using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace boardgames.ranked.networking.responses
{
	// Token: 0x0200000E RID: 14
	public class RankedLeaderboardEntry : Object
	{
		// Token: 0x06000043 RID: 67 RVA: 0x000043E0 File Offset: 0x000025E0
		// Note: this type is marked as 'beforefieldinit'.
		static RankedLeaderboardEntry()
		{
			Il2CppClassPointerStore<RankedLeaderboardEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.networking.responses", "RankedLeaderboardEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankedLeaderboardEntry>.NativeClassPtr);
			RankedLeaderboardEntry.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardEntry>.NativeClassPtr, "AccountID");
			RankedLeaderboardEntry.NativeFieldInfoPtr_ScreenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardEntry>.NativeClassPtr, "ScreenName");
			RankedLeaderboardEntry.NativeFieldInfoPtr_Elo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardEntry>.NativeClassPtr, "Elo");
			RankedLeaderboardEntry.NativeFieldInfoPtr_GamesPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardEntry>.NativeClassPtr, "GamesPlayed");
			RankedLeaderboardEntry.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardEntry>.NativeClassPtr, "Rank");
			RankedLeaderboardEntry.NativeFieldInfoPtr_xuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankedLeaderboardEntry>.NativeClassPtr, "xuid");
			RankedLeaderboardEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankedLeaderboardEntry>.NativeClassPtr, 100663320);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000449C File Offset: 0x0000269C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankedLeaderboardEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankedLeaderboardEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankedLeaderboardEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000022CC File Offset: 0x000004CC
		public RankedLeaderboardEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000046 RID: 70 RVA: 0x000044D8 File Offset: 0x000026D8
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000022D5 File Offset: 0x000004D5
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntry.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntry.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00004508 File Offset: 0x00002708
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000022F4 File Offset: 0x000004F4
		public unsafe string ScreenName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntry.NativeFieldInfoPtr_ScreenName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntry.NativeFieldInfoPtr_ScreenName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00004530 File Offset: 0x00002730
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002313 File Offset: 0x00000513
		public unsafe int Elo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntry.NativeFieldInfoPtr_Elo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntry.NativeFieldInfoPtr_Elo)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00004558 File Offset: 0x00002758
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000232E File Offset: 0x0000052E
		public unsafe int GamesPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntry.NativeFieldInfoPtr_GamesPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntry.NativeFieldInfoPtr_GamesPlayed)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00004580 File Offset: 0x00002780
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002349 File Offset: 0x00000549
		public unsafe int Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntry.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntry.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000050 RID: 80 RVA: 0x000045A8 File Offset: 0x000027A8
		// (set) Token: 0x06000051 RID: 81 RVA: 0x00002364 File Offset: 0x00000564
		public unsafe string xuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntry.NativeFieldInfoPtr_xuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RankedLeaderboardEntry.NativeFieldInfoPtr_xuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_ScreenName;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_Elo;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_GamesPlayed;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_xuid;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
