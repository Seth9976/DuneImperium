using System;

namespace Steamworks
{
	// Token: 0x0200000B RID: 11
	public enum CallbackType
	{
		// Token: 0x04000036 RID: 54
		SteamServersConnected = 101,
		// Token: 0x04000037 RID: 55
		SteamServerConnectFailure,
		// Token: 0x04000038 RID: 56
		SteamServersDisconnected,
		// Token: 0x04000039 RID: 57
		ClientGameServerDeny = 113,
		// Token: 0x0400003A RID: 58
		GSPolicyResponse = 115,
		// Token: 0x0400003B RID: 59
		IPCFailure = 117,
		// Token: 0x0400003C RID: 60
		LicensesUpdated = 125,
		// Token: 0x0400003D RID: 61
		ValidateAuthTicketResponse = 143,
		// Token: 0x0400003E RID: 62
		MicroTxnAuthorizationResponse = 152,
		// Token: 0x0400003F RID: 63
		EncryptedAppTicketResponse = 154,
		// Token: 0x04000040 RID: 64
		GetAuthSessionTicketResponse = 163,
		// Token: 0x04000041 RID: 65
		GameWebCallback,
		// Token: 0x04000042 RID: 66
		StoreAuthURLResponse,
		// Token: 0x04000043 RID: 67
		MarketEligibilityResponse,
		// Token: 0x04000044 RID: 68
		DurationControl,
		// Token: 0x04000045 RID: 69
		GSClientApprove = 201,
		// Token: 0x04000046 RID: 70
		GSClientDeny,
		// Token: 0x04000047 RID: 71
		GSClientKick,
		// Token: 0x04000048 RID: 72
		GSClientAchievementStatus = 206,
		// Token: 0x04000049 RID: 73
		GSGameplayStats,
		// Token: 0x0400004A RID: 74
		GSClientGroupStatus,
		// Token: 0x0400004B RID: 75
		GSReputation,
		// Token: 0x0400004C RID: 76
		AssociateWithClanResult,
		// Token: 0x0400004D RID: 77
		ComputeNewPlayerCompatibilityResult,
		// Token: 0x0400004E RID: 78
		PersonaStateChange = 304,
		// Token: 0x0400004F RID: 79
		GameOverlayActivated = 331,
		// Token: 0x04000050 RID: 80
		GameServerChangeRequested,
		// Token: 0x04000051 RID: 81
		GameLobbyJoinRequested,
		// Token: 0x04000052 RID: 82
		AvatarImageLoaded,
		// Token: 0x04000053 RID: 83
		ClanOfficerListResponse,
		// Token: 0x04000054 RID: 84
		FriendRichPresenceUpdate,
		// Token: 0x04000055 RID: 85
		GameRichPresenceJoinRequested,
		// Token: 0x04000056 RID: 86
		GameConnectedClanChatMsg,
		// Token: 0x04000057 RID: 87
		GameConnectedChatJoin,
		// Token: 0x04000058 RID: 88
		GameConnectedChatLeave,
		// Token: 0x04000059 RID: 89
		DownloadClanActivityCountsResult,
		// Token: 0x0400005A RID: 90
		JoinClanChatRoomCompletionResult,
		// Token: 0x0400005B RID: 91
		GameConnectedFriendChatMsg,
		// Token: 0x0400005C RID: 92
		FriendsGetFollowerCount,
		// Token: 0x0400005D RID: 93
		FriendsIsFollowing,
		// Token: 0x0400005E RID: 94
		FriendsEnumerateFollowingList,
		// Token: 0x0400005F RID: 95
		SetPersonaNameResponse,
		// Token: 0x04000060 RID: 96
		UnreadChatMessagesChanged,
		// Token: 0x04000061 RID: 97
		OverlayBrowserProtocolNavigation,
		// Token: 0x04000062 RID: 98
		FavoritesListChanged = 502,
		// Token: 0x04000063 RID: 99
		LobbyInvite,
		// Token: 0x04000064 RID: 100
		LobbyEnter,
		// Token: 0x04000065 RID: 101
		LobbyDataUpdate,
		// Token: 0x04000066 RID: 102
		LobbyChatUpdate,
		// Token: 0x04000067 RID: 103
		LobbyChatMsg,
		// Token: 0x04000068 RID: 104
		LobbyGameCreated = 509,
		// Token: 0x04000069 RID: 105
		LobbyMatchList,
		// Token: 0x0400006A RID: 106
		LobbyKicked = 512,
		// Token: 0x0400006B RID: 107
		LobbyCreated,
		// Token: 0x0400006C RID: 108
		PSNGameBootInviteResult = 515,
		// Token: 0x0400006D RID: 109
		FavoritesListAccountsUpdated,
		// Token: 0x0400006E RID: 110
		IPCountry = 701,
		// Token: 0x0400006F RID: 111
		LowBatteryPower,
		// Token: 0x04000070 RID: 112
		SteamAPICallCompleted,
		// Token: 0x04000071 RID: 113
		SteamShutdown,
		// Token: 0x04000072 RID: 114
		CheckFileSignature,
		// Token: 0x04000073 RID: 115
		GamepadTextInputDismissed = 714,
		// Token: 0x04000074 RID: 116
		AppResumingFromSuspend = 736,
		// Token: 0x04000075 RID: 117
		FloatingGamepadTextInputDismissed = 738,
		// Token: 0x04000076 RID: 118
		DlcInstalled = 1005,
		// Token: 0x04000077 RID: 119
		RegisterActivationCodeResponse = 1008,
		// Token: 0x04000078 RID: 120
		NewUrlLaunchParameters = 1014,
		// Token: 0x04000079 RID: 121
		AppProofOfPurchaseKeyResponse = 1021,
		// Token: 0x0400007A RID: 122
		FileDetailsResult = 1023,
		// Token: 0x0400007B RID: 123
		TimedTrialStatus = 1030,
		// Token: 0x0400007C RID: 124
		UserStatsReceived = 1101,
		// Token: 0x0400007D RID: 125
		UserStatsStored,
		// Token: 0x0400007E RID: 126
		UserAchievementStored,
		// Token: 0x0400007F RID: 127
		LeaderboardFindResult,
		// Token: 0x04000080 RID: 128
		LeaderboardScoresDownloaded,
		// Token: 0x04000081 RID: 129
		LeaderboardScoreUploaded,
		// Token: 0x04000082 RID: 130
		NumberOfCurrentPlayers,
		// Token: 0x04000083 RID: 131
		UserStatsUnloaded,
		// Token: 0x04000084 RID: 132
		GSStatsUnloaded = 1108,
		// Token: 0x04000085 RID: 133
		UserAchievementIconFetched,
		// Token: 0x04000086 RID: 134
		GlobalAchievementPercentagesReady,
		// Token: 0x04000087 RID: 135
		LeaderboardUGCSet,
		// Token: 0x04000088 RID: 136
		GlobalStatsReceived,
		// Token: 0x04000089 RID: 137
		P2PSessionRequest = 1202,
		// Token: 0x0400008A RID: 138
		P2PSessionConnectFail,
		// Token: 0x0400008B RID: 139
		SteamNetConnectionStatusChangedCallback = 1221,
		// Token: 0x0400008C RID: 140
		SteamNetAuthenticationStatus,
		// Token: 0x0400008D RID: 141
		SteamNetworkingFakeIPResult,
		// Token: 0x0400008E RID: 142
		SteamNetworkingMessagesSessionRequest = 1251,
		// Token: 0x0400008F RID: 143
		SteamNetworkingMessagesSessionFailed,
		// Token: 0x04000090 RID: 144
		SteamRelayNetworkStatus = 1281,
		// Token: 0x04000091 RID: 145
		RemoteStorageFileShareResult = 1307,
		// Token: 0x04000092 RID: 146
		RemoteStoragePublishFileResult = 1309,
		// Token: 0x04000093 RID: 147
		RemoteStorageDeletePublishedFileResult = 1311,
		// Token: 0x04000094 RID: 148
		RemoteStorageEnumerateUserPublishedFilesResult,
		// Token: 0x04000095 RID: 149
		RemoteStorageSubscribePublishedFileResult,
		// Token: 0x04000096 RID: 150
		RemoteStorageEnumerateUserSubscribedFilesResult,
		// Token: 0x04000097 RID: 151
		RemoteStorageUnsubscribePublishedFileResult,
		// Token: 0x04000098 RID: 152
		RemoteStorageUpdatePublishedFileResult,
		// Token: 0x04000099 RID: 153
		RemoteStorageDownloadUGCResult,
		// Token: 0x0400009A RID: 154
		RemoteStorageGetPublishedFileDetailsResult,
		// Token: 0x0400009B RID: 155
		RemoteStorageEnumerateWorkshopFilesResult,
		// Token: 0x0400009C RID: 156
		RemoteStorageGetPublishedItemVoteDetailsResult,
		// Token: 0x0400009D RID: 157
		RemoteStoragePublishedFileSubscribed,
		// Token: 0x0400009E RID: 158
		RemoteStoragePublishedFileUnsubscribed,
		// Token: 0x0400009F RID: 159
		RemoteStoragePublishedFileDeleted,
		// Token: 0x040000A0 RID: 160
		RemoteStorageUpdateUserPublishedItemVoteResult,
		// Token: 0x040000A1 RID: 161
		RemoteStorageUserVoteDetails,
		// Token: 0x040000A2 RID: 162
		RemoteStorageEnumerateUserSharedWorkshopFilesResult,
		// Token: 0x040000A3 RID: 163
		RemoteStorageSetUserPublishedFileActionResult,
		// Token: 0x040000A4 RID: 164
		RemoteStorageEnumeratePublishedFilesByUserActionResult,
		// Token: 0x040000A5 RID: 165
		RemoteStoragePublishFileProgress,
		// Token: 0x040000A6 RID: 166
		RemoteStoragePublishedFileUpdated,
		// Token: 0x040000A7 RID: 167
		RemoteStorageFileWriteAsyncComplete,
		// Token: 0x040000A8 RID: 168
		RemoteStorageFileReadAsyncComplete,
		// Token: 0x040000A9 RID: 169
		RemoteStorageLocalFileChange,
		// Token: 0x040000AA RID: 170
		GSStatsReceived = 1800,
		// Token: 0x040000AB RID: 171
		GSStatsStored,
		// Token: 0x040000AC RID: 172
		HTTPRequestCompleted = 2101,
		// Token: 0x040000AD RID: 173
		HTTPRequestHeadersReceived,
		// Token: 0x040000AE RID: 174
		HTTPRequestDataReceived,
		// Token: 0x040000AF RID: 175
		ScreenshotReady = 2301,
		// Token: 0x040000B0 RID: 176
		ScreenshotRequested,
		// Token: 0x040000B1 RID: 177
		SteamInputDeviceConnected = 2801,
		// Token: 0x040000B2 RID: 178
		SteamInputDeviceDisconnected,
		// Token: 0x040000B3 RID: 179
		SteamInputConfigurationLoaded,
		// Token: 0x040000B4 RID: 180
		SteamUGCQueryCompleted = 3401,
		// Token: 0x040000B5 RID: 181
		SteamUGCRequestUGCDetailsResult,
		// Token: 0x040000B6 RID: 182
		CreateItemResult,
		// Token: 0x040000B7 RID: 183
		SubmitItemUpdateResult,
		// Token: 0x040000B8 RID: 184
		ItemInstalled,
		// Token: 0x040000B9 RID: 185
		DownloadItemResult,
		// Token: 0x040000BA RID: 186
		UserFavoriteItemsListChanged,
		// Token: 0x040000BB RID: 187
		SetUserItemVoteResult,
		// Token: 0x040000BC RID: 188
		GetUserItemVoteResult,
		// Token: 0x040000BD RID: 189
		StartPlaytimeTrackingResult,
		// Token: 0x040000BE RID: 190
		StopPlaytimeTrackingResult,
		// Token: 0x040000BF RID: 191
		AddUGCDependencyResult,
		// Token: 0x040000C0 RID: 192
		RemoveUGCDependencyResult,
		// Token: 0x040000C1 RID: 193
		AddAppDependencyResult,
		// Token: 0x040000C2 RID: 194
		RemoveAppDependencyResult,
		// Token: 0x040000C3 RID: 195
		GetAppDependenciesResult,
		// Token: 0x040000C4 RID: 196
		DeleteItemResult,
		// Token: 0x040000C5 RID: 197
		UserSubscribedItemsListChanged,
		// Token: 0x040000C6 RID: 198
		WorkshopEULAStatus = 3420,
		// Token: 0x040000C7 RID: 199
		SteamAppInstalled = 3901,
		// Token: 0x040000C8 RID: 200
		SteamAppUninstalled,
		// Token: 0x040000C9 RID: 201
		PlaybackStatusHasChanged = 4001,
		// Token: 0x040000CA RID: 202
		VolumeHasChanged,
		// Token: 0x040000CB RID: 203
		MusicPlayerWantsVolume = 4011,
		// Token: 0x040000CC RID: 204
		MusicPlayerSelectsQueueEntry,
		// Token: 0x040000CD RID: 205
		MusicPlayerSelectsPlaylistEntry,
		// Token: 0x040000CE RID: 206
		MusicPlayerRemoteWillActivate = 4101,
		// Token: 0x040000CF RID: 207
		MusicPlayerRemoteWillDeactivate,
		// Token: 0x040000D0 RID: 208
		MusicPlayerRemoteToFront,
		// Token: 0x040000D1 RID: 209
		MusicPlayerWillQuit,
		// Token: 0x040000D2 RID: 210
		MusicPlayerWantsPlay,
		// Token: 0x040000D3 RID: 211
		MusicPlayerWantsPause,
		// Token: 0x040000D4 RID: 212
		MusicPlayerWantsPlayPrevious,
		// Token: 0x040000D5 RID: 213
		MusicPlayerWantsPlayNext,
		// Token: 0x040000D6 RID: 214
		MusicPlayerWantsShuffled,
		// Token: 0x040000D7 RID: 215
		MusicPlayerWantsLooped,
		// Token: 0x040000D8 RID: 216
		MusicPlayerWantsPlayingRepeatStatus = 4114,
		// Token: 0x040000D9 RID: 217
		HTML_BrowserReady = 4501,
		// Token: 0x040000DA RID: 218
		HTML_NeedsPaint,
		// Token: 0x040000DB RID: 219
		HTML_StartRequest,
		// Token: 0x040000DC RID: 220
		HTML_CloseBrowser,
		// Token: 0x040000DD RID: 221
		HTML_URLChanged,
		// Token: 0x040000DE RID: 222
		HTML_FinishedRequest,
		// Token: 0x040000DF RID: 223
		HTML_OpenLinkInNewTab,
		// Token: 0x040000E0 RID: 224
		HTML_ChangedTitle,
		// Token: 0x040000E1 RID: 225
		HTML_SearchResults,
		// Token: 0x040000E2 RID: 226
		HTML_CanGoBackAndForward,
		// Token: 0x040000E3 RID: 227
		HTML_HorizontalScroll,
		// Token: 0x040000E4 RID: 228
		HTML_VerticalScroll,
		// Token: 0x040000E5 RID: 229
		HTML_LinkAtPosition,
		// Token: 0x040000E6 RID: 230
		HTML_JSAlert,
		// Token: 0x040000E7 RID: 231
		HTML_JSConfirm,
		// Token: 0x040000E8 RID: 232
		HTML_FileOpenDialog,
		// Token: 0x040000E9 RID: 233
		HTML_NewWindow = 4521,
		// Token: 0x040000EA RID: 234
		HTML_SetCursor,
		// Token: 0x040000EB RID: 235
		HTML_StatusText,
		// Token: 0x040000EC RID: 236
		HTML_ShowToolTip,
		// Token: 0x040000ED RID: 237
		HTML_UpdateToolTip,
		// Token: 0x040000EE RID: 238
		HTML_HideToolTip,
		// Token: 0x040000EF RID: 239
		HTML_BrowserRestarted,
		// Token: 0x040000F0 RID: 240
		GetVideoURLResult = 4611,
		// Token: 0x040000F1 RID: 241
		GetOPFSettingsResult = 4624,
		// Token: 0x040000F2 RID: 242
		SteamInventoryResultReady = 4700,
		// Token: 0x040000F3 RID: 243
		SteamInventoryFullUpdate,
		// Token: 0x040000F4 RID: 244
		SteamInventoryDefinitionUpdate,
		// Token: 0x040000F5 RID: 245
		SteamInventoryEligiblePromoItemDefIDs,
		// Token: 0x040000F6 RID: 246
		SteamInventoryStartPurchaseResult,
		// Token: 0x040000F7 RID: 247
		SteamInventoryRequestPricesResult,
		// Token: 0x040000F8 RID: 248
		SteamParentalSettingsChanged = 5001,
		// Token: 0x040000F9 RID: 249
		SearchForGameProgressCallback = 5201,
		// Token: 0x040000FA RID: 250
		SearchForGameResultCallback,
		// Token: 0x040000FB RID: 251
		RequestPlayersForGameProgressCallback = 5211,
		// Token: 0x040000FC RID: 252
		RequestPlayersForGameResultCallback,
		// Token: 0x040000FD RID: 253
		RequestPlayersForGameFinalResultCallback,
		// Token: 0x040000FE RID: 254
		SubmitPlayerResultResultCallback,
		// Token: 0x040000FF RID: 255
		EndGameResultCallback,
		// Token: 0x04000100 RID: 256
		JoinPartyCallback = 5301,
		// Token: 0x04000101 RID: 257
		CreateBeaconCallback,
		// Token: 0x04000102 RID: 258
		ReservationNotificationCallback,
		// Token: 0x04000103 RID: 259
		ChangeNumOpenSlotsCallback,
		// Token: 0x04000104 RID: 260
		AvailableBeaconLocationsUpdated,
		// Token: 0x04000105 RID: 261
		ActiveBeaconsUpdated,
		// Token: 0x04000106 RID: 262
		SteamRemotePlaySessionConnected = 5701,
		// Token: 0x04000107 RID: 263
		SteamRemotePlaySessionDisconnected
	}
}
