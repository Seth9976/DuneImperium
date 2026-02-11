using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.ConstrainedExecution;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001C2 RID: 450
	public sealed class InternalThread : CriticalFinalizerObject
	{
		// Token: 0x06001D4B RID: 7499 RVA: 0x000AC600 File Offset: 0x000AA800
		// Note: this type is marked as 'beforefieldinit'.
		static InternalThread()
		{
			Il2CppClassPointerStore<InternalThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "InternalThread");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalThread>.NativeClassPtr);
			InternalThread.NativeFieldInfoPtr_lock_thread_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "lock_thread_id");
			InternalThread.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "handle");
			InternalThread.NativeFieldInfoPtr_native_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "native_handle");
			InternalThread.NativeFieldInfoPtr_name_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "name_chars");
			InternalThread.NativeFieldInfoPtr_name_free = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "name_free");
			InternalThread.NativeFieldInfoPtr_name_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "name_length");
			InternalThread.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "state");
			InternalThread.NativeFieldInfoPtr_abort_exc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "abort_exc");
			InternalThread.NativeFieldInfoPtr_abort_state_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "abort_state_handle");
			InternalThread.NativeFieldInfoPtr_thread_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_id");
			InternalThread.NativeFieldInfoPtr_debugger_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "debugger_thread");
			InternalThread.NativeFieldInfoPtr_static_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "static_data");
			InternalThread.NativeFieldInfoPtr_runtime_thread_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "runtime_thread_info");
			InternalThread.NativeFieldInfoPtr_current_appcontext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "current_appcontext");
			InternalThread.NativeFieldInfoPtr_root_domain_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "root_domain_thread");
			InternalThread.NativeFieldInfoPtr__serialized_principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "_serialized_principal");
			InternalThread.NativeFieldInfoPtr__serialized_principal_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "_serialized_principal_version");
			InternalThread.NativeFieldInfoPtr_appdomain_refs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "appdomain_refs");
			InternalThread.NativeFieldInfoPtr_interruption_requested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "interruption_requested");
			InternalThread.NativeFieldInfoPtr_longlived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "longlived");
			InternalThread.NativeFieldInfoPtr_threadpool_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "threadpool_thread");
			InternalThread.NativeFieldInfoPtr_thread_interrupt_requested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_interrupt_requested");
			InternalThread.NativeFieldInfoPtr_stack_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "stack_size");
			InternalThread.NativeFieldInfoPtr_apartment_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "apartment_state");
			InternalThread.NativeFieldInfoPtr_critical_region_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "critical_region_level");
			InternalThread.NativeFieldInfoPtr_managed_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "managed_id");
			InternalThread.NativeFieldInfoPtr_small_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "small_id");
			InternalThread.NativeFieldInfoPtr_manage_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "manage_callback");
			InternalThread.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "flags");
			InternalThread.NativeFieldInfoPtr_thread_pinning_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_pinning_ref");
			InternalThread.NativeFieldInfoPtr_abort_protected_block_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "abort_protected_block_count");
			InternalThread.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "priority");
			InternalThread.NativeFieldInfoPtr_owned_mutex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "owned_mutex");
			InternalThread.NativeFieldInfoPtr_suspended_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "suspended_event");
			InternalThread.NativeFieldInfoPtr_self_suspended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "self_suspended");
			InternalThread.NativeFieldInfoPtr_thread_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_state");
			InternalThread.NativeFieldInfoPtr_netcore0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "netcore0");
			InternalThread.NativeFieldInfoPtr_netcore1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "netcore1");
			InternalThread.NativeFieldInfoPtr_netcore2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "netcore2");
			InternalThread.NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "last");
			InternalThread.NativeMethodInfoPtr_Thread_free_internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, 100668318);
			InternalThread.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, 100668319);
			InternalThread.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, 100668320);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x000AC98C File Offset: 0x000AAB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357471, XrefRangeEnd = 1357472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Thread_free_internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalThread.NativeMethodInfoPtr_Thread_free_internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4D RID: 7501 RVA: 0x000AC9C0 File Offset: 0x000AABC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357472, XrefRangeEnd = 1357476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalThread.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4E RID: 7502 RVA: 0x000AC9F4 File Offset: 0x000AABF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357476, XrefRangeEnd = 1357477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalThread()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalThread>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalThread.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4F RID: 7503 RVA: 0x000096EA File Offset: 0x000078EA
		public InternalThread(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001D50 RID: 7504 RVA: 0x000ACA30 File Offset: 0x000AAC30
		// (set) Token: 0x06001D51 RID: 7505 RVA: 0x000096F3 File Offset: 0x000078F3
		public unsafe int lock_thread_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_lock_thread_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_lock_thread_id)) = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001D52 RID: 7506 RVA: 0x000ACA58 File Offset: 0x000AAC58
		// (set) Token: 0x06001D53 RID: 7507 RVA: 0x0000970E File Offset: 0x0000790E
		public unsafe IntPtr handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001D54 RID: 7508 RVA: 0x000ACA80 File Offset: 0x000AAC80
		// (set) Token: 0x06001D55 RID: 7509 RVA: 0x00009729 File Offset: 0x00007929
		public unsafe IntPtr native_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_native_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_native_handle)) = value;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06001D56 RID: 7510 RVA: 0x000ACAA8 File Offset: 0x000AACA8
		// (set) Token: 0x06001D57 RID: 7511 RVA: 0x00009744 File Offset: 0x00007944
		public unsafe IntPtr name_chars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name_chars);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name_chars)) = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x000ACAD0 File Offset: 0x000AACD0
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x0000975F File Offset: 0x0000795F
		public unsafe int name_free
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name_free);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name_free)) = value;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06001D5A RID: 7514 RVA: 0x000ACAF8 File Offset: 0x000AACF8
		// (set) Token: 0x06001D5B RID: 7515 RVA: 0x0000977A File Offset: 0x0000797A
		public unsafe int name_length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name_length)) = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001D5C RID: 7516 RVA: 0x000ACB20 File Offset: 0x000AAD20
		// (set) Token: 0x06001D5D RID: 7517 RVA: 0x00009795 File Offset: 0x00007995
		public unsafe ThreadState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001D5E RID: 7518 RVA: 0x000ACB48 File Offset: 0x000AAD48
		// (set) Token: 0x06001D5F RID: 7519 RVA: 0x000097B0 File Offset: 0x000079B0
		public unsafe Object abort_exc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_exc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_exc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001D60 RID: 7520 RVA: 0x000ACB78 File Offset: 0x000AAD78
		// (set) Token: 0x06001D61 RID: 7521 RVA: 0x000097CF File Offset: 0x000079CF
		public unsafe int abort_state_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_state_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_state_handle)) = value;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001D62 RID: 7522 RVA: 0x000ACBA0 File Offset: 0x000AADA0
		// (set) Token: 0x06001D63 RID: 7523 RVA: 0x000097EA File Offset: 0x000079EA
		public unsafe long thread_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_id)) = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001D64 RID: 7524 RVA: 0x000ACBC8 File Offset: 0x000AADC8
		// (set) Token: 0x06001D65 RID: 7525 RVA: 0x00009805 File Offset: 0x00007A05
		public unsafe IntPtr debugger_thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_debugger_thread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_debugger_thread)) = value;
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001D66 RID: 7526 RVA: 0x000ACBF0 File Offset: 0x000AADF0
		// (set) Token: 0x06001D67 RID: 7527 RVA: 0x00009820 File Offset: 0x00007A20
		public unsafe UIntPtr static_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_static_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_static_data)) = value;
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001D68 RID: 7528 RVA: 0x000ACC18 File Offset: 0x000AAE18
		// (set) Token: 0x06001D69 RID: 7529 RVA: 0x0000983B File Offset: 0x00007A3B
		public unsafe IntPtr runtime_thread_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_runtime_thread_info);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_runtime_thread_info)) = value;
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001D6A RID: 7530 RVA: 0x000ACC40 File Offset: 0x000AAE40
		// (set) Token: 0x06001D6B RID: 7531 RVA: 0x00009856 File Offset: 0x00007A56
		public unsafe Object current_appcontext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_current_appcontext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_current_appcontext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001D6C RID: 7532 RVA: 0x000ACC70 File Offset: 0x000AAE70
		// (set) Token: 0x06001D6D RID: 7533 RVA: 0x00009875 File Offset: 0x00007A75
		public unsafe Object root_domain_thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_root_domain_thread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_root_domain_thread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001D6E RID: 7534 RVA: 0x000ACCA0 File Offset: 0x000AAEA0
		// (set) Token: 0x06001D6F RID: 7535 RVA: 0x00009894 File Offset: 0x00007A94
		public unsafe Il2CppStructArray<byte> _serialized_principal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr__serialized_principal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr__serialized_principal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001D70 RID: 7536 RVA: 0x000ACCD0 File Offset: 0x000AAED0
		// (set) Token: 0x06001D71 RID: 7537 RVA: 0x000098B3 File Offset: 0x00007AB3
		public unsafe int _serialized_principal_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr__serialized_principal_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr__serialized_principal_version)) = value;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001D72 RID: 7538 RVA: 0x000ACCF8 File Offset: 0x000AAEF8
		// (set) Token: 0x06001D73 RID: 7539 RVA: 0x000098CE File Offset: 0x00007ACE
		public unsafe IntPtr appdomain_refs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_appdomain_refs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_appdomain_refs)) = value;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x000ACD20 File Offset: 0x000AAF20
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x000098E9 File Offset: 0x00007AE9
		public unsafe int interruption_requested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_interruption_requested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_interruption_requested)) = value;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x000ACD48 File Offset: 0x000AAF48
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x00009904 File Offset: 0x00007B04
		public unsafe IntPtr longlived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_longlived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_longlived)) = value;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x000ACD70 File Offset: 0x000AAF70
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x0000991F File Offset: 0x00007B1F
		public unsafe bool threadpool_thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_threadpool_thread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_threadpool_thread)) = value;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x000ACD98 File Offset: 0x000AAF98
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0000993A File Offset: 0x00007B3A
		public unsafe bool thread_interrupt_requested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_interrupt_requested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_interrupt_requested)) = value;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x000ACDC0 File Offset: 0x000AAFC0
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x00009955 File Offset: 0x00007B55
		public unsafe int stack_size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_stack_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_stack_size)) = value;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x000ACDE8 File Offset: 0x000AAFE8
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x00009970 File Offset: 0x00007B70
		public unsafe byte apartment_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_apartment_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_apartment_state)) = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x000ACE10 File Offset: 0x000AB010
		// (set) Token: 0x06001D81 RID: 7553 RVA: 0x0000998B File Offset: 0x00007B8B
		public unsafe int critical_region_level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_critical_region_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_critical_region_level)) = value;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x000ACE38 File Offset: 0x000AB038
		// (set) Token: 0x06001D83 RID: 7555 RVA: 0x000099A6 File Offset: 0x00007BA6
		public unsafe int managed_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_managed_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_managed_id)) = value;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x000ACE60 File Offset: 0x000AB060
		// (set) Token: 0x06001D85 RID: 7557 RVA: 0x000099C1 File Offset: 0x00007BC1
		public unsafe int small_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_small_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_small_id)) = value;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001D86 RID: 7558 RVA: 0x000ACE88 File Offset: 0x000AB088
		// (set) Token: 0x06001D87 RID: 7559 RVA: 0x000099DC File Offset: 0x00007BDC
		public unsafe IntPtr manage_callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_manage_callback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_manage_callback)) = value;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x000ACEB0 File Offset: 0x000AB0B0
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x000099F7 File Offset: 0x00007BF7
		public unsafe IntPtr flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x000ACED8 File Offset: 0x000AB0D8
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x00009A12 File Offset: 0x00007C12
		public unsafe IntPtr thread_pinning_ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_pinning_ref);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_pinning_ref)) = value;
			}
		}

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001D8C RID: 7564 RVA: 0x000ACF00 File Offset: 0x000AB100
		// (set) Token: 0x06001D8D RID: 7565 RVA: 0x00009A2D File Offset: 0x00007C2D
		public unsafe IntPtr abort_protected_block_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_protected_block_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_protected_block_count)) = value;
			}
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001D8E RID: 7566 RVA: 0x000ACF28 File Offset: 0x000AB128
		// (set) Token: 0x06001D8F RID: 7567 RVA: 0x00009A48 File Offset: 0x00007C48
		public unsafe int priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001D90 RID: 7568 RVA: 0x000ACF50 File Offset: 0x000AB150
		// (set) Token: 0x06001D91 RID: 7569 RVA: 0x00009A63 File Offset: 0x00007C63
		public unsafe IntPtr owned_mutex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_owned_mutex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_owned_mutex)) = value;
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001D92 RID: 7570 RVA: 0x000ACF78 File Offset: 0x000AB178
		// (set) Token: 0x06001D93 RID: 7571 RVA: 0x00009A7E File Offset: 0x00007C7E
		public unsafe IntPtr suspended_event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_suspended_event);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_suspended_event)) = value;
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06001D94 RID: 7572 RVA: 0x000ACFA0 File Offset: 0x000AB1A0
		// (set) Token: 0x06001D95 RID: 7573 RVA: 0x00009A99 File Offset: 0x00007C99
		public unsafe int self_suspended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_self_suspended);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_self_suspended)) = value;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x000ACFC8 File Offset: 0x000AB1C8
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x00009AB4 File Offset: 0x00007CB4
		public unsafe IntPtr thread_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_state)) = value;
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x000ACFF0 File Offset: 0x000AB1F0
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x00009ACF File Offset: 0x00007CCF
		public unsafe IntPtr netcore0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_netcore0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_netcore0)) = value;
			}
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x000AD018 File Offset: 0x000AB218
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x00009AEA File Offset: 0x00007CEA
		public unsafe IntPtr netcore1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_netcore1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_netcore1)) = value;
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x000AD040 File Offset: 0x000AB240
		// (set) Token: 0x06001D9D RID: 7581 RVA: 0x00009B05 File Offset: 0x00007D05
		public unsafe IntPtr netcore2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_netcore2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_netcore2)) = value;
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x000AD068 File Offset: 0x000AB268
		// (set) Token: 0x06001D9F RID: 7583 RVA: 0x00009B20 File Offset: 0x00007D20
		public unsafe IntPtr last
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_last);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_last)) = value;
			}
		}

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeFieldInfoPtr_lock_thread_id;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeFieldInfoPtr_native_handle;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeFieldInfoPtr_name_chars;

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeFieldInfoPtr_name_free;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeFieldInfoPtr_name_length;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeFieldInfoPtr_abort_exc;

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeFieldInfoPtr_abort_state_handle;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeFieldInfoPtr_thread_id;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeFieldInfoPtr_debugger_thread;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeFieldInfoPtr_static_data;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeFieldInfoPtr_runtime_thread_info;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeFieldInfoPtr_current_appcontext;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeFieldInfoPtr_root_domain_thread;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeFieldInfoPtr__serialized_principal;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeFieldInfoPtr__serialized_principal_version;

		// Token: 0x04001A7C RID: 6780
		private static readonly IntPtr NativeFieldInfoPtr_appdomain_refs;

		// Token: 0x04001A7D RID: 6781
		private static readonly IntPtr NativeFieldInfoPtr_interruption_requested;

		// Token: 0x04001A7E RID: 6782
		private static readonly IntPtr NativeFieldInfoPtr_longlived;

		// Token: 0x04001A7F RID: 6783
		private static readonly IntPtr NativeFieldInfoPtr_threadpool_thread;

		// Token: 0x04001A80 RID: 6784
		private static readonly IntPtr NativeFieldInfoPtr_thread_interrupt_requested;

		// Token: 0x04001A81 RID: 6785
		private static readonly IntPtr NativeFieldInfoPtr_stack_size;

		// Token: 0x04001A82 RID: 6786
		private static readonly IntPtr NativeFieldInfoPtr_apartment_state;

		// Token: 0x04001A83 RID: 6787
		private static readonly IntPtr NativeFieldInfoPtr_critical_region_level;

		// Token: 0x04001A84 RID: 6788
		private static readonly IntPtr NativeFieldInfoPtr_managed_id;

		// Token: 0x04001A85 RID: 6789
		private static readonly IntPtr NativeFieldInfoPtr_small_id;

		// Token: 0x04001A86 RID: 6790
		private static readonly IntPtr NativeFieldInfoPtr_manage_callback;

		// Token: 0x04001A87 RID: 6791
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04001A88 RID: 6792
		private static readonly IntPtr NativeFieldInfoPtr_thread_pinning_ref;

		// Token: 0x04001A89 RID: 6793
		private static readonly IntPtr NativeFieldInfoPtr_abort_protected_block_count;

		// Token: 0x04001A8A RID: 6794
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x04001A8B RID: 6795
		private static readonly IntPtr NativeFieldInfoPtr_owned_mutex;

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeFieldInfoPtr_suspended_event;

		// Token: 0x04001A8D RID: 6797
		private static readonly IntPtr NativeFieldInfoPtr_self_suspended;

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeFieldInfoPtr_thread_state;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeFieldInfoPtr_netcore0;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeFieldInfoPtr_netcore1;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeFieldInfoPtr_netcore2;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeFieldInfoPtr_last;

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeMethodInfoPtr_Thread_free_internal_Private_Void_0;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04001A95 RID: 6805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
