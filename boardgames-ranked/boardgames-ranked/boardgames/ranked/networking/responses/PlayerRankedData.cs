using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace boardgames.ranked.networking.responses
{
	// Token: 0x02000012 RID: 18
	public class PlayerRankedData : Object
	{
		// Token: 0x06000071 RID: 113 RVA: 0x00004A1C File Offset: 0x00002C1C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerRankedData()
		{
			Il2CppClassPointerStore<PlayerRankedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking.responses", "PlayerRankedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerRankedData>.NativeClassPtr);
			PlayerRankedData.NativeFieldInfoPtr_Stars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerRankedData>.NativeClassPtr, "Stars");
			PlayerRankedData.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerRankedData>.NativeClassPtr, "Rank");
			PlayerRankedData.NativeFieldInfoPtr_Elo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerRankedData>.NativeClassPtr, "Elo");
			PlayerRankedData.NativeFieldInfoPtr_GamesPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerRankedData>.NativeClassPtr, "GamesPlayed");
			PlayerRankedData.NativeFieldInfoPtr_LeaderboardRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerRankedData>.NativeClassPtr, "LeaderboardRank");
			PlayerRankedData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerRankedData>.NativeClassPtr, 100663324);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004AC4 File Offset: 0x00002CC4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerRankedData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerRankedData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerRankedData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002523 File Offset: 0x00000723
		public PlayerRankedData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004B00 File Offset: 0x00002D00
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000252C File Offset: 0x0000072C
		public unsafe int Stars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRankedData.NativeFieldInfoPtr_Stars);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRankedData.NativeFieldInfoPtr_Stars)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00004B28 File Offset: 0x00002D28
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002547 File Offset: 0x00000747
		public unsafe RankName Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRankedData.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRankedData.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00004B50 File Offset: 0x00002D50
		// (set) Token: 0x06000079 RID: 121 RVA: 0x00002562 File Offset: 0x00000762
		public unsafe int Elo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRankedData.NativeFieldInfoPtr_Elo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRankedData.NativeFieldInfoPtr_Elo)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00004B78 File Offset: 0x00002D78
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000257D File Offset: 0x0000077D
		public unsafe int GamesPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRankedData.NativeFieldInfoPtr_GamesPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRankedData.NativeFieldInfoPtr_GamesPlayed)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00004BA0 File Offset: 0x00002DA0
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002598 File Offset: 0x00000798
		public Nullable<int> LeaderboardRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRankedData.NativeFieldInfoPtr_LeaderboardRank);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerRankedData.NativeFieldInfoPtr_LeaderboardRank), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_Stars;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_Elo;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_GamesPlayed;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_LeaderboardRank;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
