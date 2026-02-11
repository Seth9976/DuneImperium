using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x0200002D RID: 45
	public class ISteamUserStats : SteamInterface
	{
		// Token: 0x06000728 RID: 1832 RVA: 0x0003BBBC File Offset: 0x00039DBC
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamUserStats()
		{
			Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamUserStats");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr);
			ISteamUserStats.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665041);
			ISteamUserStats.NativeMethodInfoPtr_SteamAPI_SteamUserStats_v012_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665042);
			ISteamUserStats.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665043);
			ISteamUserStats.NativeMethodInfoPtr__RequestCurrentStats_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665044);
			ISteamUserStats.NativeMethodInfoPtr_RequestCurrentStats_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665045);
			ISteamUserStats.NativeMethodInfoPtr__GetStat_Private_Static_Boolean_IntPtr_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665046);
			ISteamUserStats.NativeMethodInfoPtr_GetStat_Internal_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665047);
			ISteamUserStats.NativeMethodInfoPtr__GetStat_Private_Static_Boolean_IntPtr_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665048);
			ISteamUserStats.NativeMethodInfoPtr_GetStat_Internal_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665049);
			ISteamUserStats.NativeMethodInfoPtr__SetStat_Private_Static_Boolean_IntPtr_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665050);
			ISteamUserStats.NativeMethodInfoPtr_SetStat_Internal_Boolean_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665051);
			ISteamUserStats.NativeMethodInfoPtr__SetStat_Private_Static_Boolean_IntPtr_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665052);
			ISteamUserStats.NativeMethodInfoPtr_SetStat_Internal_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665053);
			ISteamUserStats.NativeMethodInfoPtr__UpdateAvgRateStat_Private_Static_Boolean_IntPtr_String_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665054);
			ISteamUserStats.NativeMethodInfoPtr_UpdateAvgRateStat_Internal_Boolean_String_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665055);
			ISteamUserStats.NativeMethodInfoPtr__GetAchievement_Private_Static_Boolean_IntPtr_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665056);
			ISteamUserStats.NativeMethodInfoPtr_GetAchievement_Internal_Boolean_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665057);
			ISteamUserStats.NativeMethodInfoPtr__SetAchievement_Private_Static_Boolean_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665058);
			ISteamUserStats.NativeMethodInfoPtr_SetAchievement_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665059);
			ISteamUserStats.NativeMethodInfoPtr__ClearAchievement_Private_Static_Boolean_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665060);
			ISteamUserStats.NativeMethodInfoPtr_ClearAchievement_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665061);
			ISteamUserStats.NativeMethodInfoPtr__GetAchievementAndUnlockTime_Private_Static_Boolean_IntPtr_String_byref_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665062);
			ISteamUserStats.NativeMethodInfoPtr_GetAchievementAndUnlockTime_Internal_Boolean_String_byref_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665063);
			ISteamUserStats.NativeMethodInfoPtr__StoreStats_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665064);
			ISteamUserStats.NativeMethodInfoPtr_StoreStats_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665065);
			ISteamUserStats.NativeMethodInfoPtr__GetAchievementIcon_Private_Static_Int32_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665066);
			ISteamUserStats.NativeMethodInfoPtr_GetAchievementIcon_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665067);
			ISteamUserStats.NativeMethodInfoPtr__GetAchievementDisplayAttribute_Private_Static_Utf8StringPointer_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665068);
			ISteamUserStats.NativeMethodInfoPtr_GetAchievementDisplayAttribute_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665069);
			ISteamUserStats.NativeMethodInfoPtr__IndicateAchievementProgress_Private_Static_Boolean_IntPtr_String_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665070);
			ISteamUserStats.NativeMethodInfoPtr_IndicateAchievementProgress_Internal_Boolean_String_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665071);
			ISteamUserStats.NativeMethodInfoPtr__GetNumAchievements_Private_Static_UInt32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665072);
			ISteamUserStats.NativeMethodInfoPtr_GetNumAchievements_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665073);
			ISteamUserStats.NativeMethodInfoPtr__GetAchievementName_Private_Static_Utf8StringPointer_IntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665074);
			ISteamUserStats.NativeMethodInfoPtr_GetAchievementName_Internal_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665075);
			ISteamUserStats.NativeMethodInfoPtr__RequestUserStats_Private_Static_SteamAPICall_t_IntPtr_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665076);
			ISteamUserStats.NativeMethodInfoPtr_RequestUserStats_Internal_CallResult_1_UserStatsReceived_t_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665077);
			ISteamUserStats.NativeMethodInfoPtr__GetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665078);
			ISteamUserStats.NativeMethodInfoPtr_GetUserStat_Internal_Boolean_SteamId_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665079);
			ISteamUserStats.NativeMethodInfoPtr__GetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665080);
			ISteamUserStats.NativeMethodInfoPtr_GetUserStat_Internal_Boolean_SteamId_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665081);
			ISteamUserStats.NativeMethodInfoPtr__GetUserAchievement_Private_Static_Boolean_IntPtr_SteamId_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665082);
			ISteamUserStats.NativeMethodInfoPtr_GetUserAchievement_Internal_Boolean_SteamId_String_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665083);
			ISteamUserStats.NativeMethodInfoPtr__GetUserAchievementAndUnlockTime_Private_Static_Boolean_IntPtr_SteamId_String_byref_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665084);
			ISteamUserStats.NativeMethodInfoPtr_GetUserAchievementAndUnlockTime_Internal_Boolean_SteamId_String_byref_Boolean_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665085);
			ISteamUserStats.NativeMethodInfoPtr__ResetAllStats_Private_Static_Boolean_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665086);
			ISteamUserStats.NativeMethodInfoPtr_ResetAllStats_Internal_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665087);
			ISteamUserStats.NativeMethodInfoPtr__FindOrCreateLeaderboard_Private_Static_SteamAPICall_t_IntPtr_String_LeaderboardSort_LeaderboardDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665088);
			ISteamUserStats.NativeMethodInfoPtr_FindOrCreateLeaderboard_Internal_CallResult_1_LeaderboardFindResult_t_String_LeaderboardSort_LeaderboardDisplay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665089);
			ISteamUserStats.NativeMethodInfoPtr__FindLeaderboard_Private_Static_SteamAPICall_t_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665090);
			ISteamUserStats.NativeMethodInfoPtr_FindLeaderboard_Internal_CallResult_1_LeaderboardFindResult_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665091);
			ISteamUserStats.NativeMethodInfoPtr__GetLeaderboardName_Private_Static_Utf8StringPointer_IntPtr_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665092);
			ISteamUserStats.NativeMethodInfoPtr_GetLeaderboardName_Internal_String_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665093);
			ISteamUserStats.NativeMethodInfoPtr__GetLeaderboardEntryCount_Private_Static_Int32_IntPtr_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665094);
			ISteamUserStats.NativeMethodInfoPtr_GetLeaderboardEntryCount_Internal_Int32_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665095);
			ISteamUserStats.NativeMethodInfoPtr__GetLeaderboardSortMethod_Private_Static_LeaderboardSort_IntPtr_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665096);
			ISteamUserStats.NativeMethodInfoPtr_GetLeaderboardSortMethod_Internal_LeaderboardSort_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665097);
			ISteamUserStats.NativeMethodInfoPtr__GetLeaderboardDisplayType_Private_Static_LeaderboardDisplay_IntPtr_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665098);
			ISteamUserStats.NativeMethodInfoPtr_GetLeaderboardDisplayType_Internal_LeaderboardDisplay_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665099);
			ISteamUserStats.NativeMethodInfoPtr__DownloadLeaderboardEntries_Private_Static_SteamAPICall_t_IntPtr_SteamLeaderboard_t_LeaderboardDataRequest_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665100);
			ISteamUserStats.NativeMethodInfoPtr_DownloadLeaderboardEntries_Internal_CallResult_1_LeaderboardScoresDownloaded_t_SteamLeaderboard_t_LeaderboardDataRequest_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665101);
			ISteamUserStats.NativeMethodInfoPtr__DownloadLeaderboardEntriesForUsers_Private_Static_SteamAPICall_t_IntPtr_SteamLeaderboard_t_Il2CppStructArray_1_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665102);
			ISteamUserStats.NativeMethodInfoPtr_DownloadLeaderboardEntriesForUsers_Internal_CallResult_1_LeaderboardScoresDownloaded_t_SteamLeaderboard_t_Il2CppStructArray_1_SteamId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665103);
			ISteamUserStats.NativeMethodInfoPtr__GetDownloadedLeaderboardEntry_Private_Static_Boolean_IntPtr_SteamLeaderboardEntries_t_Int32_byref_LeaderboardEntry_t_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665104);
			ISteamUserStats.NativeMethodInfoPtr_GetDownloadedLeaderboardEntry_Internal_Boolean_SteamLeaderboardEntries_t_Int32_byref_LeaderboardEntry_t_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665105);
			ISteamUserStats.NativeMethodInfoPtr__UploadLeaderboardScore_Private_Static_SteamAPICall_t_IntPtr_SteamLeaderboard_t_LeaderboardUploadScoreMethod_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665106);
			ISteamUserStats.NativeMethodInfoPtr_UploadLeaderboardScore_Internal_CallResult_1_LeaderboardScoreUploaded_t_SteamLeaderboard_t_LeaderboardUploadScoreMethod_Int32_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665107);
			ISteamUserStats.NativeMethodInfoPtr__AttachLeaderboardUGC_Private_Static_SteamAPICall_t_IntPtr_SteamLeaderboard_t_UGCHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665108);
			ISteamUserStats.NativeMethodInfoPtr_AttachLeaderboardUGC_Internal_CallResult_1_LeaderboardUGCSet_t_SteamLeaderboard_t_UGCHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665109);
			ISteamUserStats.NativeMethodInfoPtr__GetNumberOfCurrentPlayers_Private_Static_SteamAPICall_t_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665110);
			ISteamUserStats.NativeMethodInfoPtr_GetNumberOfCurrentPlayers_Internal_CallResult_1_NumberOfCurrentPlayers_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665111);
			ISteamUserStats.NativeMethodInfoPtr__RequestGlobalAchievementPercentages_Private_Static_SteamAPICall_t_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665112);
			ISteamUserStats.NativeMethodInfoPtr_RequestGlobalAchievementPercentages_Internal_CallResult_1_GlobalAchievementPercentagesReady_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665113);
			ISteamUserStats.NativeMethodInfoPtr__GetMostAchievedAchievementInfo_Private_Static_Int32_IntPtr_IntPtr_UInt32_byref_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665114);
			ISteamUserStats.NativeMethodInfoPtr_GetMostAchievedAchievementInfo_Internal_Int32_byref_String_byref_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665115);
			ISteamUserStats.NativeMethodInfoPtr__GetNextMostAchievedAchievementInfo_Private_Static_Int32_IntPtr_Int32_IntPtr_UInt32_byref_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665116);
			ISteamUserStats.NativeMethodInfoPtr_GetNextMostAchievedAchievementInfo_Internal_Int32_Int32_byref_String_byref_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665117);
			ISteamUserStats.NativeMethodInfoPtr__GetAchievementAchievedPercent_Private_Static_Boolean_IntPtr_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665118);
			ISteamUserStats.NativeMethodInfoPtr_GetAchievementAchievedPercent_Internal_Boolean_String_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665119);
			ISteamUserStats.NativeMethodInfoPtr__RequestGlobalStats_Private_Static_SteamAPICall_t_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665120);
			ISteamUserStats.NativeMethodInfoPtr_RequestGlobalStats_Internal_CallResult_1_GlobalStatsReceived_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665121);
			ISteamUserStats.NativeMethodInfoPtr__GetGlobalStat_Private_Static_Boolean_IntPtr_String_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665122);
			ISteamUserStats.NativeMethodInfoPtr_GetGlobalStat_Internal_Boolean_String_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665123);
			ISteamUserStats.NativeMethodInfoPtr__GetGlobalStat_Private_Static_Boolean_IntPtr_String_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665124);
			ISteamUserStats.NativeMethodInfoPtr_GetGlobalStat_Internal_Boolean_String_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665125);
			ISteamUserStats.NativeMethodInfoPtr__GetGlobalStatHistory_Private_Static_Int32_IntPtr_String_Il2CppStructArray_1_Int64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665126);
			ISteamUserStats.NativeMethodInfoPtr_GetGlobalStatHistory_Internal_Int32_String_Il2CppStructArray_1_Int64_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665127);
			ISteamUserStats.NativeMethodInfoPtr__GetGlobalStatHistory_Private_Static_Int32_IntPtr_String_Il2CppStructArray_1_Double_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665128);
			ISteamUserStats.NativeMethodInfoPtr_GetGlobalStatHistory_Internal_Int32_String_Il2CppStructArray_1_Double_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665129);
			ISteamUserStats.NativeMethodInfoPtr__GetAchievementProgressLimits_Private_Static_Boolean_IntPtr_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665130);
			ISteamUserStats.NativeMethodInfoPtr_GetAchievementProgressLimits_Internal_Boolean_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665131);
			ISteamUserStats.NativeMethodInfoPtr__GetAchievementProgressLimits_Private_Static_Boolean_IntPtr_String_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665132);
			ISteamUserStats.NativeMethodInfoPtr_GetAchievementProgressLimits_Internal_Boolean_String_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr, 100665133);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0003C330 File Offset: 0x0003A530
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamUserStats(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamUserStats>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0003C378 File Offset: 0x0003A578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936043, XrefRangeEnd = 936045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamUserStats_v012()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_SteamAPI_SteamUserStats_v012_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0003C3A8 File Offset: 0x0003A5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamUserStats.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0003C3F0 File Offset: 0x0003A5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936045, XrefRangeEnd = 936047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _RequestCurrentStats(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__RequestCurrentStats_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0003C430 File Offset: 0x0003A630
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 936049, RefRangeEnd = 936051, XrefRangeStart = 936047, XrefRangeEnd = 936049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RequestCurrentStats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_RequestCurrentStats_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0003C46C File Offset: 0x0003A66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936051, XrefRangeEnd = 936054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetStat(IntPtr self, string pchName, ref int pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetStat_Private_Static_Boolean_IntPtr_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0003C4CC File Offset: 0x0003A6CC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 936057, RefRangeEnd = 936060, XrefRangeStart = 936054, XrefRangeEnd = 936057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetStat(string pchName, ref int pData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetStat_Internal_Boolean_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0003C528 File Offset: 0x0003A728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936060, XrefRangeEnd = 936063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetStat(IntPtr self, string pchName, ref float pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetStat_Private_Static_Boolean_IntPtr_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0003C588 File Offset: 0x0003A788
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 936066, RefRangeEnd = 936069, XrefRangeStart = 936063, XrefRangeEnd = 936066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetStat(string pchName, ref float pData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetStat_Internal_Boolean_String_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0003C5E4 File Offset: 0x0003A7E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936069, XrefRangeEnd = 936072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetStat(IntPtr self, string pchName, int nData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__SetStat_Private_Static_Boolean_IntPtr_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0003C644 File Offset: 0x0003A844
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 936075, RefRangeEnd = 936079, XrefRangeStart = 936072, XrefRangeEnd = 936075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetStat(string pchName, int nData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_SetStat_Internal_Boolean_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0003C6A0 File Offset: 0x0003A8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936079, XrefRangeEnd = 936082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetStat(IntPtr self, string pchName, float fData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__SetStat_Private_Static_Boolean_IntPtr_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0003C700 File Offset: 0x0003A900
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 936085, RefRangeEnd = 936089, XrefRangeStart = 936082, XrefRangeEnd = 936085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetStat(string pchName, float fData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_SetStat_Internal_Boolean_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0003C75C File Offset: 0x0003A95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936089, XrefRangeEnd = 936092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _UpdateAvgRateStat(IntPtr self, string pchName, float flCountThisSession, double dSessionLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flCountThisSession;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dSessionLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__UpdateAvgRateStat_Private_Static_Boolean_IntPtr_String_Single_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0003C7C8 File Offset: 0x0003A9C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936095, RefRangeEnd = 936096, XrefRangeStart = 936092, XrefRangeEnd = 936095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool UpdateAvgRateStat(string pchName, float flCountThisSession, double dSessionLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flCountThisSession;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dSessionLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_UpdateAvgRateStat_Internal_Boolean_String_Single_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0003C834 File Offset: 0x0003AA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936096, XrefRangeEnd = 936099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetAchievement(IntPtr self, string pchName, ref bool pbAchieved)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetAchievement_Private_Static_Boolean_IntPtr_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0003C894 File Offset: 0x0003AA94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936102, RefRangeEnd = 936103, XrefRangeStart = 936099, XrefRangeEnd = 936102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAchievement(string pchName, ref bool pbAchieved)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetAchievement_Internal_Boolean_String_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0003C8F0 File Offset: 0x0003AAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936103, XrefRangeEnd = 936106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _SetAchievement(IntPtr self, string pchName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__SetAchievement_Private_Static_Boolean_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0003C940 File Offset: 0x0003AB40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936109, RefRangeEnd = 936110, XrefRangeStart = 936106, XrefRangeEnd = 936109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetAchievement(string pchName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_SetAchievement_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0003C990 File Offset: 0x0003AB90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936110, XrefRangeEnd = 936113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ClearAchievement(IntPtr self, string pchName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__ClearAchievement_Private_Static_Boolean_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0003C9E0 File Offset: 0x0003ABE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936116, RefRangeEnd = 936117, XrefRangeStart = 936113, XrefRangeEnd = 936116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ClearAchievement(string pchName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_ClearAchievement_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0003CA30 File Offset: 0x0003AC30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936117, XrefRangeEnd = 936120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetAchievementAndUnlockTime(IntPtr self, string pchName, ref bool pbAchieved, ref uint punUnlockTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punUnlockTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetAchievementAndUnlockTime_Private_Static_Boolean_IntPtr_String_byref_Boolean_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0003CA9C File Offset: 0x0003AC9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936123, RefRangeEnd = 936124, XrefRangeStart = 936120, XrefRangeEnd = 936123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAchievementAndUnlockTime(string pchName, ref bool pbAchieved, ref uint punUnlockTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punUnlockTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetAchievementAndUnlockTime_Internal_Boolean_String_byref_Boolean_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0003CB08 File Offset: 0x0003AD08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936124, XrefRangeEnd = 936126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _StoreStats(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__StoreStats_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0003CB48 File Offset: 0x0003AD48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 936128, RefRangeEnd = 936131, XrefRangeStart = 936126, XrefRangeEnd = 936128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StoreStats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_StoreStats_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0003CB84 File Offset: 0x0003AD84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936131, XrefRangeEnd = 936134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetAchievementIcon(IntPtr self, string pchName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetAchievementIcon_Private_Static_Int32_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0003CBD4 File Offset: 0x0003ADD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 936137, RefRangeEnd = 936139, XrefRangeStart = 936134, XrefRangeEnd = 936137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetAchievementIcon(string pchName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetAchievementIcon_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0003CC24 File Offset: 0x0003AE24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936139, XrefRangeEnd = 936144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetAchievementDisplayAttribute(IntPtr self, string pchName, string pchKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetAchievementDisplayAttribute_Private_Static_Utf8StringPointer_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0003CC88 File Offset: 0x0003AE88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 936150, RefRangeEnd = 936152, XrefRangeStart = 936144, XrefRangeEnd = 936150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAchievementDisplayAttribute(string pchName, string pchKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetAchievementDisplayAttribute_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0003CCE4 File Offset: 0x0003AEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936152, XrefRangeEnd = 936155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _IndicateAchievementProgress(IntPtr self, string pchName, uint nCurProgress, uint nMaxProgress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nCurProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__IndicateAchievementProgress_Private_Static_Boolean_IntPtr_String_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0003CD50 File Offset: 0x0003AF50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936158, RefRangeEnd = 936159, XrefRangeStart = 936155, XrefRangeEnd = 936158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IndicateAchievementProgress(string pchName, uint nCurProgress, uint nMaxProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nCurProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_IndicateAchievementProgress_Internal_Boolean_String_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0003CDBC File Offset: 0x0003AFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936159, XrefRangeEnd = 936161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint _GetNumAchievements(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetNumAchievements_Private_Static_UInt32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0003CDFC File Offset: 0x0003AFFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936163, RefRangeEnd = 936164, XrefRangeStart = 936161, XrefRangeEnd = 936163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint GetNumAchievements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetNumAchievements_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0003CE38 File Offset: 0x0003B038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936164, XrefRangeEnd = 936166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetAchievementName(IntPtr self, uint iAchievement)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iAchievement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetAchievementName_Private_Static_Utf8StringPointer_IntPtr_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0003CE84 File Offset: 0x0003B084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936169, RefRangeEnd = 936170, XrefRangeStart = 936166, XrefRangeEnd = 936169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAchievementName(uint iAchievement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iAchievement;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetAchievementName_Internal_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0003CEC8 File Offset: 0x0003B0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936170, XrefRangeEnd = 936172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _RequestUserStats(IntPtr self, SteamId steamIDUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__RequestUserStats_Private_Static_SteamAPICall_t_IntPtr_SteamId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0003CF14 File Offset: 0x0003B114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936177, RefRangeEnd = 936178, XrefRangeStart = 936172, XrefRangeEnd = 936177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<UserStatsReceived_t> RequestUserStats(SteamId steamIDUser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_RequestUserStats_Internal_CallResult_1_UserStatsReceived_t_SteamId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<UserStatsReceived_t>(intPtr);
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0003CF58 File Offset: 0x0003B158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936178, XrefRangeEnd = 936181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetUserStat(IntPtr self, SteamId steamIDUser, string pchName, ref int pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0003CFC4 File Offset: 0x0003B1C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936184, RefRangeEnd = 936185, XrefRangeStart = 936181, XrefRangeEnd = 936184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetUserStat(SteamId steamIDUser, string pchName, ref int pData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetUserStat_Internal_Boolean_SteamId_String_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0003D030 File Offset: 0x0003B230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936185, XrefRangeEnd = 936188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetUserStat(IntPtr self, SteamId steamIDUser, string pchName, ref float pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0003D09C File Offset: 0x0003B29C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936191, RefRangeEnd = 936192, XrefRangeStart = 936188, XrefRangeEnd = 936191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetUserStat(SteamId steamIDUser, string pchName, ref float pData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetUserStat_Internal_Boolean_SteamId_String_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0003D108 File Offset: 0x0003B308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936192, XrefRangeEnd = 936195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetUserAchievement(IntPtr self, SteamId steamIDUser, string pchName, ref bool pbAchieved)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetUserAchievement_Private_Static_Boolean_IntPtr_SteamId_String_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0003D174 File Offset: 0x0003B374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936198, RefRangeEnd = 936199, XrefRangeStart = 936195, XrefRangeEnd = 936198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetUserAchievement(SteamId steamIDUser, string pchName, ref bool pbAchieved)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetUserAchievement_Internal_Boolean_SteamId_String_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0003D1E0 File Offset: 0x0003B3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936199, XrefRangeEnd = 936202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetUserAchievementAndUnlockTime(IntPtr self, SteamId steamIDUser, string pchName, ref bool pbAchieved, ref uint punUnlockTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punUnlockTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetUserAchievementAndUnlockTime_Private_Static_Boolean_IntPtr_SteamId_String_byref_Boolean_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0003D25C File Offset: 0x0003B45C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936205, RefRangeEnd = 936206, XrefRangeStart = 936202, XrefRangeEnd = 936205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetUserAchievementAndUnlockTime(SteamId steamIDUser, string pchName, ref bool pbAchieved, ref uint punUnlockTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punUnlockTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetUserAchievementAndUnlockTime_Internal_Boolean_SteamId_String_byref_Boolean_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0003D2D4 File Offset: 0x0003B4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936206, XrefRangeEnd = 936208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ResetAllStats(IntPtr self, bool bAchievementsToo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bAchievementsToo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__ResetAllStats_Private_Static_Boolean_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0003D320 File Offset: 0x0003B520
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936210, RefRangeEnd = 936211, XrefRangeStart = 936208, XrefRangeEnd = 936210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ResetAllStats(bool bAchievementsToo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bAchievementsToo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_ResetAllStats_Internal_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0003D36C File Offset: 0x0003B56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936211, XrefRangeEnd = 936214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _FindOrCreateLeaderboard(IntPtr self, string pchLeaderboardName, LeaderboardSort eLeaderboardSortMethod, LeaderboardDisplay eLeaderboardDisplayType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchLeaderboardName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLeaderboardSortMethod;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLeaderboardDisplayType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__FindOrCreateLeaderboard_Private_Static_SteamAPICall_t_IntPtr_String_LeaderboardSort_LeaderboardDisplay_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0003D3D8 File Offset: 0x0003B5D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936220, RefRangeEnd = 936221, XrefRangeStart = 936214, XrefRangeEnd = 936220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<LeaderboardFindResult_t> FindOrCreateLeaderboard(string pchLeaderboardName, LeaderboardSort eLeaderboardSortMethod, LeaderboardDisplay eLeaderboardDisplayType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchLeaderboardName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLeaderboardSortMethod;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLeaderboardDisplayType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_FindOrCreateLeaderboard_Internal_CallResult_1_LeaderboardFindResult_t_String_LeaderboardSort_LeaderboardDisplay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<LeaderboardFindResult_t>(intPtr);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0003D43C File Offset: 0x0003B63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936221, XrefRangeEnd = 936224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _FindLeaderboard(IntPtr self, string pchLeaderboardName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchLeaderboardName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__FindLeaderboard_Private_Static_SteamAPICall_t_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0003D48C File Offset: 0x0003B68C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936230, RefRangeEnd = 936231, XrefRangeStart = 936224, XrefRangeEnd = 936230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<LeaderboardFindResult_t> FindLeaderboard(string pchLeaderboardName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchLeaderboardName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_FindLeaderboard_Internal_CallResult_1_LeaderboardFindResult_t_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<LeaderboardFindResult_t>(intPtr);
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0003D4D4 File Offset: 0x0003B6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936231, XrefRangeEnd = 936233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Utf8StringPointer _GetLeaderboardName(IntPtr self, SteamLeaderboard_t hSteamLeaderboard)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamLeaderboard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetLeaderboardName_Private_Static_Utf8StringPointer_IntPtr_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0003D520 File Offset: 0x0003B720
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936236, RefRangeEnd = 936237, XrefRangeStart = 936233, XrefRangeEnd = 936236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLeaderboardName(SteamLeaderboard_t hSteamLeaderboard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetLeaderboardName_Internal_String_SteamLeaderboard_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0003D564 File Offset: 0x0003B764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936237, XrefRangeEnd = 936239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetLeaderboardEntryCount(IntPtr self, SteamLeaderboard_t hSteamLeaderboard)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamLeaderboard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetLeaderboardEntryCount_Private_Static_Int32_IntPtr_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0003D5B0 File Offset: 0x0003B7B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936241, RefRangeEnd = 936242, XrefRangeStart = 936239, XrefRangeEnd = 936241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLeaderboardEntryCount(SteamLeaderboard_t hSteamLeaderboard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetLeaderboardEntryCount_Internal_Int32_SteamLeaderboard_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0003D5FC File Offset: 0x0003B7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936242, XrefRangeEnd = 936244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LeaderboardSort _GetLeaderboardSortMethod(IntPtr self, SteamLeaderboard_t hSteamLeaderboard)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamLeaderboard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetLeaderboardSortMethod_Private_Static_LeaderboardSort_IntPtr_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0003D648 File Offset: 0x0003B848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936246, RefRangeEnd = 936247, XrefRangeStart = 936244, XrefRangeEnd = 936246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaderboardSort GetLeaderboardSortMethod(SteamLeaderboard_t hSteamLeaderboard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetLeaderboardSortMethod_Internal_LeaderboardSort_SteamLeaderboard_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0003D694 File Offset: 0x0003B894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936247, XrefRangeEnd = 936249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static LeaderboardDisplay _GetLeaderboardDisplayType(IntPtr self, SteamLeaderboard_t hSteamLeaderboard)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamLeaderboard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetLeaderboardDisplayType_Private_Static_LeaderboardDisplay_IntPtr_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0003D6E0 File Offset: 0x0003B8E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936251, RefRangeEnd = 936252, XrefRangeStart = 936249, XrefRangeEnd = 936251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaderboardDisplay GetLeaderboardDisplayType(SteamLeaderboard_t hSteamLeaderboard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetLeaderboardDisplayType_Internal_LeaderboardDisplay_SteamLeaderboard_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0003D72C File Offset: 0x0003B92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936252, XrefRangeEnd = 936254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _DownloadLeaderboardEntries(IntPtr self, SteamLeaderboard_t hSteamLeaderboard, LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamLeaderboard;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLeaderboardDataRequest;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRangeStart;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRangeEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__DownloadLeaderboardEntries_Private_Static_SteamAPICall_t_IntPtr_SteamLeaderboard_t_LeaderboardDataRequest_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0003D7A4 File Offset: 0x0003B9A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 936259, RefRangeEnd = 936262, XrefRangeStart = 936254, XrefRangeEnd = 936259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<LeaderboardScoresDownloaded_t> DownloadLeaderboardEntries(SteamLeaderboard_t hSteamLeaderboard, LeaderboardDataRequest eLeaderboardDataRequest, int nRangeStart, int nRangeEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLeaderboardDataRequest;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRangeStart;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nRangeEnd;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_DownloadLeaderboardEntries_Internal_CallResult_1_LeaderboardScoresDownloaded_t_SteamLeaderboard_t_LeaderboardDataRequest_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<LeaderboardScoresDownloaded_t>(intPtr);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0003D814 File Offset: 0x0003BA14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936262, XrefRangeEnd = 936264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _DownloadLeaderboardEntriesForUsers(IntPtr self, SteamLeaderboard_t hSteamLeaderboard, [In] [Out] Il2CppStructArray<SteamId> prgUsers, int cUsers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamLeaderboard;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cUsers;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__DownloadLeaderboardEntriesForUsers_Private_Static_SteamAPICall_t_IntPtr_SteamLeaderboard_t_Il2CppStructArray_1_SteamId_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*prgUsers = ((intPtr4 == 0) ? null : new Il2CppStructArray<SteamId>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0003D890 File Offset: 0x0003BA90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936269, RefRangeEnd = 936270, XrefRangeStart = 936264, XrefRangeEnd = 936269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<LeaderboardScoresDownloaded_t> DownloadLeaderboardEntriesForUsers(SteamLeaderboard_t hSteamLeaderboard, [In] [Out] Il2CppStructArray<SteamId> prgUsers, int cUsers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cUsers;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_DownloadLeaderboardEntriesForUsers_Internal_CallResult_1_LeaderboardScoresDownloaded_t_SteamLeaderboard_t_Il2CppStructArray_1_SteamId_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*prgUsers = ((intPtr4 == 0) ? null : new Il2CppStructArray<SteamId>(intPtr4));
			return new CallResult<LeaderboardScoresDownloaded_t>(intPtr2);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0003D908 File Offset: 0x0003BB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936270, XrefRangeEnd = 936272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetDownloadedLeaderboardEntry(IntPtr self, SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, ref LeaderboardEntry_t pLeaderboardEntry, [In] [Out] Il2CppStructArray<int> pDetails, int cDetailsMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamLeaderboardEntries;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pLeaderboardEntry;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cDetailsMax;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetDownloadedLeaderboardEntry_Private_Static_Boolean_IntPtr_SteamLeaderboardEntries_t_Int32_byref_LeaderboardEntry_t_Il2CppStructArray_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pDetails = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0003D9A4 File Offset: 0x0003BBA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936274, RefRangeEnd = 936275, XrefRangeStart = 936272, XrefRangeEnd = 936274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetDownloadedLeaderboardEntry(SteamLeaderboardEntries_t hSteamLeaderboardEntries, int index, ref LeaderboardEntry_t pLeaderboardEntry, [In] [Out] Il2CppStructArray<int> pDetails, int cDetailsMax)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboardEntries;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pLeaderboardEntry;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cDetailsMax;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetDownloadedLeaderboardEntry_Internal_Boolean_SteamLeaderboardEntries_t_Int32_byref_LeaderboardEntry_t_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pDetails = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0003DA3C File Offset: 0x0003BC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936275, XrefRangeEnd = 936277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _UploadLeaderboardScore(IntPtr self, SteamLeaderboard_t hSteamLeaderboard, LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In] [Out] Il2CppStructArray<int> pScoreDetails, int cScoreDetailsCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamLeaderboard;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLeaderboardUploadScoreMethod;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cScoreDetailsCount;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__UploadLeaderboardScore_Private_Static_SteamAPICall_t_IntPtr_SteamLeaderboard_t_LeaderboardUploadScoreMethod_Int32_Il2CppStructArray_1_Int32_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pScoreDetails = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0003DAD8 File Offset: 0x0003BCD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 936282, RefRangeEnd = 936284, XrefRangeStart = 936277, XrefRangeEnd = 936282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<LeaderboardScoreUploaded_t> UploadLeaderboardScore(SteamLeaderboard_t hSteamLeaderboard, LeaderboardUploadScoreMethod eLeaderboardUploadScoreMethod, int nScore, [In] [Out] Il2CppStructArray<int> pScoreDetails, int cScoreDetailsCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLeaderboardUploadScoreMethod;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nScore;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cScoreDetailsCount;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_UploadLeaderboardScore_Internal_CallResult_1_LeaderboardScoreUploaded_t_SteamLeaderboard_t_LeaderboardUploadScoreMethod_Int32_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pScoreDetails = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			return new CallResult<LeaderboardScoreUploaded_t>(intPtr2);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0003DB6C File Offset: 0x0003BD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936284, XrefRangeEnd = 936286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _AttachLeaderboardUGC(IntPtr self, SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hSteamLeaderboard;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hUGC;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__AttachLeaderboardUGC_Private_Static_SteamAPICall_t_IntPtr_SteamLeaderboard_t_UGCHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0003DBC8 File Offset: 0x0003BDC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936291, RefRangeEnd = 936292, XrefRangeStart = 936286, XrefRangeEnd = 936291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<LeaderboardUGCSet_t> AttachLeaderboardUGC(SteamLeaderboard_t hSteamLeaderboard, UGCHandle_t hUGC)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamLeaderboard;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hUGC;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_AttachLeaderboardUGC_Internal_CallResult_1_LeaderboardUGCSet_t_SteamLeaderboard_t_UGCHandle_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<LeaderboardUGCSet_t>(intPtr);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0003DC1C File Offset: 0x0003BE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936292, XrefRangeEnd = 936294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _GetNumberOfCurrentPlayers(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetNumberOfCurrentPlayers_Private_Static_SteamAPICall_t_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0003DC5C File Offset: 0x0003BE5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936299, RefRangeEnd = 936300, XrefRangeStart = 936294, XrefRangeEnd = 936299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<NumberOfCurrentPlayers_t> GetNumberOfCurrentPlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetNumberOfCurrentPlayers_Internal_CallResult_1_NumberOfCurrentPlayers_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<NumberOfCurrentPlayers_t>(intPtr);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0003DC94 File Offset: 0x0003BE94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936300, XrefRangeEnd = 936302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _RequestGlobalAchievementPercentages(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__RequestGlobalAchievementPercentages_Private_Static_SteamAPICall_t_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0003DCD4 File Offset: 0x0003BED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936302, XrefRangeEnd = 936307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<GlobalAchievementPercentagesReady_t> RequestGlobalAchievementPercentages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_RequestGlobalAchievementPercentages_Internal_CallResult_1_GlobalAchievementPercentagesReady_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new CallResult<GlobalAchievementPercentagesReady_t>(intPtr);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0003DD0C File Offset: 0x0003BF0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936307, XrefRangeEnd = 936309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetMostAchievedAchievementInfo(IntPtr self, IntPtr pchName, uint unNameBufLen, ref float pflPercent, ref bool pbAchieved)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unNameBufLen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercent;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetMostAchievedAchievementInfo_Private_Static_Int32_IntPtr_IntPtr_UInt32_byref_Single_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0003DD84 File Offset: 0x0003BF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936309, XrefRangeEnd = 936331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMostAchievedAchievementInfo(out string pchName, ref float pflPercent, ref bool pbAchieved)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetMostAchievedAchievementInfo_Internal_Int32_byref_String_byref_Single_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0003DDF8 File Offset: 0x0003BFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936331, XrefRangeEnd = 936333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetNextMostAchievedAchievementInfo(IntPtr self, int iIteratorPrevious, IntPtr pchName, uint unNameBufLen, ref float pflPercent, ref bool pbAchieved)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iIteratorPrevious;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pchName;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unNameBufLen;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercent;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetNextMostAchievedAchievementInfo_Private_Static_Int32_IntPtr_Int32_IntPtr_UInt32_byref_Single_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0003DE80 File Offset: 0x0003C080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936333, XrefRangeEnd = 936355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNextMostAchievedAchievementInfo(int iIteratorPrevious, out string pchName, ref float pflPercent, ref bool pbAchieved)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iIteratorPrevious;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercent;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbAchieved;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetNextMostAchievedAchievementInfo_Internal_Int32_Int32_byref_String_byref_Single_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchName = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0003DF04 File Offset: 0x0003C104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936355, XrefRangeEnd = 936358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetAchievementAchievedPercent(IntPtr self, string pchName, ref float pflPercent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetAchievementAchievedPercent_Private_Static_Boolean_IntPtr_String_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0003DF64 File Offset: 0x0003C164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936361, RefRangeEnd = 936362, XrefRangeStart = 936358, XrefRangeEnd = 936361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAchievementAchievedPercent(string pchName, ref float pflPercent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pflPercent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetAchievementAchievedPercent_Internal_Boolean_String_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0003DFC0 File Offset: 0x0003C1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936362, XrefRangeEnd = 936364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t _RequestGlobalStats(IntPtr self, int nHistoryDays)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nHistoryDays;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__RequestGlobalStats_Private_Static_SteamAPICall_t_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0003E00C File Offset: 0x0003C20C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 936369, RefRangeEnd = 936372, XrefRangeStart = 936364, XrefRangeEnd = 936369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallResult<GlobalStatsReceived_t> RequestGlobalStats(int nHistoryDays)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nHistoryDays;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_RequestGlobalStats_Internal_CallResult_1_GlobalStatsReceived_t_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CallResult<GlobalStatsReceived_t>(intPtr);
			}
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0003E050 File Offset: 0x0003C250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936372, XrefRangeEnd = 936375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetGlobalStat(IntPtr self, string pchStatName, ref long pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchStatName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetGlobalStat_Private_Static_Boolean_IntPtr_String_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0003E0B0 File Offset: 0x0003C2B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936378, RefRangeEnd = 936379, XrefRangeStart = 936375, XrefRangeEnd = 936378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetGlobalStat(string pchStatName, ref long pData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchStatName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetGlobalStat_Internal_Boolean_String_byref_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0003E10C File Offset: 0x0003C30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936379, XrefRangeEnd = 936382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetGlobalStat(IntPtr self, string pchStatName, ref double pData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchStatName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetGlobalStat_Private_Static_Boolean_IntPtr_String_byref_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0003E16C File Offset: 0x0003C36C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936385, RefRangeEnd = 936386, XrefRangeStart = 936382, XrefRangeEnd = 936385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetGlobalStat(string pchStatName, ref double pData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchStatName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetGlobalStat_Internal_Boolean_String_byref_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0003E1C8 File Offset: 0x0003C3C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936386, XrefRangeEnd = 936389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetGlobalStatHistory(IntPtr self, string pchStatName, [In] [Out] Il2CppStructArray<long> pData, uint cubData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchStatName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetGlobalStatHistory_Private_Static_Int32_IntPtr_String_Il2CppStructArray_1_Int64_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pData = ((intPtr4 == 0) ? null : new Il2CppStructArray<long>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0003E248 File Offset: 0x0003C448
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936392, RefRangeEnd = 936393, XrefRangeStart = 936389, XrefRangeEnd = 936392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGlobalStatHistory(string pchStatName, [In] [Out] Il2CppStructArray<long> pData, uint cubData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchStatName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetGlobalStatHistory_Internal_Int32_String_Il2CppStructArray_1_Int64_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pData = ((intPtr4 == 0) ? null : new Il2CppStructArray<long>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0003E2C8 File Offset: 0x0003C4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936393, XrefRangeEnd = 936396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int _GetGlobalStatHistory(IntPtr self, string pchStatName, [In] [Out] Il2CppStructArray<double> pData, uint cubData)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchStatName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetGlobalStatHistory_Private_Static_Int32_IntPtr_String_Il2CppStructArray_1_Double_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pData = ((intPtr4 == 0) ? null : new Il2CppStructArray<double>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0003E348 File Offset: 0x0003C548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 936399, RefRangeEnd = 936400, XrefRangeStart = 936396, XrefRangeEnd = 936399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGlobalStatHistory(string pchStatName, [In] [Out] Il2CppStructArray<double> pData, uint cubData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchStatName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetGlobalStatHistory_Internal_Int32_String_Il2CppStructArray_1_Double_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*pData = ((intPtr4 == 0) ? null : new Il2CppStructArray<double>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0003E3C8 File Offset: 0x0003C5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936400, XrefRangeEnd = 936403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetAchievementProgressLimits(IntPtr self, string pchName, ref int pnMinProgress, ref int pnMaxProgress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnMinProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnMaxProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetAchievementProgressLimits_Private_Static_Boolean_IntPtr_String_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0003E434 File Offset: 0x0003C634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936403, XrefRangeEnd = 936406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAchievementProgressLimits(string pchName, ref int pnMinProgress, ref int pnMaxProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnMinProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnMaxProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetAchievementProgressLimits_Internal_Boolean_String_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0003E4A0 File Offset: 0x0003C6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936406, XrefRangeEnd = 936409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _GetAchievementProgressLimits(IntPtr self, string pchName, ref float pfMinProgress, ref float pfMaxProgress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pfMinProgress;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pfMaxProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr__GetAchievementProgressLimits_Private_Static_Boolean_IntPtr_String_byref_Single_byref_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0003E50C File Offset: 0x0003C70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936409, XrefRangeEnd = 936412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAchievementProgressLimits(string pchName, ref float pfMinProgress, ref float pfMaxProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pfMinProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pfMaxProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamUserStats.NativeMethodInfoPtr_GetAchievementProgressLimits_Internal_Boolean_String_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000023F3 File Offset: 0x000005F3
		public ISteamUserStats(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamUserStats_v012_Internal_Static_IntPtr_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr__RequestCurrentStats_Private_Static_Boolean_IntPtr_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_RequestCurrentStats_Internal_Boolean_0;

		// Token: 0x0400079C RID: 1948
		private static readonly IntPtr NativeMethodInfoPtr__GetStat_Private_Static_Boolean_IntPtr_String_byref_Int32_0;

		// Token: 0x0400079D RID: 1949
		private static readonly IntPtr NativeMethodInfoPtr_GetStat_Internal_Boolean_String_byref_Int32_0;

		// Token: 0x0400079E RID: 1950
		private static readonly IntPtr NativeMethodInfoPtr__GetStat_Private_Static_Boolean_IntPtr_String_byref_Single_0;

		// Token: 0x0400079F RID: 1951
		private static readonly IntPtr NativeMethodInfoPtr_GetStat_Internal_Boolean_String_byref_Single_0;

		// Token: 0x040007A0 RID: 1952
		private static readonly IntPtr NativeMethodInfoPtr__SetStat_Private_Static_Boolean_IntPtr_String_Int32_0;

		// Token: 0x040007A1 RID: 1953
		private static readonly IntPtr NativeMethodInfoPtr_SetStat_Internal_Boolean_String_Int32_0;

		// Token: 0x040007A2 RID: 1954
		private static readonly IntPtr NativeMethodInfoPtr__SetStat_Private_Static_Boolean_IntPtr_String_Single_0;

		// Token: 0x040007A3 RID: 1955
		private static readonly IntPtr NativeMethodInfoPtr_SetStat_Internal_Boolean_String_Single_0;

		// Token: 0x040007A4 RID: 1956
		private static readonly IntPtr NativeMethodInfoPtr__UpdateAvgRateStat_Private_Static_Boolean_IntPtr_String_Single_Double_0;

		// Token: 0x040007A5 RID: 1957
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvgRateStat_Internal_Boolean_String_Single_Double_0;

		// Token: 0x040007A6 RID: 1958
		private static readonly IntPtr NativeMethodInfoPtr__GetAchievement_Private_Static_Boolean_IntPtr_String_byref_Boolean_0;

		// Token: 0x040007A7 RID: 1959
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievement_Internal_Boolean_String_byref_Boolean_0;

		// Token: 0x040007A8 RID: 1960
		private static readonly IntPtr NativeMethodInfoPtr__SetAchievement_Private_Static_Boolean_IntPtr_String_0;

		// Token: 0x040007A9 RID: 1961
		private static readonly IntPtr NativeMethodInfoPtr_SetAchievement_Internal_Boolean_String_0;

		// Token: 0x040007AA RID: 1962
		private static readonly IntPtr NativeMethodInfoPtr__ClearAchievement_Private_Static_Boolean_IntPtr_String_0;

		// Token: 0x040007AB RID: 1963
		private static readonly IntPtr NativeMethodInfoPtr_ClearAchievement_Internal_Boolean_String_0;

		// Token: 0x040007AC RID: 1964
		private static readonly IntPtr NativeMethodInfoPtr__GetAchievementAndUnlockTime_Private_Static_Boolean_IntPtr_String_byref_Boolean_byref_UInt32_0;

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementAndUnlockTime_Internal_Boolean_String_byref_Boolean_byref_UInt32_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr__StoreStats_Private_Static_Boolean_IntPtr_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_StoreStats_Internal_Boolean_0;

		// Token: 0x040007B0 RID: 1968
		private static readonly IntPtr NativeMethodInfoPtr__GetAchievementIcon_Private_Static_Int32_IntPtr_String_0;

		// Token: 0x040007B1 RID: 1969
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementIcon_Internal_Int32_String_0;

		// Token: 0x040007B2 RID: 1970
		private static readonly IntPtr NativeMethodInfoPtr__GetAchievementDisplayAttribute_Private_Static_Utf8StringPointer_IntPtr_String_String_0;

		// Token: 0x040007B3 RID: 1971
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementDisplayAttribute_Internal_String_String_String_0;

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr__IndicateAchievementProgress_Private_Static_Boolean_IntPtr_String_UInt32_UInt32_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_IndicateAchievementProgress_Internal_Boolean_String_UInt32_UInt32_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr__GetNumAchievements_Private_Static_UInt32_IntPtr_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_GetNumAchievements_Internal_UInt32_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr__GetAchievementName_Private_Static_Utf8StringPointer_IntPtr_UInt32_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementName_Internal_String_UInt32_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr__RequestUserStats_Private_Static_SteamAPICall_t_IntPtr_SteamId_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_RequestUserStats_Internal_CallResult_1_UserStatsReceived_t_SteamId_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr__GetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_byref_Int32_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_GetUserStat_Internal_Boolean_SteamId_String_byref_Int32_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr__GetUserStat_Private_Static_Boolean_IntPtr_SteamId_String_byref_Single_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr_GetUserStat_Internal_Boolean_SteamId_String_byref_Single_0;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeMethodInfoPtr__GetUserAchievement_Private_Static_Boolean_IntPtr_SteamId_String_byref_Boolean_0;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeMethodInfoPtr_GetUserAchievement_Internal_Boolean_SteamId_String_byref_Boolean_0;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeMethodInfoPtr__GetUserAchievementAndUnlockTime_Private_Static_Boolean_IntPtr_SteamId_String_byref_Boolean_byref_UInt32_0;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_GetUserAchievementAndUnlockTime_Internal_Boolean_SteamId_String_byref_Boolean_byref_UInt32_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr__ResetAllStats_Private_Static_Boolean_IntPtr_Boolean_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr_ResetAllStats_Internal_Boolean_Boolean_0;

		// Token: 0x040007C6 RID: 1990
		private static readonly IntPtr NativeMethodInfoPtr__FindOrCreateLeaderboard_Private_Static_SteamAPICall_t_IntPtr_String_LeaderboardSort_LeaderboardDisplay_0;

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeMethodInfoPtr_FindOrCreateLeaderboard_Internal_CallResult_1_LeaderboardFindResult_t_String_LeaderboardSort_LeaderboardDisplay_0;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeMethodInfoPtr__FindLeaderboard_Private_Static_SteamAPICall_t_IntPtr_String_0;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeMethodInfoPtr_FindLeaderboard_Internal_CallResult_1_LeaderboardFindResult_t_String_0;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeMethodInfoPtr__GetLeaderboardName_Private_Static_Utf8StringPointer_IntPtr_SteamLeaderboard_t_0;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderboardName_Internal_String_SteamLeaderboard_t_0;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeMethodInfoPtr__GetLeaderboardEntryCount_Private_Static_Int32_IntPtr_SteamLeaderboard_t_0;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderboardEntryCount_Internal_Int32_SteamLeaderboard_t_0;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeMethodInfoPtr__GetLeaderboardSortMethod_Private_Static_LeaderboardSort_IntPtr_SteamLeaderboard_t_0;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderboardSortMethod_Internal_LeaderboardSort_SteamLeaderboard_t_0;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeMethodInfoPtr__GetLeaderboardDisplayType_Private_Static_LeaderboardDisplay_IntPtr_SteamLeaderboard_t_0;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeMethodInfoPtr_GetLeaderboardDisplayType_Internal_LeaderboardDisplay_SteamLeaderboard_t_0;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeMethodInfoPtr__DownloadLeaderboardEntries_Private_Static_SteamAPICall_t_IntPtr_SteamLeaderboard_t_LeaderboardDataRequest_Int32_Int32_0;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeMethodInfoPtr_DownloadLeaderboardEntries_Internal_CallResult_1_LeaderboardScoresDownloaded_t_SteamLeaderboard_t_LeaderboardDataRequest_Int32_Int32_0;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeMethodInfoPtr__DownloadLeaderboardEntriesForUsers_Private_Static_SteamAPICall_t_IntPtr_SteamLeaderboard_t_Il2CppStructArray_1_SteamId_Int32_0;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeMethodInfoPtr_DownloadLeaderboardEntriesForUsers_Internal_CallResult_1_LeaderboardScoresDownloaded_t_SteamLeaderboard_t_Il2CppStructArray_1_SteamId_Int32_0;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeMethodInfoPtr__GetDownloadedLeaderboardEntry_Private_Static_Boolean_IntPtr_SteamLeaderboardEntries_t_Int32_byref_LeaderboardEntry_t_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadedLeaderboardEntry_Internal_Boolean_SteamLeaderboardEntries_t_Int32_byref_LeaderboardEntry_t_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeMethodInfoPtr__UploadLeaderboardScore_Private_Static_SteamAPICall_t_IntPtr_SteamLeaderboard_t_LeaderboardUploadScoreMethod_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeMethodInfoPtr_UploadLeaderboardScore_Internal_CallResult_1_LeaderboardScoreUploaded_t_SteamLeaderboard_t_LeaderboardUploadScoreMethod_Int32_Il2CppStructArray_1_Int32_Int32_0;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeMethodInfoPtr__AttachLeaderboardUGC_Private_Static_SteamAPICall_t_IntPtr_SteamLeaderboard_t_UGCHandle_t_0;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_AttachLeaderboardUGC_Internal_CallResult_1_LeaderboardUGCSet_t_SteamLeaderboard_t_UGCHandle_t_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr__GetNumberOfCurrentPlayers_Private_Static_SteamAPICall_t_IntPtr_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_GetNumberOfCurrentPlayers_Internal_CallResult_1_NumberOfCurrentPlayers_t_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr__RequestGlobalAchievementPercentages_Private_Static_SteamAPICall_t_IntPtr_0;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeMethodInfoPtr_RequestGlobalAchievementPercentages_Internal_CallResult_1_GlobalAchievementPercentagesReady_t_0;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr__GetMostAchievedAchievementInfo_Private_Static_Int32_IntPtr_IntPtr_UInt32_byref_Single_byref_Boolean_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_GetMostAchievedAchievementInfo_Internal_Int32_byref_String_byref_Single_byref_Boolean_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr__GetNextMostAchievedAchievementInfo_Private_Static_Int32_IntPtr_Int32_IntPtr_UInt32_byref_Single_byref_Boolean_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_GetNextMostAchievedAchievementInfo_Internal_Int32_Int32_byref_String_byref_Single_byref_Boolean_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr__GetAchievementAchievedPercent_Private_Static_Boolean_IntPtr_String_byref_Single_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementAchievedPercent_Internal_Boolean_String_byref_Single_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr__RequestGlobalStats_Private_Static_SteamAPICall_t_IntPtr_Int32_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_RequestGlobalStats_Internal_CallResult_1_GlobalStatsReceived_t_Int32_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr__GetGlobalStat_Private_Static_Boolean_IntPtr_String_byref_Int64_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalStat_Internal_Boolean_String_byref_Int64_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr__GetGlobalStat_Private_Static_Boolean_IntPtr_String_byref_Double_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalStat_Internal_Boolean_String_byref_Double_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr__GetGlobalStatHistory_Private_Static_Int32_IntPtr_String_Il2CppStructArray_1_Int64_UInt32_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalStatHistory_Internal_Int32_String_Il2CppStructArray_1_Int64_UInt32_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr__GetGlobalStatHistory_Private_Static_Int32_IntPtr_String_Il2CppStructArray_1_Double_UInt32_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_GetGlobalStatHistory_Internal_Int32_String_Il2CppStructArray_1_Double_UInt32_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr__GetAchievementProgressLimits_Private_Static_Boolean_IntPtr_String_byref_Int32_byref_Int32_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementProgressLimits_Internal_Boolean_String_byref_Int32_byref_Int32_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr__GetAchievementProgressLimits_Private_Static_Boolean_IntPtr_String_byref_Single_byref_Single_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_GetAchievementProgressLimits_Internal_Boolean_String_byref_Single_byref_Single_0;
	}
}
