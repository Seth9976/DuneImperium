using System;
using boardgames.ranked.networking.responses;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.ranked.networking.notifications
{
	// Token: 0x02000017 RID: 23
	public class RankedDataUpdated : NetworkMessageEvent
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00004D04 File Offset: 0x00002F04
		// Note: this type is marked as 'beforefieldinit'.
		static RankedDataUpdated()
		{
			Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking.notifications", "RankedDataUpdated");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr);
			RankedDataUpdated.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "AccountID");
			RankedDataUpdated.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "GameID");
			RankedDataUpdated.NativeFieldInfoPtr_Place = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "Place");
			RankedDataUpdated.NativeFieldInfoPtr_StartedElo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "StartedElo");
			RankedDataUpdated.NativeFieldInfoPtr_NewElo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "NewElo");
			RankedDataUpdated.NativeFieldInfoPtr_StartingStars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "StartingStars");
			RankedDataUpdated.NativeFieldInfoPtr_NewStars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "NewStars");
			RankedDataUpdated.NativeFieldInfoPtr_StartingRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "StartingRank");
			RankedDataUpdated.NativeFieldInfoPtr_NewRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "NewRank");
			RankedDataUpdated.NativeFieldInfoPtr_GamesPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "GamesPlayed");
			RankedDataUpdated.NativeFieldInfoPtr_LeaderboardRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "LeaderboardRank");
			RankedDataUpdated.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "Players");
			RankedDataUpdated.NativeFieldInfoPtr_GameStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, "GameStarted");
			RankedDataUpdated.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr, 100663328);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004E4C File Offset: 0x0000304C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedDataUpdated()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedDataUpdated>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedDataUpdated.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000266E File Offset: 0x0000086E
		public RankedDataUpdated(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004E88 File Offset: 0x00003088
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002677 File Offset: 0x00000877
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00004EB8 File Offset: 0x000030B8
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002696 File Offset: 0x00000896
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00004EE8 File Offset: 0x000030E8
		// (set) Token: 0x06000091 RID: 145 RVA: 0x000026B5 File Offset: 0x000008B5
		public unsafe int Place
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_Place);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_Place)) = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00004F10 File Offset: 0x00003110
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000026D0 File Offset: 0x000008D0
		public unsafe int StartedElo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_StartedElo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_StartedElo)) = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00004F38 File Offset: 0x00003138
		// (set) Token: 0x06000095 RID: 149 RVA: 0x000026EB File Offset: 0x000008EB
		public unsafe int NewElo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_NewElo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_NewElo)) = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00004F60 File Offset: 0x00003160
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002706 File Offset: 0x00000906
		public unsafe int StartingStars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_StartingStars);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_StartingStars)) = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00004F88 File Offset: 0x00003188
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00002721 File Offset: 0x00000921
		public unsafe int NewStars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_NewStars);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_NewStars)) = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00004FB0 File Offset: 0x000031B0
		// (set) Token: 0x0600009B RID: 155 RVA: 0x0000273C File Offset: 0x0000093C
		public unsafe RankName StartingRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_StartingRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_StartingRank)) = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00004FD8 File Offset: 0x000031D8
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002757 File Offset: 0x00000957
		public unsafe RankName NewRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_NewRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_NewRank)) = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00005000 File Offset: 0x00003200
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002772 File Offset: 0x00000972
		public unsafe int GamesPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_GamesPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_GamesPlayed)) = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00005028 File Offset: 0x00003228
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000278D File Offset: 0x0000098D
		public Nullable<int> LeaderboardRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_LeaderboardRank);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_LeaderboardRank), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00005058 File Offset: 0x00003258
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000027BB File Offset: 0x000009BB
		public unsafe Il2CppStringArray Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00005088 File Offset: 0x00003288
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000027DA File Offset: 0x000009DA
		public Nullable<long> GameStarted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_GameStarted);
				return new Nullable<long>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedDataUpdated.NativeFieldInfoPtr_GameStarted), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<long>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_Place;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_StartedElo;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_NewElo;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_StartingStars;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_NewStars;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_StartingRank;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_NewRank;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_GamesPlayed;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_LeaderboardRank;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_GameStarted;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
