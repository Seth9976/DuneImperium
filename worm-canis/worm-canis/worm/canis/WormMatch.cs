using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using canis.archetypes;
using Canis.attributes;
using Canis.data;
using Canis.entities;
using Canis.events;
using Canis.gameLogs;
using Canis.json.events;
using Canis.messages;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;
using Networking.selection.messages;
using worm.canis.abilities.TriggeredAbilities;
using worm.canis.archetypes;
using worm.canis.data.enums;
using worm.canis.data.Tutorial;
using worm.canis.entities;
using worm.canis.gameLogs;
using worm.canis.match;
using worm.canis.networking;

namespace worm.canis
{
	// Token: 0x0200000D RID: 13
	public class WormMatch : Match<WormPlayer>
	{
		// Token: 0x06000052 RID: 82 RVA: 0x0006A2D0 File Offset: 0x000684D0
		// Note: this type is marked as 'beforefieldinit'.
		static WormMatch()
		{
			Il2CppClassPointerStore<WormMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis", "WormMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch>.NativeClassPtr);
			WormMatch.NativeFieldInfoPtr__Archetypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<Archetypes>k__BackingField");
			WormMatch.NativeFieldInfoPtr_CleanupGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "CleanupGame");
			WormMatch.NativeFieldInfoPtr_disconnectedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "disconnectedPlayers");
			WormMatch.NativeFieldInfoPtr_scenarioScript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "scenarioScript");
			WormMatch.NativeFieldInfoPtr_scenarioAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "scenarioAction");
			WormMatch.NativeFieldInfoPtr_wormmid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "wormmid");
			WormMatch.NativeFieldInfoPtr_messageActionFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "messageActionFactory");
			WormMatch.NativeFieldInfoPtr__GameLogManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<GameLogManager>k__BackingField");
			WormMatch.NativeMethodInfoPtr_get_MessageActionFactory_Public_Virtual_get_IMessageActionFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663397);
			WormMatch.NativeMethodInfoPtr_get_WormPlaymat_Public_get_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663398);
			WormMatch.NativeMethodInfoPtr_get_ActiveAbility_Public_Virtual_Final_New_get_ActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663399);
			WormMatch.NativeMethodInfoPtr_get_AbilityStack_Public_Virtual_Final_New_get_IEnumerable_1_ActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663400);
			WormMatch.NativeMethodInfoPtr_get_Archetypes_Public_Virtual_Final_New_get_WormArchetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663401);
			WormMatch.NativeMethodInfoPtr_get_SimpleArchetypes_Public_Virtual_Final_New_get_Archetypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663402);
			WormMatch.NativeMethodInfoPtr_get_ShouldIncludeAccountIDOnMessage_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663403);
			WormMatch.NativeMethodInfoPtr_get_ConflictRewardsAllowed_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663404);
			WormMatch.NativeMethodInfoPtr_get_EnabledSets_Public_get_Il2CppStructArray_1_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663405);
			WormMatch.NativeMethodInfoPtr_IsSetEnabled_Public_Boolean_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663406);
			WormMatch.NativeMethodInfoPtr_GetArchetypesLock_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663407);
			WormMatch.NativeMethodInfoPtr_get_PlayerTurnOrder_Public_get_IEnumerable_1_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663408);
			WormMatch.NativeMethodInfoPtr_FindPlayerTurnOrder_Public_IEnumerable_1_WormPlayer_Func_2_WormPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663409);
			WormMatch.NativeMethodInfoPtr_get_IsEvent_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663410);
			WormMatch.NativeMethodInfoPtr_get_GetEventID_Public_Virtual_get_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663411);
			WormMatch.NativeMethodInfoPtr_get_GetRoundID_Public_Virtual_get_RoundID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663412);
			WormMatch.NativeMethodInfoPtr_get_SkipLiveReplay_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663413);
			WormMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663414);
			WormMatch.NativeMethodInfoPtr_validForDisplayAction_Protected_Virtual_Boolean_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663415);
			WormMatch.NativeMethodInfoPtr_Configure_Public_Virtual_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663416);
			WormMatch.NativeMethodInfoPtr_GenPlaymat_Protected_Virtual_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663417);
			WormMatch.NativeMethodInfoPtr_GenPlaymat_Protected_Virtual_Entity_SerializedEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663418);
			WormMatch.NativeMethodInfoPtr_GenInitialAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663419);
			WormMatch.NativeMethodInfoPtr_GenResumeAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663420);
			WormMatch.NativeMethodInfoPtr_StartNewMatch_Protected_Virtual_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663421);
			WormMatch.NativeMethodInfoPtr_InitializeNewMatch_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663422);
			WormMatch.NativeMethodInfoPtr_ReinitializeMatch_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663423);
			WormMatch.NativeMethodInfoPtr_CleanupGameFailure_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663424);
			WormMatch.NativeMethodInfoPtr_CreatePlayers_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663425);
			WormMatch.NativeMethodInfoPtr_InitializePlayers_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663426);
			WormMatch.NativeMethodInfoPtr_PlayerTutorialInit_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663427);
			WormMatch.NativeMethodInfoPtr_LoadRuleMods_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663428);
			WormMatch.NativeMethodInfoPtr_SetScenarioAction_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663429);
			WormMatch.NativeMethodInfoPtr_ShouldStoreGame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663430);
			WormMatch.NativeMethodInfoPtr_get_IsRestart_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663431);
			WormMatch.NativeMethodInfoPtr_IsScenario_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663432);
			WormMatch.NativeMethodInfoPtr_IsGameOver_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663433);
			WormMatch.NativeMethodInfoPtr_IsMatchOver_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663434);
			WormMatch.NativeMethodInfoPtr_IsEndgame_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663435);
			WormMatch.NativeMethodInfoPtr_GetEndgamePlayerOrder_Public_List_1_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663436);
			WormMatch.NativeMethodInfoPtr_GetWinner_Public_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663437);
			WormMatch.NativeMethodInfoPtr_CurrentPlayer_Public_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663438);
			WormMatch.NativeMethodInfoPtr_NextPlayer_Public_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663439);
			WormMatch.NativeMethodInfoPtr_GetGameResults_Public_Virtual_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663440);
			WormMatch.NativeMethodInfoPtr_MakePlayerGameResults_Private_WormGameResultsEntry_WormPlayer_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663441);
			WormMatch.NativeMethodInfoPtr_getGameResults_Public_Virtual_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663442);
			WormMatch.NativeMethodInfoPtr_GameOverAchievementsForPlayer_Public_List_1_String_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663443);
			WormMatch.NativeMethodInfoPtr_GetGameType_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663444);
			WormMatch.NativeMethodInfoPtr_passToPlayerAction_Public_Virtual_Action_PlayerEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663445);
			WormMatch.NativeMethodInfoPtr_HandleResignGame_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663446);
			WormMatch.NativeMethodInfoPtr_HandleIdleResignFromGame_Public_Virtual_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663447);
			WormMatch.NativeMethodInfoPtr_HasResigned_Public_Virtual_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663448);
			WormMatch.NativeMethodInfoPtr_LogAnalyticsGameStart_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663449);
			WormMatch.NativeMethodInfoPtr_logGameOverAnalytics_Private_Void_Il2CppReferenceArray_1_WormGameResultsEntry_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663450);
			WormMatch.NativeMethodInfoPtr_logAnalyticsResign_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663451);
			WormMatch.NativeMethodInfoPtr_GetPlayerType_Private_PlayerType_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663452);
			WormMatch.NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663453);
			WormMatch.NativeMethodInfoPtr_GetPreAIDecisionAction_Public_Virtual_Action_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663454);
			WormMatch.NativeMethodInfoPtr_get_PlayerNameData_Public_get_List_1_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663455);
			WormMatch.NativeMethodInfoPtr_GetPlayerEntity_Public_Virtual_PlayerEntity_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663456);
			WormMatch.NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663457);
			WormMatch.NativeMethodInfoPtr_GetPlayerByIndex_Public_Virtual_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663458);
			WormMatch.NativeMethodInfoPtr_SetCleanupGame_Public_Virtual_Final_New_Void_Func_3_List_1_AccountID_WormGameResults_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663459);
			WormMatch.NativeMethodInfoPtr_GameOverCleanup_Public_Virtual_Void_List_1_AccountID_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663460);
			WormMatch.NativeMethodInfoPtr_PreProcessPlayerChoiceWithPlayer_Public_Virtual_IEnumerable_1_Action_SelectionMessage_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663461);
			WormMatch.NativeMethodInfoPtr_MakeObfuscatedMovePublicData_Public_Virtual_IEnumerable_1_IAttribute_Entity_EntityID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663462);
			WormMatch.NativeMethodInfoPtr_GetAdditionalPlayerMetadata_Public_Virtual_Dictionary_2_String_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663463);
			WormMatch.NativeMethodInfoPtr_get_HagalMultiTurnOrder_Public_get_IEnumerable_1_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663464);
			WormMatch.NativeMethodInfoPtr_FindHagalMultiTurnOrder_Public_IEnumerable_1_WormPlayer_Func_2_WormPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663465);
			WormMatch.NativeMethodInfoPtr_ClearDisplayActionsOnSave_Public_Virtual_IEnumerable_1_PlayerEntity_PlayerEntity_Dictionary_2_PlayerEntity_List_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663466);
			WormMatch.NativeMethodInfoPtr_HasSkirmishRuleMod_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663467);
			WormMatch.NativeMethodInfoPtr_PushNewAbility_Public_Virtual_Final_New_ActiveAbility_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663468);
			WormMatch.NativeMethodInfoPtr_PopAbility_Public_Virtual_Final_New_Action_ActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663469);
			WormMatch.NativeMethodInfoPtr_get_InstalledTriggeredAbilities_Public_get_IEnumerable_1_ITriggeredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663470);
			WormMatch.NativeMethodInfoPtr_GetInstalledTriggers_Public_Virtual_Final_New_IEnumerable_1_ITriggeredAbility_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663471);
			WormMatch.NativeMethodInfoPtr_get_GameLogManager_Public_Virtual_Final_New_get_GameLogManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663472);
			WormMatch.NativeMethodInfoPtr_set_GameLogManager_Private_set_Void_GameLogManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663473);
			WormMatch.NativeMethodInfoPtr_get_LogStack_Public_get_LogStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663474);
			WormMatch.NativeMethodInfoPtr_get_GameLogUndoNode_Public_Virtual_Final_New_get_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663475);
			WormMatch.NativeMethodInfoPtr_get_StoredGameLogs_Public_Virtual_Final_New_get_IEnumerable_1_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663476);
			WormMatch.NativeMethodInfoPtr_GetStoredLog_Public_Virtual_Final_New_SerializedGameLog_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663477);
			WormMatch.NativeMethodInfoPtr_StoreGameLog_Public_Virtual_Final_New_SerializedGameLog_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663478);
			WormMatch.NativeMethodInfoPtr_StoreGameLog_Public_Virtual_Final_New_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663479);
			WormMatch.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_Final_New_GameLogBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663480);
			WormMatch.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_Final_New_GameLogBuilder_String_GameLogBuilderFactoryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663481);
			WormMatch.NativeMethodInfoPtr_AILog_Public_Virtual_Void_PlayerEntity_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663482);
			WormMatch.NativeMethodInfoPtr_get_TimerMode_Public_Virtual_get_TimerModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663483);
			WormMatch.NativeMethodInfoPtr_get_TimerLength_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663484);
			WormMatch.NativeMethodInfoPtr_GetUndoEntity_Public_Virtual_Final_New_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663485);
			WormMatch.NativeMethodInfoPtr_GetRedoEntity_Public_Virtual_Final_New_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663486);
			WormMatch.NativeMethodInfoPtr_get_StoreLastCompletedSelection_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663487);
			WormMatch.NativeMethodInfoPtr_GameSpecificUndoIsAvailable_Public_Virtual_Final_New_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663488);
			WormMatch.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663489);
			WormMatch.NativeMethodInfoPtr_GameSpecificUndoBehavior_Public_Virtual_Final_New_IEnumerable_1_Action_PlayerEntity_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663490);
			WormMatch.NativeMethodInfoPtr_AddUndoNode_Public_Virtual_Final_New_Action_UndoNode_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663491);
			WormMatch.NativeMethodInfoPtr_RemoveUndoNode_Public_Virtual_Final_New_Action_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663492);
			WormMatch.NativeMethodInfoPtr_AddSequenceToUndoNode_Public_IEnumerable_1_Action_UndoNode_SequenceHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663493);
			WormMatch.NativeMethodInfoPtr_Method_Private_Int32_WormPlayer_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663494);
			WormMatch.NativeMethodInfoPtr_Method_Private_Int32_WormPlayer_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663495);
			WormMatch.NativeMethodInfoPtr__logGameOverAnalytics_b__75_3_Private_PlayerType_WormGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663496);
			WormMatch.NativeMethodInfoPtr__get_PlayerNameData_b__81_0_Private_AccountIDUsernameMetadata_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663497);
			WormMatch.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_PlayerEntity_PlayerEntity_Dictionary_2_PlayerEntity_List_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, 100663498);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0006AB98 File Offset: 0x00068D98
		public unsafe override IMessageActionFactory MessageActionFactory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_get_MessageActionFactory_Public_Virtual_get_IMessageActionFactory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageActionFactory>(intPtr3) : null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0006ABE4 File Offset: 0x00068DE4
		public unsafe WormPlaymat WormPlaymat
		{
			[CallerCount(694)]
			[CachedScanResults(RefRangeStart = 26256, RefRangeEnd = 26950, XrefRangeStart = 26254, XrefRangeEnd = 26256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_WormPlaymat_Public_get_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr3) : null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0006AC24 File Offset: 0x00068E24
		public unsafe virtual ActiveAbility ActiveAbility
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 26963, RefRangeEnd = 26991, XrefRangeStart = 26950, XrefRangeEnd = 26963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_ActiveAbility_Public_Virtual_Final_New_get_ActiveAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActiveAbility>(intPtr3) : null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0006AC64 File Offset: 0x00068E64
		public unsafe virtual IEnumerable<ActiveAbility> AbilityStack
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26991, XrefRangeEnd = 27001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_AbilityStack_Public_Virtual_Final_New_get_IEnumerable_1_ActiveAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ActiveAbility>>(intPtr3) : null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0006ACA4 File Offset: 0x00068EA4
		public unsafe virtual WormArchetypes Archetypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_Archetypes_Public_Virtual_Final_New_get_WormArchetypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormArchetypes>(intPtr3) : null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0006ACE4 File Offset: 0x00068EE4
		public unsafe virtual Archetypes SimpleArchetypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_SimpleArchetypes_Public_Virtual_Final_New_get_Archetypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetypes>(intPtr3) : null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0006AD24 File Offset: 0x00068F24
		public unsafe override bool ShouldIncludeAccountIDOnMessage
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_get_ShouldIncludeAccountIDOnMessage_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0006AD6C File Offset: 0x00068F6C
		public unsafe int ConflictRewardsAllowed
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 27003, RefRangeEnd = 27012, XrefRangeStart = 27001, XrefRangeEnd = 27003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_ConflictRewardsAllowed_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0006ADA8 File Offset: 0x00068FA8
		public unsafe Il2CppStructArray<Set> EnabledSets
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 27027, RefRangeEnd = 27037, XrefRangeStart = 27012, XrefRangeEnd = 27027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_EnabledSets_Public_get_Il2CppStructArray_1_Set_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Set>>(intPtr3) : null;
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0006ADE8 File Offset: 0x00068FE8
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 27041, RefRangeEnd = 27074, XrefRangeStart = 27037, XrefRangeEnd = 27041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSetEnabled(Set set)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref set;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_IsSetEnabled_Public_Boolean_Set_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0006AE34 File Offset: 0x00069034
		[CallerCount(0)]
		public unsafe override Object GetArchetypesLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_GetArchetypesLock_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0006AE80 File Offset: 0x00069080
		public unsafe IEnumerable<WormPlayer> PlayerTurnOrder
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 27096, RefRangeEnd = 27108, XrefRangeStart = 27074, XrefRangeEnd = 27096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_PlayerTurnOrder_Public_get_IEnumerable_1_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0006AEC0 File Offset: 0x000690C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 27115, RefRangeEnd = 27122, XrefRangeStart = 27108, XrefRangeEnd = 27115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormPlayer> FindPlayerTurnOrder(Func<WormPlayer, bool> findInitialPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(findInitialPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_FindPlayerTurnOrder_Public_IEnumerable_1_WormPlayer_Func_2_WormPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0006AF10 File Offset: 0x00069110
		public unsafe override bool IsEvent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27122, XrefRangeEnd = 27130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_get_IsEvent_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0006AF58 File Offset: 0x00069158
		public unsafe override EventID GetEventID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27130, XrefRangeEnd = 27138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_get_GetEventID_Public_Virtual_get_EventID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr3) : null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0006AFA4 File Offset: 0x000691A4
		public unsafe override RoundID GetRoundID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27138, XrefRangeEnd = 27146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_get_GetRoundID_Public_Virtual_get_RoundID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RoundID>(intPtr3) : null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0006AFF0 File Offset: 0x000691F0
		public unsafe override bool SkipLiveReplay
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_get_SkipLiveReplay_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0006B038 File Offset: 0x00069238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27146, XrefRangeEnd = 27170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0006B074 File Offset: 0x00069274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27170, XrefRangeEnd = 27175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool validForDisplayAction(DWDEvent message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_validForDisplayAction_Protected_Virtual_Boolean_DWDEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0006B0CC File Offset: 0x000692CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27175, XrefRangeEnd = 27214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Configure(MatchInitData wormMatchInitData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatchInitData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_Configure_Public_Virtual_Void_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0006B11C File Offset: 0x0006931C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27214, XrefRangeEnd = 27218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Entity GenPlaymat(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_GenPlaymat_Protected_Virtual_Entity_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0006B178 File Offset: 0x00069378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27218, XrefRangeEnd = 27222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Entity GenPlaymat(SerializedEntity entities, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_GenPlaymat_Protected_Virtual_Entity_SerializedEntity_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0006B1E8 File Offset: 0x000693E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27222, XrefRangeEnd = 27226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override global::Canis.actions.Action GenInitialAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_GenInitialAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0006B244 File Offset: 0x00069444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27226, XrefRangeEnd = 27232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override global::Canis.actions.Action GenResumeAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_GenResumeAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0006B2A0 File Offset: 0x000694A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27232, XrefRangeEnd = 27248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override global::Canis.actions.Action StartNewMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_StartNewMatch_Protected_Virtual_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0006B2EC File Offset: 0x000694EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27248, XrefRangeEnd = 27268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeNewMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_InitializeNewMatch_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0006B328 File Offset: 0x00069528
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReinitializeMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_ReinitializeMatch_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0006B364 File Offset: 0x00069564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27268, XrefRangeEnd = 27306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CleanupGameFailure()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_CleanupGameFailure_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0006B3A0 File Offset: 0x000695A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27306, XrefRangeEnd = 27430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CreatePlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_CreatePlayers_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0006B3DC File Offset: 0x000695DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27430, XrefRangeEnd = 27526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializePlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_InitializePlayers_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0006B418 File Offset: 0x00069618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27526, XrefRangeEnd = 27542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PlayerTutorialInit(bool isReload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isReload;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_PlayerTutorialInit_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0006B464 File Offset: 0x00069664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 27591, RefRangeEnd = 27592, XrefRangeStart = 27542, XrefRangeEnd = 27591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadRuleMods()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_LoadRuleMods_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0006B498 File Offset: 0x00069698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27592, XrefRangeEnd = 27632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetScenarioAction(bool isResume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isResume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_SetScenarioAction_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0006B4E4 File Offset: 0x000696E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27632, XrefRangeEnd = 27636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldStoreGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_ShouldStoreGame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0006B520 File Offset: 0x00069720
		public unsafe bool IsRestart
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_IsRestart_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0006B55C File Offset: 0x0006975C
		[CallerCount(89)]
		[CachedScanResults(RefRangeStart = 27637, RefRangeEnd = 27726, XrefRangeStart = 27636, XrefRangeEnd = 27637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsScenario(string scenario)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(scenario);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_IsScenario_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0006B5AC File Offset: 0x000697AC
		[CallerCount(0)]
		public unsafe override bool IsGameOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_IsGameOver_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0006B5F4 File Offset: 0x000697F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27726, XrefRangeEnd = 27745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsMatchOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_IsMatchOver_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0006B63C File Offset: 0x0006983C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 27786, RefRangeEnd = 27792, XrefRangeStart = 27745, XrefRangeEnd = 27786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEndgame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_IsEndgame_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0006B678 File Offset: 0x00069878
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 27889, RefRangeEnd = 27892, XrefRangeStart = 27792, XrefRangeEnd = 27889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WormPlayer> GetEndgamePlayerOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_GetEndgamePlayerOrder_Public_List_1_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WormPlayer>>(intPtr3) : null;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0006B6B8 File Offset: 0x000698B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 27892, XrefRangeEnd = 27911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEntity GetWinner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_GetWinner_Public_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0006B6F8 File Offset: 0x000698F8
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 27913, RefRangeEnd = 27932, XrefRangeStart = 27911, XrefRangeEnd = 27913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe WormPlayer CurrentPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_CurrentPlayer_Public_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0006B738 File Offset: 0x00069938
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 27932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayer NextPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_NextPlayer_Public_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0006B778 File Offset: 0x00069978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28006, XrefRangeEnd = 28016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override global::Canis.actions.Action GetGameResults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_GetGameResults_Public_Virtual_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0006B7C4 File Offset: 0x000699C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28488, RefRangeEnd = 28489, XrefRangeStart = 28016, XrefRangeEnd = 28488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormGameResultsEntry MakePlayerGameResults(WormPlayer player, int position, int playerCountTotal, int hagalCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerCountTotal;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hagalCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_MakePlayerGameResults_Private_WormGameResultsEntry_WormPlayer_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormGameResultsEntry>(intPtr3) : null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0006B840 File Offset: 0x00069A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28489, XrefRangeEnd = 28605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DBGGameResults getGameResults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_getGameResults_Public_Virtual_DBGGameResults_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGGameResults>(intPtr3) : null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0006B88C File Offset: 0x00069A8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 28794, RefRangeEnd = 28795, XrefRangeStart = 28605, XrefRangeEnd = 28794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GameOverAchievementsForPlayer(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_GameOverAchievementsForPlayer_Public_List_1_String_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0006B8DC File Offset: 0x00069ADC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 28808, RefRangeEnd = 28811, XrefRangeStart = 28795, XrefRangeEnd = 28808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetGameType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_GetGameType_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0006B914 File Offset: 0x00069B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28811, XrefRangeEnd = 28825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override global::Canis.actions.Action passToPlayerAction(PlayerEntity player, bool forced = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_passToPlayerAction_Public_Virtual_Action_PlayerEntity_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0006B980 File Offset: 0x00069B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28825, XrefRangeEnd = 28826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleResignGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_HandleResignGame_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0006B9BC File Offset: 0x00069BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28826, XrefRangeEnd = 28885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleIdleResignFromGame(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_HandleIdleResignFromGame_Public_Virtual_Void_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0006BA0C File Offset: 0x00069C0C
		[CallerCount(0)]
		public unsafe override bool HasResigned(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_HasResigned_Public_Virtual_Boolean_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0006BA64 File Offset: 0x00069C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 28885, XrefRangeEnd = 28975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LogAnalyticsGameStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_LogAnalyticsGameStart_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0006BAA0 File Offset: 0x00069CA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29190, RefRangeEnd = 29192, XrefRangeStart = 28975, XrefRangeEnd = 29190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void logGameOverAnalytics(Il2CppReferenceArray<WormGameResultsEntry> results, WormPlaymat wormPlaymat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(results);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wormPlaymat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_logGameOverAnalytics_Private_Void_Il2CppReferenceArray_1_WormGameResultsEntry_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0006BAF4 File Offset: 0x00069CF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29251, RefRangeEnd = 29253, XrefRangeStart = 29192, XrefRangeEnd = 29251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void logAnalyticsResign(bool wasTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wasTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_logAnalyticsResign_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0006BB34 File Offset: 0x00069D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29253, XrefRangeEnd = 29282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerType GetPlayerType(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_GetPlayerType_Private_PlayerType_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerType>(intPtr3) : null;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0006BB84 File Offset: 0x00069D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29282, XrefRangeEnd = 29295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsInPlay(Entity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0006BBDC File Offset: 0x00069DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29295, XrefRangeEnd = 29299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override global::Canis.actions.Action GetPreAIDecisionAction(SelectionMessage selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_GetPreAIDecisionAction_Public_Virtual_Action_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008D RID: 141 RVA: 0x0006BC38 File Offset: 0x00069E38
		public unsafe List<AccountIDUsernameMetadata> PlayerNameData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29299, XrefRangeEnd = 29312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_PlayerNameData_Public_get_List_1_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<AccountIDUsernameMetadata>>(intPtr3) : null;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0006BC78 File Offset: 0x00069E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29312, XrefRangeEnd = 29327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PlayerEntity GetPlayerEntity(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_GetPlayerEntity_Public_Virtual_PlayerEntity_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0006BCD4 File Offset: 0x00069ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29327, XrefRangeEnd = 29358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Entity CreateEntity(SerializedEntity se, Match m, Entity parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_SerializedEntity_Match_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0006BD54 File Offset: 0x00069F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29358, XrefRangeEnd = 29367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override T GetPlayerByIndex<T>(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.MethodInfoStoreGeneric_GetPlayerByIndex_Public_Virtual_T_Int32_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0006BDA8 File Offset: 0x00069FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29367, XrefRangeEnd = 29368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCleanupGame(Func<List<AccountID>, WormGameResults, Task> cleanup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cleanup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_SetCleanupGame_Public_Virtual_Final_New_Void_Func_3_List_1_AccountID_WormGameResults_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0006BDEC File Offset: 0x00069FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29368, XrefRangeEnd = 29384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GameOverCleanup(List<AccountID> playerIDs, DBGGameResults gameResults)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerIDs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameResults);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_GameOverCleanup_Public_Virtual_Void_List_1_AccountID_DBGGameResults_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0006BE4C File Offset: 0x0006A04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29384, XrefRangeEnd = 29392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<global::Canis.actions.Action> PreProcessPlayerChoiceWithPlayer(SelectionMessage selection, PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_PreProcessPlayerChoiceWithPlayer_Public_Virtual_IEnumerable_1_Action_SelectionMessage_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0006BEBC File Offset: 0x0006A0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29392, XrefRangeEnd = 29398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<IAttribute> MakeObfuscatedMovePublicData(Entity movingEntity, EntityID sourceID, EntityID destinationID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(movingEntity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destinationID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_MakeObfuscatedMovePublicData_Public_Virtual_IEnumerable_1_IAttribute_Entity_EntityID_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0006BF3C File Offset: 0x0006A13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29398, XrefRangeEnd = 29422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<string, string> GetAdditionalPlayerMetadata(PlayerEntity playerEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_GetAdditionalPlayerMetadata_Public_Virtual_Dictionary_2_String_String_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0006BF98 File Offset: 0x0006A198
		public unsafe IEnumerable<WormPlayer> HagalMultiTurnOrder
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29444, RefRangeEnd = 29446, XrefRangeStart = 29422, XrefRangeEnd = 29444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_HagalMultiTurnOrder_Public_get_IEnumerable_1_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0006BFD8 File Offset: 0x0006A1D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 29453, RefRangeEnd = 29455, XrefRangeStart = 29446, XrefRangeEnd = 29453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormPlayer> FindHagalMultiTurnOrder(Func<WormPlayer, bool> findInitialPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(findInitialPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_FindHagalMultiTurnOrder_Public_IEnumerable_1_WormPlayer_Func_2_WormPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0006C028 File Offset: 0x0006A228
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29455, XrefRangeEnd = 29463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<PlayerEntity> ClearDisplayActionsOnSave(PlayerEntity lastRespondingPlayer, Dictionary<PlayerEntity, List<PendingSelection>> allPendingSelections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastRespondingPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allPendingSelections);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_ClearDisplayActionsOnSave_Public_Virtual_IEnumerable_1_PlayerEntity_PlayerEntity_Dictionary_2_PlayerEntity_List_1_PendingSelection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0006C098 File Offset: 0x0006A298
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 29468, RefRangeEnd = 29472, XrefRangeStart = 29463, XrefRangeEnd = 29468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSkirmishRuleMod(int ruleID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ruleID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_HasSkirmishRuleMod_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0006C0E4 File Offset: 0x0006A2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29472, XrefRangeEnd = 29488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ActiveAbility PushNewAbility([Optional] Il2CppReferenceArray<Object> parameters)
		{
			if (parameters == null)
			{
				parameters = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_PushNewAbility_Public_Virtual_Final_New_ActiveAbility_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActiveAbility>(intPtr3) : null;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0006C144 File Offset: 0x0006A344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29488, XrefRangeEnd = 29492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual global::Canis.actions.Action PopAbility(ActiveAbility ability)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_PopAbility_Public_Virtual_Final_New_Action_ActiveAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0006C194 File Offset: 0x0006A394
		public unsafe IEnumerable<ITriggeredAbility> InstalledTriggeredAbilities
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29563, RefRangeEnd = 29564, XrefRangeStart = 29492, XrefRangeEnd = 29563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_InstalledTriggeredAbilities_Public_get_IEnumerable_1_ITriggeredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ITriggeredAbility>>(intPtr3) : null;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0006C1D4 File Offset: 0x0006A3D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29564, XrefRangeEnd = 29565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<ITriggeredAbility> GetInstalledTriggers(Event evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_GetInstalledTriggers_Public_Virtual_Final_New_IEnumerable_1_ITriggeredAbility_Event_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ITriggeredAbility>>(intPtr3) : null;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0006C224 File Offset: 0x0006A424
		// (set) Token: 0x0600009F RID: 159 RVA: 0x0006C264 File Offset: 0x0006A464
		public unsafe virtual GameLogManager GameLogManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_GameLogManager_Public_Virtual_Final_New_get_GameLogManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogManager>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29565, XrefRangeEnd = 29566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_set_GameLogManager_Private_set_Void_GameLogManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0006C2A8 File Offset: 0x0006A4A8
		public unsafe LogStack LogStack
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 29568, RefRangeEnd = 29583, XrefRangeStart = 29566, XrefRangeEnd = 29568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_LogStack_Public_get_LogStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogStack>(intPtr3) : null;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0006C2E8 File Offset: 0x0006A4E8
		public unsafe virtual UndoNode GameLogUndoNode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29583, XrefRangeEnd = 29598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_GameLogUndoNode_Public_Virtual_Final_New_get_UndoNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0006C328 File Offset: 0x0006A528
		public unsafe virtual IEnumerable<SerializedGameLog> StoredGameLogs
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29598, XrefRangeEnd = 29601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_StoredGameLogs_Public_Virtual_Final_New_get_IEnumerable_1_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SerializedGameLog>>(intPtr3) : null;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0006C368 File Offset: 0x0006A568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29601, XrefRangeEnd = 29617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SerializedGameLog GetStoredLog(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_GetStoredLog_Public_Virtual_Final_New_SerializedGameLog_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0006C3B4 File Offset: 0x0006A5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29617, XrefRangeEnd = 29622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SerializedGameLog StoreGameLog(GameLogBuilder logBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(logBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_StoreGameLog_Public_Virtual_Final_New_SerializedGameLog_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0006C404 File Offset: 0x0006A604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29622, XrefRangeEnd = 29623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StoreGameLog(SerializedGameLog log)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_StoreGameLog_Public_Virtual_Final_New_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0006C454 File Offset: 0x0006A654
		[CallerCount(75)]
		[CachedScanResults(RefRangeStart = 29636, RefRangeEnd = 29711, XrefRangeStart = 29623, XrefRangeEnd = 29636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameLogBuilder MakeGameLogBuilder(string logToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logToken);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_Final_New_GameLogBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0006C4A4 File Offset: 0x0006A6A4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 29725, RefRangeEnd = 29748, XrefRangeStart = 29711, XrefRangeEnd = 29725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameLogBuilder MakeGameLogBuilder(string logToken, GameLogBuilderFactoryData param)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logToken);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref param;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_Final_New_GameLogBuilder_String_GameLogBuilderFactoryData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0006C504 File Offset: 0x0006A704
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AILog(PlayerEntity player, string text, string color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_AILog_Public_Virtual_Void_PlayerEntity_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0006C578 File Offset: 0x0006A778
		public unsafe override TimerModes TimerMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_get_TimerMode_Public_Virtual_get_TimerModes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0006C5C0 File Offset: 0x0006A7C0
		public unsafe override int TimerLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29750, XrefRangeEnd = 29756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMatch.NativeMethodInfoPtr_get_TimerLength_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0006C608 File Offset: 0x0006A808
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 29758, RefRangeEnd = 29761, XrefRangeStart = 29756, XrefRangeEnd = 29758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Entity GetUndoEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_GetUndoEntity_Public_Virtual_Final_New_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0006C648 File Offset: 0x0006A848
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Entity GetRedoEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_GetRedoEntity_Public_Virtual_Final_New_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0006C688 File Offset: 0x0006A888
		public unsafe virtual bool StoreLastCompletedSelection
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_get_StoreLastCompletedSelection_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0006C6C4 File Offset: 0x0006A8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29761, XrefRangeEnd = 29763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GameSpecificUndoIsAvailable(PlayerEntity selectingPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_GameSpecificUndoIsAvailable_Public_Virtual_Final_New_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0006C714 File Offset: 0x0006A914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29763, XrefRangeEnd = 29770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<ValueTuple<string, Object>> MakeAnalyticsData(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<string, Object>>>(intPtr3) : null;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0006C764 File Offset: 0x0006A964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29770, XrefRangeEnd = 29778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> GameSpecificUndoBehavior(PlayerEntity undoPlayer, UndoNode undoNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(undoNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_GameSpecificUndoBehavior_Public_Virtual_Final_New_IEnumerable_1_Action_PlayerEntity_UndoNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0006C7C8 File Offset: 0x0006A9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29778, XrefRangeEnd = 29787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual global::Canis.actions.Action AddUndoNode(UndoNode undoNode, UndoNode parentUndoNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentUndoNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_AddUndoNode_Public_Virtual_Final_New_Action_UndoNode_UndoNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0006C82C File Offset: 0x0006AA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29787, XrefRangeEnd = 29817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual global::Canis.actions.Action RemoveUndoNode(UndoNode undoNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_RemoveUndoNode_Public_Virtual_Final_New_Action_UndoNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0006C87C File Offset: 0x0006AA7C
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 29824, RefRangeEnd = 29875, XrefRangeStart = 29817, XrefRangeEnd = 29824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> AddSequenceToUndoNode(UndoNode undoNode, SequenceHelper sequenceHelper)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(undoNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sequenceHelper);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_AddSequenceToUndoNode_Public_IEnumerable_1_Action_UndoNode_SequenceHelper_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0006C8E0 File Offset: 0x0006AAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29875, XrefRangeEnd = 29898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Method_Private_Int32_WormPlayer_PDM_0(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_Method_Private_Int32_WormPlayer_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0006C930 File Offset: 0x0006AB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29898, XrefRangeEnd = 29921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Method_Private_Int32_WormPlayer_PDM_1(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr_Method_Private_Int32_WormPlayer_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0006C980 File Offset: 0x0006AB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29921, XrefRangeEnd = 29950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerType _logGameOverAnalytics_b__75_3(WormGameResultsEntry player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr__logGameOverAnalytics_b__75_3_Private_PlayerType_WormGameResultsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerType>(intPtr3) : null;
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0006C9D0 File Offset: 0x0006ABD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 29950, XrefRangeEnd = 30031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountIDUsernameMetadata _get_PlayerNameData_b__81_0(WormPlayer p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr__get_PlayerNameData_b__81_0_Private_AccountIDUsernameMetadata_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountIDUsernameMetadata>(intPtr3) : null;
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0006CA20 File Offset: 0x0006AC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 30031, XrefRangeEnd = 30032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<PlayerEntity> __n__0(PlayerEntity lastRespondingPlayer, Dictionary<PlayerEntity, List<PendingSelection>> allPendingSelections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastRespondingPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allPendingSelections);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.NativeMethodInfoPtr___n__0_Private_IEnumerable_1_PlayerEntity_PlayerEntity_Dictionary_2_PlayerEntity_List_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000021DE File Offset: 0x000003DE
		public virtual ActiveAbility PushNewAbility(params Object[] parameters)
		{
			return this.PushNewAbility(new Il2CppReferenceArray<Object>(parameters));
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000021EC File Offset: 0x000003EC
		public WormMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0006CA84 File Offset: 0x0006AC84
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000021F5 File Offset: 0x000003F5
		public unsafe WormArchetypes _Archetypes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr__Archetypes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormArchetypes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr__Archetypes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0006CAB4 File Offset: 0x0006ACB4
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00002214 File Offset: 0x00000414
		public unsafe Func<List<AccountID>, WormGameResults, Task> CleanupGame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr_CleanupGame);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<List<AccountID>, WormGameResults, Task>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr_CleanupGame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0006CAE4 File Offset: 0x0006ACE4
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002233 File Offset: 0x00000433
		public new unsafe List<AccountID> disconnectedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr_disconnectedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr_disconnectedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0006CB14 File Offset: 0x0006AD14
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002252 File Offset: 0x00000452
		public unsafe WormTutorialScript scenarioScript
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr_scenarioScript);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTutorialScript>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr_scenarioScript), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0006CB44 File Offset: 0x0006AD44
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002271 File Offset: 0x00000471
		public unsafe global::Canis.actions.Action scenarioAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr_scenarioAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr_scenarioAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0006CB74 File Offset: 0x0006AD74
		// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002290 File Offset: 0x00000490
		public unsafe WormMatchInitData wormmid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr_wormmid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr_wormmid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0006CBA4 File Offset: 0x0006ADA4
		// (set) Token: 0x060000C8 RID: 200 RVA: 0x000022AF File Offset: 0x000004AF
		public unsafe IMessageActionFactory messageActionFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr_messageActionFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageActionFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr_messageActionFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0006CBD4 File Offset: 0x0006ADD4
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000022CE File Offset: 0x000004CE
		public unsafe GameLogManager _GameLogManager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr__GameLogManager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.NativeFieldInfoPtr__GameLogManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr__Archetypes_k__BackingField;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_CleanupGame;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_disconnectedPlayers;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_scenarioScript;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_scenarioAction;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_wormmid;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_messageActionFactory;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr__GameLogManager_k__BackingField;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageActionFactory_Public_Virtual_get_IMessageActionFactory_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_get_WormPlaymat_Public_get_WormPlaymat_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAbility_Public_Virtual_Final_New_get_ActiveAbility_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilityStack_Public_Virtual_Final_New_get_IEnumerable_1_ActiveAbility_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_get_Archetypes_Public_Virtual_Final_New_get_WormArchetypes_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_SimpleArchetypes_Public_Virtual_Final_New_get_Archetypes_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldIncludeAccountIDOnMessage_Public_Virtual_get_Boolean_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_get_ConflictRewardsAllowed_Public_get_Int32_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_get_EnabledSets_Public_get_Il2CppStructArray_1_Set_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_IsSetEnabled_Public_Boolean_Set_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_GetArchetypesLock_Public_Virtual_Object_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerTurnOrder_Public_get_IEnumerable_1_WormPlayer_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_FindPlayerTurnOrder_Public_IEnumerable_1_WormPlayer_Func_2_WormPlayer_Boolean_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEvent_Public_Virtual_get_Boolean_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_get_GetEventID_Public_Virtual_get_EventID_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_get_GetRoundID_Public_Virtual_get_RoundID_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_get_SkipLiveReplay_Public_Virtual_get_Boolean_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_validForDisplayAction_Protected_Virtual_Boolean_DWDEvent_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_Void_MatchInitData_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_GenPlaymat_Protected_Virtual_Entity_Match_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_GenPlaymat_Protected_Virtual_Entity_SerializedEntity_Match_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_GenInitialAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_GenResumeAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_StartNewMatch_Protected_Virtual_Action_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_InitializeNewMatch_Protected_Virtual_Void_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_ReinitializeMatch_Protected_Virtual_Void_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_CleanupGameFailure_Protected_Virtual_Void_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayers_Protected_Virtual_Void_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_InitializePlayers_Protected_Virtual_Void_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_PlayerTutorialInit_Protected_Virtual_Void_Boolean_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_LoadRuleMods_Private_Void_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_SetScenarioAction_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_ShouldStoreGame_Public_Boolean_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRestart_Public_get_Boolean_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_IsScenario_Public_Boolean_String_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_IsGameOver_Public_Virtual_Boolean_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchOver_Public_Virtual_Boolean_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_IsEndgame_Public_Boolean_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_GetEndgamePlayerOrder_Public_List_1_WormPlayer_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_GetWinner_Public_PlayerEntity_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_CurrentPlayer_Public_WormPlayer_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_NextPlayer_Public_WormPlayer_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_GetGameResults_Public_Virtual_Action_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_MakePlayerGameResults_Private_WormGameResultsEntry_WormPlayer_Int32_Int32_Int32_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_getGameResults_Public_Virtual_DBGGameResults_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_GameOverAchievementsForPlayer_Public_List_1_String_WormPlayer_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_GetGameType_Private_String_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_passToPlayerAction_Public_Virtual_Action_PlayerEntity_Boolean_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_HandleResignGame_Public_Virtual_Void_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_HandleIdleResignFromGame_Public_Virtual_Void_AccountID_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_HasResigned_Public_Virtual_Boolean_AccountID_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_LogAnalyticsGameStart_Protected_Virtual_Void_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_logGameOverAnalytics_Private_Void_Il2CppReferenceArray_1_WormGameResultsEntry_WormPlaymat_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_logAnalyticsResign_Private_Void_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerType_Private_PlayerType_PlayerEntity_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_IsInPlay_Public_Virtual_Boolean_Entity_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_GetPreAIDecisionAction_Public_Virtual_Action_SelectionMessage_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerNameData_Public_get_List_1_AccountIDUsernameMetadata_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerEntity_Public_Virtual_PlayerEntity_AccountID_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntity_Public_Virtual_Entity_SerializedEntity_Match_Entity_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerByIndex_Public_Virtual_T_Int32_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_SetCleanupGame_Public_Virtual_Final_New_Void_Func_3_List_1_AccountID_WormGameResults_Task_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_GameOverCleanup_Public_Virtual_Void_List_1_AccountID_DBGGameResults_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_PreProcessPlayerChoiceWithPlayer_Public_Virtual_IEnumerable_1_Action_SelectionMessage_PlayerEntity_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_MakeObfuscatedMovePublicData_Public_Virtual_IEnumerable_1_IAttribute_Entity_EntityID_EntityID_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalPlayerMetadata_Public_Virtual_Dictionary_2_String_String_PlayerEntity_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_HagalMultiTurnOrder_Public_get_IEnumerable_1_WormPlayer_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_FindHagalMultiTurnOrder_Public_IEnumerable_1_WormPlayer_Func_2_WormPlayer_Boolean_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_ClearDisplayActionsOnSave_Public_Virtual_IEnumerable_1_PlayerEntity_PlayerEntity_Dictionary_2_PlayerEntity_List_1_PendingSelection_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_HasSkirmishRuleMod_Public_Boolean_Int32_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_PushNewAbility_Public_Virtual_Final_New_ActiveAbility_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_PopAbility_Public_Virtual_Final_New_Action_ActiveAbility_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_get_InstalledTriggeredAbilities_Public_get_IEnumerable_1_ITriggeredAbility_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_GetInstalledTriggers_Public_Virtual_Final_New_IEnumerable_1_ITriggeredAbility_Event_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_get_GameLogManager_Public_Virtual_Final_New_get_GameLogManager_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_set_GameLogManager_Private_set_Void_GameLogManager_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_get_LogStack_Public_get_LogStack_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_get_GameLogUndoNode_Public_Virtual_Final_New_get_UndoNode_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_get_StoredGameLogs_Public_Virtual_Final_New_get_IEnumerable_1_SerializedGameLog_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_GetStoredLog_Public_Virtual_Final_New_SerializedGameLog_Int32_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_StoreGameLog_Public_Virtual_Final_New_SerializedGameLog_GameLogBuilder_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_StoreGameLog_Public_Virtual_Final_New_Boolean_SerializedGameLog_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_Final_New_GameLogBuilder_String_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_Final_New_GameLogBuilder_String_GameLogBuilderFactoryData_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_AILog_Public_Virtual_Void_PlayerEntity_String_String_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_get_TimerMode_Public_Virtual_get_TimerModes_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_TimerLength_Public_Virtual_get_Int32_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_GetUndoEntity_Public_Virtual_Final_New_Entity_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_GetRedoEntity_Public_Virtual_Final_New_Entity_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_get_StoreLastCompletedSelection_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_GameSpecificUndoIsAvailable_Public_Virtual_Final_New_Boolean_PlayerEntity_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_MakeAnalyticsData_Private_IEnumerable_1_ValueTuple_2_String_Object_WormPlayer_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_GameSpecificUndoBehavior_Public_Virtual_Final_New_IEnumerable_1_Action_PlayerEntity_UndoNode_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_AddUndoNode_Public_Virtual_Final_New_Action_UndoNode_UndoNode_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_RemoveUndoNode_Public_Virtual_Final_New_Action_UndoNode_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_AddSequenceToUndoNode_Public_IEnumerable_1_Action_UndoNode_SequenceHelper_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Int32_WormPlayer_PDM_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Int32_WormPlayer_PDM_1;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr__logGameOverAnalytics_b__75_3_Private_PlayerType_WormGameResultsEntry_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr__get_PlayerNameData_b__81_0_Private_AccountIDUsernameMetadata_WormPlayer_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerable_1_PlayerEntity_PlayerEntity_Dictionary_2_PlayerEntity_List_1_PendingSelection_0;

		// Token: 0x0200055A RID: 1370
		[ObfuscatedName("worm.canis.WormMatch+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004122 RID: 16674 RVA: 0x0017888C File Offset: 0x00176A8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr);
				WormMatch.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9");
				WormMatch.__c.NativeFieldInfoPtr___9__28_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__28_0");
				WormMatch.__c.NativeFieldInfoPtr___9__48_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__48_0");
				WormMatch.__c.NativeFieldInfoPtr___9__48_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__48_1");
				WormMatch.__c.NativeFieldInfoPtr___9__49_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__49_0");
				WormMatch.__c.NativeFieldInfoPtr___9__49_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__49_1");
				WormMatch.__c.NativeFieldInfoPtr___9__49_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__49_2");
				WormMatch.__c.NativeFieldInfoPtr___9__59_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__59_0");
				WormMatch.__c.NativeFieldInfoPtr___9__61_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__61_7");
				WormMatch.__c.NativeFieldInfoPtr___9__61_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__61_2");
				WormMatch.__c.NativeFieldInfoPtr___9__61_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__61_3");
				WormMatch.__c.NativeFieldInfoPtr___9__61_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__61_4");
				WormMatch.__c.NativeFieldInfoPtr___9__61_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__61_5");
				WormMatch.__c.NativeFieldInfoPtr___9__61_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__61_6");
				WormMatch.__c.NativeFieldInfoPtr___9__62_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__62_0");
				WormMatch.__c.NativeFieldInfoPtr___9__66_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__66_0");
				WormMatch.__c.NativeFieldInfoPtr___9__66_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__66_1");
				WormMatch.__c.NativeFieldInfoPtr___9__67_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__67_0");
				WormMatch.__c.NativeFieldInfoPtr___9__67_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__67_1");
				WormMatch.__c.NativeFieldInfoPtr___9__67_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__67_3");
				WormMatch.__c.NativeFieldInfoPtr___9__68_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__68_1");
				WormMatch.__c.NativeFieldInfoPtr___9__68_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__68_2");
				WormMatch.__c.NativeFieldInfoPtr___9__68_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__68_3");
				WormMatch.__c.NativeFieldInfoPtr___9__72_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__72_0");
				WormMatch.__c.NativeFieldInfoPtr___9__72_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__72_1");
				WormMatch.__c.NativeFieldInfoPtr___9__75_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__75_0");
				WormMatch.__c.NativeFieldInfoPtr___9__75_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__75_1");
				WormMatch.__c.NativeFieldInfoPtr___9__75_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__75_2");
				WormMatch.__c.NativeFieldInfoPtr___9__75_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__75_4");
				WormMatch.__c.NativeFieldInfoPtr___9__75_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__75_5");
				WormMatch.__c.NativeFieldInfoPtr___9__91_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__91_0");
				WormMatch.__c.NativeFieldInfoPtr___9__92_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__92_0");
				WormMatch.__c.NativeFieldInfoPtr___9__92_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__92_1");
				WormMatch.__c.NativeFieldInfoPtr___9__98_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__98_0");
				WormMatch.__c.NativeFieldInfoPtr___9__98_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, "<>9__98_1");
				WormMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663500);
				WormMatch.__c.NativeMethodInfoPtr__get_PlayerTurnOrder_b__28_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663501);
				WormMatch.__c.NativeMethodInfoPtr__CleanupGameFailure_b__48_0_Internal_AccountID_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663502);
				WormMatch.__c.NativeMethodInfoPtr__CleanupGameFailure_b__48_1_Internal_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663503);
				WormMatch.__c.NativeMethodInfoPtr__CreatePlayers_b__49_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663504);
				WormMatch.__c.NativeMethodInfoPtr__CreatePlayers_b__49_1_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663505);
				WormMatch.__c.NativeMethodInfoPtr__CreatePlayers_b__49_2_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663506);
				WormMatch.__c.NativeMethodInfoPtr__IsMatchOver_b__59_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663507);
				WormMatch.__c.NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_7_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663508);
				WormMatch.__c.NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_2_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663509);
				WormMatch.__c.NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_3_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663510);
				WormMatch.__c.NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_4_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663511);
				WormMatch.__c.NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_5_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663512);
				WormMatch.__c.NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_6_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663513);
				WormMatch.__c.NativeMethodInfoPtr__GetWinner_b__62_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663514);
				WormMatch.__c.NativeMethodInfoPtr__MakePlayerGameResults_b__66_0_Internal_Factions_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663515);
				WormMatch.__c.NativeMethodInfoPtr__MakePlayerGameResults_b__66_1_Internal_Factions_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663516);
				WormMatch.__c.NativeMethodInfoPtr__getGameResults_b__67_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663517);
				WormMatch.__c.NativeMethodInfoPtr__getGameResults_b__67_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663518);
				WormMatch.__c.NativeMethodInfoPtr__getGameResults_b__67_3_Internal_String_Set_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663519);
				WormMatch.__c.NativeMethodInfoPtr__GameOverAchievementsForPlayer_b__68_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663520);
				WormMatch.__c.NativeMethodInfoPtr__GameOverAchievementsForPlayer_b__68_2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663521);
				WormMatch.__c.NativeMethodInfoPtr__GameOverAchievementsForPlayer_b__68_3_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663522);
				WormMatch.__c.NativeMethodInfoPtr__HandleIdleResignFromGame_b__72_0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663523);
				WormMatch.__c.NativeMethodInfoPtr__HandleIdleResignFromGame_b__72_1_Internal_AccountID_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663524);
				WormMatch.__c.NativeMethodInfoPtr__logGameOverAnalytics_b__75_0_Internal_Int32_WormGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663525);
				WormMatch.__c.NativeMethodInfoPtr__logGameOverAnalytics_b__75_1_Internal_Int32_WormGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663526);
				WormMatch.__c.NativeMethodInfoPtr__logGameOverAnalytics_b__75_2_Internal_LocalizableText_WormGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663527);
				WormMatch.__c.NativeMethodInfoPtr__logGameOverAnalytics_b__75_4_Internal_LocalizableText_WormGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663528);
				WormMatch.__c.NativeMethodInfoPtr__logGameOverAnalytics_b__75_5_Internal_Dictionary_2_LocalizableTextVariables_Int32_WormGameResultsEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663529);
				WormMatch.__c.NativeMethodInfoPtr__get_HagalMultiTurnOrder_b__91_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663530);
				WormMatch.__c.NativeMethodInfoPtr__FindHagalMultiTurnOrder_b__92_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663531);
				WormMatch.__c.NativeMethodInfoPtr__FindHagalMultiTurnOrder_b__92_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663532);
				WormMatch.__c.NativeMethodInfoPtr__get_InstalledTriggeredAbilities_b__98_0_Internal_IEnumerable_1_TriggeredAbility_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663533);
				WormMatch.__c.NativeMethodInfoPtr__get_InstalledTriggeredAbilities_b__98_1_Internal_Boolean_TriggeredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr, 100663534);
			}

			// Token: 0x06004123 RID: 16675 RVA: 0x00178E30 File Offset: 0x00177030
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004124 RID: 16676 RVA: 0x00178E6C File Offset: 0x0017706C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25566, XrefRangeEnd = 25574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_PlayerTurnOrder_b__28_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__get_PlayerTurnOrder_b__28_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004125 RID: 16677 RVA: 0x00178EBC File Offset: 0x001770BC
			[CallerCount(0)]
			public unsafe AccountID _CleanupGameFailure_b__48_0(PlayerMatchInitData pmid)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(pmid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__CleanupGameFailure_b__48_0_Internal_AccountID_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x06004126 RID: 16678 RVA: 0x00178F0C File Offset: 0x0017710C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25574, XrefRangeEnd = 25578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CleanupGameFailure_b__48_1(AccountID a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__CleanupGameFailure_b__48_1_Internal_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004127 RID: 16679 RVA: 0x00178F5C File Offset: 0x0017715C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25578, XrefRangeEnd = 25585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreatePlayers_b__49_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__CreatePlayers_b__49_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004128 RID: 16680 RVA: 0x00178FAC File Offset: 0x001771AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25585, XrefRangeEnd = 25593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CreatePlayers_b__49_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__CreatePlayers_b__49_1_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004129 RID: 16681 RVA: 0x00178FFC File Offset: 0x001771FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25593, XrefRangeEnd = 25595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreatePlayers_b__49_2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__CreatePlayers_b__49_2_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600412A RID: 16682 RVA: 0x0017904C File Offset: 0x0017724C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25595, XrefRangeEnd = 25606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsMatchOver_b__59_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__IsMatchOver_b__59_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600412B RID: 16683 RVA: 0x0017909C File Offset: 0x0017729C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25606, XrefRangeEnd = 25607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetEndgamePlayerOrder_b__61_7(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_7_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600412C RID: 16684 RVA: 0x001790EC File Offset: 0x001772EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25607, XrefRangeEnd = 25609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetEndgamePlayerOrder_b__61_2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_2_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600412D RID: 16685 RVA: 0x0017913C File Offset: 0x0017733C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25609, XrefRangeEnd = 25617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetEndgamePlayerOrder_b__61_3(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_3_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600412E RID: 16686 RVA: 0x0017918C File Offset: 0x0017738C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25617, XrefRangeEnd = 25618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetEndgamePlayerOrder_b__61_4(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_4_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600412F RID: 16687 RVA: 0x001791DC File Offset: 0x001773DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25618, XrefRangeEnd = 25619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetEndgamePlayerOrder_b__61_5(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_5_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004130 RID: 16688 RVA: 0x0017922C File Offset: 0x0017742C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25619, XrefRangeEnd = 25620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetEndgamePlayerOrder_b__61_6(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_6_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004131 RID: 16689 RVA: 0x0017927C File Offset: 0x0017747C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25620, XrefRangeEnd = 25632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetWinner_b__62_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__GetWinner_b__62_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004132 RID: 16690 RVA: 0x001792CC File Offset: 0x001774CC
			[CallerCount(0)]
			public unsafe Factions _MakePlayerGameResults_b__66_0(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__MakePlayerGameResults_b__66_0_Internal_Factions_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004133 RID: 16691 RVA: 0x00179318 File Offset: 0x00177518
			[CallerCount(0)]
			public unsafe Factions _MakePlayerGameResults_b__66_1(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__MakePlayerGameResults_b__66_1_Internal_Factions_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004134 RID: 16692 RVA: 0x00179364 File Offset: 0x00177564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25632, XrefRangeEnd = 25634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _getGameResults_b__67_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__getGameResults_b__67_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004135 RID: 16693 RVA: 0x001793B4 File Offset: 0x001775B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _getGameResults_b__67_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__getGameResults_b__67_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004136 RID: 16694 RVA: 0x00179404 File Offset: 0x00177604
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25634, XrefRangeEnd = 25637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _getGameResults_b__67_3(Set t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref t;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__getGameResults_b__67_3_Internal_String_Set_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06004137 RID: 16695 RVA: 0x00179448 File Offset: 0x00177648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25637, XrefRangeEnd = 25642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GameOverAchievementsForPlayer_b__68_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__GameOverAchievementsForPlayer_b__68_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004138 RID: 16696 RVA: 0x00179498 File Offset: 0x00177698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25642, XrefRangeEnd = 25647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GameOverAchievementsForPlayer_b__68_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__GameOverAchievementsForPlayer_b__68_2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004139 RID: 16697 RVA: 0x001794E8 File Offset: 0x001776E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25647, XrefRangeEnd = 25654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GameOverAchievementsForPlayer_b__68_3(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__GameOverAchievementsForPlayer_b__68_3_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600413A RID: 16698 RVA: 0x00179538 File Offset: 0x00177738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25654, XrefRangeEnd = 25655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HandleIdleResignFromGame_b__72_0(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__HandleIdleResignFromGame_b__72_0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600413B RID: 16699 RVA: 0x00179588 File Offset: 0x00177788
			[CallerCount(0)]
			public unsafe AccountID _HandleIdleResignFromGame_b__72_1(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__HandleIdleResignFromGame_b__72_1_Internal_AccountID_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x0600413C RID: 16700 RVA: 0x001795D8 File Offset: 0x001777D8
			[CallerCount(0)]
			public unsafe int _logGameOverAnalytics_b__75_0(WormGameResultsEntry _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__logGameOverAnalytics_b__75_0_Internal_Int32_WormGameResultsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600413D RID: 16701 RVA: 0x00179628 File Offset: 0x00177828
			[CallerCount(0)]
			public unsafe int _logGameOverAnalytics_b__75_1(WormGameResultsEntry _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__logGameOverAnalytics_b__75_1_Internal_Int32_WormGameResultsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600413E RID: 16702 RVA: 0x00179678 File Offset: 0x00177878
			[CallerCount(0)]
			public unsafe LocalizableText _logGameOverAnalytics_b__75_2(WormGameResultsEntry player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__logGameOverAnalytics_b__75_2_Internal_LocalizableText_WormGameResultsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr3) : null;
				}
			}

			// Token: 0x0600413F RID: 16703 RVA: 0x001796C8 File Offset: 0x001778C8
			[CallerCount(0)]
			public unsafe LocalizableText _logGameOverAnalytics_b__75_4(WormGameResultsEntry player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__logGameOverAnalytics_b__75_4_Internal_LocalizableText_WormGameResultsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableText>(intPtr3) : null;
				}
			}

			// Token: 0x06004140 RID: 16704 RVA: 0x00179718 File Offset: 0x00177918
			[CallerCount(0)]
			public unsafe Dictionary<LocalizableTextVariables, int> _logGameOverAnalytics_b__75_5(WormGameResultsEntry player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__logGameOverAnalytics_b__75_5_Internal_Dictionary_2_LocalizableTextVariables_Int32_WormGameResultsEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<LocalizableTextVariables, int>>(intPtr3) : null;
				}
			}

			// Token: 0x06004141 RID: 16705 RVA: 0x00179768 File Offset: 0x00177968
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_HagalMultiTurnOrder_b__91_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__get_HagalMultiTurnOrder_b__91_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004142 RID: 16706 RVA: 0x001797B8 File Offset: 0x001779B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25655, XrefRangeEnd = 25663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindHagalMultiTurnOrder_b__92_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__FindHagalMultiTurnOrder_b__92_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004143 RID: 16707 RVA: 0x00179808 File Offset: 0x00177A08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindHagalMultiTurnOrder_b__92_1(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__FindHagalMultiTurnOrder_b__92_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004144 RID: 16708 RVA: 0x00179858 File Offset: 0x00177A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25663, XrefRangeEnd = 25714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<TriggeredAbility> _get_InstalledTriggeredAbilities_b__98_0(WormPlayer player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__get_InstalledTriggeredAbilities_b__98_0_Internal_IEnumerable_1_TriggeredAbility_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TriggeredAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x06004145 RID: 16709 RVA: 0x001798A8 File Offset: 0x00177AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25714, XrefRangeEnd = 25715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_InstalledTriggeredAbilities_b__98_1(TriggeredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c.NativeMethodInfoPtr__get_InstalledTriggeredAbilities_b__98_1_Internal_Boolean_TriggeredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004146 RID: 16710 RVA: 0x00014BED File Offset: 0x00012DED
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F36 RID: 3894
			// (get) Token: 0x06004147 RID: 16711 RVA: 0x001798F8 File Offset: 0x00177AF8
			// (set) Token: 0x06004148 RID: 16712 RVA: 0x00014BF6 File Offset: 0x00012DF6
			public unsafe static WormMatch.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F37 RID: 3895
			// (get) Token: 0x06004149 RID: 16713 RVA: 0x00179920 File Offset: 0x00177B20
			// (set) Token: 0x0600414A RID: 16714 RVA: 0x00014C08 File Offset: 0x00012E08
			public unsafe static Func<WormPlayer, bool> __9__28_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__28_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__28_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F38 RID: 3896
			// (get) Token: 0x0600414B RID: 16715 RVA: 0x00179948 File Offset: 0x00177B48
			// (set) Token: 0x0600414C RID: 16716 RVA: 0x00014C1A File Offset: 0x00012E1A
			public unsafe static Func<PlayerMatchInitData, AccountID> __9__48_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__48_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerMatchInitData, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__48_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F39 RID: 3897
			// (get) Token: 0x0600414D RID: 16717 RVA: 0x00179970 File Offset: 0x00177B70
			// (set) Token: 0x0600414E RID: 16718 RVA: 0x00014C2C File Offset: 0x00012E2C
			public unsafe static Func<AccountID, bool> __9__48_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__48_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountID, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__48_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F3A RID: 3898
			// (get) Token: 0x0600414F RID: 16719 RVA: 0x00179998 File Offset: 0x00177B98
			// (set) Token: 0x06004150 RID: 16720 RVA: 0x00014C3E File Offset: 0x00012E3E
			public unsafe static Func<WormPlayer, bool> __9__49_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__49_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__49_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F3B RID: 3899
			// (get) Token: 0x06004151 RID: 16721 RVA: 0x001799C0 File Offset: 0x00177BC0
			// (set) Token: 0x06004152 RID: 16722 RVA: 0x00014C50 File Offset: 0x00012E50
			public unsafe static Func<WormPlayer, int> __9__49_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__49_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__49_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F3C RID: 3900
			// (get) Token: 0x06004153 RID: 16723 RVA: 0x001799E8 File Offset: 0x00177BE8
			// (set) Token: 0x06004154 RID: 16724 RVA: 0x00014C62 File Offset: 0x00012E62
			public unsafe static Func<WormPlayer, bool> __9__49_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__49_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__49_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F3D RID: 3901
			// (get) Token: 0x06004155 RID: 16725 RVA: 0x00179A10 File Offset: 0x00177C10
			// (set) Token: 0x06004156 RID: 16726 RVA: 0x00014C74 File Offset: 0x00012E74
			public unsafe static Func<WormPlayer, bool> __9__59_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__59_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__59_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F3E RID: 3902
			// (get) Token: 0x06004157 RID: 16727 RVA: 0x00179A38 File Offset: 0x00177C38
			// (set) Token: 0x06004158 RID: 16728 RVA: 0x00014C86 File Offset: 0x00012E86
			public unsafe static Func<Entity, bool> __9__61_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__61_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__61_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F3F RID: 3903
			// (get) Token: 0x06004159 RID: 16729 RVA: 0x00179A60 File Offset: 0x00177C60
			// (set) Token: 0x0600415A RID: 16730 RVA: 0x00014C98 File Offset: 0x00012E98
			public unsafe static Func<WormPlayer, int> __9__61_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__61_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__61_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F40 RID: 3904
			// (get) Token: 0x0600415B RID: 16731 RVA: 0x00179A88 File Offset: 0x00177C88
			// (set) Token: 0x0600415C RID: 16732 RVA: 0x00014CAA File Offset: 0x00012EAA
			public unsafe static Func<WormPlayer, int> __9__61_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__61_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__61_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F41 RID: 3905
			// (get) Token: 0x0600415D RID: 16733 RVA: 0x00179AB0 File Offset: 0x00177CB0
			// (set) Token: 0x0600415E RID: 16734 RVA: 0x00014CBC File Offset: 0x00012EBC
			public unsafe static Func<WormPlayer, int> __9__61_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__61_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__61_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F42 RID: 3906
			// (get) Token: 0x0600415F RID: 16735 RVA: 0x00179AD8 File Offset: 0x00177CD8
			// (set) Token: 0x06004160 RID: 16736 RVA: 0x00014CCE File Offset: 0x00012ECE
			public unsafe static Func<WormPlayer, int> __9__61_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__61_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__61_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F43 RID: 3907
			// (get) Token: 0x06004161 RID: 16737 RVA: 0x00179B00 File Offset: 0x00177D00
			// (set) Token: 0x06004162 RID: 16738 RVA: 0x00014CE0 File Offset: 0x00012EE0
			public unsafe static Func<WormPlayer, int> __9__61_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__61_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__61_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F44 RID: 3908
			// (get) Token: 0x06004163 RID: 16739 RVA: 0x00179B28 File Offset: 0x00177D28
			// (set) Token: 0x06004164 RID: 16740 RVA: 0x00014CF2 File Offset: 0x00012EF2
			public unsafe static Func<WormPlayer, bool> __9__62_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__62_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__62_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F45 RID: 3909
			// (get) Token: 0x06004165 RID: 16741 RVA: 0x00179B50 File Offset: 0x00177D50
			// (set) Token: 0x06004166 RID: 16742 RVA: 0x00014D04 File Offset: 0x00012F04
			public unsafe static Func<Factions, Factions> __9__66_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__66_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Factions, Factions>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__66_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F46 RID: 3910
			// (get) Token: 0x06004167 RID: 16743 RVA: 0x00179B78 File Offset: 0x00177D78
			// (set) Token: 0x06004168 RID: 16744 RVA: 0x00014D16 File Offset: 0x00012F16
			public unsafe static Func<Factions, Factions> __9__66_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__66_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Factions, Factions>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__66_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F47 RID: 3911
			// (get) Token: 0x06004169 RID: 16745 RVA: 0x00179BA0 File Offset: 0x00177DA0
			// (set) Token: 0x0600416A RID: 16746 RVA: 0x00014D28 File Offset: 0x00012F28
			public unsafe static Func<WormPlayer, bool> __9__67_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__67_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__67_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F48 RID: 3912
			// (get) Token: 0x0600416B RID: 16747 RVA: 0x00179BC8 File Offset: 0x00177DC8
			// (set) Token: 0x0600416C RID: 16748 RVA: 0x00014D3A File Offset: 0x00012F3A
			public unsafe static Predicate<WormPlayer> __9__67_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__67_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__67_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F49 RID: 3913
			// (get) Token: 0x0600416D RID: 16749 RVA: 0x00179BF0 File Offset: 0x00177DF0
			// (set) Token: 0x0600416E RID: 16750 RVA: 0x00014D4C File Offset: 0x00012F4C
			public unsafe static Func<Set, string> __9__67_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__67_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Set, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__67_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F4A RID: 3914
			// (get) Token: 0x0600416F RID: 16751 RVA: 0x00179C18 File Offset: 0x00177E18
			// (set) Token: 0x06004170 RID: 16752 RVA: 0x00014D5E File Offset: 0x00012F5E
			public unsafe static Func<Entity, bool> __9__68_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__68_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__68_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F4B RID: 3915
			// (get) Token: 0x06004171 RID: 16753 RVA: 0x00179C40 File Offset: 0x00177E40
			// (set) Token: 0x06004172 RID: 16754 RVA: 0x00014D70 File Offset: 0x00012F70
			public unsafe static Func<Entity, bool> __9__68_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__68_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__68_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F4C RID: 3916
			// (get) Token: 0x06004173 RID: 16755 RVA: 0x00179C68 File Offset: 0x00177E68
			// (set) Token: 0x06004174 RID: 16756 RVA: 0x00014D82 File Offset: 0x00012F82
			public unsafe static Func<Entity, bool> __9__68_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__68_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__68_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F4D RID: 3917
			// (get) Token: 0x06004175 RID: 16757 RVA: 0x00179C90 File Offset: 0x00177E90
			// (set) Token: 0x06004176 RID: 16758 RVA: 0x00014D94 File Offset: 0x00012F94
			public unsafe static Func<PlayerEntity, bool> __9__72_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__72_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__72_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F4E RID: 3918
			// (get) Token: 0x06004177 RID: 16759 RVA: 0x00179CB8 File Offset: 0x00177EB8
			// (set) Token: 0x06004178 RID: 16760 RVA: 0x00014DA6 File Offset: 0x00012FA6
			public unsafe static Func<PlayerEntity, AccountID> __9__72_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__72_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__72_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F4F RID: 3919
			// (get) Token: 0x06004179 RID: 16761 RVA: 0x00179CE0 File Offset: 0x00177EE0
			// (set) Token: 0x0600417A RID: 16762 RVA: 0x00014DB8 File Offset: 0x00012FB8
			public unsafe static Func<WormGameResultsEntry, int> __9__75_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__75_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormGameResultsEntry, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__75_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F50 RID: 3920
			// (get) Token: 0x0600417B RID: 16763 RVA: 0x00179D08 File Offset: 0x00177F08
			// (set) Token: 0x0600417C RID: 16764 RVA: 0x00014DCA File Offset: 0x00012FCA
			public unsafe static Func<WormGameResultsEntry, int> __9__75_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__75_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormGameResultsEntry, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__75_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F51 RID: 3921
			// (get) Token: 0x0600417D RID: 16765 RVA: 0x00179D30 File Offset: 0x00177F30
			// (set) Token: 0x0600417E RID: 16766 RVA: 0x00014DDC File Offset: 0x00012FDC
			public unsafe static Func<WormGameResultsEntry, LocalizableText> __9__75_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__75_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormGameResultsEntry, LocalizableText>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__75_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F52 RID: 3922
			// (get) Token: 0x0600417F RID: 16767 RVA: 0x00179D58 File Offset: 0x00177F58
			// (set) Token: 0x06004180 RID: 16768 RVA: 0x00014DEE File Offset: 0x00012FEE
			public unsafe static Func<WormGameResultsEntry, LocalizableText> __9__75_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__75_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormGameResultsEntry, LocalizableText>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__75_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F53 RID: 3923
			// (get) Token: 0x06004181 RID: 16769 RVA: 0x00179D80 File Offset: 0x00177F80
			// (set) Token: 0x06004182 RID: 16770 RVA: 0x00014E00 File Offset: 0x00013000
			public unsafe static Func<WormGameResultsEntry, Dictionary<LocalizableTextVariables, int>> __9__75_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__75_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormGameResultsEntry, Dictionary<LocalizableTextVariables, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__75_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F54 RID: 3924
			// (get) Token: 0x06004183 RID: 16771 RVA: 0x00179DA8 File Offset: 0x00177FA8
			// (set) Token: 0x06004184 RID: 16772 RVA: 0x00014E12 File Offset: 0x00013012
			public unsafe static Func<WormPlayer, bool> __9__91_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__91_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__91_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F55 RID: 3925
			// (get) Token: 0x06004185 RID: 16773 RVA: 0x00179DD0 File Offset: 0x00177FD0
			// (set) Token: 0x06004186 RID: 16774 RVA: 0x00014E24 File Offset: 0x00013024
			public unsafe static Func<WormPlayer, bool> __9__92_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__92_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__92_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F56 RID: 3926
			// (get) Token: 0x06004187 RID: 16775 RVA: 0x00179DF8 File Offset: 0x00177FF8
			// (set) Token: 0x06004188 RID: 16776 RVA: 0x00014E36 File Offset: 0x00013036
			public unsafe static Func<WormPlayer, bool> __9__92_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__92_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__92_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F57 RID: 3927
			// (get) Token: 0x06004189 RID: 16777 RVA: 0x00179E20 File Offset: 0x00178020
			// (set) Token: 0x0600418A RID: 16778 RVA: 0x00014E48 File Offset: 0x00013048
			public unsafe static Func<WormPlayer, IEnumerable<TriggeredAbility>> __9__98_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__98_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, IEnumerable<TriggeredAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__98_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F58 RID: 3928
			// (get) Token: 0x0600418B RID: 16779 RVA: 0x00179E48 File Offset: 0x00178048
			// (set) Token: 0x0600418C RID: 16780 RVA: 0x00014E5A File Offset: 0x0001305A
			public unsafe static Func<TriggeredAbility, bool> __9__98_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormMatch.__c.NativeFieldInfoPtr___9__98_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TriggeredAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormMatch.__c.NativeFieldInfoPtr___9__98_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B41 RID: 11073
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002B42 RID: 11074
			private static readonly IntPtr NativeFieldInfoPtr___9__28_0;

			// Token: 0x04002B43 RID: 11075
			private static readonly IntPtr NativeFieldInfoPtr___9__48_0;

			// Token: 0x04002B44 RID: 11076
			private static readonly IntPtr NativeFieldInfoPtr___9__48_1;

			// Token: 0x04002B45 RID: 11077
			private static readonly IntPtr NativeFieldInfoPtr___9__49_0;

			// Token: 0x04002B46 RID: 11078
			private static readonly IntPtr NativeFieldInfoPtr___9__49_1;

			// Token: 0x04002B47 RID: 11079
			private static readonly IntPtr NativeFieldInfoPtr___9__49_2;

			// Token: 0x04002B48 RID: 11080
			private static readonly IntPtr NativeFieldInfoPtr___9__59_0;

			// Token: 0x04002B49 RID: 11081
			private static readonly IntPtr NativeFieldInfoPtr___9__61_7;

			// Token: 0x04002B4A RID: 11082
			private static readonly IntPtr NativeFieldInfoPtr___9__61_2;

			// Token: 0x04002B4B RID: 11083
			private static readonly IntPtr NativeFieldInfoPtr___9__61_3;

			// Token: 0x04002B4C RID: 11084
			private static readonly IntPtr NativeFieldInfoPtr___9__61_4;

			// Token: 0x04002B4D RID: 11085
			private static readonly IntPtr NativeFieldInfoPtr___9__61_5;

			// Token: 0x04002B4E RID: 11086
			private static readonly IntPtr NativeFieldInfoPtr___9__61_6;

			// Token: 0x04002B4F RID: 11087
			private static readonly IntPtr NativeFieldInfoPtr___9__62_0;

			// Token: 0x04002B50 RID: 11088
			private static readonly IntPtr NativeFieldInfoPtr___9__66_0;

			// Token: 0x04002B51 RID: 11089
			private static readonly IntPtr NativeFieldInfoPtr___9__66_1;

			// Token: 0x04002B52 RID: 11090
			private static readonly IntPtr NativeFieldInfoPtr___9__67_0;

			// Token: 0x04002B53 RID: 11091
			private static readonly IntPtr NativeFieldInfoPtr___9__67_1;

			// Token: 0x04002B54 RID: 11092
			private static readonly IntPtr NativeFieldInfoPtr___9__67_3;

			// Token: 0x04002B55 RID: 11093
			private static readonly IntPtr NativeFieldInfoPtr___9__68_1;

			// Token: 0x04002B56 RID: 11094
			private static readonly IntPtr NativeFieldInfoPtr___9__68_2;

			// Token: 0x04002B57 RID: 11095
			private static readonly IntPtr NativeFieldInfoPtr___9__68_3;

			// Token: 0x04002B58 RID: 11096
			private static readonly IntPtr NativeFieldInfoPtr___9__72_0;

			// Token: 0x04002B59 RID: 11097
			private static readonly IntPtr NativeFieldInfoPtr___9__72_1;

			// Token: 0x04002B5A RID: 11098
			private static readonly IntPtr NativeFieldInfoPtr___9__75_0;

			// Token: 0x04002B5B RID: 11099
			private static readonly IntPtr NativeFieldInfoPtr___9__75_1;

			// Token: 0x04002B5C RID: 11100
			private static readonly IntPtr NativeFieldInfoPtr___9__75_2;

			// Token: 0x04002B5D RID: 11101
			private static readonly IntPtr NativeFieldInfoPtr___9__75_4;

			// Token: 0x04002B5E RID: 11102
			private static readonly IntPtr NativeFieldInfoPtr___9__75_5;

			// Token: 0x04002B5F RID: 11103
			private static readonly IntPtr NativeFieldInfoPtr___9__91_0;

			// Token: 0x04002B60 RID: 11104
			private static readonly IntPtr NativeFieldInfoPtr___9__92_0;

			// Token: 0x04002B61 RID: 11105
			private static readonly IntPtr NativeFieldInfoPtr___9__92_1;

			// Token: 0x04002B62 RID: 11106
			private static readonly IntPtr NativeFieldInfoPtr___9__98_0;

			// Token: 0x04002B63 RID: 11107
			private static readonly IntPtr NativeFieldInfoPtr___9__98_1;

			// Token: 0x04002B64 RID: 11108
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B65 RID: 11109
			private static readonly IntPtr NativeMethodInfoPtr__get_PlayerTurnOrder_b__28_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002B66 RID: 11110
			private static readonly IntPtr NativeMethodInfoPtr__CleanupGameFailure_b__48_0_Internal_AccountID_PlayerMatchInitData_0;

			// Token: 0x04002B67 RID: 11111
			private static readonly IntPtr NativeMethodInfoPtr__CleanupGameFailure_b__48_1_Internal_Boolean_AccountID_0;

			// Token: 0x04002B68 RID: 11112
			private static readonly IntPtr NativeMethodInfoPtr__CreatePlayers_b__49_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002B69 RID: 11113
			private static readonly IntPtr NativeMethodInfoPtr__CreatePlayers_b__49_1_Internal_Int32_WormPlayer_0;

			// Token: 0x04002B6A RID: 11114
			private static readonly IntPtr NativeMethodInfoPtr__CreatePlayers_b__49_2_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002B6B RID: 11115
			private static readonly IntPtr NativeMethodInfoPtr__IsMatchOver_b__59_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002B6C RID: 11116
			private static readonly IntPtr NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_7_Internal_Boolean_Entity_0;

			// Token: 0x04002B6D RID: 11117
			private static readonly IntPtr NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_2_Internal_Int32_WormPlayer_0;

			// Token: 0x04002B6E RID: 11118
			private static readonly IntPtr NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_3_Internal_Int32_WormPlayer_0;

			// Token: 0x04002B6F RID: 11119
			private static readonly IntPtr NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_4_Internal_Int32_WormPlayer_0;

			// Token: 0x04002B70 RID: 11120
			private static readonly IntPtr NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_5_Internal_Int32_WormPlayer_0;

			// Token: 0x04002B71 RID: 11121
			private static readonly IntPtr NativeMethodInfoPtr__GetEndgamePlayerOrder_b__61_6_Internal_Int32_WormPlayer_0;

			// Token: 0x04002B72 RID: 11122
			private static readonly IntPtr NativeMethodInfoPtr__GetWinner_b__62_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002B73 RID: 11123
			private static readonly IntPtr NativeMethodInfoPtr__MakePlayerGameResults_b__66_0_Internal_Factions_Factions_0;

			// Token: 0x04002B74 RID: 11124
			private static readonly IntPtr NativeMethodInfoPtr__MakePlayerGameResults_b__66_1_Internal_Factions_Factions_0;

			// Token: 0x04002B75 RID: 11125
			private static readonly IntPtr NativeMethodInfoPtr__getGameResults_b__67_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002B76 RID: 11126
			private static readonly IntPtr NativeMethodInfoPtr__getGameResults_b__67_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002B77 RID: 11127
			private static readonly IntPtr NativeMethodInfoPtr__getGameResults_b__67_3_Internal_String_Set_0;

			// Token: 0x04002B78 RID: 11128
			private static readonly IntPtr NativeMethodInfoPtr__GameOverAchievementsForPlayer_b__68_1_Internal_Boolean_Entity_0;

			// Token: 0x04002B79 RID: 11129
			private static readonly IntPtr NativeMethodInfoPtr__GameOverAchievementsForPlayer_b__68_2_Internal_Boolean_Entity_0;

			// Token: 0x04002B7A RID: 11130
			private static readonly IntPtr NativeMethodInfoPtr__GameOverAchievementsForPlayer_b__68_3_Internal_Boolean_Entity_0;

			// Token: 0x04002B7B RID: 11131
			private static readonly IntPtr NativeMethodInfoPtr__HandleIdleResignFromGame_b__72_0_Internal_Boolean_PlayerEntity_0;

			// Token: 0x04002B7C RID: 11132
			private static readonly IntPtr NativeMethodInfoPtr__HandleIdleResignFromGame_b__72_1_Internal_AccountID_PlayerEntity_0;

			// Token: 0x04002B7D RID: 11133
			private static readonly IntPtr NativeMethodInfoPtr__logGameOverAnalytics_b__75_0_Internal_Int32_WormGameResultsEntry_0;

			// Token: 0x04002B7E RID: 11134
			private static readonly IntPtr NativeMethodInfoPtr__logGameOverAnalytics_b__75_1_Internal_Int32_WormGameResultsEntry_0;

			// Token: 0x04002B7F RID: 11135
			private static readonly IntPtr NativeMethodInfoPtr__logGameOverAnalytics_b__75_2_Internal_LocalizableText_WormGameResultsEntry_0;

			// Token: 0x04002B80 RID: 11136
			private static readonly IntPtr NativeMethodInfoPtr__logGameOverAnalytics_b__75_4_Internal_LocalizableText_WormGameResultsEntry_0;

			// Token: 0x04002B81 RID: 11137
			private static readonly IntPtr NativeMethodInfoPtr__logGameOverAnalytics_b__75_5_Internal_Dictionary_2_LocalizableTextVariables_Int32_WormGameResultsEntry_0;

			// Token: 0x04002B82 RID: 11138
			private static readonly IntPtr NativeMethodInfoPtr__get_HagalMultiTurnOrder_b__91_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002B83 RID: 11139
			private static readonly IntPtr NativeMethodInfoPtr__FindHagalMultiTurnOrder_b__92_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002B84 RID: 11140
			private static readonly IntPtr NativeMethodInfoPtr__FindHagalMultiTurnOrder_b__92_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002B85 RID: 11141
			private static readonly IntPtr NativeMethodInfoPtr__get_InstalledTriggeredAbilities_b__98_0_Internal_IEnumerable_1_TriggeredAbility_WormPlayer_0;

			// Token: 0x04002B86 RID: 11142
			private static readonly IntPtr NativeMethodInfoPtr__get_InstalledTriggeredAbilities_b__98_1_Internal_Boolean_TriggeredAbility_0;
		}

		// Token: 0x0200055B RID: 1371
		[ObfuscatedName("worm.canis.WormMatch+<>c__DisplayClass110_0")]
		public sealed class __c__DisplayClass110_0 : Object
		{
			// Token: 0x0600418D RID: 16781 RVA: 0x00179E70 File Offset: 0x00178070
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass110_0()
			{
				Il2CppClassPointerStore<WormMatch.__c__DisplayClass110_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<>c__DisplayClass110_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch.__c__DisplayClass110_0>.NativeClassPtr);
				WormMatch.__c__DisplayClass110_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c__DisplayClass110_0>.NativeClassPtr, "id");
				WormMatch.__c__DisplayClass110_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass110_0>.NativeClassPtr, 100663535);
				WormMatch.__c__DisplayClass110_0.NativeMethodInfoPtr__GetStoredLog_b__0_Internal_Boolean_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass110_0>.NativeClassPtr, 100663536);
			}

			// Token: 0x0600418E RID: 16782 RVA: 0x00179ED8 File Offset: 0x001780D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass110_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch.__c__DisplayClass110_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass110_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600418F RID: 16783 RVA: 0x00179F14 File Offset: 0x00178114
			[CallerCount(0)]
			public unsafe bool _GetStoredLog_b__0(SerializedGameLog _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass110_0.NativeMethodInfoPtr__GetStoredLog_b__0_Internal_Boolean_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004190 RID: 16784 RVA: 0x00014E6C File Offset: 0x0001306C
			public __c__DisplayClass110_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F59 RID: 3929
			// (get) Token: 0x06004191 RID: 16785 RVA: 0x00179F64 File Offset: 0x00178164
			// (set) Token: 0x06004192 RID: 16786 RVA: 0x00014E75 File Offset: 0x00013075
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass110_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass110_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x04002B87 RID: 11143
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04002B88 RID: 11144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B89 RID: 11145
			private static readonly IntPtr NativeMethodInfoPtr__GetStoredLog_b__0_Internal_Boolean_SerializedGameLog_0;
		}

		// Token: 0x0200055C RID: 1372
		[ObfuscatedName("worm.canis.WormMatch+<>c__DisplayClass29_0")]
		public sealed class __c__DisplayClass29_0 : Object
		{
			// Token: 0x06004193 RID: 16787 RVA: 0x00179F8C File Offset: 0x0017818C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass29_0()
			{
				Il2CppClassPointerStore<WormMatch.__c__DisplayClass29_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<>c__DisplayClass29_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch.__c__DisplayClass29_0>.NativeClassPtr);
				WormMatch.__c__DisplayClass29_0.NativeFieldInfoPtr_findInitialPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c__DisplayClass29_0>.NativeClassPtr, "findInitialPlayer");
				WormMatch.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass29_0>.NativeClassPtr, 100663537);
				WormMatch.__c__DisplayClass29_0.NativeMethodInfoPtr__FindPlayerTurnOrder_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass29_0>.NativeClassPtr, 100663538);
			}

			// Token: 0x06004194 RID: 16788 RVA: 0x00179FF4 File Offset: 0x001781F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass29_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch.__c__DisplayClass29_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass29_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004195 RID: 16789 RVA: 0x0017A030 File Offset: 0x00178230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25715, XrefRangeEnd = 25716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindPlayerTurnOrder_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass29_0.NativeMethodInfoPtr__FindPlayerTurnOrder_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004196 RID: 16790 RVA: 0x00014E90 File Offset: 0x00013090
			public __c__DisplayClass29_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F5A RID: 3930
			// (get) Token: 0x06004197 RID: 16791 RVA: 0x0017A080 File Offset: 0x00178280
			// (set) Token: 0x06004198 RID: 16792 RVA: 0x00014E99 File Offset: 0x00013099
			public unsafe Func<WormPlayer, bool> findInitialPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass29_0.NativeFieldInfoPtr_findInitialPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass29_0.NativeFieldInfoPtr_findInitialPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B8A RID: 11146
			private static readonly IntPtr NativeFieldInfoPtr_findInitialPlayer;

			// Token: 0x04002B8B RID: 11147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B8C RID: 11148
			private static readonly IntPtr NativeMethodInfoPtr__FindPlayerTurnOrder_b__0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x0200055D RID: 1373
		[ObfuscatedName("worm.canis.WormMatch+<>c__DisplayClass60_0")]
		public sealed class __c__DisplayClass60_0 : Object
		{
			// Token: 0x06004199 RID: 16793 RVA: 0x0017A0B0 File Offset: 0x001782B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass60_0()
			{
				Il2CppClassPointerStore<WormMatch.__c__DisplayClass60_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<>c__DisplayClass60_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch.__c__DisplayClass60_0>.NativeClassPtr);
				WormMatch.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c__DisplayClass60_0>.NativeClassPtr, "<>4__this");
				WormMatch.__c__DisplayClass60_0.NativeFieldInfoPtr_endgameTriggerScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c__DisplayClass60_0>.NativeClassPtr, "endgameTriggerScore");
				WormMatch.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass60_0>.NativeClassPtr, 100663539);
				WormMatch.__c__DisplayClass60_0.NativeMethodInfoPtr__IsEndgame_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass60_0>.NativeClassPtr, 100663540);
				WormMatch.__c__DisplayClass60_0.NativeMethodInfoPtr__IsEndgame_b__1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass60_0>.NativeClassPtr, 100663541);
				WormMatch.__c__DisplayClass60_0.NativeMethodInfoPtr__IsEndgame_b__2_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass60_0>.NativeClassPtr, 100663542);
			}

			// Token: 0x0600419A RID: 16794 RVA: 0x0017A154 File Offset: 0x00178354
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass60_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch.__c__DisplayClass60_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass60_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600419B RID: 16795 RVA: 0x0017A190 File Offset: 0x00178390
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25716, XrefRangeEnd = 25719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsEndgame_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass60_0.NativeMethodInfoPtr__IsEndgame_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600419C RID: 16796 RVA: 0x0017A1E0 File Offset: 0x001783E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25719, XrefRangeEnd = 25720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsEndgame_b__1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass60_0.NativeMethodInfoPtr__IsEndgame_b__1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600419D RID: 16797 RVA: 0x0017A230 File Offset: 0x00178430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25720, XrefRangeEnd = 25721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsEndgame_b__2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass60_0.NativeMethodInfoPtr__IsEndgame_b__2_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600419E RID: 16798 RVA: 0x00014EB8 File Offset: 0x000130B8
			public __c__DisplayClass60_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F5B RID: 3931
			// (get) Token: 0x0600419F RID: 16799 RVA: 0x0017A280 File Offset: 0x00178480
			// (set) Token: 0x060041A0 RID: 16800 RVA: 0x00014EC1 File Offset: 0x000130C1
			public unsafe WormMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass60_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F5C RID: 3932
			// (get) Token: 0x060041A1 RID: 16801 RVA: 0x0017A2B0 File Offset: 0x001784B0
			// (set) Token: 0x060041A2 RID: 16802 RVA: 0x00014EE0 File Offset: 0x000130E0
			public unsafe int endgameTriggerScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass60_0.NativeFieldInfoPtr_endgameTriggerScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass60_0.NativeFieldInfoPtr_endgameTriggerScore)) = value;
				}
			}

			// Token: 0x04002B8D RID: 11149
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002B8E RID: 11150
			private static readonly IntPtr NativeFieldInfoPtr_endgameTriggerScore;

			// Token: 0x04002B8F RID: 11151
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B90 RID: 11152
			private static readonly IntPtr NativeMethodInfoPtr__IsEndgame_b__0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002B91 RID: 11153
			private static readonly IntPtr NativeMethodInfoPtr__IsEndgame_b__1_Internal_Boolean_WormPlayer_0;

			// Token: 0x04002B92 RID: 11154
			private static readonly IntPtr NativeMethodInfoPtr__IsEndgame_b__2_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x0200055E RID: 1374
		[ObfuscatedName("worm.canis.WormMatch+<>c__DisplayClass67_0")]
		public sealed class __c__DisplayClass67_0 : Object
		{
			// Token: 0x060041A3 RID: 16803 RVA: 0x0017A2D8 File Offset: 0x001784D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass67_0()
			{
				Il2CppClassPointerStore<WormMatch.__c__DisplayClass67_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<>c__DisplayClass67_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch.__c__DisplayClass67_0>.NativeClassPtr);
				WormMatch.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c__DisplayClass67_0>.NativeClassPtr, "<>4__this");
				WormMatch.__c__DisplayClass67_0.NativeFieldInfoPtr_playerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c__DisplayClass67_0>.NativeClassPtr, "playerList");
				WormMatch.__c__DisplayClass67_0.NativeFieldInfoPtr_hagalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c__DisplayClass67_0>.NativeClassPtr, "hagalCount");
				WormMatch.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass67_0>.NativeClassPtr, 100663543);
				WormMatch.__c__DisplayClass67_0.NativeMethodInfoPtr__getGameResults_b__2_Internal_WormGameResultsEntry_WormPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass67_0>.NativeClassPtr, 100663544);
			}

			// Token: 0x060041A4 RID: 16804 RVA: 0x0017A368 File Offset: 0x00178568
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass67_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch.__c__DisplayClass67_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass67_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060041A5 RID: 16805 RVA: 0x0017A3A4 File Offset: 0x001785A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25721, XrefRangeEnd = 25723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WormGameResultsEntry _getGameResults_b__2(WormPlayer p, int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass67_0.NativeMethodInfoPtr__getGameResults_b__2_Internal_WormGameResultsEntry_WormPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormGameResultsEntry>(intPtr3) : null;
			}

			// Token: 0x060041A6 RID: 16806 RVA: 0x00014EFB File Offset: 0x000130FB
			public __c__DisplayClass67_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F5D RID: 3933
			// (get) Token: 0x060041A7 RID: 16807 RVA: 0x0017A404 File Offset: 0x00178604
			// (set) Token: 0x060041A8 RID: 16808 RVA: 0x00014F04 File Offset: 0x00013104
			public unsafe WormMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass67_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F5E RID: 3934
			// (get) Token: 0x060041A9 RID: 16809 RVA: 0x0017A434 File Offset: 0x00178634
			// (set) Token: 0x060041AA RID: 16810 RVA: 0x00014F23 File Offset: 0x00013123
			public unsafe List<WormPlayer> playerList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass67_0.NativeFieldInfoPtr_playerList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass67_0.NativeFieldInfoPtr_playerList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F5F RID: 3935
			// (get) Token: 0x060041AB RID: 16811 RVA: 0x0017A464 File Offset: 0x00178664
			// (set) Token: 0x060041AC RID: 16812 RVA: 0x00014F42 File Offset: 0x00013142
			public unsafe int hagalCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass67_0.NativeFieldInfoPtr_hagalCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass67_0.NativeFieldInfoPtr_hagalCount)) = value;
				}
			}

			// Token: 0x04002B93 RID: 11155
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002B94 RID: 11156
			private static readonly IntPtr NativeFieldInfoPtr_playerList;

			// Token: 0x04002B95 RID: 11157
			private static readonly IntPtr NativeFieldInfoPtr_hagalCount;

			// Token: 0x04002B96 RID: 11158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B97 RID: 11159
			private static readonly IntPtr NativeMethodInfoPtr__getGameResults_b__2_Internal_WormGameResultsEntry_WormPlayer_Int32_0;
		}

		// Token: 0x0200055F RID: 1375
		[ObfuscatedName("worm.canis.WormMatch+<>c__DisplayClass68_0")]
		public sealed class __c__DisplayClass68_0 : Object
		{
			// Token: 0x060041AD RID: 16813 RVA: 0x0017A48C File Offset: 0x0017868C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass68_0()
			{
				Il2CppClassPointerStore<WormMatch.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<>c__DisplayClass68_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch.__c__DisplayClass68_0>.NativeClassPtr);
				WormMatch.__c__DisplayClass68_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c__DisplayClass68_0>.NativeClassPtr, "player");
				WormMatch.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass68_0>.NativeClassPtr, 100663545);
				WormMatch.__c__DisplayClass68_0.NativeMethodInfoPtr__GameOverAchievementsForPlayer_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass68_0>.NativeClassPtr, 100663546);
			}

			// Token: 0x060041AE RID: 16814 RVA: 0x0017A4F4 File Offset: 0x001786F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass68_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch.__c__DisplayClass68_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060041AF RID: 16815 RVA: 0x0017A530 File Offset: 0x00178730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25723, XrefRangeEnd = 25725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GameOverAchievementsForPlayer_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass68_0.NativeMethodInfoPtr__GameOverAchievementsForPlayer_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060041B0 RID: 16816 RVA: 0x00014F5D File Offset: 0x0001315D
			public __c__DisplayClass68_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F60 RID: 3936
			// (get) Token: 0x060041B1 RID: 16817 RVA: 0x0017A580 File Offset: 0x00178780
			// (set) Token: 0x060041B2 RID: 16818 RVA: 0x00014F66 File Offset: 0x00013166
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass68_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass68_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B98 RID: 11160
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002B99 RID: 11161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B9A RID: 11162
			private static readonly IntPtr NativeMethodInfoPtr__GameOverAchievementsForPlayer_b__0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000560 RID: 1376
		[ObfuscatedName("worm.canis.WormMatch+<>c__DisplayClass81_0")]
		public sealed class __c__DisplayClass81_0 : Object
		{
			// Token: 0x060041B3 RID: 16819 RVA: 0x0017A5B0 File Offset: 0x001787B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass81_0()
			{
				Il2CppClassPointerStore<WormMatch.__c__DisplayClass81_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<>c__DisplayClass81_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch.__c__DisplayClass81_0>.NativeClassPtr);
				WormMatch.__c__DisplayClass81_0.NativeFieldInfoPtr_p = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c__DisplayClass81_0>.NativeClassPtr, "p");
				WormMatch.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass81_0>.NativeClassPtr, 100663547);
				WormMatch.__c__DisplayClass81_0.NativeMethodInfoPtr__get_PlayerNameData_b__1_Internal_Boolean_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass81_0>.NativeClassPtr, 100663548);
			}

			// Token: 0x060041B4 RID: 16820 RVA: 0x0017A618 File Offset: 0x00178818
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass81_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch.__c__DisplayClass81_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass81_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060041B5 RID: 16821 RVA: 0x0017A654 File Offset: 0x00178854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25725, XrefRangeEnd = 25730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_PlayerNameData_b__1(PlayerMatchInitData player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass81_0.NativeMethodInfoPtr__get_PlayerNameData_b__1_Internal_Boolean_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060041B6 RID: 16822 RVA: 0x00014F85 File Offset: 0x00013185
			public __c__DisplayClass81_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F61 RID: 3937
			// (get) Token: 0x060041B7 RID: 16823 RVA: 0x0017A6A4 File Offset: 0x001788A4
			// (set) Token: 0x060041B8 RID: 16824 RVA: 0x00014F8E File Offset: 0x0001318E
			public unsafe WormPlayer p
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass81_0.NativeFieldInfoPtr_p);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass81_0.NativeFieldInfoPtr_p), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B9B RID: 11163
			private static readonly IntPtr NativeFieldInfoPtr_p;

			// Token: 0x04002B9C RID: 11164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002B9D RID: 11165
			private static readonly IntPtr NativeMethodInfoPtr__get_PlayerNameData_b__1_Internal_Boolean_PlayerMatchInitData_0;
		}

		// Token: 0x02000561 RID: 1377
		[ObfuscatedName("worm.canis.WormMatch+<>c__DisplayClass92_0")]
		public sealed class __c__DisplayClass92_0 : Object
		{
			// Token: 0x060041B9 RID: 16825 RVA: 0x0017A6D4 File Offset: 0x001788D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass92_0()
			{
				Il2CppClassPointerStore<WormMatch.__c__DisplayClass92_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<>c__DisplayClass92_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch.__c__DisplayClass92_0>.NativeClassPtr);
				WormMatch.__c__DisplayClass92_0.NativeFieldInfoPtr_findInitialPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch.__c__DisplayClass92_0>.NativeClassPtr, "findInitialPlayer");
				WormMatch.__c__DisplayClass92_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass92_0>.NativeClassPtr, 100663549);
				WormMatch.__c__DisplayClass92_0.NativeMethodInfoPtr__FindHagalMultiTurnOrder_b__2_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch.__c__DisplayClass92_0>.NativeClassPtr, 100663550);
			}

			// Token: 0x060041BA RID: 16826 RVA: 0x0017A73C File Offset: 0x0017893C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass92_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch.__c__DisplayClass92_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass92_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060041BB RID: 16827 RVA: 0x0017A778 File Offset: 0x00178978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindHagalMultiTurnOrder_b__2(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch.__c__DisplayClass92_0.NativeMethodInfoPtr__FindHagalMultiTurnOrder_b__2_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060041BC RID: 16828 RVA: 0x00014FAD File Offset: 0x000131AD
			public __c__DisplayClass92_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F62 RID: 3938
			// (get) Token: 0x060041BD RID: 16829 RVA: 0x0017A7C8 File Offset: 0x001789C8
			// (set) Token: 0x060041BE RID: 16830 RVA: 0x00014FB6 File Offset: 0x000131B6
			public unsafe Func<WormPlayer, bool> findInitialPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass92_0.NativeFieldInfoPtr_findInitialPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch.__c__DisplayClass92_0.NativeFieldInfoPtr_findInitialPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B9E RID: 11166
			private static readonly IntPtr NativeFieldInfoPtr_findInitialPlayer;

			// Token: 0x04002B9F RID: 11167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002BA0 RID: 11168
			private static readonly IntPtr NativeMethodInfoPtr__FindHagalMultiTurnOrder_b__2_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000562 RID: 1378
		[ObfuscatedName("worm.canis.WormMatch+<AddSequenceToUndoNode>d__129")]
		public sealed class _AddSequenceToUndoNode_d__129 : Object
		{
			// Token: 0x060041BF RID: 16831 RVA: 0x0017A7F8 File Offset: 0x001789F8
			// Note: this type is marked as 'beforefieldinit'.
			static _AddSequenceToUndoNode_d__129()
			{
				Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<AddSequenceToUndoNode>d__129");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr);
				WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, "<>1__state");
				WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, "<>2__current");
				WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, "<>l__initialThreadId");
				WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr_undoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, "undoNode");
				WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___3__undoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, "<>3__undoNode");
				WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr_sequenceHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, "sequenceHelper");
				WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___3__sequenceHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, "<>3__sequenceHelper");
				WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr__sequenceName_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, "<sequenceName>5__2");
				WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, 100663551);
				WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, 100663552);
				WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, 100663553);
				WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, 100663554);
				WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, 100663555);
				WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, 100663556);
				WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, 100663557);
				WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr, 100663558);
			}

			// Token: 0x060041C0 RID: 16832 RVA: 0x0017A964 File Offset: 0x00178B64
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AddSequenceToUndoNode_d__129(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch._AddSequenceToUndoNode_d__129>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060041C1 RID: 16833 RVA: 0x0017A9AC File Offset: 0x00178BAC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060041C2 RID: 16834 RVA: 0x0017A9E0 File Offset: 0x00178BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25730, XrefRangeEnd = 25735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F6B RID: 3947
			// (get) Token: 0x060041C3 RID: 16835 RVA: 0x0017AA1C File Offset: 0x00178C1C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060041C4 RID: 16836 RVA: 0x0017AA5C File Offset: 0x00178C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25735, XrefRangeEnd = 25740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F6C RID: 3948
			// (get) Token: 0x060041C5 RID: 16837 RVA: 0x0017AA90 File Offset: 0x00178C90
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060041C6 RID: 16838 RVA: 0x0017AAD0 File Offset: 0x00178CD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25740, XrefRangeEnd = 25749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060041C7 RID: 16839 RVA: 0x0017AB10 File Offset: 0x00178D10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._AddSequenceToUndoNode_d__129.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060041C8 RID: 16840 RVA: 0x00014FD5 File Offset: 0x000131D5
			public _AddSequenceToUndoNode_d__129(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F63 RID: 3939
			// (get) Token: 0x060041C9 RID: 16841 RVA: 0x0017AB50 File Offset: 0x00178D50
			// (set) Token: 0x060041CA RID: 16842 RVA: 0x00014FDE File Offset: 0x000131DE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F64 RID: 3940
			// (get) Token: 0x060041CB RID: 16843 RVA: 0x0017AB78 File Offset: 0x00178D78
			// (set) Token: 0x060041CC RID: 16844 RVA: 0x00014FF9 File Offset: 0x000131F9
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F65 RID: 3941
			// (get) Token: 0x060041CD RID: 16845 RVA: 0x0017ABA8 File Offset: 0x00178DA8
			// (set) Token: 0x060041CE RID: 16846 RVA: 0x00015018 File Offset: 0x00013218
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000F66 RID: 3942
			// (get) Token: 0x060041CF RID: 16847 RVA: 0x0017ABD0 File Offset: 0x00178DD0
			// (set) Token: 0x060041D0 RID: 16848 RVA: 0x00015033 File Offset: 0x00013233
			public unsafe UndoNode undoNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr_undoNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr_undoNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F67 RID: 3943
			// (get) Token: 0x060041D1 RID: 16849 RVA: 0x0017AC00 File Offset: 0x00178E00
			// (set) Token: 0x060041D2 RID: 16850 RVA: 0x00015052 File Offset: 0x00013252
			public unsafe UndoNode __3__undoNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___3__undoNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___3__undoNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F68 RID: 3944
			// (get) Token: 0x060041D3 RID: 16851 RVA: 0x0017AC30 File Offset: 0x00178E30
			// (set) Token: 0x060041D4 RID: 16852 RVA: 0x00015071 File Offset: 0x00013271
			public unsafe SequenceHelper sequenceHelper
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr_sequenceHelper);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr_sequenceHelper), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F69 RID: 3945
			// (get) Token: 0x060041D5 RID: 16853 RVA: 0x0017AC60 File Offset: 0x00178E60
			// (set) Token: 0x060041D6 RID: 16854 RVA: 0x00015090 File Offset: 0x00013290
			public unsafe SequenceHelper __3__sequenceHelper
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___3__sequenceHelper);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr___3__sequenceHelper), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F6A RID: 3946
			// (get) Token: 0x060041D7 RID: 16855 RVA: 0x0017AC90 File Offset: 0x00178E90
			// (set) Token: 0x060041D8 RID: 16856 RVA: 0x000150AF File Offset: 0x000132AF
			public unsafe string _sequenceName_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr__sequenceName_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._AddSequenceToUndoNode_d__129.NativeFieldInfoPtr__sequenceName_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04002BA1 RID: 11169
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002BA2 RID: 11170
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002BA3 RID: 11171
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002BA4 RID: 11172
			private static readonly IntPtr NativeFieldInfoPtr_undoNode;

			// Token: 0x04002BA5 RID: 11173
			private static readonly IntPtr NativeFieldInfoPtr___3__undoNode;

			// Token: 0x04002BA6 RID: 11174
			private static readonly IntPtr NativeFieldInfoPtr_sequenceHelper;

			// Token: 0x04002BA7 RID: 11175
			private static readonly IntPtr NativeFieldInfoPtr___3__sequenceHelper;

			// Token: 0x04002BA8 RID: 11176
			private static readonly IntPtr NativeFieldInfoPtr__sequenceName_5__2;

			// Token: 0x04002BA9 RID: 11177
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002BAA RID: 11178
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002BAB RID: 11179
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002BAC RID: 11180
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002BAD RID: 11181
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002BAE RID: 11182
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002BAF RID: 11183
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002BB0 RID: 11184
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000563 RID: 1379
		[ObfuscatedName("worm.canis.WormMatch+<ClearDisplayActionsOnSave>d__93")]
		public sealed class _ClearDisplayActionsOnSave_d__93 : Object
		{
			// Token: 0x060041D9 RID: 16857 RVA: 0x0017ACB8 File Offset: 0x00178EB8
			// Note: this type is marked as 'beforefieldinit'.
			static _ClearDisplayActionsOnSave_d__93()
			{
				Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<ClearDisplayActionsOnSave>d__93");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr);
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, "<>1__state");
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, "<>2__current");
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, "<>l__initialThreadId");
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, "<>4__this");
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr_lastRespondingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, "lastRespondingPlayer");
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___3__lastRespondingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, "<>3__lastRespondingPlayer");
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr_allPendingSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, "allPendingSelections");
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___3__allPendingSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, "<>3__allPendingSelections");
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, "<>7__wrap1");
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, 100663559);
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, 100663560);
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, 100663561);
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, 100663562);
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, 100663563);
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, 100663564);
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, 100663565);
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, 100663566);
				WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr, 100663567);
			}

			// Token: 0x060041DA RID: 16858 RVA: 0x0017AE4C File Offset: 0x0017904C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClearDisplayActionsOnSave_d__93(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch._ClearDisplayActionsOnSave_d__93>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060041DB RID: 16859 RVA: 0x0017AE94 File Offset: 0x00179094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25749, XrefRangeEnd = 25754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060041DC RID: 16860 RVA: 0x0017AEC8 File Offset: 0x001790C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25754, XrefRangeEnd = 25783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060041DD RID: 16861 RVA: 0x0017AF04 File Offset: 0x00179104
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25783, XrefRangeEnd = 25786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F76 RID: 3958
			// (get) Token: 0x060041DE RID: 16862 RVA: 0x0017AF38 File Offset: 0x00179138
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x060041DF RID: 16863 RVA: 0x0017AF78 File Offset: 0x00179178
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25786, XrefRangeEnd = 25791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F77 RID: 3959
			// (get) Token: 0x060041E0 RID: 16864 RVA: 0x0017AFAC File Offset: 0x001791AC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060041E1 RID: 16865 RVA: 0x0017AFEC File Offset: 0x001791EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25791, XrefRangeEnd = 25801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x060041E2 RID: 16866 RVA: 0x0017B02C File Offset: 0x0017922C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._ClearDisplayActionsOnSave_d__93.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060041E3 RID: 16867 RVA: 0x000150CE File Offset: 0x000132CE
			public _ClearDisplayActionsOnSave_d__93(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F6D RID: 3949
			// (get) Token: 0x060041E4 RID: 16868 RVA: 0x0017B06C File Offset: 0x0017926C
			// (set) Token: 0x060041E5 RID: 16869 RVA: 0x000150D7 File Offset: 0x000132D7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F6E RID: 3950
			// (get) Token: 0x060041E6 RID: 16870 RVA: 0x0017B094 File Offset: 0x00179294
			// (set) Token: 0x060041E7 RID: 16871 RVA: 0x000150F2 File Offset: 0x000132F2
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F6F RID: 3951
			// (get) Token: 0x060041E8 RID: 16872 RVA: 0x0017B0C4 File Offset: 0x001792C4
			// (set) Token: 0x060041E9 RID: 16873 RVA: 0x00015111 File Offset: 0x00013311
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000F70 RID: 3952
			// (get) Token: 0x060041EA RID: 16874 RVA: 0x0017B0EC File Offset: 0x001792EC
			// (set) Token: 0x060041EB RID: 16875 RVA: 0x0001512C File Offset: 0x0001332C
			public unsafe WormMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F71 RID: 3953
			// (get) Token: 0x060041EC RID: 16876 RVA: 0x0017B11C File Offset: 0x0017931C
			// (set) Token: 0x060041ED RID: 16877 RVA: 0x0001514B File Offset: 0x0001334B
			public unsafe PlayerEntity lastRespondingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr_lastRespondingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr_lastRespondingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F72 RID: 3954
			// (get) Token: 0x060041EE RID: 16878 RVA: 0x0017B14C File Offset: 0x0017934C
			// (set) Token: 0x060041EF RID: 16879 RVA: 0x0001516A File Offset: 0x0001336A
			public unsafe PlayerEntity __3__lastRespondingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___3__lastRespondingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___3__lastRespondingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F73 RID: 3955
			// (get) Token: 0x060041F0 RID: 16880 RVA: 0x0017B17C File Offset: 0x0017937C
			// (set) Token: 0x060041F1 RID: 16881 RVA: 0x00015189 File Offset: 0x00013389
			public unsafe Dictionary<PlayerEntity, List<PendingSelection>> allPendingSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr_allPendingSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PlayerEntity, List<PendingSelection>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr_allPendingSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F74 RID: 3956
			// (get) Token: 0x060041F2 RID: 16882 RVA: 0x0017B1AC File Offset: 0x001793AC
			// (set) Token: 0x060041F3 RID: 16883 RVA: 0x000151A8 File Offset: 0x000133A8
			public unsafe Dictionary<PlayerEntity, List<PendingSelection>> __3__allPendingSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___3__allPendingSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PlayerEntity, List<PendingSelection>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___3__allPendingSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F75 RID: 3957
			// (get) Token: 0x060041F4 RID: 16884 RVA: 0x0017B1DC File Offset: 0x001793DC
			// (set) Token: 0x060041F5 RID: 16885 RVA: 0x000151C7 File Offset: 0x000133C7
			public unsafe IEnumerator<PlayerEntity> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._ClearDisplayActionsOnSave_d__93.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002BB1 RID: 11185
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002BB2 RID: 11186
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002BB3 RID: 11187
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002BB4 RID: 11188
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002BB5 RID: 11189
			private static readonly IntPtr NativeFieldInfoPtr_lastRespondingPlayer;

			// Token: 0x04002BB6 RID: 11190
			private static readonly IntPtr NativeFieldInfoPtr___3__lastRespondingPlayer;

			// Token: 0x04002BB7 RID: 11191
			private static readonly IntPtr NativeFieldInfoPtr_allPendingSelections;

			// Token: 0x04002BB8 RID: 11192
			private static readonly IntPtr NativeFieldInfoPtr___3__allPendingSelections;

			// Token: 0x04002BB9 RID: 11193
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04002BBA RID: 11194
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002BBB RID: 11195
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002BBC RID: 11196
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002BBD RID: 11197
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002BBE RID: 11198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04002BBF RID: 11199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002BC0 RID: 11200
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002BC1 RID: 11201
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04002BC2 RID: 11202
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000564 RID: 1380
		[ObfuscatedName("worm.canis.WormMatch+<FindHagalMultiTurnOrder>d__92")]
		public sealed class _FindHagalMultiTurnOrder_d__92 : Object
		{
			// Token: 0x060041F6 RID: 16886 RVA: 0x0017B20C File Offset: 0x0017940C
			// Note: this type is marked as 'beforefieldinit'.
			static _FindHagalMultiTurnOrder_d__92()
			{
				Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<FindHagalMultiTurnOrder>d__92");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr);
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, "<>1__state");
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, "<>2__current");
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, "<>l__initialThreadId");
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr_findInitialPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, "findInitialPlayer");
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___3__findInitialPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, "<>3__findInitialPlayer");
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, "<>4__this");
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr__HagalPlayerOrder_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, "<HagalPlayerOrder>5__2");
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr__playerCount_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, "<playerCount>5__3");
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr__firstPlayerIndex_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, "<firstPlayerIndex>5__4");
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, "<i>5__5");
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, 100663568);
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, 100663569);
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, 100663570);
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_entities_WormPlayer__get_Current_Private_Virtual_Final_New_get_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, 100663571);
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, 100663572);
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, 100663573);
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_entities_WormPlayer__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, 100663574);
				WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr, 100663575);
			}

			// Token: 0x060041F7 RID: 16887 RVA: 0x0017B3A0 File Offset: 0x001795A0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FindHagalMultiTurnOrder_d__92(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch._FindHagalMultiTurnOrder_d__92>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060041F8 RID: 16888 RVA: 0x0017B3E8 File Offset: 0x001795E8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060041F9 RID: 16889 RVA: 0x0017B41C File Offset: 0x0017961C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25801, XrefRangeEnd = 25900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F82 RID: 3970
			// (get) Token: 0x060041FA RID: 16890 RVA: 0x0017B458 File Offset: 0x00179658
			public unsafe WormPlayer System.Collections.Generic.IEnumerator<worm.canis.entities.WormPlayer>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_entities_WormPlayer__get_Current_Private_Virtual_Final_New_get_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
				}
			}

			// Token: 0x060041FB RID: 16891 RVA: 0x0017B498 File Offset: 0x00179698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25900, XrefRangeEnd = 25905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F83 RID: 3971
			// (get) Token: 0x060041FC RID: 16892 RVA: 0x0017B4CC File Offset: 0x001796CC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060041FD RID: 16893 RVA: 0x0017B50C File Offset: 0x0017970C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25905, XrefRangeEnd = 25914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<WormPlayer> System_Collections_Generic_IEnumerable_worm_canis_entities_WormPlayer__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_entities_WormPlayer__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr3) : null;
			}

			// Token: 0x060041FE RID: 16894 RVA: 0x0017B54C File Offset: 0x0017974C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindHagalMultiTurnOrder_d__92.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060041FF RID: 16895 RVA: 0x000151E6 File Offset: 0x000133E6
			public _FindHagalMultiTurnOrder_d__92(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F78 RID: 3960
			// (get) Token: 0x06004200 RID: 16896 RVA: 0x0017B58C File Offset: 0x0017978C
			// (set) Token: 0x06004201 RID: 16897 RVA: 0x000151EF File Offset: 0x000133EF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F79 RID: 3961
			// (get) Token: 0x06004202 RID: 16898 RVA: 0x0017B5B4 File Offset: 0x001797B4
			// (set) Token: 0x06004203 RID: 16899 RVA: 0x0001520A File Offset: 0x0001340A
			public unsafe WormPlayer __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7A RID: 3962
			// (get) Token: 0x06004204 RID: 16900 RVA: 0x0017B5E4 File Offset: 0x001797E4
			// (set) Token: 0x06004205 RID: 16901 RVA: 0x00015229 File Offset: 0x00013429
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000F7B RID: 3963
			// (get) Token: 0x06004206 RID: 16902 RVA: 0x0017B60C File Offset: 0x0017980C
			// (set) Token: 0x06004207 RID: 16903 RVA: 0x00015244 File Offset: 0x00013444
			public unsafe Func<WormPlayer, bool> findInitialPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr_findInitialPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr_findInitialPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7C RID: 3964
			// (get) Token: 0x06004208 RID: 16904 RVA: 0x0017B63C File Offset: 0x0017983C
			// (set) Token: 0x06004209 RID: 16905 RVA: 0x00015263 File Offset: 0x00013463
			public unsafe Func<WormPlayer, bool> __3__findInitialPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___3__findInitialPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___3__findInitialPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7D RID: 3965
			// (get) Token: 0x0600420A RID: 16906 RVA: 0x0017B66C File Offset: 0x0017986C
			// (set) Token: 0x0600420B RID: 16907 RVA: 0x00015282 File Offset: 0x00013482
			public unsafe WormMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7E RID: 3966
			// (get) Token: 0x0600420C RID: 16908 RVA: 0x0017B69C File Offset: 0x0017989C
			// (set) Token: 0x0600420D RID: 16909 RVA: 0x000152A1 File Offset: 0x000134A1
			public unsafe List<WormPlayer> _HagalPlayerOrder_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr__HagalPlayerOrder_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr__HagalPlayerOrder_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F7F RID: 3967
			// (get) Token: 0x0600420E RID: 16910 RVA: 0x0017B6CC File Offset: 0x001798CC
			// (set) Token: 0x0600420F RID: 16911 RVA: 0x000152C0 File Offset: 0x000134C0
			public unsafe int _playerCount_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr__playerCount_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr__playerCount_5__3)) = value;
				}
			}

			// Token: 0x17000F80 RID: 3968
			// (get) Token: 0x06004210 RID: 16912 RVA: 0x0017B6F4 File Offset: 0x001798F4
			// (set) Token: 0x06004211 RID: 16913 RVA: 0x000152DB File Offset: 0x000134DB
			public unsafe int _firstPlayerIndex_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr__firstPlayerIndex_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr__firstPlayerIndex_5__4)) = value;
				}
			}

			// Token: 0x17000F81 RID: 3969
			// (get) Token: 0x06004212 RID: 16914 RVA: 0x0017B71C File Offset: 0x0017991C
			// (set) Token: 0x06004213 RID: 16915 RVA: 0x000152F6 File Offset: 0x000134F6
			public unsafe int _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindHagalMultiTurnOrder_d__92.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x04002BC3 RID: 11203
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002BC4 RID: 11204
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002BC5 RID: 11205
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002BC6 RID: 11206
			private static readonly IntPtr NativeFieldInfoPtr_findInitialPlayer;

			// Token: 0x04002BC7 RID: 11207
			private static readonly IntPtr NativeFieldInfoPtr___3__findInitialPlayer;

			// Token: 0x04002BC8 RID: 11208
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002BC9 RID: 11209
			private static readonly IntPtr NativeFieldInfoPtr__HagalPlayerOrder_5__2;

			// Token: 0x04002BCA RID: 11210
			private static readonly IntPtr NativeFieldInfoPtr__playerCount_5__3;

			// Token: 0x04002BCB RID: 11211
			private static readonly IntPtr NativeFieldInfoPtr__firstPlayerIndex_5__4;

			// Token: 0x04002BCC RID: 11212
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x04002BCD RID: 11213
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002BCE RID: 11214
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002BCF RID: 11215
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002BD0 RID: 11216
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_entities_WormPlayer__get_Current_Private_Virtual_Final_New_get_WormPlayer_0;

			// Token: 0x04002BD1 RID: 11217
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002BD2 RID: 11218
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002BD3 RID: 11219
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_entities_WormPlayer__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_WormPlayer_0;

			// Token: 0x04002BD4 RID: 11220
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000565 RID: 1381
		[ObfuscatedName("worm.canis.WormMatch+<FindPlayerTurnOrder>d__29")]
		public sealed class _FindPlayerTurnOrder_d__29 : Object
		{
			// Token: 0x06004214 RID: 16916 RVA: 0x0017B744 File Offset: 0x00179944
			// Note: this type is marked as 'beforefieldinit'.
			static _FindPlayerTurnOrder_d__29()
			{
				Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<FindPlayerTurnOrder>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr);
				WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, "<>1__state");
				WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, "<>2__current");
				WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, "<>l__initialThreadId");
				WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr_findInitialPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, "findInitialPlayer");
				WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___3__findInitialPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, "<>3__findInitialPlayer");
				WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, "<>4__this");
				WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr__playerCount_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, "<playerCount>5__2");
				WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr__firstPlayerIndex_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, "<firstPlayerIndex>5__3");
				WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, "<i>5__4");
				WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, 100663576);
				WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, 100663577);
				WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, 100663578);
				WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_entities_WormPlayer__get_Current_Private_Virtual_Final_New_get_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, 100663579);
				WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, 100663580);
				WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, 100663581);
				WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_entities_WormPlayer__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, 100663582);
				WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr, 100663583);
			}

			// Token: 0x06004215 RID: 16917 RVA: 0x0017B8C4 File Offset: 0x00179AC4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FindPlayerTurnOrder_d__29(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch._FindPlayerTurnOrder_d__29>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004216 RID: 16918 RVA: 0x0017B90C File Offset: 0x00179B0C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004217 RID: 16919 RVA: 0x0017B940 File Offset: 0x00179B40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25914, XrefRangeEnd = 25936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000F8D RID: 3981
			// (get) Token: 0x06004218 RID: 16920 RVA: 0x0017B97C File Offset: 0x00179B7C
			public unsafe WormPlayer System.Collections.Generic.IEnumerator<worm.canis.entities.WormPlayer>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_entities_WormPlayer__get_Current_Private_Virtual_Final_New_get_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
				}
			}

			// Token: 0x06004219 RID: 16921 RVA: 0x0017B9BC File Offset: 0x00179BBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25936, XrefRangeEnd = 25941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F8E RID: 3982
			// (get) Token: 0x0600421A RID: 16922 RVA: 0x0017B9F0 File Offset: 0x00179BF0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600421B RID: 16923 RVA: 0x0017BA30 File Offset: 0x00179C30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25941, XrefRangeEnd = 25950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<WormPlayer> System_Collections_Generic_IEnumerable_worm_canis_entities_WormPlayer__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_entities_WormPlayer__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr3) : null;
			}

			// Token: 0x0600421C RID: 16924 RVA: 0x0017BA70 File Offset: 0x00179C70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._FindPlayerTurnOrder_d__29.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600421D RID: 16925 RVA: 0x00015311 File Offset: 0x00013511
			public _FindPlayerTurnOrder_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F84 RID: 3972
			// (get) Token: 0x0600421E RID: 16926 RVA: 0x0017BAB0 File Offset: 0x00179CB0
			// (set) Token: 0x0600421F RID: 16927 RVA: 0x0001531A File Offset: 0x0001351A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F85 RID: 3973
			// (get) Token: 0x06004220 RID: 16928 RVA: 0x0017BAD8 File Offset: 0x00179CD8
			// (set) Token: 0x06004221 RID: 16929 RVA: 0x00015335 File Offset: 0x00013535
			public unsafe WormPlayer __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F86 RID: 3974
			// (get) Token: 0x06004222 RID: 16930 RVA: 0x0017BB08 File Offset: 0x00179D08
			// (set) Token: 0x06004223 RID: 16931 RVA: 0x00015354 File Offset: 0x00013554
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000F87 RID: 3975
			// (get) Token: 0x06004224 RID: 16932 RVA: 0x0017BB30 File Offset: 0x00179D30
			// (set) Token: 0x06004225 RID: 16933 RVA: 0x0001536F File Offset: 0x0001356F
			public unsafe Func<WormPlayer, bool> findInitialPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr_findInitialPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr_findInitialPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F88 RID: 3976
			// (get) Token: 0x06004226 RID: 16934 RVA: 0x0017BB60 File Offset: 0x00179D60
			// (set) Token: 0x06004227 RID: 16935 RVA: 0x0001538E File Offset: 0x0001358E
			public unsafe Func<WormPlayer, bool> __3__findInitialPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___3__findInitialPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___3__findInitialPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F89 RID: 3977
			// (get) Token: 0x06004228 RID: 16936 RVA: 0x0017BB90 File Offset: 0x00179D90
			// (set) Token: 0x06004229 RID: 16937 RVA: 0x000153AD File Offset: 0x000135AD
			public unsafe WormMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F8A RID: 3978
			// (get) Token: 0x0600422A RID: 16938 RVA: 0x0017BBC0 File Offset: 0x00179DC0
			// (set) Token: 0x0600422B RID: 16939 RVA: 0x000153CC File Offset: 0x000135CC
			public unsafe int _playerCount_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr__playerCount_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr__playerCount_5__2)) = value;
				}
			}

			// Token: 0x17000F8B RID: 3979
			// (get) Token: 0x0600422C RID: 16940 RVA: 0x0017BBE8 File Offset: 0x00179DE8
			// (set) Token: 0x0600422D RID: 16941 RVA: 0x000153E7 File Offset: 0x000135E7
			public unsafe int _firstPlayerIndex_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr__firstPlayerIndex_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr__firstPlayerIndex_5__3)) = value;
				}
			}

			// Token: 0x17000F8C RID: 3980
			// (get) Token: 0x0600422E RID: 16942 RVA: 0x0017BC10 File Offset: 0x00179E10
			// (set) Token: 0x0600422F RID: 16943 RVA: 0x00015402 File Offset: 0x00013602
			public unsafe int _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._FindPlayerTurnOrder_d__29.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x04002BD5 RID: 11221
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002BD6 RID: 11222
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002BD7 RID: 11223
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002BD8 RID: 11224
			private static readonly IntPtr NativeFieldInfoPtr_findInitialPlayer;

			// Token: 0x04002BD9 RID: 11225
			private static readonly IntPtr NativeFieldInfoPtr___3__findInitialPlayer;

			// Token: 0x04002BDA RID: 11226
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002BDB RID: 11227
			private static readonly IntPtr NativeFieldInfoPtr__playerCount_5__2;

			// Token: 0x04002BDC RID: 11228
			private static readonly IntPtr NativeFieldInfoPtr__firstPlayerIndex_5__3;

			// Token: 0x04002BDD RID: 11229
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x04002BDE RID: 11230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002BDF RID: 11231
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002BE0 RID: 11232
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002BE1 RID: 11233
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_worm_canis_entities_WormPlayer__get_Current_Private_Virtual_Final_New_get_WormPlayer_0;

			// Token: 0x04002BE2 RID: 11234
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002BE3 RID: 11235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002BE4 RID: 11236
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_worm_canis_entities_WormPlayer__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_WormPlayer_0;

			// Token: 0x04002BE5 RID: 11237
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000566 RID: 1382
		[ObfuscatedName("worm.canis.WormMatch+<GameSpecificUndoBehavior>d__126")]
		public sealed class _GameSpecificUndoBehavior_d__126 : Object
		{
			// Token: 0x06004230 RID: 16944 RVA: 0x0017BC38 File Offset: 0x00179E38
			// Note: this type is marked as 'beforefieldinit'.
			static _GameSpecificUndoBehavior_d__126()
			{
				Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<GameSpecificUndoBehavior>d__126");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr);
				WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, "<>1__state");
				WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, "<>2__current");
				WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, "<>l__initialThreadId");
				WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr_undoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, "undoNode");
				WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___3__undoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, "<>3__undoNode");
				WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, "<>4__this");
				WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr_undoPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, "undoPlayer");
				WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___3__undoPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, "<>3__undoPlayer");
				WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr__sequenceID_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, "<sequenceID>5__2");
				WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr__sequenceHelper_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, "<sequenceHelper>5__3");
				WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr__undoSequenceWrap_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, "<undoSequenceWrap>5__4");
				WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, "<>7__wrap4");
				WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, 100663584);
				WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, 100663585);
				WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, 100663586);
				WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, 100663587);
				WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, 100663588);
				WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, 100663589);
				WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, 100663590);
				WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, 100663591);
				WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, 100663592);
				WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr, 100663593);
			}

			// Token: 0x06004231 RID: 16945 RVA: 0x0017BE1C File Offset: 0x0017A01C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GameSpecificUndoBehavior_d__126(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch._GameSpecificUndoBehavior_d__126>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004232 RID: 16946 RVA: 0x0017BE64 File Offset: 0x0017A064
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004233 RID: 16947 RVA: 0x0017BE98 File Offset: 0x0017A098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 25950, XrefRangeEnd = 26108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004234 RID: 16948 RVA: 0x0017BED4 File Offset: 0x0017A0D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26108, XrefRangeEnd = 26111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004235 RID: 16949 RVA: 0x0017BF08 File Offset: 0x0017A108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26111, XrefRangeEnd = 26114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F9B RID: 3995
			// (get) Token: 0x06004236 RID: 16950 RVA: 0x0017BF3C File Offset: 0x0017A13C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06004237 RID: 16951 RVA: 0x0017BF7C File Offset: 0x0017A17C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26114, XrefRangeEnd = 26119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000F9C RID: 3996
			// (get) Token: 0x06004238 RID: 16952 RVA: 0x0017BFB0 File Offset: 0x0017A1B0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004239 RID: 16953 RVA: 0x0017BFF0 File Offset: 0x0017A1F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26119, XrefRangeEnd = 26129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600423A RID: 16954 RVA: 0x0017C030 File Offset: 0x0017A230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._GameSpecificUndoBehavior_d__126.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600423B RID: 16955 RVA: 0x0001541D File Offset: 0x0001361D
			public _GameSpecificUndoBehavior_d__126(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F8F RID: 3983
			// (get) Token: 0x0600423C RID: 16956 RVA: 0x0017C070 File Offset: 0x0017A270
			// (set) Token: 0x0600423D RID: 16957 RVA: 0x00015426 File Offset: 0x00013626
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F90 RID: 3984
			// (get) Token: 0x0600423E RID: 16958 RVA: 0x0017C098 File Offset: 0x0017A298
			// (set) Token: 0x0600423F RID: 16959 RVA: 0x00015441 File Offset: 0x00013641
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F91 RID: 3985
			// (get) Token: 0x06004240 RID: 16960 RVA: 0x0017C0C8 File Offset: 0x0017A2C8
			// (set) Token: 0x06004241 RID: 16961 RVA: 0x00015460 File Offset: 0x00013660
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000F92 RID: 3986
			// (get) Token: 0x06004242 RID: 16962 RVA: 0x0017C0F0 File Offset: 0x0017A2F0
			// (set) Token: 0x06004243 RID: 16963 RVA: 0x0001547B File Offset: 0x0001367B
			public unsafe UndoNode undoNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr_undoNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr_undoNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F93 RID: 3987
			// (get) Token: 0x06004244 RID: 16964 RVA: 0x0017C120 File Offset: 0x0017A320
			// (set) Token: 0x06004245 RID: 16965 RVA: 0x0001549A File Offset: 0x0001369A
			public unsafe UndoNode __3__undoNode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___3__undoNode);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___3__undoNode), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F94 RID: 3988
			// (get) Token: 0x06004246 RID: 16966 RVA: 0x0017C150 File Offset: 0x0017A350
			// (set) Token: 0x06004247 RID: 16967 RVA: 0x000154B9 File Offset: 0x000136B9
			public unsafe WormMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F95 RID: 3989
			// (get) Token: 0x06004248 RID: 16968 RVA: 0x0017C180 File Offset: 0x0017A380
			// (set) Token: 0x06004249 RID: 16969 RVA: 0x000154D8 File Offset: 0x000136D8
			public unsafe PlayerEntity undoPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr_undoPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr_undoPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F96 RID: 3990
			// (get) Token: 0x0600424A RID: 16970 RVA: 0x0017C1B0 File Offset: 0x0017A3B0
			// (set) Token: 0x0600424B RID: 16971 RVA: 0x000154F7 File Offset: 0x000136F7
			public unsafe PlayerEntity __3__undoPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___3__undoPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___3__undoPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F97 RID: 3991
			// (get) Token: 0x0600424C RID: 16972 RVA: 0x0017C1E0 File Offset: 0x0017A3E0
			// (set) Token: 0x0600424D RID: 16973 RVA: 0x00015516 File Offset: 0x00013716
			public unsafe SequenceID _sequenceID_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr__sequenceID_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr__sequenceID_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F98 RID: 3992
			// (get) Token: 0x0600424E RID: 16974 RVA: 0x0017C210 File Offset: 0x0017A410
			// (set) Token: 0x0600424F RID: 16975 RVA: 0x00015535 File Offset: 0x00013735
			public unsafe SequenceHelper _sequenceHelper_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr__sequenceHelper_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr__sequenceHelper_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000F99 RID: 3993
			// (get) Token: 0x06004250 RID: 16976 RVA: 0x0017C240 File Offset: 0x0017A440
			// (set) Token: 0x06004251 RID: 16977 RVA: 0x00015554 File Offset: 0x00013754
			public unsafe bool _undoSequenceWrap_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr__undoSequenceWrap_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr__undoSequenceWrap_5__4)) = value;
				}
			}

			// Token: 0x17000F9A RID: 3994
			// (get) Token: 0x06004252 RID: 16978 RVA: 0x0017C268 File Offset: 0x0017A468
			// (set) Token: 0x06004253 RID: 16979 RVA: 0x0001556F File Offset: 0x0001376F
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._GameSpecificUndoBehavior_d__126.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002BE6 RID: 11238
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002BE7 RID: 11239
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002BE8 RID: 11240
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002BE9 RID: 11241
			private static readonly IntPtr NativeFieldInfoPtr_undoNode;

			// Token: 0x04002BEA RID: 11242
			private static readonly IntPtr NativeFieldInfoPtr___3__undoNode;

			// Token: 0x04002BEB RID: 11243
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002BEC RID: 11244
			private static readonly IntPtr NativeFieldInfoPtr_undoPlayer;

			// Token: 0x04002BED RID: 11245
			private static readonly IntPtr NativeFieldInfoPtr___3__undoPlayer;

			// Token: 0x04002BEE RID: 11246
			private static readonly IntPtr NativeFieldInfoPtr__sequenceID_5__2;

			// Token: 0x04002BEF RID: 11247
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__3;

			// Token: 0x04002BF0 RID: 11248
			private static readonly IntPtr NativeFieldInfoPtr__undoSequenceWrap_5__4;

			// Token: 0x04002BF1 RID: 11249
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x04002BF2 RID: 11250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002BF3 RID: 11251
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002BF4 RID: 11252
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002BF5 RID: 11253
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04002BF6 RID: 11254
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04002BF7 RID: 11255
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002BF8 RID: 11256
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002BF9 RID: 11257
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002BFA RID: 11258
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002BFB RID: 11259
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000567 RID: 1383
		[ObfuscatedName("worm.canis.WormMatch+<MakeAnalyticsData>d__125")]
		public sealed class _MakeAnalyticsData_d__125 : Object
		{
			// Token: 0x06004254 RID: 16980 RVA: 0x0017C298 File Offset: 0x0017A498
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeAnalyticsData_d__125()
			{
				Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<MakeAnalyticsData>d__125");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr);
				WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, "<>1__state");
				WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, "<>2__current");
				WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, "<>l__initialThreadId");
				WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, "player");
				WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, "<>3__player");
				WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, "<>4__this");
				WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, 100663594);
				WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, 100663595);
				WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, 100663596);
				WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, 100663597);
				WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, 100663598);
				WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, 100663599);
				WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, 100663600);
				WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr, 100663601);
			}

			// Token: 0x06004255 RID: 16981 RVA: 0x0017C3DC File Offset: 0x0017A5DC
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 26131, RefRangeEnd = 26152, XrefRangeStart = 26129, XrefRangeEnd = 26131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeAnalyticsData_d__125(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch._MakeAnalyticsData_d__125>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004256 RID: 16982 RVA: 0x0017C424 File Offset: 0x0017A624
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004257 RID: 16983 RVA: 0x0017C458 File Offset: 0x0017A658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26152, XrefRangeEnd = 26159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FA3 RID: 4003
			// (get) Token: 0x06004258 RID: 16984 RVA: 0x0017C494 File Offset: 0x0017A694
			public unsafe ValueTuple<string, Object> prop_ValueTuple_2_String_Object_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<string, Object>(intPtr);
				}
			}

			// Token: 0x06004259 RID: 16985 RVA: 0x0017C4CC File Offset: 0x0017A6CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26159, XrefRangeEnd = 26164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FA4 RID: 4004
			// (get) Token: 0x0600425A RID: 16986 RVA: 0x0017C500 File Offset: 0x0017A700
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26164, XrefRangeEnd = 26167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600425B RID: 16987 RVA: 0x0017C540 File Offset: 0x0017A740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26167, XrefRangeEnd = 26176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<string, Object>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<string, Object>>>(intPtr3) : null;
			}

			// Token: 0x0600425C RID: 16988 RVA: 0x0017C580 File Offset: 0x0017A780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeAnalyticsData_d__125.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600425D RID: 16989 RVA: 0x0001558E File Offset: 0x0001378E
			public _MakeAnalyticsData_d__125(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000F9D RID: 3997
			// (get) Token: 0x0600425E RID: 16990 RVA: 0x0017C5C0 File Offset: 0x0017A7C0
			// (set) Token: 0x0600425F RID: 16991 RVA: 0x00015597 File Offset: 0x00013797
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000F9E RID: 3998
			// (get) Token: 0x06004260 RID: 16992 RVA: 0x0017C5E8 File Offset: 0x0017A7E8
			// (set) Token: 0x06004261 RID: 16993 RVA: 0x000155B2 File Offset: 0x000137B2
			public ValueTuple<string, Object> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___2__current);
					return new ValueTuple<string, Object>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, Object>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000F9F RID: 3999
			// (get) Token: 0x06004262 RID: 16994 RVA: 0x0017C618 File Offset: 0x0017A818
			// (set) Token: 0x06004263 RID: 16995 RVA: 0x000155E0 File Offset: 0x000137E0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000FA0 RID: 4000
			// (get) Token: 0x06004264 RID: 16996 RVA: 0x0017C640 File Offset: 0x0017A840
			// (set) Token: 0x06004265 RID: 16997 RVA: 0x000155FB File Offset: 0x000137FB
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FA1 RID: 4001
			// (get) Token: 0x06004266 RID: 16998 RVA: 0x0017C670 File Offset: 0x0017A870
			// (set) Token: 0x06004267 RID: 16999 RVA: 0x0001561A File Offset: 0x0001381A
			public unsafe WormPlayer __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FA2 RID: 4002
			// (get) Token: 0x06004268 RID: 17000 RVA: 0x0017C6A0 File Offset: 0x0017A8A0
			// (set) Token: 0x06004269 RID: 17001 RVA: 0x00015639 File Offset: 0x00013839
			public unsafe WormMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeAnalyticsData_d__125.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002BFC RID: 11260
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002BFD RID: 11261
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002BFE RID: 11262
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002BFF RID: 11263
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002C00 RID: 11264
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04002C01 RID: 11265
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C02 RID: 11266
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002C03 RID: 11267
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002C04 RID: 11268
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002C05 RID: 11269
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_2_String_Object_0;

			// Token: 0x04002C06 RID: 11270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002C07 RID: 11271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002C08 RID: 11272
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_2_String_Object_0;

			// Token: 0x04002C09 RID: 11273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000568 RID: 1384
		[ObfuscatedName("worm.canis.WormMatch+<MakeObfuscatedMovePublicData>d__88")]
		public sealed class _MakeObfuscatedMovePublicData_d__88 : Object
		{
			// Token: 0x0600426A RID: 17002 RVA: 0x0017C6D0 File Offset: 0x0017A8D0
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeObfuscatedMovePublicData_d__88()
			{
				Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<MakeObfuscatedMovePublicData>d__88");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr);
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, "<>1__state");
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, "<>2__current");
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, "<>l__initialThreadId");
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr_movingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, "movingEntity");
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr___3__movingEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, "<>3__movingEntity");
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, 100663602);
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, 100663603);
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, 100663604);
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, 100663605);
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, 100663606);
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, 100663607);
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, 100663608);
				WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr, 100663609);
			}

			// Token: 0x0600426B RID: 17003 RVA: 0x0017C800 File Offset: 0x0017AA00
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeObfuscatedMovePublicData_d__88(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch._MakeObfuscatedMovePublicData_d__88>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600426C RID: 17004 RVA: 0x0017C848 File Offset: 0x0017AA48
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600426D RID: 17005 RVA: 0x0017C87C File Offset: 0x0017AA7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26176, XrefRangeEnd = 26184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FAA RID: 4010
			// (get) Token: 0x0600426E RID: 17006 RVA: 0x0017C8B8 File Offset: 0x0017AAB8
			public unsafe IAttribute System.Collections.Generic.IEnumerator<Canis.attributes.IAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x0600426F RID: 17007 RVA: 0x0017C8F8 File Offset: 0x0017AAF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26184, XrefRangeEnd = 26189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FAB RID: 4011
			// (get) Token: 0x06004270 RID: 17008 RVA: 0x0017C92C File Offset: 0x0017AB2C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004271 RID: 17009 RVA: 0x0017C96C File Offset: 0x0017AB6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26189, XrefRangeEnd = 26197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IAttribute> System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
			}

			// Token: 0x06004272 RID: 17010 RVA: 0x0017C9AC File Offset: 0x0017ABAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004273 RID: 17011 RVA: 0x00015658 File Offset: 0x00013858
			public _MakeObfuscatedMovePublicData_d__88(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FA5 RID: 4005
			// (get) Token: 0x06004274 RID: 17012 RVA: 0x0017C9EC File Offset: 0x0017ABEC
			// (set) Token: 0x06004275 RID: 17013 RVA: 0x00015661 File Offset: 0x00013861
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FA6 RID: 4006
			// (get) Token: 0x06004276 RID: 17014 RVA: 0x0017CA14 File Offset: 0x0017AC14
			// (set) Token: 0x06004277 RID: 17015 RVA: 0x0001567C File Offset: 0x0001387C
			public unsafe IAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FA7 RID: 4007
			// (get) Token: 0x06004278 RID: 17016 RVA: 0x0017CA44 File Offset: 0x0017AC44
			// (set) Token: 0x06004279 RID: 17017 RVA: 0x0001569B File Offset: 0x0001389B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000FA8 RID: 4008
			// (get) Token: 0x0600427A RID: 17018 RVA: 0x0017CA6C File Offset: 0x0017AC6C
			// (set) Token: 0x0600427B RID: 17019 RVA: 0x000156B6 File Offset: 0x000138B6
			public unsafe Entity movingEntity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr_movingEntity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr_movingEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FA9 RID: 4009
			// (get) Token: 0x0600427C RID: 17020 RVA: 0x0017CA9C File Offset: 0x0017AC9C
			// (set) Token: 0x0600427D RID: 17021 RVA: 0x000156D5 File Offset: 0x000138D5
			public unsafe Entity __3__movingEntity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr___3__movingEntity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._MakeObfuscatedMovePublicData_d__88.NativeFieldInfoPtr___3__movingEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C0A RID: 11274
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002C0B RID: 11275
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002C0C RID: 11276
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002C0D RID: 11277
			private static readonly IntPtr NativeFieldInfoPtr_movingEntity;

			// Token: 0x04002C0E RID: 11278
			private static readonly IntPtr NativeFieldInfoPtr___3__movingEntity;

			// Token: 0x04002C0F RID: 11279
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002C10 RID: 11280
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002C11 RID: 11281
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002C12 RID: 11282
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0;

			// Token: 0x04002C13 RID: 11283
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002C14 RID: 11284
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002C15 RID: 11285
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0;

			// Token: 0x04002C16 RID: 11286
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000569 RID: 1385
		[ObfuscatedName("worm.canis.WormMatch+<PreProcessPlayerChoiceWithPlayer>d__87")]
		public sealed class _PreProcessPlayerChoiceWithPlayer_d__87 : Object
		{
			// Token: 0x0600427E RID: 17022 RVA: 0x0017CACC File Offset: 0x0017ACCC
			// Note: this type is marked as 'beforefieldinit'.
			static _PreProcessPlayerChoiceWithPlayer_d__87()
			{
				Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormMatch>.NativeClassPtr, "<PreProcessPlayerChoiceWithPlayer>d__87");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr);
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, "<>1__state");
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, "<>2__current");
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, "<>l__initialThreadId");
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, "player");
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___3__player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, "<>3__player");
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, "selection");
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___3__selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, "<>3__selection");
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, "<>4__this");
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, 100663610);
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, 100663611);
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, 100663612);
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, 100663613);
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, 100663614);
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, 100663615);
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, 100663616);
				WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr, 100663617);
			}

			// Token: 0x0600427F RID: 17023 RVA: 0x0017CC38 File Offset: 0x0017AE38
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PreProcessPlayerChoiceWithPlayer_d__87(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMatch._PreProcessPlayerChoiceWithPlayer_d__87>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004280 RID: 17024 RVA: 0x0017CC80 File Offset: 0x0017AE80
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004281 RID: 17025 RVA: 0x0017CCB4 File Offset: 0x0017AEB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26197, XrefRangeEnd = 26239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FB4 RID: 4020
			// (get) Token: 0x06004282 RID: 17026 RVA: 0x0017CCF0 File Offset: 0x0017AEF0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06004283 RID: 17027 RVA: 0x0017CD30 File Offset: 0x0017AF30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26239, XrefRangeEnd = 26244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FB5 RID: 4021
			// (get) Token: 0x06004284 RID: 17028 RVA: 0x0017CD64 File Offset: 0x0017AF64
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004285 RID: 17029 RVA: 0x0017CDA4 File Offset: 0x0017AFA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26244, XrefRangeEnd = 26254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06004286 RID: 17030 RVA: 0x0017CDE4 File Offset: 0x0017AFE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004287 RID: 17031 RVA: 0x000156F4 File Offset: 0x000138F4
			public _PreProcessPlayerChoiceWithPlayer_d__87(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FAC RID: 4012
			// (get) Token: 0x06004288 RID: 17032 RVA: 0x0017CE24 File Offset: 0x0017B024
			// (set) Token: 0x06004289 RID: 17033 RVA: 0x000156FD File Offset: 0x000138FD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FAD RID: 4013
			// (get) Token: 0x0600428A RID: 17034 RVA: 0x0017CE4C File Offset: 0x0017B04C
			// (set) Token: 0x0600428B RID: 17035 RVA: 0x00015718 File Offset: 0x00013918
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FAE RID: 4014
			// (get) Token: 0x0600428C RID: 17036 RVA: 0x0017CE7C File Offset: 0x0017B07C
			// (set) Token: 0x0600428D RID: 17037 RVA: 0x00015737 File Offset: 0x00013937
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000FAF RID: 4015
			// (get) Token: 0x0600428E RID: 17038 RVA: 0x0017CEA4 File Offset: 0x0017B0A4
			// (set) Token: 0x0600428F RID: 17039 RVA: 0x00015752 File Offset: 0x00013952
			public unsafe PlayerEntity player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FB0 RID: 4016
			// (get) Token: 0x06004290 RID: 17040 RVA: 0x0017CED4 File Offset: 0x0017B0D4
			// (set) Token: 0x06004291 RID: 17041 RVA: 0x00015771 File Offset: 0x00013971
			public unsafe PlayerEntity __3__player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___3__player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___3__player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FB1 RID: 4017
			// (get) Token: 0x06004292 RID: 17042 RVA: 0x0017CF04 File Offset: 0x0017B104
			// (set) Token: 0x06004293 RID: 17043 RVA: 0x00015790 File Offset: 0x00013990
			public unsafe SelectionMessage selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr_selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FB2 RID: 4018
			// (get) Token: 0x06004294 RID: 17044 RVA: 0x0017CF34 File Offset: 0x0017B134
			// (set) Token: 0x06004295 RID: 17045 RVA: 0x000157AF File Offset: 0x000139AF
			public unsafe SelectionMessage __3__selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___3__selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___3__selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FB3 RID: 4019
			// (get) Token: 0x06004296 RID: 17046 RVA: 0x0017CF64 File Offset: 0x0017B164
			// (set) Token: 0x06004297 RID: 17047 RVA: 0x000157CE File Offset: 0x000139CE
			public unsafe WormMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMatch._PreProcessPlayerChoiceWithPlayer_d__87.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C17 RID: 11287
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002C18 RID: 11288
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002C19 RID: 11289
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002C1A RID: 11290
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04002C1B RID: 11291
			private static readonly IntPtr NativeFieldInfoPtr___3__player;

			// Token: 0x04002C1C RID: 11292
			private static readonly IntPtr NativeFieldInfoPtr_selection;

			// Token: 0x04002C1D RID: 11293
			private static readonly IntPtr NativeFieldInfoPtr___3__selection;

			// Token: 0x04002C1E RID: 11294
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002C1F RID: 11295
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002C20 RID: 11296
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002C21 RID: 11297
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002C22 RID: 11298
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002C23 RID: 11299
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002C24 RID: 11300
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002C25 RID: 11301
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002C26 RID: 11302
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200056A RID: 1386
		private sealed class MethodInfoStoreGeneric_GetPlayerByIndex_Public_Virtual_T_Int32_0<T>
		{
			// Token: 0x04002C27 RID: 11303
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(WormMatch.NativeMethodInfoPtr_GetPlayerByIndex_Public_Virtual_T_Int32_0, Il2CppClassPointerStore<WormMatch>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
