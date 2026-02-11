using System;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.networking.responses
{
	// Token: 0x02000067 RID: 103
	public class EventDefinition : Object
	{
		// Token: 0x060003E5 RID: 997 RVA: 0x000251E4 File Offset: 0x000233E4
		// Note: this type is marked as 'beforefieldinit'.
		static EventDefinition()
		{
			Il2CppClassPointerStore<EventDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr);
			EventDefinition.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, "id");
			EventDefinition.NativeFieldInfoPtr_timingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, "timingData");
			EventDefinition.NativeFieldInfoPtr_entryData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, "entryData");
			EventDefinition.NativeFieldInfoPtr_descriptionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, "descriptionData");
			EventDefinition.NativeFieldInfoPtr_roundData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, "roundData");
			EventDefinition.NativeMethodInfoPtr_GetLastRound_Public_EventRoundData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, 100663924);
			EventDefinition.NativeMethodInfoPtr_GetCurrentRoundByTime_Public_EventRoundData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, 100663925);
			EventDefinition.NativeMethodInfoPtr_GetFirstRegisterTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, 100663926);
			EventDefinition.NativeMethodInfoPtr_GetLastRegisterTime_Public_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, 100663927);
			EventDefinition.NativeMethodInfoPtr_MakeDataComposition_Public_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, 100663928);
			EventDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, 100663929);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000252F0 File Offset: 0x000234F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 693684, RefRangeEnd = 693686, XrefRangeStart = 693684, XrefRangeEnd = 693684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventRoundData GetLastRound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDefinition.NativeMethodInfoPtr_GetLastRound_Public_EventRoundData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventRoundData>(intPtr3) : null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00025330 File Offset: 0x00023530
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 693704, RefRangeEnd = 693709, XrefRangeStart = 693686, XrefRangeEnd = 693704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventRoundData GetCurrentRoundByTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDefinition.NativeMethodInfoPtr_GetCurrentRoundByTime_Public_EventRoundData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventRoundData>(intPtr3) : null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00025370 File Offset: 0x00023570
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 693733, RefRangeEnd = 693735, XrefRangeStart = 693709, XrefRangeEnd = 693733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime GetFirstRegisterTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDefinition.NativeMethodInfoPtr_GetFirstRegisterTime_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000253AC File Offset: 0x000235AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 693759, RefRangeEnd = 693760, XrefRangeStart = 693735, XrefRangeEnd = 693759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime GetLastRegisterTime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDefinition.NativeMethodInfoPtr_GetLastRegisterTime_Public_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000253E8 File Offset: 0x000235E8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 693802, RefRangeEnd = 693804, XrefRangeStart = 693760, XrefRangeEnd = 693802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataComposition MakeDataComposition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDefinition.NativeMethodInfoPtr_MakeDataComposition_Public_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00025428 File Offset: 0x00023628
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventDefinition()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00003BF7 File Offset: 0x00001DF7
		public EventDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00025464 File Offset: 0x00023664
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x00003C00 File Offset: 0x00001E00
		public unsafe EventID id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDefinition.NativeFieldInfoPtr_id);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDefinition.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00025494 File Offset: 0x00023694
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x00003C1F File Offset: 0x00001E1F
		public unsafe EventTimingData timingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDefinition.NativeFieldInfoPtr_timingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventTimingData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDefinition.NativeFieldInfoPtr_timingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000254C4 File Offset: 0x000236C4
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00003C3E File Offset: 0x00001E3E
		public unsafe EventEntryData entryData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDefinition.NativeFieldInfoPtr_entryData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventEntryData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDefinition.NativeFieldInfoPtr_entryData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000254F4 File Offset: 0x000236F4
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00003C5D File Offset: 0x00001E5D
		public unsafe EventDescriptionData descriptionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDefinition.NativeFieldInfoPtr_descriptionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDescriptionData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDefinition.NativeFieldInfoPtr_descriptionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00025524 File Offset: 0x00023724
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00003C7C File Offset: 0x00001E7C
		public unsafe Il2CppReferenceArray<EventRoundData> roundData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDefinition.NativeFieldInfoPtr_roundData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventRoundData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDefinition.NativeFieldInfoPtr_roundData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr_timingData;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_entryData;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_descriptionData;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_roundData;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_GetLastRound_Public_EventRoundData_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentRoundByTime_Public_EventRoundData_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_GetFirstRegisterTime_Public_DateTime_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_GetLastRegisterTime_Public_DateTime_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_MakeDataComposition_Public_DataComposition_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002EC RID: 748
		[ObfuscatedName("worm.networking.responses.EventDefinition+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E72 RID: 7794 RVA: 0x00075614 File Offset: 0x00073814
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EventDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDefinition.__c>.NativeClassPtr);
				EventDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDefinition.__c>.NativeClassPtr, "<>9");
				EventDefinition.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDefinition.__c>.NativeClassPtr, "<>9__7_0");
				EventDefinition.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDefinition.__c>.NativeClassPtr, "<>9__8_0");
				EventDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDefinition.__c>.NativeClassPtr, 100663931);
				EventDefinition.__c.NativeMethodInfoPtr__GetFirstRegisterTime_b__7_0_Internal_Boolean_EventRoundData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDefinition.__c>.NativeClassPtr, 100663932);
				EventDefinition.__c.NativeMethodInfoPtr__GetLastRegisterTime_b__8_0_Internal_Boolean_EventRoundData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDefinition.__c>.NativeClassPtr, 100663933);
			}

			// Token: 0x06001E73 RID: 7795 RVA: 0x000756B8 File Offset: 0x000738B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E74 RID: 7796 RVA: 0x000756F4 File Offset: 0x000738F4
			[CallerCount(0)]
			public unsafe bool _GetFirstRegisterTime_b__7_0(EventRoundData r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDefinition.__c.NativeMethodInfoPtr__GetFirstRegisterTime_b__7_0_Internal_Boolean_EventRoundData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E75 RID: 7797 RVA: 0x00075744 File Offset: 0x00073944
			[CallerCount(0)]
			public unsafe bool _GetLastRegisterTime_b__8_0(EventRoundData r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDefinition.__c.NativeMethodInfoPtr__GetLastRegisterTime_b__8_0_Internal_Boolean_EventRoundData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E76 RID: 7798 RVA: 0x00011489 File Offset: 0x0000F689
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700085B RID: 2139
			// (get) Token: 0x06001E77 RID: 7799 RVA: 0x00075794 File Offset: 0x00073994
			// (set) Token: 0x06001E78 RID: 7800 RVA: 0x00011492 File Offset: 0x0000F692
			public unsafe static EventDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EventDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EventDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085C RID: 2140
			// (get) Token: 0x06001E79 RID: 7801 RVA: 0x000757BC File Offset: 0x000739BC
			// (set) Token: 0x06001E7A RID: 7802 RVA: 0x000114A4 File Offset: 0x0000F6A4
			public unsafe static Func<EventRoundData, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EventDefinition.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EventRoundData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EventDefinition.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700085D RID: 2141
			// (get) Token: 0x06001E7B RID: 7803 RVA: 0x000757E4 File Offset: 0x000739E4
			// (set) Token: 0x06001E7C RID: 7804 RVA: 0x000114B6 File Offset: 0x0000F6B6
			public unsafe static Func<EventRoundData, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EventDefinition.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EventRoundData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EventDefinition.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011A5 RID: 4517
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040011A6 RID: 4518
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040011A7 RID: 4519
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040011A8 RID: 4520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011A9 RID: 4521
			private static readonly IntPtr NativeMethodInfoPtr__GetFirstRegisterTime_b__7_0_Internal_Boolean_EventRoundData_0;

			// Token: 0x040011AA RID: 4522
			private static readonly IntPtr NativeMethodInfoPtr__GetLastRegisterTime_b__8_0_Internal_Boolean_EventRoundData_0;
		}

		// Token: 0x020002ED RID: 749
		[ObfuscatedName("worm.networking.responses.EventDefinition+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06001E7D RID: 7805 RVA: 0x0007580C File Offset: 0x00073A0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<EventDefinition.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventDefinition>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventDefinition.__c__DisplayClass6_0>.NativeClassPtr);
				EventDefinition.__c__DisplayClass6_0.NativeFieldInfoPtr_now = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventDefinition.__c__DisplayClass6_0>.NativeClassPtr, "now");
				EventDefinition.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDefinition.__c__DisplayClass6_0>.NativeClassPtr, 100663934);
				EventDefinition.__c__DisplayClass6_0.NativeMethodInfoPtr__GetCurrentRoundByTime_b__0_Internal_Boolean_EventRoundData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventDefinition.__c__DisplayClass6_0>.NativeClassPtr, 100663935);
			}

			// Token: 0x06001E7E RID: 7806 RVA: 0x00075874 File Offset: 0x00073A74
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventDefinition.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDefinition.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E7F RID: 7807 RVA: 0x000758B0 File Offset: 0x00073AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693676, XrefRangeEnd = 693684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetCurrentRoundByTime_b__0(EventRoundData r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventDefinition.__c__DisplayClass6_0.NativeMethodInfoPtr__GetCurrentRoundByTime_b__0_Internal_Boolean_EventRoundData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E80 RID: 7808 RVA: 0x000114C8 File Offset: 0x0000F6C8
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700085E RID: 2142
			// (get) Token: 0x06001E81 RID: 7809 RVA: 0x00075900 File Offset: 0x00073B00
			// (set) Token: 0x06001E82 RID: 7810 RVA: 0x000114D1 File Offset: 0x0000F6D1
			public unsafe DateTime now
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDefinition.__c__DisplayClass6_0.NativeFieldInfoPtr_now);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventDefinition.__c__DisplayClass6_0.NativeFieldInfoPtr_now)) = value;
				}
			}

			// Token: 0x040011AB RID: 4523
			private static readonly IntPtr NativeFieldInfoPtr_now;

			// Token: 0x040011AC RID: 4524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011AD RID: 4525
			private static readonly IntPtr NativeMethodInfoPtr__GetCurrentRoundByTime_b__0_Internal_Boolean_EventRoundData_0;
		}
	}
}
