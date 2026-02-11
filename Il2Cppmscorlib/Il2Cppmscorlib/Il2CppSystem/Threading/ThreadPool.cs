using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001BA RID: 442
	public static class ThreadPool : Object
	{
		// Token: 0x06001CAD RID: 7341 RVA: 0x000A9C40 File Offset: 0x000A7E40
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPool()
		{
			Il2CppClassPointerStore<ThreadPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr);
			ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Private_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_UInt32_Boolean_byref_StackCrawlMark_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668231);
			ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Public_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668232);
			ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Public_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668233);
			ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668234);
			ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668235);
			ThreadPool.NativeMethodInfoPtr_UnsafeQueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668236);
			ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_Action_1_TState_TState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668237);
			ThreadPool.NativeMethodInfoPtr_QueueUserWorkItemHelper_Private_Static_Boolean_WaitCallback_Object_byref_StackCrawlMark_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668238);
			ThreadPool.NativeMethodInfoPtr_UnsafeQueueCustomWorkItem_Internal_Static_Void_IThreadPoolWorkItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668239);
			ThreadPool.NativeMethodInfoPtr_TryPopCustomWorkItem_Internal_Static_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668240);
			ThreadPool.NativeMethodInfoPtr_RequestWorkerThread_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668241);
			ThreadPool.NativeMethodInfoPtr_EnsureVMInitialized_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668242);
			ThreadPool.NativeMethodInfoPtr_NotifyWorkItemComplete_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668243);
			ThreadPool.NativeMethodInfoPtr_ReportThreadStatus_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668244);
			ThreadPool.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668245);
			ThreadPool.NativeMethodInfoPtr_NotifyWorkItemProgressNative_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668246);
			ThreadPool.NativeMethodInfoPtr_NotifyWorkItemQueued_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668247);
			ThreadPool.NativeMethodInfoPtr_InitializeVMTp_Private_Static_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668248);
			ThreadPool.NativeMethodInfoPtr_get_IsThreadPoolThread_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100668249);
		}

		// Token: 0x06001CAE RID: 7342 RVA: 0x000A9DEC File Offset: 0x000A7FEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1356823, RefRangeEnd = 1356825, XrefRangeStart = 1356800, XrefRangeEnd = 1356823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, Object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeOutInterval;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref executeOnlyOnce;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compressStack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Private_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_UInt32_Boolean_byref_StackCrawlMark_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegisteredWaitHandle>(intPtr3) : null;
		}

		// Token: 0x06001CAF RID: 7343 RVA: 0x000A9E90 File Offset: 0x000A8090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356825, XrefRangeEnd = 1356826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, Object state, int millisecondsTimeOutInterval, bool executeOnlyOnce)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeOutInterval;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref executeOnlyOnce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Public_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegisteredWaitHandle>(intPtr3) : null;
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x000A9F14 File Offset: 0x000A8114
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1356831, RefRangeEnd = 1356833, XrefRangeStart = 1356826, XrefRangeEnd = 1356831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, Object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref executeOnlyOnce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Public_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegisteredWaitHandle>(intPtr3) : null;
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x000A9F98 File Offset: 0x000A8198
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1356834, RefRangeEnd = 1356842, XrefRangeStart = 1356833, XrefRangeEnd = 1356834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueueUserWorkItem(WaitCallback callBack, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x000A9FEC File Offset: 0x000A81EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1356843, RefRangeEnd = 1356844, XrefRangeStart = 1356842, XrefRangeEnd = 1356843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueueUserWorkItem(WaitCallback callBack)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x000AA030 File Offset: 0x000A8230
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1356845, RefRangeEnd = 1356854, XrefRangeStart = 1356844, XrefRangeEnd = 1356845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnsafeQueueUserWorkItem(WaitCallback callBack, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_UnsafeQueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB4 RID: 7348 RVA: 0x000AA084 File Offset: 0x000A8284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356854, XrefRangeEnd = 1356864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TState).IsValueType)
			{
				TState tstate = state;
				intPtr = ((tstate is string) ? IL2CPP.ManagedStringToIl2Cpp(tstate as string) : IL2CPP.Il2CppObjectBaseToPtr(tstate as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref state;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preferLocal;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ThreadPool.MethodInfoStoreGeneric_QueueUserWorkItem_Public_Static_Boolean_Action_1_TState_TState_Boolean_0<TState>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x000AA11C File Offset: 0x000A831C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1356868, RefRangeEnd = 1356872, XrefRangeStart = 1356864, XrefRangeEnd = 1356868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueueUserWorkItemHelper(WaitCallback callBack, Object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = true)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compressStack;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceGlobal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_QueueUserWorkItemHelper_Private_Static_Boolean_WaitCallback_Object_byref_StackCrawlMark_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x000AA19C File Offset: 0x000A839C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1356877, RefRangeEnd = 1356882, XrefRangeStart = 1356872, XrefRangeEnd = 1356877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(workItem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceGlobal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_UnsafeQueueCustomWorkItem_Internal_Static_Void_IThreadPoolWorkItem_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000AA1E0 File Offset: 0x000A83E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1356894, RefRangeEnd = 1356896, XrefRangeStart = 1356882, XrefRangeEnd = 1356894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(workItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_TryPopCustomWorkItem_Internal_Static_Boolean_IThreadPoolWorkItem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000AA224 File Offset: 0x000A8424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356896, XrefRangeEnd = 1356897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestWorkerThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_RequestWorkerThread_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x000AA254 File Offset: 0x000A8454
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1356908, RefRangeEnd = 1356912, XrefRangeStart = 1356897, XrefRangeEnd = 1356908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureVMInitialized()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_EnsureVMInitialized_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x000AA27C File Offset: 0x000A847C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356912, XrefRangeEnd = 1356913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NotifyWorkItemComplete()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_NotifyWorkItemComplete_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x000AA2AC File Offset: 0x000A84AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356913, XrefRangeEnd = 1356914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportThreadStatus(bool isWorking)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isWorking;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_ReportThreadStatus_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x000AA2E0 File Offset: 0x000A84E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356914, XrefRangeEnd = 1356916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyWorkItemProgress()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x000AA308 File Offset: 0x000A8508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356916, XrefRangeEnd = 1356917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyWorkItemProgressNative()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_NotifyWorkItemProgressNative_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x000AA330 File Offset: 0x000A8530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyWorkItemQueued()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_NotifyWorkItemQueued_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x000AA358 File Offset: 0x000A8558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356917, XrefRangeEnd = 1356918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeVMTp(ref bool enableWorkerTracking)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &enableWorkerTracking;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_InitializeVMTp_Private_Static_Void_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x000AA38C File Offset: 0x000A858C
		public unsafe static bool IsThreadPoolThread
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356918, XrefRangeEnd = 1356923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_get_IsThreadPoolThread_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x000093BF File Offset: 0x000075BF
		public ThreadPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040019FA RID: 6650
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWaitForSingleObject_Private_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_UInt32_Boolean_byref_StackCrawlMark_Boolean_0;

		// Token: 0x040019FB RID: 6651
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWaitForSingleObject_Public_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_Int32_Boolean_0;

		// Token: 0x040019FC RID: 6652
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWaitForSingleObject_Public_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0;

		// Token: 0x040019FD RID: 6653
		private static readonly IntPtr NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0;

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_0;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeQueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_Action_1_TState_TState_Boolean_0;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeMethodInfoPtr_QueueUserWorkItemHelper_Private_Static_Boolean_WaitCallback_Object_byref_StackCrawlMark_Boolean_Boolean_0;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeQueueCustomWorkItem_Internal_Static_Void_IThreadPoolWorkItem_Boolean_0;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeMethodInfoPtr_TryPopCustomWorkItem_Internal_Static_Boolean_IThreadPoolWorkItem_0;

		// Token: 0x04001A04 RID: 6660
		private static readonly IntPtr NativeMethodInfoPtr_RequestWorkerThread_Internal_Static_Boolean_0;

		// Token: 0x04001A05 RID: 6661
		private static readonly IntPtr NativeMethodInfoPtr_EnsureVMInitialized_Private_Static_Void_0;

		// Token: 0x04001A06 RID: 6662
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemComplete_Internal_Static_Boolean_0;

		// Token: 0x04001A07 RID: 6663
		private static readonly IntPtr NativeMethodInfoPtr_ReportThreadStatus_Internal_Static_Void_Boolean_0;

		// Token: 0x04001A08 RID: 6664
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Static_Void_0;

		// Token: 0x04001A09 RID: 6665
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemProgressNative_Internal_Static_Void_0;

		// Token: 0x04001A0A RID: 6666
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemQueued_Internal_Static_Void_0;

		// Token: 0x04001A0B RID: 6667
		private static readonly IntPtr NativeMethodInfoPtr_InitializeVMTp_Private_Static_Void_byref_Boolean_0;

		// Token: 0x04001A0C RID: 6668
		private static readonly IntPtr NativeMethodInfoPtr_get_IsThreadPoolThread_Internal_Static_get_Boolean_0;

		// Token: 0x02000615 RID: 1557
		[ObfuscatedName("System.Threading.ThreadPool+<>c__DisplayClass17_0`1")]
		public sealed class __c__DisplayClass17_0<TState> : Object
		{
			// Token: 0x060058AF RID: 22703 RVA: 0x00197708 File Offset: 0x00195908
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<ThreadPool.__c__DisplayClass17_0<TState>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, "<>c__DisplayClass17_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPool.__c__DisplayClass17_0<TState>>.NativeClassPtr);
				ThreadPool.__c__DisplayClass17_0<TState>.NativeFieldInfoPtr_callBack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPool.__c__DisplayClass17_0<TState>>.NativeClassPtr, "callBack");
				ThreadPool.__c__DisplayClass17_0<TState>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool.__c__DisplayClass17_0<TState>>.NativeClassPtr, 100668250);
				ThreadPool.__c__DisplayClass17_0<TState>.NativeMethodInfoPtr__QueueUserWorkItem_b__0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool.__c__DisplayClass17_0<TState>>.NativeClassPtr, 100668251);
			}

			// Token: 0x060058B0 RID: 22704 RVA: 0x001977AC File Offset: 0x001959AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPool.__c__DisplayClass17_0<TState>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.__c__DisplayClass17_0<TState>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058B1 RID: 22705 RVA: 0x001977E8 File Offset: 0x001959E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1356795, XrefRangeEnd = 1356800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _QueueUserWorkItem_b__0(Object x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.__c__DisplayClass17_0<TState>.NativeMethodInfoPtr__QueueUserWorkItem_b__0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058B2 RID: 22706 RVA: 0x0001F9FA File Offset: 0x0001DBFA
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700169C RID: 5788
			// (get) Token: 0x060058B3 RID: 22707 RVA: 0x0019782C File Offset: 0x00195A2C
			// (set) Token: 0x060058B4 RID: 22708 RVA: 0x0001FA03 File Offset: 0x0001DC03
			public unsafe Action<TState> callBack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPool.__c__DisplayClass17_0<TState>.NativeFieldInfoPtr_callBack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TState>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThreadPool.__c__DisplayClass17_0<TState>.NativeFieldInfoPtr_callBack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048E1 RID: 18657
			private static readonly IntPtr NativeFieldInfoPtr_callBack;

			// Token: 0x040048E2 RID: 18658
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040048E3 RID: 18659
			private static readonly IntPtr NativeMethodInfoPtr__QueueUserWorkItem_b__0_Internal_Void_Object_0;
		}

		// Token: 0x02000616 RID: 1558
		private sealed class MethodInfoStoreGeneric_QueueUserWorkItem_Public_Static_Boolean_Action_1_TState_TState_Boolean_0<TState>
		{
			// Token: 0x040048E4 RID: 18660
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_Action_1_TState_TState_Boolean_0, Il2CppClassPointerStore<ThreadPool>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TState>.NativeClassPtr)) }))));
		}
	}
}
