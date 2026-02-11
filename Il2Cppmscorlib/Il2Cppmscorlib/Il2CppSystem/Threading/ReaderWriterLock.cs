using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.ConstrainedExecution;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001C0 RID: 448
	public sealed class ReaderWriterLock : CriticalFinalizerObject
	{
		// Token: 0x06001D1E RID: 7454 RVA: 0x000ABDF8 File Offset: 0x000A9FF8
		// Note: this type is marked as 'beforefieldinit'.
		static ReaderWriterLock()
		{
			Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ReaderWriterLock");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr);
			ReaderWriterLock.NativeFieldInfoPtr_seq_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, "seq_num");
			ReaderWriterLock.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, "state");
			ReaderWriterLock.NativeFieldInfoPtr_readers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, "readers");
			ReaderWriterLock.NativeFieldInfoPtr_writer_lock_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, "writer_lock_owner");
			ReaderWriterLock.NativeFieldInfoPtr_writer_queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, "writer_queue");
			ReaderWriterLock.NativeFieldInfoPtr_reader_locks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, "reader_locks");
			ReaderWriterLock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100668307);
			ReaderWriterLock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100668308);
			ReaderWriterLock.NativeMethodInfoPtr_AcquireWriterLock_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100668309);
			ReaderWriterLock.NativeMethodInfoPtr_AcquireWriterLock_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100668310);
			ReaderWriterLock.NativeMethodInfoPtr_ReleaseWriterLock_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100668311);
			ReaderWriterLock.NativeMethodInfoPtr_ReleaseWriterLock_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100668312);
			ReaderWriterLock.NativeMethodInfoPtr_HasWriterLock_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr, 100668313);
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x000ABF2C File Offset: 0x000AA12C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357369, RefRangeEnd = 1357370, XrefRangeStart = 1357353, XrefRangeEnd = 1357369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReaderWriterLock()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReaderWriterLock>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x000ABF68 File Offset: 0x000AA168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x000ABF9C File Offset: 0x000AA19C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357371, RefRangeEnd = 1357372, XrefRangeStart = 1357370, XrefRangeEnd = 1357371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquireWriterLock(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr_AcquireWriterLock_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x000ABFDC File Offset: 0x000AA1DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357383, RefRangeEnd = 1357384, XrefRangeStart = 1357372, XrefRangeEnd = 1357383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcquireWriterLock(int millisecondsTimeout, int initialLockCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialLockCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr_AcquireWriterLock_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x000AC028 File Offset: 0x000AA228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1357394, RefRangeEnd = 1357396, XrefRangeStart = 1357384, XrefRangeEnd = 1357394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseWriterLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr_ReleaseWriterLock_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D24 RID: 7460 RVA: 0x000AC05C File Offset: 0x000AA25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357396, XrefRangeEnd = 1357398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseWriterLock(int releaseCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref releaseCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr_ReleaseWriterLock_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000AC09C File Offset: 0x000AA29C
		[CallerCount(0)]
		public unsafe bool HasWriterLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderWriterLock.NativeMethodInfoPtr_HasWriterLock_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x00009527 File Offset: 0x00007727
		public ReaderWriterLock(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x000AC0D8 File Offset: 0x000AA2D8
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x00009530 File Offset: 0x00007730
		public unsafe int seq_num
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_seq_num);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_seq_num)) = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x000AC100 File Offset: 0x000AA300
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0000954B File Offset: 0x0000774B
		public unsafe int state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x000AC128 File Offset: 0x000AA328
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x00009566 File Offset: 0x00007766
		public unsafe int readers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_readers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_readers)) = value;
			}
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x000AC150 File Offset: 0x000AA350
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x00009581 File Offset: 0x00007781
		public unsafe int writer_lock_owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_writer_lock_owner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_writer_lock_owner)) = value;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x000AC178 File Offset: 0x000AA378
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0000959C File Offset: 0x0000779C
		public unsafe LockQueue writer_queue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_writer_queue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LockQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_writer_queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x000AC1A8 File Offset: 0x000AA3A8
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x000095BB File Offset: 0x000077BB
		public unsafe Hashtable reader_locks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_reader_locks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderWriterLock.NativeFieldInfoPtr_reader_locks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeFieldInfoPtr_seq_num;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeFieldInfoPtr_readers;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeFieldInfoPtr_writer_lock_owner;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeFieldInfoPtr_writer_queue;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeFieldInfoPtr_reader_locks;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr_AcquireWriterLock_Public_Void_Int32_0;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr_AcquireWriterLock_Private_Void_Int32_Int32_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseWriterLock_Public_Void_0;

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseWriterLock_Private_Void_Int32_0;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeMethodInfoPtr_HasWriterLock_Private_Boolean_0;
	}
}
