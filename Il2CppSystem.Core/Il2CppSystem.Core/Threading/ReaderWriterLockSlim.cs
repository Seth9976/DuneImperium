using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000135 RID: 309
	public class ReaderWriterLockSlim : Object
	{
		// Token: 0x06001232 RID: 4658 RVA: 0x0005EB28 File Offset: 0x0005CD28
		// Note: this type is marked as 'beforefieldinit'.
		static ReaderWriterLockSlim()
		{
			Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Threading", "ReaderWriterLockSlim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr);
			ReaderWriterLockSlim.NativeFieldInfoPtr_fIsReentrant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "fIsReentrant");
			ReaderWriterLockSlim.NativeFieldInfoPtr_myLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "myLock");
			ReaderWriterLockSlim.NativeFieldInfoPtr_numWriteWaiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "numWriteWaiters");
			ReaderWriterLockSlim.NativeFieldInfoPtr_numReadWaiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "numReadWaiters");
			ReaderWriterLockSlim.NativeFieldInfoPtr_numWriteUpgradeWaiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "numWriteUpgradeWaiters");
			ReaderWriterLockSlim.NativeFieldInfoPtr_numUpgradeWaiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "numUpgradeWaiters");
			ReaderWriterLockSlim.NativeFieldInfoPtr_fNoWaiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "fNoWaiters");
			ReaderWriterLockSlim.NativeFieldInfoPtr_upgradeLockOwnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "upgradeLockOwnerId");
			ReaderWriterLockSlim.NativeFieldInfoPtr_writeLockOwnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "writeLockOwnerId");
			ReaderWriterLockSlim.NativeFieldInfoPtr_writeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "writeEvent");
			ReaderWriterLockSlim.NativeFieldInfoPtr_readEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "readEvent");
			ReaderWriterLockSlim.NativeFieldInfoPtr_upgradeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "upgradeEvent");
			ReaderWriterLockSlim.NativeFieldInfoPtr_waitUpgradeEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "waitUpgradeEvent");
			ReaderWriterLockSlim.NativeFieldInfoPtr_s_nextLockID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "s_nextLockID");
			ReaderWriterLockSlim.NativeFieldInfoPtr_lockID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "lockID");
			ReaderWriterLockSlim.NativeFieldInfoPtr_t_rwc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "t_rwc");
			ReaderWriterLockSlim.NativeFieldInfoPtr_fUpgradeThreadHoldingRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "fUpgradeThreadHoldingRead");
			ReaderWriterLockSlim.NativeFieldInfoPtr_owners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "owners");
			ReaderWriterLockSlim.NativeFieldInfoPtr_fDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "fDisposed");
			ReaderWriterLockSlim.NativeMethodInfoPtr_InitializeThreadCounts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666731);
			ReaderWriterLockSlim.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666732);
			ReaderWriterLockSlim.NativeMethodInfoPtr__ctor_Public_Void_LockRecursionPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666733);
			ReaderWriterLockSlim.NativeMethodInfoPtr_IsRWEntryEmpty_Private_Static_Boolean_ReaderWriterCount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666734);
			ReaderWriterLockSlim.NativeMethodInfoPtr_IsRwHashEntryChanged_Private_Boolean_ReaderWriterCount_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666735);
			ReaderWriterLockSlim.NativeMethodInfoPtr_GetThreadRWCount_Private_ReaderWriterCount_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666736);
			ReaderWriterLockSlim.NativeMethodInfoPtr_EnterWriteLock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666737);
			ReaderWriterLockSlim.NativeMethodInfoPtr_TryEnterWriteLock_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666738);
			ReaderWriterLockSlim.NativeMethodInfoPtr_TryEnterWriteLock_Private_Boolean_TimeoutTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666739);
			ReaderWriterLockSlim.NativeMethodInfoPtr_TryEnterWriteLockCore_Private_Boolean_TimeoutTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666740);
			ReaderWriterLockSlim.NativeMethodInfoPtr_EnterUpgradeableReadLock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666741);
			ReaderWriterLockSlim.NativeMethodInfoPtr_TryEnterUpgradeableReadLock_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666742);
			ReaderWriterLockSlim.NativeMethodInfoPtr_TryEnterUpgradeableReadLock_Private_Boolean_TimeoutTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666743);
			ReaderWriterLockSlim.NativeMethodInfoPtr_TryEnterUpgradeableReadLockCore_Private_Boolean_TimeoutTracker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666744);
			ReaderWriterLockSlim.NativeMethodInfoPtr_ExitWriteLock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666745);
			ReaderWriterLockSlim.NativeMethodInfoPtr_ExitUpgradeableReadLock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666746);
			ReaderWriterLockSlim.NativeMethodInfoPtr_LazyCreateEvent_Private_Void_byref_EventWaitHandle_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666747);
			ReaderWriterLockSlim.NativeMethodInfoPtr_WaitOnEvent_Private_Boolean_EventWaitHandle_byref_UInt32_TimeoutTracker_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666748);
			ReaderWriterLockSlim.NativeMethodInfoPtr_ExitAndWakeUpAppropriateWaiters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666749);
			ReaderWriterLockSlim.NativeMethodInfoPtr_ExitAndWakeUpAppropriateWaitersPreferringWriters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666750);
			ReaderWriterLockSlim.NativeMethodInfoPtr_ExitAndWakeUpAppropriateReadWaiters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666751);
			ReaderWriterLockSlim.NativeMethodInfoPtr_IsWriterAcquired_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666752);
			ReaderWriterLockSlim.NativeMethodInfoPtr_SetWriterAcquired_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666753);
			ReaderWriterLockSlim.NativeMethodInfoPtr_ClearWriterAcquired_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666754);
			ReaderWriterLockSlim.NativeMethodInfoPtr_SetWritersWaiting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666755);
			ReaderWriterLockSlim.NativeMethodInfoPtr_ClearWritersWaiting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666756);
			ReaderWriterLockSlim.NativeMethodInfoPtr_SetUpgraderWaiting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666757);
			ReaderWriterLockSlim.NativeMethodInfoPtr_ClearUpgraderWaiting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666758);
			ReaderWriterLockSlim.NativeMethodInfoPtr_GetNumReaders_Private_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666759);
			ReaderWriterLockSlim.NativeMethodInfoPtr_EnterMyLock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666760);
			ReaderWriterLockSlim.NativeMethodInfoPtr_EnterMyLockSpin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666761);
			ReaderWriterLockSlim.NativeMethodInfoPtr_ExitMyLock_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666762);
			ReaderWriterLockSlim.NativeMethodInfoPtr_SpinWait_Private_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666763);
			ReaderWriterLockSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666764);
			ReaderWriterLockSlim.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666765);
			ReaderWriterLockSlim.NativeMethodInfoPtr_get_IsReadLockHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666766);
			ReaderWriterLockSlim.NativeMethodInfoPtr_get_IsUpgradeableReadLockHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666767);
			ReaderWriterLockSlim.NativeMethodInfoPtr_get_IsWriteLockHeld_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666768);
			ReaderWriterLockSlim.NativeMethodInfoPtr_get_RecursiveReadCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666769);
			ReaderWriterLockSlim.NativeMethodInfoPtr_get_RecursiveUpgradeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666770);
			ReaderWriterLockSlim.NativeMethodInfoPtr_get_RecursiveWriteCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666771);
			ReaderWriterLockSlim.NativeMethodInfoPtr_get_WaitingReadCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666772);
			ReaderWriterLockSlim.NativeMethodInfoPtr_get_WaitingUpgradeCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666773);
			ReaderWriterLockSlim.NativeMethodInfoPtr_get_WaitingWriteCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, 100666774);
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0005F044 File Offset: 0x0005D244
		[CallerCount(0)]
		public unsafe void InitializeThreadCounts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_InitializeThreadCounts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001234 RID: 4660 RVA: 0x0005F078 File Offset: 0x0005D278
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032078, RefRangeEnd = 1032079, XrefRangeStart = 1032074, XrefRangeEnd = 1032078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReaderWriterLockSlim()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0005F0B4 File Offset: 0x0005D2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032079, XrefRangeEnd = 1032083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recursionPolicy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr__ctor_Public_Void_LockRecursionPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0005F0FC File Offset: 0x0005D2FC
		[CallerCount(0)]
		public unsafe static bool IsRWEntryEmpty(ReaderWriterCount rwc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rwc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_IsRWEntryEmpty_Private_Static_Boolean_ReaderWriterCount_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001237 RID: 4663 RVA: 0x0005F140 File Offset: 0x0005D340
		[CallerCount(0)]
		public unsafe bool IsRwHashEntryChanged(ReaderWriterCount lrwc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lrwc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_IsRwHashEntryChanged_Private_Boolean_ReaderWriterCount_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001238 RID: 4664 RVA: 0x0005F190 File Offset: 0x0005D390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032083, XrefRangeEnd = 1032098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReaderWriterCount GetThreadRWCount(bool dontAllocate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dontAllocate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_GetThreadRWCount_Private_ReaderWriterCount_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReaderWriterCount>(intPtr3) : null;
			}
		}

		// Token: 0x06001239 RID: 4665 RVA: 0x0005F1DC File Offset: 0x0005D3DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1032099, RefRangeEnd = 1032101, XrefRangeStart = 1032098, XrefRangeEnd = 1032099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterWriteLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_EnterWriteLock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123A RID: 4666 RVA: 0x0005F210 File Offset: 0x0005D410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032101, XrefRangeEnd = 1032110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryEnterWriteLock(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_TryEnterWriteLock_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0005F25C File Offset: 0x0005D45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032110, XrefRangeEnd = 1032111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_TryEnterWriteLock_Private_Boolean_TimeoutTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0005F2A8 File Offset: 0x0005D4A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1032119, RefRangeEnd = 1032122, XrefRangeStart = 1032111, XrefRangeEnd = 1032119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_TryEnterWriteLockCore_Private_Boolean_TimeoutTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0005F2F4 File Offset: 0x0005D4F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032123, RefRangeEnd = 1032124, XrefRangeStart = 1032122, XrefRangeEnd = 1032123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterUpgradeableReadLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_EnterUpgradeableReadLock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0005F328 File Offset: 0x0005D528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032124, XrefRangeEnd = 1032133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryEnterUpgradeableReadLock(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_TryEnterUpgradeableReadLock_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0005F374 File Offset: 0x0005D574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032133, XrefRangeEnd = 1032134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_TryEnterUpgradeableReadLock_Private_Boolean_TimeoutTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0005F3C0 File Offset: 0x0005D5C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1032141, RefRangeEnd = 1032144, XrefRangeStart = 1032134, XrefRangeEnd = 1032141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_TryEnterUpgradeableReadLockCore_Private_Boolean_TimeoutTracker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0005F40C File Offset: 0x0005D60C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1032148, RefRangeEnd = 1032152, XrefRangeStart = 1032144, XrefRangeEnd = 1032148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitWriteLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_ExitWriteLock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0005F440 File Offset: 0x0005D640
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032169, RefRangeEnd = 1032170, XrefRangeStart = 1032152, XrefRangeEnd = 1032169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitUpgradeableReadLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_ExitUpgradeableReadLock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0005F474 File Offset: 0x0005D674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032170, XrefRangeEnd = 1032184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(waitEvent);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref makeAutoResetEvent;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_LazyCreateEvent_Private_Void_byref_EventWaitHandle_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			waitEvent = ((intPtr4 == 0) ? null : new EventWaitHandle(intPtr4));
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0005F4DC File Offset: 0x0005D6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032184, XrefRangeEnd = 1032191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitEvent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &numWaiters;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWriteWaiter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_WaitOnEvent_Private_Boolean_EventWaitHandle_byref_UInt32_TimeoutTracker_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0005F554 File Offset: 0x0005D754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032191, XrefRangeEnd = 1032197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitAndWakeUpAppropriateWaiters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_ExitAndWakeUpAppropriateWaiters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0005F588 File Offset: 0x0005D788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032197, XrefRangeEnd = 1032203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitAndWakeUpAppropriateWaitersPreferringWriters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_ExitAndWakeUpAppropriateWaitersPreferringWriters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0005F5BC File Offset: 0x0005D7BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1032206, RefRangeEnd = 1032208, XrefRangeStart = 1032203, XrefRangeEnd = 1032206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitAndWakeUpAppropriateReadWaiters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_ExitAndWakeUpAppropriateReadWaiters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0005F5F0 File Offset: 0x0005D7F0
		[CallerCount(0)]
		public unsafe bool IsWriterAcquired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_IsWriterAcquired_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x0005F62C File Offset: 0x0005D82C
		[CallerCount(0)]
		public unsafe void SetWriterAcquired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_SetWriterAcquired_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x0005F660 File Offset: 0x0005D860
		[CallerCount(0)]
		public unsafe void ClearWriterAcquired()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_ClearWriterAcquired_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x0005F694 File Offset: 0x0005D894
		[CallerCount(0)]
		public unsafe void SetWritersWaiting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_SetWritersWaiting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x0005F6C8 File Offset: 0x0005D8C8
		[CallerCount(0)]
		public unsafe void ClearWritersWaiting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_ClearWritersWaiting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x0005F6FC File Offset: 0x0005D8FC
		[CallerCount(0)]
		public unsafe void SetUpgraderWaiting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_SetUpgraderWaiting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x0005F730 File Offset: 0x0005D930
		[CallerCount(0)]
		public unsafe void ClearUpgraderWaiting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_ClearUpgraderWaiting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0005F764 File Offset: 0x0005D964
		[CallerCount(0)]
		public unsafe uint GetNumReaders()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_GetNumReaders_Private_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0005F7A0 File Offset: 0x0005D9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032208, XrefRangeEnd = 1032210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterMyLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_EnterMyLock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0005F7D4 File Offset: 0x0005D9D4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1032220, RefRangeEnd = 1032228, XrefRangeStart = 1032210, XrefRangeEnd = 1032220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnterMyLockSpin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_EnterMyLockSpin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0005F808 File Offset: 0x0005DA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032228, XrefRangeEnd = 1032229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitMyLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_ExitMyLock_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0005F83C File Offset: 0x0005DA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032229, XrefRangeEnd = 1032236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SpinWait(int SpinCount)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref SpinCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_SpinWait_Private_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x0005F870 File Offset: 0x0005DA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032236, XrefRangeEnd = 1032237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0005F8A4 File Offset: 0x0005DAA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1032256, RefRangeEnd = 1032257, XrefRangeStart = 1032237, XrefRangeEnd = 1032256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x0005F8E4 File Offset: 0x0005DAE4
		public unsafe bool IsReadLockHeld
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032257, XrefRangeEnd = 1032261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_get_IsReadLockHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x0005F920 File Offset: 0x0005DB20
		public unsafe bool IsUpgradeableReadLockHeld
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032261, XrefRangeEnd = 1032263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_get_IsUpgradeableReadLockHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x0005F95C File Offset: 0x0005DB5C
		public unsafe bool IsWriteLockHeld
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032263, XrefRangeEnd = 1032265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_get_IsWriteLockHeld_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x0005F998 File Offset: 0x0005DB98
		public unsafe int RecursiveReadCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032265, XrefRangeEnd = 1032269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_get_RecursiveReadCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x0005F9D4 File Offset: 0x0005DBD4
		public unsafe int RecursiveUpgradeCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032269, XrefRangeEnd = 1032271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_get_RecursiveUpgradeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x0005FA10 File Offset: 0x0005DC10
		public unsafe int RecursiveWriteCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032271, XrefRangeEnd = 1032273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_get_RecursiveWriteCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x0005FA4C File Offset: 0x0005DC4C
		public unsafe int WaitingReadCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_get_WaitingReadCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x0005FA88 File Offset: 0x0005DC88
		public unsafe int WaitingUpgradeCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_get_WaitingUpgradeCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x0005FAC4 File Offset: 0x0005DCC4
		public unsafe int WaitingWriteCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.NativeMethodInfoPtr_get_WaitingWriteCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00007887 File Offset: 0x00005A87
		public ReaderWriterLockSlim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001260 RID: 4704 RVA: 0x0005FB00 File Offset: 0x0005DD00
		// (set) Token: 0x06001261 RID: 4705 RVA: 0x00007890 File Offset: 0x00005A90
		public unsafe bool fIsReentrant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_fIsReentrant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_fIsReentrant)) = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x0005FB28 File Offset: 0x0005DD28
		// (set) Token: 0x06001263 RID: 4707 RVA: 0x000078AB File Offset: 0x00005AAB
		public unsafe int myLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_myLock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_myLock)) = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x0005FB50 File Offset: 0x0005DD50
		// (set) Token: 0x06001265 RID: 4709 RVA: 0x000078C6 File Offset: 0x00005AC6
		public unsafe uint numWriteWaiters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_numWriteWaiters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_numWriteWaiters)) = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x0005FB78 File Offset: 0x0005DD78
		// (set) Token: 0x06001267 RID: 4711 RVA: 0x000078E1 File Offset: 0x00005AE1
		public unsafe uint numReadWaiters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_numReadWaiters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_numReadWaiters)) = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x0005FBA0 File Offset: 0x0005DDA0
		// (set) Token: 0x06001269 RID: 4713 RVA: 0x000078FC File Offset: 0x00005AFC
		public unsafe uint numWriteUpgradeWaiters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_numWriteUpgradeWaiters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_numWriteUpgradeWaiters)) = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x0005FBC8 File Offset: 0x0005DDC8
		// (set) Token: 0x0600126B RID: 4715 RVA: 0x00007917 File Offset: 0x00005B17
		public unsafe uint numUpgradeWaiters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_numUpgradeWaiters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_numUpgradeWaiters)) = value;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0005FBF0 File Offset: 0x0005DDF0
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x00007932 File Offset: 0x00005B32
		public unsafe bool fNoWaiters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_fNoWaiters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_fNoWaiters)) = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0005FC18 File Offset: 0x0005DE18
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x0000794D File Offset: 0x00005B4D
		public unsafe int upgradeLockOwnerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_upgradeLockOwnerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_upgradeLockOwnerId)) = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x0005FC40 File Offset: 0x0005DE40
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x00007968 File Offset: 0x00005B68
		public unsafe int writeLockOwnerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_writeLockOwnerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_writeLockOwnerId)) = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x0005FC68 File Offset: 0x0005DE68
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x00007983 File Offset: 0x00005B83
		public unsafe EventWaitHandle writeEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_writeEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventWaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_writeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x0005FC98 File Offset: 0x0005DE98
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x000079A2 File Offset: 0x00005BA2
		public unsafe EventWaitHandle readEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_readEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventWaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_readEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x0005FCC8 File Offset: 0x0005DEC8
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x000079C1 File Offset: 0x00005BC1
		public unsafe EventWaitHandle upgradeEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_upgradeEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventWaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_upgradeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x0005FCF8 File Offset: 0x0005DEF8
		// (set) Token: 0x06001279 RID: 4729 RVA: 0x000079E0 File Offset: 0x00005BE0
		public unsafe EventWaitHandle waitUpgradeEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_waitUpgradeEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventWaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_waitUpgradeEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x0005FD28 File Offset: 0x0005DF28
		// (set) Token: 0x0600127B RID: 4731 RVA: 0x000079FF File Offset: 0x00005BFF
		public unsafe static long s_nextLockID
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(ReaderWriterLockSlim.NativeFieldInfoPtr_s_nextLockID, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReaderWriterLockSlim.NativeFieldInfoPtr_s_nextLockID, (void*)(&value));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x0005FD44 File Offset: 0x0005DF44
		// (set) Token: 0x0600127D RID: 4733 RVA: 0x00007A0D File Offset: 0x00005C0D
		public unsafe long lockID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_lockID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_lockID)) = value;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x0005FD6C File Offset: 0x0005DF6C
		// (set) Token: 0x0600127F RID: 4735 RVA: 0x00007A28 File Offset: 0x00005C28
		public unsafe static ReaderWriterCount t_rwc
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReaderWriterLockSlim.NativeFieldInfoPtr_t_rwc, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReaderWriterCount>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReaderWriterLockSlim.NativeFieldInfoPtr_t_rwc, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x0005FD94 File Offset: 0x0005DF94
		// (set) Token: 0x06001281 RID: 4737 RVA: 0x00007A3A File Offset: 0x00005C3A
		public unsafe bool fUpgradeThreadHoldingRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_fUpgradeThreadHoldingRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_fUpgradeThreadHoldingRead)) = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x0005FDBC File Offset: 0x0005DFBC
		// (set) Token: 0x06001283 RID: 4739 RVA: 0x00007A55 File Offset: 0x00005C55
		public unsafe uint owners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_owners);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_owners)) = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x0005FDE4 File Offset: 0x0005DFE4
		// (set) Token: 0x06001285 RID: 4741 RVA: 0x00007A70 File Offset: 0x00005C70
		public unsafe bool fDisposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_fDisposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLockSlim.NativeFieldInfoPtr_fDisposed)) = value;
			}
		}

		// Token: 0x04000D18 RID: 3352
		private static readonly IntPtr NativeFieldInfoPtr_fIsReentrant;

		// Token: 0x04000D19 RID: 3353
		private static readonly IntPtr NativeFieldInfoPtr_myLock;

		// Token: 0x04000D1A RID: 3354
		private static readonly IntPtr NativeFieldInfoPtr_numWriteWaiters;

		// Token: 0x04000D1B RID: 3355
		private static readonly IntPtr NativeFieldInfoPtr_numReadWaiters;

		// Token: 0x04000D1C RID: 3356
		private static readonly IntPtr NativeFieldInfoPtr_numWriteUpgradeWaiters;

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeFieldInfoPtr_numUpgradeWaiters;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeFieldInfoPtr_fNoWaiters;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeFieldInfoPtr_upgradeLockOwnerId;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeFieldInfoPtr_writeLockOwnerId;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeFieldInfoPtr_writeEvent;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeFieldInfoPtr_readEvent;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeFieldInfoPtr_upgradeEvent;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeFieldInfoPtr_waitUpgradeEvent;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeFieldInfoPtr_s_nextLockID;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeFieldInfoPtr_lockID;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeFieldInfoPtr_t_rwc;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeFieldInfoPtr_fUpgradeThreadHoldingRead;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeFieldInfoPtr_owners;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeFieldInfoPtr_fDisposed;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_InitializeThreadCounts_Private_Void_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_LockRecursionPolicy_0;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeMethodInfoPtr_IsRWEntryEmpty_Private_Static_Boolean_ReaderWriterCount_0;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_IsRwHashEntryChanged_Private_Boolean_ReaderWriterCount_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_GetThreadRWCount_Private_ReaderWriterCount_Boolean_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_EnterWriteLock_Public_Void_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_TryEnterWriteLock_Public_Boolean_Int32_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr_TryEnterWriteLock_Private_Boolean_TimeoutTracker_0;

		// Token: 0x04000D34 RID: 3380
		private static readonly IntPtr NativeMethodInfoPtr_TryEnterWriteLockCore_Private_Boolean_TimeoutTracker_0;

		// Token: 0x04000D35 RID: 3381
		private static readonly IntPtr NativeMethodInfoPtr_EnterUpgradeableReadLock_Public_Void_0;

		// Token: 0x04000D36 RID: 3382
		private static readonly IntPtr NativeMethodInfoPtr_TryEnterUpgradeableReadLock_Public_Boolean_Int32_0;

		// Token: 0x04000D37 RID: 3383
		private static readonly IntPtr NativeMethodInfoPtr_TryEnterUpgradeableReadLock_Private_Boolean_TimeoutTracker_0;

		// Token: 0x04000D38 RID: 3384
		private static readonly IntPtr NativeMethodInfoPtr_TryEnterUpgradeableReadLockCore_Private_Boolean_TimeoutTracker_0;

		// Token: 0x04000D39 RID: 3385
		private static readonly IntPtr NativeMethodInfoPtr_ExitWriteLock_Public_Void_0;

		// Token: 0x04000D3A RID: 3386
		private static readonly IntPtr NativeMethodInfoPtr_ExitUpgradeableReadLock_Public_Void_0;

		// Token: 0x04000D3B RID: 3387
		private static readonly IntPtr NativeMethodInfoPtr_LazyCreateEvent_Private_Void_byref_EventWaitHandle_Boolean_0;

		// Token: 0x04000D3C RID: 3388
		private static readonly IntPtr NativeMethodInfoPtr_WaitOnEvent_Private_Boolean_EventWaitHandle_byref_UInt32_TimeoutTracker_Boolean_0;

		// Token: 0x04000D3D RID: 3389
		private static readonly IntPtr NativeMethodInfoPtr_ExitAndWakeUpAppropriateWaiters_Private_Void_0;

		// Token: 0x04000D3E RID: 3390
		private static readonly IntPtr NativeMethodInfoPtr_ExitAndWakeUpAppropriateWaitersPreferringWriters_Private_Void_0;

		// Token: 0x04000D3F RID: 3391
		private static readonly IntPtr NativeMethodInfoPtr_ExitAndWakeUpAppropriateReadWaiters_Private_Void_0;

		// Token: 0x04000D40 RID: 3392
		private static readonly IntPtr NativeMethodInfoPtr_IsWriterAcquired_Private_Boolean_0;

		// Token: 0x04000D41 RID: 3393
		private static readonly IntPtr NativeMethodInfoPtr_SetWriterAcquired_Private_Void_0;

		// Token: 0x04000D42 RID: 3394
		private static readonly IntPtr NativeMethodInfoPtr_ClearWriterAcquired_Private_Void_0;

		// Token: 0x04000D43 RID: 3395
		private static readonly IntPtr NativeMethodInfoPtr_SetWritersWaiting_Private_Void_0;

		// Token: 0x04000D44 RID: 3396
		private static readonly IntPtr NativeMethodInfoPtr_ClearWritersWaiting_Private_Void_0;

		// Token: 0x04000D45 RID: 3397
		private static readonly IntPtr NativeMethodInfoPtr_SetUpgraderWaiting_Private_Void_0;

		// Token: 0x04000D46 RID: 3398
		private static readonly IntPtr NativeMethodInfoPtr_ClearUpgraderWaiting_Private_Void_0;

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeMethodInfoPtr_GetNumReaders_Private_UInt32_0;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeMethodInfoPtr_EnterMyLock_Private_Void_0;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeMethodInfoPtr_EnterMyLockSpin_Private_Void_0;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeMethodInfoPtr_ExitMyLock_Private_Void_0;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeMethodInfoPtr_SpinWait_Private_Static_Void_Int32_0;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadLockHeld_Public_get_Boolean_0;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUpgradeableReadLockHeld_Public_get_Boolean_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWriteLockHeld_Public_get_Boolean_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_get_RecursiveReadCount_Public_get_Int32_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_get_RecursiveUpgradeCount_Public_get_Int32_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_get_RecursiveWriteCount_Public_get_Int32_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_get_WaitingReadCount_Public_get_Int32_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_get_WaitingUpgradeCount_Public_get_Int32_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_get_WaitingWriteCount_Public_get_Int32_0;

		// Token: 0x0200035A RID: 858
		[StructLayout(2)]
		public struct TimeoutTracker
		{
			// Token: 0x06001C48 RID: 7240 RVA: 0x0008564C File Offset: 0x0008384C
			// Note: this type is marked as 'beforefieldinit'.
			static TimeoutTracker()
			{
				Il2CppClassPointerStore<ReaderWriterLockSlim.TimeoutTracker>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReaderWriterLockSlim>.NativeClassPtr, "TimeoutTracker");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReaderWriterLockSlim.TimeoutTracker>.NativeClassPtr);
				ReaderWriterLockSlim.TimeoutTracker.NativeFieldInfoPtr_m_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim.TimeoutTracker>.NativeClassPtr, "m_total");
				ReaderWriterLockSlim.TimeoutTracker.NativeFieldInfoPtr_m_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLockSlim.TimeoutTracker>.NativeClassPtr, "m_start");
				ReaderWriterLockSlim.TimeoutTracker.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim.TimeoutTracker>.NativeClassPtr, 100666775);
				ReaderWriterLockSlim.TimeoutTracker.NativeMethodInfoPtr_get_RemainingMilliseconds_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim.TimeoutTracker>.NativeClassPtr, 100666776);
				ReaderWriterLockSlim.TimeoutTracker.NativeMethodInfoPtr_get_IsExpired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLockSlim.TimeoutTracker>.NativeClassPtr, 100666777);
			}

			// Token: 0x06001C49 RID: 7241 RVA: 0x000856DC File Offset: 0x000838DC
			[CallerCount(0)]
			public unsafe TimeoutTracker(int millisecondsTimeout)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref millisecondsTimeout;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.TimeoutTracker.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x06001C4A RID: 7242 RVA: 0x00085710 File Offset: 0x00083910
			public unsafe int RemainingMilliseconds
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032072, XrefRangeEnd = 1032073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.TimeoutTracker.NativeMethodInfoPtr_get_RemainingMilliseconds_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000725 RID: 1829
			// (get) Token: 0x06001C4B RID: 7243 RVA: 0x00085740 File Offset: 0x00083940
			public unsafe bool IsExpired
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1032073, XrefRangeEnd = 1032074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLockSlim.TimeoutTracker.NativeMethodInfoPtr_get_IsExpired_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001C4C RID: 7244 RVA: 0x0000ACB0 File Offset: 0x00008EB0
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReaderWriterLockSlim.TimeoutTracker>.NativeClassPtr, ref this));
			}

			// Token: 0x04001312 RID: 4882
			private static readonly IntPtr NativeFieldInfoPtr_m_total;

			// Token: 0x04001313 RID: 4883
			private static readonly IntPtr NativeFieldInfoPtr_m_start;

			// Token: 0x04001314 RID: 4884
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001315 RID: 4885
			private static readonly IntPtr NativeMethodInfoPtr_get_RemainingMilliseconds_Public_get_Int32_0;

			// Token: 0x04001316 RID: 4886
			private static readonly IntPtr NativeMethodInfoPtr_get_IsExpired_Public_get_Boolean_0;

			// Token: 0x04001317 RID: 4887
			[FieldOffset(0)]
			public int m_total;

			// Token: 0x04001318 RID: 4888
			[FieldOffset(4)]
			public int m_start;
		}
	}
}
