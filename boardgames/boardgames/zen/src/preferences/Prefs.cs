using System;
using boardgames.utils;
using Canis.utils.ids;
using dwd.core.settings;
using dwd.core.settings.config.definitions;
using dwd.core.settings.platform.definitions;
using dwd.core.settings.playerPrefs.definitions;
using dwd.core.settings.scriptableConfig;
using dwd.core.video.settings;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using localization;

namespace zen.src.preferences
{
	// Token: 0x02000050 RID: 80
	public static class Prefs : Object
	{
		// Token: 0x0600031E RID: 798 RVA: 0x0001B2D0 File Offset: 0x000194D0
		// Note: this type is marked as 'beforefieldinit'.
		static Prefs()
		{
			Il2CppClassPointerStore<Prefs>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.preferences", "Prefs");
			Prefs.NativeFieldInfoPtr_defaultConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "defaultConfig");
			Prefs.NativeFieldInfoPtr_NetworkLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "NetworkLogging");
			Prefs.NativeFieldInfoPtr_PlatformAuthURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "PlatformAuthURL");
			Prefs.NativeFieldInfoPtr_PlatformScoreboardURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "PlatformScoreboardURL");
			Prefs.NativeFieldInfoPtr_SocialService = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SocialService");
			Prefs.NativeFieldInfoPtr_NotificationURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "NotificationURL");
			Prefs.NativeFieldInfoPtr_BundleMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "BundleMessages");
			Prefs.NativeFieldInfoPtr_GameURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "GameURL");
			Prefs.NativeFieldInfoPtr_ChallengeURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ChallengeURL");
			Prefs.NativeFieldInfoPtr_LobbyURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "LobbyURL");
			Prefs.NativeFieldInfoPtr_DailyChallengeURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "DailyChallengeURL");
			Prefs.NativeFieldInfoPtr_DisableUnitySocial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "DisableUnitySocial");
			Prefs.NativeFieldInfoPtr_AccountURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AccountURL");
			Prefs.NativeFieldInfoPtr_GameCoreScid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "GameCoreScid");
			Prefs.NativeFieldInfoPtr_NotificationsSocketURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "NotificationsSocketURL");
			Prefs.NativeFieldInfoPtr_RankedURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RankedURL");
			Prefs.NativeFieldInfoPtr_RankedSocketURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RankedSocketURL");
			Prefs.NativeFieldInfoPtr_UseSteam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "UseSteam");
			Prefs.NativeFieldInfoPtr_SettingNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SettingNamespace");
			Prefs.NativeFieldInfoPtr_AllowDiagnostics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AllowDiagnostics");
			Prefs.NativeFieldInfoPtr_FeedbackNotificationAPIKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "FeedbackNotificationAPIKey");
			Prefs.NativeFieldInfoPtr_LocalServerLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "LocalServerLocation");
			Prefs.NativeFieldInfoPtr_UpdateCheckURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "UpdateCheckURL");
			Prefs.NativeFieldInfoPtr_CommerceURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "CommerceURL");
			Prefs.NativeFieldInfoPtr_BroadcastingAssetURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "BroadcastingAssetURL");
			Prefs.NativeFieldInfoPtr_BroadcastingLocalizationURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "BroadcastingLocalizationURL");
			Prefs.NativeFieldInfoPtr_BroadcastingVersionURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "BroadcastingVersionURL");
			Prefs.NativeFieldInfoPtr_AnalyticsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AnalyticsEnabled");
			Prefs.NativeFieldInfoPtr_AnalyticsURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AnalyticsURL");
			Prefs.NativeFieldInfoPtr_AnalyticsGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AnalyticsGame");
			Prefs.NativeFieldInfoPtr_UseOfflineAnalyticsMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "UseOfflineAnalyticsMessages");
			Prefs.NativeFieldInfoPtr_DireBytesURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "DireBytesURL");
			Prefs.NativeFieldInfoPtr_DireBytesImageURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "DireBytesImageURL");
			Prefs.NativeFieldInfoPtr_CodeRedemptionURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "CodeRedemptionURL");
			Prefs.NativeFieldInfoPtr_SwitchboardURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SwitchboardURL");
			Prefs.NativeFieldInfoPtr_GRMUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "GRMUrl");
			Prefs.NativeFieldInfoPtr_DailyChallengePlayPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "DailyChallengePlayPath");
			Prefs.NativeFieldInfoPtr_DailyChallengeGetInfoPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "DailyChallengeGetInfoPath");
			Prefs.NativeFieldInfoPtr_DailyChallengeLeaderboardPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "DailyChallengeLeaderboardPath");
			Prefs.NativeFieldInfoPtr_DailyChallengeLeaderboardFriendsPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "DailyChallengeLeaderboardFriendsPath");
			Prefs.NativeFieldInfoPtr_MatchHistoryEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "MatchHistoryEnabled");
			Prefs.NativeFieldInfoPtr_MatchHistoryURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "MatchHistoryURL");
			Prefs.NativeFieldInfoPtr_UseOfflineMatchHistoryMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "UseOfflineMatchHistoryMessages");
			Prefs.NativeFieldInfoPtr_DisableBugManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "DisableBugManager");
			Prefs.NativeFieldInfoPtr_EnableMultiTouch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "EnableMultiTouch");
			Prefs.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SteamID");
			Prefs.NativeFieldInfoPtr_AndroidID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AndroidID");
			Prefs.NativeFieldInfoPtr_NintendoID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "NintendoID");
			Prefs.NativeFieldInfoPtr_OverrideSteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "OverrideSteamID");
			Prefs.NativeFieldInfoPtr_Environment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "Environment");
			Prefs.NativeFieldInfoPtr_GameLobbyChatURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "GameLobbyChatURL");
			Prefs.NativeFieldInfoPtr_AutoReconnectToLiveGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AutoReconnectToLiveGame");
			Prefs.NativeFieldInfoPtr_KabbagePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "KabbagePath");
			Prefs.NativeFieldInfoPtr_UseGameResultsV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "UseGameResultsV2");
			Prefs.NativeFieldInfoPtr_FetchReputationURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "FetchReputationURL");
			Prefs.NativeFieldInfoPtr_PromptForAndroidPermissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "PromptForAndroidPermissions");
			Prefs.NativeFieldInfoPtr_PromptForAndroidPushNotificaitons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "PromptForAndroidPushNotificaitons");
			Prefs.NativeFieldInfoPtr_RememberAutoLogin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberAutoLogin");
			Prefs.NativeFieldInfoPtr_RememberedUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberedUser");
			Prefs.NativeFieldInfoPtr_RememberedScreenname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberedScreenname");
			Prefs.NativeFieldInfoPtr_RememberedScreennameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberedScreennameID");
			Prefs.NativeFieldInfoPtr_LastAccountIDForPrefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "LastAccountIDForPrefs");
			Prefs.NativeFieldInfoPtr_SeenAccountIDsForPrefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenAccountIDsForPrefs");
			Prefs.NativeFieldInfoPtr_RememberedPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberedPassword");
			Prefs.NativeFieldInfoPtr_SignificantEventCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SignificantEventCount");
			Prefs.NativeFieldInfoPtr_RememberedPassAndPlayUser1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberedPassAndPlayUser1");
			Prefs.NativeFieldInfoPtr_RememberedPassAndPlayUser2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberedPassAndPlayUser2");
			Prefs.NativeFieldInfoPtr_RememberedPassAndPlayUser3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberedPassAndPlayUser3");
			Prefs.NativeFieldInfoPtr_RememberedPassAndPlayUser4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberedPassAndPlayUser4");
			Prefs.NativeFieldInfoPtr_RememberedPassAndPlaySelected1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberedPassAndPlaySelected1");
			Prefs.NativeFieldInfoPtr_RememberedPassAndPlaySelected2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberedPassAndPlaySelected2");
			Prefs.NativeFieldInfoPtr_RememberedPassAndPlaySelected3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberedPassAndPlaySelected3");
			Prefs.NativeFieldInfoPtr_RememberedPassAndPlaySelected4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RememberedPassAndPlaySelected4");
			Prefs.NativeFieldInfoPtr_LastLoginHadGamesToContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "LastLoginHadGamesToContinue");
			Prefs.NativeFieldInfoPtr_AcceptedEULA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AcceptedEULA");
			Prefs.NativeFieldInfoPtr_RejectedEULA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RejectedEULA");
			Prefs.NativeFieldInfoPtr_SavedLocale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SavedLocale");
			Prefs.NativeFieldInfoPtr_MusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "MusicVolume");
			Prefs.NativeFieldInfoPtr_MusicMuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "MusicMuted");
			Prefs.NativeFieldInfoPtr_SFXVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SFXVolume");
			Prefs.NativeFieldInfoPtr_SFXMuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SFXMuted");
			Prefs.NativeFieldInfoPtr_AmbienceVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AmbienceVolume");
			Prefs.NativeFieldInfoPtr_AmbienceMuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AmbienceMuted");
			Prefs.NativeFieldInfoPtr_VolumeMuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "VolumeMuted");
			Prefs.NativeFieldInfoPtr_MasterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "MasterVolume");
			Prefs.NativeFieldInfoPtr_VSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "VSync");
			Prefs.NativeFieldInfoPtr_PlatformOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "PlatformOverride");
			Prefs.NativeFieldInfoPtr_Screen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "Screen");
			Prefs.NativeFieldInfoPtr_DisableGameplayWarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "DisableGameplayWarnings");
			Prefs.NativeFieldInfoPtr_ReduceTooltips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ReduceTooltips");
			Prefs.NativeFieldInfoPtr_ShowTutorialClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ShowTutorialClient");
			Prefs.NativeFieldInfoPtr_ShowPrompts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ShowPrompts");
			Prefs.NativeFieldInfoPtr_SelectedTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SelectedTray");
			Prefs.NativeFieldInfoPtr_SoloAILevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SoloAILevel");
			Prefs.NativeFieldInfoPtr_ProcessedGameResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ProcessedGameResults");
			Prefs.NativeFieldInfoPtr_SeenTutorialPracticeGamePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenTutorialPracticeGamePrompt");
			Prefs.NativeFieldInfoPtr_SeenPostTutorialChallengePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenPostTutorialChallengePrompt");
			Prefs.NativeFieldInfoPtr_SeenTutorialCompletePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenTutorialCompletePrompt");
			Prefs.NativeFieldInfoPtr_SeenAdvancedTutorialWarningPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenAdvancedTutorialWarningPrompt");
			Prefs.NativeFieldInfoPtr_PreviouslyPlayedChallengeScenario = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "PreviouslyPlayedChallengeScenario");
			Prefs.NativeFieldInfoPtr_TutorialsStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "TutorialsStarted");
			Prefs.NativeFieldInfoPtr_DismissedMOTD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "DismissedMOTD");
			Prefs.NativeFieldInfoPtr_SeenCatalogTitles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenCatalogTitles");
			Prefs.NativeFieldInfoPtr_CachedMOTDVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "CachedMOTDVersion");
			Prefs.NativeFieldInfoPtr_ForceUpdatePromptVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ForceUpdatePromptVersion");
			Prefs.NativeFieldInfoPtr_LastVersusRanked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "LastVersusRanked");
			Prefs.NativeFieldInfoPtr_DemoBuild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "DemoBuild");
			Prefs.NativeFieldInfoPtr_ForceAnalyticsOffline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ForceAnalyticsOffline");
			Prefs.NativeFieldInfoPtr_NumPnPPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "NumPnPPlayers");
			Prefs.NativeFieldInfoPtr_RecentLobbyChatTimestamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RecentLobbyChatTimestamp");
			Prefs.NativeFieldInfoPtr_RecentGameChatTimestamps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "RecentGameChatTimestamps");
			Prefs.NativeFieldInfoPtr_BlockedAccountIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "BlockedAccountIDs");
			Prefs.NativeFieldInfoPtr_QualityPreference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "QualityPreference");
			Prefs.NativeFieldInfoPtr_UIScalingPref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "UIScalingPref");
			Prefs.NativeFieldInfoPtr_AnimationSpeedPref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AnimationSpeedPref");
			Prefs.NativeFieldInfoPtr_AndroidFirstBoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AndroidFirstBoot");
			Prefs.NativeFieldInfoPtr_CurrentDownloadedDireByteImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "CurrentDownloadedDireByteImages");
			Prefs.NativeFieldInfoPtr_UseQADirebytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "UseQADirebytes");
			Prefs.NativeFieldInfoPtr_SeenDirebyteAlerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenDirebyteAlerts");
			Prefs.NativeFieldInfoPtr_SeenDirebytesTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenDirebytesTiles");
			Prefs.NativeFieldInfoPtr_SeenTutorialEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenTutorialEvents");
			Prefs.NativeFieldInfoPtr_ShowOnlinePasswordGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ShowOnlinePasswordGames");
			Prefs.NativeFieldInfoPtr_GRMButtonVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "GRMButtonVisible");
			Prefs.NativeFieldInfoPtr_SeenTutorialVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenTutorialVersion");
			Prefs.NativeFieldInfoPtr_SeenStoreVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenStoreVersion");
			Prefs.NativeFieldInfoPtr_SeenChallengeVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenChallengeVersion");
			Prefs.NativeFieldInfoPtr_SeenMenuTutorialScreens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenMenuTutorialScreens");
			Prefs.NativeFieldInfoPtr_SeenChallenges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenChallenges");
			Prefs.NativeFieldInfoPtr_SeenDailyChallenge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenDailyChallenge");
			Prefs.NativeFieldInfoPtr_SeenDailyChallengeRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenDailyChallengeRules");
			Prefs.NativeFieldInfoPtr_SeenDailyChallengeVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenDailyChallengeVersion");
			Prefs.NativeFieldInfoPtr_SeenCrossPromoMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "SeenCrossPromoMessages");
			Prefs.NativeFieldInfoPtr_ReviewedCrossPromoMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ReviewedCrossPromoMessages");
			Prefs.NativeFieldInfoPtr_AcknowledgedCrossPromoMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AcknowledgedCrossPromoMessages");
			Prefs.NativeFieldInfoPtr_ControllerSupportEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ControllerSupportEnabled");
			Prefs.NativeFieldInfoPtr_ControllerSupportPrompted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ControllerSupportPrompted");
			Prefs.NativeFieldInfoPtr_OfflinePlayerColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "OfflinePlayerColor");
			Prefs.NativeFieldInfoPtr_OfflinePlayerAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "OfflinePlayerAvatar");
			Prefs.NativeFieldInfoPtr_OnlinePlayerColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "OnlinePlayerColor");
			Prefs.NativeFieldInfoPtr_OnlinePlayerAvatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "OnlinePlayerAvatar");
			Prefs.NativeFieldInfoPtr_ReputationSwitchboardEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ReputationSwitchboardEnabled");
			Prefs.NativeFieldInfoPtr_AllowObservers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "AllowObservers");
			Prefs.NativeFieldInfoPtr_ObserverSwitchboardEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "ObserverSwitchboardEnabled");
			Prefs.NativeFieldInfoPtr_UseStubIAPStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Prefs>.NativeClassPtr, "UseStubIAPStore");
			Prefs.NativeMethodInfoPtr_InitializeConfig_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefs>.NativeClassPtr, 100663838);
			Prefs.NativeMethodInfoPtr_StringConfig_Private_Static_StringConfigDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefs>.NativeClassPtr, 100663839);
			Prefs.NativeMethodInfoPtr_IntConfig_Private_Static_IntConfigDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefs>.NativeClassPtr, 100663840);
			Prefs.NativeMethodInfoPtr_BoolConfig_Private_Static_BoolConfigDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefs>.NativeClassPtr, 100663841);
			Prefs.NativeMethodInfoPtr_GetLastAccountInt_Public_Static_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefs>.NativeClassPtr, 100663843);
			Prefs.NativeMethodInfoPtr_SetLastAccountInt_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Prefs>.NativeClassPtr, 100663844);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0001BEB0 File Offset: 0x0001A0B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 985784, RefRangeEnd = 985787, XrefRangeStart = 985770, XrefRangeEnd = 985784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeConfig()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Prefs.NativeMethodInfoPtr_InitializeConfig_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0001BED8 File Offset: 0x0001A0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985787, XrefRangeEnd = 985802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringConfigDefinition StringConfig(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Prefs.NativeMethodInfoPtr_StringConfig_Private_Static_StringConfigDefinition_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0001BF1C File Offset: 0x0001A11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985802, XrefRangeEnd = 985817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntConfigDefinition IntConfig(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Prefs.NativeMethodInfoPtr_IntConfig_Private_Static_IntConfigDefinition_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IntConfigDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0001BF60 File Offset: 0x0001A160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985817, XrefRangeEnd = 985832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BoolConfigDefinition BoolConfig(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Prefs.NativeMethodInfoPtr_BoolConfig_Private_Static_BoolConfigDefinition_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0001BFA4 File Offset: 0x0001A1A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 985849, RefRangeEnd = 985851, XrefRangeStart = 985832, XrefRangeEnd = 985849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLastAccountInt(string prefName, int defaultValue = 0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Prefs.NativeMethodInfoPtr_GetLastAccountInt_Public_Static_Int32_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985851, XrefRangeEnd = 985860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLastAccountInt(string prefName, int value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Prefs.NativeMethodInfoPtr_SetLastAccountInt_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00003522 File Offset: 0x00001722
		public Prefs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0001C038 File Offset: 0x0001A238
		// (set) Token: 0x06000327 RID: 807 RVA: 0x0000352B File Offset: 0x0000172B
		public unsafe static DefaultConfigValues defaultConfig
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_defaultConfig, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultConfigValues>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_defaultConfig, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0001C060 File Offset: 0x0001A260
		// (set) Token: 0x06000329 RID: 809 RVA: 0x0000353D File Offset: 0x0000173D
		public unsafe static BoolConfigDefinition NetworkLogging
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_NetworkLogging, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_NetworkLogging, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0001C088 File Offset: 0x0001A288
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0000354F File Offset: 0x0000174F
		public unsafe static StringConfigDefinition PlatformAuthURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_PlatformAuthURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_PlatformAuthURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0001C0B0 File Offset: 0x0001A2B0
		// (set) Token: 0x0600032D RID: 813 RVA: 0x00003561 File Offset: 0x00001761
		public unsafe static StringConfigDefinition PlatformScoreboardURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_PlatformScoreboardURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_PlatformScoreboardURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00003573 File Offset: 0x00001773
		public unsafe static StringConfigDefinition SocialService
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SocialService, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SocialService, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0001C100 File Offset: 0x0001A300
		// (set) Token: 0x06000331 RID: 817 RVA: 0x00003585 File Offset: 0x00001785
		public unsafe static StringConfigDefinition NotificationURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_NotificationURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_NotificationURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0001C128 File Offset: 0x0001A328
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00003597 File Offset: 0x00001797
		public unsafe static BoolConfigDefinition BundleMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_BundleMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_BundleMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0001C150 File Offset: 0x0001A350
		// (set) Token: 0x06000335 RID: 821 RVA: 0x000035A9 File Offset: 0x000017A9
		public unsafe static StringConfigDefinition GameURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_GameURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_GameURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0001C178 File Offset: 0x0001A378
		// (set) Token: 0x06000337 RID: 823 RVA: 0x000035BB File Offset: 0x000017BB
		public unsafe static StringConfigDefinition ChallengeURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ChallengeURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ChallengeURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0001C1A0 File Offset: 0x0001A3A0
		// (set) Token: 0x06000339 RID: 825 RVA: 0x000035CD File Offset: 0x000017CD
		public unsafe static StringConfigDefinition LobbyURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_LobbyURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_LobbyURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0001C1C8 File Offset: 0x0001A3C8
		// (set) Token: 0x0600033B RID: 827 RVA: 0x000035DF File Offset: 0x000017DF
		public unsafe static StringConfigDefinition DailyChallengeURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_DailyChallengeURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_DailyChallengeURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0001C1F0 File Offset: 0x0001A3F0
		// (set) Token: 0x0600033D RID: 829 RVA: 0x000035F1 File Offset: 0x000017F1
		public unsafe static BoolConfigDefinition DisableUnitySocial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_DisableUnitySocial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_DisableUnitySocial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0001C218 File Offset: 0x0001A418
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00003603 File Offset: 0x00001803
		public unsafe static StringConfigDefinition AccountURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AccountURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AccountURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0001C240 File Offset: 0x0001A440
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00003615 File Offset: 0x00001815
		public unsafe static StringConfigDefinition GameCoreScid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_GameCoreScid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_GameCoreScid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0001C268 File Offset: 0x0001A468
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00003627 File Offset: 0x00001827
		public unsafe static StringConfigDefinition NotificationsSocketURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_NotificationsSocketURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_NotificationsSocketURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0001C290 File Offset: 0x0001A490
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00003639 File Offset: 0x00001839
		public unsafe static StringConfigDefinition RankedURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RankedURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RankedURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0001C2B8 File Offset: 0x0001A4B8
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0000364B File Offset: 0x0000184B
		public unsafe static StringConfigDefinition RankedSocketURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RankedSocketURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RankedSocketURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0001C2E0 File Offset: 0x0001A4E0
		// (set) Token: 0x06000349 RID: 841 RVA: 0x0000365D File Offset: 0x0000185D
		public unsafe static ISettingDefinition<bool> UseSteam
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_UseSteam, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_UseSteam, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0001C308 File Offset: 0x0001A508
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0000366F File Offset: 0x0000186F
		public unsafe static StringConfigDefinition SettingNamespace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SettingNamespace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SettingNamespace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0001C330 File Offset: 0x0001A530
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00003681 File Offset: 0x00001881
		public unsafe static BoolConfigDefinition AllowDiagnostics
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AllowDiagnostics, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AllowDiagnostics, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600034E RID: 846 RVA: 0x0001C358 File Offset: 0x0001A558
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00003693 File Offset: 0x00001893
		public unsafe static StringConfigDefinition FeedbackNotificationAPIKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_FeedbackNotificationAPIKey, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_FeedbackNotificationAPIKey, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0001C380 File Offset: 0x0001A580
		// (set) Token: 0x06000351 RID: 849 RVA: 0x000036A5 File Offset: 0x000018A5
		public unsafe static StringConfigDefinition LocalServerLocation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_LocalServerLocation, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_LocalServerLocation, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0001C3A8 File Offset: 0x0001A5A8
		// (set) Token: 0x06000353 RID: 851 RVA: 0x000036B7 File Offset: 0x000018B7
		public unsafe static StringConfigDefinition UpdateCheckURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_UpdateCheckURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_UpdateCheckURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0001C3D0 File Offset: 0x0001A5D0
		// (set) Token: 0x06000355 RID: 853 RVA: 0x000036C9 File Offset: 0x000018C9
		public unsafe static StringConfigDefinition CommerceURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_CommerceURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_CommerceURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
		// (set) Token: 0x06000357 RID: 855 RVA: 0x000036DB File Offset: 0x000018DB
		public unsafe static StringConfigDefinition BroadcastingAssetURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_BroadcastingAssetURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_BroadcastingAssetURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0001C420 File Offset: 0x0001A620
		// (set) Token: 0x06000359 RID: 857 RVA: 0x000036ED File Offset: 0x000018ED
		public unsafe static StringConfigDefinition BroadcastingLocalizationURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_BroadcastingLocalizationURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_BroadcastingLocalizationURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0001C448 File Offset: 0x0001A648
		// (set) Token: 0x0600035B RID: 859 RVA: 0x000036FF File Offset: 0x000018FF
		public unsafe static StringConfigDefinition BroadcastingVersionURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_BroadcastingVersionURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_BroadcastingVersionURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0001C470 File Offset: 0x0001A670
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00003711 File Offset: 0x00001911
		public unsafe static BoolConfigDefinition AnalyticsEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AnalyticsEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AnalyticsEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0001C498 File Offset: 0x0001A698
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00003723 File Offset: 0x00001923
		public unsafe static StringConfigDefinition AnalyticsURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AnalyticsURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AnalyticsURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0001C4C0 File Offset: 0x0001A6C0
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00003735 File Offset: 0x00001935
		public unsafe static StringConfigDefinition AnalyticsGame
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AnalyticsGame, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AnalyticsGame, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00003747 File Offset: 0x00001947
		public unsafe static BoolConfigDefinition UseOfflineAnalyticsMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_UseOfflineAnalyticsMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_UseOfflineAnalyticsMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000364 RID: 868 RVA: 0x0001C510 File Offset: 0x0001A710
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00003759 File Offset: 0x00001959
		public unsafe static StringConfigDefinition DireBytesURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_DireBytesURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_DireBytesURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000366 RID: 870 RVA: 0x0001C538 File Offset: 0x0001A738
		// (set) Token: 0x06000367 RID: 871 RVA: 0x0000376B File Offset: 0x0000196B
		public unsafe static StringConfigDefinition DireBytesImageURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_DireBytesImageURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_DireBytesImageURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0001C560 File Offset: 0x0001A760
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0000377D File Offset: 0x0000197D
		public unsafe static StringConfigDefinition CodeRedemptionURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_CodeRedemptionURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_CodeRedemptionURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0001C588 File Offset: 0x0001A788
		// (set) Token: 0x0600036B RID: 875 RVA: 0x0000378F File Offset: 0x0000198F
		public unsafe static StringConfigDefinition SwitchboardURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SwitchboardURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SwitchboardURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600036C RID: 876 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
		// (set) Token: 0x0600036D RID: 877 RVA: 0x000037A1 File Offset: 0x000019A1
		public unsafe static StringConfigDefinition GRMUrl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_GRMUrl, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_GRMUrl, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0001C5D8 File Offset: 0x0001A7D8
		// (set) Token: 0x0600036F RID: 879 RVA: 0x000037B3 File Offset: 0x000019B3
		public unsafe static StringConfigDefinition DailyChallengePlayPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_DailyChallengePlayPath, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_DailyChallengePlayPath, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000370 RID: 880 RVA: 0x0001C600 File Offset: 0x0001A800
		// (set) Token: 0x06000371 RID: 881 RVA: 0x000037C5 File Offset: 0x000019C5
		public unsafe static StringConfigDefinition DailyChallengeGetInfoPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_DailyChallengeGetInfoPath, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_DailyChallengeGetInfoPath, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0001C628 File Offset: 0x0001A828
		// (set) Token: 0x06000373 RID: 883 RVA: 0x000037D7 File Offset: 0x000019D7
		public unsafe static StringConfigDefinition DailyChallengeLeaderboardPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_DailyChallengeLeaderboardPath, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_DailyChallengeLeaderboardPath, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0001C650 File Offset: 0x0001A850
		// (set) Token: 0x06000375 RID: 885 RVA: 0x000037E9 File Offset: 0x000019E9
		public unsafe static StringConfigDefinition DailyChallengeLeaderboardFriendsPath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_DailyChallengeLeaderboardFriendsPath, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_DailyChallengeLeaderboardFriendsPath, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0001C678 File Offset: 0x0001A878
		// (set) Token: 0x06000377 RID: 887 RVA: 0x000037FB File Offset: 0x000019FB
		public unsafe static BoolConfigDefinition MatchHistoryEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_MatchHistoryEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_MatchHistoryEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0001C6A0 File Offset: 0x0001A8A0
		// (set) Token: 0x06000379 RID: 889 RVA: 0x0000380D File Offset: 0x00001A0D
		public unsafe static StringConfigDefinition MatchHistoryURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_MatchHistoryURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_MatchHistoryURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0001C6C8 File Offset: 0x0001A8C8
		// (set) Token: 0x0600037B RID: 891 RVA: 0x0000381F File Offset: 0x00001A1F
		public unsafe static BoolConfigDefinition UseOfflineMatchHistoryMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_UseOfflineMatchHistoryMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_UseOfflineMatchHistoryMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0001C6F0 File Offset: 0x0001A8F0
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00003831 File Offset: 0x00001A31
		public unsafe static BoolConfigDefinition DisableBugManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_DisableBugManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_DisableBugManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0001C718 File Offset: 0x0001A918
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00003843 File Offset: 0x00001A43
		public unsafe static BoolConfigDefinition EnableMultiTouch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_EnableMultiTouch, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_EnableMultiTouch, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0001C740 File Offset: 0x0001A940
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00003855 File Offset: 0x00001A55
		public unsafe static PlatformIDScriptableConfigDefinition SteamID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SteamID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformIDScriptableConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SteamID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0001C768 File Offset: 0x0001A968
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00003867 File Offset: 0x00001A67
		public unsafe static PlatformIDScriptableConfigDefinition AndroidID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AndroidID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformIDScriptableConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AndroidID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0001C790 File Offset: 0x0001A990
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00003879 File Offset: 0x00001A79
		public unsafe static PlatformIDScriptableConfigDefinition NintendoID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_NintendoID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformIDScriptableConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_NintendoID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
		// (set) Token: 0x06000387 RID: 903 RVA: 0x0000388B File Offset: 0x00001A8B
		public unsafe static IntConfigDefinition OverrideSteamID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_OverrideSteamID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_OverrideSteamID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0001C7E0 File Offset: 0x0001A9E0
		// (set) Token: 0x06000389 RID: 905 RVA: 0x0000389D File Offset: 0x00001A9D
		public unsafe static StringConfigDefinition Environment
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_Environment, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_Environment, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0001C808 File Offset: 0x0001AA08
		// (set) Token: 0x0600038B RID: 907 RVA: 0x000038AF File Offset: 0x00001AAF
		public unsafe static StringConfigDefinition GameLobbyChatURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_GameLobbyChatURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_GameLobbyChatURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0001C830 File Offset: 0x0001AA30
		// (set) Token: 0x0600038D RID: 909 RVA: 0x000038C1 File Offset: 0x00001AC1
		public unsafe static BoolConfigDefinition AutoReconnectToLiveGame
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AutoReconnectToLiveGame, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AutoReconnectToLiveGame, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0001C858 File Offset: 0x0001AA58
		// (set) Token: 0x0600038F RID: 911 RVA: 0x000038D3 File Offset: 0x00001AD3
		public unsafe static StringConfigDefinition KabbagePath
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_KabbagePath, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_KabbagePath, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0001C880 File Offset: 0x0001AA80
		// (set) Token: 0x06000391 RID: 913 RVA: 0x000038E5 File Offset: 0x00001AE5
		public unsafe static BoolConfigDefinition UseGameResultsV2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_UseGameResultsV2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_UseGameResultsV2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
		// (set) Token: 0x06000393 RID: 915 RVA: 0x000038F7 File Offset: 0x00001AF7
		public unsafe static StringConfigDefinition FetchReputationURL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_FetchReputationURL, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringConfigDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_FetchReputationURL, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000394 RID: 916 RVA: 0x0001C8D0 File Offset: 0x0001AAD0
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00003909 File Offset: 0x00001B09
		public unsafe static BoolPrefDefinition PromptForAndroidPermissions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_PromptForAndroidPermissions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_PromptForAndroidPermissions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0001C8F8 File Offset: 0x0001AAF8
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0000391B File Offset: 0x00001B1B
		public unsafe static BoolPrefDefinition PromptForAndroidPushNotificaitons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_PromptForAndroidPushNotificaitons, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_PromptForAndroidPushNotificaitons, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0001C920 File Offset: 0x0001AB20
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000392D File Offset: 0x00001B2D
		public unsafe static BoolPrefDefinition RememberAutoLogin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberAutoLogin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberAutoLogin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0001C948 File Offset: 0x0001AB48
		// (set) Token: 0x0600039B RID: 923 RVA: 0x0000393F File Offset: 0x00001B3F
		public unsafe static StringPrefDefinition RememberedUser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberedUser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberedUser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0001C970 File Offset: 0x0001AB70
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00003951 File Offset: 0x00001B51
		public unsafe static StringPrefDefinition RememberedScreenname
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberedScreenname, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberedScreenname, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0001C998 File Offset: 0x0001AB98
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00003963 File Offset: 0x00001B63
		public unsafe static StringPrefDefinition RememberedScreennameID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberedScreennameID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberedScreennameID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0001C9C0 File Offset: 0x0001ABC0
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00003975 File Offset: 0x00001B75
		public unsafe static StringPrefDefinition LastAccountIDForPrefs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_LastAccountIDForPrefs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_LastAccountIDForPrefs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00003987 File Offset: 0x00001B87
		public unsafe static ListPrefDefinition<string> SeenAccountIDsForPrefs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenAccountIDsForPrefs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListPrefDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenAccountIDsForPrefs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0001CA10 File Offset: 0x0001AC10
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00003999 File Offset: 0x00001B99
		public unsafe static EncryptedStringPrefDefinition RememberedPassword
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberedPassword, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EncryptedStringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberedPassword, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0001CA38 File Offset: 0x0001AC38
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x000039AB File Offset: 0x00001BAB
		public unsafe static IntPrefDefinition SignificantEventCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SignificantEventCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SignificantEventCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0001CA60 File Offset: 0x0001AC60
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x000039BD File Offset: 0x00001BBD
		public unsafe static StringPrefDefinition RememberedPassAndPlayUser1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlayUser1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlayUser1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0001CA88 File Offset: 0x0001AC88
		// (set) Token: 0x060003AB RID: 939 RVA: 0x000039CF File Offset: 0x00001BCF
		public unsafe static StringPrefDefinition RememberedPassAndPlayUser2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlayUser2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlayUser2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0001CAB0 File Offset: 0x0001ACB0
		// (set) Token: 0x060003AD RID: 941 RVA: 0x000039E1 File Offset: 0x00001BE1
		public unsafe static StringPrefDefinition RememberedPassAndPlayUser3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlayUser3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlayUser3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0001CAD8 File Offset: 0x0001ACD8
		// (set) Token: 0x060003AF RID: 943 RVA: 0x000039F3 File Offset: 0x00001BF3
		public unsafe static StringPrefDefinition RememberedPassAndPlayUser4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlayUser4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlayUser4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x0001CB00 File Offset: 0x0001AD00
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00003A05 File Offset: 0x00001C05
		public unsafe static BoolPrefDefinition RememberedPassAndPlaySelected1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlaySelected1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlaySelected1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x0001CB28 File Offset: 0x0001AD28
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00003A17 File Offset: 0x00001C17
		public unsafe static BoolPrefDefinition RememberedPassAndPlaySelected2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlaySelected2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlaySelected2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x0001CB50 File Offset: 0x0001AD50
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00003A29 File Offset: 0x00001C29
		public unsafe static BoolPrefDefinition RememberedPassAndPlaySelected3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlaySelected3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlaySelected3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0001CB78 File Offset: 0x0001AD78
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00003A3B File Offset: 0x00001C3B
		public unsafe static BoolPrefDefinition RememberedPassAndPlaySelected4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlaySelected4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RememberedPassAndPlaySelected4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0001CBA0 File Offset: 0x0001ADA0
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00003A4D File Offset: 0x00001C4D
		public unsafe static BoolPrefDefinition LastLoginHadGamesToContinue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_LastLoginHadGamesToContinue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_LastLoginHadGamesToContinue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0001CBC8 File Offset: 0x0001ADC8
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00003A5F File Offset: 0x00001C5F
		public unsafe static PlatformSettingDefinition<bool> AcceptedEULA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AcceptedEULA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AcceptedEULA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003BC RID: 956 RVA: 0x0001CBF0 File Offset: 0x0001ADF0
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00003A71 File Offset: 0x00001C71
		public unsafe static PlatformSettingDefinition<bool> RejectedEULA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RejectedEULA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RejectedEULA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003BE RID: 958 RVA: 0x0001CC18 File Offset: 0x0001AE18
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00003A83 File Offset: 0x00001C83
		public unsafe static EnumPlatformSettingDefinition<TextLocalization.Locale> SavedLocale
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SavedLocale, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EnumPlatformSettingDefinition<TextLocalization.Locale>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SavedLocale, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0001CC40 File Offset: 0x0001AE40
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00003A95 File Offset: 0x00001C95
		public unsafe static PlatformSettingDefinition<float> MusicVolume
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_MusicVolume, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_MusicVolume, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x0001CC68 File Offset: 0x0001AE68
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00003AA7 File Offset: 0x00001CA7
		public unsafe static PlatformSettingDefinition<bool> MusicMuted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_MusicMuted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_MusicMuted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x0001CC90 File Offset: 0x0001AE90
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00003AB9 File Offset: 0x00001CB9
		public unsafe static PlatformSettingDefinition<float> SFXVolume
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SFXVolume, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SFXVolume, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0001CCB8 File Offset: 0x0001AEB8
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00003ACB File Offset: 0x00001CCB
		public unsafe static PlatformSettingDefinition<bool> SFXMuted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SFXMuted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SFXMuted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x0001CCE0 File Offset: 0x0001AEE0
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00003ADD File Offset: 0x00001CDD
		public unsafe static PlatformSettingDefinition<float> AmbienceVolume
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AmbienceVolume, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AmbienceVolume, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003CA RID: 970 RVA: 0x0001CD08 File Offset: 0x0001AF08
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00003AEF File Offset: 0x00001CEF
		public unsafe static PlatformSettingDefinition<bool> AmbienceMuted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AmbienceMuted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AmbienceMuted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0001CD30 File Offset: 0x0001AF30
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00003B01 File Offset: 0x00001D01
		public unsafe static PlatformSettingDefinition<bool> VolumeMuted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_VolumeMuted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_VolumeMuted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003CE RID: 974 RVA: 0x0001CD58 File Offset: 0x0001AF58
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00003B13 File Offset: 0x00001D13
		public unsafe static PlatformSettingDefinition<float> MasterVolume
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_MasterVolume, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_MasterVolume, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0001CD80 File Offset: 0x0001AF80
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00003B25 File Offset: 0x00001D25
		public unsafe static BoolPrefDefinition VSync
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_VSync, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_VSync, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0001CDA8 File Offset: 0x0001AFA8
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00003B37 File Offset: 0x00001D37
		public unsafe static IntPrefDefinition PlatformOverride
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_PlatformOverride, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_PlatformOverride, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0001CDD0 File Offset: 0x0001AFD0
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00003B49 File Offset: 0x00001D49
		public unsafe static ScreenPrefsDefinition Screen
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_Screen, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenPrefsDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_Screen, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003D6 RID: 982 RVA: 0x0001CDF8 File Offset: 0x0001AFF8
		// (set) Token: 0x060003D7 RID: 983 RVA: 0x00003B5B File Offset: 0x00001D5B
		public unsafe static PlatformSettingDefinition<bool> DisableGameplayWarnings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_DisableGameplayWarnings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_DisableGameplayWarnings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0001CE20 File Offset: 0x0001B020
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00003B6D File Offset: 0x00001D6D
		public unsafe static PlatformSettingDefinition<bool> ReduceTooltips
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ReduceTooltips, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ReduceTooltips, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0001CE48 File Offset: 0x0001B048
		// (set) Token: 0x060003DB RID: 987 RVA: 0x00003B7F File Offset: 0x00001D7F
		public unsafe static BoolPrefDefinition ShowTutorialClient
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ShowTutorialClient, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ShowTutorialClient, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0001CE70 File Offset: 0x0001B070
		// (set) Token: 0x060003DD RID: 989 RVA: 0x00003B91 File Offset: 0x00001D91
		public unsafe static BoolPrefDefinition ShowPrompts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ShowPrompts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ShowPrompts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0001CE98 File Offset: 0x0001B098
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00003BA3 File Offset: 0x00001DA3
		public unsafe static IntPrefDefinition SelectedTray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SelectedTray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SelectedTray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0001CEC0 File Offset: 0x0001B0C0
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00003BB5 File Offset: 0x00001DB5
		public unsafe static IntPrefDefinition SoloAILevel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SoloAILevel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SoloAILevel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0001CEE8 File Offset: 0x0001B0E8
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00003BC7 File Offset: 0x00001DC7
		public unsafe static StringPrefDefinition ProcessedGameResults
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ProcessedGameResults, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ProcessedGameResults, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x0001CF10 File Offset: 0x0001B110
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00003BD9 File Offset: 0x00001DD9
		public unsafe static PlatformSettingDefinition<bool> SeenTutorialPracticeGamePrompt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenTutorialPracticeGamePrompt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenTutorialPracticeGamePrompt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x0001CF38 File Offset: 0x0001B138
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00003BEB File Offset: 0x00001DEB
		public unsafe static PlatformSettingDefinition<bool> SeenPostTutorialChallengePrompt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenPostTutorialChallengePrompt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenPostTutorialChallengePrompt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0001CF60 File Offset: 0x0001B160
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00003BFD File Offset: 0x00001DFD
		public unsafe static PlatformSettingDefinition<bool> SeenTutorialCompletePrompt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenTutorialCompletePrompt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenTutorialCompletePrompt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x0001CF88 File Offset: 0x0001B188
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00003C0F File Offset: 0x00001E0F
		public unsafe static PlatformSettingDefinition<bool> SeenAdvancedTutorialWarningPrompt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenAdvancedTutorialWarningPrompt, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenAdvancedTutorialWarningPrompt, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00003C21 File Offset: 0x00001E21
		public unsafe static PlatformSettingDefinition<string> PreviouslyPlayedChallengeScenario
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_PreviouslyPlayedChallengeScenario, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_PreviouslyPlayedChallengeScenario, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x0001CFD8 File Offset: 0x0001B1D8
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00003C33 File Offset: 0x00001E33
		public unsafe static ListPlatformSettingDefinition<string> TutorialsStarted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_TutorialsStarted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ListPlatformSettingDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_TutorialsStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x0001D000 File Offset: 0x0001B200
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00003C45 File Offset: 0x00001E45
		public unsafe static StringPrefDefinition DismissedMOTD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_DismissedMOTD, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_DismissedMOTD, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x0001D028 File Offset: 0x0001B228
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00003C57 File Offset: 0x00001E57
		public unsafe static StringPrefDefinition SeenCatalogTitles
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenCatalogTitles, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenCatalogTitles, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x0001D050 File Offset: 0x0001B250
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00003C69 File Offset: 0x00001E69
		public unsafe static StringPrefDefinition CachedMOTDVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_CachedMOTDVersion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_CachedMOTDVersion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x0001D078 File Offset: 0x0001B278
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00003C7B File Offset: 0x00001E7B
		public unsafe static StringPrefDefinition ForceUpdatePromptVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ForceUpdatePromptVersion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ForceUpdatePromptVersion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0001D0A0 File Offset: 0x0001B2A0
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x00003C8D File Offset: 0x00001E8D
		public unsafe static BoolPrefDefinition LastVersusRanked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_LastVersusRanked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_LastVersusRanked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0001D0C8 File Offset: 0x0001B2C8
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x00003C9F File Offset: 0x00001E9F
		public unsafe static ISettingDefinition<bool> DemoBuild
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_DemoBuild, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_DemoBuild, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0001D0F0 File Offset: 0x0001B2F0
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x00003CB1 File Offset: 0x00001EB1
		public unsafe static BoolPrefDefinition ForceAnalyticsOffline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ForceAnalyticsOffline, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ForceAnalyticsOffline, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x0001D118 File Offset: 0x0001B318
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00003CC3 File Offset: 0x00001EC3
		public unsafe static IntPrefDefinition NumPnPPlayers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_NumPnPPlayers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_NumPnPPlayers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0001D140 File Offset: 0x0001B340
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00003CD5 File Offset: 0x00001ED5
		public unsafe static JsonPlatformSettingDefinition<long> RecentLobbyChatTimestamp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RecentLobbyChatTimestamp, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonPlatformSettingDefinition<long>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RecentLobbyChatTimestamp, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0001D168 File Offset: 0x0001B368
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00003CE7 File Offset: 0x00001EE7
		public unsafe static JsonPlatformSettingDefinition<Dictionary<GameID, long>> RecentGameChatTimestamps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_RecentGameChatTimestamps, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JsonPlatformSettingDefinition<Dictionary<GameID, long>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_RecentGameChatTimestamps, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0001D190 File Offset: 0x0001B390
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00003CF9 File Offset: 0x00001EF9
		public unsafe static AccountsPrefDefinition BlockedAccountIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_BlockedAccountIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountsPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_BlockedAccountIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0001D1B8 File Offset: 0x0001B3B8
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x00003D0B File Offset: 0x00001F0B
		public unsafe static IntPrefDefinition QualityPreference
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_QualityPreference, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IntPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_QualityPreference, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0001D1E0 File Offset: 0x0001B3E0
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x00003D1D File Offset: 0x00001F1D
		public unsafe static FloatPrefDefinition UIScalingPref
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_UIScalingPref, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FloatPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_UIScalingPref, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x0001D208 File Offset: 0x0001B408
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x00003D2F File Offset: 0x00001F2F
		public unsafe static PlatformSettingDefinition<float> AnimationSpeedPref
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AnimationSpeedPref, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AnimationSpeedPref, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0001D230 File Offset: 0x0001B430
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00003D41 File Offset: 0x00001F41
		public unsafe static BoolPrefDefinition AndroidFirstBoot
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AndroidFirstBoot, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AndroidFirstBoot, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x0001D258 File Offset: 0x0001B458
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x00003D53 File Offset: 0x00001F53
		public unsafe static StringPrefDefinition CurrentDownloadedDireByteImages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_CurrentDownloadedDireByteImages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_CurrentDownloadedDireByteImages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x0001D280 File Offset: 0x0001B480
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x00003D65 File Offset: 0x00001F65
		public unsafe static BoolPrefDefinition UseQADirebytes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_UseQADirebytes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_UseQADirebytes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0001D2A8 File Offset: 0x0001B4A8
		// (set) Token: 0x06000413 RID: 1043 RVA: 0x00003D77 File Offset: 0x00001F77
		public unsafe static StringPrefDefinition SeenDirebyteAlerts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenDirebyteAlerts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenDirebyteAlerts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0001D2D0 File Offset: 0x0001B4D0
		// (set) Token: 0x06000415 RID: 1045 RVA: 0x00003D89 File Offset: 0x00001F89
		public unsafe static StringPrefDefinition SeenDirebytesTiles
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenDirebytesTiles, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenDirebytesTiles, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x0001D2F8 File Offset: 0x0001B4F8
		// (set) Token: 0x06000417 RID: 1047 RVA: 0x00003D9B File Offset: 0x00001F9B
		public unsafe static PlatformSettingDefinition<string> SeenTutorialEvents
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenTutorialEvents, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenTutorialEvents, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0001D320 File Offset: 0x0001B520
		// (set) Token: 0x06000419 RID: 1049 RVA: 0x00003DAD File Offset: 0x00001FAD
		public unsafe static PlatformSettingDefinition<bool> ShowOnlinePasswordGames
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ShowOnlinePasswordGames, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ShowOnlinePasswordGames, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0001D348 File Offset: 0x0001B548
		// (set) Token: 0x0600041B RID: 1051 RVA: 0x00003DBF File Offset: 0x00001FBF
		public unsafe static BoolPrefDefinition GRMButtonVisible
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_GRMButtonVisible, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_GRMButtonVisible, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600041C RID: 1052 RVA: 0x0001D370 File Offset: 0x0001B570
		// (set) Token: 0x0600041D RID: 1053 RVA: 0x00003DD1 File Offset: 0x00001FD1
		public unsafe static PlatformSettingDefinition<int> SeenTutorialVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenTutorialVersion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenTutorialVersion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x0001D398 File Offset: 0x0001B598
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00003DE3 File Offset: 0x00001FE3
		public unsafe static PlatformSettingDefinition<int> SeenStoreVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenStoreVersion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenStoreVersion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0001D3C0 File Offset: 0x0001B5C0
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00003DF5 File Offset: 0x00001FF5
		public unsafe static PlatformSettingDefinition<int> SeenChallengeVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenChallengeVersion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenChallengeVersion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00003E07 File Offset: 0x00002007
		public unsafe static PlatformSettingDefinition<string> SeenMenuTutorialScreens
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenMenuTutorialScreens, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenMenuTutorialScreens, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x0001D410 File Offset: 0x0001B610
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00003E19 File Offset: 0x00002019
		public unsafe static PlatformSettingDefinition<string> SeenChallenges
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenChallenges, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenChallenges, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x0001D438 File Offset: 0x0001B638
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00003E2B File Offset: 0x0000202B
		public unsafe static PlatformSettingDefinition<bool> SeenDailyChallenge
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenDailyChallenge, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenDailyChallenge, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x0001D460 File Offset: 0x0001B660
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00003E3D File Offset: 0x0000203D
		public unsafe static PlatformSettingDefinition<bool> SeenDailyChallengeRules
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenDailyChallengeRules, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenDailyChallengeRules, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0001D488 File Offset: 0x0001B688
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00003E4F File Offset: 0x0000204F
		public unsafe static PlatformSettingDefinition<int> SeenDailyChallengeVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenDailyChallengeVersion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenDailyChallengeVersion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0001D4B0 File Offset: 0x0001B6B0
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x00003E61 File Offset: 0x00002061
		public unsafe static PlatformSettingDefinition<string> SeenCrossPromoMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_SeenCrossPromoMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_SeenCrossPromoMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0001D4D8 File Offset: 0x0001B6D8
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x00003E73 File Offset: 0x00002073
		public unsafe static PlatformSettingDefinition<string> ReviewedCrossPromoMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ReviewedCrossPromoMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ReviewedCrossPromoMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0001D500 File Offset: 0x0001B700
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x00003E85 File Offset: 0x00002085
		public unsafe static PlatformSettingDefinition<string> AcknowledgedCrossPromoMessages
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AcknowledgedCrossPromoMessages, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AcknowledgedCrossPromoMessages, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0001D528 File Offset: 0x0001B728
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x00003E97 File Offset: 0x00002097
		public unsafe static BoolPrefDefinition ControllerSupportEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ControllerSupportEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ControllerSupportEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0001D550 File Offset: 0x0001B750
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00003EA9 File Offset: 0x000020A9
		public unsafe static BoolPrefDefinition ControllerSupportPrompted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ControllerSupportPrompted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ControllerSupportPrompted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x0001D578 File Offset: 0x0001B778
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00003EBB File Offset: 0x000020BB
		public unsafe static PlatformSettingDefinition<string> OfflinePlayerColor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_OfflinePlayerColor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_OfflinePlayerColor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0001D5A0 File Offset: 0x0001B7A0
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00003ECD File Offset: 0x000020CD
		public unsafe static PlatformSettingDefinition<string> OfflinePlayerAvatar
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_OfflinePlayerAvatar, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_OfflinePlayerAvatar, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x0001D5C8 File Offset: 0x0001B7C8
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00003EDF File Offset: 0x000020DF
		public unsafe static PlatformSettingDefinition<string> OnlinePlayerColor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_OnlinePlayerColor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_OnlinePlayerColor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600043C RID: 1084 RVA: 0x0001D5F0 File Offset: 0x0001B7F0
		// (set) Token: 0x0600043D RID: 1085 RVA: 0x00003EF1 File Offset: 0x000020F1
		public unsafe static PlatformSettingDefinition<string> OnlinePlayerAvatar
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_OnlinePlayerAvatar, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_OnlinePlayerAvatar, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0001D618 File Offset: 0x0001B818
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x00003F03 File Offset: 0x00002103
		public unsafe static BoolPrefDefinition ReputationSwitchboardEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ReputationSwitchboardEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ReputationSwitchboardEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0001D640 File Offset: 0x0001B840
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x00003F15 File Offset: 0x00002115
		public unsafe static PlatformSettingDefinition<bool> AllowObservers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_AllowObservers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformSettingDefinition<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_AllowObservers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0001D668 File Offset: 0x0001B868
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x00003F27 File Offset: 0x00002127
		public unsafe static BoolPrefDefinition ObserverSwitchboardEnabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_ObserverSwitchboardEnabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_ObserverSwitchboardEnabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0001D690 File Offset: 0x0001B890
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x00003F39 File Offset: 0x00002139
		public unsafe static BoolPrefDefinition UseStubIAPStore
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Prefs.NativeFieldInfoPtr_UseStubIAPStore, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolPrefDefinition>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Prefs.NativeFieldInfoPtr_UseStubIAPStore, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeFieldInfoPtr_defaultConfig;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeFieldInfoPtr_NetworkLogging;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeFieldInfoPtr_PlatformAuthURL;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeFieldInfoPtr_PlatformScoreboardURL;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeFieldInfoPtr_SocialService;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_NotificationURL;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeFieldInfoPtr_BundleMessages;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeFieldInfoPtr_GameURL;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeFieldInfoPtr_ChallengeURL;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeFieldInfoPtr_LobbyURL;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeFieldInfoPtr_DailyChallengeURL;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeFieldInfoPtr_DisableUnitySocial;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeFieldInfoPtr_AccountURL;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeFieldInfoPtr_GameCoreScid;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeFieldInfoPtr_NotificationsSocketURL;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeFieldInfoPtr_RankedURL;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeFieldInfoPtr_RankedSocketURL;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeFieldInfoPtr_UseSteam;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeFieldInfoPtr_SettingNamespace;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeFieldInfoPtr_AllowDiagnostics;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeFieldInfoPtr_FeedbackNotificationAPIKey;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeFieldInfoPtr_LocalServerLocation;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeFieldInfoPtr_UpdateCheckURL;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeFieldInfoPtr_CommerceURL;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeFieldInfoPtr_BroadcastingAssetURL;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeFieldInfoPtr_BroadcastingLocalizationURL;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeFieldInfoPtr_BroadcastingVersionURL;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeFieldInfoPtr_AnalyticsEnabled;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeFieldInfoPtr_AnalyticsURL;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeFieldInfoPtr_AnalyticsGame;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeFieldInfoPtr_UseOfflineAnalyticsMessages;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeFieldInfoPtr_DireBytesURL;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeFieldInfoPtr_DireBytesImageURL;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeFieldInfoPtr_CodeRedemptionURL;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeFieldInfoPtr_SwitchboardURL;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeFieldInfoPtr_GRMUrl;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeFieldInfoPtr_DailyChallengePlayPath;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeFieldInfoPtr_DailyChallengeGetInfoPath;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr_DailyChallengeLeaderboardPath;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_DailyChallengeLeaderboardFriendsPath;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_MatchHistoryEnabled;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr_MatchHistoryURL;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr_UseOfflineMatchHistoryMessages;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr_DisableBugManager;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeFieldInfoPtr_EnableMultiTouch;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeFieldInfoPtr_AndroidID;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeFieldInfoPtr_NintendoID;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeFieldInfoPtr_OverrideSteamID;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeFieldInfoPtr_Environment;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeFieldInfoPtr_GameLobbyChatURL;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeFieldInfoPtr_AutoReconnectToLiveGame;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeFieldInfoPtr_KabbagePath;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeFieldInfoPtr_UseGameResultsV2;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr_FetchReputationURL;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_PromptForAndroidPermissions;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeFieldInfoPtr_PromptForAndroidPushNotificaitons;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeFieldInfoPtr_RememberAutoLogin;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeFieldInfoPtr_RememberedUser;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeFieldInfoPtr_RememberedScreenname;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeFieldInfoPtr_RememberedScreennameID;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeFieldInfoPtr_LastAccountIDForPrefs;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr_SeenAccountIDsForPrefs;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr_RememberedPassword;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr_SignificantEventCount;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeFieldInfoPtr_RememberedPassAndPlayUser1;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeFieldInfoPtr_RememberedPassAndPlayUser2;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeFieldInfoPtr_RememberedPassAndPlayUser3;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeFieldInfoPtr_RememberedPassAndPlayUser4;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeFieldInfoPtr_RememberedPassAndPlaySelected1;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeFieldInfoPtr_RememberedPassAndPlaySelected2;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeFieldInfoPtr_RememberedPassAndPlaySelected3;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeFieldInfoPtr_RememberedPassAndPlaySelected4;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeFieldInfoPtr_LastLoginHadGamesToContinue;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_AcceptedEULA;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_RejectedEULA;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeFieldInfoPtr_SavedLocale;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeFieldInfoPtr_MusicVolume;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeFieldInfoPtr_MusicMuted;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeFieldInfoPtr_SFXVolume;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeFieldInfoPtr_SFXMuted;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeFieldInfoPtr_AmbienceVolume;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeFieldInfoPtr_AmbienceMuted;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMuted;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_MasterVolume;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_VSync;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_PlatformOverride;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_Screen;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_DisableGameplayWarnings;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeFieldInfoPtr_ReduceTooltips;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeFieldInfoPtr_ShowTutorialClient;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeFieldInfoPtr_ShowPrompts;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeFieldInfoPtr_SelectedTray;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr_SoloAILevel;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr_ProcessedGameResults;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr_SeenTutorialPracticeGamePrompt;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_SeenPostTutorialChallengePrompt;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeFieldInfoPtr_SeenTutorialCompletePrompt;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeFieldInfoPtr_SeenAdvancedTutorialWarningPrompt;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr_PreviouslyPlayedChallengeScenario;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_TutorialsStarted;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_DismissedMOTD;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_SeenCatalogTitles;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_CachedMOTDVersion;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_ForceUpdatePromptVersion;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_LastVersusRanked;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_DemoBuild;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_ForceAnalyticsOffline;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeFieldInfoPtr_NumPnPPlayers;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeFieldInfoPtr_RecentLobbyChatTimestamp;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeFieldInfoPtr_RecentGameChatTimestamps;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_BlockedAccountIDs;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_QualityPreference;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_UIScalingPref;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_AnimationSpeedPref;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_AndroidFirstBoot;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_CurrentDownloadedDireByteImages;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_UseQADirebytes;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr_SeenDirebyteAlerts;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_SeenDirebytesTiles;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_SeenTutorialEvents;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_ShowOnlinePasswordGames;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr_GRMButtonVisible;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeFieldInfoPtr_SeenTutorialVersion;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeFieldInfoPtr_SeenStoreVersion;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeFieldInfoPtr_SeenChallengeVersion;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeFieldInfoPtr_SeenMenuTutorialScreens;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeFieldInfoPtr_SeenChallenges;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeFieldInfoPtr_SeenDailyChallenge;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeFieldInfoPtr_SeenDailyChallengeRules;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeFieldInfoPtr_SeenDailyChallengeVersion;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeFieldInfoPtr_SeenCrossPromoMessages;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeFieldInfoPtr_ReviewedCrossPromoMessages;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeFieldInfoPtr_AcknowledgedCrossPromoMessages;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr_ControllerSupportEnabled;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeFieldInfoPtr_ControllerSupportPrompted;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeFieldInfoPtr_OfflinePlayerColor;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeFieldInfoPtr_OfflinePlayerAvatar;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeFieldInfoPtr_OnlinePlayerColor;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeFieldInfoPtr_OnlinePlayerAvatar;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeFieldInfoPtr_ReputationSwitchboardEnabled;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeFieldInfoPtr_AllowObservers;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeFieldInfoPtr_ObserverSwitchboardEnabled;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeFieldInfoPtr_UseStubIAPStore;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_InitializeConfig_Private_Static_Void_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_StringConfig_Private_Static_StringConfigDefinition_String_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_IntConfig_Private_Static_IntConfigDefinition_String_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_BoolConfig_Private_Static_BoolConfigDefinition_String_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_GetLastAccountInt_Public_Static_Int32_String_Int32_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_SetLastAccountInt_Public_Static_Void_String_Int32_0;
	}
}
