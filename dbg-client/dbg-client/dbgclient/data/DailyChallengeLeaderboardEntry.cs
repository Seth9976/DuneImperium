using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dbgclient.data
{
	// Token: 0x020000C8 RID: 200
	[Serializable]
	public class DailyChallengeLeaderboardEntry : Object
	{
		// Token: 0x06000872 RID: 2162 RVA: 0x000382CC File Offset: 0x000364CC
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeLeaderboardEntry()
		{
			Il2CppClassPointerStore<DailyChallengeLeaderboardEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "DailyChallengeLeaderboardEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeLeaderboardEntry>.NativeClassPtr);
			DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardEntry>.NativeClassPtr, "accountID");
			DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_screenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardEntry>.NativeClassPtr, "screenName");
			DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardEntry>.NativeClassPtr, "rank");
			DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_totalScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardEntry>.NativeClassPtr, "totalScore");
			DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_currentScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardEntry>.NativeClassPtr, "currentScore");
			DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_badges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardEntry>.NativeClassPtr, "badges");
			DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_timestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardEntry>.NativeClassPtr, "timestamp");
			DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_xuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardEntry>.NativeClassPtr, "xuid");
			DailyChallengeLeaderboardEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardEntry>.NativeClassPtr, 100664547);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000383B0 File Offset: 0x000365B0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeLeaderboardEntry()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeLeaderboardEntry>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00005EAE File Offset: 0x000040AE
		public DailyChallengeLeaderboardEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x000383EC File Offset: 0x000365EC
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00005EB7 File Offset: 0x000040B7
		public unsafe AccountID accountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_accountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0003841C File Offset: 0x0003661C
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00005ED6 File Offset: 0x000040D6
		public unsafe string screenName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_screenName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_screenName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00038444 File Offset: 0x00036644
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00005EF5 File Offset: 0x000040F5
		public unsafe int rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_rank)) = value;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0003846C File Offset: 0x0003666C
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x00005F10 File Offset: 0x00004110
		public unsafe int totalScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_totalScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_totalScore)) = value;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00038494 File Offset: 0x00036694
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x00005F2B File Offset: 0x0000412B
		public unsafe int currentScore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_currentScore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_currentScore)) = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x000384BC File Offset: 0x000366BC
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x00005F46 File Offset: 0x00004146
		public unsafe DailyChallengeLeaderboardBadges badges
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_badges);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeLeaderboardBadges>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_badges), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x000384EC File Offset: 0x000366EC
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x00005F65 File Offset: 0x00004165
		public unsafe long timestamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_timestamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_timestamp)) = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00038514 File Offset: 0x00036714
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x00005F80 File Offset: 0x00004180
		public unsafe string xuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_xuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardEntry.NativeFieldInfoPtr_xuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeFieldInfoPtr_accountID;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeFieldInfoPtr_screenName;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeFieldInfoPtr_rank;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeFieldInfoPtr_totalScore;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeFieldInfoPtr_currentScore;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeFieldInfoPtr_badges;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeFieldInfoPtr_timestamp;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeFieldInfoPtr_xuid;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
