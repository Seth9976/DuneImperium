using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001BD RID: 445
	public class LockQueue : Object
	{
		// Token: 0x06001D09 RID: 7433 RVA: 0x000AB914 File Offset: 0x000A9B14
		// Note: this type is marked as 'beforefieldinit'.
		static LockQueue()
		{
			Il2CppClassPointerStore<LockQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "LockQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LockQueue>.NativeClassPtr);
			LockQueue.NativeFieldInfoPtr_rwlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, "rwlock");
			LockQueue.NativeFieldInfoPtr_lockCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, "lockCount");
			LockQueue.NativeMethodInfoPtr__ctor_Public_Void_ReaderWriterLock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, 100668296);
			LockQueue.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, 100668297);
			LockQueue.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, 100668298);
			LockQueue.NativeMethodInfoPtr_Pulse_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LockQueue>.NativeClassPtr, 100668299);
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x000AB9BC File Offset: 0x000A9BBC
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LockQueue(ReaderWriterLock rwlock)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LockQueue>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rwlock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockQueue.NativeMethodInfoPtr__ctor_Public_Void_ReaderWriterLock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x000ABA08 File Offset: 0x000A9C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357313, RefRangeEnd = 1357314, XrefRangeStart = 1357304, XrefRangeEnd = 1357313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockQueue.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x000ABA54 File Offset: 0x000A9C54
		public unsafe bool IsEmpty
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1357318, RefRangeEnd = 1357321, XrefRangeStart = 1357314, XrefRangeEnd = 1357318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockQueue.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x000ABA90 File Offset: 0x000A9C90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1357327, RefRangeEnd = 1357329, XrefRangeStart = 1357321, XrefRangeEnd = 1357327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pulse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LockQueue.NativeMethodInfoPtr_Pulse_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x000094AD File Offset: 0x000076AD
		public LockQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x000ABAC4 File Offset: 0x000A9CC4
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x000094B6 File Offset: 0x000076B6
		public unsafe ReaderWriterLock rwlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockQueue.NativeFieldInfoPtr_rwlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReaderWriterLock>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockQueue.NativeFieldInfoPtr_rwlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x000ABAF4 File Offset: 0x000A9CF4
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x000094D5 File Offset: 0x000076D5
		public unsafe int lockCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockQueue.NativeFieldInfoPtr_lockCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LockQueue.NativeFieldInfoPtr_lockCount)) = value;
			}
		}

		// Token: 0x04001A44 RID: 6724
		private static readonly IntPtr NativeFieldInfoPtr_rwlock;

		// Token: 0x04001A45 RID: 6725
		private static readonly IntPtr NativeFieldInfoPtr_lockCount;

		// Token: 0x04001A46 RID: 6726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReaderWriterLock_0;

		// Token: 0x04001A47 RID: 6727
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_0;

		// Token: 0x04001A48 RID: 6728
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x04001A49 RID: 6729
		private static readonly IntPtr NativeMethodInfoPtr_Pulse_Public_Void_0;
	}
}
