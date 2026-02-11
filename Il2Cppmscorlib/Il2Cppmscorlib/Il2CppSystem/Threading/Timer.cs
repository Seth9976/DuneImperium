using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Threading
{
	// Token: 0x020001C3 RID: 451
	public sealed class Timer : MarshalByRefObject
	{
		// Token: 0x06001DA0 RID: 7584 RVA: 0x000AD090 File Offset: 0x000AB290
		// Note: this type is marked as 'beforefieldinit'.
		static Timer()
		{
			Il2CppClassPointerStore<Timer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Timer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timer>.NativeClassPtr);
			Timer.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "callback");
			Timer.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "state");
			Timer.NativeFieldInfoPtr_due_time_ms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "due_time_ms");
			Timer.NativeFieldInfoPtr_period_ms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "period_ms");
			Timer.NativeFieldInfoPtr_next_run = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "next_run");
			Timer.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "disposed");
			Timer.NativeFieldInfoPtr_is_dead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "is_dead");
			Timer.NativeFieldInfoPtr_is_added = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "is_added");
			Timer.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "MaxValue");
			Timer.NativeMethodInfoPtr_get_scheduler_Private_Static_get_Scheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100668321);
			Timer.NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100668322);
			Timer.NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100668323);
			Timer.NativeMethodInfoPtr_Init_Private_Void_TimerCallback_Object_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100668324);
			Timer.NativeMethodInfoPtr_Change_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100668325);
			Timer.NativeMethodInfoPtr_Change_Public_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100668326);
			Timer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100668327);
			Timer.NativeMethodInfoPtr_Change_Private_Boolean_Int64_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100668328);
			Timer.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_Final_New_ValueTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100668329);
			Timer.NativeMethodInfoPtr_KeepRootedWhileScheduled_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100668330);
			Timer.NativeMethodInfoPtr_GetTimeMonotonic_Private_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100668331);
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x000AD250 File Offset: 0x000AB450
		public unsafe static Timer.Scheduler scheduler
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1357689, RefRangeEnd = 1357692, XrefRangeStart = 1357681, XrefRangeEnd = 1357689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_get_scheduler_Private_Static_get_Scheduler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Timer.Scheduler>(intPtr3) : null;
			}
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x000AD284 File Offset: 0x000AB484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1357702, RefRangeEnd = 1357705, XrefRangeStart = 1357692, XrefRangeEnd = 1357702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Timer(TimerCallback callback, Object state, int dueTime, int period)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dueTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x000AD300 File Offset: 0x000AB500
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1357714, RefRangeEnd = 1357717, XrefRangeStart = 1357705, XrefRangeEnd = 1357714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Timer(TimerCallback callback, Object state, TimeSpan dueTime, TimeSpan period)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dueTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x000AD37C File Offset: 0x000AB57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357717, XrefRangeEnd = 1357726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(TimerCallback callback, Object state, long dueTime, long period)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dueTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Init_Private_Void_TimerCallback_Object_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x000AD3EC File Offset: 0x000AB5EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1357727, RefRangeEnd = 1357731, XrefRangeStart = 1357726, XrefRangeEnd = 1357727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Change(int dueTime, int period)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dueTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Change_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x000AD444 File Offset: 0x000AB644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1357737, RefRangeEnd = 1357738, XrefRangeStart = 1357731, XrefRangeEnd = 1357737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Change(TimeSpan dueTime, TimeSpan period)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dueTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Change_Public_Boolean_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x000AD49C File Offset: 0x000AB69C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1357740, RefRangeEnd = 1357748, XrefRangeStart = 1357738, XrefRangeEnd = 1357740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x000AD4D0 File Offset: 0x000AB6D0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1357750, RefRangeEnd = 1357756, XrefRangeStart = 1357748, XrefRangeEnd = 1357750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Change(long dueTime, long period, bool first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dueTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Change_Private_Boolean_Int64_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x000AD538 File Offset: 0x000AB738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357756, XrefRangeEnd = 1357766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTask DisposeAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_DisposeAsync_Public_Virtual_Final_New_ValueTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTask(intPtr);
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x000AD570 File Offset: 0x000AB770
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KeepRootedWhileScheduled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_KeepRootedWhileScheduled_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x000AD5A4 File Offset: 0x000AB7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetTimeMonotonic()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_GetTimeMonotonic_Private_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00009B3B File Offset: 0x00007D3B
		public Timer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x000AD5D4 File Offset: 0x000AB7D4
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x00009B44 File Offset: 0x00007D44
		public unsafe TimerCallback callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x000AD604 File Offset: 0x000AB804
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x00009B63 File Offset: 0x00007D63
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x000AD634 File Offset: 0x000AB834
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x00009B82 File Offset: 0x00007D82
		public unsafe long due_time_ms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_due_time_ms);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_due_time_ms)) = value;
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x000AD65C File Offset: 0x000AB85C
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x00009B9D File Offset: 0x00007D9D
		public unsafe long period_ms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_period_ms);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_period_ms)) = value;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x000AD684 File Offset: 0x000AB884
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x00009BB8 File Offset: 0x00007DB8
		public unsafe long next_run
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_next_run);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_next_run)) = value;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x000AD6AC File Offset: 0x000AB8AC
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00009BD3 File Offset: 0x00007DD3
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x000AD6D4 File Offset: 0x000AB8D4
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x00009BEE File Offset: 0x00007DEE
		public unsafe bool is_dead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_is_dead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_is_dead)) = value;
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x000AD6FC File Offset: 0x000AB8FC
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x00009C09 File Offset: 0x00007E09
		public unsafe bool is_added
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_is_added);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_is_added)) = value;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x000AD724 File Offset: 0x000AB924
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x00009C24 File Offset: 0x00007E24
		public unsafe static long MaxValue
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(Timer.NativeFieldInfoPtr_MaxValue, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Timer.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x04001A96 RID: 6806
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04001A97 RID: 6807
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001A98 RID: 6808
		private static readonly IntPtr NativeFieldInfoPtr_due_time_ms;

		// Token: 0x04001A99 RID: 6809
		private static readonly IntPtr NativeFieldInfoPtr_period_ms;

		// Token: 0x04001A9A RID: 6810
		private static readonly IntPtr NativeFieldInfoPtr_next_run;

		// Token: 0x04001A9B RID: 6811
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04001A9C RID: 6812
		private static readonly IntPtr NativeFieldInfoPtr_is_dead;

		// Token: 0x04001A9D RID: 6813
		private static readonly IntPtr NativeFieldInfoPtr_is_added;

		// Token: 0x04001A9E RID: 6814
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04001A9F RID: 6815
		private static readonly IntPtr NativeMethodInfoPtr_get_scheduler_Private_Static_get_Scheduler_0;

		// Token: 0x04001AA0 RID: 6816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_Int32_Int32_0;

		// Token: 0x04001AA1 RID: 6817
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_TimeSpan_TimeSpan_0;

		// Token: 0x04001AA2 RID: 6818
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_TimerCallback_Object_Int64_Int64_0;

		// Token: 0x04001AA3 RID: 6819
		private static readonly IntPtr NativeMethodInfoPtr_Change_Public_Boolean_Int32_Int32_0;

		// Token: 0x04001AA4 RID: 6820
		private static readonly IntPtr NativeMethodInfoPtr_Change_Public_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04001AA5 RID: 6821
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001AA6 RID: 6822
		private static readonly IntPtr NativeMethodInfoPtr_Change_Private_Boolean_Int64_Int64_Boolean_0;

		// Token: 0x04001AA7 RID: 6823
		private static readonly IntPtr NativeMethodInfoPtr_DisposeAsync_Public_Virtual_Final_New_ValueTask_0;

		// Token: 0x04001AA8 RID: 6824
		private static readonly IntPtr NativeMethodInfoPtr_KeepRootedWhileScheduled_Internal_Void_0;

		// Token: 0x04001AA9 RID: 6825
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeMonotonic_Private_Static_Int64_0;

		// Token: 0x02000619 RID: 1561
		[StructLayout(2)]
		public struct TimerComparer
		{
			// Token: 0x060058B8 RID: 22712 RVA: 0x00197958 File Offset: 0x00195B58
			// Note: this type is marked as 'beforefieldinit'.
			static TimerComparer()
			{
				Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Timer>.NativeClassPtr, "TimerComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr);
				Timer.TimerComparer.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr, 100668332);
				Timer.TimerComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Timer_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr, 100668333);
			}

			// Token: 0x060058B9 RID: 22713 RVA: 0x001979AC File Offset: 0x00195BAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357477, XrefRangeEnd = 1357483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int System_Collections_IComparer_Compare(Object x, Object y)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.TimerComparer.NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060058BA RID: 22714 RVA: 0x00197A00 File Offset: 0x00195C00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357483, XrefRangeEnd = 1357488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Compare(Timer tx, Timer ty)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tx);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ty);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.TimerComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Timer_Timer_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060058BB RID: 22715 RVA: 0x0001FA22 File Offset: 0x0001DC22
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr, ref this));
			}

			// Token: 0x040048E7 RID: 18663
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IComparer_Compare_Private_Virtual_Final_New_Int32_Object_Object_0;

			// Token: 0x040048E8 RID: 18664
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Timer_Timer_0;
		}

		// Token: 0x0200061A RID: 1562
		public sealed class Scheduler : Object
		{
			// Token: 0x060058BC RID: 22716 RVA: 0x00197A54 File Offset: 0x00195C54
			// Note: this type is marked as 'beforefieldinit'.
			static Scheduler()
			{
				Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Timer>.NativeClassPtr, "Scheduler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr);
				Timer.Scheduler.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, "instance");
				Timer.Scheduler.NativeFieldInfoPtr_needReSort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, "needReSort");
				Timer.Scheduler.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, "list");
				Timer.Scheduler.NativeFieldInfoPtr_current_next_run = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, "current_next_run");
				Timer.Scheduler.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, "changed");
				Timer.Scheduler.NativeMethodInfoPtr_InitScheduler_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100668334);
				Timer.Scheduler.NativeMethodInfoPtr_WakeupScheduler_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100668335);
				Timer.Scheduler.NativeMethodInfoPtr_SchedulerThread_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100668336);
				Timer.Scheduler.NativeMethodInfoPtr_get_Instance_Public_Static_get_Scheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100668337);
				Timer.Scheduler.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100668338);
				Timer.Scheduler.NativeMethodInfoPtr_Remove_Public_Void_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100668339);
				Timer.Scheduler.NativeMethodInfoPtr_Change_Public_Void_Timer_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100668340);
				Timer.Scheduler.NativeMethodInfoPtr_Add_Private_Void_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100668341);
				Timer.Scheduler.NativeMethodInfoPtr_InternalRemove_Private_Void_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100668342);
				Timer.Scheduler.NativeMethodInfoPtr_TimerCB_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100668343);
				Timer.Scheduler.NativeMethodInfoPtr_FireTimer_Private_Void_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100668344);
				Timer.Scheduler.NativeMethodInfoPtr_RunSchedulerLoop_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100668345);
			}

			// Token: 0x060058BD RID: 22717 RVA: 0x00197BD4 File Offset: 0x00195DD4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1357522, RefRangeEnd = 1357524, XrefRangeStart = 1357488, XrefRangeEnd = 1357522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void InitScheduler()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_InitScheduler_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058BE RID: 22718 RVA: 0x00197C08 File Offset: 0x00195E08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357524, XrefRangeEnd = 1357542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void WakeupScheduler()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_WakeupScheduler_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058BF RID: 22719 RVA: 0x00197C3C File Offset: 0x00195E3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357542, XrefRangeEnd = 1357569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SchedulerThread()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_SchedulerThread_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170016A2 RID: 5794
			// (get) Token: 0x060058C0 RID: 22720 RVA: 0x00197C70 File Offset: 0x00195E70
			public unsafe static Timer.Scheduler Instance
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357569, XrefRangeEnd = 1357573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_get_Instance_Public_Static_get_Scheduler_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Timer.Scheduler>(intPtr3) : null;
				}
			}

			// Token: 0x060058C1 RID: 22721 RVA: 0x00197CA4 File Offset: 0x00195EA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357573, XrefRangeEnd = 1357583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Scheduler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058C2 RID: 22722 RVA: 0x00197CE0 File Offset: 0x00195EE0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1357588, RefRangeEnd = 1357591, XrefRangeStart = 1357583, XrefRangeEnd = 1357588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Remove(Timer timer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_Remove_Public_Void_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058C3 RID: 22723 RVA: 0x00197D24 File Offset: 0x00195F24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357591, XrefRangeEnd = 1357610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Change(Timer timer, long new_next_run)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref new_next_run;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_Change_Public_Void_Timer_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060058C4 RID: 22724 RVA: 0x00197D74 File Offset: 0x00195F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357610, XrefRangeEnd = 1357618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(Timer timer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_Add_Private_Void_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058C5 RID: 22725 RVA: 0x00197DB8 File Offset: 0x00195FB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357618, XrefRangeEnd = 1357619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void InternalRemove(Timer timer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_InternalRemove_Private_Void_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058C6 RID: 22726 RVA: 0x00197DFC File Offset: 0x00195FFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1357619, XrefRangeEnd = 1357623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void TimerCB(Object o)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_TimerCB_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058C7 RID: 22727 RVA: 0x00197E34 File Offset: 0x00196034
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1357633, RefRangeEnd = 1357634, XrefRangeStart = 1357623, XrefRangeEnd = 1357633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void FireTimer(Timer timer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_FireTimer_Private_Void_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060058C8 RID: 22728 RVA: 0x00197E78 File Offset: 0x00196078
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1357680, RefRangeEnd = 1357681, XrefRangeStart = 1357634, XrefRangeEnd = 1357680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int RunSchedulerLoop()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_RunSchedulerLoop_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060058C9 RID: 22729 RVA: 0x0001FA34 File Offset: 0x0001DC34
			public Scheduler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700169D RID: 5789
			// (get) Token: 0x060058CA RID: 22730 RVA: 0x00197EB4 File Offset: 0x001960B4
			// (set) Token: 0x060058CB RID: 22731 RVA: 0x0001FA3D File Offset: 0x0001DC3D
			public unsafe static Timer.Scheduler instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Timer.Scheduler.NativeFieldInfoPtr_instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer.Scheduler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Timer.Scheduler.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700169E RID: 5790
			// (get) Token: 0x060058CC RID: 22732 RVA: 0x00197EDC File Offset: 0x001960DC
			// (set) Token: 0x060058CD RID: 22733 RVA: 0x0001FA4F File Offset: 0x0001DC4F
			public unsafe bool needReSort
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_needReSort);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_needReSort)) = value;
				}
			}

			// Token: 0x1700169F RID: 5791
			// (get) Token: 0x060058CE RID: 22734 RVA: 0x00197F04 File Offset: 0x00196104
			// (set) Token: 0x060058CF RID: 22735 RVA: 0x0001FA6A File Offset: 0x0001DC6A
			public unsafe List<Timer> list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Timer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170016A0 RID: 5792
			// (get) Token: 0x060058D0 RID: 22736 RVA: 0x00197F34 File Offset: 0x00196134
			// (set) Token: 0x060058D1 RID: 22737 RVA: 0x0001FA89 File Offset: 0x0001DC89
			public unsafe long current_next_run
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_current_next_run);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_current_next_run)) = value;
				}
			}

			// Token: 0x170016A1 RID: 5793
			// (get) Token: 0x060058D2 RID: 22738 RVA: 0x00197F5C File Offset: 0x0019615C
			// (set) Token: 0x060058D3 RID: 22739 RVA: 0x0001FAA4 File Offset: 0x0001DCA4
			public unsafe ManualResetEvent changed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_changed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_changed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040048E9 RID: 18665
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x040048EA RID: 18666
			private static readonly IntPtr NativeFieldInfoPtr_needReSort;

			// Token: 0x040048EB RID: 18667
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x040048EC RID: 18668
			private static readonly IntPtr NativeFieldInfoPtr_current_next_run;

			// Token: 0x040048ED RID: 18669
			private static readonly IntPtr NativeFieldInfoPtr_changed;

			// Token: 0x040048EE RID: 18670
			private static readonly IntPtr NativeMethodInfoPtr_InitScheduler_Private_Void_0;

			// Token: 0x040048EF RID: 18671
			private static readonly IntPtr NativeMethodInfoPtr_WakeupScheduler_Private_Void_0;

			// Token: 0x040048F0 RID: 18672
			private static readonly IntPtr NativeMethodInfoPtr_SchedulerThread_Private_Void_0;

			// Token: 0x040048F1 RID: 18673
			private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Scheduler_0;

			// Token: 0x040048F2 RID: 18674
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x040048F3 RID: 18675
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Timer_0;

			// Token: 0x040048F4 RID: 18676
			private static readonly IntPtr NativeMethodInfoPtr_Change_Public_Void_Timer_Int64_0;

			// Token: 0x040048F5 RID: 18677
			private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Void_Timer_0;

			// Token: 0x040048F6 RID: 18678
			private static readonly IntPtr NativeMethodInfoPtr_InternalRemove_Private_Void_Timer_0;

			// Token: 0x040048F7 RID: 18679
			private static readonly IntPtr NativeMethodInfoPtr_TimerCB_Private_Static_Void_Object_0;

			// Token: 0x040048F8 RID: 18680
			private static readonly IntPtr NativeMethodInfoPtr_FireTimer_Private_Void_Timer_0;

			// Token: 0x040048F9 RID: 18681
			private static readonly IntPtr NativeMethodInfoPtr_RunSchedulerLoop_Private_Int32_0;
		}
	}
}
