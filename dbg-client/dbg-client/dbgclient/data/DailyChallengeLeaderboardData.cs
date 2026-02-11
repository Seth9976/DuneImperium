using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dbgclient.data
{
	// Token: 0x020000CA RID: 202
	public class DailyChallengeLeaderboardData : DataComponent
	{
		// Token: 0x06000890 RID: 2192 RVA: 0x000386AC File Offset: 0x000368AC
		// Note: this type is marked as 'beforefieldinit'.
		static DailyChallengeLeaderboardData()
		{
			Il2CppClassPointerStore<DailyChallengeLeaderboardData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "DailyChallengeLeaderboardData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailyChallengeLeaderboardData>.NativeClassPtr);
			DailyChallengeLeaderboardData.NativeFieldInfoPtr_Rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardData>.NativeClassPtr, "Rank");
			DailyChallengeLeaderboardData.NativeFieldInfoPtr_TotalPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardData>.NativeClassPtr, "TotalPoints");
			DailyChallengeLeaderboardData.NativeFieldInfoPtr_CurrentPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardData>.NativeClassPtr, "CurrentPoints");
			DailyChallengeLeaderboardData.NativeFieldInfoPtr_SilverMedals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardData>.NativeClassPtr, "SilverMedals");
			DailyChallengeLeaderboardData.NativeFieldInfoPtr_BronzeMedals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardData>.NativeClassPtr, "BronzeMedals");
			DailyChallengeLeaderboardData.NativeFieldInfoPtr_GoldMedals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardData>.NativeClassPtr, "GoldMedals");
			DailyChallengeLeaderboardData.NativeFieldInfoPtr_PlatinumMedals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardData>.NativeClassPtr, "PlatinumMedals");
			DailyChallengeLeaderboardData.NativeFieldInfoPtr_IsLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailyChallengeLeaderboardData>.NativeClassPtr, "IsLocalPlayer");
			DailyChallengeLeaderboardData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailyChallengeLeaderboardData>.NativeClassPtr, 100664549);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00038790 File Offset: 0x00036990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504776, RefRangeEnd = 504777, XrefRangeStart = 504775, XrefRangeEnd = 504776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailyChallengeLeaderboardData(int rank, int totalPoints, int currentPoints, int platinumMedals, int goldMedals, int silverMedals, int bronzeMedals, bool isLocalPlayer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailyChallengeLeaderboardData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rank;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalPoints;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentPoints;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref platinumMedals;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref goldMedals;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref silverMedals;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bronzeMedals;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLocalPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailyChallengeLeaderboardData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00006014 File Offset: 0x00004214
		public DailyChallengeLeaderboardData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x0003883C File Offset: 0x00036A3C
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x0000601D File Offset: 0x0000421D
		public unsafe int Rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_Rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_Rank)) = value;
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00038864 File Offset: 0x00036A64
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00006038 File Offset: 0x00004238
		public unsafe int TotalPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_TotalPoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_TotalPoints)) = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x0003888C File Offset: 0x00036A8C
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00006053 File Offset: 0x00004253
		public unsafe int CurrentPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_CurrentPoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_CurrentPoints)) = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x000388B4 File Offset: 0x00036AB4
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x0000606E File Offset: 0x0000426E
		public unsafe int SilverMedals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_SilverMedals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_SilverMedals)) = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x000388DC File Offset: 0x00036ADC
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x00006089 File Offset: 0x00004289
		public unsafe int BronzeMedals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_BronzeMedals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_BronzeMedals)) = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x00038904 File Offset: 0x00036B04
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x000060A4 File Offset: 0x000042A4
		public unsafe int GoldMedals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_GoldMedals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_GoldMedals)) = value;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x0003892C File Offset: 0x00036B2C
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x000060BF File Offset: 0x000042BF
		public unsafe int PlatinumMedals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_PlatinumMedals);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_PlatinumMedals)) = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x00038954 File Offset: 0x00036B54
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x000060DA File Offset: 0x000042DA
		public unsafe bool IsLocalPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_IsLocalPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailyChallengeLeaderboardData.NativeFieldInfoPtr_IsLocalPlayer)) = value;
			}
		}

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeFieldInfoPtr_Rank;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_TotalPoints;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeFieldInfoPtr_CurrentPoints;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeFieldInfoPtr_SilverMedals;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr_BronzeMedals;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_GoldMedals;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr_PlatinumMedals;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeFieldInfoPtr_IsLocalPlayer;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_Int32_Int32_Boolean_0;
	}
}
