using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.networking.responses
{
	// Token: 0x0200006D RID: 109
	public class EventEntry : Object
	{
		// Token: 0x06000434 RID: 1076 RVA: 0x00025DA0 File Offset: 0x00023FA0
		// Note: this type is marked as 'beforefieldinit'.
		static EventEntry()
		{
			Il2CppClassPointerStore<EventEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventEntry>.NativeClassPtr);
			EventEntry.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntry>.NativeClassPtr, "id");
			EventEntry.NativeFieldInfoPtr_eventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntry>.NativeClassPtr, "eventID");
			EventEntry.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntry>.NativeClassPtr, "accountID");
			EventEntry.NativeFieldInfoPtr_roundID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntry>.NativeClassPtr, "roundID");
			EventEntry.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntry>.NativeClassPtr, "active");
			EventEntry.NativeFieldInfoPtr_runCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntry>.NativeClassPtr, "runCount");
			EventEntry.NativeFieldInfoPtr_leaderboardEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntry>.NativeClassPtr, "leaderboardEntry");
			EventEntry.NativeFieldInfoPtr_matchHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntry>.NativeClassPtr, "matchHistory");
			EventEntry.NativeMethodInfoPtr_GetGamesPlayed_Public_Int32_RoundID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventEntry>.NativeClassPtr, 100663941);
			EventEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventEntry>.NativeClassPtr, 100663942);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00025E98 File Offset: 0x00024098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 693823, RefRangeEnd = 693825, XrefRangeStart = 693809, XrefRangeEnd = 693823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGamesPlayed(RoundID inRound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inRound);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventEntry.NativeMethodInfoPtr_GetGamesPlayed_Public_Int32_RoundID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00025EE8 File Offset: 0x000240E8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00004013 File Offset: 0x00002213
		public EventEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x00025F24 File Offset: 0x00024124
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x0000401C File Offset: 0x0000221C
		public unsafe EntryID id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_id);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntryID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00025F54 File Offset: 0x00024154
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x0000403B File Offset: 0x0000223B
		public unsafe EventID eventID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_eventID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_eventID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x00025F84 File Offset: 0x00024184
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x0000405A File Offset: 0x0000225A
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x00025FB4 File Offset: 0x000241B4
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00004079 File Offset: 0x00002279
		public unsafe RoundID roundID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_roundID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_roundID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x00025FE4 File Offset: 0x000241E4
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00004098 File Offset: 0x00002298
		public unsafe bool active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_active)) = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0002600C File Offset: 0x0002420C
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x000040B3 File Offset: 0x000022B3
		public unsafe int runCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_runCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_runCount)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x00026034 File Offset: 0x00024234
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x000040CE File Offset: 0x000022CE
		public unsafe EventEntryLeaderboardEntry leaderboardEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_leaderboardEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventEntryLeaderboardEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_leaderboardEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000446 RID: 1094 RVA: 0x00026064 File Offset: 0x00024264
		// (set) Token: 0x06000447 RID: 1095 RVA: 0x000040ED File Offset: 0x000022ED
		public unsafe Il2CppReferenceArray<EventEntryMatchHistory> matchHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_matchHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EventEntryMatchHistory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.NativeFieldInfoPtr_matchHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr_eventID;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeFieldInfoPtr_roundID;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr_active;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_runCount;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr_leaderboardEntry;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr_matchHistory;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_GetGamesPlayed_Public_Int32_RoundID_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002EE RID: 750
		[ObfuscatedName("worm.networking.responses.EventEntry+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06001E83 RID: 7811 RVA: 0x00075928 File Offset: 0x00073B28
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<EventEntry.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EventEntry>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventEntry.__c__DisplayClass8_0>.NativeClassPtr);
				EventEntry.__c__DisplayClass8_0.NativeFieldInfoPtr_inRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntry.__c__DisplayClass8_0>.NativeClassPtr, "inRound");
				EventEntry.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventEntry.__c__DisplayClass8_0>.NativeClassPtr, 100663943);
				EventEntry.__c__DisplayClass8_0.NativeMethodInfoPtr__GetGamesPlayed_b__0_Internal_Boolean_EventEntryMatchHistory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventEntry.__c__DisplayClass8_0>.NativeClassPtr, 100663944);
			}

			// Token: 0x06001E84 RID: 7812 RVA: 0x00075990 File Offset: 0x00073B90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventEntry.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventEntry.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E85 RID: 7813 RVA: 0x000759CC File Offset: 0x00073BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 693804, XrefRangeEnd = 693809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetGamesPlayed_b__0(EventEntryMatchHistory m)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventEntry.__c__DisplayClass8_0.NativeMethodInfoPtr__GetGamesPlayed_b__0_Internal_Boolean_EventEntryMatchHistory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001E86 RID: 7814 RVA: 0x000114EC File Offset: 0x0000F6EC
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700085F RID: 2143
			// (get) Token: 0x06001E87 RID: 7815 RVA: 0x00075A1C File Offset: 0x00073C1C
			// (set) Token: 0x06001E88 RID: 7816 RVA: 0x000114F5 File Offset: 0x0000F6F5
			public unsafe RoundID inRound
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.__c__DisplayClass8_0.NativeFieldInfoPtr_inRound);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntry.__c__DisplayClass8_0.NativeFieldInfoPtr_inRound), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011AE RID: 4526
			private static readonly IntPtr NativeFieldInfoPtr_inRound;

			// Token: 0x040011AF RID: 4527
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011B0 RID: 4528
			private static readonly IntPtr NativeMethodInfoPtr__GetGamesPlayed_b__0_Internal_Boolean_EventEntryMatchHistory_0;
		}
	}
}
