using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dbgclient.data
{
	// Token: 0x020000C9 RID: 201
	[Serializable]
	public class DailyChallengeLeaderboardBadges : Object
	{
		// Token: 0x06000885 RID: 2181 RVA: 0x0003853C File Offset: 0x0003673C
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeLeaderboardBadges()
		{
			Il2CppClassPointerStore<DailyChallengeLeaderboardBadges>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "DailyChallengeLeaderboardBadges");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeLeaderboardBadges>.NativeClassPtr);
			DailyChallengeLeaderboardBadges.NativeFieldInfoPtr_platinum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardBadges>.NativeClassPtr, "platinum");
			DailyChallengeLeaderboardBadges.NativeFieldInfoPtr_gold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardBadges>.NativeClassPtr, "gold");
			DailyChallengeLeaderboardBadges.NativeFieldInfoPtr_silver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardBadges>.NativeClassPtr, "silver");
			DailyChallengeLeaderboardBadges.NativeFieldInfoPtr_bronze = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardBadges>.NativeClassPtr, "bronze");
			DailyChallengeLeaderboardBadges.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardBadges>.NativeClassPtr, 100664548);
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000385D0 File Offset: 0x000367D0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeLeaderboardBadges()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeLeaderboardBadges>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardBadges.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00005F9F File Offset: 0x0000419F
		public DailyChallengeLeaderboardBadges(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x0003860C File Offset: 0x0003680C
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00005FA8 File Offset: 0x000041A8
		public unsafe int platinum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardBadges.NativeFieldInfoPtr_platinum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardBadges.NativeFieldInfoPtr_platinum)) = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00038634 File Offset: 0x00036834
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00005FC3 File Offset: 0x000041C3
		public unsafe int gold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardBadges.NativeFieldInfoPtr_gold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardBadges.NativeFieldInfoPtr_gold)) = value;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0003865C File Offset: 0x0003685C
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00005FDE File Offset: 0x000041DE
		public unsafe int silver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardBadges.NativeFieldInfoPtr_silver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardBadges.NativeFieldInfoPtr_silver)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x00038684 File Offset: 0x00036884
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00005FF9 File Offset: 0x000041F9
		public unsafe int bronze
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardBadges.NativeFieldInfoPtr_bronze);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardBadges.NativeFieldInfoPtr_bronze)) = value;
			}
		}

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeFieldInfoPtr_platinum;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_gold;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeFieldInfoPtr_silver;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeFieldInfoPtr_bronze;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
