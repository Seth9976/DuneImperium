using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001A3 RID: 419
	public class SemaphoreSlim : Object
	{
		// Token: 0x06001B29 RID: 6953 RVA: 0x000A42E0 File Offset: 0x000A24E0
		// Note: this type is marked as 'beforefieldinit'.
		static SemaphoreSlim()
		{
			Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SemaphoreSlim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr);
			SemaphoreSlim.NativeFieldInfoPtr_m_currentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_currentCount");
			SemaphoreSlim.NativeFieldInfoPtr_m_maxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_maxCount");
			SemaphoreSlim.NativeFieldInfoPtr_m_waitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_waitCount");
			SemaphoreSlim.NativeFieldInfoPtr_m_lockObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_lockObj");
			SemaphoreSlim.NativeFieldInfoPtr_m_waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_waitHandle");
			SemaphoreSlim.NativeFieldInfoPtr_m_asyncHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_asyncHead");
			SemaphoreSlim.NativeFieldInfoPtr_m_asyncTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_asyncTail");
			SemaphoreSlim.NativeFieldInfoPtr_s_trueTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "s_trueTask");
			SemaphoreSlim.NativeFieldInfoPtr_s_falseTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "s_falseTask");
			SemaphoreSlim.NativeFieldInfoPtr_s_cancellationTokenCanceledEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "s_cancellationTokenCanceledEventHandler");
			SemaphoreSlim.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667984);
			SemaphoreSlim.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667985);
			SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667986);
			SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667987);
			SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667988);
			SemaphoreSlim.NativeMethodInfoPtr_WaitUntilCountOrTimeout_Private_Boolean_Int32_UInt32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667989);
			SemaphoreSlim.NativeMethodInfoPtr_WaitAsync_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667990);
			SemaphoreSlim.NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667991);
			SemaphoreSlim.NativeMethodInfoPtr_CreateAndAddAsyncWaiter_Private_TaskNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667992);
			SemaphoreSlim.NativeMethodInfoPtr_RemoveAsyncWaiter_Private_Boolean_TaskNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667993);
			SemaphoreSlim.NativeMethodInfoPtr_WaitUntilCountOrTimeoutAsync_Private_Task_1_Boolean_TaskNode_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667994);
			SemaphoreSlim.NativeMethodInfoPtr_Release_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667995);
			SemaphoreSlim.NativeMethodInfoPtr_Release_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667996);
			SemaphoreSlim.NativeMethodInfoPtr_QueueWaiterTask_Private_Static_Void_TaskNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667997);
			SemaphoreSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667998);
			SemaphoreSlim.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100667999);
			SemaphoreSlim.NativeMethodInfoPtr_CancellationTokenCanceledEventHandler_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100668000);
			SemaphoreSlim.NativeMethodInfoPtr_CheckDispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100668001);
			SemaphoreSlim.NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100668002);
		}

		// Token: 0x06001B2A RID: 6954 RVA: 0x000A4554 File Offset: 0x000A2754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353122, XrefRangeEnd = 1353123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreSlim(int initialCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x000A459C File Offset: 0x000A279C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1353130, RefRangeEnd = 1353138, XrefRangeStart = 1353123, XrefRangeEnd = 1353130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreSlim(int initialCount, int maxCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2C RID: 6956 RVA: 0x000A45F4 File Offset: 0x000A27F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1353165, RefRangeEnd = 1353167, XrefRangeStart = 1353138, XrefRangeEnd = 1353165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x000A4628 File Offset: 0x000A2828
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1353168, RefRangeEnd = 1353170, XrefRangeStart = 1353167, XrefRangeEnd = 1353168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B2E RID: 6958 RVA: 0x000A4674 File Offset: 0x000A2874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1353183, RefRangeEnd = 1353185, XrefRangeStart = 1353170, XrefRangeEnd = 1353183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x000A46D4 File Offset: 0x000A28D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353185, XrefRangeEnd = 1353196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_WaitUntilCountOrTimeout_Private_Boolean_Int32_UInt32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x000A4744 File Offset: 0x000A2944
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1353197, RefRangeEnd = 1353204, XrefRangeStart = 1353196, XrefRangeEnd = 1353197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WaitAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_WaitAsync_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x000A4784 File Offset: 0x000A2984
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1353216, RefRangeEnd = 1353217, XrefRangeStart = 1353204, XrefRangeEnd = 1353216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x000A47E8 File Offset: 0x000A29E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353217, XrefRangeEnd = 1353227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_CreateAndAddAsyncWaiter_Private_TaskNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr3) : null;
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x000A4828 File Offset: 0x000A2A28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1353234, RefRangeEnd = 1353236, XrefRangeStart = 1353227, XrefRangeEnd = 1353234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_RemoveAsyncWaiter_Private_Boolean_TaskNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x000A4878 File Offset: 0x000A2A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353236, XrefRangeEnd = 1353252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncWaiter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_WaitUntilCountOrTimeoutAsync_Private_Task_1_Boolean_TaskNode_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x000A48F0 File Offset: 0x000A2AF0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1353253, RefRangeEnd = 1353265, XrefRangeStart = 1353252, XrefRangeEnd = 1353253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Release_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x000A492C File Offset: 0x000A2B2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1353285, RefRangeEnd = 1353286, XrefRangeStart = 1353265, XrefRangeEnd = 1353285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Release(int releaseCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref releaseCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Release_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x000A4978 File Offset: 0x000A2B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353286, XrefRangeEnd = 1353287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waiterTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_QueueWaiterTask_Private_Static_Void_TaskNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x000A49B0 File Offset: 0x000A2BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353287, XrefRangeEnd = 1353291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x000A49E4 File Offset: 0x000A2BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353291, XrefRangeEnd = 1353298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SemaphoreSlim.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x000A4A30 File Offset: 0x000A2C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353298, XrefRangeEnd = 1353306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancellationTokenCanceledEventHandler(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_CancellationTokenCanceledEventHandler_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x000A4A68 File Offset: 0x000A2C68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1353306, RefRangeEnd = 1353309, XrefRangeStart = 1353306, XrefRangeEnd = 1353306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_CheckDispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x000A4A9C File Offset: 0x000A2C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353309, XrefRangeEnd = 1353310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00008BA0 File Offset: 0x00006DA0
		public SemaphoreSlim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x000A4AD8 File Offset: 0x000A2CD8
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x00008BA9 File Offset: 0x00006DA9
		public unsafe int m_currentCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_currentCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_currentCount)) = value;
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x000A4B00 File Offset: 0x000A2D00
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x00008BC4 File Offset: 0x00006DC4
		public unsafe int m_maxCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_maxCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_maxCount)) = value;
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x000A4B28 File Offset: 0x000A2D28
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x00008BDF File Offset: 0x00006DDF
		public unsafe int m_waitCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_waitCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_waitCount)) = value;
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x000A4B50 File Offset: 0x000A2D50
		// (set) Token: 0x06001B45 RID: 6981 RVA: 0x00008BFA File Offset: 0x00006DFA
		public unsafe Object m_lockObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_lockObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_lockObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x000A4B80 File Offset: 0x000A2D80
		// (set) Token: 0x06001B47 RID: 6983 RVA: 0x00008C19 File Offset: 0x00006E19
		public unsafe ManualResetEvent m_waitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_waitHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_waitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x000A4BB0 File Offset: 0x000A2DB0
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x00008C38 File Offset: 0x00006E38
		public unsafe SemaphoreSlim.TaskNode m_asyncHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_asyncHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_asyncHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x000A4BE0 File Offset: 0x000A2DE0
		// (set) Token: 0x06001B4B RID: 6987 RVA: 0x00008C57 File Offset: 0x00006E57
		public unsafe SemaphoreSlim.TaskNode m_asyncTail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_asyncTail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_asyncTail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x000A4C10 File Offset: 0x000A2E10
		// (set) Token: 0x06001B4D RID: 6989 RVA: 0x00008C76 File Offset: 0x00006E76
		public unsafe static Task<bool> s_trueTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SemaphoreSlim.NativeFieldInfoPtr_s_trueTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SemaphoreSlim.NativeFieldInfoPtr_s_trueTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001B4E RID: 6990 RVA: 0x000A4C38 File Offset: 0x000A2E38
		// (set) Token: 0x06001B4F RID: 6991 RVA: 0x00008C88 File Offset: 0x00006E88
		public unsafe static Task<bool> s_falseTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SemaphoreSlim.NativeFieldInfoPtr_s_falseTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SemaphoreSlim.NativeFieldInfoPtr_s_falseTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x000A4C60 File Offset: 0x000A2E60
		// (set) Token: 0x06001B51 RID: 6993 RVA: 0x00008C9A File Offset: 0x00006E9A
		public unsafe static Action<Object> s_cancellationTokenCanceledEventHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SemaphoreSlim.NativeFieldInfoPtr_s_cancellationTokenCanceledEventHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SemaphoreSlim.NativeFieldInfoPtr_s_cancellationTokenCanceledEventHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040018E3 RID: 6371
		private static readonly IntPtr NativeFieldInfoPtr_m_currentCount;

		// Token: 0x040018E4 RID: 6372
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCount;

		// Token: 0x040018E5 RID: 6373
		private static readonly IntPtr NativeFieldInfoPtr_m_waitCount;

		// Token: 0x040018E6 RID: 6374
		private static readonly IntPtr NativeFieldInfoPtr_m_lockObj;

		// Token: 0x040018E7 RID: 6375
		private static readonly IntPtr NativeFieldInfoPtr_m_waitHandle;

		// Token: 0x040018E8 RID: 6376
		private static readonly IntPtr NativeFieldInfoPtr_m_asyncHead;

		// Token: 0x040018E9 RID: 6377
		private static readonly IntPtr NativeFieldInfoPtr_m_asyncTail;

		// Token: 0x040018EA RID: 6378
		private static readonly IntPtr NativeFieldInfoPtr_s_trueTask;

		// Token: 0x040018EB RID: 6379
		private static readonly IntPtr NativeFieldInfoPtr_s_falseTask;

		// Token: 0x040018EC RID: 6380
		private static readonly IntPtr NativeFieldInfoPtr_s_cancellationTokenCanceledEventHandler;

		// Token: 0x040018ED RID: 6381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040018EE RID: 6382
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040018EF RID: 6383
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Void_0;

		// Token: 0x040018F0 RID: 6384
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0;

		// Token: 0x040018F1 RID: 6385
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0;

		// Token: 0x040018F2 RID: 6386
		private static readonly IntPtr NativeMethodInfoPtr_WaitUntilCountOrTimeout_Private_Boolean_Int32_UInt32_CancellationToken_0;

		// Token: 0x040018F3 RID: 6387
		private static readonly IntPtr NativeMethodInfoPtr_WaitAsync_Public_Task_0;

		// Token: 0x040018F4 RID: 6388
		private static readonly IntPtr NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_CancellationToken_0;

		// Token: 0x040018F5 RID: 6389
		private static readonly IntPtr NativeMethodInfoPtr_CreateAndAddAsyncWaiter_Private_TaskNode_0;

		// Token: 0x040018F6 RID: 6390
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAsyncWaiter_Private_Boolean_TaskNode_0;

		// Token: 0x040018F7 RID: 6391
		private static readonly IntPtr NativeMethodInfoPtr_WaitUntilCountOrTimeoutAsync_Private_Task_1_Boolean_TaskNode_Int32_CancellationToken_0;

		// Token: 0x040018F8 RID: 6392
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Int32_0;

		// Token: 0x040018F9 RID: 6393
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Int32_Int32_0;

		// Token: 0x040018FA RID: 6394
		private static readonly IntPtr NativeMethodInfoPtr_QueueWaiterTask_Private_Static_Void_TaskNode_0;

		// Token: 0x040018FB RID: 6395
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040018FC RID: 6396
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x040018FD RID: 6397
		private static readonly IntPtr NativeMethodInfoPtr_CancellationTokenCanceledEventHandler_Private_Static_Void_Object_0;

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeMethodInfoPtr_CheckDispose_Private_Void_0;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0;

		// Token: 0x02000609 RID: 1545
		public sealed class TaskNode : Task<bool>
		{
			// Token: 0x0600583E RID: 22590 RVA: 0x0019613C File Offset: 0x0019433C
			// Note: this type is marked as 'beforefieldinit'.
			static TaskNode()
			{
				Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "TaskNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr);
				SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, "Prev");
				SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, "Next");
				SemaphoreSlim.TaskNode.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, 100668004);
				SemaphoreSlim.TaskNode.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, 100668005);
				SemaphoreSlim.TaskNode.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, 100668006);
			}

			// Token: 0x0600583F RID: 22591 RVA: 0x001961CC File Offset: 0x001943CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353028, XrefRangeEnd = 1353031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TaskNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.TaskNode.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005840 RID: 22592 RVA: 0x00196208 File Offset: 0x00194408
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353031, XrefRangeEnd = 1353034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.TaskNode.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005841 RID: 22593 RVA: 0x0019623C File Offset: 0x0019443C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.TaskNode.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005842 RID: 22594 RVA: 0x0001F5CB File Offset: 0x0001D7CB
			public TaskNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700167C RID: 5756
			// (get) Token: 0x06005843 RID: 22595 RVA: 0x00196280 File Offset: 0x00194480
			// (set) Token: 0x06005844 RID: 22596 RVA: 0x0001F5D4 File Offset: 0x0001D7D4
			public unsafe SemaphoreSlim.TaskNode Prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700167D RID: 5757
			// (get) Token: 0x06005845 RID: 22597 RVA: 0x001962B0 File Offset: 0x001944B0
			// (set) Token: 0x06005846 RID: 22598 RVA: 0x0001F5F3 File Offset: 0x0001D7F3
			public unsafe SemaphoreSlim.TaskNode Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400489A RID: 18586
			private static readonly IntPtr NativeFieldInfoPtr_Prev;

			// Token: 0x0400489B RID: 18587
			private static readonly IntPtr NativeFieldInfoPtr_Next;

			// Token: 0x0400489C RID: 18588
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x0400489D RID: 18589
			private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400489E RID: 18590
			private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;
		}

		// Token: 0x0200060A RID: 1546
		[ObfuscatedName("System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__32")]
		public sealed class _WaitUntilCountOrTimeoutAsync_d__32 : ValueType
		{
			// Token: 0x06005847 RID: 22599 RVA: 0x001962E0 File Offset: 0x001944E0
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitUntilCountOrTimeoutAsync_d__32()
			{
				Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "<WaitUntilCountOrTimeoutAsync>d__32");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr);
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr, "<>1__state");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr, "<>t__builder");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr, "cancellationToken");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr_asyncWaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr, "asyncWaiter");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr_millisecondsTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr, "millisecondsTimeout");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr, "<>4__this");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr__cts_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr, "<cts>5__2");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr, "<>7__wrap2");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr, "<>u__1");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr, "<>u__2");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr, 100668007);
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr, 100668008);
			}

			// Token: 0x06005848 RID: 22600 RVA: 0x001963FC File Offset: 0x001945FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353034, XrefRangeEnd = 1353116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005849 RID: 22601 RVA: 0x00196434 File Offset: 0x00194634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1353116, XrefRangeEnd = 1353122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600584A RID: 22602 RVA: 0x0001F612 File Offset: 0x0001D812
			public _WaitUntilCountOrTimeoutAsync_d__32(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600584B RID: 22603 RVA: 0x0001F61B File Offset: 0x0001D81B
			public _WaitUntilCountOrTimeoutAsync_d__32()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32>.NativeClassPtr))
			{
			}

			// Token: 0x1700167E RID: 5758
			// (get) Token: 0x0600584C RID: 22604 RVA: 0x0019647C File Offset: 0x0019467C
			// (set) Token: 0x0600584D RID: 22605 RVA: 0x0001F62D File Offset: 0x0001D82D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700167F RID: 5759
			// (get) Token: 0x0600584E RID: 22606 RVA: 0x001964A4 File Offset: 0x001946A4
			// (set) Token: 0x0600584F RID: 22607 RVA: 0x0001F648 File Offset: 0x0001D848
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001680 RID: 5760
			// (get) Token: 0x06005850 RID: 22608 RVA: 0x001964D4 File Offset: 0x001946D4
			// (set) Token: 0x06005851 RID: 22609 RVA: 0x0001F676 File Offset: 0x0001D876
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001681 RID: 5761
			// (get) Token: 0x06005852 RID: 22610 RVA: 0x00196504 File Offset: 0x00194704
			// (set) Token: 0x06005853 RID: 22611 RVA: 0x0001F6A4 File Offset: 0x0001D8A4
			public unsafe SemaphoreSlim.TaskNode asyncWaiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr_asyncWaiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr_asyncWaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001682 RID: 5762
			// (get) Token: 0x06005854 RID: 22612 RVA: 0x00196534 File Offset: 0x00194734
			// (set) Token: 0x06005855 RID: 22613 RVA: 0x0001F6C3 File Offset: 0x0001D8C3
			public unsafe int millisecondsTimeout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr_millisecondsTimeout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr_millisecondsTimeout)) = value;
				}
			}

			// Token: 0x17001683 RID: 5763
			// (get) Token: 0x06005856 RID: 22614 RVA: 0x0019655C File Offset: 0x0019475C
			// (set) Token: 0x06005857 RID: 22615 RVA: 0x0001F6DE File Offset: 0x0001D8DE
			public unsafe SemaphoreSlim __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001684 RID: 5764
			// (get) Token: 0x06005858 RID: 22616 RVA: 0x0019658C File Offset: 0x0019478C
			// (set) Token: 0x06005859 RID: 22617 RVA: 0x0001F6FD File Offset: 0x0001D8FD
			public unsafe CancellationTokenSource _cts_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr__cts_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr__cts_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001685 RID: 5765
			// (get) Token: 0x0600585A RID: 22618 RVA: 0x001965BC File Offset: 0x001947BC
			// (set) Token: 0x0600585B RID: 22619 RVA: 0x0001F71C File Offset: 0x0001D91C
			public unsafe Object __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001686 RID: 5766
			// (get) Token: 0x0600585C RID: 22620 RVA: 0x001965EC File Offset: 0x001947EC
			// (set) Token: 0x0600585D RID: 22621 RVA: 0x0001F73B File Offset: 0x0001D93B
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001687 RID: 5767
			// (get) Token: 0x0600585E RID: 22622 RVA: 0x0019661C File Offset: 0x0019481C
			// (set) Token: 0x0600585F RID: 22623 RVA: 0x0001F769 File Offset: 0x0001D969
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__32.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400489F RID: 18591
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040048A0 RID: 18592
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040048A1 RID: 18593
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040048A2 RID: 18594
			private static readonly IntPtr NativeFieldInfoPtr_asyncWaiter;

			// Token: 0x040048A3 RID: 18595
			private static readonly IntPtr NativeFieldInfoPtr_millisecondsTimeout;

			// Token: 0x040048A4 RID: 18596
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040048A5 RID: 18597
			private static readonly IntPtr NativeFieldInfoPtr__cts_5__2;

			// Token: 0x040048A6 RID: 18598
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040048A7 RID: 18599
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040048A8 RID: 18600
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040048A9 RID: 18601
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040048AA RID: 18602
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
