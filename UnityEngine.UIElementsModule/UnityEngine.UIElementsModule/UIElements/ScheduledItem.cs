using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000177 RID: 375
	public class ScheduledItem : Object
	{
		// Token: 0x06001BBF RID: 7103 RVA: 0x0007ECE8 File Offset: 0x0007CEE8
		// Note: this type is marked as 'beforefieldinit'.
		static ScheduledItem()
		{
			Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "ScheduledItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr);
			ScheduledItem.NativeFieldInfoPtr_timerUpdateStopCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "timerUpdateStopCondition");
			ScheduledItem.NativeFieldInfoPtr_OnceCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "OnceCondition");
			ScheduledItem.NativeFieldInfoPtr_ForeverCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "ForeverCondition");
			ScheduledItem.NativeFieldInfoPtr__startMs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "<startMs>k__BackingField");
			ScheduledItem.NativeFieldInfoPtr__delayMs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "<delayMs>k__BackingField");
			ScheduledItem.NativeFieldInfoPtr__intervalMs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "<intervalMs>k__BackingField");
			ScheduledItem.NativeFieldInfoPtr__endTimeMs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "<endTimeMs>k__BackingField");
			ScheduledItem.NativeMethodInfoPtr_get_startMs_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100667329);
			ScheduledItem.NativeMethodInfoPtr_set_startMs_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100667330);
			ScheduledItem.NativeMethodInfoPtr_get_delayMs_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100667331);
			ScheduledItem.NativeMethodInfoPtr_set_delayMs_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100667332);
			ScheduledItem.NativeMethodInfoPtr_get_intervalMs_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100667333);
			ScheduledItem.NativeMethodInfoPtr_set_intervalMs_Public_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100667334);
			ScheduledItem.NativeMethodInfoPtr_get_endTimeMs_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100667335);
			ScheduledItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100667336);
			ScheduledItem.NativeMethodInfoPtr_ResetStartTime_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100667337);
			ScheduledItem.NativeMethodInfoPtr_PerformTimerUpdate_Public_Abstract_Virtual_New_Void_TimerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100667338);
			ScheduledItem.NativeMethodInfoPtr_OnItemUnscheduled_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100667339);
			ScheduledItem.NativeMethodInfoPtr_ShouldUnschedule_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, 100667340);
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x0007EE94 File Offset: 0x0007D094
		// (set) Token: 0x06001BC1 RID: 7105 RVA: 0x0007EED0 File Offset: 0x0007D0D0
		public unsafe long startMs
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.NativeMethodInfoPtr_get_startMs_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.NativeMethodInfoPtr_set_startMs_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001BC2 RID: 7106 RVA: 0x0007EF10 File Offset: 0x0007D110
		// (set) Token: 0x06001BC3 RID: 7107 RVA: 0x0007EF4C File Offset: 0x0007D14C
		public unsafe long delayMs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.NativeMethodInfoPtr_get_delayMs_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.NativeMethodInfoPtr_set_delayMs_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001BC4 RID: 7108 RVA: 0x0007EF8C File Offset: 0x0007D18C
		// (set) Token: 0x06001BC5 RID: 7109 RVA: 0x0007EFC8 File Offset: 0x0007D1C8
		public unsafe long intervalMs
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.NativeMethodInfoPtr_get_intervalMs_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 312312, RefRangeEnd = 312313, XrefRangeStart = 312312, XrefRangeEnd = 312313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.NativeMethodInfoPtr_set_intervalMs_Public_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001BC6 RID: 7110 RVA: 0x0007F008 File Offset: 0x0007D208
		// (set) Token: 0x06001BDB RID: 7131 RVA: 0x0000C952 File Offset: 0x0000AB52
		public unsafe long endTimeMs
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.NativeMethodInfoPtr_get_endTimeMs_Public_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._endTimeMs_k__BackingField = value;
			}
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0007F044 File Offset: 0x0007D244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323398, RefRangeEnd = 323399, XrefRangeStart = 323388, XrefRangeEnd = 323398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScheduledItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x0007F080 File Offset: 0x0007D280
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323403, RefRangeEnd = 323405, XrefRangeStart = 323399, XrefRangeEnd = 323403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetStartTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.NativeMethodInfoPtr_ResetStartTime_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BC9 RID: 7113 RVA: 0x0007F0B4 File Offset: 0x0007D2B4
		[CallerCount(0)]
		public unsafe virtual void PerformTimerUpdate(TimerState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduledItem.NativeMethodInfoPtr_PerformTimerUpdate_Public_Abstract_Virtual_New_Void_TimerState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0007F100 File Offset: 0x0007D300
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnItemUnscheduled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduledItem.NativeMethodInfoPtr_OnItemUnscheduled_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x0007F13C File Offset: 0x0007D33C
		[CallerCount(0)]
		public unsafe virtual bool ShouldUnschedule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ScheduledItem.NativeMethodInfoPtr_ShouldUnschedule_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x0000C89A File Offset: 0x0000AA9A
		public ScheduledItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001BCD RID: 7117 RVA: 0x0007F184 File Offset: 0x0007D384
		// (set) Token: 0x06001BCE RID: 7118 RVA: 0x0000C8A3 File Offset: 0x0000AAA3
		public unsafe Func<bool> timerUpdateStopCondition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr_timerUpdateStopCondition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr_timerUpdateStopCondition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0007F1B4 File Offset: 0x0007D3B4
		// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x0000C8C2 File Offset: 0x0000AAC2
		public unsafe static Func<bool> OnceCondition
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScheduledItem.NativeFieldInfoPtr_OnceCondition, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScheduledItem.NativeFieldInfoPtr_OnceCondition, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x0007F1DC File Offset: 0x0007D3DC
		// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
		public unsafe static Func<bool> ForeverCondition
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ScheduledItem.NativeFieldInfoPtr_ForeverCondition, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ScheduledItem.NativeFieldInfoPtr_ForeverCondition, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x0007F204 File Offset: 0x0007D404
		// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x0000C8E6 File Offset: 0x0000AAE6
		public unsafe long _startMs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__startMs_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__startMs_k__BackingField)) = value;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x0007F22C File Offset: 0x0007D42C
		// (set) Token: 0x06001BD6 RID: 7126 RVA: 0x0000C901 File Offset: 0x0000AB01
		public unsafe long _delayMs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__delayMs_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__delayMs_k__BackingField)) = value;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001BD7 RID: 7127 RVA: 0x0007F254 File Offset: 0x0007D454
		// (set) Token: 0x06001BD8 RID: 7128 RVA: 0x0000C91C File Offset: 0x0000AB1C
		public unsafe long _intervalMs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__intervalMs_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__intervalMs_k__BackingField)) = value;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001BD9 RID: 7129 RVA: 0x0007F27C File Offset: 0x0007D47C
		// (set) Token: 0x06001BDA RID: 7130 RVA: 0x0000C937 File Offset: 0x0000AB37
		public unsafe long _endTimeMs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__endTimeMs_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScheduledItem.NativeFieldInfoPtr__endTimeMs_k__BackingField)) = value;
			}
		}

		// Token: 0x06001BDC RID: 7132 RVA: 0x0000C95B File Offset: 0x0000AB5B
		public void SetDuration(long durationMs)
		{
			this.endTimeMs = this.startMs + durationMs;
		}

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeFieldInfoPtr_timerUpdateStopCondition;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeFieldInfoPtr_OnceCondition;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeFieldInfoPtr_ForeverCondition;

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeFieldInfoPtr__startMs_k__BackingField;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeFieldInfoPtr__delayMs_k__BackingField;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeFieldInfoPtr__intervalMs_k__BackingField;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeFieldInfoPtr__endTimeMs_k__BackingField;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeMethodInfoPtr_get_startMs_Public_get_Int64_0;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr_set_startMs_Public_set_Void_Int64_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_get_delayMs_Public_get_Int64_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_set_delayMs_Public_set_Void_Int64_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_get_intervalMs_Public_get_Int64_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_set_intervalMs_Public_set_Void_Int64_0;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeMethodInfoPtr_get_endTimeMs_Public_get_Int64_0;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeMethodInfoPtr_ResetStartTime_Protected_Void_0;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_PerformTimerUpdate_Public_Abstract_Virtual_New_Void_TimerState_0;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeMethodInfoPtr_OnItemUnscheduled_Internal_Virtual_New_Void_0;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeMethodInfoPtr_ShouldUnschedule_Public_Virtual_New_Boolean_0;

		// Token: 0x02000499 RID: 1177
		[ObfuscatedName("UnityEngine.UIElements.ScheduledItem+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003D15 RID: 15637 RVA: 0x000F3C58 File Offset: 0x000F1E58
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScheduledItem>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr);
				ScheduledItem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr, "<>9");
				ScheduledItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr, 100667343);
				ScheduledItem.__c.NativeMethodInfoPtr___cctor_b__25_0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr, 100667344);
				ScheduledItem.__c.NativeMethodInfoPtr___cctor_b__25_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr, 100667345);
			}

			// Token: 0x06003D16 RID: 15638 RVA: 0x000F3CD4 File Offset: 0x000F1ED4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScheduledItem.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003D17 RID: 15639 RVA: 0x000F3D10 File Offset: 0x000F1F10
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__25_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.__c.NativeMethodInfoPtr___cctor_b__25_0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003D18 RID: 15640 RVA: 0x000F3D4C File Offset: 0x000F1F4C
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__25_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScheduledItem.__c.NativeMethodInfoPtr___cctor_b__25_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003D19 RID: 15641 RVA: 0x00019BFD File Offset: 0x00017DFD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001282 RID: 4738
			// (get) Token: 0x06003D1A RID: 15642 RVA: 0x000F3D88 File Offset: 0x000F1F88
			// (set) Token: 0x06003D1B RID: 15643 RVA: 0x00019C06 File Offset: 0x00017E06
			public unsafe static ScheduledItem.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ScheduledItem.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScheduledItem.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ScheduledItem.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B24 RID: 11044
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002B25 RID: 11045
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B26 RID: 11046
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__25_0_Internal_Boolean_0;

			// Token: 0x04002B27 RID: 11047
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__25_1_Internal_Boolean_0;
		}

		// Token: 0x0200049A RID: 1178
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
