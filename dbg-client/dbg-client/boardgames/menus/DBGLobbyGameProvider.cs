using System;
using boardgames.data;
using Canis.json.events;
using Canis.messages;
using Canis.utils.ids;
using dwd.core;
using dwd.core.data.composition;
using dwd.core.data.providers;
using dwd.core.session;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.game;
using Networking.lobby.responses;
using UnityEngine.Events;

namespace boardgames.menus
{
	// Token: 0x020001A1 RID: 417
	public class DBGLobbyGameProvider : MapProvider<GameID, DataComposition>
	{
		// Token: 0x0600126F RID: 4719 RVA: 0x000589C8 File Offset: 0x00056BC8
		// Note: this type is marked as 'beforefieldinit'.
		static DBGLobbyGameProvider()
		{
			Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "DBGLobbyGameProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr);
			DBGLobbyGameProvider.NativeFieldInfoPtr_matchStartSoundName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "matchStartSoundName");
			DBGLobbyGameProvider.NativeFieldInfoPtr_lobbySession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "lobbySession");
			DBGLobbyGameProvider.NativeFieldInfoPtr_pendingGameMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "pendingGameMetadata");
			DBGLobbyGameProvider.NativeFieldInfoPtr_OnPlayerJoin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "OnPlayerJoin");
			DBGLobbyGameProvider.NativeFieldInfoPtr_OnPlayerLeave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "OnPlayerLeave");
			DBGLobbyGameProvider.NativeFieldInfoPtr_OnPlayerJoinAttendedMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "OnPlayerJoinAttendedMatch");
			DBGLobbyGameProvider.NativeFieldInfoPtr_OnPlayerLeaveAttendedMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "OnPlayerLeaveAttendedMatch");
			DBGLobbyGameProvider.NativeFieldInfoPtr_PlayerJoinAttendedMatchEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "PlayerJoinAttendedMatchEvent");
			DBGLobbyGameProvider.NativeFieldInfoPtr_PlayerLeaveAttendedMatchEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "PlayerLeaveAttendedMatchEvent");
			DBGLobbyGameProvider.NativeFieldInfoPtr_PlayerAttendedMatchStartEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "PlayerAttendedMatchStartEvent");
			DBGLobbyGameProvider.NativeFieldInfoPtr__TotalGames_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "<TotalGames>k__BackingField");
			DBGLobbyGameProvider.NativeMethodInfoPtr_add_PlayerJoinAttendedMatchEvent_Public_add_Void_Action_2_AccountID_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665975);
			DBGLobbyGameProvider.NativeMethodInfoPtr_remove_PlayerJoinAttendedMatchEvent_Public_rem_Void_Action_2_AccountID_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665976);
			DBGLobbyGameProvider.NativeMethodInfoPtr_add_PlayerLeaveAttendedMatchEvent_Public_add_Void_Action_2_AccountID_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665977);
			DBGLobbyGameProvider.NativeMethodInfoPtr_remove_PlayerLeaveAttendedMatchEvent_Public_rem_Void_Action_2_AccountID_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665978);
			DBGLobbyGameProvider.NativeMethodInfoPtr_add_PlayerAttendedMatchStartEvent_Public_add_Void_Action_1_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665979);
			DBGLobbyGameProvider.NativeMethodInfoPtr_remove_PlayerAttendedMatchStartEvent_Public_rem_Void_Action_1_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665980);
			DBGLobbyGameProvider.NativeMethodInfoPtr_get_OnWaitingForPlayerScreen_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665981);
			DBGLobbyGameProvider.NativeMethodInfoPtr_set_TotalGames_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665982);
			DBGLobbyGameProvider.NativeMethodInfoPtr_get_TotalGames_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665983);
			DBGLobbyGameProvider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665984);
			DBGLobbyGameProvider.NativeMethodInfoPtr_CanJoinGame_Public_Virtual_New_Boolean_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665985);
			DBGLobbyGameProvider.NativeMethodInfoPtr_HasAlreadyPendingLiveGame_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665986);
			DBGLobbyGameProvider.NativeMethodInfoPtr_HasAlreadyPendingCasualGame_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665987);
			DBGLobbyGameProvider.NativeMethodInfoPtr_logMessage_Private_Void_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665988);
			DBGLobbyGameProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665989);
			DBGLobbyGameProvider.NativeMethodInfoPtr_handleDisconnected_Private_Void_Disconnected_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665990);
			DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyGameStarted_Private_Void_LobbyGameStarted_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665991);
			DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyJoinFailed_Private_Void_LobbyJoinFailed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665992);
			DBGLobbyGameProvider.NativeMethodInfoPtr_handleUserRegistered_Private_Void_LobbyUserRegistered_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665993);
			DBGLobbyGameProvider.NativeMethodInfoPtr_handGameStartFailure_Private_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665994);
			DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyGameList_Private_Void_LobbyGameList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665995);
			DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyGameAdded_Private_Void_LobbyGameAdded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665996);
			DBGLobbyGameProvider.NativeMethodInfoPtr_analyticsLobbyGameAdded_Private_Void_LobbyGameAdded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665997);
			DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyGameRemoved_Private_Void_LobbyGameRemoved_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665998);
			DBGLobbyGameProvider.NativeMethodInfoPtr_analyticsLobbyGameRemoved_Private_Void_GameID_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100665999);
			DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyJoined_Private_Void_LobbyJoined_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100666000);
			DBGLobbyGameProvider.NativeMethodInfoPtr_LocalPlayerInLobby_Private_Boolean_AccountID_GameID_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100666001);
			DBGLobbyGameProvider.NativeMethodInfoPtr_LocalPlayerInLobby_Private_Boolean_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100666002);
			DBGLobbyGameProvider.NativeMethodInfoPtr_analyticsLobbyJoined_Private_Void_LobbyJoined_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100666003);
			DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyLeft_Private_Void_LobbyLeft_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100666004);
			DBGLobbyGameProvider.NativeMethodInfoPtr_analyticsLogLobbyLeft_Private_Void_LobbyLeft_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100666005);
			DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyGameUpdated_Private_Void_LobbyGameUpdated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100666006);
			DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyGamePlayerMetadataUpdated_Private_Void_LobbyGamePlayerMetadataUpdated_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100666007);
			DBGLobbyGameProvider.NativeMethodInfoPtr_createOrUpdateDataCompositionFor_Private_Boolean_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100666008);
			DBGLobbyGameProvider.NativeMethodInfoPtr_createPendingGameData_Protected_Abstract_Virtual_New_PendingGameData_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100666009);
			DBGLobbyGameProvider.NativeMethodInfoPtr_AttachGameSpecificDataComponents_Protected_Virtual_New_Void_DataComposition_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100666010);
			DBGLobbyGameProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, 100666011);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00058DB8 File Offset: 0x00056FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516989, XrefRangeEnd = 516994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PlayerJoinAttendedMatchEvent(Action<AccountID, DWDPendingGameMetadata> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_add_PlayerJoinAttendedMatchEvent_Public_add_Void_Action_2_AccountID_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00058DFC File Offset: 0x00056FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516994, XrefRangeEnd = 516999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PlayerJoinAttendedMatchEvent(Action<AccountID, DWDPendingGameMetadata> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_remove_PlayerJoinAttendedMatchEvent_Public_rem_Void_Action_2_AccountID_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00058E40 File Offset: 0x00057040
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516999, XrefRangeEnd = 517004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PlayerLeaveAttendedMatchEvent(Action<AccountID, DWDPendingGameMetadata> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_add_PlayerLeaveAttendedMatchEvent_Public_add_Void_Action_2_AccountID_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00058E84 File Offset: 0x00057084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517004, XrefRangeEnd = 517009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PlayerLeaveAttendedMatchEvent(Action<AccountID, DWDPendingGameMetadata> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_remove_PlayerLeaveAttendedMatchEvent_Public_rem_Void_Action_2_AccountID_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00058EC8 File Offset: 0x000570C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517009, XrefRangeEnd = 517014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_PlayerAttendedMatchStartEvent(Action<DWDPendingGameMetadata> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_add_PlayerAttendedMatchStartEvent_Public_add_Void_Action_1_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00058F0C File Offset: 0x0005710C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517014, XrefRangeEnd = 517019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_PlayerAttendedMatchStartEvent(Action<DWDPendingGameMetadata> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_remove_PlayerAttendedMatchStartEvent_Public_rem_Void_Action_1_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001276 RID: 4726 RVA: 0x00058F50 File Offset: 0x00057150
		public unsafe bool OnWaitingForPlayerScreen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517019, XrefRangeEnd = 517026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_get_OnWaitingForPlayerScreen_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00058FCC File Offset: 0x000571CC
		// (set) Token: 0x06001277 RID: 4727 RVA: 0x00058F8C File Offset: 0x0005718C
		public unsafe int TotalGames
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_get_TotalGames_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_set_TotalGames_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00059008 File Offset: 0x00057208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517026, XrefRangeEnd = 517144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0005903C File Offset: 0x0005723C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517144, XrefRangeEnd = 517205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanJoinGame(GameID gameIDToJoin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameIDToJoin);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGLobbyGameProvider.NativeMethodInfoPtr_CanJoinGame_Public_Virtual_New_Boolean_GameID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x00059094 File Offset: 0x00057294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517205, XrefRangeEnd = 517240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasAlreadyPendingLiveGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGLobbyGameProvider.NativeMethodInfoPtr_HasAlreadyPendingLiveGame_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x000590DC File Offset: 0x000572DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517240, XrefRangeEnd = 517279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasAlreadyPendingCasualGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGLobbyGameProvider.NativeMethodInfoPtr_HasAlreadyPendingCasualGame_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00059124 File Offset: 0x00057324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517279, XrefRangeEnd = 517294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void logMessage(DWDEvent evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_logMessage_Private_Void_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00059168 File Offset: 0x00057368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517294, XrefRangeEnd = 517397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0005919C File Offset: 0x0005739C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517397, XrefRangeEnd = 517424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleDisconnected(SessionProvider.Disconnected message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_handleDisconnected_Private_Void_Disconnected_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x000591E0 File Offset: 0x000573E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517424, XrefRangeEnd = 517457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleLobbyGameStarted(LobbyGameStarted message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyGameStarted_Private_Void_LobbyGameStarted_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00059224 File Offset: 0x00057424
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleLobbyJoinFailed(LobbyJoinFailed message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyJoinFailed_Private_Void_LobbyJoinFailed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00059268 File Offset: 0x00057468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517457, XrefRangeEnd = 517462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleUserRegistered(LobbyUserRegistered message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_handleUserRegistered_Private_Void_LobbyUserRegistered_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x000592AC File Offset: 0x000574AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517462, XrefRangeEnd = 517480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handGameStartFailure(ErrorInfo errorInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(errorInfo));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_handGameStartFailure_Private_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x000592F4 File Offset: 0x000574F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517480, XrefRangeEnd = 517520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleLobbyGameList(LobbyGameList message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyGameList_Private_Void_LobbyGameList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00059338 File Offset: 0x00057538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517520, XrefRangeEnd = 517533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleLobbyGameAdded(LobbyGameAdded message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyGameAdded_Private_Void_LobbyGameAdded_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0005937C File Offset: 0x0005757C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 517602, RefRangeEnd = 517603, XrefRangeStart = 517533, XrefRangeEnd = 517602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void analyticsLobbyGameAdded(LobbyGameAdded message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_analyticsLobbyGameAdded_Private_Void_LobbyGameAdded_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x000593C0 File Offset: 0x000575C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517603, XrefRangeEnd = 517627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleLobbyGameRemoved(LobbyGameRemoved message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyGameRemoved_Private_Void_LobbyGameRemoved_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00059404 File Offset: 0x00057604
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 517692, RefRangeEnd = 517694, XrefRangeStart = 517627, XrefRangeEnd = 517692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void analyticsLobbyGameRemoved(GameID gameID, DWDPendingGameMetadata gameSession)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameSession);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_analyticsLobbyGameRemoved_Private_Void_GameID_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00059458 File Offset: 0x00057658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517694, XrefRangeEnd = 517725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleLobbyJoined(LobbyJoined message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyJoined_Private_Void_LobbyJoined_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0005949C File Offset: 0x0005769C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 517740, RefRangeEnd = 517744, XrefRangeStart = 517725, XrefRangeEnd = 517740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LocalPlayerInLobby(AccountID accountID, GameID gameID, AccountID localAccountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localAccountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_LocalPlayerInLobby_Private_Boolean_AccountID_GameID_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00059510 File Offset: 0x00057710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517744, XrefRangeEnd = 517758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LocalPlayerInLobby(GameID gameID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_LocalPlayerInLobby_Private_Boolean_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00059560 File Offset: 0x00057760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 517827, RefRangeEnd = 517828, XrefRangeStart = 517758, XrefRangeEnd = 517827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void analyticsLobbyJoined(LobbyJoined message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_analyticsLobbyJoined_Private_Void_LobbyJoined_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x000595A4 File Offset: 0x000577A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517828, XrefRangeEnd = 517858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleLobbyLeft(LobbyLeft message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyLeft_Private_Void_LobbyLeft_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x000595E8 File Offset: 0x000577E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 517927, RefRangeEnd = 517928, XrefRangeStart = 517858, XrefRangeEnd = 517927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void analyticsLogLobbyLeft(LobbyLeft message, DWDPendingGameMetadata gameSession)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameSession);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_analyticsLogLobbyLeft_Private_Void_LobbyLeft_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0005963C File Offset: 0x0005783C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517928, XrefRangeEnd = 517931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleLobbyGameUpdated(LobbyGameUpdated message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyGameUpdated_Private_Void_LobbyGameUpdated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00059680 File Offset: 0x00057880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 517931, XrefRangeEnd = 517938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleLobbyGamePlayerMetadataUpdated(LobbyGamePlayerMetadataUpdated message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_handleLobbyGamePlayerMetadataUpdated_Private_Void_LobbyGamePlayerMetadataUpdated_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x000596C4 File Offset: 0x000578C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 518041, RefRangeEnd = 518046, XrefRangeStart = 517938, XrefRangeEnd = 518041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool createOrUpdateDataCompositionFor(DWDPendingGameMetadata message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr_createOrUpdateDataCompositionFor_Private_Boolean_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00059714 File Offset: 0x00057914
		[CallerCount(0)]
		public unsafe virtual PendingGameData createPendingGameData(DWDPendingGameMetadata message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGLobbyGameProvider.NativeMethodInfoPtr_createPendingGameData_Protected_Abstract_Virtual_New_PendingGameData_DWDPendingGameMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PendingGameData>(intPtr3) : null;
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00059770 File Offset: 0x00057970
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AttachGameSpecificDataComponents(DataComposition composition, DWDPendingGameMetadata message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(composition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGLobbyGameProvider.NativeMethodInfoPtr_AttachGameSpecificDataComponents_Protected_Virtual_New_Void_DataComposition_DWDPendingGameMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x000597D0 File Offset: 0x000579D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 518104, RefRangeEnd = 518105, XrefRangeStart = 518046, XrefRangeEnd = 518104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGLobbyGameProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0000ABF6 File Offset: 0x00008DF6
		public DBGLobbyGameProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001296 RID: 4758 RVA: 0x0005980C File Offset: 0x00057A0C
		// (set) Token: 0x06001297 RID: 4759 RVA: 0x0000ABFF File Offset: 0x00008DFF
		public unsafe string matchStartSoundName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_matchStartSoundName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_matchStartSoundName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001298 RID: 4760 RVA: 0x00059834 File Offset: 0x00057A34
		// (set) Token: 0x06001299 RID: 4761 RVA: 0x0000AC1E File Offset: 0x00008E1E
		public unsafe LobbySessionProvider lobbySession
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_lobbySession);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbySessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_lobbySession), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600129A RID: 4762 RVA: 0x00059864 File Offset: 0x00057A64
		// (set) Token: 0x0600129B RID: 4763 RVA: 0x0000AC3D File Offset: 0x00008E3D
		public unsafe Dictionary<GameID, DWDPendingGameMetadata> pendingGameMetadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_pendingGameMetadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<GameID, DWDPendingGameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_pendingGameMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600129C RID: 4764 RVA: 0x00059894 File Offset: 0x00057A94
		// (set) Token: 0x0600129D RID: 4765 RVA: 0x0000AC5C File Offset: 0x00008E5C
		public unsafe UnityEvent OnPlayerJoin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_OnPlayerJoin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_OnPlayerJoin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x000598C4 File Offset: 0x00057AC4
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x0000AC7B File Offset: 0x00008E7B
		public unsafe UnityEvent OnPlayerLeave
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_OnPlayerLeave);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_OnPlayerLeave), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x000598F4 File Offset: 0x00057AF4
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x0000AC9A File Offset: 0x00008E9A
		public unsafe UnityEvent OnPlayerJoinAttendedMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_OnPlayerJoinAttendedMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_OnPlayerJoinAttendedMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00059924 File Offset: 0x00057B24
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x0000ACB9 File Offset: 0x00008EB9
		public unsafe UnityEvent OnPlayerLeaveAttendedMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_OnPlayerLeaveAttendedMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_OnPlayerLeaveAttendedMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x00059954 File Offset: 0x00057B54
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x0000ACD8 File Offset: 0x00008ED8
		public unsafe Action<AccountID, DWDPendingGameMetadata> PlayerJoinAttendedMatchEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_PlayerJoinAttendedMatchEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AccountID, DWDPendingGameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_PlayerJoinAttendedMatchEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x00059984 File Offset: 0x00057B84
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x0000ACF7 File Offset: 0x00008EF7
		public unsafe Action<AccountID, DWDPendingGameMetadata> PlayerLeaveAttendedMatchEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_PlayerLeaveAttendedMatchEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AccountID, DWDPendingGameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_PlayerLeaveAttendedMatchEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060012A8 RID: 4776 RVA: 0x000599B4 File Offset: 0x00057BB4
		// (set) Token: 0x060012A9 RID: 4777 RVA: 0x0000AD16 File Offset: 0x00008F16
		public unsafe Action<DWDPendingGameMetadata> PlayerAttendedMatchStartEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_PlayerAttendedMatchStartEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DWDPendingGameMetadata>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr_PlayerAttendedMatchStartEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x000599E4 File Offset: 0x00057BE4
		// (set) Token: 0x060012AB RID: 4779 RVA: 0x0000AD35 File Offset: 0x00008F35
		public unsafe int _TotalGames_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr__TotalGames_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.NativeFieldInfoPtr__TotalGames_k__BackingField)) = value;
			}
		}

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeFieldInfoPtr_matchStartSoundName;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeFieldInfoPtr_lobbySession;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeFieldInfoPtr_pendingGameMetadata;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeFieldInfoPtr_OnPlayerJoin;

		// Token: 0x04000B51 RID: 2897
		private static readonly IntPtr NativeFieldInfoPtr_OnPlayerLeave;

		// Token: 0x04000B52 RID: 2898
		private static readonly IntPtr NativeFieldInfoPtr_OnPlayerJoinAttendedMatch;

		// Token: 0x04000B53 RID: 2899
		private static readonly IntPtr NativeFieldInfoPtr_OnPlayerLeaveAttendedMatch;

		// Token: 0x04000B54 RID: 2900
		private static readonly IntPtr NativeFieldInfoPtr_PlayerJoinAttendedMatchEvent;

		// Token: 0x04000B55 RID: 2901
		private static readonly IntPtr NativeFieldInfoPtr_PlayerLeaveAttendedMatchEvent;

		// Token: 0x04000B56 RID: 2902
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAttendedMatchStartEvent;

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeFieldInfoPtr__TotalGames_k__BackingField;

		// Token: 0x04000B58 RID: 2904
		private static readonly IntPtr NativeMethodInfoPtr_add_PlayerJoinAttendedMatchEvent_Public_add_Void_Action_2_AccountID_DWDPendingGameMetadata_0;

		// Token: 0x04000B59 RID: 2905
		private static readonly IntPtr NativeMethodInfoPtr_remove_PlayerJoinAttendedMatchEvent_Public_rem_Void_Action_2_AccountID_DWDPendingGameMetadata_0;

		// Token: 0x04000B5A RID: 2906
		private static readonly IntPtr NativeMethodInfoPtr_add_PlayerLeaveAttendedMatchEvent_Public_add_Void_Action_2_AccountID_DWDPendingGameMetadata_0;

		// Token: 0x04000B5B RID: 2907
		private static readonly IntPtr NativeMethodInfoPtr_remove_PlayerLeaveAttendedMatchEvent_Public_rem_Void_Action_2_AccountID_DWDPendingGameMetadata_0;

		// Token: 0x04000B5C RID: 2908
		private static readonly IntPtr NativeMethodInfoPtr_add_PlayerAttendedMatchStartEvent_Public_add_Void_Action_1_DWDPendingGameMetadata_0;

		// Token: 0x04000B5D RID: 2909
		private static readonly IntPtr NativeMethodInfoPtr_remove_PlayerAttendedMatchStartEvent_Public_rem_Void_Action_1_DWDPendingGameMetadata_0;

		// Token: 0x04000B5E RID: 2910
		private static readonly IntPtr NativeMethodInfoPtr_get_OnWaitingForPlayerScreen_Private_get_Boolean_0;

		// Token: 0x04000B5F RID: 2911
		private static readonly IntPtr NativeMethodInfoPtr_set_TotalGames_Protected_set_Void_Int32_0;

		// Token: 0x04000B60 RID: 2912
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalGames_Public_get_Int32_0;

		// Token: 0x04000B61 RID: 2913
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000B62 RID: 2914
		private static readonly IntPtr NativeMethodInfoPtr_CanJoinGame_Public_Virtual_New_Boolean_GameID_0;

		// Token: 0x04000B63 RID: 2915
		private static readonly IntPtr NativeMethodInfoPtr_HasAlreadyPendingLiveGame_Public_Virtual_New_Boolean_0;

		// Token: 0x04000B64 RID: 2916
		private static readonly IntPtr NativeMethodInfoPtr_HasAlreadyPendingCasualGame_Public_Virtual_New_Boolean_0;

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_logMessage_Private_Void_DWDEvent_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_handleDisconnected_Private_Void_Disconnected_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_handleLobbyGameStarted_Private_Void_LobbyGameStarted_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_handleLobbyJoinFailed_Private_Void_LobbyJoinFailed_0;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_handleUserRegistered_Private_Void_LobbyUserRegistered_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr_handGameStartFailure_Private_Void_ErrorInfo_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr_handleLobbyGameList_Private_Void_LobbyGameList_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr_handleLobbyGameAdded_Private_Void_LobbyGameAdded_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_analyticsLobbyGameAdded_Private_Void_LobbyGameAdded_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_handleLobbyGameRemoved_Private_Void_LobbyGameRemoved_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_analyticsLobbyGameRemoved_Private_Void_GameID_DWDPendingGameMetadata_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_handleLobbyJoined_Private_Void_LobbyJoined_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerInLobby_Private_Boolean_AccountID_GameID_AccountID_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_LocalPlayerInLobby_Private_Boolean_GameID_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_analyticsLobbyJoined_Private_Void_LobbyJoined_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_handleLobbyLeft_Private_Void_LobbyLeft_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_analyticsLogLobbyLeft_Private_Void_LobbyLeft_DWDPendingGameMetadata_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_handleLobbyGameUpdated_Private_Void_LobbyGameUpdated_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_handleLobbyGamePlayerMetadataUpdated_Private_Void_LobbyGamePlayerMetadataUpdated_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_createOrUpdateDataCompositionFor_Private_Boolean_DWDPendingGameMetadata_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_createPendingGameData_Protected_Abstract_Virtual_New_PendingGameData_DWDPendingGameMetadata_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_AttachGameSpecificDataComponents_Protected_Virtual_New_Void_DataComposition_DWDPendingGameMetadata_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000390 RID: 912
		[ObfuscatedName("boardgames.menus.DBGLobbyGameProvider+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002B07 RID: 11015 RVA: 0x000A92D8 File Offset: 0x000A74D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr);
				DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr, "<>9");
				DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr, "<>9__46_0");
				DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr, "<>9__49_0");
				DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9__49_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr, "<>9__49_1");
				DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9__49_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr, "<>9__49_2");
				DBGLobbyGameProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr, 100666013);
				DBGLobbyGameProvider.__c.NativeMethodInfoPtr__createOrUpdateDataCompositionFor_b__46_0_Internal_Boolean_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr, 100666014);
				DBGLobbyGameProvider.__c.NativeMethodInfoPtr___ctor_b__49_0_Internal_Void_AccountID_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr, 100666015);
				DBGLobbyGameProvider.__c.NativeMethodInfoPtr___ctor_b__49_1_Internal_Void_AccountID_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr, 100666016);
				DBGLobbyGameProvider.__c.NativeMethodInfoPtr___ctor_b__49_2_Internal_Void_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr, 100666017);
			}

			// Token: 0x06002B08 RID: 11016 RVA: 0x000A93CC File Offset: 0x000A75CC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLobbyGameProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B09 RID: 11017 RVA: 0x000A9408 File Offset: 0x000A7608
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516955, XrefRangeEnd = 516963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _createOrUpdateDataCompositionFor_b__46_0(DataComposition player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c.NativeMethodInfoPtr__createOrUpdateDataCompositionFor_b__46_0_Internal_Boolean_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B0A RID: 11018 RVA: 0x000A9458 File Offset: 0x000A7658
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__49_0(AccountID <p0>, DWDPendingGameMetadata <p1>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(<p1>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c.NativeMethodInfoPtr___ctor_b__49_0_Internal_Void_AccountID_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B0B RID: 11019 RVA: 0x000A94AC File Offset: 0x000A76AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__49_1(AccountID <p0>, DWDPendingGameMetadata <p1>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(<p1>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c.NativeMethodInfoPtr___ctor_b__49_1_Internal_Void_AccountID_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B0C RID: 11020 RVA: 0x000A9500 File Offset: 0x000A7700
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__49_2(DWDPendingGameMetadata <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c.NativeMethodInfoPtr___ctor_b__49_2_Internal_Void_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002B0D RID: 11021 RVA: 0x00016401 File Offset: 0x00014601
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C30 RID: 3120
			// (get) Token: 0x06002B0E RID: 11022 RVA: 0x000A9544 File Offset: 0x000A7744
			// (set) Token: 0x06002B0F RID: 11023 RVA: 0x0001640A File Offset: 0x0001460A
			public unsafe static DBGLobbyGameProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGLobbyGameProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C31 RID: 3121
			// (get) Token: 0x06002B10 RID: 11024 RVA: 0x000A956C File Offset: 0x000A776C
			// (set) Token: 0x06002B11 RID: 11025 RVA: 0x0001641C File Offset: 0x0001461C
			public unsafe static Func<DataComposition, bool> __9__46_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9__46_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DataComposition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9__46_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C32 RID: 3122
			// (get) Token: 0x06002B12 RID: 11026 RVA: 0x000A9594 File Offset: 0x000A7794
			// (set) Token: 0x06002B13 RID: 11027 RVA: 0x0001642E File Offset: 0x0001462E
			public unsafe static Action<AccountID, DWDPendingGameMetadata> __9__49_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AccountID, DWDPendingGameMetadata>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9__49_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C33 RID: 3123
			// (get) Token: 0x06002B14 RID: 11028 RVA: 0x000A95BC File Offset: 0x000A77BC
			// (set) Token: 0x06002B15 RID: 11029 RVA: 0x00016440 File Offset: 0x00014640
			public unsafe static Action<AccountID, DWDPendingGameMetadata> __9__49_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9__49_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AccountID, DWDPendingGameMetadata>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9__49_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C34 RID: 3124
			// (get) Token: 0x06002B16 RID: 11030 RVA: 0x000A95E4 File Offset: 0x000A77E4
			// (set) Token: 0x06002B17 RID: 11031 RVA: 0x00016452 File Offset: 0x00014652
			public unsafe static Action<DWDPendingGameMetadata> __9__49_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9__49_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<DWDPendingGameMetadata>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGLobbyGameProvider.__c.NativeFieldInfoPtr___9__49_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AD6 RID: 6870
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001AD7 RID: 6871
			private static readonly IntPtr NativeFieldInfoPtr___9__46_0;

			// Token: 0x04001AD8 RID: 6872
			private static readonly IntPtr NativeFieldInfoPtr___9__49_0;

			// Token: 0x04001AD9 RID: 6873
			private static readonly IntPtr NativeFieldInfoPtr___9__49_1;

			// Token: 0x04001ADA RID: 6874
			private static readonly IntPtr NativeFieldInfoPtr___9__49_2;

			// Token: 0x04001ADB RID: 6875
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001ADC RID: 6876
			private static readonly IntPtr NativeMethodInfoPtr__createOrUpdateDataCompositionFor_b__46_0_Internal_Boolean_DataComposition_0;

			// Token: 0x04001ADD RID: 6877
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__49_0_Internal_Void_AccountID_DWDPendingGameMetadata_0;

			// Token: 0x04001ADE RID: 6878
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__49_1_Internal_Void_AccountID_DWDPendingGameMetadata_0;

			// Token: 0x04001ADF RID: 6879
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__49_2_Internal_Void_DWDPendingGameMetadata_0;
		}

		// Token: 0x02000391 RID: 913
		[ObfuscatedName("boardgames.menus.DBGLobbyGameProvider+<>c__DisplayClass23_0")]
		public sealed class __c__DisplayClass23_0 : Object
		{
			// Token: 0x06002B18 RID: 11032 RVA: 0x000A960C File Offset: 0x000A780C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass23_0()
			{
				Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass23_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "<>c__DisplayClass23_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass23_0>.NativeClassPtr);
				DBGLobbyGameProvider.__c__DisplayClass23_0.NativeFieldInfoPtr_myAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass23_0>.NativeClassPtr, "myAccountID");
				DBGLobbyGameProvider.__c__DisplayClass23_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass23_0>.NativeClassPtr, "<>9__0");
				DBGLobbyGameProvider.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass23_0>.NativeClassPtr, 100666018);
				DBGLobbyGameProvider.__c__DisplayClass23_0.NativeMethodInfoPtr__CanJoinGame_b__0_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass23_0>.NativeClassPtr, 100666019);
			}

			// Token: 0x06002B19 RID: 11033 RVA: 0x000A9688 File Offset: 0x000A7888
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass23_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass23_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c__DisplayClass23_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B1A RID: 11034 RVA: 0x000A96C4 File Offset: 0x000A78C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516963, XrefRangeEnd = 516968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanJoinGame_b__0(AccountIDUsernameMetadata p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c__DisplayClass23_0.NativeMethodInfoPtr__CanJoinGame_b__0_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B1B RID: 11035 RVA: 0x00016464 File Offset: 0x00014664
			public __c__DisplayClass23_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C35 RID: 3125
			// (get) Token: 0x06002B1C RID: 11036 RVA: 0x000A9714 File Offset: 0x000A7914
			// (set) Token: 0x06002B1D RID: 11037 RVA: 0x0001646D File Offset: 0x0001466D
			public unsafe AccountID myAccountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass23_0.NativeFieldInfoPtr_myAccountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass23_0.NativeFieldInfoPtr_myAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C36 RID: 3126
			// (get) Token: 0x06002B1E RID: 11038 RVA: 0x000A9744 File Offset: 0x000A7944
			// (set) Token: 0x06002B1F RID: 11039 RVA: 0x0001648C File Offset: 0x0001468C
			public unsafe Predicate<AccountIDUsernameMetadata> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass23_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AccountIDUsernameMetadata>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass23_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AE0 RID: 6880
			private static readonly IntPtr NativeFieldInfoPtr_myAccountID;

			// Token: 0x04001AE1 RID: 6881
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04001AE2 RID: 6882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001AE3 RID: 6883
			private static readonly IntPtr NativeMethodInfoPtr__CanJoinGame_b__0_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000392 RID: 914
		[ObfuscatedName("boardgames.menus.DBGLobbyGameProvider+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Object
		{
			// Token: 0x06002B20 RID: 11040 RVA: 0x000A9774 File Offset: 0x000A7974
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass24_0>.NativeClassPtr);
				DBGLobbyGameProvider.__c__DisplayClass24_0.NativeFieldInfoPtr_myAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass24_0>.NativeClassPtr, "myAccountID");
				DBGLobbyGameProvider.__c__DisplayClass24_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass24_0>.NativeClassPtr, "<>9__0");
				DBGLobbyGameProvider.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass24_0>.NativeClassPtr, 100666020);
				DBGLobbyGameProvider.__c__DisplayClass24_0.NativeMethodInfoPtr__HasAlreadyPendingLiveGame_b__0_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass24_0>.NativeClassPtr, 100666021);
			}

			// Token: 0x06002B21 RID: 11041 RVA: 0x000A97F0 File Offset: 0x000A79F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B22 RID: 11042 RVA: 0x000A982C File Offset: 0x000A7A2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516968, XrefRangeEnd = 516973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasAlreadyPendingLiveGame_b__0(AccountIDUsernameMetadata p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c__DisplayClass24_0.NativeMethodInfoPtr__HasAlreadyPendingLiveGame_b__0_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B23 RID: 11043 RVA: 0x000164AB File Offset: 0x000146AB
			public __c__DisplayClass24_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C37 RID: 3127
			// (get) Token: 0x06002B24 RID: 11044 RVA: 0x000A987C File Offset: 0x000A7A7C
			// (set) Token: 0x06002B25 RID: 11045 RVA: 0x000164B4 File Offset: 0x000146B4
			public unsafe AccountID myAccountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass24_0.NativeFieldInfoPtr_myAccountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass24_0.NativeFieldInfoPtr_myAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C38 RID: 3128
			// (get) Token: 0x06002B26 RID: 11046 RVA: 0x000A98AC File Offset: 0x000A7AAC
			// (set) Token: 0x06002B27 RID: 11047 RVA: 0x000164D3 File Offset: 0x000146D3
			public unsafe Predicate<AccountIDUsernameMetadata> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass24_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AccountIDUsernameMetadata>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass24_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AE4 RID: 6884
			private static readonly IntPtr NativeFieldInfoPtr_myAccountID;

			// Token: 0x04001AE5 RID: 6885
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04001AE6 RID: 6886
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001AE7 RID: 6887
			private static readonly IntPtr NativeMethodInfoPtr__HasAlreadyPendingLiveGame_b__0_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000393 RID: 915
		[ObfuscatedName("boardgames.menus.DBGLobbyGameProvider+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Object
		{
			// Token: 0x06002B28 RID: 11048 RVA: 0x000A98DC File Offset: 0x000A7ADC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass25_0>.NativeClassPtr);
				DBGLobbyGameProvider.__c__DisplayClass25_0.NativeFieldInfoPtr_myAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass25_0>.NativeClassPtr, "myAccountID");
				DBGLobbyGameProvider.__c__DisplayClass25_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass25_0>.NativeClassPtr, "<>9__0");
				DBGLobbyGameProvider.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass25_0>.NativeClassPtr, 100666022);
				DBGLobbyGameProvider.__c__DisplayClass25_0.NativeMethodInfoPtr__HasAlreadyPendingCasualGame_b__0_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass25_0>.NativeClassPtr, 100666023);
			}

			// Token: 0x06002B29 RID: 11049 RVA: 0x000A9958 File Offset: 0x000A7B58
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B2A RID: 11050 RVA: 0x000A9994 File Offset: 0x000A7B94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516973, XrefRangeEnd = 516978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasAlreadyPendingCasualGame_b__0(AccountIDUsernameMetadata p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c__DisplayClass25_0.NativeMethodInfoPtr__HasAlreadyPendingCasualGame_b__0_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B2B RID: 11051 RVA: 0x000164F2 File Offset: 0x000146F2
			public __c__DisplayClass25_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C39 RID: 3129
			// (get) Token: 0x06002B2C RID: 11052 RVA: 0x000A99E4 File Offset: 0x000A7BE4
			// (set) Token: 0x06002B2D RID: 11053 RVA: 0x000164FB File Offset: 0x000146FB
			public unsafe AccountID myAccountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass25_0.NativeFieldInfoPtr_myAccountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass25_0.NativeFieldInfoPtr_myAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C3A RID: 3130
			// (get) Token: 0x06002B2E RID: 11054 RVA: 0x000A9A14 File Offset: 0x000A7C14
			// (set) Token: 0x06002B2F RID: 11055 RVA: 0x0001651A File Offset: 0x0001471A
			public unsafe Predicate<AccountIDUsernameMetadata> __9__0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass25_0.NativeFieldInfoPtr___9__0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AccountIDUsernameMetadata>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass25_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AE8 RID: 6888
			private static readonly IntPtr NativeFieldInfoPtr_myAccountID;

			// Token: 0x04001AE9 RID: 6889
			private static readonly IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04001AEA RID: 6890
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001AEB RID: 6891
			private static readonly IntPtr NativeMethodInfoPtr__HasAlreadyPendingCasualGame_b__0_Internal_Boolean_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000394 RID: 916
		[ObfuscatedName("boardgames.menus.DBGLobbyGameProvider+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Object
		{
			// Token: 0x06002B30 RID: 11056 RVA: 0x000A9A44 File Offset: 0x000A7C44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass33_0>.NativeClassPtr);
				DBGLobbyGameProvider.__c__DisplayClass33_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass33_0>.NativeClassPtr, "accountID");
				DBGLobbyGameProvider.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass33_0>.NativeClassPtr, 100666024);
				DBGLobbyGameProvider.__c__DisplayClass33_0.NativeMethodInfoPtr__handleLobbyGameList_b__0_Internal_Boolean_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass33_0>.NativeClassPtr, 100666025);
			}

			// Token: 0x06002B31 RID: 11057 RVA: 0x000A9AAC File Offset: 0x000A7CAC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B32 RID: 11058 RVA: 0x000A9AE8 File Offset: 0x000A7CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516978, XrefRangeEnd = 516979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _handleLobbyGameList_b__0(DWDPendingGameMetadata g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c__DisplayClass33_0.NativeMethodInfoPtr__handleLobbyGameList_b__0_Internal_Boolean_DWDPendingGameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B33 RID: 11059 RVA: 0x00016539 File Offset: 0x00014739
			public __c__DisplayClass33_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C3B RID: 3131
			// (get) Token: 0x06002B34 RID: 11060 RVA: 0x000A9B38 File Offset: 0x000A7D38
			// (set) Token: 0x06002B35 RID: 11061 RVA: 0x00016542 File Offset: 0x00014742
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass33_0.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass33_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AEC RID: 6892
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x04001AED RID: 6893
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001AEE RID: 6894
			private static readonly IntPtr NativeMethodInfoPtr__handleLobbyGameList_b__0_Internal_Boolean_DWDPendingGameMetadata_0;
		}

		// Token: 0x02000395 RID: 917
		[ObfuscatedName("boardgames.menus.DBGLobbyGameProvider+<>c__DisplayClass46_0")]
		public sealed class __c__DisplayClass46_0 : Object
		{
			// Token: 0x06002B36 RID: 11062 RVA: 0x000A9B68 File Offset: 0x000A7D68
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass46_0()
			{
				Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass46_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGLobbyGameProvider>.NativeClassPtr, "<>c__DisplayClass46_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass46_0>.NativeClassPtr);
				DBGLobbyGameProvider.__c__DisplayClass46_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass46_0>.NativeClassPtr, "message");
				DBGLobbyGameProvider.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass46_0>.NativeClassPtr, 100666026);
				DBGLobbyGameProvider.__c__DisplayClass46_0.NativeMethodInfoPtr__createOrUpdateDataCompositionFor_b__1_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass46_0>.NativeClassPtr, 100666027);
				DBGLobbyGameProvider.__c__DisplayClass46_0.NativeMethodInfoPtr__createOrUpdateDataCompositionFor_b__2_Internal_Boolean_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass46_0>.NativeClassPtr, 100666028);
			}

			// Token: 0x06002B37 RID: 11063 RVA: 0x000A9BE4 File Offset: 0x000A7DE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass46_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLobbyGameProvider.__c__DisplayClass46_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c__DisplayClass46_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002B38 RID: 11064 RVA: 0x000A9C20 File Offset: 0x000A7E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516979, XrefRangeEnd = 516984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _createOrUpdateDataCompositionFor_b__1(AccountIDUsernameMetadata p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c__DisplayClass46_0.NativeMethodInfoPtr__createOrUpdateDataCompositionFor_b__1_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B39 RID: 11065 RVA: 0x000A9C70 File Offset: 0x000A7E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 516984, XrefRangeEnd = 516989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _createOrUpdateDataCompositionFor_b__2(AccountIDUsernameMetadata p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLobbyGameProvider.__c__DisplayClass46_0.NativeMethodInfoPtr__createOrUpdateDataCompositionFor_b__2_Internal_Boolean_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002B3A RID: 11066 RVA: 0x00016561 File Offset: 0x00014761
			public __c__DisplayClass46_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C3C RID: 3132
			// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000A9CC0 File Offset: 0x000A7EC0
			// (set) Token: 0x06002B3C RID: 11068 RVA: 0x0001656A File Offset: 0x0001476A
			public unsafe DWDPendingGameMetadata message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass46_0.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DWDPendingGameMetadata>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLobbyGameProvider.__c__DisplayClass46_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AEF RID: 6895
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04001AF0 RID: 6896
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001AF1 RID: 6897
			private static readonly IntPtr NativeMethodInfoPtr__createOrUpdateDataCompositionFor_b__1_Internal_Boolean_AccountIDUsernameMetadata_0;

			// Token: 0x04001AF2 RID: 6898
			private static readonly IntPtr NativeMethodInfoPtr__createOrUpdateDataCompositionFor_b__2_Internal_Boolean_AccountIDUsernameMetadata_0;
		}
	}
}
