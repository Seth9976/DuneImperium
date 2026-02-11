using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000B1 RID: 177
	public class SteamUserStats : SteamClientClass<SteamUserStats>
	{
		// Token: 0x06000B4D RID: 2893 RVA: 0x0004DFE0 File Offset: 0x0004C1E0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUserStats()
		{
			Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamUserStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr);
			SteamUserStats.NativeFieldInfoPtr__StatsRecieved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, "<StatsRecieved>k__BackingField");
			SteamUserStats.NativeFieldInfoPtr_OnAchievementIconFetched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, "OnAchievementIconFetched");
			SteamUserStats.NativeFieldInfoPtr_OnUserStatsReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, "OnUserStatsReceived");
			SteamUserStats.NativeFieldInfoPtr_OnUserStatsStored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, "OnUserStatsStored");
			SteamUserStats.NativeFieldInfoPtr_OnAchievementProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, "OnAchievementProgress");
			SteamUserStats.NativeFieldInfoPtr_OnUserStatsUnloaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, "OnUserStatsUnloaded");
			SteamUserStats.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamUserStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666069);
			SteamUserStats.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666070);
			SteamUserStats.NativeMethodInfoPtr_get_StatsRecieved_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666071);
			SteamUserStats.NativeMethodInfoPtr_set_StatsRecieved_Internal_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666072);
			SteamUserStats.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666073);
			SteamUserStats.NativeMethodInfoPtr_add_OnAchievementIconFetched_Internal_Static_add_Void_Action_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666074);
			SteamUserStats.NativeMethodInfoPtr_remove_OnAchievementIconFetched_Internal_Static_rem_Void_Action_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666075);
			SteamUserStats.NativeMethodInfoPtr_add_OnUserStatsReceived_Public_Static_add_Void_Action_2_SteamId_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666076);
			SteamUserStats.NativeMethodInfoPtr_remove_OnUserStatsReceived_Public_Static_rem_Void_Action_2_SteamId_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666077);
			SteamUserStats.NativeMethodInfoPtr_add_OnUserStatsStored_Public_Static_add_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666078);
			SteamUserStats.NativeMethodInfoPtr_remove_OnUserStatsStored_Public_Static_rem_Void_Action_1_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666079);
			SteamUserStats.NativeMethodInfoPtr_add_OnAchievementProgress_Public_Static_add_Void_Action_3_Achievement_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666080);
			SteamUserStats.NativeMethodInfoPtr_remove_OnAchievementProgress_Public_Static_rem_Void_Action_3_Achievement_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666081);
			SteamUserStats.NativeMethodInfoPtr_add_OnUserStatsUnloaded_Public_Static_add_Void_Action_1_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666082);
			SteamUserStats.NativeMethodInfoPtr_remove_OnUserStatsUnloaded_Public_Static_rem_Void_Action_1_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666083);
			SteamUserStats.NativeMethodInfoPtr_get_Achievements_Public_Static_get_IEnumerable_1_Achievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666084);
			SteamUserStats.NativeMethodInfoPtr_IndicateAchievementProgress_Public_Static_Boolean_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666085);
			SteamUserStats.NativeMethodInfoPtr_PlayerCountAsync_Public_Static_Task_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666086);
			SteamUserStats.NativeMethodInfoPtr_StoreStats_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666087);
			SteamUserStats.NativeMethodInfoPtr_RequestCurrentStats_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666088);
			SteamUserStats.NativeMethodInfoPtr_RequestGlobalStatsAsync_Public_Static_Task_1_Result_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666089);
			SteamUserStats.NativeMethodInfoPtr_FindOrCreateLeaderboardAsync_Public_Static_Task_1_Nullable_1_Leaderboard_String_LeaderboardSort_LeaderboardDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666090);
			SteamUserStats.NativeMethodInfoPtr_FindLeaderboardAsync_Public_Static_Task_1_Nullable_1_Leaderboard_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666091);
			SteamUserStats.NativeMethodInfoPtr_AddStat_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666092);
			SteamUserStats.NativeMethodInfoPtr_AddStat_Public_Static_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666093);
			SteamUserStats.NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666094);
			SteamUserStats.NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666095);
			SteamUserStats.NativeMethodInfoPtr_GetStatInt_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666096);
			SteamUserStats.NativeMethodInfoPtr_GetStatFloat_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666097);
			SteamUserStats.NativeMethodInfoPtr_ResetAll_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666098);
			SteamUserStats.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, 100666099);
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x0004E2F4 File Offset: 0x0004C4F4
		public unsafe static ISteamUserStats Internal
		{
			[CallerCount(60)]
			[CachedScanResults(RefRangeStart = 945209, RefRangeEnd = 945269, XrefRangeStart = 945206, XrefRangeEnd = 945209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamUserStats_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamUserStats>(intPtr3) : null;
			}
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x0004E328 File Offset: 0x0004C528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945269, XrefRangeEnd = 945277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamUserStats.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0004E374 File Offset: 0x0004C574
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x0004E3A4 File Offset: 0x0004C5A4
		public unsafe static bool StatsRecieved
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945277, XrefRangeEnd = 945279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_get_StatsRecieved_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945279, XrefRangeEnd = 945281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_set_StatsRecieved_Internal_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0004E3D8 File Offset: 0x0004C5D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 945378, RefRangeEnd = 945379, XrefRangeStart = 945281, XrefRangeEnd = 945378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0004E400 File Offset: 0x0004C600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 945388, RefRangeEnd = 945389, XrefRangeStart = 945379, XrefRangeEnd = 945388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnAchievementIconFetched(Action<string, int> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_add_OnAchievementIconFetched_Internal_Static_add_Void_Action_2_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0004E438 File Offset: 0x0004C638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945389, XrefRangeEnd = 945398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnAchievementIconFetched(Action<string, int> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_remove_OnAchievementIconFetched_Internal_Static_rem_Void_Action_2_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x0004E470 File Offset: 0x0004C670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945398, XrefRangeEnd = 945407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnUserStatsReceived(Action<SteamId, Result> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_add_OnUserStatsReceived_Public_Static_add_Void_Action_2_SteamId_Result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x0004E4A8 File Offset: 0x0004C6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945407, XrefRangeEnd = 945416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnUserStatsReceived(Action<SteamId, Result> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_remove_OnUserStatsReceived_Public_Static_rem_Void_Action_2_SteamId_Result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0004E4E0 File Offset: 0x0004C6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945416, XrefRangeEnd = 945425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnUserStatsStored(Action<Result> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_add_OnUserStatsStored_Public_Static_add_Void_Action_1_Result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0004E518 File Offset: 0x0004C718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945425, XrefRangeEnd = 945434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnUserStatsStored(Action<Result> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_remove_OnUserStatsStored_Public_Static_rem_Void_Action_1_Result_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0004E550 File Offset: 0x0004C750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945434, XrefRangeEnd = 945443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnAchievementProgress(Action<Achievement, int, int> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_add_OnAchievementProgress_Public_Static_add_Void_Action_3_Achievement_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x0004E588 File Offset: 0x0004C788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945443, XrefRangeEnd = 945452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnAchievementProgress(Action<Achievement, int, int> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_remove_OnAchievementProgress_Public_Static_rem_Void_Action_3_Achievement_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x0004E5C0 File Offset: 0x0004C7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945452, XrefRangeEnd = 945461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnUserStatsUnloaded(Action<SteamId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_add_OnUserStatsUnloaded_Public_Static_add_Void_Action_1_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x0004E5F8 File Offset: 0x0004C7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945461, XrefRangeEnd = 945470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnUserStatsUnloaded(Action<SteamId> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_remove_OnUserStatsUnloaded_Public_Static_rem_Void_Action_1_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0004E630 File Offset: 0x0004C830
		public unsafe static IEnumerable<Achievement> Achievements
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945470, XrefRangeEnd = 945475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_get_Achievements_Public_Static_get_IEnumerable_1_Achievement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Achievement>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0004E664 File Offset: 0x0004C864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945475, XrefRangeEnd = 945478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IndicateAchievementProgress(string achName, int curProg, int maxProg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(achName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref curProg;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxProg;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_IndicateAchievementProgress_Public_Static_Boolean_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0004E6C4 File Offset: 0x0004C8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945478, XrefRangeEnd = 945491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<int> PlayerCountAsync()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_PlayerCountAsync_Public_Static_Task_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0004E6F8 File Offset: 0x0004C8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945491, XrefRangeEnd = 945494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StoreStats()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_StoreStats_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0004E728 File Offset: 0x0004C928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945494, XrefRangeEnd = 945497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestCurrentStats()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_RequestCurrentStats_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0004E758 File Offset: 0x0004C958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945497, XrefRangeEnd = 945510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Result> RequestGlobalStatsAsync(int days)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref days;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_RequestGlobalStatsAsync_Public_Static_Task_1_Result_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Result>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0004E798 File Offset: 0x0004C998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945510, XrefRangeEnd = 945524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<Leaderboard>> FindOrCreateLeaderboardAsync(string name, LeaderboardSort sort, LeaderboardDisplay display)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sort;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref display;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_FindOrCreateLeaderboardAsync_Public_Static_Task_1_Nullable_1_Leaderboard_String_LeaderboardSort_LeaderboardDisplay_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Leaderboard>>>(intPtr3) : null;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0004E7F8 File Offset: 0x0004C9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945524, XrefRangeEnd = 945538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Nullable<Leaderboard>> FindLeaderboardAsync(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_FindLeaderboardAsync_Public_Static_Task_1_Nullable_1_Leaderboard_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Nullable<Leaderboard>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0004E83C File Offset: 0x0004CA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945538, XrefRangeEnd = 945544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddStat(string name, int amount = 1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_AddStat_Public_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0004E88C File Offset: 0x0004CA8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945544, XrefRangeEnd = 945550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AddStat(string name, float amount = 1f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_AddStat_Public_Static_Boolean_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0004E8DC File Offset: 0x0004CADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945550, XrefRangeEnd = 945553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetStat(string name, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0004E92C File Offset: 0x0004CB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945553, XrefRangeEnd = 945556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetStat(string name, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0004E97C File Offset: 0x0004CB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945556, XrefRangeEnd = 945558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetStatInt(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetStatInt_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0004E9C0 File Offset: 0x0004CBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945558, XrefRangeEnd = 945560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetStatFloat(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_GetStatFloat_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0004EA04 File Offset: 0x0004CC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945560, XrefRangeEnd = 945563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ResetAll(bool includeAchievements)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includeAchievements;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr_ResetAll_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0004EA44 File Offset: 0x0004CC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945563, XrefRangeEnd = 945566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamUserStats()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x00002DAE File Offset: 0x00000FAE
		public SteamUserStats(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0004EA80 File Offset: 0x0004CC80
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x00002DB7 File Offset: 0x00000FB7
		public unsafe static bool _StatsRecieved_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SteamUserStats.NativeFieldInfoPtr__StatsRecieved_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUserStats.NativeFieldInfoPtr__StatsRecieved_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x0004EA9C File Offset: 0x0004CC9C
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00002DC5 File Offset: 0x00000FC5
		public unsafe static Action<string, int> OnAchievementIconFetched
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUserStats.NativeFieldInfoPtr_OnAchievementIconFetched, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUserStats.NativeFieldInfoPtr_OnAchievementIconFetched, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x0004EAC4 File Offset: 0x0004CCC4
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00002DD7 File Offset: 0x00000FD7
		public unsafe static Action<SteamId, Result> OnUserStatsReceived
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUserStats.NativeFieldInfoPtr_OnUserStatsReceived, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamId, Result>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUserStats.NativeFieldInfoPtr_OnUserStatsReceived, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0004EAEC File Offset: 0x0004CCEC
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00002DE9 File Offset: 0x00000FE9
		public unsafe static Action<Result> OnUserStatsStored
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUserStats.NativeFieldInfoPtr_OnUserStatsStored, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Result>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUserStats.NativeFieldInfoPtr_OnUserStatsStored, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0004EB14 File Offset: 0x0004CD14
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x00002DFB File Offset: 0x00000FFB
		public unsafe static Action<Achievement, int, int> OnAchievementProgress
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUserStats.NativeFieldInfoPtr_OnAchievementProgress, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Achievement, int, int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUserStats.NativeFieldInfoPtr_OnAchievementProgress, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0004EB3C File Offset: 0x0004CD3C
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x00002E0D File Offset: 0x0000100D
		public unsafe static Action<SteamId> OnUserStatsUnloaded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamUserStats.NativeFieldInfoPtr_OnUserStatsUnloaded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SteamId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamUserStats.NativeFieldInfoPtr_OnUserStatsUnloaded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeFieldInfoPtr__StatsRecieved_k__BackingField;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeFieldInfoPtr_OnAchievementIconFetched;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeFieldInfoPtr_OnUserStatsReceived;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeFieldInfoPtr_OnUserStatsStored;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeFieldInfoPtr_OnAchievementProgress;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeFieldInfoPtr_OnUserStatsUnloaded;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamUserStats_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr_get_StatsRecieved_Public_Static_get_Boolean_0;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_set_StatsRecieved_Internal_Static_set_Void_Boolean_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_add_OnAchievementIconFetched_Internal_Static_add_Void_Action_2_String_Int32_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnAchievementIconFetched_Internal_Static_rem_Void_Action_2_String_Int32_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_add_OnUserStatsReceived_Public_Static_add_Void_Action_2_SteamId_Result_0;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnUserStatsReceived_Public_Static_rem_Void_Action_2_SteamId_Result_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr_add_OnUserStatsStored_Public_Static_add_Void_Action_1_Result_0;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnUserStatsStored_Public_Static_rem_Void_Action_1_Result_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_add_OnAchievementProgress_Public_Static_add_Void_Action_3_Achievement_Int32_Int32_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnAchievementProgress_Public_Static_rem_Void_Action_3_Achievement_Int32_Int32_0;

		// Token: 0x04001206 RID: 4614
		private static readonly IntPtr NativeMethodInfoPtr_add_OnUserStatsUnloaded_Public_Static_add_Void_Action_1_SteamId_0;

		// Token: 0x04001207 RID: 4615
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnUserStatsUnloaded_Public_Static_rem_Void_Action_1_SteamId_0;

		// Token: 0x04001208 RID: 4616
		private static readonly IntPtr NativeMethodInfoPtr_get_Achievements_Public_Static_get_IEnumerable_1_Achievement_0;

		// Token: 0x04001209 RID: 4617
		private static readonly IntPtr NativeMethodInfoPtr_IndicateAchievementProgress_Public_Static_Boolean_String_Int32_Int32_0;

		// Token: 0x0400120A RID: 4618
		private static readonly IntPtr NativeMethodInfoPtr_PlayerCountAsync_Public_Static_Task_1_Int32_0;

		// Token: 0x0400120B RID: 4619
		private static readonly IntPtr NativeMethodInfoPtr_StoreStats_Public_Static_Boolean_0;

		// Token: 0x0400120C RID: 4620
		private static readonly IntPtr NativeMethodInfoPtr_RequestCurrentStats_Public_Static_Boolean_0;

		// Token: 0x0400120D RID: 4621
		private static readonly IntPtr NativeMethodInfoPtr_RequestGlobalStatsAsync_Public_Static_Task_1_Result_Int32_0;

		// Token: 0x0400120E RID: 4622
		private static readonly IntPtr NativeMethodInfoPtr_FindOrCreateLeaderboardAsync_Public_Static_Task_1_Nullable_1_Leaderboard_String_LeaderboardSort_LeaderboardDisplay_0;

		// Token: 0x0400120F RID: 4623
		private static readonly IntPtr NativeMethodInfoPtr_FindLeaderboardAsync_Public_Static_Task_1_Nullable_1_Leaderboard_String_0;

		// Token: 0x04001210 RID: 4624
		private static readonly IntPtr NativeMethodInfoPtr_AddStat_Public_Static_Boolean_String_Int32_0;

		// Token: 0x04001211 RID: 4625
		private static readonly IntPtr NativeMethodInfoPtr_AddStat_Public_Static_Boolean_String_Single_0;

		// Token: 0x04001212 RID: 4626
		private static readonly IntPtr NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Int32_0;

		// Token: 0x04001213 RID: 4627
		private static readonly IntPtr NativeMethodInfoPtr_SetStat_Public_Static_Boolean_String_Single_0;

		// Token: 0x04001214 RID: 4628
		private static readonly IntPtr NativeMethodInfoPtr_GetStatInt_Public_Static_Int32_String_0;

		// Token: 0x04001215 RID: 4629
		private static readonly IntPtr NativeMethodInfoPtr_GetStatFloat_Public_Static_Single_String_0;

		// Token: 0x04001216 RID: 4630
		private static readonly IntPtr NativeMethodInfoPtr_ResetAll_Public_Static_Boolean_Boolean_0;

		// Token: 0x04001217 RID: 4631
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000266 RID: 614
		[ObfuscatedName("Steamworks.SteamUserStats+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001F0B RID: 7947 RVA: 0x0008B5D4 File Offset: 0x000897D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr);
				SteamUserStats.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr, "<>9");
				SteamUserStats.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr, "<>9__7_0");
				SteamUserStats.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr, "<>9__7_1");
				SteamUserStats.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr, "<>9__7_2");
				SteamUserStats.__c.NativeFieldInfoPtr___9__7_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr, "<>9__7_3");
				SteamUserStats.__c.NativeFieldInfoPtr___9__7_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr, "<>9__7_4");
				SteamUserStats.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr, 100666101);
				SteamUserStats.__c.NativeMethodInfoPtr__InstallEvents_b__7_0_Internal_Void_UserStatsReceived_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr, 100666102);
				SteamUserStats.__c.NativeMethodInfoPtr__InstallEvents_b__7_1_Internal_Void_UserStatsStored_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr, 100666103);
				SteamUserStats.__c.NativeMethodInfoPtr__InstallEvents_b__7_2_Internal_Void_UserAchievementStored_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr, 100666104);
				SteamUserStats.__c.NativeMethodInfoPtr__InstallEvents_b__7_3_Internal_Void_UserStatsUnloaded_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr, 100666105);
				SteamUserStats.__c.NativeMethodInfoPtr__InstallEvents_b__7_4_Internal_Void_UserAchievementIconFetched_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr, 100666106);
			}

			// Token: 0x06001F0C RID: 7948 RVA: 0x0008B6F0 File Offset: 0x000898F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUserStats.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F0D RID: 7949 RVA: 0x0008B72C File Offset: 0x0008992C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945030, XrefRangeEnd = 945038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__7_0(UserStatsReceived_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.__c.NativeMethodInfoPtr__InstallEvents_b__7_0_Internal_Void_UserStatsReceived_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F0E RID: 7950 RVA: 0x0008B76C File Offset: 0x0008996C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945038, XrefRangeEnd = 945040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__7_1(UserStatsStored_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.__c.NativeMethodInfoPtr__InstallEvents_b__7_1_Internal_Void_UserStatsStored_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F0F RID: 7951 RVA: 0x0008B7AC File Offset: 0x000899AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945040, XrefRangeEnd = 945047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__7_2(UserAchievementStored_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.__c.NativeMethodInfoPtr__InstallEvents_b__7_2_Internal_Void_UserAchievementStored_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F10 RID: 7952 RVA: 0x0008B7F4 File Offset: 0x000899F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945047, XrefRangeEnd = 945049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__7_3(UserStatsUnloaded_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.__c.NativeMethodInfoPtr__InstallEvents_b__7_3_Internal_Void_UserStatsUnloaded_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F11 RID: 7953 RVA: 0x0008B834 File Offset: 0x00089A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945049, XrefRangeEnd = 945055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__7_4(UserAchievementIconFetched_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats.__c.NativeMethodInfoPtr__InstallEvents_b__7_4_Internal_Void_UserAchievementIconFetched_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F12 RID: 7954 RVA: 0x0000B712 File Offset: 0x00009912
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007E7 RID: 2023
			// (get) Token: 0x06001F13 RID: 7955 RVA: 0x0008B87C File Offset: 0x00089A7C
			// (set) Token: 0x06001F14 RID: 7956 RVA: 0x0000B71B File Offset: 0x0000991B
			public unsafe static SteamUserStats.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUserStats.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamUserStats.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUserStats.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E8 RID: 2024
			// (get) Token: 0x06001F15 RID: 7957 RVA: 0x0008B8A4 File Offset: 0x00089AA4
			// (set) Token: 0x06001F16 RID: 7958 RVA: 0x0000B72D File Offset: 0x0000992D
			public unsafe static Action<UserStatsReceived_t> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUserStats.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UserStatsReceived_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUserStats.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E9 RID: 2025
			// (get) Token: 0x06001F17 RID: 7959 RVA: 0x0008B8CC File Offset: 0x00089ACC
			// (set) Token: 0x06001F18 RID: 7960 RVA: 0x0000B73F File Offset: 0x0000993F
			public unsafe static Action<UserStatsStored_t> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUserStats.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UserStatsStored_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUserStats.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007EA RID: 2026
			// (get) Token: 0x06001F19 RID: 7961 RVA: 0x0008B8F4 File Offset: 0x00089AF4
			// (set) Token: 0x06001F1A RID: 7962 RVA: 0x0000B751 File Offset: 0x00009951
			public unsafe static Action<UserAchievementStored_t> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUserStats.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UserAchievementStored_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUserStats.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007EB RID: 2027
			// (get) Token: 0x06001F1B RID: 7963 RVA: 0x0008B91C File Offset: 0x00089B1C
			// (set) Token: 0x06001F1C RID: 7964 RVA: 0x0000B763 File Offset: 0x00009963
			public unsafe static Action<UserStatsUnloaded_t> __9__7_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUserStats.__c.NativeFieldInfoPtr___9__7_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UserStatsUnloaded_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUserStats.__c.NativeFieldInfoPtr___9__7_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007EC RID: 2028
			// (get) Token: 0x06001F1D RID: 7965 RVA: 0x0008B944 File Offset: 0x00089B44
			// (set) Token: 0x06001F1E RID: 7966 RVA: 0x0000B775 File Offset: 0x00009975
			public unsafe static Action<UserAchievementIconFetched_t> __9__7_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamUserStats.__c.NativeFieldInfoPtr___9__7_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UserAchievementIconFetched_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamUserStats.__c.NativeFieldInfoPtr___9__7_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002204 RID: 8708
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002205 RID: 8709
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04002206 RID: 8710
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04002207 RID: 8711
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x04002208 RID: 8712
			private static readonly IntPtr NativeFieldInfoPtr___9__7_3;

			// Token: 0x04002209 RID: 8713
			private static readonly IntPtr NativeFieldInfoPtr___9__7_4;

			// Token: 0x0400220A RID: 8714
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400220B RID: 8715
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__7_0_Internal_Void_UserStatsReceived_t_0;

			// Token: 0x0400220C RID: 8716
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__7_1_Internal_Void_UserStatsStored_t_0;

			// Token: 0x0400220D RID: 8717
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__7_2_Internal_Void_UserAchievementStored_t_0;

			// Token: 0x0400220E RID: 8718
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__7_3_Internal_Void_UserStatsUnloaded_t_0;

			// Token: 0x0400220F RID: 8719
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__7_4_Internal_Void_UserAchievementIconFetched_t_0;
		}

		// Token: 0x02000267 RID: 615
		[ObfuscatedName("Steamworks.SteamUserStats+<FindLeaderboardAsync>d__31")]
		public sealed class _FindLeaderboardAsync_d__31 : ValueType
		{
			// Token: 0x06001F1F RID: 7967 RVA: 0x0008B96C File Offset: 0x00089B6C
			// Note: this type is marked as 'beforefieldinit'.
			static _FindLeaderboardAsync_d__31()
			{
				Il2CppClassPointerStore<SteamUserStats._FindLeaderboardAsync_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, "<FindLeaderboardAsync>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUserStats._FindLeaderboardAsync_d__31>.NativeClassPtr);
				SteamUserStats._FindLeaderboardAsync_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._FindLeaderboardAsync_d__31>.NativeClassPtr, "<>1__state");
				SteamUserStats._FindLeaderboardAsync_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._FindLeaderboardAsync_d__31>.NativeClassPtr, "<>t__builder");
				SteamUserStats._FindLeaderboardAsync_d__31.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._FindLeaderboardAsync_d__31>.NativeClassPtr, "name");
				SteamUserStats._FindLeaderboardAsync_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._FindLeaderboardAsync_d__31>.NativeClassPtr, "<>u__1");
				SteamUserStats._FindLeaderboardAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._FindLeaderboardAsync_d__31>.NativeClassPtr, 100666107);
				SteamUserStats._FindLeaderboardAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._FindLeaderboardAsync_d__31>.NativeClassPtr, 100666108);
			}

			// Token: 0x06001F20 RID: 7968 RVA: 0x0008BA10 File Offset: 0x00089C10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945055, XrefRangeEnd = 945085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._FindLeaderboardAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F21 RID: 7969 RVA: 0x0008BA48 File Offset: 0x00089C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945085, XrefRangeEnd = 945091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._FindLeaderboardAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F22 RID: 7970 RVA: 0x0000B787 File Offset: 0x00009987
			public _FindLeaderboardAsync_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F23 RID: 7971 RVA: 0x0000B790 File Offset: 0x00009990
			public _FindLeaderboardAsync_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUserStats._FindLeaderboardAsync_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x170007ED RID: 2029
			// (get) Token: 0x06001F24 RID: 7972 RVA: 0x0008BA90 File Offset: 0x00089C90
			// (set) Token: 0x06001F25 RID: 7973 RVA: 0x0000B7A2 File Offset: 0x000099A2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindLeaderboardAsync_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindLeaderboardAsync_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007EE RID: 2030
			// (get) Token: 0x06001F26 RID: 7974 RVA: 0x0008BAB8 File Offset: 0x00089CB8
			// (set) Token: 0x06001F27 RID: 7975 RVA: 0x0000B7BD File Offset: 0x000099BD
			public AsyncTaskMethodBuilder<Nullable<Leaderboard>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindLeaderboardAsync_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Leaderboard>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Leaderboard>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindLeaderboardAsync_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Leaderboard>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007EF RID: 2031
			// (get) Token: 0x06001F28 RID: 7976 RVA: 0x0008BAE8 File Offset: 0x00089CE8
			// (set) Token: 0x06001F29 RID: 7977 RVA: 0x0000B7EB File Offset: 0x000099EB
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindLeaderboardAsync_d__31.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindLeaderboardAsync_d__31.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007F0 RID: 2032
			// (get) Token: 0x06001F2A RID: 7978 RVA: 0x0008BB10 File Offset: 0x00089D10
			// (set) Token: 0x06001F2B RID: 7979 RVA: 0x0000B80A File Offset: 0x00009A0A
			public CallResult<LeaderboardFindResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindLeaderboardAsync_d__31.NativeFieldInfoPtr___u__1);
					return new CallResult<LeaderboardFindResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LeaderboardFindResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindLeaderboardAsync_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LeaderboardFindResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002210 RID: 8720
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002211 RID: 8721
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002212 RID: 8722
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04002213 RID: 8723
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002214 RID: 8724
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002215 RID: 8725
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000268 RID: 616
		[ObfuscatedName("Steamworks.SteamUserStats+<FindOrCreateLeaderboardAsync>d__30")]
		public sealed class _FindOrCreateLeaderboardAsync_d__30 : ValueType
		{
			// Token: 0x06001F2C RID: 7980 RVA: 0x0008BB40 File Offset: 0x00089D40
			// Note: this type is marked as 'beforefieldinit'.
			static _FindOrCreateLeaderboardAsync_d__30()
			{
				Il2CppClassPointerStore<SteamUserStats._FindOrCreateLeaderboardAsync_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, "<FindOrCreateLeaderboardAsync>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUserStats._FindOrCreateLeaderboardAsync_d__30>.NativeClassPtr);
				SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._FindOrCreateLeaderboardAsync_d__30>.NativeClassPtr, "<>1__state");
				SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._FindOrCreateLeaderboardAsync_d__30>.NativeClassPtr, "<>t__builder");
				SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._FindOrCreateLeaderboardAsync_d__30>.NativeClassPtr, "name");
				SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr_sort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._FindOrCreateLeaderboardAsync_d__30>.NativeClassPtr, "sort");
				SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._FindOrCreateLeaderboardAsync_d__30>.NativeClassPtr, "display");
				SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._FindOrCreateLeaderboardAsync_d__30>.NativeClassPtr, "<>u__1");
				SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._FindOrCreateLeaderboardAsync_d__30>.NativeClassPtr, 100666109);
				SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._FindOrCreateLeaderboardAsync_d__30>.NativeClassPtr, 100666110);
			}

			// Token: 0x06001F2D RID: 7981 RVA: 0x0008BC0C File Offset: 0x00089E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945091, XrefRangeEnd = 945121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F2E RID: 7982 RVA: 0x0008BC44 File Offset: 0x00089E44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945121, XrefRangeEnd = 945127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F2F RID: 7983 RVA: 0x0000B838 File Offset: 0x00009A38
			public _FindOrCreateLeaderboardAsync_d__30(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F30 RID: 7984 RVA: 0x0000B841 File Offset: 0x00009A41
			public _FindOrCreateLeaderboardAsync_d__30()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUserStats._FindOrCreateLeaderboardAsync_d__30>.NativeClassPtr))
			{
			}

			// Token: 0x170007F1 RID: 2033
			// (get) Token: 0x06001F31 RID: 7985 RVA: 0x0008BC8C File Offset: 0x00089E8C
			// (set) Token: 0x06001F32 RID: 7986 RVA: 0x0000B853 File Offset: 0x00009A53
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007F2 RID: 2034
			// (get) Token: 0x06001F33 RID: 7987 RVA: 0x0008BCB4 File Offset: 0x00089EB4
			// (set) Token: 0x06001F34 RID: 7988 RVA: 0x0000B86E File Offset: 0x00009A6E
			public AsyncTaskMethodBuilder<Nullable<Leaderboard>> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Nullable<Leaderboard>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Leaderboard>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Nullable<Leaderboard>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007F3 RID: 2035
			// (get) Token: 0x06001F35 RID: 7989 RVA: 0x0008BCE4 File Offset: 0x00089EE4
			// (set) Token: 0x06001F36 RID: 7990 RVA: 0x0000B89C File Offset: 0x00009A9C
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170007F4 RID: 2036
			// (get) Token: 0x06001F37 RID: 7991 RVA: 0x0008BD0C File Offset: 0x00089F0C
			// (set) Token: 0x06001F38 RID: 7992 RVA: 0x0000B8BB File Offset: 0x00009ABB
			public unsafe LeaderboardSort sort
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr_sort);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr_sort)) = value;
				}
			}

			// Token: 0x170007F5 RID: 2037
			// (get) Token: 0x06001F39 RID: 7993 RVA: 0x0008BD34 File Offset: 0x00089F34
			// (set) Token: 0x06001F3A RID: 7994 RVA: 0x0000B8D6 File Offset: 0x00009AD6
			public unsafe LeaderboardDisplay display
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr_display);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr_display)) = value;
				}
			}

			// Token: 0x170007F6 RID: 2038
			// (get) Token: 0x06001F3B RID: 7995 RVA: 0x0008BD5C File Offset: 0x00089F5C
			// (set) Token: 0x06001F3C RID: 7996 RVA: 0x0000B8F1 File Offset: 0x00009AF1
			public CallResult<LeaderboardFindResult_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr___u__1);
					return new CallResult<LeaderboardFindResult_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<LeaderboardFindResult_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._FindOrCreateLeaderboardAsync_d__30.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<LeaderboardFindResult_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002216 RID: 8726
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002217 RID: 8727
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002218 RID: 8728
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04002219 RID: 8729
			private static readonly IntPtr NativeFieldInfoPtr_sort;

			// Token: 0x0400221A RID: 8730
			private static readonly IntPtr NativeFieldInfoPtr_display;

			// Token: 0x0400221B RID: 8731
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400221C RID: 8732
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400221D RID: 8733
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x02000269 RID: 617
		[ObfuscatedName("Steamworks.SteamUserStats+<PlayerCountAsync>d__26")]
		public sealed class _PlayerCountAsync_d__26 : ValueType
		{
			// Token: 0x06001F3D RID: 7997 RVA: 0x0008BD8C File Offset: 0x00089F8C
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayerCountAsync_d__26()
			{
				Il2CppClassPointerStore<SteamUserStats._PlayerCountAsync_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, "<PlayerCountAsync>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUserStats._PlayerCountAsync_d__26>.NativeClassPtr);
				SteamUserStats._PlayerCountAsync_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._PlayerCountAsync_d__26>.NativeClassPtr, "<>1__state");
				SteamUserStats._PlayerCountAsync_d__26.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._PlayerCountAsync_d__26>.NativeClassPtr, "<>t__builder");
				SteamUserStats._PlayerCountAsync_d__26.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._PlayerCountAsync_d__26>.NativeClassPtr, "<>u__1");
				SteamUserStats._PlayerCountAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._PlayerCountAsync_d__26>.NativeClassPtr, 100666111);
				SteamUserStats._PlayerCountAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._PlayerCountAsync_d__26>.NativeClassPtr, 100666112);
			}

			// Token: 0x06001F3E RID: 7998 RVA: 0x0008BE1C File Offset: 0x0008A01C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945127, XrefRangeEnd = 945153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._PlayerCountAsync_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F3F RID: 7999 RVA: 0x0008BE54 File Offset: 0x0008A054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945153, XrefRangeEnd = 945159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._PlayerCountAsync_d__26.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F40 RID: 8000 RVA: 0x0000B91F File Offset: 0x00009B1F
			public _PlayerCountAsync_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F41 RID: 8001 RVA: 0x0000B928 File Offset: 0x00009B28
			public _PlayerCountAsync_d__26()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUserStats._PlayerCountAsync_d__26>.NativeClassPtr))
			{
			}

			// Token: 0x170007F7 RID: 2039
			// (get) Token: 0x06001F42 RID: 8002 RVA: 0x0008BE9C File Offset: 0x0008A09C
			// (set) Token: 0x06001F43 RID: 8003 RVA: 0x0000B93A File Offset: 0x00009B3A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._PlayerCountAsync_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._PlayerCountAsync_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007F8 RID: 2040
			// (get) Token: 0x06001F44 RID: 8004 RVA: 0x0008BEC4 File Offset: 0x0008A0C4
			// (set) Token: 0x06001F45 RID: 8005 RVA: 0x0000B955 File Offset: 0x00009B55
			public AsyncTaskMethodBuilder<int> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._PlayerCountAsync_d__26.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._PlayerCountAsync_d__26.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007F9 RID: 2041
			// (get) Token: 0x06001F46 RID: 8006 RVA: 0x0008BEF4 File Offset: 0x0008A0F4
			// (set) Token: 0x06001F47 RID: 8007 RVA: 0x0000B983 File Offset: 0x00009B83
			public CallResult<NumberOfCurrentPlayers_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._PlayerCountAsync_d__26.NativeFieldInfoPtr___u__1);
					return new CallResult<NumberOfCurrentPlayers_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<NumberOfCurrentPlayers_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._PlayerCountAsync_d__26.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<NumberOfCurrentPlayers_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400221E RID: 8734
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400221F RID: 8735
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002220 RID: 8736
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002221 RID: 8737
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002222 RID: 8738
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200026A RID: 618
		[ObfuscatedName("Steamworks.SteamUserStats+<RequestGlobalStatsAsync>d__29")]
		public sealed class _RequestGlobalStatsAsync_d__29 : ValueType
		{
			// Token: 0x06001F48 RID: 8008 RVA: 0x0008BF24 File Offset: 0x0008A124
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestGlobalStatsAsync_d__29()
			{
				Il2CppClassPointerStore<SteamUserStats._RequestGlobalStatsAsync_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, "<RequestGlobalStatsAsync>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUserStats._RequestGlobalStatsAsync_d__29>.NativeClassPtr);
				SteamUserStats._RequestGlobalStatsAsync_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._RequestGlobalStatsAsync_d__29>.NativeClassPtr, "<>1__state");
				SteamUserStats._RequestGlobalStatsAsync_d__29.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._RequestGlobalStatsAsync_d__29>.NativeClassPtr, "<>t__builder");
				SteamUserStats._RequestGlobalStatsAsync_d__29.NativeFieldInfoPtr_days = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._RequestGlobalStatsAsync_d__29>.NativeClassPtr, "days");
				SteamUserStats._RequestGlobalStatsAsync_d__29.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._RequestGlobalStatsAsync_d__29>.NativeClassPtr, "<>u__1");
				SteamUserStats._RequestGlobalStatsAsync_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._RequestGlobalStatsAsync_d__29>.NativeClassPtr, 100666113);
				SteamUserStats._RequestGlobalStatsAsync_d__29.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._RequestGlobalStatsAsync_d__29>.NativeClassPtr, 100666114);
			}

			// Token: 0x06001F49 RID: 8009 RVA: 0x0008BFC8 File Offset: 0x0008A1C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945159, XrefRangeEnd = 945183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._RequestGlobalStatsAsync_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F4A RID: 8010 RVA: 0x0008C000 File Offset: 0x0008A200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945183, XrefRangeEnd = 945189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._RequestGlobalStatsAsync_d__29.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F4B RID: 8011 RVA: 0x0000B9B1 File Offset: 0x00009BB1
			public _RequestGlobalStatsAsync_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F4C RID: 8012 RVA: 0x0000B9BA File Offset: 0x00009BBA
			public _RequestGlobalStatsAsync_d__29()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUserStats._RequestGlobalStatsAsync_d__29>.NativeClassPtr))
			{
			}

			// Token: 0x170007FA RID: 2042
			// (get) Token: 0x06001F4D RID: 8013 RVA: 0x0008C048 File Offset: 0x0008A248
			// (set) Token: 0x06001F4E RID: 8014 RVA: 0x0000B9CC File Offset: 0x00009BCC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._RequestGlobalStatsAsync_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._RequestGlobalStatsAsync_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007FB RID: 2043
			// (get) Token: 0x06001F4F RID: 8015 RVA: 0x0008C070 File Offset: 0x0008A270
			// (set) Token: 0x06001F50 RID: 8016 RVA: 0x0000B9E7 File Offset: 0x00009BE7
			public AsyncTaskMethodBuilder<Result> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._RequestGlobalStatsAsync_d__29.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<Result>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Result>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._RequestGlobalStatsAsync_d__29.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<Result>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007FC RID: 2044
			// (get) Token: 0x06001F51 RID: 8017 RVA: 0x0008C0A0 File Offset: 0x0008A2A0
			// (set) Token: 0x06001F52 RID: 8018 RVA: 0x0000BA15 File Offset: 0x00009C15
			public unsafe int days
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._RequestGlobalStatsAsync_d__29.NativeFieldInfoPtr_days);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._RequestGlobalStatsAsync_d__29.NativeFieldInfoPtr_days)) = value;
				}
			}

			// Token: 0x170007FD RID: 2045
			// (get) Token: 0x06001F53 RID: 8019 RVA: 0x0008C0C8 File Offset: 0x0008A2C8
			// (set) Token: 0x06001F54 RID: 8020 RVA: 0x0000BA30 File Offset: 0x00009C30
			public CallResult<GlobalStatsReceived_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._RequestGlobalStatsAsync_d__29.NativeFieldInfoPtr___u__1);
					return new CallResult<GlobalStatsReceived_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<GlobalStatsReceived_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._RequestGlobalStatsAsync_d__29.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<GlobalStatsReceived_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002223 RID: 8739
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002224 RID: 8740
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002225 RID: 8741
			private static readonly IntPtr NativeFieldInfoPtr_days;

			// Token: 0x04002226 RID: 8742
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002227 RID: 8743
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002228 RID: 8744
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200026B RID: 619
		[ObfuscatedName("Steamworks.SteamUserStats+<get_Achievements>d__24")]
		public sealed class _get_Achievements_d__24 : Object
		{
			// Token: 0x06001F55 RID: 8021 RVA: 0x0008C0F8 File Offset: 0x0008A2F8
			// Note: this type is marked as 'beforefieldinit'.
			static _get_Achievements_d__24()
			{
				Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamUserStats>.NativeClassPtr, "<get_Achievements>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr);
				SteamUserStats._get_Achievements_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr, "<>1__state");
				SteamUserStats._get_Achievements_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr, "<>2__current");
				SteamUserStats._get_Achievements_d__24.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr, "<>l__initialThreadId");
				SteamUserStats._get_Achievements_d__24.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr, "<i>5__2");
				SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr, 100666115);
				SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr, 100666116);
				SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr, 100666117);
				SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_Achievement__get_Current_Private_Virtual_Final_New_get_Achievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr, 100666118);
				SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr, 100666119);
				SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr, 100666120);
				SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_Achievement__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Achievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr, 100666121);
				SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr, 100666122);
			}

			// Token: 0x06001F56 RID: 8022 RVA: 0x0008C214 File Offset: 0x0008A414
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_Achievements_d__24(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamUserStats._get_Achievements_d__24>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F57 RID: 8023 RVA: 0x0008C25C File Offset: 0x0008A45C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F58 RID: 8024 RVA: 0x0008C290 File Offset: 0x0008A490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945189, XrefRangeEnd = 945196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000802 RID: 2050
			// (get) Token: 0x06001F59 RID: 8025 RVA: 0x0008C2CC File Offset: 0x0008A4CC
			public unsafe Achievement System.Collections.Generic.IEnumerator<Steamworks.Data.Achievement>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_Achievement__get_Current_Private_Virtual_Final_New_get_Achievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Achievement(intPtr);
				}
			}

			// Token: 0x06001F5A RID: 8026 RVA: 0x0008C304 File Offset: 0x0008A504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945196, XrefRangeEnd = 945201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000803 RID: 2051
			// (get) Token: 0x06001F5B RID: 8027 RVA: 0x0008C338 File Offset: 0x0008A538
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945201, XrefRangeEnd = 945204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F5C RID: 8028 RVA: 0x0008C378 File Offset: 0x0008A578
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 945204, XrefRangeEnd = 945206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Achievement> System_Collections_Generic_IEnumerable_Steamworks_Data_Achievement__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_Achievement__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Achievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Achievement>>(intPtr3) : null;
			}

			// Token: 0x06001F5D RID: 8029 RVA: 0x0008C3B8 File Offset: 0x0008A5B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUserStats._get_Achievements_d__24.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001F5E RID: 8030 RVA: 0x0000BA5E File Offset: 0x00009C5E
			public _get_Achievements_d__24(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007FE RID: 2046
			// (get) Token: 0x06001F5F RID: 8031 RVA: 0x0008C3F8 File Offset: 0x0008A5F8
			// (set) Token: 0x06001F60 RID: 8032 RVA: 0x0000BA67 File Offset: 0x00009C67
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._get_Achievements_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._get_Achievements_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007FF RID: 2047
			// (get) Token: 0x06001F61 RID: 8033 RVA: 0x0008C420 File Offset: 0x0008A620
			// (set) Token: 0x06001F62 RID: 8034 RVA: 0x0000BA82 File Offset: 0x00009C82
			public Achievement __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._get_Achievements_d__24.NativeFieldInfoPtr___2__current);
					return new Achievement(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Achievement>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._get_Achievements_d__24.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Achievement>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000800 RID: 2048
			// (get) Token: 0x06001F63 RID: 8035 RVA: 0x0008C450 File Offset: 0x0008A650
			// (set) Token: 0x06001F64 RID: 8036 RVA: 0x0000BAB0 File Offset: 0x00009CB0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._get_Achievements_d__24.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._get_Achievements_d__24.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000801 RID: 2049
			// (get) Token: 0x06001F65 RID: 8037 RVA: 0x0008C478 File Offset: 0x0008A678
			// (set) Token: 0x06001F66 RID: 8038 RVA: 0x0000BACB File Offset: 0x00009CCB
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._get_Achievements_d__24.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SteamUserStats._get_Achievements_d__24.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04002229 RID: 8745
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400222A RID: 8746
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400222B RID: 8747
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400222C RID: 8748
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400222D RID: 8749
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400222E RID: 8750
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400222F RID: 8751
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002230 RID: 8752
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Data_Achievement__get_Current_Private_Virtual_Final_New_get_Achievement_0;

			// Token: 0x04002231 RID: 8753
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002232 RID: 8754
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002233 RID: 8755
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Data_Achievement__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Achievement_0;

			// Token: 0x04002234 RID: 8756
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
