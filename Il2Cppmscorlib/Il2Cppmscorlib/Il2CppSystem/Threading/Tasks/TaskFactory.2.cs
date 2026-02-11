using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020001E6 RID: 486
	public class TaskFactory : Object
	{
		// Token: 0x06001FD3 RID: 8147 RVA: 0x000B6A20 File Offset: 0x000B4C20
		// Note: this type is marked as 'beforefieldinit'.
		static TaskFactory()
		{
			Il2CppClassPointerStore<TaskFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr);
			TaskFactory.NativeFieldInfoPtr_m_defaultCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultCancellationToken");
			TaskFactory.NativeFieldInfoPtr_m_defaultScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultScheduler");
			TaskFactory.NativeFieldInfoPtr_m_defaultCreationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultCreationOptions");
			TaskFactory.NativeFieldInfoPtr_m_defaultContinuationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultContinuationOptions");
			TaskFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668703);
			TaskFactory.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668704);
			TaskFactory.NativeMethodInfoPtr_CheckCreationOptions_Internal_Static_Void_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668705);
			TaskFactory.NativeMethodInfoPtr_StartNew_Public_Task_Action_CancellationToken_TaskCreationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668706);
			TaskFactory.NativeMethodInfoPtr_StartNew_Public_Task_Action_1_Object_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668707);
			TaskFactory.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668708);
			TaskFactory.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668709);
			TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668710);
			TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668711);
			TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668712);
			TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668713);
			TaskFactory.NativeMethodInfoPtr_CheckFromAsyncOptions_Internal_Static_Void_TaskCreationOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668714);
			TaskFactory.NativeMethodInfoPtr_CommonCWAnyLogic_Internal_Static_Task_1_Task_IList_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668715);
			TaskFactory.NativeMethodInfoPtr_CheckMultiTaskContinuationOptions_Internal_Static_Void_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100668716);
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x000B6BB8 File Offset: 0x000B4DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361788, XrefRangeEnd = 1361791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x000B6BF4 File Offset: 0x000B4DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361791, XrefRangeEnd = 1361794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x000B6C74 File Offset: 0x000B4E74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1361794, RefRangeEnd = 1361796, XrefRangeStart = 1361794, XrefRangeEnd = 1361794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckCreationOptions(TaskCreationOptions creationOptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref creationOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_CheckCreationOptions_Internal_Static_Void_TaskCreationOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x000B6CA8 File Offset: 0x000B4EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361796, XrefRangeEnd = 1361807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task StartNew(Action action, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_StartNew_Public_Task_Action_CancellationToken_TaskCreationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001FD8 RID: 8152 RVA: 0x000B6D30 File Offset: 0x000B4F30
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1361818, RefRangeEnd = 1361824, XrefRangeStart = 1361807, XrefRangeEnd = 1361818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task StartNew(Action<Object> action, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_StartNew_Public_Task_Action_1_Object_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x000B6DCC File Offset: 0x000B4FCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1361830, RefRangeEnd = 1361832, XrefRangeStart = 1361824, XrefRangeEnd = 1361830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.MethodInfoStoreGeneric_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0<TResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x000B6E54 File Offset: 0x000B5054
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361838, RefRangeEnd = 1361839, XrefRangeStart = 1361832, XrefRangeEnd = 1361838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> StartNew<TResult>(Func<Object, TResult> function, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.MethodInfoStoreGeneric_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0<TResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x000B6EF0 File Offset: 0x000B50F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361842, RefRangeEnd = 1361843, XrefRangeStart = 1361839, XrefRangeEnd = 1361842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, Object state)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory.MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0<TArg1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task>(intPtr4) : null;
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x000B6FB0 File Offset: 0x000B51B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361843, XrefRangeEnd = 1361845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, Object state, TaskCreationOptions creationOptions)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory.MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0<TArg1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task>(intPtr4) : null;
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x000B707C File Offset: 0x000B527C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1361848, RefRangeEnd = 1361849, XrefRangeStart = 1361845, XrefRangeEnd = 1361848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, Object state)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TaskFactory.MethodInfoStoreGeneric_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_0<TArg1, TArg2>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Task>(intPtr5) : null;
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x000B7184 File Offset: 0x000B5384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361849, XrefRangeEnd = 1361851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, Object state, TaskCreationOptions creationOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TaskFactory.MethodInfoStoreGeneric_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0<TArg1, TArg2>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Task>(intPtr5) : null;
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x000B7298 File Offset: 0x000B5498
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1361851, RefRangeEnd = 1361854, XrefRangeStart = 1361851, XrefRangeEnd = 1361851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref creationOptions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeginMethod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_CheckFromAsyncOptions_Internal_Static_Void_TaskCreationOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x000B72D8 File Offset: 0x000B54D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1361884, RefRangeEnd = 1361886, XrefRangeStart = 1361854, XrefRangeEnd = 1361884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Task> CommonCWAnyLogic(IList<Task> tasks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_CommonCWAnyLogic_Internal_Static_Task_1_Task_IList_1_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Task>>(intPtr3) : null;
			}
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x000B731C File Offset: 0x000B551C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1361886, RefRangeEnd = 1361888, XrefRangeStart = 1361886, XrefRangeEnd = 1361886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continuationOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_CheckMultiTaskContinuationOptions_Internal_Static_Void_TaskContinuationOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0000A577 File Offset: 0x00008777
		public TaskFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x000B7350 File Offset: 0x000B5550
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x0000A580 File Offset: 0x00008780
		public CancellationToken m_defaultCancellationToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultCancellationToken);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x000B7380 File Offset: 0x000B5580
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x0000A5AE File Offset: 0x000087AE
		public unsafe TaskScheduler m_defaultScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001FE7 RID: 8167 RVA: 0x000B73B0 File Offset: 0x000B55B0
		// (set) Token: 0x06001FE8 RID: 8168 RVA: 0x0000A5CD File Offset: 0x000087CD
		public unsafe TaskCreationOptions m_defaultCreationOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultCreationOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultCreationOptions)) = value;
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x000B73D8 File Offset: 0x000B55D8
		// (set) Token: 0x06001FEA RID: 8170 RVA: 0x0000A5E8 File Offset: 0x000087E8
		public unsafe TaskContinuationOptions m_defaultContinuationOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultContinuationOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultContinuationOptions)) = value;
			}
		}

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultCancellationToken;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultScheduler;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultCreationOptions;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultContinuationOptions;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr_CheckCreationOptions_Internal_Static_Void_TaskCreationOptions_0;

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Task_Action_CancellationToken_TaskCreationOptions_TaskScheduler_0;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Task_Action_1_Object_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0;

		// Token: 0x04001C5C RID: 7260
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0;

		// Token: 0x04001C5D RID: 7261
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0;

		// Token: 0x04001C5E RID: 7262
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_0;

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0;

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeMethodInfoPtr_CheckFromAsyncOptions_Internal_Static_Void_TaskCreationOptions_Boolean_0;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeMethodInfoPtr_CommonCWAnyLogic_Internal_Static_Task_1_Task_IList_1_Task_0;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeMethodInfoPtr_CheckMultiTaskContinuationOptions_Internal_Static_Void_TaskContinuationOptions_0;

		// Token: 0x02000642 RID: 1602
		public sealed class CompleteOnInvokePromise : Task<Task>
		{
			// Token: 0x0600598A RID: 22922 RVA: 0x0019A3DC File Offset: 0x001985DC
			// Note: this type is marked as 'beforefieldinit'.
			static CompleteOnInvokePromise()
			{
				Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "CompleteOnInvokePromise");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr);
				TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr__tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr, "_tasks");
				TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr__ctor_Public_Void_IList_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr, 100668717);
				TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr, 100668718);
				TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr, 100668719);
			}

			// Token: 0x0600598B RID: 22923 RVA: 0x0019A458 File Offset: 0x00198658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1361758, XrefRangeEnd = 1361769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CompleteOnInvokePromise(IList<Task> tasks)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr__ctor_Public_Void_IList_1_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600598C RID: 22924 RVA: 0x0019A4A4 File Offset: 0x001986A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1361787, RefRangeEnd = 1361788, XrefRangeStart = 1361769, XrefRangeEnd = 1361787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Task completingTask)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170016D4 RID: 5844
			// (get) Token: 0x0600598D RID: 22925 RVA: 0x0019A4E8 File Offset: 0x001986E8
			public unsafe bool InvokeMayRunArbitraryCode
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600598E RID: 22926 RVA: 0x000200C5 File Offset: 0x0001E2C5
			public CompleteOnInvokePromise(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170016D3 RID: 5843
			// (get) Token: 0x0600598F RID: 22927 RVA: 0x0019A524 File Offset: 0x00198724
			// (set) Token: 0x06005990 RID: 22928 RVA: 0x000200CE File Offset: 0x0001E2CE
			public unsafe IList<Task> _tasks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr__tasks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Task>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr__tasks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004964 RID: 18788
			private static readonly IntPtr NativeFieldInfoPtr__tasks;

			// Token: 0x04004965 RID: 18789
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_Task_0;

			// Token: 0x04004966 RID: 18790
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0;

			// Token: 0x04004967 RID: 18791
			private static readonly IntPtr NativeMethodInfoPtr_get_InvokeMayRunArbitraryCode_Public_Virtual_Final_New_get_Boolean_0;
		}

		// Token: 0x02000643 RID: 1603
		private sealed class MethodInfoStoreGeneric_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0<TResult>
		{
			// Token: 0x04004968 RID: 18792
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000644 RID: 1604
		private sealed class MethodInfoStoreGeneric_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0<TResult>
		{
			// Token: 0x04004969 RID: 18793
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000645 RID: 1605
		private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0<TArg1>
		{
			// Token: 0x0400496A RID: 18794
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)) }))));
		}

		// Token: 0x02000646 RID: 1606
		private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0<TArg1>
		{
			// Token: 0x0400496B RID: 18795
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)) }))));
		}

		// Token: 0x02000647 RID: 1607
		private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_0<TArg1, TArg2>
		{
			// Token: 0x0400496C RID: 18796
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg2>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000648 RID: 1608
		private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0<TArg1, TArg2>
		{
			// Token: 0x0400496D RID: 18797
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_5_TArg1_TArg2_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_TArg2_Object_TaskCreationOptions_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg2>.NativeClassPtr))
			}))));
		}
	}
}
