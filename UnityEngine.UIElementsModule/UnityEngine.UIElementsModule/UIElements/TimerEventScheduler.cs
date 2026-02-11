using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000178 RID: 376
	public class TimerEventScheduler : Object
	{
		// Token: 0x06001BDD RID: 7133 RVA: 0x0007F2A4 File Offset: 0x0007D4A4
		// Note: this type is marked as 'beforefieldinit'.
		static TimerEventScheduler()
		{
			Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TimerEventScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr);
			TimerEventScheduler.NativeFieldInfoPtr_m_ScheduledItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, "m_ScheduledItems");
			TimerEventScheduler.NativeFieldInfoPtr_m_TransactionMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, "m_TransactionMode");
			TimerEventScheduler.NativeFieldInfoPtr_m_ScheduleTransactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, "m_ScheduleTransactions");
			TimerEventScheduler.NativeFieldInfoPtr_m_UnscheduleTransactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, "m_UnscheduleTransactions");
			TimerEventScheduler.NativeFieldInfoPtr_disableThrottling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, "disableThrottling");
			TimerEventScheduler.NativeFieldInfoPtr_m_LastUpdatedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, "m_LastUpdatedIndex");
			TimerEventScheduler.NativeMethodInfoPtr_Schedule_Public_Virtual_Final_New_Void_ScheduledItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, 100667346);
			TimerEventScheduler.NativeMethodInfoPtr_RemovedScheduledItemAt_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, 100667347);
			TimerEventScheduler.NativeMethodInfoPtr_Unschedule_Public_Virtual_Final_New_Void_ScheduledItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, 100667348);
			TimerEventScheduler.NativeMethodInfoPtr_PrivateUnSchedule_Private_Boolean_ScheduledItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, 100667349);
			TimerEventScheduler.NativeMethodInfoPtr_UpdateScheduledEvents_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, 100667350);
			TimerEventScheduler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr, 100667351);
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x0007F3C4 File Offset: 0x0007D5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323405, XrefRangeEnd = 323412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Schedule(ScheduledItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerEventScheduler.NativeMethodInfoPtr_Schedule_Public_Virtual_Final_New_Void_ScheduledItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0007F408 File Offset: 0x0007D608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323412, XrefRangeEnd = 323413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemovedScheduledItemAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerEventScheduler.NativeMethodInfoPtr_RemovedScheduledItemAt_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x0007F454 File Offset: 0x0007D654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323413, XrefRangeEnd = 323427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Unschedule(ScheduledItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerEventScheduler.NativeMethodInfoPtr_Unschedule_Public_Virtual_Final_New_Void_ScheduledItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BE1 RID: 7137 RVA: 0x0007F498 File Offset: 0x0007D698
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323434, RefRangeEnd = 323436, XrefRangeStart = 323427, XrefRangeEnd = 323434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PrivateUnSchedule(ScheduledItem sItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerEventScheduler.NativeMethodInfoPtr_PrivateUnSchedule_Private_Boolean_ScheduledItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x0007F4E8 File Offset: 0x0007D6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323436, XrefRangeEnd = 323479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateScheduledEvents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerEventScheduler.NativeMethodInfoPtr_UpdateScheduledEvents_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x0007F51C File Offset: 0x0007D71C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323499, RefRangeEnd = 323501, XrefRangeStart = 323479, XrefRangeEnd = 323499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimerEventScheduler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimerEventScheduler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimerEventScheduler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x0000C96D File Offset: 0x0000AB6D
		public TimerEventScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x0007F558 File Offset: 0x0007D758
		// (set) Token: 0x06001BE6 RID: 7142 RVA: 0x0000C976 File Offset: 0x0000AB76
		public unsafe List<ScheduledItem> m_ScheduledItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_ScheduledItems);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScheduledItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_ScheduledItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06001BE7 RID: 7143 RVA: 0x0007F588 File Offset: 0x0007D788
		// (set) Token: 0x06001BE8 RID: 7144 RVA: 0x0000C995 File Offset: 0x0000AB95
		public unsafe bool m_TransactionMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_TransactionMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_TransactionMode)) = value;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0007F5B0 File Offset: 0x0007D7B0
		// (set) Token: 0x06001BEA RID: 7146 RVA: 0x0000C9B0 File Offset: 0x0000ABB0
		public unsafe List<ScheduledItem> m_ScheduleTransactions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_ScheduleTransactions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScheduledItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_ScheduleTransactions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001BEB RID: 7147 RVA: 0x0007F5E0 File Offset: 0x0007D7E0
		// (set) Token: 0x06001BEC RID: 7148 RVA: 0x0000C9CF File Offset: 0x0000ABCF
		public unsafe HashSet<ScheduledItem> m_UnscheduleTransactions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_UnscheduleTransactions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ScheduledItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_UnscheduleTransactions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001BED RID: 7149 RVA: 0x0007F610 File Offset: 0x0007D810
		// (set) Token: 0x06001BEE RID: 7150 RVA: 0x0000C9EE File Offset: 0x0000ABEE
		public unsafe bool disableThrottling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_disableThrottling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_disableThrottling)) = value;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001BEF RID: 7151 RVA: 0x0007F638 File Offset: 0x0007D838
		// (set) Token: 0x06001BF0 RID: 7152 RVA: 0x0000CA09 File Offset: 0x0000AC09
		public unsafe int m_LastUpdatedIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_LastUpdatedIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimerEventScheduler.NativeFieldInfoPtr_m_LastUpdatedIndex)) = value;
			}
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x0007F660 File Offset: 0x0007D860
		public ScheduledItem ScheduleOnce(Action<TimerState> timerUpdateEvent, long delayMs)
		{
			TimerEventScheduler.TimerEventSchedulerItem timerEventSchedulerItem = new TimerEventScheduler.TimerEventSchedulerItem(timerUpdateEvent)
			{
				delayMs = delayMs
			};
			this.Schedule(timerEventSchedulerItem);
			return timerEventSchedulerItem;
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x0007F68C File Offset: 0x0007D88C
		public ScheduledItem ScheduleUntil(Action<TimerState> timerUpdateEvent, long delayMs, long intervalMs, Func<bool> stopCondition)
		{
			TimerEventScheduler.TimerEventSchedulerItem timerEventSchedulerItem = new TimerEventScheduler.TimerEventSchedulerItem(timerUpdateEvent)
			{
				delayMs = delayMs,
				intervalMs = intervalMs,
				timerUpdateStopCondition = stopCondition
			};
			this.Schedule(timerEventSchedulerItem);
			return timerEventSchedulerItem;
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x0007F6C8 File Offset: 0x0007D8C8
		public ScheduledItem ScheduleForDuration(Action<TimerState> timerUpdateEvent, long delayMs, long intervalMs, long durationMs)
		{
			TimerEventScheduler.TimerEventSchedulerItem timerEventSchedulerItem = new TimerEventScheduler.TimerEventSchedulerItem(timerUpdateEvent)
			{
				delayMs = delayMs,
				intervalMs = intervalMs,
				timerUpdateStopCondition = null
			};
			timerEventSchedulerItem.SetDuration(durationMs);
			this.Schedule(timerEventSchedulerItem);
			return timerEventSchedulerItem;
		}

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeFieldInfoPtr_m_ScheduledItems;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeFieldInfoPtr_m_TransactionMode;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeFieldInfoPtr_m_ScheduleTransactions;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeFieldInfoPtr_m_UnscheduleTransactions;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeFieldInfoPtr_disableThrottling;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeFieldInfoPtr_m_LastUpdatedIndex;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Virtual_Final_New_Void_ScheduledItem_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_RemovedScheduledItemAt_Private_Boolean_Int32_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_Unschedule_Public_Virtual_Final_New_Void_ScheduledItem_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_PrivateUnSchedule_Private_Boolean_ScheduledItem_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_UpdateScheduledEvents_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200049B RID: 1179
		public class TimerEventSchedulerItem : ScheduledItem
		{
		}
	}
}
