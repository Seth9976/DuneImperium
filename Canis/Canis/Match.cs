using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.attributes;
using Canis.data;
using Canis.entities;
using Canis.events;
using Canis.hasExecutionStack;
using Canis.json.events;
using Canis.messageRouters;
using Canis.messages;
using Canis.messages.sequence;
using Canis.skirmishScripts;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Networking.selection.messages;
using Networking.selection.targetinformation;

namespace Canis
{
	// Token: 0x02000023 RID: 35
	public class Match : Object
	{
		// Token: 0x0600014A RID: 330 RVA: 0x0001E364 File Offset: 0x0001C564
		// Note: this type is marked as 'beforefieldinit'.
		static Match()
		{
			Il2CppClassPointerStore<Match>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis", "Match");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match>.NativeClassPtr);
			Match.NativeFieldInfoPtr__MessageRouter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "<MessageRouter>k__BackingField");
			Match.NativeFieldInfoPtr_hasExecutionStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "hasExecutionStacks");
			Match.NativeFieldInfoPtr_MatchDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "MatchDisposed");
			Match.NativeFieldInfoPtr_matchWriteLockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "matchWriteLockObject");
			Match.NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "Initialized");
			Match.NativeFieldInfoPtr_logging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "logging");
			Match.NativeFieldInfoPtr__Random_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "<Random>k__BackingField");
			Match.NativeFieldInfoPtr__SelectionRandom_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "<SelectionRandom>k__BackingField");
			Match.NativeFieldInfoPtr_messageDispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "messageDispatcher");
			Match.NativeFieldInfoPtr__GameID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "<GameID>k__BackingField");
			Match.NativeFieldInfoPtr__HumanAccountIDs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "<HumanAccountIDs>k__BackingField");
			Match.NativeFieldInfoPtr__AIAccountIDs_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "<AIAccountIDs>k__BackingField");
			Match.NativeFieldInfoPtr__ActiveAccountID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "<ActiveAccountID>k__BackingField");
			Match.NativeFieldInfoPtr__matchInitData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "<matchInitData>k__BackingField");
			Match.NativeFieldInfoPtr_Playmat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "Playmat");
			Match.NativeFieldInfoPtr_GameOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "GameOptions");
			Match.NativeFieldInfoPtr_Entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "Entities");
			Match.NativeFieldInfoPtr_ownedByPendingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "ownedByPendingPlayer");
			Match.NativeFieldInfoPtr__EventReactor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "<EventReactor>k__BackingField");
			Match.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "startTime");
			Match.NativeFieldInfoPtr__UseTurnTimers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "<UseTurnTimers>k__BackingField");
			Match.NativeFieldInfoPtr_forceGameOver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "forceGameOver");
			Match.NativeFieldInfoPtr_reconnectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "reconnectingPlayer");
			Match.NativeFieldInfoPtr_reconnectMessageQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "reconnectMessageQueue");
			Match.NativeFieldInfoPtr_SaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "SaveData");
			Match.NativeFieldInfoPtr_WriteSaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "WriteSaveData");
			Match.NativeFieldInfoPtr_WriteNewSaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "WriteNewSaveData");
			Match.NativeFieldInfoPtr_WritePlayerResignedState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "WritePlayerResignedState");
			Match.NativeFieldInfoPtr_WriteSimultaneousSaveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "WriteSimultaneousSaveData");
			Match.NativeFieldInfoPtr_PlayerNotifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "PlayerNotifier");
			Match.NativeFieldInfoPtr_RemoveIdlePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "RemoveIdlePlayer");
			Match.NativeFieldInfoPtr_LastSelectionMessageV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "LastSelectionMessageV2");
			Match.NativeFieldInfoPtr_TimerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "TimerID");
			Match.NativeFieldInfoPtr_TimerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "TimerType");
			Match.NativeFieldInfoPtr_aiLogging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "aiLogging");
			Match.NativeFieldInfoPtr_disconnectedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "disconnectedPlayers");
			Match.NativeFieldInfoPtr__MessageActionFactory_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "<MessageActionFactory>k__BackingField");
			Match.NativeFieldInfoPtr_LastSelectionMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "LastSelectionMessage");
			Match.NativeFieldInfoPtr__activeSelectionMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_activeSelectionMessages");
			Match.NativeFieldInfoPtr_PreviousAISelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "PreviousAISelections");
			Match.NativeFieldInfoPtr__activeTimers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match>.NativeClassPtr, "_activeTimers");
			Match.NativeMethodInfoPtr_get_MessageRouter_Protected_get_MainMessageRouter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663530);
			Match.NativeMethodInfoPtr_set_MessageRouter_Protected_set_Void_MainMessageRouter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663531);
			Match.NativeMethodInfoPtr_GetHasExecutionStack_Public_IHasExecutionStack_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663532);
			Match.NativeMethodInfoPtr_GetArchetypesLock_Public_Abstract_Virtual_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663533);
			Match.NativeMethodInfoPtr_get_Random_Public_get_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663534);
			Match.NativeMethodInfoPtr_set_Random_Private_set_Void_CanisRandom_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663535);
			Match.NativeMethodInfoPtr_get_SelectionRandom_Public_get_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663536);
			Match.NativeMethodInfoPtr_set_SelectionRandom_Private_set_Void_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663537);
			Match.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663538);
			Match.NativeMethodInfoPtr_set_GameID_Private_set_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663539);
			Match.NativeMethodInfoPtr_get_HumanAccountIDs_Public_get_Il2CppReferenceArray_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663540);
			Match.NativeMethodInfoPtr_set_HumanAccountIDs_Protected_set_Void_Il2CppReferenceArray_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663541);
			Match.NativeMethodInfoPtr_get_AIAccountIDs_Public_get_Il2CppReferenceArray_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663542);
			Match.NativeMethodInfoPtr_set_AIAccountIDs_Protected_set_Void_Il2CppReferenceArray_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663543);
			Match.NativeMethodInfoPtr_get_ActiveAccountID_Public_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663544);
			Match.NativeMethodInfoPtr_set_ActiveAccountID_Public_set_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663545);
			Match.NativeMethodInfoPtr_get_matchInitData_Public_get_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663546);
			Match.NativeMethodInfoPtr_set_matchInitData_Private_set_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663547);
			Match.NativeMethodInfoPtr_get_EventReactor_Public_get_EventReactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663548);
			Match.NativeMethodInfoPtr_set_EventReactor_Protected_set_Void_EventReactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663549);
			Match.NativeMethodInfoPtr_get_ActiveSequences_Public_get_IReadOnlyList_1_DBGSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663550);
			Match.NativeMethodInfoPtr_passToPlayerAction_Public_Abstract_Virtual_New_Action_PlayerEntity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663551);
			Match.NativeMethodInfoPtr_GetGameResults_Public_Abstract_Virtual_New_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663552);
			Match.NativeMethodInfoPtr_getGameResults_Public_Abstract_Virtual_New_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663553);
			Match.NativeMethodInfoPtr_HandleResignGame_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663554);
			Match.NativeMethodInfoPtr_HandleIdleResignFromGame_Public_Abstract_Virtual_New_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663555);
			Match.NativeMethodInfoPtr_GameOverCleanup_Public_Abstract_Virtual_New_Void_List_1_AccountID_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663556);
			Match.NativeMethodInfoPtr_GetPreAIDecisionAction_Public_Abstract_Virtual_New_Action_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663557);
			Match.NativeMethodInfoPtr_PreProcessPlayerChoice_Public_Virtual_New_Action_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663558);
			Match.NativeMethodInfoPtr_PreProcessPlayerChoiceWithPlayer_Public_Virtual_New_IEnumerable_1_Action_SelectionMessage_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663559);
			Match.NativeMethodInfoPtr_get_UseTurnTimers_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663560);
			Match.NativeMethodInfoPtr_set_UseTurnTimers_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663561);
			Match.NativeMethodInfoPtr_SetReconnectingPlayer_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663562);
			Match.NativeMethodInfoPtr_get_IsReconnecting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663563);
			Match.NativeMethodInfoPtr_get_ReconnectMessageQueue_Public_get_List_1_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663564);
			Match.NativeMethodInfoPtr_get_SendNumChildrenAttributeModified_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663565);
			Match.NativeMethodInfoPtr_get_AnalyticsGameID_Public_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663566);
			Match.NativeMethodInfoPtr_set_AnalyticsGameID_Protected_set_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663567);
			Match.NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_MatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663568);
			Match.NativeMethodInfoPtr_get_BasicPlayers_Public_Abstract_Virtual_New_get_IEnumerable_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663569);
			Match.NativeMethodInfoPtr_AddPlayer_Public_Abstract_Virtual_New_Void_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663570);
			Match.NativeMethodInfoPtr_GetPlayerEntity_Public_Abstract_Virtual_New_PlayerEntity_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663571);
			Match.NativeMethodInfoPtr_CreateEntity_Public_Abstract_Virtual_New_Entity_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663572);
			Match.NativeMethodInfoPtr_GetPlayerByIndex_Public_Abstract_Virtual_New_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663573);
			Match.NativeMethodInfoPtr_get_MatchType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663574);
			Match.NativeMethodInfoPtr_get_IsTutorial_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663575);
			Match.NativeMethodInfoPtr_get_IsPassAndPlay_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663576);
			Match.NativeMethodInfoPtr_get_IsSimultaneousSolo_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663577);
			Match.NativeMethodInfoPtr_get_IsPBM_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663578);
			Match.NativeMethodInfoPtr_get_IsSolo_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663579);
			Match.NativeMethodInfoPtr_get_IsFriend_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663580);
			Match.NativeMethodInfoPtr_get_IsLive_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663581);
			Match.NativeMethodInfoPtr_get_IsCasual_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663582);
			Match.NativeMethodInfoPtr_get_IsOnline_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663583);
			Match.NativeMethodInfoPtr_get_IsCampaign_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663584);
			Match.NativeMethodInfoPtr_get_IsDailyChallenge_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663585);
			Match.NativeMethodInfoPtr_get_IsSkirmish_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663586);
			Match.NativeMethodInfoPtr_get_IsRanked_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663587);
			Match.NativeMethodInfoPtr_get_IsEvent_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663588);
			Match.NativeMethodInfoPtr_get_GetEventID_Public_Virtual_New_get_EventID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663589);
			Match.NativeMethodInfoPtr_get_GetRoundID_Public_Virtual_New_get_RoundID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663590);
			Match.NativeMethodInfoPtr_get_ShouldIncludeAccountIDOnMessage_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663591);
			Match.NativeMethodInfoPtr_get_IsAIOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663592);
			Match.NativeMethodInfoPtr_get_IsOptimization_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663593);
			Match.NativeMethodInfoPtr_get_SkipLiveReplay_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663594);
			Match.NativeMethodInfoPtr_IsFirstSelectionTurn_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663595);
			Match.NativeMethodInfoPtr_GetEntityOption_Public_IEnumerable_1_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663596);
			Match.NativeMethodInfoPtr_GetEntityOption_Public_IEnumerable_1_T_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663597);
			Match.NativeMethodInfoPtr_TryGetEntity_Public_Boolean_EntityID_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663598);
			Match.NativeMethodInfoPtr_TryGetEntity_Public_Boolean_EntityID_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663599);
			Match.NativeMethodInfoPtr_LookupEntities_Public_IEnumerable_1_Entity_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663600);
			Match.NativeMethodInfoPtr_LookupEntities_Public_IEnumerable_1_T_IEnumerable_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663601);
			Match.NativeMethodInfoPtr_AddEntityForPendingPlayer_Public_Void_AccountID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663602);
			Match.NativeMethodInfoPtr_ClaimOwnedEntitiesForPending_Public_IEnumerable_1_Entity_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663603);
			Match.NativeMethodInfoPtr_SaveInitialState_Public_Void_AccountID_SerializedGameState_List_1_PlayerInfoSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663604);
			Match.NativeMethodInfoPtr_MakeNewSaveData_Private_SaveData_SerializedGameState_List_1_PlayerInfoSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663605);
			Match.NativeMethodInfoPtr_get_SerializedEventReactor_Private_get_SerializedEventReactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663606);
			Match.NativeMethodInfoPtr_RestoreSerializedEventReactor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663607);
			Match.NativeMethodInfoPtr_SaveSimultaneousPlayers_Public_Void_AccountID_IEnumerable_1_AccountID_SerializedGameState_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663608);
			Match.NativeMethodInfoPtr_SendNotificationToPlayer_Public_Void_AccountID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663609);
			Match.NativeMethodInfoPtr_ClearDisplayActionsForPlayer_Public_Void_AccountID_SerializedGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663610);
			Match.NativeMethodInfoPtr_get_GetTurnForSaveData_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663611);
			Match.NativeMethodInfoPtr_PostClearDisplayActions_Public_Virtual_New_Void_PlayerEntity_PlayerSaveData_Dictionary_2_PlayerEntity_List_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663612);
			Match.NativeMethodInfoPtr_SaveOnPause_Public_Virtual_New_Void_PlayerEntity_Il2CppReferenceArray_1_PlayerEntity_IEnumerable_1_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663613);
			Match.NativeMethodInfoPtr_ClearDisplayActionsOnSave_Public_Virtual_New_IEnumerable_1_PlayerEntity_PlayerEntity_Dictionary_2_PlayerEntity_List_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663614);
			Match.NativeMethodInfoPtr_IsInSelectionLoop_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663615);
			Match.NativeMethodInfoPtr_ShouldResetSelectionCount_Public_Virtual_New_Boolean_IHasExecutionStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663616);
			Match.NativeMethodInfoPtr_Run_Public_Void_String_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663617);
			Match.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Object_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663618);
			Match.NativeMethodInfoPtr_LogGameCrashToAnalytics_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663619);
			Match.NativeMethodInfoPtr_EndGameImmediately_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663620);
			Match.NativeMethodInfoPtr_SetNonPromptText_Public_Virtual_New_IEnumerable_1_Action_LocalizableTextVariables_IEnumerable_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663621);
			Match.NativeMethodInfoPtr_ClearNonPromptText_Public_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663622);
			Match.NativeMethodInfoPtr_Resign_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663623);
			Match.NativeMethodInfoPtr_OnPlayerDisconnected_Public_Virtual_New_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663624);
			Match.NativeMethodInfoPtr_validForDisplayAction_Protected_Virtual_New_Boolean_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663625);
			Match.NativeMethodInfoPtr_DispatchMessage_Public_Void_AccountID_DWDEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663626);
			Match.NativeMethodInfoPtr_SetMessageDispatcher_Public_Void_Action_2_AccountID_DWDEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663627);
			Match.NativeMethodInfoPtr_SetWriteSaveData_Public_Void_Action_1_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663628);
			Match.NativeMethodInfoPtr_SetWriteSimultaneousSaveData_Public_Void_Func_4_SaveData_AccountID_IEnumerable_1_AccountID_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663629);
			Match.NativeMethodInfoPtr_SetWritePlayerResignedState_Public_Void_Func_3_SerializedGameState_AccountID_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663630);
			Match.NativeMethodInfoPtr_SetWriteNewSaveData_Public_Void_Func_2_SaveData_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663631);
			Match.NativeMethodInfoPtr_SetSaveData_Public_Void_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663632);
			Match.NativeMethodInfoPtr_SetNotifier_Public_Void_Func_3_String_AccountID_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663633);
			Match.NativeMethodInfoPtr_SetRemoveIdlePlayer_Public_Void_Func_2_AccountID_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663634);
			Match.NativeMethodInfoPtr_GetNextSelectionCounter_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663635);
			Match.NativeMethodInfoPtr_HasPendingResponse_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663636);
			Match.NativeMethodInfoPtr_IsGameOver_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663637);
			Match.NativeMethodInfoPtr_IsMatchOver_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663638);
			Match.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663639);
			Match.NativeMethodInfoPtr_AddDeviceIDForAnalyticsIfOfflineMatch_Public_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663640);
			Match.NativeMethodInfoPtr_EntityIDDebugInfo_Protected_String_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663641);
			Match.NativeMethodInfoPtr_TargetInfoDebugInfo_Public_Virtual_New_String_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663642);
			Match.NativeMethodInfoPtr_SelectionDebugInfo_Public_Virtual_New_String_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663643);
			Match.NativeMethodInfoPtr_CurrentPlayer_Public_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663644);
			Match.NativeMethodInfoPtr_AddClientInfoForAnalyticsIfOfflineMatch_Public_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663645);
			Match.NativeMethodInfoPtr_IsInPlay_Public_Abstract_Virtual_New_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663646);
			Match.NativeMethodInfoPtr_get_AILogging_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663647);
			Match.NativeMethodInfoPtr_set_AILogging_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663648);
			Match.NativeMethodInfoPtr_AILog_Public_Abstract_Virtual_New_Void_PlayerEntity_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663649);
			Match.NativeMethodInfoPtr_AIDecisionDelayForSelection_Public_Virtual_New_Nullable_1_Int32_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663650);
			Match.NativeMethodInfoPtr_FinishReconnect_Public_Virtual_New_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663651);
			Match.NativeMethodInfoPtr_ShouldNotifyPlayer_Public_Virtual_New_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663652);
			Match.NativeMethodInfoPtr_GetAdditionalPlayerMetadata_Public_Virtual_New_Dictionary_2_String_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663653);
			Match.NativeMethodInfoPtr_UpdatePlayerData_Public_Virtual_New_Void_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663654);
			Match.NativeMethodInfoPtr_SetPlayerDataForResignFromGame_Protected_Virtual_New_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663655);
			Match.NativeMethodInfoPtr_HandleResignGame_Protected_Virtual_New_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663656);
			Match.NativeMethodInfoPtr_HandleResignGameAsync_Public_Task_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663657);
			Match.NativeMethodInfoPtr_SetPlayerResignedState_Public_Void_SerializedGameState_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663658);
			Match.NativeMethodInfoPtr_HasResigned_Public_Virtual_New_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663659);
			Match.NativeMethodInfoPtr_get_MessageActionFactory_Public_Virtual_New_get_IMessageActionFactory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663660);
			Match.NativeMethodInfoPtr_SetActiveSelectionOfPlayer_Public_Void_AccountID_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663661);
			Match.NativeMethodInfoPtr_RemoveActiveSelectionOfPlayer_Public_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663662);
			Match.NativeMethodInfoPtr_HandleIdleTurn_Public_Virtual_New_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663663);
			Match.NativeMethodInfoPtr_ShouldSaveOnPause_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663664);
			Match.NativeMethodInfoPtr_AllowMultiSelectionCounter_Public_Virtual_New_Boolean_PlayerEntity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663665);
			Match.NativeMethodInfoPtr_AnyPlayerIsSelecting_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663666);
			Match.NativeMethodInfoPtr_PlayerIsSelecting_Protected_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663667);
			Match.NativeMethodInfoPtr_PlayerIDsMakingSelections_Private_IEnumerable_1_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663668);
			Match.NativeMethodInfoPtr_ActiveSelectionsOfPlayer_Public_IEnumerable_1_SelectionMessage_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663669);
			Match.NativeMethodInfoPtr_PlayerIDForSelection_Public_AccountID_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663670);
			Match.NativeMethodInfoPtr_CalcifyTarget_Public_Virtual_New_Nullable_1_KeyValuePair_2_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663671);
			Match.NativeMethodInfoPtr_ReifyTarget_Public_Virtual_New_Object_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663672);
			Match.NativeMethodInfoPtr_MakeObfuscatedNumChildren_Public_Virtual_New_IEnumerable_1_IAttribute_1_Nullable_1_Int32_Entity_AccountID_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663673);
			Match.NativeMethodInfoPtr_MakeObfuscatedNumChildren_Public_Virtual_New_IEnumerable_1_IAttribute_1_Nullable_1_Int32_SerializedEntity_Il2CppReferenceArray_1_SerializedEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663674);
			Match.NativeMethodInfoPtr_MakeObfuscatedMovePublicData_Public_Virtual_New_IEnumerable_1_IAttribute_Entity_EntityID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663675);
			Match.NativeMethodInfoPtr_MakeObfuscatedMovePublicData_Public_Virtual_New_IEnumerable_1_IAttribute_SerializedEntity_EntityID_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663676);
			Match.NativeMethodInfoPtr_get_NumberOfAISelectionsToStore_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663677);
			Match.NativeMethodInfoPtr_StoreAISelectionForLog_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663678);
			Match.NativeMethodInfoPtr_GetPreviousAISelections_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663679);
			Match.NativeMethodInfoPtr_PrePendSelection_Public_Virtual_New_IEnumerable_1_Action_List_1_ValueTuple_2_PlayerEntity_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663680);
			Match.NativeMethodInfoPtr_get_TimerMode_Public_Abstract_Virtual_New_get_TimerModes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663681);
			Match.NativeMethodInfoPtr_get_TimerLength_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663682);
			Match.NativeMethodInfoPtr_get_UseTimers_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663683);
			Match.NativeMethodInfoPtr_get_ActiveTimers_Public_get_IReadOnlyCollection_1_TimerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663684);
			Match.NativeMethodInfoPtr_TrackTimer_Public_Void_TimerID_String_AccountID_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663685);
			Match.NativeMethodInfoPtr_TrackTimer_Public_Void_TimerID_String_Il2CppReferenceArray_1_ValueTuple_2_AccountID_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663686);
			Match.NativeMethodInfoPtr_UntrackTimer_Public_Void_TimerID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663687);
			Match.NativeMethodInfoPtr_CancelTimersForCounter_Public_Void_AccountID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663688);
			Match.NativeMethodInfoPtr_TimerIsActive_Public_Boolean_TimerID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663689);
			Match.NativeMethodInfoPtr_TimeoutDisconnectedPlayer_Public_Virtual_New_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663690);
			Match.NativeMethodInfoPtr_ShouldSetTimerForSelection_Public_Virtual_New_Boolean_PlayerEntity_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663691);
			Match.NativeMethodInfoPtr_GetTimerForSelection_Public_Virtual_New_Int32_PlayerEntity_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663692);
			Match.NativeMethodInfoPtr_GetTimerPaddingForSelection_Public_Virtual_New_Single_PlayerEntity_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663693);
			Match.NativeMethodInfoPtr_GetTotalTimerTime_Public_Virtual_New_Int32_PlayerEntity_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663694);
			Match.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663695);
			Match.NativeMethodInfoPtr__Configure_b__78_0_Private_MatchInitData_MatchInitData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663696);
			Match.NativeMethodInfoPtr__ClaimOwnedEntitiesForPending_b__145_0_Private_IEnumerable_1_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663697);
			Match.NativeMethodInfoPtr__TargetInfoDebugInfo_b__186_0_Private_String_KeyValuePair_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663698);
			Match.NativeMethodInfoPtr__TargetInfoDebugInfo_b__186_1_Private_String_KeyValuePair_2_Int32_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663699);
			Match.NativeMethodInfoPtr__SelectionDebugInfo_b__187_0_Private_String_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match>.NativeClassPtr, 100663700);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0001F424 File Offset: 0x0001D624
		// (set) Token: 0x0600014C RID: 332 RVA: 0x0001F464 File Offset: 0x0001D664
		public unsafe MainMessageRouter MessageRouter
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_MessageRouter_Protected_get_MainMessageRouter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MainMessageRouter>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_MessageRouter_Protected_set_Void_MainMessageRouter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0001F4A8 File Offset: 0x0001D6A8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 545364, RefRangeEnd = 545384, XrefRangeStart = 545345, XrefRangeEnd = 545364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IHasExecutionStack GetHasExecutionStack(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_GetHasExecutionStack_Public_IHasExecutionStack_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasExecutionStack>(intPtr3) : null;
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0001F4F8 File Offset: 0x0001D6F8
		[CallerCount(0)]
		public unsafe virtual Object GetArchetypesLock()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_GetArchetypesLock_Public_Abstract_Virtual_New_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0001F544 File Offset: 0x0001D744
		// (set) Token: 0x06000150 RID: 336 RVA: 0x0001F584 File Offset: 0x0001D784
		public unsafe CanisRandom Random
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_Random_Public_get_CanisRandom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CanisRandom>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_Random_Private_set_Void_CanisRandom_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0001F5C8 File Offset: 0x0001D7C8
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0001F608 File Offset: 0x0001D808
		public unsafe Random SelectionRandom
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_SelectionRandom_Public_get_Random_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Random>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_SelectionRandom_Private_set_Void_Random_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000153 RID: 339 RVA: 0x0001F64C File Offset: 0x0001D84C
		// (set) Token: 0x06000154 RID: 340 RVA: 0x0001F68C File Offset: 0x0001D88C
		public unsafe GameID GameID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_GameID_Public_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_GameID_Private_set_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000155 RID: 341 RVA: 0x0001F6D0 File Offset: 0x0001D8D0
		// (set) Token: 0x06000156 RID: 342 RVA: 0x0001F710 File Offset: 0x0001D910
		public unsafe Il2CppReferenceArray<AccountID> HumanAccountIDs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_HumanAccountIDs_Public_get_Il2CppReferenceArray_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_HumanAccountIDs_Protected_set_Void_Il2CppReferenceArray_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000157 RID: 343 RVA: 0x0001F754 File Offset: 0x0001D954
		// (set) Token: 0x06000158 RID: 344 RVA: 0x0001F794 File Offset: 0x0001D994
		public unsafe Il2CppReferenceArray<AccountID> AIAccountIDs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_AIAccountIDs_Public_get_Il2CppReferenceArray_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_AIAccountIDs_Protected_set_Void_Il2CppReferenceArray_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000159 RID: 345 RVA: 0x0001F7D8 File Offset: 0x0001D9D8
		// (set) Token: 0x0600015A RID: 346 RVA: 0x0001F818 File Offset: 0x0001DA18
		public unsafe AccountID ActiveAccountID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_ActiveAccountID_Public_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_ActiveAccountID_Public_set_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0001F85C File Offset: 0x0001DA5C
		// (set) Token: 0x0600015C RID: 348 RVA: 0x0001F89C File Offset: 0x0001DA9C
		public unsafe MatchInitData matchInitData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_matchInitData_Public_get_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_matchInitData_Private_set_Void_MatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0001F8E0 File Offset: 0x0001DAE0
		// (set) Token: 0x0600015E RID: 350 RVA: 0x0001F920 File Offset: 0x0001DB20
		public unsafe EventReactor EventReactor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_EventReactor_Public_get_EventReactor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventReactor>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_EventReactor_Protected_set_Void_EventReactor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600015F RID: 351 RVA: 0x0001F964 File Offset: 0x0001DB64
		public unsafe IReadOnlyList<DBGSequence> ActiveSequences
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 545398, RefRangeEnd = 545409, XrefRangeStart = 545384, XrefRangeEnd = 545398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_ActiveSequences_Public_get_IReadOnlyList_1_DBGSequence_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DBGSequence>>(intPtr3) : null;
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0001F9A4 File Offset: 0x0001DBA4
		[CallerCount(0)]
		public unsafe virtual Canis.actions.Action passToPlayerAction(PlayerEntity player, bool forced = false)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_passToPlayerAction_Public_Abstract_Virtual_New_Action_PlayerEntity_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0001FA10 File Offset: 0x0001DC10
		[CallerCount(0)]
		public unsafe virtual Canis.actions.Action GetGameResults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_GetGameResults_Public_Abstract_Virtual_New_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0001FA5C File Offset: 0x0001DC5C
		[CallerCount(0)]
		public unsafe virtual DBGGameResults getGameResults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_getGameResults_Public_Abstract_Virtual_New_DBGGameResults_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGGameResults>(intPtr3) : null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0001FAA8 File Offset: 0x0001DCA8
		[CallerCount(0)]
		public unsafe virtual void HandleResignGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_HandleResignGame_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0001FAE4 File Offset: 0x0001DCE4
		[CallerCount(0)]
		public unsafe virtual void HandleIdleResignFromGame(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_HandleIdleResignFromGame_Public_Abstract_Virtual_New_Void_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0001FB34 File Offset: 0x0001DD34
		[CallerCount(0)]
		public unsafe virtual void GameOverCleanup(List<AccountID> playerIDs, DBGGameResults gameResults)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_GameOverCleanup_Public_Abstract_Virtual_New_Void_List_1_AccountID_DBGGameResults_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0001FB94 File Offset: 0x0001DD94
		[CallerCount(0)]
		public unsafe virtual Canis.actions.Action GetPreAIDecisionAction(SelectionMessage selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_GetPreAIDecisionAction_Public_Abstract_Virtual_New_Action_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545409, XrefRangeEnd = 545413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Canis.actions.Action PreProcessPlayerChoice(SelectionMessage selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_PreProcessPlayerChoice_Public_Virtual_New_Action_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0001FC4C File Offset: 0x0001DE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545413, XrefRangeEnd = 545419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> PreProcessPlayerChoiceWithPlayer(SelectionMessage selection, PlayerEntity player)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_PreProcessPlayerChoiceWithPlayer_Public_Virtual_New_IEnumerable_1_Action_SelectionMessage_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0001FCBC File Offset: 0x0001DEBC
		// (set) Token: 0x0600016A RID: 362 RVA: 0x0001FCF8 File Offset: 0x0001DEF8
		public unsafe bool UseTurnTimers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_UseTurnTimers_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_UseTurnTimers_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0001FD38 File Offset: 0x0001DF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545419, XrefRangeEnd = 545430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReconnectingPlayer(bool reconnecting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reconnecting;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SetReconnectingPlayer_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0001FD78 File Offset: 0x0001DF78
		public unsafe bool IsReconnecting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_IsReconnecting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0001FDB4 File Offset: 0x0001DFB4
		public unsafe List<DWDEvent> ReconnectMessageQueue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545430, XrefRangeEnd = 545433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_ReconnectMessageQueue_Public_get_List_1_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DWDEvent>>(intPtr3) : null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0001FDF4 File Offset: 0x0001DFF4
		public unsafe virtual bool SendNumChildrenAttributeModified
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_SendNumChildrenAttributeModified_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0001FE3C File Offset: 0x0001E03C
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0001FE7C File Offset: 0x0001E07C
		public unsafe GameID AnalyticsGameID
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 545443, RefRangeEnd = 545452, XrefRangeStart = 545433, XrefRangeEnd = 545443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_AnalyticsGameID_Public_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 545460, RefRangeEnd = 545462, XrefRangeStart = 545452, XrefRangeEnd = 545460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_AnalyticsGameID_Protected_set_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 545515, RefRangeEnd = 545516, XrefRangeStart = 545462, XrefRangeEnd = 545515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Configure(MatchInitData mid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_MatchInitData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000172 RID: 370 RVA: 0x0001FF10 File Offset: 0x0001E110
		public unsafe virtual IEnumerable<PlayerEntity> BasicPlayers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_BasicPlayers_Public_Abstract_Virtual_New_get_IEnumerable_1_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0001FF5C File Offset: 0x0001E15C
		[CallerCount(0)]
		public unsafe virtual void AddPlayer(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_AddPlayer_Public_Abstract_Virtual_New_Void_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0001FFAC File Offset: 0x0001E1AC
		[CallerCount(0)]
		public unsafe virtual PlayerEntity GetPlayerEntity(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_GetPlayerEntity_Public_Abstract_Virtual_New_PlayerEntity_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00020008 File Offset: 0x0001E208
		[CallerCount(0)]
		public unsafe virtual Entity CreateEntity(SerializedEntity se, Match m, Entity parent)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_CreateEntity_Public_Abstract_Virtual_New_Entity_SerializedEntity_Match_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00020088 File Offset: 0x0001E288
		[CallerCount(0)]
		public unsafe virtual T GetPlayerByIndex<T>(int index) where T : PlayerEntity
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.MethodInfoStoreGeneric_GetPlayerByIndex_Public_Abstract_Virtual_New_T_Int32_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000200DC File Offset: 0x0001E2DC
		public unsafe string MatchType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 545522, RefRangeEnd = 545524, XrefRangeStart = 545516, XrefRangeEnd = 545522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_MatchType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00020114 File Offset: 0x0001E314
		public unsafe virtual bool IsTutorial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545524, XrefRangeEnd = 545533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsTutorial_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0002015C File Offset: 0x0001E35C
		public unsafe virtual bool IsPassAndPlay
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545533, XrefRangeEnd = 545542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsPassAndPlay_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600017A RID: 378 RVA: 0x000201A4 File Offset: 0x0001E3A4
		public unsafe virtual bool IsSimultaneousSolo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545542, XrefRangeEnd = 545551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsSimultaneousSolo_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000201EC File Offset: 0x0001E3EC
		public unsafe virtual bool IsPBM
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545551, XrefRangeEnd = 545560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsPBM_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00020234 File Offset: 0x0001E434
		public unsafe virtual bool IsSolo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545560, XrefRangeEnd = 545568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsSolo_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0002027C File Offset: 0x0001E47C
		public unsafe virtual bool IsFriend
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545568, XrefRangeEnd = 545577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsFriend_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000202C4 File Offset: 0x0001E4C4
		public unsafe virtual bool IsLive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545577, XrefRangeEnd = 545586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsLive_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0002030C File Offset: 0x0001E50C
		public unsafe virtual bool IsCasual
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545586, XrefRangeEnd = 545595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsCasual_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000180 RID: 384 RVA: 0x00020354 File Offset: 0x0001E554
		public unsafe virtual bool IsOnline
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsOnline_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0002039C File Offset: 0x0001E59C
		public unsafe virtual bool IsCampaign
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545595, XrefRangeEnd = 545604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsCampaign_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000203E4 File Offset: 0x0001E5E4
		public unsafe virtual bool IsDailyChallenge
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545604, XrefRangeEnd = 545613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsDailyChallenge_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0002042C File Offset: 0x0001E62C
		public unsafe virtual bool IsSkirmish
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsSkirmish_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00020474 File Offset: 0x0001E674
		public unsafe virtual bool IsRanked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsRanked_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000185 RID: 389 RVA: 0x000204BC File Offset: 0x0001E6BC
		public unsafe virtual bool IsEvent
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_IsEvent_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00020504 File Offset: 0x0001E704
		public unsafe virtual EventID GetEventID
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_GetEventID_Public_Virtual_New_get_EventID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EventID>(intPtr3) : null;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00020550 File Offset: 0x0001E750
		public unsafe virtual RoundID GetRoundID
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_GetRoundID_Public_Virtual_New_get_RoundID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RoundID>(intPtr3) : null;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000188 RID: 392 RVA: 0x0002059C File Offset: 0x0001E79C
		public unsafe virtual bool ShouldIncludeAccountIDOnMessage
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_ShouldIncludeAccountIDOnMessage_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000189 RID: 393 RVA: 0x000205E4 File Offset: 0x0001E7E4
		public unsafe bool IsAIOnly
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 545632, RefRangeEnd = 545638, XrefRangeStart = 545613, XrefRangeEnd = 545632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_IsAIOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00020620 File Offset: 0x0001E820
		public unsafe bool IsOptimization
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 545647, RefRangeEnd = 545649, XrefRangeStart = 545638, XrefRangeEnd = 545647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_IsOptimization_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0002065C File Offset: 0x0001E85C
		public unsafe virtual bool SkipLiveReplay
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_SkipLiveReplay_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000206A4 File Offset: 0x0001E8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545649, XrefRangeEnd = 545650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsFirstSelectionTurn(int turnNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref turnNumber;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_IsFirstSelectionTurn_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000206F8 File Offset: 0x0001E8F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545650, XrefRangeEnd = 545657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetEntityOption(EntityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_GetEntityOption_Public_IEnumerable_1_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00020748 File Offset: 0x0001E948
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 545663, RefRangeEnd = 545664, XrefRangeStart = 545657, XrefRangeEnd = 545663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> GetEntityOption<T>(EntityID id) where T : Entity
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.MethodInfoStoreGeneric_GetEntityOption_Public_IEnumerable_1_T_EntityID_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00020798 File Offset: 0x0001E998
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 545672, RefRangeEnd = 545727, XrefRangeStart = 545664, XrefRangeEnd = 545672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetEntity(EntityID id, out Entity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_TryGetEntity_Public_Boolean_EntityID_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			entity = ((intPtr4 == 0) ? null : new Entity(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00020808 File Offset: 0x0001EA08
		[CallerCount(92)]
		[CachedScanResults(RefRangeStart = 545743, RefRangeEnd = 545835, XrefRangeStart = 545727, XrefRangeEnd = 545743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetEntity<T>(EntityID id, out T entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref entity;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Match.MethodInfoStoreGeneric_TryGetEntity_Public_Boolean_EntityID_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				entity = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000208A4 File Offset: 0x0001EAA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 545838, RefRangeEnd = 545839, XrefRangeStart = 545835, XrefRangeEnd = 545838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> LookupEntities(IEnumerable<EntityID> entityIDs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityIDs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_LookupEntities_Public_IEnumerable_1_Entity_IEnumerable_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000208F4 File Offset: 0x0001EAF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 545845, RefRangeEnd = 545849, XrefRangeStart = 545839, XrefRangeEnd = 545845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> LookupEntities<T>(IEnumerable<EntityID> entityIDs) where T : Entity
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityIDs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.MethodInfoStoreGeneric_LookupEntities_Public_IEnumerable_1_T_IEnumerable_1_EntityID_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00020944 File Offset: 0x0001EB44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 545864, RefRangeEnd = 545865, XrefRangeStart = 545849, XrefRangeEnd = 545864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddEntityForPendingPlayer(AccountID owner, Entity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_AddEntityForPendingPlayer_Public_Void_AccountID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00020998 File Offset: 0x0001EB98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 545872, RefRangeEnd = 545873, XrefRangeStart = 545865, XrefRangeEnd = 545872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> ClaimOwnedEntitiesForPending(AccountID owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(owner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_ClaimOwnedEntitiesForPending_Public_IEnumerable_1_Entity_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000209E8 File Offset: 0x0001EBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545873, XrefRangeEnd = 545876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveInitialState(AccountID firstPlayer, SerializedGameState startingGameState, List<PlayerInfoSaveData> orderedPlayers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(firstPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(startingGameState);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orderedPlayers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SaveInitialState_Public_Void_AccountID_SerializedGameState_List_1_PlayerInfoSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00020A50 File Offset: 0x0001EC50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 545974, RefRangeEnd = 545976, XrefRangeStart = 545876, XrefRangeEnd = 545974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveData MakeNewSaveData(SerializedGameState sgs = null, List<PlayerInfoSaveData> orderedPlayers = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sgs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(orderedPlayers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_MakeNewSaveData_Private_SaveData_SerializedGameState_List_1_PlayerInfoSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr3) : null;
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00020AB4 File Offset: 0x0001ECB4
		public unsafe SerializedEventReactor SerializedEventReactor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 545979, RefRangeEnd = 545980, XrefRangeStart = 545976, XrefRangeEnd = 545979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_SerializedEventReactor_Private_get_SerializedEventReactor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedEventReactor>(intPtr3) : null;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00020AF4 File Offset: 0x0001ECF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 545985, RefRangeEnd = 545986, XrefRangeStart = 545980, XrefRangeEnd = 545985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RestoreSerializedEventReactor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_RestoreSerializedEventReactor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00020B28 File Offset: 0x0001ED28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545986, XrefRangeEnd = 546081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveSimultaneousPlayers(AccountID completedTurnPlayer, IEnumerable<AccountID> waitingForPlayers, SerializedGameState gameState, int turn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedTurnPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(waitingForPlayers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameState);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref turn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SaveSimultaneousPlayers_Public_Void_AccountID_IEnumerable_1_AccountID_SerializedGameState_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00020B9C File Offset: 0x0001ED9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546081, XrefRangeEnd = 546108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendNotificationToPlayer(AccountID playerToNotify, string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerToNotify);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SendNotificationToPlayer_Public_Void_AccountID_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00020BF0 File Offset: 0x0001EDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546108, XrefRangeEnd = 546122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearDisplayActionsForPlayer(AccountID player, SerializedGameState gameState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gameState);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_ClearDisplayActionsForPlayer_Public_Void_AccountID_SerializedGameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00020C44 File Offset: 0x0001EE44
		public unsafe virtual int GetTurnForSaveData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546122, XrefRangeEnd = 546130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_GetTurnForSaveData_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00020C8C File Offset: 0x0001EE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546130, XrefRangeEnd = 546152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostClearDisplayActions(PlayerEntity player, PlayerSaveData playerState, Dictionary<PlayerEntity, List<PendingSelection>> allPendingSelections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerState);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allPendingSelections);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_PostClearDisplayActions_Public_Virtual_New_Void_PlayerEntity_PlayerSaveData_Dictionary_2_PlayerEntity_List_1_PendingSelection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00020D00 File Offset: 0x0001EF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546152, XrefRangeEnd = 546395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SaveOnPause(PlayerEntity latestRespondedPlayer, Il2CppReferenceArray<PlayerEntity> previousSelectingPlayers, IEnumerable<ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>> pendingSelections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(latestRespondedPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previousSelectingPlayers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pendingSelections);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_SaveOnPause_Public_Virtual_New_Void_PlayerEntity_Il2CppReferenceArray_1_PlayerEntity_IEnumerable_1_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00020D74 File Offset: 0x0001EF74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 546403, RefRangeEnd = 546405, XrefRangeStart = 546395, XrefRangeEnd = 546403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<PlayerEntity> ClearDisplayActionsOnSave(PlayerEntity lastRespondingPlayer, Dictionary<PlayerEntity, List<PendingSelection>> allPendingSelections)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_ClearDisplayActionsOnSave_Public_Virtual_New_IEnumerable_1_PlayerEntity_PlayerEntity_Dictionary_2_PlayerEntity_List_1_PendingSelection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr3) : null;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00020DE4 File Offset: 0x0001EFE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 546412, RefRangeEnd = 546413, XrefRangeStart = 546405, XrefRangeEnd = 546412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInSelectionLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_IsInSelectionLoop_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00020E20 File Offset: 0x0001F020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546413, XrefRangeEnd = 546425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldResetSelectionCount(IHasExecutionStack hasExecutionStack)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasExecutionStack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_ShouldResetSelectionCount_Public_Virtual_New_Boolean_IHasExecutionStack_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00020E78 File Offset: 0x0001F078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 546449, RefRangeEnd = 546450, XrefRangeStart = 546425, XrefRangeEnd = 546449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Run(string executionStackName, Canis.actions.Action action, bool allowSaves = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(executionStackName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowSaves;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_Run_Public_Void_String_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00020EDC File Offset: 0x0001F0DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546450, XrefRangeEnd = 546520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Write(Object message, AccountID accountID = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Object_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00020F3C File Offset: 0x0001F13C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 546564, RefRangeEnd = 546565, XrefRangeStart = 546520, XrefRangeEnd = 546564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogGameCrashToAnalytics(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_LogGameCrashToAnalytics_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00020F80 File Offset: 0x0001F180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 546624, RefRangeEnd = 546625, XrefRangeStart = 546565, XrefRangeEnd = 546624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndGameImmediately()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_EndGameImmediately_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00020FB4 File Offset: 0x0001F1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546625, XrefRangeEnd = 546633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> SetNonPromptText(LocalizableTextVariables nonPromptText, IEnumerable<PlayerEntity> nonSelectingPlayers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nonPromptText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nonSelectingPlayers);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_SetNonPromptText_Public_Virtual_New_IEnumerable_1_Action_LocalizableTextVariables_IEnumerable_1_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00021024 File Offset: 0x0001F224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546633, XrefRangeEnd = 546639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> ClearNonPromptText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_ClearNonPromptText_Public_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00021070 File Offset: 0x0001F270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 546653, RefRangeEnd = 546654, XrefRangeStart = 546639, XrefRangeEnd = 546653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Resign()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_Resign_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000210A4 File Offset: 0x0001F2A4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPlayerDisconnected(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_OnPlayerDisconnected_Public_Virtual_New_Void_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000210F4 File Offset: 0x0001F2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546654, XrefRangeEnd = 546659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool validForDisplayAction(DWDEvent message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_validForDisplayAction_Protected_Virtual_New_Boolean_DWDEvent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0002114C File Offset: 0x0001F34C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 546769, RefRangeEnd = 546772, XrefRangeStart = 546659, XrefRangeEnd = 546769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DispatchMessage(AccountID accountID, DWDEvent message, bool shouldStoreDisplayAction = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldStoreDisplayAction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_DispatchMessage_Public_Void_AccountID_DWDEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000211B0 File Offset: 0x0001F3B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMessageDispatcher(Action<AccountID, DWDEvent> dispatcher)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dispatcher);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SetMessageDispatcher_Public_Void_Action_2_AccountID_DWDEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000211F4 File Offset: 0x0001F3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWriteSaveData(Action<SaveData> writeSaveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writeSaveData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SetWriteSaveData_Public_Void_Action_1_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00021238 File Offset: 0x0001F438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWriteSimultaneousSaveData(Func<SaveData, AccountID, IEnumerable<AccountID>, Task> writeSimultaneousSaveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writeSimultaneousSaveData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SetWriteSimultaneousSaveData_Public_Void_Func_4_SaveData_AccountID_IEnumerable_1_AccountID_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0002127C File Offset: 0x0001F47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWritePlayerResignedState(Func<SerializedGameState, AccountID, Task> writePlayerResignedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(writePlayerResignedData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SetWritePlayerResignedState_Public_Void_Func_3_SerializedGameState_AccountID_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000212C0 File Offset: 0x0001F4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetWriteNewSaveData(Func<SaveData, Task> saveData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(saveData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SetWriteNewSaveData_Public_Void_Func_2_SaveData_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00021304 File Offset: 0x0001F504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSaveData(SaveData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SetSaveData_Public_Void_SaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00021348 File Offset: 0x0001F548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNotifier(Func<string, AccountID, Task> notifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SetNotifier_Public_Void_Func_3_String_AccountID_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0002138C File Offset: 0x0001F58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRemoveIdlePlayer(Func<AccountID, Task> removeIdlePlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(removeIdlePlayer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SetRemoveIdlePlayer_Public_Void_Func_2_AccountID_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x000213D0 File Offset: 0x0001F5D0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 546788, RefRangeEnd = 546799, XrefRangeStart = 546772, XrefRangeEnd = 546788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNextSelectionCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_GetNextSelectionCounter_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0002140C File Offset: 0x0001F60C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546799, XrefRangeEnd = 546800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasPendingResponse(int selectionCounter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref selectionCounter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_HasPendingResponse_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00021458 File Offset: 0x0001F658
		[CallerCount(0)]
		public unsafe virtual bool IsGameOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_IsGameOver_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000214A0 File Offset: 0x0001F6A0
		[CallerCount(0)]
		public unsafe virtual bool IsMatchOver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_IsMatchOver_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000214E8 File Offset: 0x0001F6E8
		[CallerCount(0)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00021524 File Offset: 0x0001F724
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 546806, RefRangeEnd = 546810, XrefRangeStart = 546800, XrefRangeEnd = 546806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDeviceIDForAnalyticsIfOfflineMatch(Dictionary<string, Object> dict)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_AddDeviceIDForAnalyticsIfOfflineMatch_Public_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00021568 File Offset: 0x0001F768
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 546812, RefRangeEnd = 546815, XrefRangeStart = 546810, XrefRangeEnd = 546812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EntityIDDebugInfo(EntityID entityID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_EntityIDDebugInfo_Protected_String_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000215B0 File Offset: 0x0001F7B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546815, XrefRangeEnd = 546882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string TargetInfoDebugInfo(TargetInformation targetInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_TargetInfoDebugInfo_Public_Virtual_New_String_TargetInformation_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00021604 File Offset: 0x0001F804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546882, XrefRangeEnd = 546932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string SelectionDebugInfo(SelectionMessage selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_SelectionDebugInfo_Public_Virtual_New_String_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00021658 File Offset: 0x0001F858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 546932, RefRangeEnd = 546934, XrefRangeStart = 546932, XrefRangeEnd = 546932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEntity CurrentPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_CurrentPlayer_Public_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00021698 File Offset: 0x0001F898
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 546991, RefRangeEnd = 546994, XrefRangeStart = 546934, XrefRangeEnd = 546991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddClientInfoForAnalyticsIfOfflineMatch(Dictionary<string, Object> dict)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_AddClientInfoForAnalyticsIfOfflineMatch_Public_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000216DC File Offset: 0x0001F8DC
		[CallerCount(0)]
		public unsafe virtual bool IsInPlay(Entity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_IsInPlay_Public_Abstract_Virtual_New_Boolean_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00021734 File Offset: 0x0001F934
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00021770 File Offset: 0x0001F970
		public unsafe bool AILogging
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_AILogging_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 546994, XrefRangeEnd = 547002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_set_AILogging_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000217B0 File Offset: 0x0001F9B0
		[CallerCount(0)]
		public unsafe virtual void AILog(PlayerEntity player, string str, string color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(color);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_AILog_Public_Abstract_Virtual_New_Void_PlayerEntity_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00021824 File Offset: 0x0001FA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 547002, XrefRangeEnd = 547006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<int> AIDecisionDelayForSelection(SelectionMessage selectionMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_AIDecisionDelayForSelection_Public_Virtual_New_Nullable_1_Int32_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00021878 File Offset: 0x0001FA78
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FinishReconnect(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_FinishReconnect_Public_Virtual_New_Void_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000218C8 File Offset: 0x0001FAC8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldNotifyPlayer(AccountID playerID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_ShouldNotifyPlayer_Public_Virtual_New_Boolean_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00021920 File Offset: 0x0001FB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 547006, XrefRangeEnd = 547012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dictionary<string, string> GetAdditionalPlayerMetadata(PlayerEntity playerEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_GetAdditionalPlayerMetadata_Public_Virtual_New_Dictionary_2_String_String_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0002197C File Offset: 0x0001FB7C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdatePlayerData(AccountIDUsernameMetadata playerData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(playerData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_UpdatePlayerData_Public_Virtual_New_Void_AccountIDUsernameMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000219CC File Offset: 0x0001FBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 547012, XrefRangeEnd = 547176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetPlayerDataForResignFromGame(AccountID resigningPlayerID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resigningPlayerID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_SetPlayerDataForResignFromGame_Protected_Virtual_New_Void_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00021A1C File Offset: 0x0001FC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 547176, XrefRangeEnd = 547201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleResignGame(AccountID resigningPlayerID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resigningPlayerID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_HandleResignGame_Protected_Virtual_New_Void_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00021A6C File Offset: 0x0001FC6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 547201, XrefRangeEnd = 547212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task HandleResignGameAsync(AccountID resigningPlayerID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resigningPlayerID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_HandleResignGameAsync_Public_Task_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00021ABC File Offset: 0x0001FCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 547212, XrefRangeEnd = 547221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerResignedState(SerializedGameState gameState, AccountID resigningPlayerID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameState);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resigningPlayerID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SetPlayerResignedState_Public_Void_SerializedGameState_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00021B10 File Offset: 0x0001FD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 547221, XrefRangeEnd = 547223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasResigned(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_HasResigned_Public_Virtual_New_Boolean_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00021B68 File Offset: 0x0001FD68
		public unsafe virtual IMessageActionFactory MessageActionFactory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_MessageActionFactory_Public_Virtual_New_get_IMessageActionFactory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageActionFactory>(intPtr3) : null;
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00021BB4 File Offset: 0x0001FDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 547223, XrefRangeEnd = 547228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetActiveSelectionOfPlayer(AccountID accountID, SelectionMessage sm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sm);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_SetActiveSelectionOfPlayer_Public_Void_AccountID_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00021C08 File Offset: 0x0001FE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 547228, XrefRangeEnd = 547232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveActiveSelectionOfPlayer(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_RemoveActiveSelectionOfPlayer_Public_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00021C4C File Offset: 0x0001FE4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 547232, XrefRangeEnd = 547334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleIdleTurn(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_HandleIdleTurn_Public_Virtual_New_Void_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00021C9C File Offset: 0x0001FE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 547334, XrefRangeEnd = 547343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSaveOnPause(string executionStackName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(executionStackName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_ShouldSaveOnPause_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00021CF4 File Offset: 0x0001FEF4
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool AllowMultiSelectionCounter(PlayerEntity selectingPlayer, int counter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_AllowMultiSelectionCounter_Public_Virtual_New_Boolean_PlayerEntity_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00021D5C File Offset: 0x0001FF5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 547343, XrefRangeEnd = 547347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AnyPlayerIsSelecting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_AnyPlayerIsSelecting_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00021D98 File Offset: 0x0001FF98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 547351, RefRangeEnd = 547352, XrefRangeStart = 547347, XrefRangeEnd = 547351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PlayerIsSelecting(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_PlayerIsSelecting_Protected_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00021DE8 File Offset: 0x0001FFE8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 547394, RefRangeEnd = 547401, XrefRangeStart = 547352, XrefRangeEnd = 547394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<AccountID> PlayerIDsMakingSelections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_PlayerIDsMakingSelections_Private_IEnumerable_1_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AccountID>>(intPtr3) : null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00021E28 File Offset: 0x00020028
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 547454, RefRangeEnd = 547457, XrefRangeStart = 547401, XrefRangeEnd = 547454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<SelectionMessage> ActiveSelectionsOfPlayer(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_ActiveSelectionsOfPlayer_Public_IEnumerable_1_SelectionMessage_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SelectionMessage>>(intPtr3) : null;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00021E78 File Offset: 0x00020078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 547520, RefRangeEnd = 547521, XrefRangeStart = 547457, XrefRangeEnd = 547520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccountID PlayerIDForSelection(SelectionMessage evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_PlayerIDForSelection_Public_AccountID_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00021EC8 File Offset: 0x000200C8
		[CallerCount(492)]
		[CachedScanResults(RefRangeStart = 547521, RefRangeEnd = 548013, XrefRangeStart = 547521, XrefRangeEnd = 547521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<KeyValuePair<string, string>> CalcifyTarget(Object unknown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unknown);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_CalcifyTarget_Public_Virtual_New_Nullable_1_KeyValuePair_2_String_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<KeyValuePair<string, string>>(intPtr);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00021F1C File Offset: 0x0002011C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object ReifyTarget(string hint, string serialized)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(hint);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(serialized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_ReifyTarget_Public_Virtual_New_Object_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00021F8C File Offset: 0x0002018C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548013, XrefRangeEnd = 548021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IAttribute<Nullable<int>>> MakeObfuscatedNumChildren(Entity parent, AccountID perspective, [Optional] Il2CppReferenceArray<Entity> removedEntities)
		{
			if (removedEntities == null)
			{
				removedEntities = new Il2CppReferenceArray<Entity>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(perspective);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(removedEntities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_MakeObfuscatedNumChildren_Public_Virtual_New_IEnumerable_1_IAttribute_1_Nullable_1_Int32_Entity_AccountID_Il2CppReferenceArray_1_Entity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute<Nullable<int>>>>(intPtr3) : null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00022018 File Offset: 0x00020218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548021, XrefRangeEnd = 548028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IAttribute<Nullable<int>>> MakeObfuscatedNumChildren(SerializedEntity parent, [Optional] Il2CppReferenceArray<SerializedEntity> removedEntities)
		{
			if (removedEntities == null)
			{
				removedEntities = new Il2CppReferenceArray<SerializedEntity>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(removedEntities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_MakeObfuscatedNumChildren_Public_Virtual_New_IEnumerable_1_IAttribute_1_Nullable_1_Int32_SerializedEntity_Il2CppReferenceArray_1_SerializedEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute<Nullable<int>>>>(intPtr3) : null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00022094 File Offset: 0x00020294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548028, XrefRangeEnd = 548033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IAttribute> MakeObfuscatedMovePublicData(Entity movingEntity, EntityID sourceID, EntityID destinationID)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_MakeObfuscatedMovePublicData_Public_Virtual_New_IEnumerable_1_IAttribute_Entity_EntityID_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00022114 File Offset: 0x00020314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548033, XrefRangeEnd = 548038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<IAttribute> MakeObfuscatedMovePublicData(SerializedEntity movingEntity, EntityID sourceID, EntityID destinationID)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_MakeObfuscatedMovePublicData_Public_Virtual_New_IEnumerable_1_IAttribute_SerializedEntity_EntityID_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IAttribute>>(intPtr3) : null;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00022194 File Offset: 0x00020394
		public unsafe virtual int NumberOfAISelectionsToStore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_NumberOfAISelectionsToStore_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000221DC File Offset: 0x000203DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 548046, RefRangeEnd = 548047, XrefRangeStart = 548038, XrefRangeEnd = 548046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreAISelectionForLog(string selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_StoreAISelectionForLog_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00022220 File Offset: 0x00020420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548047, XrefRangeEnd = 548056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPreviousAISelections()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_GetPreviousAISelections_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00022258 File Offset: 0x00020458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548056, XrefRangeEnd = 548061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> PrePendSelection(List<ValueTuple<PlayerEntity, PendingSelection>> pendingSelections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pendingSelections);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_PrePendSelection_Public_Virtual_New_IEnumerable_1_Action_List_1_ValueTuple_2_PlayerEntity_PendingSelection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x000222B4 File Offset: 0x000204B4
		public unsafe virtual TimerModes TimerMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_TimerMode_Public_Abstract_Virtual_New_get_TimerModes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x000222FC File Offset: 0x000204FC
		public unsafe virtual int TimerLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548061, XrefRangeEnd = 548067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_TimerLength_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00022344 File Offset: 0x00020544
		public unsafe virtual bool UseTimers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_get_UseTimers_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0002238C File Offset: 0x0002058C
		public unsafe IReadOnlyCollection<TimerInfo> ActiveTimers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_get_ActiveTimers_Public_get_IReadOnlyCollection_1_TimerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<TimerInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000223CC File Offset: 0x000205CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548067, XrefRangeEnd = 548091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackTimer(TimerID timerID, string timerType, AccountID forAccount, SelectionMessage forSelection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timerID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(timerType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forAccount);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forSelection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_TrackTimer_Public_Void_TimerID_String_AccountID_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00022448 File Offset: 0x00020648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 548147, RefRangeEnd = 548148, XrefRangeStart = 548091, XrefRangeEnd = 548147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackTimer(TimerID timerID, string timerType, [Optional] Il2CppReferenceArray<ValueTuple<AccountID, SelectionMessage>> forAccountSelections)
		{
			if (forAccountSelections == null)
			{
				forAccountSelections = new Il2CppStructArray<ValueTuple<AccountID, SelectionMessage>>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timerID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(timerType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(forAccountSelections);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_TrackTimer_Public_Void_TimerID_String_Il2CppReferenceArray_1_ValueTuple_2_AccountID_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000224BC File Offset: 0x000206BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 548163, RefRangeEnd = 548166, XrefRangeStart = 548148, XrefRangeEnd = 548163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UntrackTimer(TimerID timerID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timerID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_UntrackTimer_Public_Void_TimerID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00022500 File Offset: 0x00020700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 548168, RefRangeEnd = 548170, XrefRangeStart = 548166, XrefRangeEnd = 548168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelTimersForCounter(AccountID accountID, int selectionCounter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref selectionCounter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_CancelTimersForCounter_Public_Void_AccountID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00022550 File Offset: 0x00020750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 548185, RefRangeEnd = 548187, XrefRangeStart = 548170, XrefRangeEnd = 548185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TimerIsActive(TimerID timerID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timerID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr_TimerIsActive_Public_Boolean_TimerID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000225A0 File Offset: 0x000207A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548187, XrefRangeEnd = 548195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TimeoutDisconnectedPlayer(AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_TimeoutDisconnectedPlayer_Public_Virtual_New_Void_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000225F0 File Offset: 0x000207F0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSetTimerForSelection(PlayerEntity player, SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_ShouldSetTimerForSelection_Public_Virtual_New_Boolean_PlayerEntity_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0002265C File Offset: 0x0002085C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548195, XrefRangeEnd = 548216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetTimerForSelection(PlayerEntity player, SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_GetTimerForSelection_Public_Virtual_New_Int32_PlayerEntity_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000226C8 File Offset: 0x000208C8
		[CallerCount(0)]
		public unsafe virtual float GetTimerPaddingForSelection(PlayerEntity player, SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_GetTimerPaddingForSelection_Public_Virtual_New_Single_PlayerEntity_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00022734 File Offset: 0x00020934
		[CallerCount(0)]
		public unsafe virtual int GetTotalTimerTime(PlayerEntity player, SelectionMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Match.NativeMethodInfoPtr_GetTotalTimerTime_Public_Virtual_New_Int32_PlayerEntity_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000227A0 File Offset: 0x000209A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 548305, RefRangeEnd = 548306, XrefRangeStart = 548216, XrefRangeEnd = 548305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000227DC File Offset: 0x000209DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548306, XrefRangeEnd = 548321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchInitData _Configure_b__78_0(MatchInitData smid, int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(smid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__Configure_b__78_0_Private_MatchInitData_MatchInitData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr3) : null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0002283C File Offset: 0x00020A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548321, XrefRangeEnd = 548329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> _ClaimOwnedEntitiesForPending_b__145_0(EntityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__ClaimOwnedEntitiesForPending_b__145_0_Private_IEnumerable_1_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0002288C File Offset: 0x00020A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548329, XrefRangeEnd = 548338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _TargetInfoDebugInfo_b__186_0(KeyValuePair<EntityID, int> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__TargetInfoDebugInfo_b__186_0_Private_String_KeyValuePair_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000228DC File Offset: 0x00020ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548338, XrefRangeEnd = 548361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _TargetInfoDebugInfo_b__186_1(KeyValuePair<int, TargetInformation> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__TargetInfoDebugInfo_b__186_1_Private_String_KeyValuePair_2_Int32_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0002292C File Offset: 0x00020B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 548361, XrefRangeEnd = 548394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _SelectionDebugInfo_b__187_0(KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>> kvp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.NativeMethodInfoPtr__SelectionDebugInfo_b__187_0_Private_String_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000029B3 File Offset: 0x00000BB3
		public virtual IEnumerable<IAttribute<Nullable<int>>> MakeObfuscatedNumChildren(Entity parent, AccountID perspective, params Entity[] removedEntities)
		{
			return this.MakeObfuscatedNumChildren(parent, perspective, new Il2CppReferenceArray<Entity>(removedEntities));
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000029C3 File Offset: 0x00000BC3
		public virtual IEnumerable<IAttribute<Nullable<int>>> MakeObfuscatedNumChildren(SerializedEntity parent, params SerializedEntity[] removedEntities)
		{
			return this.MakeObfuscatedNumChildren(parent, new Il2CppReferenceArray<SerializedEntity>(removedEntities));
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x000029D2 File Offset: 0x00000BD2
		public void TrackTimer(TimerID timerID, string timerType, params ValueTuple<AccountID, SelectionMessage>[] forAccountSelections)
		{
			this.TrackTimer(timerID, timerType, new Il2CppReferenceArray<ValueTuple<AccountID, SelectionMessage>>(forAccountSelections));
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000029E2 File Offset: 0x00000BE2
		public Match(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0002297C File Offset: 0x00020B7C
		// (set) Token: 0x060001FB RID: 507 RVA: 0x000029EB File Offset: 0x00000BEB
		public unsafe MainMessageRouter _MessageRouter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__MessageRouter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMessageRouter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__MessageRouter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001FC RID: 508 RVA: 0x000229AC File Offset: 0x00020BAC
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002A0A File Offset: 0x00000C0A
		public unsafe Dictionary<string, IHasExecutionStack> hasExecutionStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_hasExecutionStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, IHasExecutionStack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_hasExecutionStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000229DC File Offset: 0x00020BDC
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002A29 File Offset: 0x00000C29
		public unsafe bool MatchDisposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_MatchDisposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_MatchDisposed)) = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00022A04 File Offset: 0x00020C04
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002A44 File Offset: 0x00000C44
		public unsafe Object matchWriteLockObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_matchWriteLockObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_matchWriteLockObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00022A34 File Offset: 0x00020C34
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002A63 File Offset: 0x00000C63
		public unsafe bool Initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_Initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_Initialized)) = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00022A5C File Offset: 0x00020C5C
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00002A7E File Offset: 0x00000C7E
		public unsafe bool logging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_logging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_logging)) = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00022A84 File Offset: 0x00020C84
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002A99 File Offset: 0x00000C99
		public unsafe CanisRandom _Random_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__Random_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisRandom>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__Random_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00022AB4 File Offset: 0x00020CB4
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002AB8 File Offset: 0x00000CB8
		public unsafe Random _SelectionRandom_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__SelectionRandom_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Random>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__SelectionRandom_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00022AE4 File Offset: 0x00020CE4
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00002AD7 File Offset: 0x00000CD7
		public unsafe Action<AccountID, DWDEvent> messageDispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_messageDispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AccountID, DWDEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_messageDispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00022B14 File Offset: 0x00020D14
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002AF6 File Offset: 0x00000CF6
		public unsafe GameID _GameID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__GameID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__GameID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00022B44 File Offset: 0x00020D44
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002B15 File Offset: 0x00000D15
		public unsafe Il2CppReferenceArray<AccountID> _HumanAccountIDs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__HumanAccountIDs_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__HumanAccountIDs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00022B74 File Offset: 0x00020D74
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002B34 File Offset: 0x00000D34
		public unsafe Il2CppReferenceArray<AccountID> _AIAccountIDs_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__AIAccountIDs_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__AIAccountIDs_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00022BA4 File Offset: 0x00020DA4
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002B53 File Offset: 0x00000D53
		public unsafe AccountID _ActiveAccountID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__ActiveAccountID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__ActiveAccountID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00022BD4 File Offset: 0x00020DD4
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002B72 File Offset: 0x00000D72
		public unsafe MatchInitData _matchInitData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matchInitData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__matchInitData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00022C04 File Offset: 0x00020E04
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002B91 File Offset: 0x00000D91
		public unsafe Entity Playmat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_Playmat);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_Playmat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00022C34 File Offset: 0x00020E34
		// (set) Token: 0x06000219 RID: 537 RVA: 0x00002BB0 File Offset: 0x00000DB0
		public unsafe Dictionary<string, string> GameOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_GameOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_GameOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00022C64 File Offset: 0x00020E64
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00002BCF File Offset: 0x00000DCF
		public unsafe Dictionary<EntityID, Entity> Entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_Entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, Entity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_Entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00022C94 File Offset: 0x00020E94
		// (set) Token: 0x0600021D RID: 541 RVA: 0x00002BEE File Offset: 0x00000DEE
		public unsafe Dictionary<AccountID, List<EntityID>> ownedByPendingPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_ownedByPendingPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_ownedByPendingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00022CC4 File Offset: 0x00020EC4
		// (set) Token: 0x0600021F RID: 543 RVA: 0x00002C0D File Offset: 0x00000E0D
		public unsafe EventReactor _EventReactor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__EventReactor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventReactor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__EventReactor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00022CF4 File Offset: 0x00020EF4
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002C2C File Offset: 0x00000E2C
		public unsafe long startTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_startTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_startTime)) = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00022D1C File Offset: 0x00020F1C
		// (set) Token: 0x06000223 RID: 547 RVA: 0x00002C47 File Offset: 0x00000E47
		public unsafe bool _UseTurnTimers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__UseTurnTimers_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__UseTurnTimers_k__BackingField)) = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00022D44 File Offset: 0x00020F44
		// (set) Token: 0x06000225 RID: 549 RVA: 0x00002C62 File Offset: 0x00000E62
		public unsafe bool forceGameOver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_forceGameOver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_forceGameOver)) = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00022D6C File Offset: 0x00020F6C
		// (set) Token: 0x06000227 RID: 551 RVA: 0x00002C7D File Offset: 0x00000E7D
		public unsafe bool reconnectingPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_reconnectingPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_reconnectingPlayer)) = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00022D94 File Offset: 0x00020F94
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00002C98 File Offset: 0x00000E98
		public unsafe Queue<DWDEvent> reconnectMessageQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_reconnectMessageQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<DWDEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_reconnectMessageQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00022DC4 File Offset: 0x00020FC4
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00002CB7 File Offset: 0x00000EB7
		public unsafe SaveData SaveData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_SaveData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_SaveData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00022DF4 File Offset: 0x00020FF4
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00002CD6 File Offset: 0x00000ED6
		public unsafe Action<SaveData> WriteSaveData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_WriteSaveData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_WriteSaveData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00022E24 File Offset: 0x00021024
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00002CF5 File Offset: 0x00000EF5
		public unsafe Func<SaveData, Task> WriteNewSaveData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_WriteNewSaveData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SaveData, Task>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_WriteNewSaveData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00022E54 File Offset: 0x00021054
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00002D14 File Offset: 0x00000F14
		public unsafe Func<SerializedGameState, AccountID, Task> WritePlayerResignedState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_WritePlayerResignedState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedGameState, AccountID, Task>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_WritePlayerResignedState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00022E84 File Offset: 0x00021084
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00002D33 File Offset: 0x00000F33
		public unsafe Func<SaveData, AccountID, IEnumerable<AccountID>, Task> WriteSimultaneousSaveData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_WriteSimultaneousSaveData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SaveData, AccountID, IEnumerable<AccountID>, Task>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_WriteSimultaneousSaveData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00022EB4 File Offset: 0x000210B4
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002D52 File Offset: 0x00000F52
		public unsafe Func<string, AccountID, Task> PlayerNotifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_PlayerNotifier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, AccountID, Task>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_PlayerNotifier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00022EE4 File Offset: 0x000210E4
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00002D71 File Offset: 0x00000F71
		public unsafe Func<AccountID, Task> RemoveIdlePlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_RemoveIdlePlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountID, Task>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_RemoveIdlePlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00022F14 File Offset: 0x00021114
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00002D90 File Offset: 0x00000F90
		public unsafe Dictionary<AccountID, SelectionMessage> LastSelectionMessageV2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_LastSelectionMessageV2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, SelectionMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_LastSelectionMessageV2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00022F44 File Offset: 0x00021144
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00002DAF File Offset: 0x00000FAF
		public unsafe TimerID TimerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_TimerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_TimerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00022F74 File Offset: 0x00021174
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00002DCE File Offset: 0x00000FCE
		public unsafe string TimerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_TimerType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_TimerType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00022F9C File Offset: 0x0002119C
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00002DED File Offset: 0x00000FED
		public unsafe bool aiLogging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_aiLogging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_aiLogging)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00022FC4 File Offset: 0x000211C4
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00002E08 File Offset: 0x00001008
		public unsafe List<AccountID> disconnectedPlayers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_disconnectedPlayers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_disconnectedPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00022FF4 File Offset: 0x000211F4
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00002E27 File Offset: 0x00001027
		public unsafe IMessageActionFactory _MessageActionFactory_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__MessageActionFactory_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageActionFactory>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__MessageActionFactory_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00023024 File Offset: 0x00021224
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00002E46 File Offset: 0x00001046
		public unsafe SelectionMessage LastSelectionMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_LastSelectionMessage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_LastSelectionMessage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00023054 File Offset: 0x00021254
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00002E65 File Offset: 0x00001065
		public unsafe Dictionary<AccountID, SelectionMessage> _activeSelectionMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__activeSelectionMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, SelectionMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__activeSelectionMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00023084 File Offset: 0x00021284
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002E84 File Offset: 0x00001084
		public unsafe Queue<string> PreviousAISelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_PreviousAISelections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr_PreviousAISelections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000230B4 File Offset: 0x000212B4
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00002EA3 File Offset: 0x000010A3
		public unsafe List<TimerInfo> _activeTimers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__activeTimers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TimerInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.NativeFieldInfoPtr__activeTimers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeFieldInfoPtr__MessageRouter_k__BackingField;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeFieldInfoPtr_hasExecutionStacks;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeFieldInfoPtr_MatchDisposed;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeFieldInfoPtr_matchWriteLockObject;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_Initialized;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_logging;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeFieldInfoPtr__Random_k__BackingField;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeFieldInfoPtr__SelectionRandom_k__BackingField;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeFieldInfoPtr_messageDispatcher;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeFieldInfoPtr__GameID_k__BackingField;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeFieldInfoPtr__HumanAccountIDs_k__BackingField;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeFieldInfoPtr__AIAccountIDs_k__BackingField;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeFieldInfoPtr__ActiveAccountID_k__BackingField;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeFieldInfoPtr__matchInitData_k__BackingField;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeFieldInfoPtr_Playmat;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr_GameOptions;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeFieldInfoPtr_Entities;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeFieldInfoPtr_ownedByPendingPlayer;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr__EventReactor_k__BackingField;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeFieldInfoPtr_startTime;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeFieldInfoPtr__UseTurnTimers_k__BackingField;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeFieldInfoPtr_forceGameOver;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeFieldInfoPtr_reconnectingPlayer;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeFieldInfoPtr_reconnectMessageQueue;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeFieldInfoPtr_SaveData;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeFieldInfoPtr_WriteSaveData;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeFieldInfoPtr_WriteNewSaveData;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeFieldInfoPtr_WritePlayerResignedState;

		// Token: 0x040000D8 RID: 216
		private static readonly IntPtr NativeFieldInfoPtr_WriteSimultaneousSaveData;

		// Token: 0x040000D9 RID: 217
		private static readonly IntPtr NativeFieldInfoPtr_PlayerNotifier;

		// Token: 0x040000DA RID: 218
		private static readonly IntPtr NativeFieldInfoPtr_RemoveIdlePlayer;

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_LastSelectionMessageV2;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeFieldInfoPtr_TimerID;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeFieldInfoPtr_TimerType;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_aiLogging;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_disconnectedPlayers;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr__MessageActionFactory_k__BackingField;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_LastSelectionMessage;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr__activeSelectionMessages;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr_PreviousAISelections;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr__activeTimers;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageRouter_Protected_get_MainMessageRouter_0;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_set_MessageRouter_Protected_set_Void_MainMessageRouter_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_GetHasExecutionStack_Public_IHasExecutionStack_String_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_GetArchetypesLock_Public_Abstract_Virtual_New_Object_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_get_Random_Public_get_CanisRandom_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_set_Random_Private_set_Void_CanisRandom_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionRandom_Public_get_Random_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectionRandom_Private_set_Void_Random_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_get_GameID_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_set_GameID_Private_set_Void_GameID_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_get_HumanAccountIDs_Public_get_Il2CppReferenceArray_1_AccountID_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_set_HumanAccountIDs_Protected_set_Void_Il2CppReferenceArray_1_AccountID_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_get_AIAccountIDs_Public_get_Il2CppReferenceArray_1_AccountID_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_set_AIAccountIDs_Protected_set_Void_Il2CppReferenceArray_1_AccountID_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAccountID_Public_get_AccountID_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveAccountID_Public_set_Void_AccountID_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_get_matchInitData_Public_get_MatchInitData_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_set_matchInitData_Private_set_Void_MatchInitData_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_get_EventReactor_Public_get_EventReactor_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_set_EventReactor_Protected_set_Void_EventReactor_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSequences_Public_get_IReadOnlyList_1_DBGSequence_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_passToPlayerAction_Public_Abstract_Virtual_New_Action_PlayerEntity_Boolean_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_GetGameResults_Public_Abstract_Virtual_New_Action_0;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr_getGameResults_Public_Abstract_Virtual_New_DBGGameResults_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_HandleResignGame_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_HandleIdleResignFromGame_Public_Abstract_Virtual_New_Void_AccountID_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_GameOverCleanup_Public_Abstract_Virtual_New_Void_List_1_AccountID_DBGGameResults_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_GetPreAIDecisionAction_Public_Abstract_Virtual_New_Action_SelectionMessage_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_PreProcessPlayerChoice_Public_Virtual_New_Action_SelectionMessage_0;

		// Token: 0x04000102 RID: 258
		private static readonly IntPtr NativeMethodInfoPtr_PreProcessPlayerChoiceWithPlayer_Public_Virtual_New_IEnumerable_1_Action_SelectionMessage_PlayerEntity_0;

		// Token: 0x04000103 RID: 259
		private static readonly IntPtr NativeMethodInfoPtr_get_UseTurnTimers_Public_get_Boolean_0;

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeMethodInfoPtr_set_UseTurnTimers_Protected_set_Void_Boolean_0;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_SetReconnectingPlayer_Public_Void_Boolean_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReconnecting_Public_get_Boolean_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_get_ReconnectMessageQueue_Public_get_List_1_DWDEvent_0;

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeMethodInfoPtr_get_SendNumChildrenAttributeModified_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_AnalyticsGameID_Public_get_GameID_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_set_AnalyticsGameID_Protected_set_Void_GameID_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_Configure_Public_Virtual_New_Void_MatchInitData_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_get_BasicPlayers_Public_Abstract_Virtual_New_get_IEnumerable_1_PlayerEntity_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayer_Public_Abstract_Virtual_New_Void_PlayerEntity_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerEntity_Public_Abstract_Virtual_New_PlayerEntity_AccountID_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntity_Public_Abstract_Virtual_New_Entity_SerializedEntity_Match_Entity_0;

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerByIndex_Public_Abstract_Virtual_New_T_Int32_0;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_get_MatchType_Public_get_String_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTutorial_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPassAndPlay_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSimultaneousSolo_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPBM_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSolo_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFriend_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLive_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCasual_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOnline_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCampaign_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDailyChallenge_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSkirmish_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRanked_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEvent_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_get_GetEventID_Public_Virtual_New_get_EventID_0;

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr_get_GetRoundID_Public_Virtual_New_get_RoundID_0;

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldIncludeAccountIDOnMessage_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAIOnly_Public_get_Boolean_0;

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOptimization_Public_get_Boolean_0;

		// Token: 0x04000125 RID: 293
		private static readonly IntPtr NativeMethodInfoPtr_get_SkipLiveReplay_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000126 RID: 294
		private static readonly IntPtr NativeMethodInfoPtr_IsFirstSelectionTurn_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x04000127 RID: 295
		private static readonly IntPtr NativeMethodInfoPtr_GetEntityOption_Public_IEnumerable_1_Entity_EntityID_0;

		// Token: 0x04000128 RID: 296
		private static readonly IntPtr NativeMethodInfoPtr_GetEntityOption_Public_IEnumerable_1_T_EntityID_0;

		// Token: 0x04000129 RID: 297
		private static readonly IntPtr NativeMethodInfoPtr_TryGetEntity_Public_Boolean_EntityID_byref_Entity_0;

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_TryGetEntity_Public_Boolean_EntityID_byref_T_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_LookupEntities_Public_IEnumerable_1_Entity_IEnumerable_1_EntityID_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr_LookupEntities_Public_IEnumerable_1_T_IEnumerable_1_EntityID_0;

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_AddEntityForPendingPlayer_Public_Void_AccountID_Entity_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_ClaimOwnedEntitiesForPending_Public_IEnumerable_1_Entity_AccountID_0;

		// Token: 0x0400012F RID: 303
		private static readonly IntPtr NativeMethodInfoPtr_SaveInitialState_Public_Void_AccountID_SerializedGameState_List_1_PlayerInfoSaveData_0;

		// Token: 0x04000130 RID: 304
		private static readonly IntPtr NativeMethodInfoPtr_MakeNewSaveData_Private_SaveData_SerializedGameState_List_1_PlayerInfoSaveData_0;

		// Token: 0x04000131 RID: 305
		private static readonly IntPtr NativeMethodInfoPtr_get_SerializedEventReactor_Private_get_SerializedEventReactor_0;

		// Token: 0x04000132 RID: 306
		private static readonly IntPtr NativeMethodInfoPtr_RestoreSerializedEventReactor_Protected_Void_0;

		// Token: 0x04000133 RID: 307
		private static readonly IntPtr NativeMethodInfoPtr_SaveSimultaneousPlayers_Public_Void_AccountID_IEnumerable_1_AccountID_SerializedGameState_Int32_0;

		// Token: 0x04000134 RID: 308
		private static readonly IntPtr NativeMethodInfoPtr_SendNotificationToPlayer_Public_Void_AccountID_String_0;

		// Token: 0x04000135 RID: 309
		private static readonly IntPtr NativeMethodInfoPtr_ClearDisplayActionsForPlayer_Public_Void_AccountID_SerializedGameState_0;

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_get_GetTurnForSaveData_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_PostClearDisplayActions_Public_Virtual_New_Void_PlayerEntity_PlayerSaveData_Dictionary_2_PlayerEntity_List_1_PendingSelection_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr_SaveOnPause_Public_Virtual_New_Void_PlayerEntity_Il2CppReferenceArray_1_PlayerEntity_IEnumerable_1_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeMethodInfoPtr_ClearDisplayActionsOnSave_Public_Virtual_New_IEnumerable_1_PlayerEntity_PlayerEntity_Dictionary_2_PlayerEntity_List_1_PendingSelection_0;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr_IsInSelectionLoop_Public_Boolean_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_ShouldResetSelectionCount_Public_Virtual_New_Boolean_IHasExecutionStack_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Void_String_Action_Boolean_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_New_Void_Object_AccountID_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_LogGameCrashToAnalytics_Private_Void_Exception_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_EndGameImmediately_Private_Void_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_SetNonPromptText_Public_Virtual_New_IEnumerable_1_Action_LocalizableTextVariables_IEnumerable_1_PlayerEntity_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_ClearNonPromptText_Public_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_Resign_Public_Void_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerDisconnected_Public_Virtual_New_Void_AccountID_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_validForDisplayAction_Protected_Virtual_New_Boolean_DWDEvent_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_DispatchMessage_Public_Void_AccountID_DWDEvent_Boolean_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_SetMessageDispatcher_Public_Void_Action_2_AccountID_DWDEvent_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_SetWriteSaveData_Public_Void_Action_1_SaveData_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_SetWriteSimultaneousSaveData_Public_Void_Func_4_SaveData_AccountID_IEnumerable_1_AccountID_Task_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_SetWritePlayerResignedState_Public_Void_Func_3_SerializedGameState_AccountID_Task_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_SetWriteNewSaveData_Public_Void_Func_2_SaveData_Task_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_SetSaveData_Public_Void_SaveData_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_SetNotifier_Public_Void_Func_3_String_AccountID_Task_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_SetRemoveIdlePlayer_Public_Void_Func_2_AccountID_Task_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_GetNextSelectionCounter_Public_Int32_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_HasPendingResponse_Public_Boolean_Int32_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_IsGameOver_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchOver_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_AddDeviceIDForAnalyticsIfOfflineMatch_Public_Void_Dictionary_2_String_Object_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_EntityIDDebugInfo_Protected_String_EntityID_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_TargetInfoDebugInfo_Public_Virtual_New_String_TargetInformation_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_SelectionDebugInfo_Public_Virtual_New_String_SelectionMessage_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_CurrentPlayer_Public_PlayerEntity_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_AddClientInfoForAnalyticsIfOfflineMatch_Public_Void_Dictionary_2_String_Object_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_IsInPlay_Public_Abstract_Virtual_New_Boolean_Entity_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_get_AILogging_Public_get_Boolean_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_set_AILogging_Public_set_Void_Boolean_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_AILog_Public_Abstract_Virtual_New_Void_PlayerEntity_String_String_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_AIDecisionDelayForSelection_Public_Virtual_New_Nullable_1_Int32_SelectionMessage_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_FinishReconnect_Public_Virtual_New_Void_AccountID_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_ShouldNotifyPlayer_Public_Virtual_New_Boolean_AccountID_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalPlayerMetadata_Public_Virtual_New_Dictionary_2_String_String_PlayerEntity_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayerData_Public_Virtual_New_Void_AccountIDUsernameMetadata_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerDataForResignFromGame_Protected_Virtual_New_Void_AccountID_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_HandleResignGame_Protected_Virtual_New_Void_AccountID_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_HandleResignGameAsync_Public_Task_AccountID_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerResignedState_Public_Void_SerializedGameState_AccountID_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_HasResigned_Public_Virtual_New_Boolean_AccountID_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageActionFactory_Public_Virtual_New_get_IMessageActionFactory_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_SetActiveSelectionOfPlayer_Public_Void_AccountID_SelectionMessage_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_RemoveActiveSelectionOfPlayer_Public_Void_AccountID_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_HandleIdleTurn_Public_Virtual_New_Void_AccountID_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSaveOnPause_Public_Virtual_New_Boolean_String_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_AllowMultiSelectionCounter_Public_Virtual_New_Boolean_PlayerEntity_Int32_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_AnyPlayerIsSelecting_Protected_Boolean_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_PlayerIsSelecting_Protected_Boolean_AccountID_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_PlayerIDsMakingSelections_Private_IEnumerable_1_AccountID_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_ActiveSelectionsOfPlayer_Public_IEnumerable_1_SelectionMessage_AccountID_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_PlayerIDForSelection_Public_AccountID_SelectionMessage_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_CalcifyTarget_Public_Virtual_New_Nullable_1_KeyValuePair_2_String_String_Object_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_ReifyTarget_Public_Virtual_New_Object_String_String_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_MakeObfuscatedNumChildren_Public_Virtual_New_IEnumerable_1_IAttribute_1_Nullable_1_Int32_Entity_AccountID_Il2CppReferenceArray_1_Entity_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_MakeObfuscatedNumChildren_Public_Virtual_New_IEnumerable_1_IAttribute_1_Nullable_1_Int32_SerializedEntity_Il2CppReferenceArray_1_SerializedEntity_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_MakeObfuscatedMovePublicData_Public_Virtual_New_IEnumerable_1_IAttribute_Entity_EntityID_EntityID_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_MakeObfuscatedMovePublicData_Public_Virtual_New_IEnumerable_1_IAttribute_SerializedEntity_EntityID_EntityID_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberOfAISelectionsToStore_Protected_Virtual_New_get_Int32_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_StoreAISelectionForLog_Public_Void_String_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousAISelections_Public_String_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_PrePendSelection_Public_Virtual_New_IEnumerable_1_Action_List_1_ValueTuple_2_PlayerEntity_PendingSelection_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_get_TimerMode_Public_Abstract_Virtual_New_get_TimerModes_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_get_TimerLength_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_get_UseTimers_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveTimers_Public_get_IReadOnlyCollection_1_TimerInfo_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_TrackTimer_Public_Void_TimerID_String_AccountID_SelectionMessage_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_TrackTimer_Public_Void_TimerID_String_Il2CppReferenceArray_1_ValueTuple_2_AccountID_SelectionMessage_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_UntrackTimer_Public_Void_TimerID_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_CancelTimersForCounter_Public_Void_AccountID_Int32_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_TimerIsActive_Public_Boolean_TimerID_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_TimeoutDisconnectedPlayer_Public_Virtual_New_Void_AccountID_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSetTimerForSelection_Public_Virtual_New_Boolean_PlayerEntity_SelectionMessage_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_GetTimerForSelection_Public_Virtual_New_Int32_PlayerEntity_SelectionMessage_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_GetTimerPaddingForSelection_Public_Virtual_New_Single_PlayerEntity_SelectionMessage_0;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalTimerTime_Public_Virtual_New_Int32_PlayerEntity_SelectionMessage_0;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr__Configure_b__78_0_Private_MatchInitData_MatchInitData_Int32_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr__ClaimOwnedEntitiesForPending_b__145_0_Private_IEnumerable_1_Entity_EntityID_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr__TargetInfoDebugInfo_b__186_0_Private_String_KeyValuePair_2_EntityID_Int32_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr__TargetInfoDebugInfo_b__186_1_Private_String_KeyValuePair_2_Int32_TargetInformation_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr__SelectionDebugInfo_b__187_0_Private_String_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0;

		// Token: 0x02000255 RID: 597
		public enum ResignationType
		{
			// Token: 0x04000FEB RID: 4075
			Timeout,
			// Token: 0x04000FEC RID: 4076
			Resign
		}

		// Token: 0x02000256 RID: 598
		[ObfuscatedName("Canis.Match+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060018E1 RID: 6369 RVA: 0x0007C0A0 File Offset: 0x0007A2A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Match.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c>.NativeClassPtr);
				Match.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9");
				Match.__c.NativeFieldInfoPtr___9__122_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__122_0");
				Match.__c.NativeFieldInfoPtr___9__147_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__147_0");
				Match.__c.NativeFieldInfoPtr___9__147_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__147_1");
				Match.__c.NativeFieldInfoPtr___9__147_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__147_2");
				Match.__c.NativeFieldInfoPtr___9__147_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__147_3");
				Match.__c.NativeFieldInfoPtr___9__156_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__156_0");
				Match.__c.NativeFieldInfoPtr___9__157_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__157_0");
				Match.__c.NativeFieldInfoPtr___9__157_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__157_1");
				Match.__c.NativeFieldInfoPtr___9__157_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__157_3");
				Match.__c.NativeFieldInfoPtr___9__157_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__157_2");
				Match.__c.NativeFieldInfoPtr___9__157_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__157_7");
				Match.__c.NativeFieldInfoPtr___9__157_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__157_4");
				Match.__c.NativeFieldInfoPtr___9__157_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__157_12");
				Match.__c.NativeFieldInfoPtr___9__157_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__157_6");
				Match.__c.NativeFieldInfoPtr___9__165_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__165_1");
				Match.__c.NativeFieldInfoPtr___9__166_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__166_0");
				Match.__c.NativeFieldInfoPtr___9__189_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__189_0");
				Match.__c.NativeFieldInfoPtr___9__189_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__189_1");
				Match.__c.NativeFieldInfoPtr___9__204_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__204_1");
				Match.__c.NativeFieldInfoPtr___9__204_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__204_2");
				Match.__c.NativeFieldInfoPtr___9__219_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__219_0");
				Match.__c.NativeFieldInfoPtr___9__219_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__219_1");
				Match.__c.NativeFieldInfoPtr___9__220_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__220_1");
				Match.__c.NativeFieldInfoPtr___9__221_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__221_1");
				Match.__c.NativeFieldInfoPtr___9__221_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__221_3");
				Match.__c.NativeFieldInfoPtr___9__244_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__244_0");
				Match.__c.NativeFieldInfoPtr___9__244_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, "<>9__244_1");
				Match.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663702);
				Match.__c.NativeMethodInfoPtr__get_IsAIOnly_b__122_0_Internal_Boolean_PlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663703);
				Match.__c.NativeMethodInfoPtr__MakeNewSaveData_b__147_0_Internal_AccountID_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663704);
				Match.__c.NativeMethodInfoPtr__MakeNewSaveData_b__147_1_Internal_PlayerInfoSaveData_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663705);
				Match.__c.NativeMethodInfoPtr__MakeNewSaveData_b__147_2_Internal_Boolean_PlayerInfoSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663706);
				Match.__c.NativeMethodInfoPtr__MakeNewSaveData_b__147_3_Internal_AccountID_PlayerInfoSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663707);
				Match.__c.NativeMethodInfoPtr__PostClearDisplayActions_b__156_0_Internal_SequenceMessage_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663708);
				Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_0_Internal_PlayerEntity_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663709);
				Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_1_Internal_List_1_PendingSelection_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663710);
				Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_2_Internal_String_KeyValuePair_2_PlayerEntity_List_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663711);
				Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_3_Internal_Int32_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663712);
				Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_4_Internal_IEnumerable_1_Int32_KeyValuePair_2_PlayerEntity_List_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663713);
				Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_7_Internal_Int32_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663714);
				Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_12_Internal_AccountID_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663715);
				Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_6_Internal_Boolean_KeyValuePair_2_PlayerEntity_List_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663716);
				Match.__c.NativeMethodInfoPtr__SetNonPromptText_b__165_1_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663717);
				Match.__c.NativeMethodInfoPtr__ClearNonPromptText_b__166_0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663718);
				Match.__c.NativeMethodInfoPtr__AddClientInfoForAnalyticsIfOfflineMatch_b__189_0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663719);
				Match.__c.NativeMethodInfoPtr__AddClientInfoForAnalyticsIfOfflineMatch_b__189_1_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663720);
				Match.__c.NativeMethodInfoPtr__HandleResignGameAsync_b__204_1_Internal_AccountID_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663721);
				Match.__c.NativeMethodInfoPtr__HandleResignGameAsync_b__204_2_Internal_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663722);
				Match.__c.NativeMethodInfoPtr__PlayerIDsMakingSelections_b__219_0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663723);
				Match.__c.NativeMethodInfoPtr__PlayerIDsMakingSelections_b__219_1_Internal_AccountID_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663724);
				Match.__c.NativeMethodInfoPtr__ActiveSelectionsOfPlayer_b__220_1_Internal_SelectionMessage_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663725);
				Match.__c.NativeMethodInfoPtr__PlayerIDForSelection_b__221_1_Internal_AccountID_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663726);
				Match.__c.NativeMethodInfoPtr__PlayerIDForSelection_b__221_3_Internal_AccountID_KeyValuePair_2_AccountID_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663727);
				Match.__c.NativeMethodInfoPtr__TrackTimer_b__244_0_Internal_AccountID_ValueTuple_2_AccountID_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663728);
				Match.__c.NativeMethodInfoPtr__TrackTimer_b__244_1_Internal_SelectionMessage_ValueTuple_2_AccountID_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c>.NativeClassPtr, 100663729);
			}

			// Token: 0x060018E2 RID: 6370 RVA: 0x0007C52C File Offset: 0x0007A72C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018E3 RID: 6371 RVA: 0x0007C568 File Offset: 0x0007A768
			[CallerCount(0)]
			public unsafe bool _get_IsAIOnly_b__122_0(PlayerMatchInitData p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__get_IsAIOnly_b__122_0_Internal_Boolean_PlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018E4 RID: 6372 RVA: 0x0007C5B8 File Offset: 0x0007A7B8
			[CallerCount(0)]
			public unsafe AccountID _MakeNewSaveData_b__147_0(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__MakeNewSaveData_b__147_0_Internal_AccountID_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060018E5 RID: 6373 RVA: 0x0007C608 File Offset: 0x0007A808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544605, XrefRangeEnd = 544606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerInfoSaveData _MakeNewSaveData_b__147_1(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__MakeNewSaveData_b__147_1_Internal_PlayerInfoSaveData_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerInfoSaveData>(intPtr3) : null;
				}
			}

			// Token: 0x060018E6 RID: 6374 RVA: 0x0007C658 File Offset: 0x0007A858
			[CallerCount(0)]
			public unsafe bool _MakeNewSaveData_b__147_2(PlayerInfoSaveData p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__MakeNewSaveData_b__147_2_Internal_Boolean_PlayerInfoSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018E7 RID: 6375 RVA: 0x0007C6A8 File Offset: 0x0007A8A8
			[CallerCount(0)]
			public unsafe AccountID _MakeNewSaveData_b__147_3(PlayerInfoSaveData p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__MakeNewSaveData_b__147_3_Internal_AccountID_PlayerInfoSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060018E8 RID: 6376 RVA: 0x0007C6F8 File Offset: 0x0007A8F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544606, XrefRangeEnd = 544610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SequenceMessage _PostClearDisplayActions_b__156_0(PendingSelection _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__PostClearDisplayActions_b__156_0_Internal_SequenceMessage_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceMessage>(intPtr3) : null;
				}
			}

			// Token: 0x060018E9 RID: 6377 RVA: 0x0007C748 File Offset: 0x0007A948
			[CallerCount(0)]
			public unsafe PlayerEntity _SaveOnPause_b__157_0(ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_0_Internal_PlayerEntity_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x060018EA RID: 6378 RVA: 0x0007C7A0 File Offset: 0x0007A9A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544610, XrefRangeEnd = 544613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe List<PendingSelection> _SaveOnPause_b__157_1(ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_1_Internal_List_1_PendingSelection_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<PendingSelection>>(intPtr3) : null;
				}
			}

			// Token: 0x060018EB RID: 6379 RVA: 0x0007C7F8 File Offset: 0x0007A9F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544613, XrefRangeEnd = 544642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SaveOnPause_b__157_2(KeyValuePair<PlayerEntity, List<PendingSelection>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_2_Internal_String_KeyValuePair_2_PlayerEntity_List_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060018EC RID: 6380 RVA: 0x0007C848 File Offset: 0x0007AA48
			[CallerCount(0)]
			public unsafe int _SaveOnPause_b__157_3(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_3_Internal_Int32_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018ED RID: 6381 RVA: 0x0007C898 File Offset: 0x0007AA98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544642, XrefRangeEnd = 544661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _SaveOnPause_b__157_4(KeyValuePair<PlayerEntity, List<PendingSelection>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_4_Internal_IEnumerable_1_Int32_KeyValuePair_2_PlayerEntity_List_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
				}
			}

			// Token: 0x060018EE RID: 6382 RVA: 0x0007C8F0 File Offset: 0x0007AAF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544661, XrefRangeEnd = 544663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _SaveOnPause_b__157_7(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_7_Internal_Int32_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018EF RID: 6383 RVA: 0x0007C940 File Offset: 0x0007AB40
			[CallerCount(0)]
			public unsafe AccountID _SaveOnPause_b__157_12(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_12_Internal_AccountID_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060018F0 RID: 6384 RVA: 0x0007C990 File Offset: 0x0007AB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544663, XrefRangeEnd = 544668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SaveOnPause_b__157_6(KeyValuePair<PlayerEntity, List<PendingSelection>> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__SaveOnPause_b__157_6_Internal_Boolean_KeyValuePair_2_PlayerEntity_List_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018F1 RID: 6385 RVA: 0x0007C9E4 File Offset: 0x0007ABE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544668, XrefRangeEnd = 544672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetNonPromptText_b__165_1(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__SetNonPromptText_b__165_1_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018F2 RID: 6386 RVA: 0x0007CA34 File Offset: 0x0007AC34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544672, XrefRangeEnd = 544680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClearNonPromptText_b__166_0(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__ClearNonPromptText_b__166_0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018F3 RID: 6387 RVA: 0x0007CA84 File Offset: 0x0007AC84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddClientInfoForAnalyticsIfOfflineMatch_b__189_0(PlayerEntity player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__AddClientInfoForAnalyticsIfOfflineMatch_b__189_0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018F4 RID: 6388 RVA: 0x0007CAD4 File Offset: 0x0007ACD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddClientInfoForAnalyticsIfOfflineMatch_b__189_1(PlayerEntity player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__AddClientInfoForAnalyticsIfOfflineMatch_b__189_1_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018F5 RID: 6389 RVA: 0x0007CB24 File Offset: 0x0007AD24
			[CallerCount(0)]
			public unsafe AccountID _HandleResignGameAsync_b__204_1(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__HandleResignGameAsync_b__204_1_Internal_AccountID_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060018F6 RID: 6390 RVA: 0x0007CB74 File Offset: 0x0007AD74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544680, XrefRangeEnd = 544684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>> _HandleResignGameAsync_b__204_2(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__HandleResignGameAsync_b__204_2_Internal_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>(intPtr);
				}
			}

			// Token: 0x060018F7 RID: 6391 RVA: 0x0007CBBC File Offset: 0x0007ADBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544684, XrefRangeEnd = 544688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayerIDsMakingSelections_b__219_0(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__PlayerIDsMakingSelections_b__219_0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018F8 RID: 6392 RVA: 0x0007CC0C File Offset: 0x0007AE0C
			[CallerCount(0)]
			public unsafe AccountID _PlayerIDsMakingSelections_b__219_1(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__PlayerIDsMakingSelections_b__219_1_Internal_AccountID_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060018F9 RID: 6393 RVA: 0x0007CC5C File Offset: 0x0007AE5C
			[CallerCount(0)]
			public unsafe SelectionMessage _ActiveSelectionsOfPlayer_b__220_1(PendingSelection _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__ActiveSelectionsOfPlayer_b__220_1_Internal_SelectionMessage_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr3) : null;
				}
			}

			// Token: 0x060018FA RID: 6394 RVA: 0x0007CCAC File Offset: 0x0007AEAC
			[CallerCount(0)]
			public unsafe AccountID _PlayerIDForSelection_b__221_1(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__PlayerIDForSelection_b__221_1_Internal_AccountID_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060018FB RID: 6395 RVA: 0x0007CCFC File Offset: 0x0007AEFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544688, XrefRangeEnd = 544689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AccountID _PlayerIDForSelection_b__221_3(KeyValuePair<AccountID, SelectionMessage> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__PlayerIDForSelection_b__221_3_Internal_AccountID_KeyValuePair_2_AccountID_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060018FC RID: 6396 RVA: 0x0007CD54 File Offset: 0x0007AF54
			[CallerCount(0)]
			public unsafe AccountID _TrackTimer_b__244_0(ValueTuple<AccountID, SelectionMessage> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__TrackTimer_b__244_0_Internal_AccountID_ValueTuple_2_AccountID_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060018FD RID: 6397 RVA: 0x0007CDAC File Offset: 0x0007AFAC
			[CallerCount(0)]
			public unsafe SelectionMessage _TrackTimer_b__244_1(ValueTuple<AccountID, SelectionMessage> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c.NativeMethodInfoPtr__TrackTimer_b__244_1_Internal_SelectionMessage_ValueTuple_2_AccountID_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr3) : null;
				}
			}

			// Token: 0x060018FE RID: 6398 RVA: 0x0000BE12 File Offset: 0x0000A012
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700057B RID: 1403
			// (get) Token: 0x060018FF RID: 6399 RVA: 0x0007CE04 File Offset: 0x0007B004
			// (set) Token: 0x06001900 RID: 6400 RVA: 0x0000BE1B File Offset: 0x0000A01B
			public unsafe static Match.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700057C RID: 1404
			// (get) Token: 0x06001901 RID: 6401 RVA: 0x0007CE2C File Offset: 0x0007B02C
			// (set) Token: 0x06001902 RID: 6402 RVA: 0x0000BE2D File Offset: 0x0000A02D
			public unsafe static Func<PlayerMatchInitData, bool> __9__122_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__122_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerMatchInitData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__122_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700057D RID: 1405
			// (get) Token: 0x06001903 RID: 6403 RVA: 0x0007CE54 File Offset: 0x0007B054
			// (set) Token: 0x06001904 RID: 6404 RVA: 0x0000BE3F File Offset: 0x0000A03F
			public unsafe static Func<PlayerEntity, AccountID> __9__147_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__147_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__147_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700057E RID: 1406
			// (get) Token: 0x06001905 RID: 6405 RVA: 0x0007CE7C File Offset: 0x0007B07C
			// (set) Token: 0x06001906 RID: 6406 RVA: 0x0000BE51 File Offset: 0x0000A051
			public unsafe static Func<PlayerEntity, PlayerInfoSaveData> __9__147_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__147_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, PlayerInfoSaveData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__147_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700057F RID: 1407
			// (get) Token: 0x06001907 RID: 6407 RVA: 0x0007CEA4 File Offset: 0x0007B0A4
			// (set) Token: 0x06001908 RID: 6408 RVA: 0x0000BE63 File Offset: 0x0000A063
			public unsafe static Func<PlayerInfoSaveData, bool> __9__147_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__147_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerInfoSaveData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__147_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000580 RID: 1408
			// (get) Token: 0x06001909 RID: 6409 RVA: 0x0007CECC File Offset: 0x0007B0CC
			// (set) Token: 0x0600190A RID: 6410 RVA: 0x0000BE75 File Offset: 0x0000A075
			public unsafe static Func<PlayerInfoSaveData, AccountID> __9__147_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__147_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerInfoSaveData, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__147_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000581 RID: 1409
			// (get) Token: 0x0600190B RID: 6411 RVA: 0x0007CEF4 File Offset: 0x0007B0F4
			// (set) Token: 0x0600190C RID: 6412 RVA: 0x0000BE87 File Offset: 0x0000A087
			public unsafe static Func<PendingSelection, SequenceMessage> __9__156_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__156_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, SequenceMessage>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__156_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000582 RID: 1410
			// (get) Token: 0x0600190D RID: 6413 RVA: 0x0007CF1C File Offset: 0x0007B11C
			// (set) Token: 0x0600190E RID: 6414 RVA: 0x0000BE99 File Offset: 0x0000A099
			public unsafe static Func<ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>, PlayerEntity> __9__157_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__157_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>, PlayerEntity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__157_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000583 RID: 1411
			// (get) Token: 0x0600190F RID: 6415 RVA: 0x0007CF44 File Offset: 0x0007B144
			// (set) Token: 0x06001910 RID: 6416 RVA: 0x0000BEAB File Offset: 0x0000A0AB
			public unsafe static Func<ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>, List<PendingSelection>> __9__157_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__157_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>, List<PendingSelection>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__157_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000584 RID: 1412
			// (get) Token: 0x06001911 RID: 6417 RVA: 0x0007CF6C File Offset: 0x0007B16C
			// (set) Token: 0x06001912 RID: 6418 RVA: 0x0000BEBD File Offset: 0x0000A0BD
			public unsafe static Func<PendingSelection, int> __9__157_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__157_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__157_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000585 RID: 1413
			// (get) Token: 0x06001913 RID: 6419 RVA: 0x0007CF94 File Offset: 0x0007B194
			// (set) Token: 0x06001914 RID: 6420 RVA: 0x0000BECF File Offset: 0x0000A0CF
			public unsafe static Func<KeyValuePair<PlayerEntity, List<PendingSelection>>, string> __9__157_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__157_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<PlayerEntity, List<PendingSelection>>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__157_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000586 RID: 1414
			// (get) Token: 0x06001915 RID: 6421 RVA: 0x0007CFBC File Offset: 0x0007B1BC
			// (set) Token: 0x06001916 RID: 6422 RVA: 0x0000BEE1 File Offset: 0x0000A0E1
			public unsafe static Func<PendingSelection, int> __9__157_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__157_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__157_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000587 RID: 1415
			// (get) Token: 0x06001917 RID: 6423 RVA: 0x0007CFE4 File Offset: 0x0007B1E4
			// (set) Token: 0x06001918 RID: 6424 RVA: 0x0000BEF3 File Offset: 0x0000A0F3
			public unsafe static Func<KeyValuePair<PlayerEntity, List<PendingSelection>>, IEnumerable<int>> __9__157_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__157_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<PlayerEntity, List<PendingSelection>>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__157_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000588 RID: 1416
			// (get) Token: 0x06001919 RID: 6425 RVA: 0x0007D00C File Offset: 0x0007B20C
			// (set) Token: 0x0600191A RID: 6426 RVA: 0x0000BF05 File Offset: 0x0000A105
			public unsafe static Func<PlayerEntity, AccountID> __9__157_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__157_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__157_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000589 RID: 1417
			// (get) Token: 0x0600191B RID: 6427 RVA: 0x0007D034 File Offset: 0x0007B234
			// (set) Token: 0x0600191C RID: 6428 RVA: 0x0000BF17 File Offset: 0x0000A117
			public unsafe static Func<KeyValuePair<PlayerEntity, List<PendingSelection>>, bool> __9__157_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__157_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<PlayerEntity, List<PendingSelection>>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__157_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058A RID: 1418
			// (get) Token: 0x0600191D RID: 6429 RVA: 0x0007D05C File Offset: 0x0007B25C
			// (set) Token: 0x0600191E RID: 6430 RVA: 0x0000BF29 File Offset: 0x0000A129
			public unsafe static Func<PlayerEntity, bool> __9__165_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__165_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__165_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058B RID: 1419
			// (get) Token: 0x0600191F RID: 6431 RVA: 0x0007D084 File Offset: 0x0007B284
			// (set) Token: 0x06001920 RID: 6432 RVA: 0x0000BF3B File Offset: 0x0000A13B
			public unsafe static Func<PlayerEntity, bool> __9__166_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__166_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__166_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058C RID: 1420
			// (get) Token: 0x06001921 RID: 6433 RVA: 0x0007D0AC File Offset: 0x0007B2AC
			// (set) Token: 0x06001922 RID: 6434 RVA: 0x0000BF4D File Offset: 0x0000A14D
			public unsafe static Func<PlayerEntity, bool> __9__189_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__189_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__189_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058D RID: 1421
			// (get) Token: 0x06001923 RID: 6435 RVA: 0x0007D0D4 File Offset: 0x0007B2D4
			// (set) Token: 0x06001924 RID: 6436 RVA: 0x0000BF5F File Offset: 0x0000A15F
			public unsafe static Func<PlayerEntity, bool> __9__189_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__189_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__189_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058E RID: 1422
			// (get) Token: 0x06001925 RID: 6437 RVA: 0x0007D0FC File Offset: 0x0007B2FC
			// (set) Token: 0x06001926 RID: 6438 RVA: 0x0000BF71 File Offset: 0x0000A171
			public unsafe static Func<PlayerEntity, AccountID> __9__204_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__204_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__204_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700058F RID: 1423
			// (get) Token: 0x06001927 RID: 6439 RVA: 0x0007D124 File Offset: 0x0007B324
			// (set) Token: 0x06001928 RID: 6440 RVA: 0x0000BF83 File Offset: 0x0000A183
			public unsafe static Func<PlayerEntity, ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>> __9__204_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__204_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, ValueTuple<PlayerEntity, IReadOnlyCollection<PendingSelection>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__204_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000590 RID: 1424
			// (get) Token: 0x06001929 RID: 6441 RVA: 0x0007D14C File Offset: 0x0007B34C
			// (set) Token: 0x0600192A RID: 6442 RVA: 0x0000BF95 File Offset: 0x0000A195
			public unsafe static Func<PlayerEntity, bool> __9__219_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__219_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__219_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000591 RID: 1425
			// (get) Token: 0x0600192B RID: 6443 RVA: 0x0007D174 File Offset: 0x0007B374
			// (set) Token: 0x0600192C RID: 6444 RVA: 0x0000BFA7 File Offset: 0x0000A1A7
			public unsafe static Func<PlayerEntity, AccountID> __9__219_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__219_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__219_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000592 RID: 1426
			// (get) Token: 0x0600192D RID: 6445 RVA: 0x0007D19C File Offset: 0x0007B39C
			// (set) Token: 0x0600192E RID: 6446 RVA: 0x0000BFB9 File Offset: 0x0000A1B9
			public unsafe static Func<PendingSelection, SelectionMessage> __9__220_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__220_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, SelectionMessage>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__220_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000593 RID: 1427
			// (get) Token: 0x0600192F RID: 6447 RVA: 0x0007D1C4 File Offset: 0x0007B3C4
			// (set) Token: 0x06001930 RID: 6448 RVA: 0x0000BFCB File Offset: 0x0000A1CB
			public unsafe static Func<PlayerEntity, AccountID> __9__221_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__221_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerEntity, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__221_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000594 RID: 1428
			// (get) Token: 0x06001931 RID: 6449 RVA: 0x0007D1EC File Offset: 0x0007B3EC
			// (set) Token: 0x06001932 RID: 6450 RVA: 0x0000BFDD File Offset: 0x0000A1DD
			public unsafe static Func<KeyValuePair<AccountID, SelectionMessage>, AccountID> __9__221_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__221_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<AccountID, SelectionMessage>, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__221_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000595 RID: 1429
			// (get) Token: 0x06001933 RID: 6451 RVA: 0x0007D214 File Offset: 0x0007B414
			// (set) Token: 0x06001934 RID: 6452 RVA: 0x0000BFEF File Offset: 0x0000A1EF
			public unsafe static Func<ValueTuple<AccountID, SelectionMessage>, AccountID> __9__244_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__244_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<AccountID, SelectionMessage>, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__244_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000596 RID: 1430
			// (get) Token: 0x06001935 RID: 6453 RVA: 0x0007D23C File Offset: 0x0007B43C
			// (set) Token: 0x06001936 RID: 6454 RVA: 0x0000C001 File Offset: 0x0000A201
			public unsafe static Func<ValueTuple<AccountID, SelectionMessage>, SelectionMessage> __9__244_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Match.__c.NativeFieldInfoPtr___9__244_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<AccountID, SelectionMessage>, SelectionMessage>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Match.__c.NativeFieldInfoPtr___9__244_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000FED RID: 4077
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000FEE RID: 4078
			private static readonly IntPtr NativeFieldInfoPtr___9__122_0;

			// Token: 0x04000FEF RID: 4079
			private static readonly IntPtr NativeFieldInfoPtr___9__147_0;

			// Token: 0x04000FF0 RID: 4080
			private static readonly IntPtr NativeFieldInfoPtr___9__147_1;

			// Token: 0x04000FF1 RID: 4081
			private static readonly IntPtr NativeFieldInfoPtr___9__147_2;

			// Token: 0x04000FF2 RID: 4082
			private static readonly IntPtr NativeFieldInfoPtr___9__147_3;

			// Token: 0x04000FF3 RID: 4083
			private static readonly IntPtr NativeFieldInfoPtr___9__156_0;

			// Token: 0x04000FF4 RID: 4084
			private static readonly IntPtr NativeFieldInfoPtr___9__157_0;

			// Token: 0x04000FF5 RID: 4085
			private static readonly IntPtr NativeFieldInfoPtr___9__157_1;

			// Token: 0x04000FF6 RID: 4086
			private static readonly IntPtr NativeFieldInfoPtr___9__157_3;

			// Token: 0x04000FF7 RID: 4087
			private static readonly IntPtr NativeFieldInfoPtr___9__157_2;

			// Token: 0x04000FF8 RID: 4088
			private static readonly IntPtr NativeFieldInfoPtr___9__157_7;

			// Token: 0x04000FF9 RID: 4089
			private static readonly IntPtr NativeFieldInfoPtr___9__157_4;

			// Token: 0x04000FFA RID: 4090
			private static readonly IntPtr NativeFieldInfoPtr___9__157_12;

			// Token: 0x04000FFB RID: 4091
			private static readonly IntPtr NativeFieldInfoPtr___9__157_6;

			// Token: 0x04000FFC RID: 4092
			private static readonly IntPtr NativeFieldInfoPtr___9__165_1;

			// Token: 0x04000FFD RID: 4093
			private static readonly IntPtr NativeFieldInfoPtr___9__166_0;

			// Token: 0x04000FFE RID: 4094
			private static readonly IntPtr NativeFieldInfoPtr___9__189_0;

			// Token: 0x04000FFF RID: 4095
			private static readonly IntPtr NativeFieldInfoPtr___9__189_1;

			// Token: 0x04001000 RID: 4096
			private static readonly IntPtr NativeFieldInfoPtr___9__204_1;

			// Token: 0x04001001 RID: 4097
			private static readonly IntPtr NativeFieldInfoPtr___9__204_2;

			// Token: 0x04001002 RID: 4098
			private static readonly IntPtr NativeFieldInfoPtr___9__219_0;

			// Token: 0x04001003 RID: 4099
			private static readonly IntPtr NativeFieldInfoPtr___9__219_1;

			// Token: 0x04001004 RID: 4100
			private static readonly IntPtr NativeFieldInfoPtr___9__220_1;

			// Token: 0x04001005 RID: 4101
			private static readonly IntPtr NativeFieldInfoPtr___9__221_1;

			// Token: 0x04001006 RID: 4102
			private static readonly IntPtr NativeFieldInfoPtr___9__221_3;

			// Token: 0x04001007 RID: 4103
			private static readonly IntPtr NativeFieldInfoPtr___9__244_0;

			// Token: 0x04001008 RID: 4104
			private static readonly IntPtr NativeFieldInfoPtr___9__244_1;

			// Token: 0x04001009 RID: 4105
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400100A RID: 4106
			private static readonly IntPtr NativeMethodInfoPtr__get_IsAIOnly_b__122_0_Internal_Boolean_PlayerMatchInitData_0;

			// Token: 0x0400100B RID: 4107
			private static readonly IntPtr NativeMethodInfoPtr__MakeNewSaveData_b__147_0_Internal_AccountID_PlayerEntity_0;

			// Token: 0x0400100C RID: 4108
			private static readonly IntPtr NativeMethodInfoPtr__MakeNewSaveData_b__147_1_Internal_PlayerInfoSaveData_PlayerEntity_0;

			// Token: 0x0400100D RID: 4109
			private static readonly IntPtr NativeMethodInfoPtr__MakeNewSaveData_b__147_2_Internal_Boolean_PlayerInfoSaveData_0;

			// Token: 0x0400100E RID: 4110
			private static readonly IntPtr NativeMethodInfoPtr__MakeNewSaveData_b__147_3_Internal_AccountID_PlayerInfoSaveData_0;

			// Token: 0x0400100F RID: 4111
			private static readonly IntPtr NativeMethodInfoPtr__PostClearDisplayActions_b__156_0_Internal_SequenceMessage_PendingSelection_0;

			// Token: 0x04001010 RID: 4112
			private static readonly IntPtr NativeMethodInfoPtr__SaveOnPause_b__157_0_Internal_PlayerEntity_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0;

			// Token: 0x04001011 RID: 4113
			private static readonly IntPtr NativeMethodInfoPtr__SaveOnPause_b__157_1_Internal_List_1_PendingSelection_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_0;

			// Token: 0x04001012 RID: 4114
			private static readonly IntPtr NativeMethodInfoPtr__SaveOnPause_b__157_2_Internal_String_KeyValuePair_2_PlayerEntity_List_1_PendingSelection_0;

			// Token: 0x04001013 RID: 4115
			private static readonly IntPtr NativeMethodInfoPtr__SaveOnPause_b__157_3_Internal_Int32_PendingSelection_0;

			// Token: 0x04001014 RID: 4116
			private static readonly IntPtr NativeMethodInfoPtr__SaveOnPause_b__157_4_Internal_IEnumerable_1_Int32_KeyValuePair_2_PlayerEntity_List_1_PendingSelection_0;

			// Token: 0x04001015 RID: 4117
			private static readonly IntPtr NativeMethodInfoPtr__SaveOnPause_b__157_7_Internal_Int32_PendingSelection_0;

			// Token: 0x04001016 RID: 4118
			private static readonly IntPtr NativeMethodInfoPtr__SaveOnPause_b__157_12_Internal_AccountID_PlayerEntity_0;

			// Token: 0x04001017 RID: 4119
			private static readonly IntPtr NativeMethodInfoPtr__SaveOnPause_b__157_6_Internal_Boolean_KeyValuePair_2_PlayerEntity_List_1_PendingSelection_0;

			// Token: 0x04001018 RID: 4120
			private static readonly IntPtr NativeMethodInfoPtr__SetNonPromptText_b__165_1_Internal_Boolean_PlayerEntity_0;

			// Token: 0x04001019 RID: 4121
			private static readonly IntPtr NativeMethodInfoPtr__ClearNonPromptText_b__166_0_Internal_Boolean_PlayerEntity_0;

			// Token: 0x0400101A RID: 4122
			private static readonly IntPtr NativeMethodInfoPtr__AddClientInfoForAnalyticsIfOfflineMatch_b__189_0_Internal_Boolean_PlayerEntity_0;

			// Token: 0x0400101B RID: 4123
			private static readonly IntPtr NativeMethodInfoPtr__AddClientInfoForAnalyticsIfOfflineMatch_b__189_1_Internal_Boolean_PlayerEntity_0;

			// Token: 0x0400101C RID: 4124
			private static readonly IntPtr NativeMethodInfoPtr__HandleResignGameAsync_b__204_1_Internal_AccountID_PlayerEntity_0;

			// Token: 0x0400101D RID: 4125
			private static readonly IntPtr NativeMethodInfoPtr__HandleResignGameAsync_b__204_2_Internal_ValueTuple_2_PlayerEntity_IReadOnlyCollection_1_PendingSelection_PlayerEntity_0;

			// Token: 0x0400101E RID: 4126
			private static readonly IntPtr NativeMethodInfoPtr__PlayerIDsMakingSelections_b__219_0_Internal_Boolean_PlayerEntity_0;

			// Token: 0x0400101F RID: 4127
			private static readonly IntPtr NativeMethodInfoPtr__PlayerIDsMakingSelections_b__219_1_Internal_AccountID_PlayerEntity_0;

			// Token: 0x04001020 RID: 4128
			private static readonly IntPtr NativeMethodInfoPtr__ActiveSelectionsOfPlayer_b__220_1_Internal_SelectionMessage_PendingSelection_0;

			// Token: 0x04001021 RID: 4129
			private static readonly IntPtr NativeMethodInfoPtr__PlayerIDForSelection_b__221_1_Internal_AccountID_PlayerEntity_0;

			// Token: 0x04001022 RID: 4130
			private static readonly IntPtr NativeMethodInfoPtr__PlayerIDForSelection_b__221_3_Internal_AccountID_KeyValuePair_2_AccountID_SelectionMessage_0;

			// Token: 0x04001023 RID: 4131
			private static readonly IntPtr NativeMethodInfoPtr__TrackTimer_b__244_0_Internal_AccountID_ValueTuple_2_AccountID_SelectionMessage_0;

			// Token: 0x04001024 RID: 4132
			private static readonly IntPtr NativeMethodInfoPtr__TrackTimer_b__244_1_Internal_SelectionMessage_ValueTuple_2_AccountID_SelectionMessage_0;
		}

		// Token: 0x02000257 RID: 599
		[ObfuscatedName("Canis.Match+<>c__DisplayClass152_0")]
		public sealed class __c__DisplayClass152_0 : Object
		{
			// Token: 0x06001937 RID: 6455 RVA: 0x0007D264 File Offset: 0x0007B464
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass152_0()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass152_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass152_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass152_0>.NativeClassPtr);
				Match.__c__DisplayClass152_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass152_0>.NativeClassPtr, "<>4__this");
				Match.__c__DisplayClass152_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass152_0>.NativeClassPtr, "message");
				Match.__c__DisplayClass152_0.NativeFieldInfoPtr_playerToNotify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass152_0>.NativeClassPtr, "playerToNotify");
				Match.__c__DisplayClass152_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass152_0>.NativeClassPtr, 100663730);
				Match.__c__DisplayClass152_0.NativeMethodInfoPtr__SendNotificationToPlayer_b__0_Internal_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass152_0>.NativeClassPtr, 100663731);
			}

			// Token: 0x06001938 RID: 6456 RVA: 0x0007D2F4 File Offset: 0x0007B4F4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass152_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass152_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass152_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001939 RID: 6457 RVA: 0x0007D330 File Offset: 0x0007B530
			[CallerCount(0)]
			public unsafe Task _SendNotificationToPlayer_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass152_0.NativeMethodInfoPtr__SendNotificationToPlayer_b__0_Internal_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}

			// Token: 0x0600193A RID: 6458 RVA: 0x0000C013 File Offset: 0x0000A213
			public __c__DisplayClass152_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000597 RID: 1431
			// (get) Token: 0x0600193B RID: 6459 RVA: 0x0007D370 File Offset: 0x0007B570
			// (set) Token: 0x0600193C RID: 6460 RVA: 0x0000C01C File Offset: 0x0000A21C
			public unsafe Match __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass152_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass152_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000598 RID: 1432
			// (get) Token: 0x0600193D RID: 6461 RVA: 0x0007D3A0 File Offset: 0x0007B5A0
			// (set) Token: 0x0600193E RID: 6462 RVA: 0x0000C03B File Offset: 0x0000A23B
			public unsafe string message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass152_0.NativeFieldInfoPtr_message);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass152_0.NativeFieldInfoPtr_message), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000599 RID: 1433
			// (get) Token: 0x0600193F RID: 6463 RVA: 0x0007D3C8 File Offset: 0x0007B5C8
			// (set) Token: 0x06001940 RID: 6464 RVA: 0x0000C05A File Offset: 0x0000A25A
			public unsafe AccountID playerToNotify
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass152_0.NativeFieldInfoPtr_playerToNotify);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass152_0.NativeFieldInfoPtr_playerToNotify), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001025 RID: 4133
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001026 RID: 4134
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04001027 RID: 4135
			private static readonly IntPtr NativeFieldInfoPtr_playerToNotify;

			// Token: 0x04001028 RID: 4136
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001029 RID: 4137
			private static readonly IntPtr NativeMethodInfoPtr__SendNotificationToPlayer_b__0_Internal_Task_0;
		}

		// Token: 0x02000258 RID: 600
		[ObfuscatedName("Canis.Match+<>c__DisplayClass157_0")]
		public sealed class __c__DisplayClass157_0 : Object
		{
			// Token: 0x06001941 RID: 6465 RVA: 0x0007D3F8 File Offset: 0x0007B5F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass157_0()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass157_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass157_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass157_0>.NativeClassPtr);
				Match.__c__DisplayClass157_0.NativeFieldInfoPtr_allPendingSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass157_0>.NativeClassPtr, "allPendingSelections");
				Match.__c__DisplayClass157_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass157_0>.NativeClassPtr, "<>4__this");
				Match.__c__DisplayClass157_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass157_0>.NativeClassPtr, 100663732);
				Match.__c__DisplayClass157_0.NativeMethodInfoPtr__SaveOnPause_b__8_Internal_IEnumerable_1_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass157_0>.NativeClassPtr, 100663733);
				Match.__c__DisplayClass157_0.NativeMethodInfoPtr_Method_Internal_SerializedGameState_byref___c__DisplayClass157_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass157_0>.NativeClassPtr, 100663734);
			}

			// Token: 0x06001942 RID: 6466 RVA: 0x0007D488 File Offset: 0x0007B688
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass157_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass157_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass157_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001943 RID: 6467 RVA: 0x0007D4C4 File Offset: 0x0007B6C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544689, XrefRangeEnd = 544703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<string> _SaveOnPause_b__8(int counter)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref counter;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass157_0.NativeMethodInfoPtr__SaveOnPause_b__8_Internal_IEnumerable_1_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
				}
			}

			// Token: 0x06001944 RID: 6468 RVA: 0x0007D510 File Offset: 0x0007B710
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 544727, RefRangeEnd = 544730, XrefRangeStart = 544703, XrefRangeEnd = 544727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerializedGameState Method_Internal_SerializedGameState_byref___c__DisplayClass157_1_0(ref Match.__c__DisplayClass157_1 A_1)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass157_0.NativeMethodInfoPtr_Method_Internal_SerializedGameState_byref___c__DisplayClass157_1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameState>(intPtr3) : null;
				}
			}

			// Token: 0x06001945 RID: 6469 RVA: 0x0000C079 File Offset: 0x0000A279
			public __c__DisplayClass157_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700059A RID: 1434
			// (get) Token: 0x06001946 RID: 6470 RVA: 0x0007D564 File Offset: 0x0007B764
			// (set) Token: 0x06001947 RID: 6471 RVA: 0x0000C082 File Offset: 0x0000A282
			public unsafe Dictionary<PlayerEntity, List<PendingSelection>> allPendingSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass157_0.NativeFieldInfoPtr_allPendingSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PlayerEntity, List<PendingSelection>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass157_0.NativeFieldInfoPtr_allPendingSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700059B RID: 1435
			// (get) Token: 0x06001948 RID: 6472 RVA: 0x0007D594 File Offset: 0x0007B794
			// (set) Token: 0x06001949 RID: 6473 RVA: 0x0000C0A1 File Offset: 0x0000A2A1
			public unsafe Match __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass157_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass157_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400102A RID: 4138
			private static readonly IntPtr NativeFieldInfoPtr_allPendingSelections;

			// Token: 0x0400102B RID: 4139
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400102C RID: 4140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400102D RID: 4141
			private static readonly IntPtr NativeMethodInfoPtr__SaveOnPause_b__8_Internal_IEnumerable_1_String_Int32_0;

			// Token: 0x0400102E RID: 4142
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_SerializedGameState_byref___c__DisplayClass157_1_0;
		}

		// Token: 0x02000259 RID: 601
		[ObfuscatedName("Canis.Match+<>c__DisplayClass157_1")]
		public sealed class __c__DisplayClass157_1 : ValueType
		{
			// Token: 0x0600194A RID: 6474 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass157_1()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass157_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass157_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass157_1>.NativeClassPtr);
				Match.__c__DisplayClass157_1.NativeFieldInfoPtr_newState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass157_1>.NativeClassPtr, "newState");
			}

			// Token: 0x0600194B RID: 6475 RVA: 0x0000C0F4 File Offset: 0x0000A2F4
			public __c__DisplayClass157_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600194C RID: 6476 RVA: 0x0000C0FD File Offset: 0x0000A2FD
			public __c__DisplayClass157_1()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass157_1>.NativeClassPtr))
			{
			}

			// Token: 0x1700059C RID: 1436
			// (get) Token: 0x0600194D RID: 6477 RVA: 0x0007D5C4 File Offset: 0x0007B7C4
			// (set) Token: 0x0600194E RID: 6478 RVA: 0x0000C10F File Offset: 0x0000A30F
			public unsafe SerializedGameState newState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass157_1.NativeFieldInfoPtr_newState);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass157_1.NativeFieldInfoPtr_newState), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400102F RID: 4143
			private static readonly IntPtr NativeFieldInfoPtr_newState;
		}

		// Token: 0x0200025A RID: 602
		[ObfuscatedName("Canis.Match+<>c__DisplayClass157_2")]
		public sealed class __c__DisplayClass157_2 : Object
		{
			// Token: 0x0600194F RID: 6479 RVA: 0x0007D5F4 File Offset: 0x0007B7F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass157_2()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass157_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass157_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass157_2>.NativeClassPtr);
				Match.__c__DisplayClass157_2.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass157_2>.NativeClassPtr, "counter");
				Match.__c__DisplayClass157_2.NativeFieldInfoPtr___9__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass157_2>.NativeClassPtr, "<>9__10");
				Match.__c__DisplayClass157_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass157_2>.NativeClassPtr, 100663735);
				Match.__c__DisplayClass157_2.NativeMethodInfoPtr__SaveOnPause_b__9_Internal_IEnumerable_1_String_KeyValuePair_2_PlayerEntity_List_1_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass157_2>.NativeClassPtr, 100663736);
				Match.__c__DisplayClass157_2.NativeMethodInfoPtr__SaveOnPause_b__10_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass157_2>.NativeClassPtr, 100663737);
			}

			// Token: 0x06001950 RID: 6480 RVA: 0x0007D684 File Offset: 0x0007B884
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass157_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass157_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass157_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001951 RID: 6481 RVA: 0x0007D6C0 File Offset: 0x0007B8C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544730, XrefRangeEnd = 544756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<string> _SaveOnPause_b__9(KeyValuePair<PlayerEntity, List<PendingSelection>> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass157_2.NativeMethodInfoPtr__SaveOnPause_b__9_Internal_IEnumerable_1_String_KeyValuePair_2_PlayerEntity_List_1_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
				}
			}

			// Token: 0x06001952 RID: 6482 RVA: 0x0007D718 File Offset: 0x0007B918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544756, XrefRangeEnd = 544757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SaveOnPause_b__10(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass157_2.NativeMethodInfoPtr__SaveOnPause_b__10_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001953 RID: 6483 RVA: 0x0000C12E File Offset: 0x0000A32E
			public __c__DisplayClass157_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700059D RID: 1437
			// (get) Token: 0x06001954 RID: 6484 RVA: 0x0007D768 File Offset: 0x0007B968
			// (set) Token: 0x06001955 RID: 6485 RVA: 0x0000C137 File Offset: 0x0000A337
			public unsafe int counter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass157_2.NativeFieldInfoPtr_counter);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass157_2.NativeFieldInfoPtr_counter)) = value;
				}
			}

			// Token: 0x1700059E RID: 1438
			// (get) Token: 0x06001956 RID: 6486 RVA: 0x0007D790 File Offset: 0x0007B990
			// (set) Token: 0x06001957 RID: 6487 RVA: 0x0000C152 File Offset: 0x0000A352
			public unsafe Func<PendingSelection, bool> __9__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass157_2.NativeFieldInfoPtr___9__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass157_2.NativeFieldInfoPtr___9__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001030 RID: 4144
			private static readonly IntPtr NativeFieldInfoPtr_counter;

			// Token: 0x04001031 RID: 4145
			private static readonly IntPtr NativeFieldInfoPtr___9__10;

			// Token: 0x04001032 RID: 4146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001033 RID: 4147
			private static readonly IntPtr NativeMethodInfoPtr__SaveOnPause_b__9_Internal_IEnumerable_1_String_KeyValuePair_2_PlayerEntity_List_1_PendingSelection_0;

			// Token: 0x04001034 RID: 4148
			private static readonly IntPtr NativeMethodInfoPtr__SaveOnPause_b__10_Internal_Boolean_PendingSelection_0;
		}

		// Token: 0x0200025B RID: 603
		[ObfuscatedName("Canis.Match+<>c__DisplayClass157_3")]
		public sealed class __c__DisplayClass157_3 : Object
		{
			// Token: 0x06001958 RID: 6488 RVA: 0x0007D7C0 File Offset: 0x0007B9C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass157_3()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass157_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass157_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass157_3>.NativeClassPtr);
				Match.__c__DisplayClass157_3.NativeFieldInfoPtr_pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass157_3>.NativeClassPtr, "pair");
				Match.__c__DisplayClass157_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass157_3>.NativeClassPtr, 100663738);
				Match.__c__DisplayClass157_3.NativeMethodInfoPtr__SaveOnPause_b__11_Internal_String_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass157_3>.NativeClassPtr, 100663739);
			}

			// Token: 0x06001959 RID: 6489 RVA: 0x0007D828 File Offset: 0x0007BA28
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass157_3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass157_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass157_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600195A RID: 6490 RVA: 0x0007D864 File Offset: 0x0007BA64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544757, XrefRangeEnd = 544761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _SaveOnPause_b__11(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass157_3.NativeMethodInfoPtr__SaveOnPause_b__11_Internal_String_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600195B RID: 6491 RVA: 0x0000C171 File Offset: 0x0000A371
			public __c__DisplayClass157_3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700059F RID: 1439
			// (get) Token: 0x0600195C RID: 6492 RVA: 0x0007D8AC File Offset: 0x0007BAAC
			// (set) Token: 0x0600195D RID: 6493 RVA: 0x0000C17A File Offset: 0x0000A37A
			public KeyValuePair<PlayerEntity, List<PendingSelection>> pair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass157_3.NativeFieldInfoPtr_pair);
					return new KeyValuePair<PlayerEntity, List<PendingSelection>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<PlayerEntity, List<PendingSelection>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass157_3.NativeFieldInfoPtr_pair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<PlayerEntity, List<PendingSelection>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04001035 RID: 4149
			private static readonly IntPtr NativeFieldInfoPtr_pair;

			// Token: 0x04001036 RID: 4150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001037 RID: 4151
			private static readonly IntPtr NativeMethodInfoPtr__SaveOnPause_b__11_Internal_String_PendingSelection_0;
		}

		// Token: 0x0200025C RID: 604
		[ObfuscatedName("Canis.Match+<>c__DisplayClass165_0")]
		public sealed class __c__DisplayClass165_0 : Object
		{
			// Token: 0x0600195E RID: 6494 RVA: 0x0007D8DC File Offset: 0x0007BADC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass165_0()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass165_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass165_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass165_0>.NativeClassPtr);
				Match.__c__DisplayClass165_0.NativeFieldInfoPtr_currentSelectionPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass165_0>.NativeClassPtr, "currentSelectionPlayer");
				Match.__c__DisplayClass165_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass165_0>.NativeClassPtr, 100663740);
				Match.__c__DisplayClass165_0.NativeMethodInfoPtr__SetNonPromptText_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass165_0>.NativeClassPtr, 100663741);
			}

			// Token: 0x0600195F RID: 6495 RVA: 0x0007D944 File Offset: 0x0007BB44
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass165_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass165_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass165_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001960 RID: 6496 RVA: 0x0007D980 File Offset: 0x0007BB80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544761, XrefRangeEnd = 544768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetNonPromptText_b__0(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass165_0.NativeMethodInfoPtr__SetNonPromptText_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001961 RID: 6497 RVA: 0x0000C1A8 File Offset: 0x0000A3A8
			public __c__DisplayClass165_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A0 RID: 1440
			// (get) Token: 0x06001962 RID: 6498 RVA: 0x0007D9D0 File Offset: 0x0007BBD0
			// (set) Token: 0x06001963 RID: 6499 RVA: 0x0000C1B1 File Offset: 0x0000A3B1
			public unsafe AccountID currentSelectionPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass165_0.NativeFieldInfoPtr_currentSelectionPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass165_0.NativeFieldInfoPtr_currentSelectionPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001038 RID: 4152
			private static readonly IntPtr NativeFieldInfoPtr_currentSelectionPlayer;

			// Token: 0x04001039 RID: 4153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400103A RID: 4154
			private static readonly IntPtr NativeMethodInfoPtr__SetNonPromptText_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x0200025D RID: 605
		[ObfuscatedName("Canis.Match+<>c__DisplayClass202_0")]
		public sealed class __c__DisplayClass202_0 : Object
		{
			// Token: 0x06001964 RID: 6500 RVA: 0x0007DA00 File Offset: 0x0007BC00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass202_0()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass202_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass202_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass202_0>.NativeClassPtr);
				Match.__c__DisplayClass202_0.NativeFieldInfoPtr_resigningPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass202_0>.NativeClassPtr, "resigningPlayerID");
				Match.__c__DisplayClass202_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass202_0>.NativeClassPtr, 100663742);
				Match.__c__DisplayClass202_0.NativeMethodInfoPtr__SetPlayerDataForResignFromGame_b__0_Internal_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass202_0>.NativeClassPtr, 100663743);
				Match.__c__DisplayClass202_0.NativeMethodInfoPtr__SetPlayerDataForResignFromGame_b__1_Internal_Boolean_PlayerInfoSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass202_0>.NativeClassPtr, 100663744);
			}

			// Token: 0x06001965 RID: 6501 RVA: 0x0007DA7C File Offset: 0x0007BC7C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass202_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass202_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass202_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001966 RID: 6502 RVA: 0x0007DAB8 File Offset: 0x0007BCB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544768, XrefRangeEnd = 544772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetPlayerDataForResignFromGame_b__0(AccountID aID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aID);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass202_0.NativeMethodInfoPtr__SetPlayerDataForResignFromGame_b__0_Internal_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001967 RID: 6503 RVA: 0x0007DB08 File Offset: 0x0007BD08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544772, XrefRangeEnd = 544777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SetPlayerDataForResignFromGame_b__1(PlayerInfoSaveData p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass202_0.NativeMethodInfoPtr__SetPlayerDataForResignFromGame_b__1_Internal_Boolean_PlayerInfoSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001968 RID: 6504 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
			public __c__DisplayClass202_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A1 RID: 1441
			// (get) Token: 0x06001969 RID: 6505 RVA: 0x0007DB58 File Offset: 0x0007BD58
			// (set) Token: 0x0600196A RID: 6506 RVA: 0x0000C1D9 File Offset: 0x0000A3D9
			public unsafe AccountID resigningPlayerID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass202_0.NativeFieldInfoPtr_resigningPlayerID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass202_0.NativeFieldInfoPtr_resigningPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400103B RID: 4155
			private static readonly IntPtr NativeFieldInfoPtr_resigningPlayerID;

			// Token: 0x0400103C RID: 4156
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400103D RID: 4157
			private static readonly IntPtr NativeMethodInfoPtr__SetPlayerDataForResignFromGame_b__0_Internal_Boolean_AccountID_0;

			// Token: 0x0400103E RID: 4158
			private static readonly IntPtr NativeMethodInfoPtr__SetPlayerDataForResignFromGame_b__1_Internal_Boolean_PlayerInfoSaveData_0;
		}

		// Token: 0x0200025E RID: 606
		[ObfuscatedName("Canis.Match+<>c__DisplayClass204_0")]
		public sealed class __c__DisplayClass204_0 : Object
		{
			// Token: 0x0600196B RID: 6507 RVA: 0x0007DB88 File Offset: 0x0007BD88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass204_0()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass204_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass204_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass204_0>.NativeClassPtr);
				Match.__c__DisplayClass204_0.NativeFieldInfoPtr_resigningPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass204_0>.NativeClassPtr, "resigningPlayerID");
				Match.__c__DisplayClass204_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass204_0>.NativeClassPtr, 100663745);
				Match.__c__DisplayClass204_0.NativeMethodInfoPtr__HandleResignGameAsync_b__0_Internal_Boolean_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass204_0>.NativeClassPtr, 100663746);
			}

			// Token: 0x0600196C RID: 6508 RVA: 0x0007DBF0 File Offset: 0x0007BDF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass204_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass204_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass204_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600196D RID: 6509 RVA: 0x0007DC2C File Offset: 0x0007BE2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544777, XrefRangeEnd = 544781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HandleResignGameAsync_b__0(AccountID aID)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aID);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass204_0.NativeMethodInfoPtr__HandleResignGameAsync_b__0_Internal_Boolean_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600196E RID: 6510 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
			public __c__DisplayClass204_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A2 RID: 1442
			// (get) Token: 0x0600196F RID: 6511 RVA: 0x0007DC7C File Offset: 0x0007BE7C
			// (set) Token: 0x06001970 RID: 6512 RVA: 0x0000C201 File Offset: 0x0000A401
			public unsafe AccountID resigningPlayerID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass204_0.NativeFieldInfoPtr_resigningPlayerID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass204_0.NativeFieldInfoPtr_resigningPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400103F RID: 4159
			private static readonly IntPtr NativeFieldInfoPtr_resigningPlayerID;

			// Token: 0x04001040 RID: 4160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001041 RID: 4161
			private static readonly IntPtr NativeMethodInfoPtr__HandleResignGameAsync_b__0_Internal_Boolean_AccountID_0;
		}

		// Token: 0x0200025F RID: 607
		[ObfuscatedName("Canis.Match+<>c__DisplayClass214_0")]
		public sealed class __c__DisplayClass214_0 : Object
		{
			// Token: 0x06001971 RID: 6513 RVA: 0x0007DCAC File Offset: 0x0007BEAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass214_0()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass214_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass214_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass214_0>.NativeClassPtr);
				Match.__c__DisplayClass214_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass214_0>.NativeClassPtr, "accountID");
				Match.__c__DisplayClass214_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass214_0>.NativeClassPtr, 100663747);
				Match.__c__DisplayClass214_0.NativeMethodInfoPtr__HandleIdleTurn_b__0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass214_0>.NativeClassPtr, 100663748);
			}

			// Token: 0x06001972 RID: 6514 RVA: 0x0007DD14 File Offset: 0x0007BF14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass214_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass214_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass214_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001973 RID: 6515 RVA: 0x0007DD50 File Offset: 0x0007BF50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544781, XrefRangeEnd = 544786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HandleIdleTurn_b__0(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass214_0.NativeMethodInfoPtr__HandleIdleTurn_b__0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001974 RID: 6516 RVA: 0x0000C220 File Offset: 0x0000A420
			public __c__DisplayClass214_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A3 RID: 1443
			// (get) Token: 0x06001975 RID: 6517 RVA: 0x0007DDA0 File Offset: 0x0007BFA0
			// (set) Token: 0x06001976 RID: 6518 RVA: 0x0000C229 File Offset: 0x0000A429
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass214_0.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass214_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001042 RID: 4162
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x04001043 RID: 4163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001044 RID: 4164
			private static readonly IntPtr NativeMethodInfoPtr__HandleIdleTurn_b__0_Internal_Boolean_PlayerEntity_0;
		}

		// Token: 0x02000260 RID: 608
		[ObfuscatedName("Canis.Match+<>c__DisplayClass220_0")]
		public sealed class __c__DisplayClass220_0 : Object
		{
			// Token: 0x06001977 RID: 6519 RVA: 0x0007DDD0 File Offset: 0x0007BFD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass220_0()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass220_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass220_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass220_0>.NativeClassPtr);
				Match.__c__DisplayClass220_0.NativeFieldInfoPtr_accountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass220_0>.NativeClassPtr, "accountID");
				Match.__c__DisplayClass220_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass220_0>.NativeClassPtr, 100663749);
				Match.__c__DisplayClass220_0.NativeMethodInfoPtr__ActiveSelectionsOfPlayer_b__0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass220_0>.NativeClassPtr, 100663750);
			}

			// Token: 0x06001978 RID: 6520 RVA: 0x0007DE38 File Offset: 0x0007C038
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass220_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass220_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass220_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001979 RID: 6521 RVA: 0x0007DE74 File Offset: 0x0007C074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544786, XrefRangeEnd = 544791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ActiveSelectionsOfPlayer_b__0(PlayerEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass220_0.NativeMethodInfoPtr__ActiveSelectionsOfPlayer_b__0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600197A RID: 6522 RVA: 0x0000C248 File Offset: 0x0000A448
			public __c__DisplayClass220_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A4 RID: 1444
			// (get) Token: 0x0600197B RID: 6523 RVA: 0x0007DEC4 File Offset: 0x0007C0C4
			// (set) Token: 0x0600197C RID: 6524 RVA: 0x0000C251 File Offset: 0x0000A451
			public unsafe AccountID accountID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass220_0.NativeFieldInfoPtr_accountID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass220_0.NativeFieldInfoPtr_accountID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001045 RID: 4165
			private static readonly IntPtr NativeFieldInfoPtr_accountID;

			// Token: 0x04001046 RID: 4166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001047 RID: 4167
			private static readonly IntPtr NativeMethodInfoPtr__ActiveSelectionsOfPlayer_b__0_Internal_Boolean_PlayerEntity_0;
		}

		// Token: 0x02000261 RID: 609
		[ObfuscatedName("Canis.Match+<>c__DisplayClass221_0")]
		public sealed class __c__DisplayClass221_0 : Object
		{
			// Token: 0x0600197D RID: 6525 RVA: 0x0007DEF4 File Offset: 0x0007C0F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass221_0()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass221_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass221_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass221_0>.NativeClassPtr);
				Match.__c__DisplayClass221_0.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass221_0>.NativeClassPtr, "evt");
				Match.__c__DisplayClass221_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass221_0>.NativeClassPtr, "<>9__4");
				Match.__c__DisplayClass221_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass221_0>.NativeClassPtr, 100663751);
				Match.__c__DisplayClass221_0.NativeMethodInfoPtr__PlayerIDForSelection_b__0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass221_0>.NativeClassPtr, 100663752);
				Match.__c__DisplayClass221_0.NativeMethodInfoPtr__PlayerIDForSelection_b__4_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass221_0>.NativeClassPtr, 100663753);
				Match.__c__DisplayClass221_0.NativeMethodInfoPtr__PlayerIDForSelection_b__2_Internal_Boolean_KeyValuePair_2_AccountID_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass221_0>.NativeClassPtr, 100663754);
			}

			// Token: 0x0600197E RID: 6526 RVA: 0x0007DF98 File Offset: 0x0007C198
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass221_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass221_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass221_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600197F RID: 6527 RVA: 0x0007DFD4 File Offset: 0x0007C1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544791, XrefRangeEnd = 544802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayerIDForSelection_b__0(PlayerEntity p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass221_0.NativeMethodInfoPtr__PlayerIDForSelection_b__0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001980 RID: 6528 RVA: 0x0007E024 File Offset: 0x0007C224
			[CallerCount(0)]
			public unsafe bool _PlayerIDForSelection_b__4(PendingSelection _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass221_0.NativeMethodInfoPtr__PlayerIDForSelection_b__4_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001981 RID: 6529 RVA: 0x0007E074 File Offset: 0x0007C274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544802, XrefRangeEnd = 544803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayerIDForSelection_b__2(KeyValuePair<AccountID, SelectionMessage> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass221_0.NativeMethodInfoPtr__PlayerIDForSelection_b__2_Internal_Boolean_KeyValuePair_2_AccountID_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001982 RID: 6530 RVA: 0x0000C270 File Offset: 0x0000A470
			public __c__DisplayClass221_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A5 RID: 1445
			// (get) Token: 0x06001983 RID: 6531 RVA: 0x0007E0C8 File Offset: 0x0007C2C8
			// (set) Token: 0x06001984 RID: 6532 RVA: 0x0000C279 File Offset: 0x0000A479
			public unsafe SelectionMessage evt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass221_0.NativeFieldInfoPtr_evt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass221_0.NativeFieldInfoPtr_evt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005A6 RID: 1446
			// (get) Token: 0x06001985 RID: 6533 RVA: 0x0007E0F8 File Offset: 0x0007C2F8
			// (set) Token: 0x06001986 RID: 6534 RVA: 0x0000C298 File Offset: 0x0000A498
			public unsafe Func<PendingSelection, bool> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass221_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass221_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001048 RID: 4168
			private static readonly IntPtr NativeFieldInfoPtr_evt;

			// Token: 0x04001049 RID: 4169
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x0400104A RID: 4170
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400104B RID: 4171
			private static readonly IntPtr NativeMethodInfoPtr__PlayerIDForSelection_b__0_Internal_Boolean_PlayerEntity_0;

			// Token: 0x0400104C RID: 4172
			private static readonly IntPtr NativeMethodInfoPtr__PlayerIDForSelection_b__4_Internal_Boolean_PendingSelection_0;

			// Token: 0x0400104D RID: 4173
			private static readonly IntPtr NativeMethodInfoPtr__PlayerIDForSelection_b__2_Internal_Boolean_KeyValuePair_2_AccountID_SelectionMessage_0;
		}

		// Token: 0x02000262 RID: 610
		[ObfuscatedName("Canis.Match+<>c__DisplayClass245_0")]
		public sealed class __c__DisplayClass245_0 : Object
		{
			// Token: 0x06001987 RID: 6535 RVA: 0x0007E128 File Offset: 0x0007C328
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass245_0()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass245_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass245_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass245_0>.NativeClassPtr);
				Match.__c__DisplayClass245_0.NativeFieldInfoPtr_timerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass245_0>.NativeClassPtr, "timerID");
				Match.__c__DisplayClass245_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass245_0>.NativeClassPtr, 100663755);
				Match.__c__DisplayClass245_0.NativeMethodInfoPtr__UntrackTimer_b__0_Internal_Boolean_TimerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass245_0>.NativeClassPtr, 100663756);
			}

			// Token: 0x06001988 RID: 6536 RVA: 0x0007E190 File Offset: 0x0007C390
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass245_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass245_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass245_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001989 RID: 6537 RVA: 0x0007E1CC File Offset: 0x0007C3CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544803, XrefRangeEnd = 544808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UntrackTimer_b__0(TimerInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass245_0.NativeMethodInfoPtr__UntrackTimer_b__0_Internal_Boolean_TimerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600198A RID: 6538 RVA: 0x0000C2B7 File Offset: 0x0000A4B7
			public __c__DisplayClass245_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A7 RID: 1447
			// (get) Token: 0x0600198B RID: 6539 RVA: 0x0007E21C File Offset: 0x0007C41C
			// (set) Token: 0x0600198C RID: 6540 RVA: 0x0000C2C0 File Offset: 0x0000A4C0
			public unsafe TimerID timerID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass245_0.NativeFieldInfoPtr_timerID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass245_0.NativeFieldInfoPtr_timerID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400104E RID: 4174
			private static readonly IntPtr NativeFieldInfoPtr_timerID;

			// Token: 0x0400104F RID: 4175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001050 RID: 4176
			private static readonly IntPtr NativeMethodInfoPtr__UntrackTimer_b__0_Internal_Boolean_TimerInfo_0;
		}

		// Token: 0x02000263 RID: 611
		[ObfuscatedName("Canis.Match+<>c__DisplayClass247_0")]
		public sealed class __c__DisplayClass247_0 : Object
		{
			// Token: 0x0600198D RID: 6541 RVA: 0x0007E24C File Offset: 0x0007C44C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass247_0()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass247_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass247_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass247_0>.NativeClassPtr);
				Match.__c__DisplayClass247_0.NativeFieldInfoPtr_timerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass247_0>.NativeClassPtr, "timerID");
				Match.__c__DisplayClass247_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass247_0>.NativeClassPtr, 100663757);
				Match.__c__DisplayClass247_0.NativeMethodInfoPtr__TimerIsActive_b__0_Internal_Boolean_TimerInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass247_0>.NativeClassPtr, 100663758);
			}

			// Token: 0x0600198E RID: 6542 RVA: 0x0007E2B4 File Offset: 0x0007C4B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass247_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass247_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass247_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600198F RID: 6543 RVA: 0x0007E2F0 File Offset: 0x0007C4F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544808, XrefRangeEnd = 544813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TimerIsActive_b__0(TimerInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass247_0.NativeMethodInfoPtr__TimerIsActive_b__0_Internal_Boolean_TimerInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001990 RID: 6544 RVA: 0x0000C2DF File Offset: 0x0000A4DF
			public __c__DisplayClass247_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A8 RID: 1448
			// (get) Token: 0x06001991 RID: 6545 RVA: 0x0007E340 File Offset: 0x0007C540
			// (set) Token: 0x06001992 RID: 6546 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
			public unsafe TimerID timerID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass247_0.NativeFieldInfoPtr_timerID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass247_0.NativeFieldInfoPtr_timerID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001051 RID: 4177
			private static readonly IntPtr NativeFieldInfoPtr_timerID;

			// Token: 0x04001052 RID: 4178
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001053 RID: 4179
			private static readonly IntPtr NativeMethodInfoPtr__TimerIsActive_b__0_Internal_Boolean_TimerInfo_0;
		}

		// Token: 0x02000264 RID: 612
		[ObfuscatedName("Canis.Match+<>c__DisplayClass78_0")]
		public sealed class __c__DisplayClass78_0 : Object
		{
			// Token: 0x06001993 RID: 6547 RVA: 0x0007E370 File Offset: 0x0007C570
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass78_0()
			{
				Il2CppClassPointerStore<Match.__c__DisplayClass78_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<>c__DisplayClass78_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match.__c__DisplayClass78_0>.NativeClassPtr);
				Match.__c__DisplayClass78_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match.__c__DisplayClass78_0>.NativeClassPtr, "id");
				Match.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass78_0>.NativeClassPtr, 100663759);
				Match.__c__DisplayClass78_0.NativeMethodInfoPtr__Configure_b__1_Internal_Boolean_SkirmishRulesModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match.__c__DisplayClass78_0>.NativeClassPtr, 100663760);
			}

			// Token: 0x06001994 RID: 6548 RVA: 0x0007E3D8 File Offset: 0x0007C5D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass78_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match.__c__DisplayClass78_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass78_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001995 RID: 6549 RVA: 0x0007E414 File Offset: 0x0007C614
			[CallerCount(0)]
			public unsafe bool _Configure_b__1(SkirmishRulesModifier _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match.__c__DisplayClass78_0.NativeMethodInfoPtr__Configure_b__1_Internal_Boolean_SkirmishRulesModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001996 RID: 6550 RVA: 0x0000C307 File Offset: 0x0000A507
			public __c__DisplayClass78_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005A9 RID: 1449
			// (get) Token: 0x06001997 RID: 6551 RVA: 0x0007E464 File Offset: 0x0007C664
			// (set) Token: 0x06001998 RID: 6552 RVA: 0x0000C310 File Offset: 0x0000A510
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass78_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match.__c__DisplayClass78_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x04001054 RID: 4180
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04001055 RID: 4181
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001056 RID: 4182
			private static readonly IntPtr NativeMethodInfoPtr__Configure_b__1_Internal_Boolean_SkirmishRulesModifier_0;
		}

		// Token: 0x02000265 RID: 613
		[ObfuscatedName("Canis.Match+<ClaimOwnedEntitiesForPending>d__145")]
		public sealed class _ClaimOwnedEntitiesForPending_d__145 : Object
		{
			// Token: 0x06001999 RID: 6553 RVA: 0x0007E48C File Offset: 0x0007C68C
			// Note: this type is marked as 'beforefieldinit'.
			static _ClaimOwnedEntitiesForPending_d__145()
			{
				Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<ClaimOwnedEntitiesForPending>d__145");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr);
				Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, "<>1__state");
				Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, "<>2__current");
				Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, "<>l__initialThreadId");
				Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, "<>4__this");
				Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, "owner");
				Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___3__owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, "<>3__owner");
				Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, "<>7__wrap1");
				Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, 100663761);
				Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, 100663762);
				Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, 100663763);
				Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, 100663764);
				Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, 100663765);
				Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, 100663766);
				Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, 100663767);
				Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, 100663768);
				Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr, 100663769);
			}

			// Token: 0x0600199A RID: 6554 RVA: 0x0007E5F8 File Offset: 0x0007C7F8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClaimOwnedEntitiesForPending_d__145(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._ClaimOwnedEntitiesForPending_d__145>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600199B RID: 6555 RVA: 0x0007E640 File Offset: 0x0007C840
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544813, XrefRangeEnd = 544818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600199C RID: 6556 RVA: 0x0007E674 File Offset: 0x0007C874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544818, XrefRangeEnd = 544852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600199D RID: 6557 RVA: 0x0007E6B0 File Offset: 0x0007C8B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544852, XrefRangeEnd = 544855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005B1 RID: 1457
			// (get) Token: 0x0600199E RID: 6558 RVA: 0x0007E6E4 File Offset: 0x0007C8E4
			public unsafe Entity System.Collections.Generic.IEnumerator<Canis.entities.Entity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x0600199F RID: 6559 RVA: 0x0007E724 File Offset: 0x0007C924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544855, XrefRangeEnd = 544860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005B2 RID: 1458
			// (get) Token: 0x060019A0 RID: 6560 RVA: 0x0007E758 File Offset: 0x0007C958
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019A1 RID: 6561 RVA: 0x0007E798 File Offset: 0x0007C998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544860, XrefRangeEnd = 544869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Entity> System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr3) : null;
			}

			// Token: 0x060019A2 RID: 6562 RVA: 0x0007E7D8 File Offset: 0x0007C9D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClaimOwnedEntitiesForPending_d__145.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060019A3 RID: 6563 RVA: 0x0000C32B File Offset: 0x0000A52B
			public _ClaimOwnedEntitiesForPending_d__145(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005AA RID: 1450
			// (get) Token: 0x060019A4 RID: 6564 RVA: 0x0007E818 File Offset: 0x0007CA18
			// (set) Token: 0x060019A5 RID: 6565 RVA: 0x0000C334 File Offset: 0x0000A534
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005AB RID: 1451
			// (get) Token: 0x060019A6 RID: 6566 RVA: 0x0007E840 File Offset: 0x0007CA40
			// (set) Token: 0x060019A7 RID: 6567 RVA: 0x0000C34F File Offset: 0x0000A54F
			public unsafe Entity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AC RID: 1452
			// (get) Token: 0x060019A8 RID: 6568 RVA: 0x0007E870 File Offset: 0x0007CA70
			// (set) Token: 0x060019A9 RID: 6569 RVA: 0x0000C36E File Offset: 0x0000A56E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005AD RID: 1453
			// (get) Token: 0x060019AA RID: 6570 RVA: 0x0007E898 File Offset: 0x0007CA98
			// (set) Token: 0x060019AB RID: 6571 RVA: 0x0000C389 File Offset: 0x0000A589
			public unsafe Match __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AE RID: 1454
			// (get) Token: 0x060019AC RID: 6572 RVA: 0x0007E8C8 File Offset: 0x0007CAC8
			// (set) Token: 0x060019AD RID: 6573 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
			public unsafe AccountID owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr_owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr_owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005AF RID: 1455
			// (get) Token: 0x060019AE RID: 6574 RVA: 0x0007E8F8 File Offset: 0x0007CAF8
			// (set) Token: 0x060019AF RID: 6575 RVA: 0x0000C3C7 File Offset: 0x0000A5C7
			public unsafe AccountID __3__owner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___3__owner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___3__owner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B0 RID: 1456
			// (get) Token: 0x060019B0 RID: 6576 RVA: 0x0007E928 File Offset: 0x0007CB28
			// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0000C3E6 File Offset: 0x0000A5E6
			public unsafe IEnumerator<Entity> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClaimOwnedEntitiesForPending_d__145.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001057 RID: 4183
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001058 RID: 4184
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001059 RID: 4185
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400105A RID: 4186
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400105B RID: 4187
			private static readonly IntPtr NativeFieldInfoPtr_owner;

			// Token: 0x0400105C RID: 4188
			private static readonly IntPtr NativeFieldInfoPtr___3__owner;

			// Token: 0x0400105D RID: 4189
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400105E RID: 4190
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400105F RID: 4191
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001060 RID: 4192
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001061 RID: 4193
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001062 RID: 4194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0;

			// Token: 0x04001063 RID: 4195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001064 RID: 4196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001065 RID: 4197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0;

			// Token: 0x04001066 RID: 4198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000266 RID: 614
		[ObfuscatedName("Canis.Match+<ClearDisplayActionsOnSave>d__158")]
		public sealed class _ClearDisplayActionsOnSave_d__158 : Object
		{
			// Token: 0x060019B2 RID: 6578 RVA: 0x0007E958 File Offset: 0x0007CB58
			// Note: this type is marked as 'beforefieldinit'.
			static _ClearDisplayActionsOnSave_d__158()
			{
				Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<ClearDisplayActionsOnSave>d__158");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr);
				Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, "<>1__state");
				Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, "<>2__current");
				Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, "<>l__initialThreadId");
				Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, "<>4__this");
				Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr_lastRespondingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, "lastRespondingPlayer");
				Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___3__lastRespondingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, "<>3__lastRespondingPlayer");
				Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr_allPendingSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, "allPendingSelections");
				Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___3__allPendingSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, "<>3__allPendingSelections");
				Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, 100663770);
				Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, 100663771);
				Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, 100663772);
				Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, 100663773);
				Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, 100663774);
				Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, 100663775);
				Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, 100663776);
				Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr, 100663777);
			}

			// Token: 0x060019B3 RID: 6579 RVA: 0x0007EAC4 File Offset: 0x0007CCC4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClearDisplayActionsOnSave_d__158(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._ClearDisplayActionsOnSave_d__158>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019B4 RID: 6580 RVA: 0x0007EB0C File Offset: 0x0007CD0C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019B5 RID: 6581 RVA: 0x0007EB40 File Offset: 0x0007CD40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544869, XrefRangeEnd = 544878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005BB RID: 1467
			// (get) Token: 0x060019B6 RID: 6582 RVA: 0x0007EB7C File Offset: 0x0007CD7C
			public unsafe PlayerEntity System.Collections.Generic.IEnumerator<Canis.entities.PlayerEntity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
				}
			}

			// Token: 0x060019B7 RID: 6583 RVA: 0x0007EBBC File Offset: 0x0007CDBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544878, XrefRangeEnd = 544883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005BC RID: 1468
			// (get) Token: 0x060019B8 RID: 6584 RVA: 0x0007EBF0 File Offset: 0x0007CDF0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019B9 RID: 6585 RVA: 0x0007EC30 File Offset: 0x0007CE30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544883, XrefRangeEnd = 544893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<PlayerEntity> System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<PlayerEntity>>(intPtr3) : null;
			}

			// Token: 0x060019BA RID: 6586 RVA: 0x0007EC70 File Offset: 0x0007CE70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearDisplayActionsOnSave_d__158.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060019BB RID: 6587 RVA: 0x0000C405 File Offset: 0x0000A605
			public _ClearDisplayActionsOnSave_d__158(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005B3 RID: 1459
			// (get) Token: 0x060019BC RID: 6588 RVA: 0x0007ECB0 File Offset: 0x0007CEB0
			// (set) Token: 0x060019BD RID: 6589 RVA: 0x0000C40E File Offset: 0x0000A60E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005B4 RID: 1460
			// (get) Token: 0x060019BE RID: 6590 RVA: 0x0007ECD8 File Offset: 0x0007CED8
			// (set) Token: 0x060019BF RID: 6591 RVA: 0x0000C429 File Offset: 0x0000A629
			public unsafe PlayerEntity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B5 RID: 1461
			// (get) Token: 0x060019C0 RID: 6592 RVA: 0x0007ED08 File Offset: 0x0007CF08
			// (set) Token: 0x060019C1 RID: 6593 RVA: 0x0000C448 File Offset: 0x0000A648
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005B6 RID: 1462
			// (get) Token: 0x060019C2 RID: 6594 RVA: 0x0007ED30 File Offset: 0x0007CF30
			// (set) Token: 0x060019C3 RID: 6595 RVA: 0x0000C463 File Offset: 0x0000A663
			public unsafe Match __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B7 RID: 1463
			// (get) Token: 0x060019C4 RID: 6596 RVA: 0x0007ED60 File Offset: 0x0007CF60
			// (set) Token: 0x060019C5 RID: 6597 RVA: 0x0000C482 File Offset: 0x0000A682
			public unsafe PlayerEntity lastRespondingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr_lastRespondingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr_lastRespondingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B8 RID: 1464
			// (get) Token: 0x060019C6 RID: 6598 RVA: 0x0007ED90 File Offset: 0x0007CF90
			// (set) Token: 0x060019C7 RID: 6599 RVA: 0x0000C4A1 File Offset: 0x0000A6A1
			public unsafe PlayerEntity __3__lastRespondingPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___3__lastRespondingPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___3__lastRespondingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005B9 RID: 1465
			// (get) Token: 0x060019C8 RID: 6600 RVA: 0x0007EDC0 File Offset: 0x0007CFC0
			// (set) Token: 0x060019C9 RID: 6601 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
			public unsafe Dictionary<PlayerEntity, List<PendingSelection>> allPendingSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr_allPendingSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PlayerEntity, List<PendingSelection>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr_allPendingSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005BA RID: 1466
			// (get) Token: 0x060019CA RID: 6602 RVA: 0x0007EDF0 File Offset: 0x0007CFF0
			// (set) Token: 0x060019CB RID: 6603 RVA: 0x0000C4DF File Offset: 0x0000A6DF
			public unsafe Dictionary<PlayerEntity, List<PendingSelection>> __3__allPendingSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___3__allPendingSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PlayerEntity, List<PendingSelection>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearDisplayActionsOnSave_d__158.NativeFieldInfoPtr___3__allPendingSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001067 RID: 4199
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001068 RID: 4200
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001069 RID: 4201
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400106A RID: 4202
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400106B RID: 4203
			private static readonly IntPtr NativeFieldInfoPtr_lastRespondingPlayer;

			// Token: 0x0400106C RID: 4204
			private static readonly IntPtr NativeFieldInfoPtr___3__lastRespondingPlayer;

			// Token: 0x0400106D RID: 4205
			private static readonly IntPtr NativeFieldInfoPtr_allPendingSelections;

			// Token: 0x0400106E RID: 4206
			private static readonly IntPtr NativeFieldInfoPtr___3__allPendingSelections;

			// Token: 0x0400106F RID: 4207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001070 RID: 4208
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001071 RID: 4209
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001072 RID: 4210
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_PlayerEntity__get_Current_Private_Virtual_Final_New_get_PlayerEntity_0;

			// Token: 0x04001073 RID: 4211
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001074 RID: 4212
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001075 RID: 4213
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_PlayerEntity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_PlayerEntity_0;

			// Token: 0x04001076 RID: 4214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000267 RID: 615
		[ObfuscatedName("Canis.Match+<ClearNonPromptText>d__166")]
		public sealed class _ClearNonPromptText_d__166 : Object
		{
			// Token: 0x060019CC RID: 6604 RVA: 0x0007EE20 File Offset: 0x0007D020
			// Note: this type is marked as 'beforefieldinit'.
			static _ClearNonPromptText_d__166()
			{
				Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<ClearNonPromptText>d__166");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr);
				Match._ClearNonPromptText_d__166.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr, "<>1__state");
				Match._ClearNonPromptText_d__166.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr, "<>2__current");
				Match._ClearNonPromptText_d__166.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr, "<>l__initialThreadId");
				Match._ClearNonPromptText_d__166.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr, "<>4__this");
				Match._ClearNonPromptText_d__166.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr, 100663778);
				Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr, 100663779);
				Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr, 100663780);
				Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr, 100663781);
				Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr, 100663782);
				Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr, 100663783);
				Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr, 100663784);
				Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr, 100663785);
			}

			// Token: 0x060019CD RID: 6605 RVA: 0x0007EF3C File Offset: 0x0007D13C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ClearNonPromptText_d__166(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._ClearNonPromptText_d__166>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearNonPromptText_d__166.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019CE RID: 6606 RVA: 0x0007EF84 File Offset: 0x0007D184
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019CF RID: 6607 RVA: 0x0007EFB8 File Offset: 0x0007D1B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544893, XrefRangeEnd = 544932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005C1 RID: 1473
			// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0007EFF4 File Offset: 0x0007D1F4
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060019D1 RID: 6609 RVA: 0x0007F034 File Offset: 0x0007D234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544932, XrefRangeEnd = 544937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005C2 RID: 1474
			// (get) Token: 0x060019D2 RID: 6610 RVA: 0x0007F068 File Offset: 0x0007D268
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019D3 RID: 6611 RVA: 0x0007F0A8 File Offset: 0x0007D2A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544937, XrefRangeEnd = 544939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060019D4 RID: 6612 RVA: 0x0007F0E8 File Offset: 0x0007D2E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._ClearNonPromptText_d__166.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060019D5 RID: 6613 RVA: 0x0000C4FE File Offset: 0x0000A6FE
			public _ClearNonPromptText_d__166(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005BD RID: 1469
			// (get) Token: 0x060019D6 RID: 6614 RVA: 0x0007F128 File Offset: 0x0007D328
			// (set) Token: 0x060019D7 RID: 6615 RVA: 0x0000C507 File Offset: 0x0000A707
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearNonPromptText_d__166.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearNonPromptText_d__166.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005BE RID: 1470
			// (get) Token: 0x060019D8 RID: 6616 RVA: 0x0007F150 File Offset: 0x0007D350
			// (set) Token: 0x060019D9 RID: 6617 RVA: 0x0000C522 File Offset: 0x0000A722
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearNonPromptText_d__166.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearNonPromptText_d__166.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005BF RID: 1471
			// (get) Token: 0x060019DA RID: 6618 RVA: 0x0007F180 File Offset: 0x0007D380
			// (set) Token: 0x060019DB RID: 6619 RVA: 0x0000C541 File Offset: 0x0000A741
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearNonPromptText_d__166.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearNonPromptText_d__166.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005C0 RID: 1472
			// (get) Token: 0x060019DC RID: 6620 RVA: 0x0007F1A8 File Offset: 0x0007D3A8
			// (set) Token: 0x060019DD RID: 6621 RVA: 0x0000C55C File Offset: 0x0000A75C
			public unsafe Match __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearNonPromptText_d__166.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._ClearNonPromptText_d__166.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001077 RID: 4215
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001078 RID: 4216
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001079 RID: 4217
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400107A RID: 4218
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400107B RID: 4219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400107C RID: 4220
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400107D RID: 4221
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400107E RID: 4222
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400107F RID: 4223
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001080 RID: 4224
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001081 RID: 4225
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001082 RID: 4226
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000268 RID: 616
		[ObfuscatedName("Canis.Match+<GetEntityOption>d__138")]
		public sealed class _GetEntityOption_d__138 : Object
		{
			// Token: 0x060019DE RID: 6622 RVA: 0x0007F1D8 File Offset: 0x0007D3D8
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEntityOption_d__138()
			{
				Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<GetEntityOption>d__138");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr);
				Match._GetEntityOption_d__138.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, "<>1__state");
				Match._GetEntityOption_d__138.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, "<>2__current");
				Match._GetEntityOption_d__138.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, "<>l__initialThreadId");
				Match._GetEntityOption_d__138.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, "<>4__this");
				Match._GetEntityOption_d__138.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, "id");
				Match._GetEntityOption_d__138.NativeFieldInfoPtr___3__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, "<>3__id");
				Match._GetEntityOption_d__138.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, 100663786);
				Match._GetEntityOption_d__138.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, 100663787);
				Match._GetEntityOption_d__138.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, 100663788);
				Match._GetEntityOption_d__138.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, 100663789);
				Match._GetEntityOption_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, 100663790);
				Match._GetEntityOption_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, 100663791);
				Match._GetEntityOption_d__138.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, 100663792);
				Match._GetEntityOption_d__138.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr, 100663793);
			}

			// Token: 0x060019DF RID: 6623 RVA: 0x0007F31C File Offset: 0x0007D51C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEntityOption_d__138(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._GetEntityOption_d__138>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__138.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019E0 RID: 6624 RVA: 0x0007F364 File Offset: 0x0007D564
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__138.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019E1 RID: 6625 RVA: 0x0007F398 File Offset: 0x0007D598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544939, XrefRangeEnd = 544941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__138.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005C9 RID: 1481
			// (get) Token: 0x060019E2 RID: 6626 RVA: 0x0007F3D4 File Offset: 0x0007D5D4
			public unsafe Entity System.Collections.Generic.IEnumerator<Canis.entities.Entity>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__138.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
				}
			}

			// Token: 0x060019E3 RID: 6627 RVA: 0x0007F414 File Offset: 0x0007D614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544941, XrefRangeEnd = 544946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005CA RID: 1482
			// (get) Token: 0x060019E4 RID: 6628 RVA: 0x0007F448 File Offset: 0x0007D648
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__138.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019E5 RID: 6629 RVA: 0x0007F488 File Offset: 0x0007D688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544946, XrefRangeEnd = 544955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Entity> System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__138.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr3) : null;
			}

			// Token: 0x060019E6 RID: 6630 RVA: 0x0007F4C8 File Offset: 0x0007D6C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__138.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060019E7 RID: 6631 RVA: 0x0000C57B File Offset: 0x0000A77B
			public _GetEntityOption_d__138(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005C3 RID: 1475
			// (get) Token: 0x060019E8 RID: 6632 RVA: 0x0007F508 File Offset: 0x0007D708
			// (set) Token: 0x060019E9 RID: 6633 RVA: 0x0000C584 File Offset: 0x0000A784
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__138.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__138.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005C4 RID: 1476
			// (get) Token: 0x060019EA RID: 6634 RVA: 0x0007F530 File Offset: 0x0007D730
			// (set) Token: 0x060019EB RID: 6635 RVA: 0x0000C59F File Offset: 0x0000A79F
			public unsafe Entity __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__138.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__138.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x060019EC RID: 6636 RVA: 0x0007F560 File Offset: 0x0007D760
			// (set) Token: 0x060019ED RID: 6637 RVA: 0x0000C5BE File Offset: 0x0000A7BE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__138.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__138.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005C6 RID: 1478
			// (get) Token: 0x060019EE RID: 6638 RVA: 0x0007F588 File Offset: 0x0007D788
			// (set) Token: 0x060019EF RID: 6639 RVA: 0x0000C5D9 File Offset: 0x0000A7D9
			public unsafe Match __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__138.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__138.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C7 RID: 1479
			// (get) Token: 0x060019F0 RID: 6640 RVA: 0x0007F5B8 File Offset: 0x0007D7B8
			// (set) Token: 0x060019F1 RID: 6641 RVA: 0x0000C5F8 File Offset: 0x0000A7F8
			public unsafe EntityID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__138.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__138.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005C8 RID: 1480
			// (get) Token: 0x060019F2 RID: 6642 RVA: 0x0007F5E8 File Offset: 0x0007D7E8
			// (set) Token: 0x060019F3 RID: 6643 RVA: 0x0000C617 File Offset: 0x0000A817
			public unsafe EntityID __3__id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__138.NativeFieldInfoPtr___3__id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__138.NativeFieldInfoPtr___3__id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001083 RID: 4227
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001084 RID: 4228
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001085 RID: 4229
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001086 RID: 4230
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001087 RID: 4231
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04001088 RID: 4232
			private static readonly IntPtr NativeFieldInfoPtr___3__id;

			// Token: 0x04001089 RID: 4233
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400108A RID: 4234
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400108B RID: 4235
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400108C RID: 4236
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_entities_Entity__get_Current_Private_Virtual_Final_New_get_Entity_0;

			// Token: 0x0400108D RID: 4237
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400108E RID: 4238
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400108F RID: 4239
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_entities_Entity__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Entity_0;

			// Token: 0x04001090 RID: 4240
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000269 RID: 617
		[ObfuscatedName("Canis.Match+<GetEntityOption>d__139`1")]
		public sealed class _GetEntityOption_d__139<T> : Object where T : Entity
		{
			// Token: 0x060019F4 RID: 6644 RVA: 0x0007F618 File Offset: 0x0007D818
			// Note: this type is marked as 'beforefieldinit'.
			static _GetEntityOption_d__139()
			{
				Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<GetEntityOption>d__139`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr);
				Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, "<>1__state");
				Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, "<>2__current");
				Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, "<>l__initialThreadId");
				Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, "<>4__this");
				Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, "id");
				Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___3__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, "<>3__id");
				Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, 100663794);
				Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, 100663795);
				Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, 100663796);
				Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, 100663797);
				Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, 100663798);
				Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, 100663799);
				Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, 100663800);
				Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr, 100663801);
			}

			// Token: 0x060019F5 RID: 6645 RVA: 0x0007F798 File Offset: 0x0007D998
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetEntityOption_d__139(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._GetEntityOption_d__139<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060019F6 RID: 6646 RVA: 0x0007F7E0 File Offset: 0x0007D9E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060019F7 RID: 6647 RVA: 0x0007F814 File Offset: 0x0007DA14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544955, XrefRangeEnd = 544957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005D1 RID: 1489
			// (get) Token: 0x060019F8 RID: 6648 RVA: 0x0007F850 File Offset: 0x0007DA50
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x060019F9 RID: 6649 RVA: 0x0007F88C File Offset: 0x0007DA8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005D2 RID: 1490
			// (get) Token: 0x060019FA RID: 6650 RVA: 0x0007F8C0 File Offset: 0x0007DAC0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060019FB RID: 6651 RVA: 0x0007F900 File Offset: 0x0007DB00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x060019FC RID: 6652 RVA: 0x0007F940 File Offset: 0x0007DB40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._GetEntityOption_d__139<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060019FD RID: 6653 RVA: 0x0000C636 File Offset: 0x0000A836
			public _GetEntityOption_d__139(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005CB RID: 1483
			// (get) Token: 0x060019FE RID: 6654 RVA: 0x0007F980 File Offset: 0x0007DB80
			// (set) Token: 0x060019FF RID: 6655 RVA: 0x0000C63F File Offset: 0x0000A83F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005CC RID: 1484
			// (get) Token: 0x06001A00 RID: 6656 RVA: 0x0007F9A8 File Offset: 0x0007DBA8
			// (set) Token: 0x06001A01 RID: 6657 RVA: 0x0007F9D0 File Offset: 0x0007DBD0
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170005CD RID: 1485
			// (get) Token: 0x06001A02 RID: 6658 RVA: 0x0007FA78 File Offset: 0x0007DC78
			// (set) Token: 0x06001A03 RID: 6659 RVA: 0x0000C65A File Offset: 0x0000A85A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005CE RID: 1486
			// (get) Token: 0x06001A04 RID: 6660 RVA: 0x0007FAA0 File Offset: 0x0007DCA0
			// (set) Token: 0x06001A05 RID: 6661 RVA: 0x0000C675 File Offset: 0x0000A875
			public unsafe Match __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005CF RID: 1487
			// (get) Token: 0x06001A06 RID: 6662 RVA: 0x0007FAD0 File Offset: 0x0007DCD0
			// (set) Token: 0x06001A07 RID: 6663 RVA: 0x0000C694 File Offset: 0x0000A894
			public unsafe EntityID id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr_id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D0 RID: 1488
			// (get) Token: 0x06001A08 RID: 6664 RVA: 0x0007FB00 File Offset: 0x0007DD00
			// (set) Token: 0x06001A09 RID: 6665 RVA: 0x0000C6B3 File Offset: 0x0000A8B3
			public unsafe EntityID __3__id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___3__id);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._GetEntityOption_d__139<T>.NativeFieldInfoPtr___3__id), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001091 RID: 4241
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001092 RID: 4242
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001093 RID: 4243
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001094 RID: 4244
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001095 RID: 4245
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04001096 RID: 4246
			private static readonly IntPtr NativeFieldInfoPtr___3__id;

			// Token: 0x04001097 RID: 4247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001098 RID: 4248
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001099 RID: 4249
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400109A RID: 4250
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x0400109B RID: 4251
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400109C RID: 4252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400109D RID: 4253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x0400109E RID: 4254
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200026A RID: 618
		[ObfuscatedName("Canis.Match+<HandleResignGameAsync>d__204")]
		public sealed class _HandleResignGameAsync_d__204 : ValueType
		{
			// Token: 0x06001A0A RID: 6666 RVA: 0x0007FB30 File Offset: 0x0007DD30
			// Note: this type is marked as 'beforefieldinit'.
			static _HandleResignGameAsync_d__204()
			{
				Il2CppClassPointerStore<Match._HandleResignGameAsync_d__204>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<HandleResignGameAsync>d__204");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._HandleResignGameAsync_d__204>.NativeClassPtr);
				Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._HandleResignGameAsync_d__204>.NativeClassPtr, "<>1__state");
				Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._HandleResignGameAsync_d__204>.NativeClassPtr, "<>t__builder");
				Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr_resigningPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._HandleResignGameAsync_d__204>.NativeClassPtr, "resigningPlayerID");
				Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._HandleResignGameAsync_d__204>.NativeClassPtr, "<>4__this");
				Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._HandleResignGameAsync_d__204>.NativeClassPtr, "<>u__1");
				Match._HandleResignGameAsync_d__204.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._HandleResignGameAsync_d__204>.NativeClassPtr, 100663802);
				Match._HandleResignGameAsync_d__204.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._HandleResignGameAsync_d__204>.NativeClassPtr, 100663803);
			}

			// Token: 0x06001A0B RID: 6667 RVA: 0x0007FBE8 File Offset: 0x0007DDE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 544957, XrefRangeEnd = 545086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._HandleResignGameAsync_d__204.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A0C RID: 6668 RVA: 0x0007FC20 File Offset: 0x0007DE20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545086, XrefRangeEnd = 545090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._HandleResignGameAsync_d__204.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A0D RID: 6669 RVA: 0x0000C6D2 File Offset: 0x0000A8D2
			public _HandleResignGameAsync_d__204(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001A0E RID: 6670 RVA: 0x0000C6DB File Offset: 0x0000A8DB
			public _HandleResignGameAsync_d__204()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._HandleResignGameAsync_d__204>.NativeClassPtr))
			{
			}

			// Token: 0x170005D3 RID: 1491
			// (get) Token: 0x06001A0F RID: 6671 RVA: 0x0007FC68 File Offset: 0x0007DE68
			// (set) Token: 0x06001A10 RID: 6672 RVA: 0x0000C6ED File Offset: 0x0000A8ED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005D4 RID: 1492
			// (get) Token: 0x06001A11 RID: 6673 RVA: 0x0007FC90 File Offset: 0x0007DE90
			// (set) Token: 0x06001A12 RID: 6674 RVA: 0x0000C708 File Offset: 0x0000A908
			public AsyncTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170005D5 RID: 1493
			// (get) Token: 0x06001A13 RID: 6675 RVA: 0x0007FCC0 File Offset: 0x0007DEC0
			// (set) Token: 0x06001A14 RID: 6676 RVA: 0x0000C736 File Offset: 0x0000A936
			public unsafe AccountID resigningPlayerID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr_resigningPlayerID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr_resigningPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D6 RID: 1494
			// (get) Token: 0x06001A15 RID: 6677 RVA: 0x0007FCF0 File Offset: 0x0007DEF0
			// (set) Token: 0x06001A16 RID: 6678 RVA: 0x0000C755 File Offset: 0x0000A955
			public unsafe Match __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005D7 RID: 1495
			// (get) Token: 0x06001A17 RID: 6679 RVA: 0x0007FD20 File Offset: 0x0007DF20
			// (set) Token: 0x06001A18 RID: 6680 RVA: 0x0000C774 File Offset: 0x0000A974
			public TaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr___u__1);
					return new TaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._HandleResignGameAsync_d__204.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400109F RID: 4255
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010A0 RID: 4256
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040010A1 RID: 4257
			private static readonly IntPtr NativeFieldInfoPtr_resigningPlayerID;

			// Token: 0x040010A2 RID: 4258
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040010A3 RID: 4259
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040010A4 RID: 4260
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010A5 RID: 4261
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200026B RID: 619
		[ObfuscatedName("Canis.Match+<LookupEntities>d__143`1")]
		public sealed class _LookupEntities_d__143<T> : Object where T : Entity
		{
			// Token: 0x06001A19 RID: 6681 RVA: 0x0007FD50 File Offset: 0x0007DF50
			// Note: this type is marked as 'beforefieldinit'.
			static _LookupEntities_d__143()
			{
				Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<LookupEntities>d__143`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr);
				Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, "<>1__state");
				Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, "<>2__current");
				Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, "<>l__initialThreadId");
				Match._LookupEntities_d__143<T>.NativeFieldInfoPtr_entityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, "entityIDs");
				Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___3__entityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, "<>3__entityIDs");
				Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, "<>4__this");
				Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, "<>7__wrap1");
				Match._LookupEntities_d__143<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, 100663804);
				Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, 100663805);
				Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, 100663806);
				Match._LookupEntities_d__143<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, 100663807);
				Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, 100663808);
				Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, 100663809);
				Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, 100663810);
				Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, 100663811);
				Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr, 100663812);
			}

			// Token: 0x06001A1A RID: 6682 RVA: 0x0007FEF8 File Offset: 0x0007E0F8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LookupEntities_d__143(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._LookupEntities_d__143<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._LookupEntities_d__143<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A1B RID: 6683 RVA: 0x0007FF40 File Offset: 0x0007E140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545090, XrefRangeEnd = 545095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A1C RID: 6684 RVA: 0x0007FF74 File Offset: 0x0007E174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545095, XrefRangeEnd = 545117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001A1D RID: 6685 RVA: 0x0007FFB0 File Offset: 0x0007E1B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545117, XrefRangeEnd = 545120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._LookupEntities_d__143<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005DF RID: 1503
			// (get) Token: 0x06001A1E RID: 6686 RVA: 0x0007FFE4 File Offset: 0x0007E1E4
			public unsafe T System.Collections.Generic.IEnumerator<T>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06001A1F RID: 6687 RVA: 0x00080020 File Offset: 0x0007E220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005E0 RID: 1504
			// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00080054 File Offset: 0x0007E254
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A21 RID: 6689 RVA: 0x00080094 File Offset: 0x0007E294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545120, XrefRangeEnd = 545128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<T> System_Collections_Generic_IEnumerable_T__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<T>>(intPtr3) : null;
			}

			// Token: 0x06001A22 RID: 6690 RVA: 0x000800D4 File Offset: 0x0007E2D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545128, XrefRangeEnd = 545136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._LookupEntities_d__143<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001A23 RID: 6691 RVA: 0x0000C7A2 File Offset: 0x0000A9A2
			public _LookupEntities_d__143(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005D8 RID: 1496
			// (get) Token: 0x06001A24 RID: 6692 RVA: 0x00080114 File Offset: 0x0007E314
			// (set) Token: 0x06001A25 RID: 6693 RVA: 0x0000C7AB File Offset: 0x0000A9AB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005D9 RID: 1497
			// (get) Token: 0x06001A26 RID: 6694 RVA: 0x0008013C File Offset: 0x0007E33C
			// (set) Token: 0x06001A27 RID: 6695 RVA: 0x00080164 File Offset: 0x0007E364
			public unsafe T __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___2__current);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___2__current);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x170005DA RID: 1498
			// (get) Token: 0x06001A28 RID: 6696 RVA: 0x0008020C File Offset: 0x0007E40C
			// (set) Token: 0x06001A29 RID: 6697 RVA: 0x0000C7C6 File Offset: 0x0000A9C6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005DB RID: 1499
			// (get) Token: 0x06001A2A RID: 6698 RVA: 0x00080234 File Offset: 0x0007E434
			// (set) Token: 0x06001A2B RID: 6699 RVA: 0x0000C7E1 File Offset: 0x0000A9E1
			public unsafe IEnumerable<EntityID> entityIDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr_entityIDs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr_entityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005DC RID: 1500
			// (get) Token: 0x06001A2C RID: 6700 RVA: 0x00080264 File Offset: 0x0007E464
			// (set) Token: 0x06001A2D RID: 6701 RVA: 0x0000C800 File Offset: 0x0000AA00
			public unsafe IEnumerable<EntityID> __3__entityIDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___3__entityIDs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___3__entityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005DD RID: 1501
			// (get) Token: 0x06001A2E RID: 6702 RVA: 0x00080294 File Offset: 0x0007E494
			// (set) Token: 0x06001A2F RID: 6703 RVA: 0x0000C81F File Offset: 0x0000AA1F
			public unsafe Match __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005DE RID: 1502
			// (get) Token: 0x06001A30 RID: 6704 RVA: 0x000802C4 File Offset: 0x0007E4C4
			// (set) Token: 0x06001A31 RID: 6705 RVA: 0x0000C83E File Offset: 0x0000AA3E
			public unsafe IEnumerator<EntityID> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<EntityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._LookupEntities_d__143<T>.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010A6 RID: 4262
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010A7 RID: 4263
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040010A8 RID: 4264
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040010A9 RID: 4265
			private static readonly IntPtr NativeFieldInfoPtr_entityIDs;

			// Token: 0x040010AA RID: 4266
			private static readonly IntPtr NativeFieldInfoPtr___3__entityIDs;

			// Token: 0x040010AB RID: 4267
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040010AC RID: 4268
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040010AD RID: 4269
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010AE RID: 4270
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010AF RID: 4271
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010B0 RID: 4272
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040010B1 RID: 4273
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_T__get_Current_Private_Virtual_Final_New_get_T_0;

			// Token: 0x040010B2 RID: 4274
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010B3 RID: 4275
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040010B4 RID: 4276
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_T__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_T_0;

			// Token: 0x040010B5 RID: 4277
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200026C RID: 620
		[ObfuscatedName("Canis.Match+<MakeObfuscatedMovePublicData>d__226")]
		public sealed class _MakeObfuscatedMovePublicData_d__226 : Object
		{
			// Token: 0x06001A32 RID: 6706 RVA: 0x000802F4 File Offset: 0x0007E4F4
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeObfuscatedMovePublicData_d__226()
			{
				Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<MakeObfuscatedMovePublicData>d__226");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr);
				Match._MakeObfuscatedMovePublicData_d__226.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr, "<>1__state");
				Match._MakeObfuscatedMovePublicData_d__226.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr, "<>2__current");
				Match._MakeObfuscatedMovePublicData_d__226.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr, "<>l__initialThreadId");
				Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr, 100663813);
				Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr, 100663814);
				Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr, 100663815);
				Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr, 100663816);
				Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr, 100663817);
				Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr, 100663818);
				Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr, 100663819);
				Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr, 100663820);
			}

			// Token: 0x06001A33 RID: 6707 RVA: 0x000803FC File Offset: 0x0007E5FC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeObfuscatedMovePublicData_d__226(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__226>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A34 RID: 6708 RVA: 0x00080444 File Offset: 0x0007E644
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A35 RID: 6709 RVA: 0x00080478 File Offset: 0x0007E678
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005E4 RID: 1508
			// (get) Token: 0x06001A36 RID: 6710 RVA: 0x000804B4 File Offset: 0x0007E6B4
			public unsafe IAttribute System.Collections.Generic.IEnumerator<Canis.attributes.IAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x06001A37 RID: 6711 RVA: 0x000804F4 File Offset: 0x0007E6F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545136, XrefRangeEnd = 545141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005E5 RID: 1509
			// (get) Token: 0x06001A38 RID: 6712 RVA: 0x00080528 File Offset: 0x0007E728
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A39 RID: 6713 RVA: 0x00080568 File Offset: 0x0007E768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545141, XrefRangeEnd = 545143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IAttribute> System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
			}

			// Token: 0x06001A3A RID: 6714 RVA: 0x000805A8 File Offset: 0x0007E7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__226.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001A3B RID: 6715 RVA: 0x0000C85D File Offset: 0x0000AA5D
			public _MakeObfuscatedMovePublicData_d__226(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E1 RID: 1505
			// (get) Token: 0x06001A3C RID: 6716 RVA: 0x000805E8 File Offset: 0x0007E7E8
			// (set) Token: 0x06001A3D RID: 6717 RVA: 0x0000C866 File Offset: 0x0000AA66
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedMovePublicData_d__226.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedMovePublicData_d__226.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005E2 RID: 1506
			// (get) Token: 0x06001A3E RID: 6718 RVA: 0x00080610 File Offset: 0x0007E810
			// (set) Token: 0x06001A3F RID: 6719 RVA: 0x0000C881 File Offset: 0x0000AA81
			public unsafe IAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedMovePublicData_d__226.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedMovePublicData_d__226.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005E3 RID: 1507
			// (get) Token: 0x06001A40 RID: 6720 RVA: 0x00080640 File Offset: 0x0007E840
			// (set) Token: 0x06001A41 RID: 6721 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedMovePublicData_d__226.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedMovePublicData_d__226.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040010B6 RID: 4278
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010B7 RID: 4279
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040010B8 RID: 4280
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040010B9 RID: 4281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010BA RID: 4282
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010BB RID: 4283
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010BC RID: 4284
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0;

			// Token: 0x040010BD RID: 4285
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010BE RID: 4286
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040010BF RID: 4287
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0;

			// Token: 0x040010C0 RID: 4288
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200026D RID: 621
		[ObfuscatedName("Canis.Match+<MakeObfuscatedMovePublicData>d__227")]
		public sealed class _MakeObfuscatedMovePublicData_d__227 : Object
		{
			// Token: 0x06001A42 RID: 6722 RVA: 0x00080668 File Offset: 0x0007E868
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeObfuscatedMovePublicData_d__227()
			{
				Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<MakeObfuscatedMovePublicData>d__227");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr);
				Match._MakeObfuscatedMovePublicData_d__227.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr, "<>1__state");
				Match._MakeObfuscatedMovePublicData_d__227.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr, "<>2__current");
				Match._MakeObfuscatedMovePublicData_d__227.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr, "<>l__initialThreadId");
				Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr, 100663821);
				Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr, 100663822);
				Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr, 100663823);
				Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr, 100663824);
				Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr, 100663825);
				Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr, 100663826);
				Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr, 100663827);
				Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr, 100663828);
			}

			// Token: 0x06001A43 RID: 6723 RVA: 0x00080770 File Offset: 0x0007E970
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeObfuscatedMovePublicData_d__227(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._MakeObfuscatedMovePublicData_d__227>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A44 RID: 6724 RVA: 0x000807B8 File Offset: 0x0007E9B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A45 RID: 6725 RVA: 0x000807EC File Offset: 0x0007E9EC
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005E9 RID: 1513
			// (get) Token: 0x06001A46 RID: 6726 RVA: 0x00080828 File Offset: 0x0007EA28
			public unsafe IAttribute System.Collections.Generic.IEnumerator<Canis.attributes.IAttribute>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr3) : null;
				}
			}

			// Token: 0x06001A47 RID: 6727 RVA: 0x00080868 File Offset: 0x0007EA68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545143, XrefRangeEnd = 545148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005EA RID: 1514
			// (get) Token: 0x06001A48 RID: 6728 RVA: 0x0008089C File Offset: 0x0007EA9C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A49 RID: 6729 RVA: 0x000808DC File Offset: 0x0007EADC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545148, XrefRangeEnd = 545150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IAttribute> System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute>>(intPtr3) : null;
			}

			// Token: 0x06001A4A RID: 6730 RVA: 0x0008091C File Offset: 0x0007EB1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedMovePublicData_d__227.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001A4B RID: 6731 RVA: 0x0000C8BB File Offset: 0x0000AABB
			public _MakeObfuscatedMovePublicData_d__227(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005E6 RID: 1510
			// (get) Token: 0x06001A4C RID: 6732 RVA: 0x0008095C File Offset: 0x0007EB5C
			// (set) Token: 0x06001A4D RID: 6733 RVA: 0x0000C8C4 File Offset: 0x0000AAC4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedMovePublicData_d__227.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedMovePublicData_d__227.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005E7 RID: 1511
			// (get) Token: 0x06001A4E RID: 6734 RVA: 0x00080984 File Offset: 0x0007EB84
			// (set) Token: 0x06001A4F RID: 6735 RVA: 0x0000C8DF File Offset: 0x0000AADF
			public unsafe IAttribute __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedMovePublicData_d__227.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedMovePublicData_d__227.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005E8 RID: 1512
			// (get) Token: 0x06001A50 RID: 6736 RVA: 0x000809B4 File Offset: 0x0007EBB4
			// (set) Token: 0x06001A51 RID: 6737 RVA: 0x0000C8FE File Offset: 0x0000AAFE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedMovePublicData_d__227.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedMovePublicData_d__227.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040010C1 RID: 4289
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010C2 RID: 4290
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040010C3 RID: 4291
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040010C4 RID: 4292
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010C5 RID: 4293
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010C6 RID: 4294
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010C7 RID: 4295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_attributes_IAttribute__get_Current_Private_Virtual_Final_New_get_IAttribute_0;

			// Token: 0x040010C8 RID: 4296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010C9 RID: 4297
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040010CA RID: 4298
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_attributes_IAttribute__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_IAttribute_0;

			// Token: 0x040010CB RID: 4299
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200026E RID: 622
		[ObfuscatedName("Canis.Match+<MakeObfuscatedNumChildren>d__224")]
		public sealed class _MakeObfuscatedNumChildren_d__224 : Object
		{
			// Token: 0x06001A52 RID: 6738 RVA: 0x000809DC File Offset: 0x0007EBDC
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeObfuscatedNumChildren_d__224()
			{
				Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<MakeObfuscatedNumChildren>d__224");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr);
				Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, "<>1__state");
				Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, "<>2__current");
				Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, "<>l__initialThreadId");
				Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, "parent");
				Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___3__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, "<>3__parent");
				Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr_perspective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, "perspective");
				Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___3__perspective = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, "<>3__perspective");
				Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr_removedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, "removedEntities");
				Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___3__removedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, "<>3__removedEntities");
				Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, 100663829);
				Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, 100663830);
				Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, 100663831);
				Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, 100663832);
				Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, 100663833);
				Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, 100663834);
				Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, 100663835);
				Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr, 100663836);
			}

			// Token: 0x06001A53 RID: 6739 RVA: 0x00080B5C File Offset: 0x0007ED5C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeObfuscatedNumChildren_d__224(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__224>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A54 RID: 6740 RVA: 0x00080BA4 File Offset: 0x0007EDA4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A55 RID: 6741 RVA: 0x00080BD8 File Offset: 0x0007EDD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545150, XrefRangeEnd = 545165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005F4 RID: 1524
			// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00080C14 File Offset: 0x0007EE14
			public unsafe IAttribute<Nullable<int>> prop_IAttribute_1_Nullable_1_Int32_0
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001A57 RID: 6743 RVA: 0x00080C54 File Offset: 0x0007EE54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545165, XrefRangeEnd = 545170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005F5 RID: 1525
			// (get) Token: 0x06001A58 RID: 6744 RVA: 0x00080C88 File Offset: 0x0007EE88
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A59 RID: 6745 RVA: 0x00080CC8 File Offset: 0x0007EEC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545170, XrefRangeEnd = 545180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IAttribute<Nullable<int>>> Method_Private_Virtual_Final_New_IEnumerator_1_IAttribute_1_Nullable_1_Int32_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute<Nullable<int>>>>(intPtr3) : null;
			}

			// Token: 0x06001A5A RID: 6746 RVA: 0x00080D08 File Offset: 0x0007EF08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__224.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001A5B RID: 6747 RVA: 0x0000C919 File Offset: 0x0000AB19
			public _MakeObfuscatedNumChildren_d__224(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005EB RID: 1515
			// (get) Token: 0x06001A5C RID: 6748 RVA: 0x00080D48 File Offset: 0x0007EF48
			// (set) Token: 0x06001A5D RID: 6749 RVA: 0x0000C922 File Offset: 0x0000AB22
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005EC RID: 1516
			// (get) Token: 0x06001A5E RID: 6750 RVA: 0x00080D70 File Offset: 0x0007EF70
			// (set) Token: 0x06001A5F RID: 6751 RVA: 0x0000C93D File Offset: 0x0000AB3D
			public unsafe IAttribute<Nullable<int>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005ED RID: 1517
			// (get) Token: 0x06001A60 RID: 6752 RVA: 0x00080DA0 File Offset: 0x0007EFA0
			// (set) Token: 0x06001A61 RID: 6753 RVA: 0x0000C95C File Offset: 0x0000AB5C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005EE RID: 1518
			// (get) Token: 0x06001A62 RID: 6754 RVA: 0x00080DC8 File Offset: 0x0007EFC8
			// (set) Token: 0x06001A63 RID: 6755 RVA: 0x0000C977 File Offset: 0x0000AB77
			public unsafe Entity parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x06001A64 RID: 6756 RVA: 0x00080DF8 File Offset: 0x0007EFF8
			// (set) Token: 0x06001A65 RID: 6757 RVA: 0x0000C996 File Offset: 0x0000AB96
			public unsafe Entity __3__parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___3__parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___3__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F0 RID: 1520
			// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00080E28 File Offset: 0x0007F028
			// (set) Token: 0x06001A67 RID: 6759 RVA: 0x0000C9B5 File Offset: 0x0000ABB5
			public unsafe AccountID perspective
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr_perspective);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr_perspective), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F1 RID: 1521
			// (get) Token: 0x06001A68 RID: 6760 RVA: 0x00080E58 File Offset: 0x0007F058
			// (set) Token: 0x06001A69 RID: 6761 RVA: 0x0000C9D4 File Offset: 0x0000ABD4
			public unsafe AccountID __3__perspective
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___3__perspective);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___3__perspective), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F2 RID: 1522
			// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00080E88 File Offset: 0x0007F088
			// (set) Token: 0x06001A6B RID: 6763 RVA: 0x0000C9F3 File Offset: 0x0000ABF3
			public unsafe Il2CppReferenceArray<Entity> removedEntities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr_removedEntities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr_removedEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F3 RID: 1523
			// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00080EB8 File Offset: 0x0007F0B8
			// (set) Token: 0x06001A6D RID: 6765 RVA: 0x0000CA12 File Offset: 0x0000AC12
			public unsafe Il2CppReferenceArray<Entity> __3__removedEntities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___3__removedEntities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__224.NativeFieldInfoPtr___3__removedEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010CC RID: 4300
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010CD RID: 4301
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040010CE RID: 4302
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040010CF RID: 4303
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x040010D0 RID: 4304
			private static readonly IntPtr NativeFieldInfoPtr___3__parent;

			// Token: 0x040010D1 RID: 4305
			private static readonly IntPtr NativeFieldInfoPtr_perspective;

			// Token: 0x040010D2 RID: 4306
			private static readonly IntPtr NativeFieldInfoPtr___3__perspective;

			// Token: 0x040010D3 RID: 4307
			private static readonly IntPtr NativeFieldInfoPtr_removedEntities;

			// Token: 0x040010D4 RID: 4308
			private static readonly IntPtr NativeFieldInfoPtr___3__removedEntities;

			// Token: 0x040010D5 RID: 4309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010D6 RID: 4310
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010D7 RID: 4311
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010D8 RID: 4312
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IAttribute_1_Nullable_1_Int32_0;

			// Token: 0x040010D9 RID: 4313
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010DA RID: 4314
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040010DB RID: 4315
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_IAttribute_1_Nullable_1_Int32_0;

			// Token: 0x040010DC RID: 4316
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200026F RID: 623
		[ObfuscatedName("Canis.Match+<MakeObfuscatedNumChildren>d__225")]
		public sealed class _MakeObfuscatedNumChildren_d__225 : Object
		{
			// Token: 0x06001A6E RID: 6766 RVA: 0x00080EE8 File Offset: 0x0007F0E8
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeObfuscatedNumChildren_d__225()
			{
				Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<MakeObfuscatedNumChildren>d__225");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr);
				Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, "<>1__state");
				Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, "<>2__current");
				Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, "<>l__initialThreadId");
				Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, "parent");
				Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___3__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, "<>3__parent");
				Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr_removedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, "removedEntities");
				Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___3__removedEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, "<>3__removedEntities");
				Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, 100663837);
				Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, 100663838);
				Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, 100663839);
				Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, 100663840);
				Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, 100663841);
				Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, 100663842);
				Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_IAttribute_1_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, 100663843);
				Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr, 100663844);
			}

			// Token: 0x06001A6F RID: 6767 RVA: 0x00081040 File Offset: 0x0007F240
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeObfuscatedNumChildren_d__225(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._MakeObfuscatedNumChildren_d__225>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A70 RID: 6768 RVA: 0x00081088 File Offset: 0x0007F288
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A71 RID: 6769 RVA: 0x000810BC File Offset: 0x0007F2BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545180, XrefRangeEnd = 545191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x06001A72 RID: 6770 RVA: 0x000810F8 File Offset: 0x0007F2F8
			public unsafe IAttribute<Nullable<int>> prop_IAttribute_1_Nullable_1_Int32_0
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr3) : null;
				}
			}

			// Token: 0x06001A73 RID: 6771 RVA: 0x00081138 File Offset: 0x0007F338
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545191, XrefRangeEnd = 545196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170005FE RID: 1534
			// (get) Token: 0x06001A74 RID: 6772 RVA: 0x0008116C File Offset: 0x0007F36C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A75 RID: 6773 RVA: 0x000811AC File Offset: 0x0007F3AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545196, XrefRangeEnd = 545205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<IAttribute<Nullable<int>>> Method_Private_Virtual_Final_New_IEnumerator_1_IAttribute_1_Nullable_1_Int32_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_IAttribute_1_Nullable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<IAttribute<Nullable<int>>>>(intPtr3) : null;
			}

			// Token: 0x06001A76 RID: 6774 RVA: 0x000811EC File Offset: 0x0007F3EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._MakeObfuscatedNumChildren_d__225.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001A77 RID: 6775 RVA: 0x0000CA31 File Offset: 0x0000AC31
			public _MakeObfuscatedNumChildren_d__225(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005F6 RID: 1526
			// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0008122C File Offset: 0x0007F42C
			// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0000CA3A File Offset: 0x0000AC3A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170005F7 RID: 1527
			// (get) Token: 0x06001A7A RID: 6778 RVA: 0x00081254 File Offset: 0x0007F454
			// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0000CA55 File Offset: 0x0000AC55
			public unsafe IAttribute<Nullable<int>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute<Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005F8 RID: 1528
			// (get) Token: 0x06001A7C RID: 6780 RVA: 0x00081284 File Offset: 0x0007F484
			// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0000CA74 File Offset: 0x0000AC74
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170005F9 RID: 1529
			// (get) Token: 0x06001A7E RID: 6782 RVA: 0x000812AC File Offset: 0x0007F4AC
			// (set) Token: 0x06001A7F RID: 6783 RVA: 0x0000CA8F File Offset: 0x0000AC8F
			public unsafe SerializedEntity parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr_parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FA RID: 1530
			// (get) Token: 0x06001A80 RID: 6784 RVA: 0x000812DC File Offset: 0x0007F4DC
			// (set) Token: 0x06001A81 RID: 6785 RVA: 0x0000CAAE File Offset: 0x0000ACAE
			public unsafe SerializedEntity __3__parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___3__parent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___3__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FB RID: 1531
			// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0008130C File Offset: 0x0007F50C
			// (set) Token: 0x06001A83 RID: 6787 RVA: 0x0000CACD File Offset: 0x0000ACCD
			public unsafe Il2CppReferenceArray<SerializedEntity> removedEntities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr_removedEntities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializedEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr_removedEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170005FC RID: 1532
			// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0008133C File Offset: 0x0007F53C
			// (set) Token: 0x06001A85 RID: 6789 RVA: 0x0000CAEC File Offset: 0x0000ACEC
			public unsafe Il2CppReferenceArray<SerializedEntity> __3__removedEntities
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___3__removedEntities);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SerializedEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._MakeObfuscatedNumChildren_d__225.NativeFieldInfoPtr___3__removedEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010DD RID: 4317
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010DE RID: 4318
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040010DF RID: 4319
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040010E0 RID: 4320
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x040010E1 RID: 4321
			private static readonly IntPtr NativeFieldInfoPtr___3__parent;

			// Token: 0x040010E2 RID: 4322
			private static readonly IntPtr NativeFieldInfoPtr_removedEntities;

			// Token: 0x040010E3 RID: 4323
			private static readonly IntPtr NativeFieldInfoPtr___3__removedEntities;

			// Token: 0x040010E4 RID: 4324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010E5 RID: 4325
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010E6 RID: 4326
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010E7 RID: 4327
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_IAttribute_1_Nullable_1_Int32_0;

			// Token: 0x040010E8 RID: 4328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010E9 RID: 4329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040010EA RID: 4330
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_IAttribute_1_Nullable_1_Int32_0;

			// Token: 0x040010EB RID: 4331
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000270 RID: 624
		[ObfuscatedName("Canis.Match+<PrePendSelection>d__233")]
		public sealed class _PrePendSelection_d__233 : Object
		{
			// Token: 0x06001A86 RID: 6790 RVA: 0x0008136C File Offset: 0x0007F56C
			// Note: this type is marked as 'beforefieldinit'.
			static _PrePendSelection_d__233()
			{
				Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<PrePendSelection>d__233");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr);
				Match._PrePendSelection_d__233.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr, "<>1__state");
				Match._PrePendSelection_d__233.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr, "<>2__current");
				Match._PrePendSelection_d__233.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr, "<>l__initialThreadId");
				Match._PrePendSelection_d__233.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr, 100663845);
				Match._PrePendSelection_d__233.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr, 100663846);
				Match._PrePendSelection_d__233.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr, 100663847);
				Match._PrePendSelection_d__233.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr, 100663848);
				Match._PrePendSelection_d__233.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr, 100663849);
				Match._PrePendSelection_d__233.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr, 100663850);
				Match._PrePendSelection_d__233.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr, 100663851);
				Match._PrePendSelection_d__233.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr, 100663852);
			}

			// Token: 0x06001A87 RID: 6791 RVA: 0x00081474 File Offset: 0x0007F674
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PrePendSelection_d__233(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._PrePendSelection_d__233>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PrePendSelection_d__233.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A88 RID: 6792 RVA: 0x000814BC File Offset: 0x0007F6BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PrePendSelection_d__233.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A89 RID: 6793 RVA: 0x000814F0 File Offset: 0x0007F6F0
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PrePendSelection_d__233.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x06001A8A RID: 6794 RVA: 0x0008152C File Offset: 0x0007F72C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PrePendSelection_d__233.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001A8B RID: 6795 RVA: 0x0008156C File Offset: 0x0007F76C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545205, XrefRangeEnd = 545210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PrePendSelection_d__233.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000603 RID: 1539
			// (get) Token: 0x06001A8C RID: 6796 RVA: 0x000815A0 File Offset: 0x0007F7A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PrePendSelection_d__233.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A8D RID: 6797 RVA: 0x000815E0 File Offset: 0x0007F7E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545210, XrefRangeEnd = 545212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PrePendSelection_d__233.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001A8E RID: 6798 RVA: 0x00081620 File Offset: 0x0007F820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PrePendSelection_d__233.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001A8F RID: 6799 RVA: 0x0000CB0B File Offset: 0x0000AD0B
			public _PrePendSelection_d__233(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170005FF RID: 1535
			// (get) Token: 0x06001A90 RID: 6800 RVA: 0x00081660 File Offset: 0x0007F860
			// (set) Token: 0x06001A91 RID: 6801 RVA: 0x0000CB14 File Offset: 0x0000AD14
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PrePendSelection_d__233.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PrePendSelection_d__233.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000600 RID: 1536
			// (get) Token: 0x06001A92 RID: 6802 RVA: 0x00081688 File Offset: 0x0007F888
			// (set) Token: 0x06001A93 RID: 6803 RVA: 0x0000CB2F File Offset: 0x0000AD2F
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PrePendSelection_d__233.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PrePendSelection_d__233.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x06001A94 RID: 6804 RVA: 0x000816B8 File Offset: 0x0007F8B8
			// (set) Token: 0x06001A95 RID: 6805 RVA: 0x0000CB4E File Offset: 0x0000AD4E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PrePendSelection_d__233.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PrePendSelection_d__233.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040010EC RID: 4332
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010ED RID: 4333
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040010EE RID: 4334
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040010EF RID: 4335
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010F0 RID: 4336
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010F1 RID: 4337
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010F2 RID: 4338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040010F3 RID: 4339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010F4 RID: 4340
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040010F5 RID: 4341
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040010F6 RID: 4342
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000271 RID: 625
		[ObfuscatedName("Canis.Match+<PreProcessPlayerChoiceWithPlayer>d__59")]
		public sealed class _PreProcessPlayerChoiceWithPlayer_d__59 : Object
		{
			// Token: 0x06001A96 RID: 6806 RVA: 0x000816E0 File Offset: 0x0007F8E0
			// Note: this type is marked as 'beforefieldinit'.
			static _PreProcessPlayerChoiceWithPlayer_d__59()
			{
				Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<PreProcessPlayerChoiceWithPlayer>d__59");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr);
				Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr, "<>1__state");
				Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr, "<>2__current");
				Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr, "<>l__initialThreadId");
				Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr, "<>4__this");
				Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr, 100663853);
				Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr, 100663854);
				Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr, 100663855);
				Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr, 100663856);
				Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr, 100663857);
				Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr, 100663858);
				Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr, 100663859);
				Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr, 100663860);
			}

			// Token: 0x06001A97 RID: 6807 RVA: 0x000817FC File Offset: 0x0007F9FC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PreProcessPlayerChoiceWithPlayer_d__59(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._PreProcessPlayerChoiceWithPlayer_d__59>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001A98 RID: 6808 RVA: 0x00081844 File Offset: 0x0007FA44
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001A99 RID: 6809 RVA: 0x00081878 File Offset: 0x0007FA78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545212, XrefRangeEnd = 545217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000608 RID: 1544
			// (get) Token: 0x06001A9A RID: 6810 RVA: 0x000818B4 File Offset: 0x0007FAB4
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001A9B RID: 6811 RVA: 0x000818F4 File Offset: 0x0007FAF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545217, XrefRangeEnd = 545222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000609 RID: 1545
			// (get) Token: 0x06001A9C RID: 6812 RVA: 0x00081928 File Offset: 0x0007FB28
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001A9D RID: 6813 RVA: 0x00081968 File Offset: 0x0007FB68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545222, XrefRangeEnd = 545224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001A9E RID: 6814 RVA: 0x000819A8 File Offset: 0x0007FBA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001A9F RID: 6815 RVA: 0x0000CB69 File Offset: 0x0000AD69
			public _PreProcessPlayerChoiceWithPlayer_d__59(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x000819E8 File Offset: 0x0007FBE8
			// (set) Token: 0x06001AA1 RID: 6817 RVA: 0x0000CB72 File Offset: 0x0000AD72
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000605 RID: 1541
			// (get) Token: 0x06001AA2 RID: 6818 RVA: 0x00081A10 File Offset: 0x0007FC10
			// (set) Token: 0x06001AA3 RID: 6819 RVA: 0x0000CB8D File Offset: 0x0000AD8D
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x00081A40 File Offset: 0x0007FC40
			// (set) Token: 0x06001AA5 RID: 6821 RVA: 0x0000CBAC File Offset: 0x0000ADAC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000607 RID: 1543
			// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x00081A68 File Offset: 0x0007FC68
			// (set) Token: 0x06001AA7 RID: 6823 RVA: 0x0000CBC7 File Offset: 0x0000ADC7
			public unsafe Match __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._PreProcessPlayerChoiceWithPlayer_d__59.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010F7 RID: 4343
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010F8 RID: 4344
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040010F9 RID: 4345
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040010FA RID: 4346
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040010FB RID: 4347
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010FC RID: 4348
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010FD RID: 4349
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010FE RID: 4350
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040010FF RID: 4351
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001100 RID: 4352
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001101 RID: 4353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001102 RID: 4354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000272 RID: 626
		[ObfuscatedName("Canis.Match+<SetNonPromptText>d__165")]
		public sealed class _SetNonPromptText_d__165 : Object
		{
			// Token: 0x06001AA8 RID: 6824 RVA: 0x00081A98 File Offset: 0x0007FC98
			// Note: this type is marked as 'beforefieldinit'.
			static _SetNonPromptText_d__165()
			{
				Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Match>.NativeClassPtr, "<SetNonPromptText>d__165");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr);
				Match._SetNonPromptText_d__165.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, "<>1__state");
				Match._SetNonPromptText_d__165.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, "<>2__current");
				Match._SetNonPromptText_d__165.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, "<>l__initialThreadId");
				Match._SetNonPromptText_d__165.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, "<>4__this");
				Match._SetNonPromptText_d__165.NativeFieldInfoPtr_nonSelectingPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, "nonSelectingPlayers");
				Match._SetNonPromptText_d__165.NativeFieldInfoPtr___3__nonSelectingPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, "<>3__nonSelectingPlayers");
				Match._SetNonPromptText_d__165.NativeFieldInfoPtr_nonPromptText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, "nonPromptText");
				Match._SetNonPromptText_d__165.NativeFieldInfoPtr___3__nonPromptText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, "<>3__nonPromptText");
				Match._SetNonPromptText_d__165.NativeFieldInfoPtr__nonSelectors_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, "<nonSelectors>5__2");
				Match._SetNonPromptText_d__165.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, "<>7__wrap2");
				Match._SetNonPromptText_d__165.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, 100663861);
				Match._SetNonPromptText_d__165.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, 100663862);
				Match._SetNonPromptText_d__165.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, 100663863);
				Match._SetNonPromptText_d__165.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, 100663864);
				Match._SetNonPromptText_d__165.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, 100663865);
				Match._SetNonPromptText_d__165.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, 100663866);
				Match._SetNonPromptText_d__165.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, 100663867);
				Match._SetNonPromptText_d__165.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, 100663868);
				Match._SetNonPromptText_d__165.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr, 100663869);
			}

			// Token: 0x06001AA9 RID: 6825 RVA: 0x00081C40 File Offset: 0x0007FE40
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SetNonPromptText_d__165(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Match._SetNonPromptText_d__165>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._SetNonPromptText_d__165.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AAA RID: 6826 RVA: 0x00081C88 File Offset: 0x0007FE88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545224, XrefRangeEnd = 545229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._SetNonPromptText_d__165.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AAB RID: 6827 RVA: 0x00081CBC File Offset: 0x0007FEBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545229, XrefRangeEnd = 545327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._SetNonPromptText_d__165.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001AAC RID: 6828 RVA: 0x00081CF8 File Offset: 0x0007FEF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545327, XrefRangeEnd = 545330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._SetNonPromptText_d__165.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000614 RID: 1556
			// (get) Token: 0x06001AAD RID: 6829 RVA: 0x00081D2C File Offset: 0x0007FF2C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._SetNonPromptText_d__165.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06001AAE RID: 6830 RVA: 0x00081D6C File Offset: 0x0007FF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545330, XrefRangeEnd = 545335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._SetNonPromptText_d__165.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x06001AAF RID: 6831 RVA: 0x00081DA0 File Offset: 0x0007FFA0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._SetNonPromptText_d__165.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001AB0 RID: 6832 RVA: 0x00081DE0 File Offset: 0x0007FFE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 545335, XrefRangeEnd = 545345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._SetNonPromptText_d__165.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001AB1 RID: 6833 RVA: 0x00081E20 File Offset: 0x00080020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Match._SetNonPromptText_d__165.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001AB2 RID: 6834 RVA: 0x0000CBE6 File Offset: 0x0000ADE6
			public _SetNonPromptText_d__165(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700060A RID: 1546
			// (get) Token: 0x06001AB3 RID: 6835 RVA: 0x00081E60 File Offset: 0x00080060
			// (set) Token: 0x06001AB4 RID: 6836 RVA: 0x0000CBEF File Offset: 0x0000ADEF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700060B RID: 1547
			// (get) Token: 0x06001AB5 RID: 6837 RVA: 0x00081E88 File Offset: 0x00080088
			// (set) Token: 0x06001AB6 RID: 6838 RVA: 0x0000CC0A File Offset: 0x0000AE0A
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700060C RID: 1548
			// (get) Token: 0x06001AB7 RID: 6839 RVA: 0x00081EB8 File Offset: 0x000800B8
			// (set) Token: 0x06001AB8 RID: 6840 RVA: 0x0000CC29 File Offset: 0x0000AE29
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700060D RID: 1549
			// (get) Token: 0x06001AB9 RID: 6841 RVA: 0x00081EE0 File Offset: 0x000800E0
			// (set) Token: 0x06001ABA RID: 6842 RVA: 0x0000CC44 File Offset: 0x0000AE44
			public unsafe Match __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x06001ABB RID: 6843 RVA: 0x00081F10 File Offset: 0x00080110
			// (set) Token: 0x06001ABC RID: 6844 RVA: 0x0000CC63 File Offset: 0x0000AE63
			public unsafe IEnumerable<PlayerEntity> nonSelectingPlayers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr_nonSelectingPlayers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr_nonSelectingPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700060F RID: 1551
			// (get) Token: 0x06001ABD RID: 6845 RVA: 0x00081F40 File Offset: 0x00080140
			// (set) Token: 0x06001ABE RID: 6846 RVA: 0x0000CC82 File Offset: 0x0000AE82
			public unsafe IEnumerable<PlayerEntity> __3__nonSelectingPlayers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___3__nonSelectingPlayers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<PlayerEntity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___3__nonSelectingPlayers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x06001ABF RID: 6847 RVA: 0x00081F70 File Offset: 0x00080170
			// (set) Token: 0x06001AC0 RID: 6848 RVA: 0x0000CCA1 File Offset: 0x0000AEA1
			public unsafe LocalizableTextVariables nonPromptText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr_nonPromptText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr_nonPromptText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x06001AC1 RID: 6849 RVA: 0x00081FA0 File Offset: 0x000801A0
			// (set) Token: 0x06001AC2 RID: 6850 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
			public unsafe LocalizableTextVariables __3__nonPromptText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___3__nonPromptText);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___3__nonPromptText), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x00081FD0 File Offset: 0x000801D0
			// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x0000CCDF File Offset: 0x0000AEDF
			public unsafe Il2CppReferenceArray<Entity> _nonSelectors_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr__nonSelectors_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr__nonSelectors_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x00082000 File Offset: 0x00080200
			// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x0000CCFE File Offset: 0x0000AEFE
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Match._SetNonPromptText_d__165.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001103 RID: 4355
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001104 RID: 4356
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001105 RID: 4357
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001106 RID: 4358
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001107 RID: 4359
			private static readonly IntPtr NativeFieldInfoPtr_nonSelectingPlayers;

			// Token: 0x04001108 RID: 4360
			private static readonly IntPtr NativeFieldInfoPtr___3__nonSelectingPlayers;

			// Token: 0x04001109 RID: 4361
			private static readonly IntPtr NativeFieldInfoPtr_nonPromptText;

			// Token: 0x0400110A RID: 4362
			private static readonly IntPtr NativeFieldInfoPtr___3__nonPromptText;

			// Token: 0x0400110B RID: 4363
			private static readonly IntPtr NativeFieldInfoPtr__nonSelectors_5__2;

			// Token: 0x0400110C RID: 4364
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400110D RID: 4365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400110E RID: 4366
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400110F RID: 4367
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001110 RID: 4368
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001111 RID: 4369
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001112 RID: 4370
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001113 RID: 4371
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001114 RID: 4372
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001115 RID: 4373
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000273 RID: 627
		private sealed class MethodInfoStoreGeneric_GetPlayerByIndex_Public_Abstract_Virtual_New_T_Int32_0<T>
		{
			// Token: 0x04001116 RID: 4374
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Match.NativeMethodInfoPtr_GetPlayerByIndex_Public_Abstract_Virtual_New_T_Int32_0, Il2CppClassPointerStore<Match>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000274 RID: 628
		private sealed class MethodInfoStoreGeneric_GetEntityOption_Public_IEnumerable_1_T_EntityID_0<T>
		{
			// Token: 0x04001117 RID: 4375
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Match.NativeMethodInfoPtr_GetEntityOption_Public_IEnumerable_1_T_EntityID_0, Il2CppClassPointerStore<Match>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000275 RID: 629
		private sealed class MethodInfoStoreGeneric_TryGetEntity_Public_Boolean_EntityID_byref_T_0<T>
		{
			// Token: 0x04001118 RID: 4376
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Match.NativeMethodInfoPtr_TryGetEntity_Public_Boolean_EntityID_byref_T_0, Il2CppClassPointerStore<Match>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000276 RID: 630
		private sealed class MethodInfoStoreGeneric_LookupEntities_Public_IEnumerable_1_T_IEnumerable_1_EntityID_0<T>
		{
			// Token: 0x04001119 RID: 4377
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Match.NativeMethodInfoPtr_LookupEntities_Public_IEnumerable_1_T_IEnumerable_1_EntityID_0, Il2CppClassPointerStore<Match>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
