using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.networking.responses
{
	// Token: 0x02000074 RID: 116
	public class EventLeaderboardEntry : Object
	{
		// Token: 0x0600047C RID: 1148 RVA: 0x000267F0 File Offset: 0x000249F0
		// Note: this type is marked as 'beforefieldinit'.
		static EventLeaderboardEntry()
		{
			Il2CppClassPointerStore<EventLeaderboardEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.networking.responses", "EventLeaderboardEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventLeaderboardEntry>.NativeClassPtr);
			EventLeaderboardEntry.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventLeaderboardEntry>.NativeClassPtr, "accountID");
			EventLeaderboardEntry.NativeFieldInfoPtr_screenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventLeaderboardEntry>.NativeClassPtr, "screenName");
			EventLeaderboardEntry.NativeFieldInfoPtr_score = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventLeaderboardEntry>.NativeClassPtr, "score");
			EventLeaderboardEntry.NativeFieldInfoPtr_strengthOfSchedule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventLeaderboardEntry>.NativeClassPtr, "strengthOfSchedule");
			EventLeaderboardEntry.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventLeaderboardEntry>.NativeClassPtr, "rank");
			EventLeaderboardEntry.NativeFieldInfoPtr_gamesPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventLeaderboardEntry>.NativeClassPtr, "gamesPlayed");
			EventLeaderboardEntry.NativeFieldInfoPtr_xuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventLeaderboardEntry>.NativeClassPtr, "xuid");
			EventLeaderboardEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventLeaderboardEntry>.NativeClassPtr, 100663951);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000268C0 File Offset: 0x00024AC0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventLeaderboardEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventLeaderboardEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventLeaderboardEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00004367 File Offset: 0x00002567
		public EventLeaderboardEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x000268FC File Offset: 0x00024AFC
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00004370 File Offset: 0x00002570
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x0002692C File Offset: 0x00024B2C
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x0000438F File Offset: 0x0000258F
		public unsafe string screenName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_screenName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_screenName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00026954 File Offset: 0x00024B54
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x000043AE File Offset: 0x000025AE
		public unsafe int score
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_score);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_score)) = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0002697C File Offset: 0x00024B7C
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x000043C9 File Offset: 0x000025C9
		public unsafe int strengthOfSchedule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_strengthOfSchedule);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_strengthOfSchedule)) = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x000269A4 File Offset: 0x00024BA4
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x000043E4 File Offset: 0x000025E4
		public unsafe int rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_rank)) = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x000269CC File Offset: 0x00024BCC
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x000043FF File Offset: 0x000025FF
		public unsafe int gamesPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_gamesPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_gamesPlayed)) = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x000269F4 File Offset: 0x00024BF4
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x0000441A File Offset: 0x0000261A
		public unsafe string xuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_xuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventLeaderboardEntry.NativeFieldInfoPtr_xuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_screenName;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_score;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_strengthOfSchedule;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_rank;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_gamesPlayed;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr_xuid;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
