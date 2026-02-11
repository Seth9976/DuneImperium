using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.networking.responses
{
	// Token: 0x0200006F RID: 111
	public class EventEntryLeaderboardEntry : Object
	{
		// Token: 0x06000457 RID: 1111 RVA: 0x000262AC File Offset: 0x000244AC
		// Note: this type is marked as 'beforefieldinit'.
		static EventEntryLeaderboardEntry()
		{
			Il2CppClassPointerStore<EventEntryLeaderboardEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventEntryLeaderboardEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventEntryLeaderboardEntry>.NativeClassPtr);
			EventEntryLeaderboardEntry.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryLeaderboardEntry>.NativeClassPtr, "score");
			EventEntryLeaderboardEntry.NativeFieldInfoPtr_strengthOfSchedule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryLeaderboardEntry>.NativeClassPtr, "strengthOfSchedule");
			EventEntryLeaderboardEntry.NativeFieldInfoPtr_finishedInPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventEntryLeaderboardEntry>.NativeClassPtr, "finishedInPlace");
			EventEntryLeaderboardEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventEntryLeaderboardEntry>.NativeClassPtr, 100663946);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x0002632C File Offset: 0x0002452C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventEntryLeaderboardEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventEntryLeaderboardEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventEntryLeaderboardEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000041ED File Offset: 0x000023ED
		public EventEntryLeaderboardEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00026368 File Offset: 0x00024568
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x000041F6 File Offset: 0x000023F6
		public unsafe int score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryLeaderboardEntry.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryLeaderboardEntry.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00026390 File Offset: 0x00024590
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00004211 File Offset: 0x00002411
		public unsafe int strengthOfSchedule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryLeaderboardEntry.NativeFieldInfoPtr_strengthOfSchedule);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryLeaderboardEntry.NativeFieldInfoPtr_strengthOfSchedule)) = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x000263B8 File Offset: 0x000245B8
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x0000422C File Offset: 0x0000242C
		public unsafe Dictionary<int, int> finishedInPlace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryLeaderboardEntry.NativeFieldInfoPtr_finishedInPlace);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventEntryLeaderboardEntry.NativeFieldInfoPtr_finishedInPlace), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_strengthOfSchedule;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_finishedInPlace;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
