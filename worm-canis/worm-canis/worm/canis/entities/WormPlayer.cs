using System;
using Canis;
using Canis.actions;
using Canis.attributes;
using Canis.entities;
using Canis.messages;
using Canis.selectionfilters;
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
using lib.canis.Canis.data;
using lib.canis.worm_canis.data.Skirmish.ScoringMethods;
using Networking.selection.messages;
using Networking.selection.messages.outgoing;
using Networking.selection.targetresponse;
using worm.canis.abilities;
using worm.canis.abilities.PlayAbilities;
using worm.canis.ai;
using worm.canis.data.enums;
using worm.canis.match;

namespace worm.canis.entities
{
	// Token: 0x02000031 RID: 49
	public class WormPlayer : PlayerEntity
	{
		// Token: 0x060003BB RID: 955 RVA: 0x0007834C File Offset: 0x0007654C
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayer()
		{
			Il2CppClassPointerStore<WormPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.entities", "WormPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr);
			WormPlayer.NativeFieldInfoPtr_playerInitData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "playerInitData");
			WormPlayer.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "match");
			WormPlayer.NativeFieldInfoPtr_playerSelectionFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "playerSelectionFilters");
			WormPlayer.NativeFieldInfoPtr_selectionAttrsEnt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "selectionAttrsEnt");
			WormPlayer.NativeFieldInfoPtr__PlayArea_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<PlayArea>k__BackingField");
			WormPlayer.NativeFieldInfoPtr__ActiveAgentArea_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<ActiveAgentArea>k__BackingField");
			WormPlayer.NativeFieldInfoPtr__PermanentArea_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<PermanentArea>k__BackingField");
			WormPlayer.NativeFieldInfoPtr__Hand_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<Hand>k__BackingField");
			WormPlayer.NativeFieldInfoPtr__Deck_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<Deck>k__BackingField");
			WormPlayer.NativeFieldInfoPtr__Discard_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<Discard>k__BackingField");
			WormPlayer.NativeFieldInfoPtr__IntrigueHand_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<IntrigueHand>k__BackingField");
			WormPlayer.NativeFieldInfoPtr__Supply_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<Supply>k__BackingField");
			WormPlayer.NativeFieldInfoPtr__AllianceTokens_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<AllianceTokens>k__BackingField");
			WormPlayer.NativeFieldInfoPtr__PrivateInformation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<PrivateInformation>k__BackingField");
			WormPlayer.NativeFieldInfoPtr__SetAside_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<SetAside>k__BackingField");
			WormPlayer.NativeFieldInfoPtr__Leader_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<Leader>k__BackingField");
			WormPlayer.NativeFieldInfoPtr__TechTileArea_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<TechTileArea>k__BackingField");
			WormPlayer.NativeFieldInfoPtr_abilityUsage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "abilityUsage");
			WormPlayer.NativeFieldInfoPtr_additionalReports = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "additionalReports");
			WormPlayer.NativeFieldInfoPtr_AIProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "AIProfile");
			WormPlayer.NativeFieldInfoPtr_DeferralThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "DeferralThreshold");
			WormPlayer.NativeMethodInfoPtr_get_PlayArea_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664155);
			WormPlayer.NativeMethodInfoPtr_set_PlayArea_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664156);
			WormPlayer.NativeMethodInfoPtr_get_ActiveAgentArea_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664157);
			WormPlayer.NativeMethodInfoPtr_set_ActiveAgentArea_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664158);
			WormPlayer.NativeMethodInfoPtr_get_PermanentArea_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664159);
			WormPlayer.NativeMethodInfoPtr_set_PermanentArea_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664160);
			WormPlayer.NativeMethodInfoPtr_get_Hand_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664161);
			WormPlayer.NativeMethodInfoPtr_set_Hand_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664162);
			WormPlayer.NativeMethodInfoPtr_get_Deck_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664163);
			WormPlayer.NativeMethodInfoPtr_set_Deck_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664164);
			WormPlayer.NativeMethodInfoPtr_get_Discard_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664165);
			WormPlayer.NativeMethodInfoPtr_set_Discard_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664166);
			WormPlayer.NativeMethodInfoPtr_get_IntrigueHand_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664167);
			WormPlayer.NativeMethodInfoPtr_set_IntrigueHand_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664168);
			WormPlayer.NativeMethodInfoPtr_get_Supply_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664169);
			WormPlayer.NativeMethodInfoPtr_set_Supply_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664170);
			WormPlayer.NativeMethodInfoPtr_get_AllianceTokens_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664171);
			WormPlayer.NativeMethodInfoPtr_set_AllianceTokens_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664172);
			WormPlayer.NativeMethodInfoPtr_get_PrivateInformation_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664173);
			WormPlayer.NativeMethodInfoPtr_set_PrivateInformation_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664174);
			WormPlayer.NativeMethodInfoPtr_get_SetAside_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664175);
			WormPlayer.NativeMethodInfoPtr_set_SetAside_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664176);
			WormPlayer.NativeMethodInfoPtr_get_Leader_Public_get_WormLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664177);
			WormPlayer.NativeMethodInfoPtr_set_Leader_Public_set_Void_WormLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664178);
			WormPlayer.NativeMethodInfoPtr_get_TechTileArea_Public_get_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664179);
			WormPlayer.NativeMethodInfoPtr_set_TechTileArea_Public_set_Void_WormPlayArea_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664180);
			WormPlayer.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664181);
			WormPlayer.NativeMethodInfoPtr__ctor_Public_Void_Match_AccountID_WormPlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664182);
			WormPlayer.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664183);
			WormPlayer.NativeMethodInfoPtr_InitializeSelectionFilter_Public_Void_Match_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664184);
			WormPlayer.NativeMethodInfoPtr_get_ConsecutiveTimeoutThreshold_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664185);
			WormPlayer.NativeMethodInfoPtr_get_Opponents_Public_get_IEnumerable_1_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664186);
			WormPlayer.NativeMethodInfoPtr_get_RemainingAgents_Public_get_IEnumerable_1_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664187);
			WormPlayer.NativeMethodInfoPtr_get_AllCardsInPlay_Public_get_IEnumerable_1_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664188);
			WormPlayer.NativeMethodInfoPtr_get_AllImperiumCards_Public_get_IEnumerable_1_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664189);
			WormPlayer.NativeMethodInfoPtr_get_HandCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664190);
			WormPlayer.NativeMethodInfoPtr_get_DeckCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664191);
			WormPlayer.NativeMethodInfoPtr_MarkVisitedSpace_Public_Action_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664192);
			WormPlayer.NativeMethodInfoPtr_UndoMarkVisitedSpace_Public_Action_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664193);
			WormPlayer.NativeMethodInfoPtr_get_AbilityUsage_Public_get_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664194);
			WormPlayer.NativeMethodInfoPtr_get_AdditionalReports_Public_get_Dictionary_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664195);
			WormPlayer.NativeMethodInfoPtr_UpsertReport_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664196);
			WormPlayer.NativeMethodInfoPtr_UpsertAbilityUsage_Public_Void_WormAbilityDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664197);
			WormPlayer.NativeMethodInfoPtr_UpsertAbilityUsageCustom_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664198);
			WormPlayer.NativeMethodInfoPtr_PrepareAbilityUsage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664199);
			WormPlayer.NativeMethodInfoPtr_SelectFrom_Public_Virtual_IEnumerator_SelectionMessage_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664200);
			WormPlayer.NativeMethodInfoPtr_MakeEmptyResponse_Protected_Virtual_IEnumerable_1_TargetResponse_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664201);
			WormPlayer.NativeMethodInfoPtr_get_PlayerName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664202);
			WormPlayer.NativeMethodInfoPtr_get_Score_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664203);
			WormPlayer.NativeMethodInfoPtr_get_Winner_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664204);
			WormPlayer.NativeMethodInfoPtr_get_HasImperiumCards_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664205);
			WormPlayer.NativeMethodInfoPtr_HasIntrigueCard_Public_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664206);
			WormPlayer.NativeMethodInfoPtr_get_CanTakePlayerTurn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664207);
			WormPlayer.NativeMethodInfoPtr_get_IsHagal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664208);
			WormPlayer.NativeMethodInfoPtr_get_CardsDrawnStartOfRound_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664209);
			WormPlayer.NativeMethodInfoPtr_IsInPlayerTurn_Public_Boolean_PlayerTurnTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664210);
			WormPlayer.NativeMethodInfoPtr_get_Strength_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664211);
			WormPlayer.NativeMethodInfoPtr_get_ActiveCards_Public_get_IEnumerable_1_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664212);
			WormPlayer.NativeMethodInfoPtr_TurnOfRound_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664213);
			WormPlayer.NativeMethodInfoPtr_get_ActiveSpace_Public_get_IEnumerable_1_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664214);
			WormPlayer.NativeMethodInfoPtr_GetNextAgent_Public_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664215);
			WormPlayer.NativeMethodInfoPtr_GetNextUnits_Public_IEnumerable_1_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664216);
			WormPlayer.NativeMethodInfoPtr_GetNextTroops_Public_IEnumerable_1_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664217);
			WormPlayer.NativeMethodInfoPtr_GetNextGarrisonUnits_Public_IEnumerable_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664218);
			WormPlayer.NativeMethodInfoPtr_GetGarrisonUnits_Public_List_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664219);
			WormPlayer.NativeMethodInfoPtr_GetNextGarrisonTroops_Public_IEnumerable_1_WormTroop_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664220);
			WormPlayer.NativeMethodInfoPtr_GetFactionInfluence_Public_Int32_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664221);
			WormPlayer.NativeMethodInfoPtr_InAlliance_Public_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664222);
			WormPlayer.NativeMethodInfoPtr_GetFactionTrackTargets_Public_List_1_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664223);
			WormPlayer.NativeMethodInfoPtr_GetFactionTrackTargets_Public_List_1_WormFactionTrack_Func_3_WormFactionTrack_WormPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664224);
			WormPlayer.NativeMethodInfoPtr_get_GetDeferralThreshold_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664225);
			WormPlayer.NativeMethodInfoPtr_DeferredThresholdReached_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664226);
			WormPlayer.NativeMethodInfoPtr_DeferredThresholdReached_Public_Boolean_IEnumerable_1_WormPlayable_IEnumerable_1_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664227);
			WormPlayer.NativeMethodInfoPtr_GetSkirmishScore_Public_Dictionary_2_LocalizableTextVariables_Int32_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664228);
			WormPlayer.NativeMethodInfoPtr_GetRevealPreview_Public_Dictionary_2_String_Int32_WormMatch_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664229);
			WormPlayer.NativeMethodInfoPtr_HasMetCampaignRequirment_Public_Boolean_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664230);
			WormPlayer.NativeMethodInfoPtr_GetDarkSpaces_Public_List_1_EntityID_WormMatch_List_1_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664231);
			WormPlayer.NativeMethodInfoPtr_GetEndgamePlayableList_Public_List_1_EntityID_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664232);
			WormPlayer.NativeMethodInfoPtr_CanAcquireFromImperiumRow_Public_Boolean_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664233);
			WormPlayer.NativeMethodInfoPtr_GetUnusualSelectionsForImperiumSelections_Public_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_List_1_Entity_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664234);
			WormPlayer.NativeMethodInfoPtr_GetTargetHintingForImperiumSelections_Public_Dictionary_2_EntityID_ReadOnlyAttributes_List_1_Entity_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664235);
			WormPlayer.NativeMethodInfoPtr_GetPickerAttributesForImperiumTrash_Public_MutableAttributes_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664236);
			WormPlayer.NativeMethodInfoPtr_GetPickerAttributesForImperiumDiscard_Public_MutableAttributes_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664237);
			WormPlayer.NativeMethodInfoPtr_GetPickerAttributesForImperiumSelections_Public_MutableAttributes_List_1_Entity_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664238);
			WormPlayer.NativeMethodInfoPtr_GetTroopSupplyUnusualSelections_Public_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_List_1_Entity_Func_2_Entity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664239);
			WormPlayer.NativeMethodInfoPtr_get_ConflictTroops_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664240);
			WormPlayer.NativeMethodInfoPtr_get_GarrisonTroops_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664241);
			WormPlayer.NativeMethodInfoPtr_get_ConflictUnits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664242);
			WormPlayer.NativeMethodInfoPtr_get_GarrisonUnits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664243);
			WormPlayer.NativeMethodInfoPtr_get_ConflictDreadnoughts_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664244);
			WormPlayer.NativeMethodInfoPtr_get_GarrisonDreadnoughts_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664245);
			WormPlayer.NativeMethodInfoPtr_GetShippingTrackSpace_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664246);
			WormPlayer.NativeMethodInfoPtr_get_TechTileCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664247);
			WormPlayer.NativeMethodInfoPtr_HasTechTile_Public_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664248);
			WormPlayer.NativeMethodInfoPtr_HasTechTileFaceUp_Public_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664249);
			WormPlayer.NativeMethodInfoPtr_get_IsDuringTurn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664250);
			WormPlayer.NativeMethodInfoPtr_GetSpecimens_Public_IEnumerable_1_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664251);
			WormPlayer.NativeMethodInfoPtr_get_GeneticMarkers_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664252);
			WormPlayer.NativeMethodInfoPtr_GetTleilaxuInfluence_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664253);
			WormPlayer.NativeMethodInfoPtr_GetAcquireArchIDAndPickerKind_Public_ValueTuple_3_Boolean_ArchetypeID_String_Entity_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664254);
			WormPlayer.NativeMethodInfoPtr_GetSnooperInfluenceLevel_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664255);
			WormPlayer.NativeMethodInfoPtr_get_DefaultPlayerTurnPadding_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664256);
			WormPlayer.NativeMethodInfoPtr_InitializeTurnTimer_Public_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664257);
			WormPlayer.NativeMethodInfoPtr_ResetTurnTimer_Public_Virtual_Final_New_IEnumerable_1_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664258);
			WormPlayer.NativeMethodInfoPtr_UpdateTurnTimer_Public_Virtual_Final_New_IEnumerable_1_Action_DateTime_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664259);
			WormPlayer.NativeMethodInfoPtr_AddExtraTimeForOpponents_Public_IEnumerable_1_Action_Int32_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664260);
			WormPlayer.NativeMethodInfoPtr_PadOpponentTime_Public_Virtual_Final_New_IEnumerable_1_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664261);
			WormPlayer.NativeMethodInfoPtr___ctor_b__56_0_Private_Boolean_WormPlayerMatchInitData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664262);
			WormPlayer.NativeMethodInfoPtr__get_Opponents_b__63_0_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664263);
			WormPlayer.NativeMethodInfoPtr__DeferredThresholdReached_b__125_1_Private_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664264);
			WormPlayer.NativeMethodInfoPtr__GetEndgamePlayableList_b__131_0_Private_Boolean_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664265);
			WormPlayer.NativeMethodInfoPtr__GetEndgamePlayableList_b__131_4_Private_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664266);
			WormPlayer.NativeMethodInfoPtr__GetEndgamePlayableList_b__131_2_Private_Boolean_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664267);
			WormPlayer.NativeMethodInfoPtr__GetEndgamePlayableList_b__131_5_Private_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664268);
			WormPlayer.NativeMethodInfoPtr__CanAcquireFromImperiumRow_b__132_0_Private_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664269);
			WormPlayer.NativeMethodInfoPtr__GetSpecimens_b__158_0_Private_Boolean_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, 100664270);
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00078E30 File Offset: 0x00077030
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00078E70 File Offset: 0x00077070
		public unsafe WormPlayArea PlayArea
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_PlayArea_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_PlayArea_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00078EB4 File Offset: 0x000770B4
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00078EF4 File Offset: 0x000770F4
		public unsafe WormPlayArea ActiveAgentArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_ActiveAgentArea_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_ActiveAgentArea_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00078F38 File Offset: 0x00077138
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00078F78 File Offset: 0x00077178
		public unsafe WormPlayArea PermanentArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_PermanentArea_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_PermanentArea_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00078FBC File Offset: 0x000771BC
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00078FFC File Offset: 0x000771FC
		public unsafe WormPlayArea Hand
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_Hand_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_Hand_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00079040 File Offset: 0x00077240
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00079080 File Offset: 0x00077280
		public unsafe WormPlayArea Deck
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_Deck_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_Deck_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x000790C4 File Offset: 0x000772C4
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00079104 File Offset: 0x00077304
		public unsafe WormPlayArea Discard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_Discard_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_Discard_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00079148 File Offset: 0x00077348
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00079188 File Offset: 0x00077388
		public unsafe WormPlayArea IntrigueHand
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_IntrigueHand_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39584, XrefRangeEnd = 39585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_IntrigueHand_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060003CA RID: 970 RVA: 0x000791CC File Offset: 0x000773CC
		// (set) Token: 0x060003CB RID: 971 RVA: 0x0007920C File Offset: 0x0007740C
		public unsafe WormPlayArea Supply
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_Supply_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39585, XrefRangeEnd = 39586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_Supply_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00079250 File Offset: 0x00077450
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00079290 File Offset: 0x00077490
		public unsafe WormPlayArea AllianceTokens
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_AllianceTokens_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39586, XrefRangeEnd = 39587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_AllianceTokens_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060003CE RID: 974 RVA: 0x000792D4 File Offset: 0x000774D4
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00079314 File Offset: 0x00077514
		public unsafe WormPlayArea PrivateInformation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 39587, RefRangeEnd = 39588, XrefRangeStart = 39587, XrefRangeEnd = 39587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_PrivateInformation_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39588, XrefRangeEnd = 39589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_PrivateInformation_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00079358 File Offset: 0x00077558
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00079398 File Offset: 0x00077598
		public unsafe WormPlayArea SetAside
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_SetAside_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39589, XrefRangeEnd = 39590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_SetAside_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x000793DC File Offset: 0x000775DC
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0007941C File Offset: 0x0007761C
		public unsafe WormLeader Leader
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_Leader_Public_get_WormLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormLeader>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39590, XrefRangeEnd = 39591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_Leader_Public_set_Void_WormLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00079460 File Offset: 0x00077660
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x000794A0 File Offset: 0x000776A0
		public unsafe WormPlayArea TechTileArea
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_TechTileArea_Public_get_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39591, XrefRangeEnd = 39592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_set_TechTileArea_Public_set_Void_WormPlayArea_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000794E4 File Offset: 0x000776E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39667, RefRangeEnd = 39668, XrefRangeStart = 39592, XrefRangeEnd = 39667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayer(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00079554 File Offset: 0x00077754
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39908, RefRangeEnd = 39909, XrefRangeStart = 39668, XrefRangeEnd = 39908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayer(Match m, AccountID accountID, WormPlayerMatchInitData initialData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(initialData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr__ctor_Public_Void_Match_AccountID_WormPlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000795C4 File Offset: 0x000777C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40041, RefRangeEnd = 40042, XrefRangeStart = 39909, XrefRangeEnd = 40041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000795F8 File Offset: 0x000777F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40065, RefRangeEnd = 40066, XrefRangeStart = 40042, XrefRangeEnd = 40065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeSelectionFilter(Match m, bool isReload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isReload;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_InitializeSelectionFilter_Public_Void_Match_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00079648 File Offset: 0x00077848
		public unsafe override int ConsecutiveTimeoutThreshold
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayer.NativeMethodInfoPtr_get_ConsecutiveTimeoutThreshold_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00079690 File Offset: 0x00077890
		public unsafe IEnumerable<WormPlayer> Opponents
		{
			[CallerCount(72)]
			[CachedScanResults(RefRangeStart = 40077, RefRangeEnd = 40149, XrefRangeStart = 40066, XrefRangeEnd = 40077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_Opponents_Public_get_IEnumerable_1_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormPlayer>>(intPtr3) : null;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000796D0 File Offset: 0x000778D0
		public unsafe IEnumerable<WormAgent> RemainingAgents
		{
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 40153, RefRangeEnd = 40196, XrefRangeStart = 40149, XrefRangeEnd = 40153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_RemainingAgents_Public_get_IEnumerable_1_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAgent>>(intPtr3) : null;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00079710 File Offset: 0x00077910
		public unsafe IEnumerable<WormPlayable> AllCardsInPlay
		{
			[CallerCount(71)]
			[CachedScanResults(RefRangeStart = 40203, RefRangeEnd = 40274, XrefRangeStart = 40196, XrefRangeEnd = 40203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_AllCardsInPlay_Public_get_IEnumerable_1_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormPlayable>>(intPtr3) : null;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060003DE RID: 990 RVA: 0x00079750 File Offset: 0x00077950
		public unsafe IEnumerable<WormImperiumPlayable> AllImperiumCards
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 40287, RefRangeEnd = 40303, XrefRangeStart = 40274, XrefRangeEnd = 40287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_AllImperiumCards_Public_get_IEnumerable_1_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormImperiumPlayable>>(intPtr3) : null;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00079790 File Offset: 0x00077990
		public unsafe int HandCount
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 40304, RefRangeEnd = 40320, XrefRangeStart = 40303, XrefRangeEnd = 40304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_HandCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x000797CC File Offset: 0x000779CC
		public unsafe int DeckCount
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 40321, RefRangeEnd = 40326, XrefRangeStart = 40320, XrefRangeEnd = 40321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_DeckCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00079808 File Offset: 0x00077A08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40378, RefRangeEnd = 40379, XrefRangeStart = 40326, XrefRangeEnd = 40378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::Canis.actions.Action MarkVisitedSpace(WormSpace space)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_MarkVisitedSpace_Public_Action_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00079858 File Offset: 0x00077A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40379, XrefRangeEnd = 40432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe global::Canis.actions.Action UndoMarkVisitedSpace(WormSpace space)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_UndoMarkVisitedSpace_Public_Action_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000798A8 File Offset: 0x00077AA8
		public unsafe Dictionary<string, int> AbilityUsage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 40438, RefRangeEnd = 40439, XrefRangeStart = 40432, XrefRangeEnd = 40438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_AbilityUsage_Public_get_Dictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x000798E8 File Offset: 0x00077AE8
		public unsafe Dictionary<string, int> AdditionalReports
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 40445, RefRangeEnd = 40446, XrefRangeStart = 40439, XrefRangeEnd = 40445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_AdditionalReports_Public_get_Dictionary_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr3) : null;
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00079928 File Offset: 0x00077B28
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 40452, RefRangeEnd = 40462, XrefRangeStart = 40446, XrefRangeEnd = 40452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpsertReport(string reportName, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reportName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_UpsertReport_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00079978 File Offset: 0x00077B78
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 40530, RefRangeEnd = 40543, XrefRangeStart = 40462, XrefRangeEnd = 40530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpsertAbilityUsage(WormAbilityDefinition ability, int amount = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_UpsertAbilityUsage_Public_Void_WormAbilityDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000799C8 File Offset: 0x00077BC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40552, RefRangeEnd = 40553, XrefRangeStart = 40543, XrefRangeEnd = 40552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpsertAbilityUsageCustom(string abilityType, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(abilityType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_UpsertAbilityUsageCustom_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00079A1C File Offset: 0x00077C1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40594, RefRangeEnd = 40595, XrefRangeStart = 40553, XrefRangeEnd = 40594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrepareAbilityUsage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_PrepareAbilityUsage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00079A50 File Offset: 0x00077C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40595, XrefRangeEnd = 40601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator SelectFrom(SelectionMessage selection, Match m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayer.NativeMethodInfoPtr_SelectFrom_Public_Virtual_IEnumerator_SelectionMessage_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00079AC0 File Offset: 0x00077CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40601, XrefRangeEnd = 40605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<TargetResponse> MakeEmptyResponse(EntityID selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayer.NativeMethodInfoPtr_MakeEmptyResponse_Protected_Virtual_IEnumerable_1_TargetResponse_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetResponse>>(intPtr3) : null;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00079B1C File Offset: 0x00077D1C
		public unsafe override string PlayerName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40605, XrefRangeEnd = 40619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayer.NativeMethodInfoPtr_get_PlayerName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00079B60 File Offset: 0x00077D60
		public unsafe int Score
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 40626, RefRangeEnd = 40632, XrefRangeStart = 40619, XrefRangeEnd = 40626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_Score_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00079B9C File Offset: 0x00077D9C
		public unsafe bool Winner
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 40639, RefRangeEnd = 40659, XrefRangeStart = 40632, XrefRangeEnd = 40639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_Winner_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00079BD8 File Offset: 0x00077DD8
		public unsafe bool HasImperiumCards
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 40678, RefRangeEnd = 40680, XrefRangeStart = 40659, XrefRangeEnd = 40678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_HasImperiumCards_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00079C14 File Offset: 0x00077E14
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 40695, RefRangeEnd = 40717, XrefRangeStart = 40680, XrefRangeEnd = 40695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasIntrigueCard(ArchetypeID archID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_HasIntrigueCard_Public_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00079C64 File Offset: 0x00077E64
		public unsafe bool CanTakePlayerTurn
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 40724, RefRangeEnd = 40727, XrefRangeStart = 40717, XrefRangeEnd = 40724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_CanTakePlayerTurn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00079CA0 File Offset: 0x00077EA0
		public unsafe bool IsHagal
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 40734, RefRangeEnd = 40756, XrefRangeStart = 40727, XrefRangeEnd = 40734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_IsHagal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00079CDC File Offset: 0x00077EDC
		public unsafe int CardsDrawnStartOfRound
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 40756, RefRangeEnd = 40759, XrefRangeStart = 40756, XrefRangeEnd = 40756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_CardsDrawnStartOfRound_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00079D18 File Offset: 0x00077F18
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 40771, RefRangeEnd = 40859, XrefRangeStart = 40759, XrefRangeEnd = 40771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsInPlayerTurn(PlayerTurnTypes playerTurnType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref playerTurnType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_IsInPlayerTurn_Public_Boolean_PlayerTurnTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00079D64 File Offset: 0x00077F64
		public unsafe int Strength
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 40870, RefRangeEnd = 40935, XrefRangeStart = 40859, XrefRangeEnd = 40870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_Strength_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00079DA0 File Offset: 0x00077FA0
		public unsafe IEnumerable<WormPlayable> ActiveCards
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 40984, RefRangeEnd = 40992, XrefRangeStart = 40935, XrefRangeEnd = 40984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_ActiveCards_Public_get_IEnumerable_1_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormPlayable>>(intPtr3) : null;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00079DE0 File Offset: 0x00077FE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 40999, RefRangeEnd = 41004, XrefRangeStart = 40992, XrefRangeEnd = 40999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int TurnOfRound()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_TurnOfRound_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00079E1C File Offset: 0x0007801C
		public unsafe IEnumerable<WormSpace> ActiveSpace
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 41024, RefRangeEnd = 41045, XrefRangeStart = 41004, XrefRangeEnd = 41024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_ActiveSpace_Public_get_IEnumerable_1_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormSpace>>(intPtr3) : null;
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00079E5C File Offset: 0x0007805C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 41052, RefRangeEnd = 41064, XrefRangeStart = 41045, XrefRangeEnd = 41052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity GetNextAgent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetNextAgent_Public_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00079E9C File Offset: 0x0007809C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 41073, RefRangeEnd = 41076, XrefRangeStart = 41064, XrefRangeEnd = 41073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetNextUnits<T>(int amt = 1) where T : WormUnit
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.MethodInfoStoreGeneric_GetNextUnits_Public_IEnumerable_1_Entity_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00079EE8 File Offset: 0x000780E8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 41079, RefRangeEnd = 41089, XrefRangeStart = 41076, XrefRangeEnd = 41079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Entity> GetNextTroops(int amt = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetNextTroops_Public_IEnumerable_1_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00079F34 File Offset: 0x00078134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41095, RefRangeEnd = 41096, XrefRangeStart = 41089, XrefRangeEnd = 41095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<T> GetNextGarrisonUnits<T>(int amt = 1) where T : WormUnit
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.MethodInfoStoreGeneric_GetNextGarrisonUnits_Public_IEnumerable_1_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00079F80 File Offset: 0x00078180
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41104, XrefRangeStart = 41096, XrefRangeEnd = 41102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<T> GetGarrisonUnits<T>() where T : WormUnit
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.MethodInfoStoreGeneric_GetGarrisonUnits_Public_List_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00079FC0 File Offset: 0x000781C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 41107, RefRangeEnd = 41113, XrefRangeStart = 41104, XrefRangeEnd = 41107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormTroop> GetNextGarrisonTroops(int amt = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetNextGarrisonTroops_Public_IEnumerable_1_WormTroop_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormTroop>>(intPtr3) : null;
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0007A00C File Offset: 0x0007820C
		[CallerCount(116)]
		[CachedScanResults(RefRangeStart = 41131, RefRangeEnd = 41247, XrefRangeStart = 41113, XrefRangeEnd = 41131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetFactionInfluence(Factions faction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetFactionInfluence_Public_Int32_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0007A058 File Offset: 0x00078258
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 41261, RefRangeEnd = 41283, XrefRangeStart = 41247, XrefRangeEnd = 41261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InAlliance(Factions faction = Factions.None)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_InAlliance_Public_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0007A0A4 File Offset: 0x000782A4
		[CallerCount(29)]
		[CachedScanResults(RefRangeStart = 41321, RefRangeEnd = 41350, XrefRangeStart = 41283, XrefRangeEnd = 41321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WormFactionTrack> GetFactionTrackTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetFactionTrackTargets_Public_List_1_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WormFactionTrack>>(intPtr3) : null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0007A0E4 File Offset: 0x000782E4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 41373, RefRangeEnd = 41380, XrefRangeStart = 41350, XrefRangeEnd = 41373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WormFactionTrack> GetFactionTrackTargets(Func<WormFactionTrack, WormPlayer, bool> filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(filter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetFactionTrackTargets_Public_List_1_WormFactionTrack_Func_3_WormFactionTrack_WormPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WormFactionTrack>>(intPtr3) : null;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0007A134 File Offset: 0x00078334
		public unsafe int GetDeferralThreshold
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41380, XrefRangeEnd = 41392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_GetDeferralThreshold_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0007A170 File Offset: 0x00078370
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 41442, RefRangeEnd = 41448, XrefRangeStart = 41392, XrefRangeEnd = 41442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeferredThresholdReached()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_DeferredThresholdReached_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0007A1AC File Offset: 0x000783AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 41579, RefRangeEnd = 41582, XrefRangeStart = 41448, XrefRangeEnd = 41579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DeferredThresholdReached(IEnumerable<WormPlayable> activeCards, IEnumerable<WormSpace> activeSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeCards);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeSpace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_DeferredThresholdReached_Public_Boolean_IEnumerable_1_WormPlayable_IEnumerable_1_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0007A20C File Offset: 0x0007840C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41656, RefRangeEnd = 41657, XrefRangeStart = 41582, XrefRangeEnd = 41656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<LocalizableTextVariables, int> GetSkirmishScore(WormMatch wormMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetSkirmishScore_Public_Dictionary_2_LocalizableTextVariables_Int32_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<LocalizableTextVariables, int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0007A25C File Offset: 0x0007845C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 41973, RefRangeEnd = 41982, XrefRangeStart = 41657, XrefRangeEnd = 41973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, int> GetRevealPreview(WormMatch wormMatch, bool includeTriggers = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeTriggers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetRevealPreview_Public_Dictionary_2_String_Int32_WormMatch_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr3) : null;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0007A2BC File Offset: 0x000784BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42240, RefRangeEnd = 42242, XrefRangeStart = 41982, XrefRangeEnd = 42240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasMetCampaignRequirment(WormMatch wormMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_HasMetCampaignRequirment_Public_Boolean_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0007A30C File Offset: 0x0007850C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42304, RefRangeEnd = 42310, XrefRangeStart = 42242, XrefRangeEnd = 42304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EntityID> GetDarkSpaces(WormMatch wormMatch, List<ArchetypeID> exceptions = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetDarkSpaces_Public_List_1_EntityID_WormMatch_List_1_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr3) : null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0007A370 File Offset: 0x00078570
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42375, RefRangeEnd = 42377, XrefRangeStart = 42310, XrefRangeEnd = 42375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<EntityID> GetEndgamePlayableList(WormMatch wormMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetEndgamePlayableList_Public_List_1_EntityID_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0007A3C0 File Offset: 0x000785C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42391, RefRangeEnd = 42392, XrefRangeStart = 42377, XrefRangeEnd = 42391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAcquireFromImperiumRow(WormMatch wormMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_CanAcquireFromImperiumRow_Public_Boolean_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0007A410 File Offset: 0x00078610
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42522, RefRangeEnd = 42524, XrefRangeStart = 42392, XrefRangeEnd = 42522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ValueTuple<LocalizableTextVariables, List<EntityID>>> GetUnusualSelectionsForImperiumSelections(List<Entity> targets, bool trash = false, bool discard = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trash;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref discard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetUnusualSelectionsForImperiumSelections_Public_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_List_1_Entity_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<LocalizableTextVariables, List<EntityID>>>>(intPtr3) : null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0007A47C File Offset: 0x0007867C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42603, RefRangeEnd = 42605, XrefRangeStart = 42524, XrefRangeEnd = 42603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<EntityID, ReadOnlyAttributes> GetTargetHintingForImperiumSelections(List<Entity> targets, bool trash = false, bool discard = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trash;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref discard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetTargetHintingForImperiumSelections_Public_Dictionary_2_EntityID_ReadOnlyAttributes_List_1_Entity_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<EntityID, ReadOnlyAttributes>>(intPtr3) : null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0007A4E8 File Offset: 0x000786E8
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 42606, RefRangeEnd = 42624, XrefRangeStart = 42605, XrefRangeEnd = 42606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttributes GetPickerAttributesForImperiumTrash(List<Entity> targets)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetPickerAttributesForImperiumTrash_Public_MutableAttributes_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0007A538 File Offset: 0x00078738
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 42625, RefRangeEnd = 42634, XrefRangeStart = 42624, XrefRangeEnd = 42625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttributes GetPickerAttributesForImperiumDiscard(List<Entity> targets)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetPickerAttributesForImperiumDiscard_Public_MutableAttributes_List_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0007A588 File Offset: 0x00078788
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 42681, RefRangeEnd = 42683, XrefRangeStart = 42634, XrefRangeEnd = 42681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MutableAttributes GetPickerAttributesForImperiumSelections(List<Entity> targets, bool trash = false, bool discard = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trash;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref discard;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetPickerAttributesForImperiumSelections_Public_MutableAttributes_List_1_Entity_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MutableAttributes>(intPtr3) : null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0007A5F4 File Offset: 0x000787F4
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 42755, RefRangeEnd = 42771, XrefRangeStart = 42683, XrefRangeEnd = 42755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ValueTuple<LocalizableTextVariables, List<EntityID>>> GetTroopSupplyUnusualSelections(List<Entity> entityList, Func<Entity, int> troopCounter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(troopCounter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetTroopSupplyUnusualSelections_Public_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_List_1_Entity_Func_2_Entity_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<LocalizableTextVariables, List<EntityID>>>>(intPtr3) : null;
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0007A658 File Offset: 0x00078858
		public unsafe int ConflictTroops
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 42792, RefRangeEnd = 42804, XrefRangeStart = 42771, XrefRangeEnd = 42792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_ConflictTroops_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000412 RID: 1042 RVA: 0x0007A694 File Offset: 0x00078894
		public unsafe int GarrisonTroops
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 42825, RefRangeEnd = 42836, XrefRangeStart = 42804, XrefRangeEnd = 42825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_GarrisonTroops_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0007A6D0 File Offset: 0x000788D0
		public unsafe int ConflictUnits
		{
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 42857, RefRangeEnd = 42890, XrefRangeStart = 42836, XrefRangeEnd = 42857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_ConflictUnits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x0007A70C File Offset: 0x0007890C
		public unsafe int GarrisonUnits
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 42911, RefRangeEnd = 42919, XrefRangeStart = 42890, XrefRangeEnd = 42911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_GarrisonUnits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0007A748 File Offset: 0x00078948
		public unsafe int ConflictDreadnoughts
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 42940, RefRangeEnd = 42945, XrefRangeStart = 42919, XrefRangeEnd = 42940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_ConflictDreadnoughts_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000416 RID: 1046 RVA: 0x0007A784 File Offset: 0x00078984
		public unsafe int GarrisonDreadnoughts
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 42966, RefRangeEnd = 42969, XrefRangeStart = 42945, XrefRangeEnd = 42966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_GarrisonDreadnoughts_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0007A7C0 File Offset: 0x000789C0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 42971, RefRangeEnd = 42989, XrefRangeStart = 42969, XrefRangeEnd = 42971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetShippingTrackSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetShippingTrackSpace_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000418 RID: 1048 RVA: 0x0007A7FC File Offset: 0x000789FC
		public unsafe int TechTileCount
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 42995, RefRangeEnd = 43003, XrefRangeStart = 42989, XrefRangeEnd = 42995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_TechTileCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0007A838 File Offset: 0x00078A38
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 43017, RefRangeEnd = 43041, XrefRangeStart = 43003, XrefRangeEnd = 43017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasTechTile(ArchetypeID archID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_HasTechTile_Public_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0007A888 File Offset: 0x00078A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43041, XrefRangeEnd = 43058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasTechTileFaceUp(ArchetypeID archID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(archID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_HasTechTileFaceUp_Public_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0007A8D8 File Offset: 0x00078AD8
		public unsafe bool IsDuringTurn
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 43061, RefRangeEnd = 43065, XrefRangeStart = 43058, XrefRangeEnd = 43061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_IsDuringTurn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0007A914 File Offset: 0x00078B14
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 43079, RefRangeEnd = 43091, XrefRangeStart = 43065, XrefRangeEnd = 43079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormUnit> GetSpecimens()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetSpecimens_Public_IEnumerable_1_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormUnit>>(intPtr3) : null;
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0007A954 File Offset: 0x00078B54
		public unsafe int GeneticMarkers
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 43098, RefRangeEnd = 43134, XrefRangeStart = 43091, XrefRangeEnd = 43098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_GeneticMarkers_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0007A990 File Offset: 0x00078B90
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 43136, RefRangeEnd = 43158, XrefRangeStart = 43134, XrefRangeEnd = 43136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTleilaxuInfluence()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetTleilaxuInfluence_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0007A9CC File Offset: 0x00078BCC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 43199, RefRangeEnd = 43208, XrefRangeStart = 43158, XrefRangeEnd = 43199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<bool, ArchetypeID, string> GetAcquireArchIDAndPickerKind(Entity card = null, bool checkRecruitmentMission = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkRecruitmentMission;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetAcquireArchIDAndPickerKind_Public_ValueTuple_3_Boolean_ArchetypeID_String_Entity_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<bool, ArchetypeID, string>(intPtr);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0007AA24 File Offset: 0x00078C24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 43214, RefRangeEnd = 43216, XrefRangeStart = 43208, XrefRangeEnd = 43214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSnooperInfluenceLevel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_GetSnooperInfluenceLevel_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0007AA60 File Offset: 0x00078C60
		public unsafe virtual int DefaultPlayerTurnPadding
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 40756, RefRangeEnd = 40759, XrefRangeStart = 40756, XrefRangeEnd = 40759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_get_DefaultPlayerTurnPadding_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0007AA9C File Offset: 0x00078C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43216, XrefRangeEnd = 43231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeTurnTimer(int timerLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timerLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_InitializeTurnTimer_Public_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0007AADC File Offset: 0x00078CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43231, XrefRangeEnd = 43236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> ResetTurnTimer(int timerLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timerLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_ResetTurnTimer_Public_Virtual_Final_New_IEnumerable_1_Action_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0007AB28 File Offset: 0x00078D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43236, XrefRangeEnd = 43241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> UpdateTurnTimer(DateTime startTime, DateTime endTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_UpdateTurnTimer_Public_Virtual_Final_New_IEnumerable_1_Action_DateTime_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0007AB84 File Offset: 0x00078D84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43247, RefRangeEnd = 43250, XrefRangeStart = 43241, XrefRangeEnd = 43247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> AddExtraTimeForOpponents(int seconds, WormMatch wormMatch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(wormMatch);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_AddExtraTimeForOpponents_Public_IEnumerable_1_Action_Int32_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0007ABE4 File Offset: 0x00078DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43250, XrefRangeEnd = 43255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> PadOpponentTime(int seconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref seconds;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr_PadOpponentTime_Public_Virtual_Final_New_IEnumerable_1_Action_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0007AC30 File Offset: 0x00078E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43255, XrefRangeEnd = 43260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool __ctor_b__56_0(WormPlayerMatchInitData p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr___ctor_b__56_0_Private_Boolean_WormPlayerMatchInitData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x0007AC80 File Offset: 0x00078E80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43261, XrefRangeStart = 43260, XrefRangeEnd = 43260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_Opponents_b__63_0(WormPlayer _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr__get_Opponents_b__63_0_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0007ACD0 File Offset: 0x00078ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43261, XrefRangeEnd = 43269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _DeferredThresholdReached_b__125_1(WormSpace _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr__DeferredThresholdReached_b__125_1_Private_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0007AD20 File Offset: 0x00078F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43269, XrefRangeEnd = 43282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetEndgamePlayableList_b__131_0(WormIntriguePlayable intrigueCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(intrigueCard);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr__GetEndgamePlayableList_b__131_0_Private_Boolean_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0007AD70 File Offset: 0x00078F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43282, XrefRangeEnd = 43283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetEndgamePlayableList_b__131_4(WormAbilityDefinition _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr__GetEndgamePlayableList_b__131_4_Private_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0007ADC0 File Offset: 0x00078FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43283, XrefRangeEnd = 43296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetEndgamePlayableList_b__131_2(WormTechTilePlayable techTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(techTile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr__GetEndgamePlayableList_b__131_2_Private_Boolean_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0007AE10 File Offset: 0x00079010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetEndgamePlayableList_b__131_5(WormAbilityDefinition _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr__GetEndgamePlayableList_b__131_5_Private_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0007AE60 File Offset: 0x00079060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 43296, XrefRangeEnd = 43321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _CanAcquireFromImperiumRow_b__132_0(WormImperiumPlayable card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr__CanAcquireFromImperiumRow_b__132_0_Private_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0007AEB0 File Offset: 0x000790B0
		[CallerCount(0)]
		public unsafe bool _GetSpecimens_b__158_0(WormUnit _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.NativeMethodInfoPtr__GetSpecimens_b__158_0_Private_Boolean_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000037BD File Offset: 0x000019BD
		public WormPlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0007AF00 File Offset: 0x00079100
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x000037C6 File Offset: 0x000019C6
		public unsafe WormPlayerMatchInitData playerInitData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_playerInitData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayerMatchInitData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_playerInitData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0007AF30 File Offset: 0x00079130
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x000037E5 File Offset: 0x000019E5
		public unsafe WormMatch match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0007AF60 File Offset: 0x00079160
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00003804 File Offset: 0x00001A04
		public unsafe List<SelectionFilter> playerSelectionFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_playerSelectionFilters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SelectionFilter>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_playerSelectionFilters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x0007AF90 File Offset: 0x00079190
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00003823 File Offset: 0x00001A23
		public unsafe Entity selectionAttrsEnt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_selectionAttrsEnt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_selectionAttrsEnt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0007AFC0 File Offset: 0x000791C0
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00003842 File Offset: 0x00001A42
		public unsafe WormPlayArea _PlayArea_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__PlayArea_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__PlayArea_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0007AFF0 File Offset: 0x000791F0
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00003861 File Offset: 0x00001A61
		public unsafe WormPlayArea _ActiveAgentArea_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__ActiveAgentArea_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__ActiveAgentArea_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0007B020 File Offset: 0x00079220
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00003880 File Offset: 0x00001A80
		public unsafe WormPlayArea _PermanentArea_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__PermanentArea_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__PermanentArea_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0007B050 File Offset: 0x00079250
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0000389F File Offset: 0x00001A9F
		public unsafe WormPlayArea _Hand_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__Hand_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__Hand_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0007B080 File Offset: 0x00079280
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x000038BE File Offset: 0x00001ABE
		public unsafe WormPlayArea _Deck_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__Deck_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__Deck_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0007B0B0 File Offset: 0x000792B0
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x000038DD File Offset: 0x00001ADD
		public unsafe WormPlayArea _Discard_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__Discard_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__Discard_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0007B0E0 File Offset: 0x000792E0
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x000038FC File Offset: 0x00001AFC
		public unsafe WormPlayArea _IntrigueHand_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__IntrigueHand_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__IntrigueHand_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0007B110 File Offset: 0x00079310
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x0000391B File Offset: 0x00001B1B
		public unsafe WormPlayArea _Supply_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__Supply_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__Supply_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0007B140 File Offset: 0x00079340
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0000393A File Offset: 0x00001B3A
		public unsafe WormPlayArea _AllianceTokens_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__AllianceTokens_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__AllianceTokens_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0007B170 File Offset: 0x00079370
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00003959 File Offset: 0x00001B59
		public unsafe WormPlayArea _PrivateInformation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__PrivateInformation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__PrivateInformation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0007B1A0 File Offset: 0x000793A0
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00003978 File Offset: 0x00001B78
		public unsafe WormPlayArea _SetAside_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__SetAside_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__SetAside_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0007B1D0 File Offset: 0x000793D0
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00003997 File Offset: 0x00001B97
		public unsafe WormLeader _Leader_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__Leader_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormLeader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__Leader_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0007B200 File Offset: 0x00079400
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x000039B6 File Offset: 0x00001BB6
		public unsafe WormPlayArea _TechTileArea_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__TechTileArea_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr__TechTileArea_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0007B230 File Offset: 0x00079430
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x000039D5 File Offset: 0x00001BD5
		public unsafe Dictionary<string, int> abilityUsage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_abilityUsage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_abilityUsage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0007B260 File Offset: 0x00079460
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x000039F4 File Offset: 0x00001BF4
		public unsafe Dictionary<string, int> additionalReports
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_additionalReports);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_additionalReports), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0007B290 File Offset: 0x00079490
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x00003A13 File Offset: 0x00001C13
		public unsafe WormAIProfile AIProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_AIProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.NativeFieldInfoPtr_AIProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0007B2C0 File Offset: 0x000794C0
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00003A32 File Offset: 0x00001C32
		public unsafe static int DeferralThreshold
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormPlayer.NativeFieldInfoPtr_DeferralThreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormPlayer.NativeFieldInfoPtr_DeferralThreshold, (void*)(&value));
			}
		}

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr_playerInitData;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr_playerSelectionFilters;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr_selectionAttrsEnt;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr__PlayArea_k__BackingField;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr__ActiveAgentArea_k__BackingField;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr__PermanentArea_k__BackingField;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr__Hand_k__BackingField;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr__Deck_k__BackingField;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeFieldInfoPtr__Discard_k__BackingField;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr__IntrigueHand_k__BackingField;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr__Supply_k__BackingField;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr__AllianceTokens_k__BackingField;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeFieldInfoPtr__PrivateInformation_k__BackingField;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeFieldInfoPtr__SetAside_k__BackingField;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeFieldInfoPtr__Leader_k__BackingField;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeFieldInfoPtr__TechTileArea_k__BackingField;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeFieldInfoPtr_abilityUsage;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeFieldInfoPtr_additionalReports;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeFieldInfoPtr_AIProfile;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeFieldInfoPtr_DeferralThreshold;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayArea_Public_get_WormPlayArea_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayArea_Public_set_Void_WormPlayArea_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAgentArea_Public_get_WormPlayArea_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveAgentArea_Public_set_Void_WormPlayArea_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_get_PermanentArea_Public_get_WormPlayArea_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_set_PermanentArea_Public_set_Void_WormPlayArea_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_get_Hand_Public_get_WormPlayArea_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_set_Hand_Public_set_Void_WormPlayArea_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_get_Deck_Public_get_WormPlayArea_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_set_Deck_Public_set_Void_WormPlayArea_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_get_Discard_Public_get_WormPlayArea_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_set_Discard_Public_set_Void_WormPlayArea_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_get_IntrigueHand_Public_get_WormPlayArea_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_set_IntrigueHand_Public_set_Void_WormPlayArea_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_get_Supply_Public_get_WormPlayArea_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_set_Supply_Public_set_Void_WormPlayArea_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_get_AllianceTokens_Public_get_WormPlayArea_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_set_AllianceTokens_Public_set_Void_WormPlayArea_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateInformation_Public_get_WormPlayArea_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_set_PrivateInformation_Public_set_Void_WormPlayArea_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_get_SetAside_Public_get_WormPlayArea_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_set_SetAside_Public_set_Void_WormPlayArea_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_get_Leader_Public_get_WormLeader_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_set_Leader_Public_set_Void_WormLeader_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_get_TechTileArea_Public_get_WormPlayArea_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_set_TechTileArea_Public_set_Void_WormPlayArea_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_AccountID_WormPlayerMatchInitData_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSelectionFilter_Public_Void_Match_Boolean_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsecutiveTimeoutThreshold_Public_Virtual_get_Int32_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_get_Opponents_Public_get_IEnumerable_1_WormPlayer_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_get_RemainingAgents_Public_get_IEnumerable_1_WormAgent_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_get_AllCardsInPlay_Public_get_IEnumerable_1_WormPlayable_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_get_AllImperiumCards_Public_get_IEnumerable_1_WormImperiumPlayable_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_get_HandCount_Public_get_Int32_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_get_DeckCount_Public_get_Int32_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_MarkVisitedSpace_Public_Action_WormSpace_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_UndoMarkVisitedSpace_Public_Action_WormSpace_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilityUsage_Public_get_Dictionary_2_String_Int32_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditionalReports_Public_get_Dictionary_2_String_Int32_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_UpsertReport_Public_Void_String_Int32_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_UpsertAbilityUsage_Public_Void_WormAbilityDefinition_Int32_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_UpsertAbilityUsageCustom_Public_Void_String_String_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_PrepareAbilityUsage_Public_Void_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_SelectFrom_Public_Virtual_IEnumerator_SelectionMessage_Match_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_MakeEmptyResponse_Protected_Virtual_IEnumerable_1_TargetResponse_EntityID_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerName_Public_Virtual_get_String_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_get_Score_Public_get_Int32_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_get_Winner_Public_get_Boolean_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_get_HasImperiumCards_Public_get_Boolean_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_HasIntrigueCard_Public_Boolean_ArchetypeID_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTakePlayerTurn_Public_get_Boolean_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHagal_Public_get_Boolean_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_get_CardsDrawnStartOfRound_Public_get_Int32_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_IsInPlayerTurn_Public_Boolean_PlayerTurnTypes_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_get_Strength_Public_get_Int32_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveCards_Public_get_IEnumerable_1_WormPlayable_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_TurnOfRound_Public_Int32_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveSpace_Public_get_IEnumerable_1_WormSpace_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_GetNextAgent_Public_Entity_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_GetNextUnits_Public_IEnumerable_1_Entity_Int32_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_GetNextTroops_Public_IEnumerable_1_Entity_Int32_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_GetNextGarrisonUnits_Public_IEnumerable_1_T_Int32_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_GetGarrisonUnits_Public_List_1_T_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_GetNextGarrisonTroops_Public_IEnumerable_1_WormTroop_Int32_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_GetFactionInfluence_Public_Int32_Factions_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_InAlliance_Public_Boolean_Factions_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_GetFactionTrackTargets_Public_List_1_WormFactionTrack_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_GetFactionTrackTargets_Public_List_1_WormFactionTrack_Func_3_WormFactionTrack_WormPlayer_Boolean_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_get_GetDeferralThreshold_Public_get_Int32_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_DeferredThresholdReached_Public_Boolean_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_DeferredThresholdReached_Public_Boolean_IEnumerable_1_WormPlayable_IEnumerable_1_WormSpace_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_GetSkirmishScore_Public_Dictionary_2_LocalizableTextVariables_Int32_WormMatch_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_GetRevealPreview_Public_Dictionary_2_String_Int32_WormMatch_Boolean_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_HasMetCampaignRequirment_Public_Boolean_WormMatch_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_GetDarkSpaces_Public_List_1_EntityID_WormMatch_List_1_ArchetypeID_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_GetEndgamePlayableList_Public_List_1_EntityID_WormMatch_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_CanAcquireFromImperiumRow_Public_Boolean_WormMatch_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_GetUnusualSelectionsForImperiumSelections_Public_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_List_1_Entity_Boolean_Boolean_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetHintingForImperiumSelections_Public_Dictionary_2_EntityID_ReadOnlyAttributes_List_1_Entity_Boolean_Boolean_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_GetPickerAttributesForImperiumTrash_Public_MutableAttributes_List_1_Entity_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_GetPickerAttributesForImperiumDiscard_Public_MutableAttributes_List_1_Entity_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_GetPickerAttributesForImperiumSelections_Public_MutableAttributes_List_1_Entity_Boolean_Boolean_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_GetTroopSupplyUnusualSelections_Public_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_List_1_Entity_Func_2_Entity_Int32_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_get_ConflictTroops_Public_get_Int32_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_get_GarrisonTroops_Public_get_Int32_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_get_ConflictUnits_Public_get_Int32_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_get_GarrisonUnits_Public_get_Int32_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_get_ConflictDreadnoughts_Public_get_Int32_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_get_GarrisonDreadnoughts_Public_get_Int32_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_GetShippingTrackSpace_Public_Int32_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_get_TechTileCount_Public_get_Int32_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_HasTechTile_Public_Boolean_ArchetypeID_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_HasTechTileFaceUp_Public_Boolean_ArchetypeID_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDuringTurn_Public_get_Boolean_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecimens_Public_IEnumerable_1_WormUnit_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneticMarkers_Public_get_Int32_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_GetTleilaxuInfluence_Public_Int32_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_GetAcquireArchIDAndPickerKind_Public_ValueTuple_3_Boolean_ArchetypeID_String_Entity_Boolean_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_GetSnooperInfluenceLevel_Public_Int32_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPlayerTurnPadding_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_InitializeTurnTimer_Public_Virtual_Final_New_Void_Int32_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_ResetTurnTimer_Public_Virtual_Final_New_IEnumerable_1_Action_Int32_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTurnTimer_Public_Virtual_Final_New_IEnumerable_1_Action_DateTime_DateTime_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_AddExtraTimeForOpponents_Public_IEnumerable_1_Action_Int32_WormMatch_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_PadOpponentTime_Public_Virtual_Final_New_IEnumerable_1_Action_Int32_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__56_0_Private_Boolean_WormPlayerMatchInitData_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr__get_Opponents_b__63_0_Private_Boolean_WormPlayer_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr__DeferredThresholdReached_b__125_1_Private_Boolean_WormSpace_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr__GetEndgamePlayableList_b__131_0_Private_Boolean_WormIntriguePlayable_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr__GetEndgamePlayableList_b__131_4_Private_Boolean_WormAbilityDefinition_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr__GetEndgamePlayableList_b__131_2_Private_Boolean_WormTechTilePlayable_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr__GetEndgamePlayableList_b__131_5_Private_Boolean_WormAbilityDefinition_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr__CanAcquireFromImperiumRow_b__132_0_Private_Boolean_WormImperiumPlayable_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr__GetSpecimens_b__158_0_Private_Boolean_WormUnit_0;

		// Token: 0x020005A2 RID: 1442
		[ObfuscatedName("worm.canis.entities.WormPlayer+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06004539 RID: 17721 RVA: 0x00184860 File Offset: 0x00182A60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr);
				WormPlayer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9");
				WormPlayer.__c.NativeFieldInfoPtr___9__86_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__86_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__96_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__96_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__108_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__108_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__120_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__120_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__125_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__125_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__126_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__126_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__126_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__126_1");
				WormPlayer.__c.NativeFieldInfoPtr___9__126_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__126_2");
				WormPlayer.__c.NativeFieldInfoPtr___9__126_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__126_3");
				WormPlayer.__c.NativeFieldInfoPtr___9__127_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__127_1");
				WormPlayer.__c.NativeFieldInfoPtr___9__127_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__127_2");
				WormPlayer.__c.NativeFieldInfoPtr___9__128_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__128_1");
				WormPlayer.__c.NativeFieldInfoPtr___9__128_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__128_2");
				WormPlayer.__c.NativeFieldInfoPtr___9__128_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__128_3");
				WormPlayer.__c.NativeFieldInfoPtr___9__129_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__129_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__129_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__129_1");
				WormPlayer.__c.NativeFieldInfoPtr___9__129_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__129_2");
				WormPlayer.__c.NativeFieldInfoPtr___9__129_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__129_5");
				WormPlayer.__c.NativeFieldInfoPtr___9__129_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__129_6");
				WormPlayer.__c.NativeFieldInfoPtr___9__131_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__131_1");
				WormPlayer.__c.NativeFieldInfoPtr___9__131_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__131_3");
				WormPlayer.__c.NativeFieldInfoPtr___9__133_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__133_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__133_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__133_1");
				WormPlayer.__c.NativeFieldInfoPtr___9__133_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__133_2");
				WormPlayer.__c.NativeFieldInfoPtr___9__133_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__133_3");
				WormPlayer.__c.NativeFieldInfoPtr___9__134_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__134_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__134_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__134_1");
				WormPlayer.__c.NativeFieldInfoPtr___9__134_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__134_2");
				WormPlayer.__c.NativeFieldInfoPtr___9__137_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__137_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__138_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__138_1");
				WormPlayer.__c.NativeFieldInfoPtr___9__138_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__138_3");
				WormPlayer.__c.NativeFieldInfoPtr___9__140_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__140_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__142_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__142_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__144_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__144_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__146_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__146_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__148_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__148_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__150_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__150_0");
				WormPlayer.__c.NativeFieldInfoPtr___9__169_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, "<>9__169_0");
				WormPlayer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664272);
				WormPlayer.__c.NativeMethodInfoPtr__PrepareAbilityUsage_b__86_0_Internal_IEnumerable_1_WormAbilityDefinition_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664273);
				WormPlayer.__c.NativeMethodInfoPtr__get_HasImperiumCards_b__96_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664274);
				WormPlayer.__c.NativeMethodInfoPtr__get_ActiveCards_b__108_0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664275);
				WormPlayer.__c.NativeMethodInfoPtr__GetFactionTrackTargets_b__120_0_Internal_Boolean_WormFactionTrack_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664276);
				WormPlayer.__c.NativeMethodInfoPtr__DeferredThresholdReached_b__125_0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664277);
				WormPlayer.__c.NativeMethodInfoPtr__DeferredThresholdReached_b__126_0_Internal_Int32_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664278);
				WormPlayer.__c.NativeMethodInfoPtr__DeferredThresholdReached_b__126_1_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664279);
				WormPlayer.__c.NativeMethodInfoPtr__DeferredThresholdReached_b__126_2_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664280);
				WormPlayer.__c.NativeMethodInfoPtr__DeferredThresholdReached_b__126_3_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664281);
				WormPlayer.__c.NativeMethodInfoPtr__GetSkirmishScore_b__127_1_Internal_LocalizableTextVariables_SkirmishScoreItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664282);
				WormPlayer.__c.NativeMethodInfoPtr__GetSkirmishScore_b__127_2_Internal_Int32_SkirmishScoreItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664283);
				WormPlayer.__c.NativeMethodInfoPtr__GetRevealPreview_b__128_1_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664284);
				WormPlayer.__c.NativeMethodInfoPtr__GetRevealPreview_b__128_2_Internal_IEnumerable_1_RevealAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664285);
				WormPlayer.__c.NativeMethodInfoPtr__GetRevealPreview_b__128_3_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664286);
				WormPlayer.__c.NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_0_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664287);
				WormPlayer.__c.NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_1_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664288);
				WormPlayer.__c.NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_2_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664289);
				WormPlayer.__c.NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_5_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664290);
				WormPlayer.__c.NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_6_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664291);
				WormPlayer.__c.NativeMethodInfoPtr__GetEndgamePlayableList_b__131_1_Internal_EntityID_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664292);
				WormPlayer.__c.NativeMethodInfoPtr__GetEndgamePlayableList_b__131_3_Internal_EntityID_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664293);
				WormPlayer.__c.NativeMethodInfoPtr__GetUnusualSelectionsForImperiumSelections_b__133_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664294);
				WormPlayer.__c.NativeMethodInfoPtr__GetUnusualSelectionsForImperiumSelections_b__133_1_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664295);
				WormPlayer.__c.NativeMethodInfoPtr__GetUnusualSelectionsForImperiumSelections_b__133_2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664296);
				WormPlayer.__c.NativeMethodInfoPtr__GetUnusualSelectionsForImperiumSelections_b__133_3_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664297);
				WormPlayer.__c.NativeMethodInfoPtr__GetTargetHintingForImperiumSelections_b__134_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664298);
				WormPlayer.__c.NativeMethodInfoPtr__GetTargetHintingForImperiumSelections_b__134_1_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664299);
				WormPlayer.__c.NativeMethodInfoPtr__GetTargetHintingForImperiumSelections_b__134_2_Internal_ReadOnlyAttributes_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664300);
				WormPlayer.__c.NativeMethodInfoPtr__GetPickerAttributesForImperiumSelections_b__137_0_Internal_UnusualSelection_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664301);
				WormPlayer.__c.NativeMethodInfoPtr__GetTroopSupplyUnusualSelections_b__138_1_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664302);
				WormPlayer.__c.NativeMethodInfoPtr__GetTroopSupplyUnusualSelections_b__138_3_Internal_EntityID_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664303);
				WormPlayer.__c.NativeMethodInfoPtr__get_ConflictTroops_b__140_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664304);
				WormPlayer.__c.NativeMethodInfoPtr__get_GarrisonTroops_b__142_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664305);
				WormPlayer.__c.NativeMethodInfoPtr__get_ConflictUnits_b__144_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664306);
				WormPlayer.__c.NativeMethodInfoPtr__get_GarrisonUnits_b__146_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664307);
				WormPlayer.__c.NativeMethodInfoPtr__get_ConflictDreadnoughts_b__148_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664308);
				WormPlayer.__c.NativeMethodInfoPtr__get_GarrisonDreadnoughts_b__150_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664309);
				WormPlayer.__c.NativeMethodInfoPtr__AddExtraTimeForOpponents_b__169_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr, 100664310);
			}

			// Token: 0x0600453A RID: 17722 RVA: 0x00184EA4 File Offset: 0x001830A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600453B RID: 17723 RVA: 0x00184EE0 File Offset: 0x001830E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39008, XrefRangeEnd = 39012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormAbilityDefinition> _PrepareAbilityUsage_b__86_0(IHasAbilities<WormMatch, WormAbilityDefinition> a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__PrepareAbilityUsage_b__86_0_Internal_IEnumerable_1_WormAbilityDefinition_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr3) : null;
				}
			}

			// Token: 0x0600453C RID: 17724 RVA: 0x00184F30 File Offset: 0x00183130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39012, XrefRangeEnd = 39013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_HasImperiumCards_b__96_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__get_HasImperiumCards_b__96_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600453D RID: 17725 RVA: 0x00184F80 File Offset: 0x00183180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39013, XrefRangeEnd = 39018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ActiveCards_b__108_0(WormPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__get_ActiveCards_b__108_0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600453E RID: 17726 RVA: 0x00184FD0 File Offset: 0x001831D0
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFactionTrackTargets_b__120_0(WormFactionTrack x, WormPlayer y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetFactionTrackTargets_b__120_0_Internal_Boolean_WormFactionTrack_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600453F RID: 17727 RVA: 0x00185030 File Offset: 0x00183230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeferredThresholdReached_b__125_0(WormPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__DeferredThresholdReached_b__125_0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004540 RID: 17728 RVA: 0x00185080 File Offset: 0x00183280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39018, XrefRangeEnd = 39029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _DeferredThresholdReached_b__126_0(WormEntity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__DeferredThresholdReached_b__126_0_Internal_Int32_WormEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004541 RID: 17729 RVA: 0x001850D0 File Offset: 0x001832D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39029, XrefRangeEnd = 39038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeferredThresholdReached_b__126_1(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__DeferredThresholdReached_b__126_1_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004542 RID: 17730 RVA: 0x00185120 File Offset: 0x00183320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39038, XrefRangeEnd = 39039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeferredThresholdReached_b__126_2(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__DeferredThresholdReached_b__126_2_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004543 RID: 17731 RVA: 0x00185170 File Offset: 0x00183370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39039, XrefRangeEnd = 39046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeferredThresholdReached_b__126_3(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__DeferredThresholdReached_b__126_3_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004544 RID: 17732 RVA: 0x001851C0 File Offset: 0x001833C0
			[CallerCount(0)]
			public unsafe LocalizableTextVariables _GetSkirmishScore_b__127_1(SkirmishScoreItem s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetSkirmishScore_b__127_1_Internal_LocalizableTextVariables_SkirmishScoreItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr3) : null;
				}
			}

			// Token: 0x06004545 RID: 17733 RVA: 0x00185210 File Offset: 0x00183410
			[CallerCount(0)]
			public unsafe int _GetSkirmishScore_b__127_2(SkirmishScoreItem s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetSkirmishScore_b__127_2_Internal_Int32_SkirmishScoreItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004546 RID: 17734 RVA: 0x00185260 File Offset: 0x00183460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39046, XrefRangeEnd = 39051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRevealPreview_b__128_1(WormPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetRevealPreview_b__128_1_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004547 RID: 17735 RVA: 0x001852B0 File Offset: 0x001834B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39051, XrefRangeEnd = 39054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<RevealAbility> _GetRevealPreview_b__128_2(IHasAbilities<WormMatch, WormAbilityDefinition> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetRevealPreview_b__128_2_Internal_IEnumerable_1_RevealAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<RevealAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x06004548 RID: 17736 RVA: 0x00185300 File Offset: 0x00183500
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39054, XrefRangeEnd = 39063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRevealPreview_b__128_3(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetRevealPreview_b__128_3_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004549 RID: 17737 RVA: 0x00185350 File Offset: 0x00183550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _HasMetCampaignRequirment_b__129_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_0_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600454A RID: 17738 RVA: 0x001853A0 File Offset: 0x001835A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39063, XrefRangeEnd = 39064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _HasMetCampaignRequirment_b__129_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_1_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600454B RID: 17739 RVA: 0x001853F0 File Offset: 0x001835F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39064, XrefRangeEnd = 39065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasMetCampaignRequirment_b__129_2(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_2_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600454C RID: 17740 RVA: 0x00185440 File Offset: 0x00183640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39065, XrefRangeEnd = 39070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasMetCampaignRequirment_b__129_5(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_5_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600454D RID: 17741 RVA: 0x00185490 File Offset: 0x00183690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39070, XrefRangeEnd = 39086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasMetCampaignRequirment_b__129_6(WormImperiumPlayable wip)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wip);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_6_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600454E RID: 17742 RVA: 0x001854E0 File Offset: 0x001836E0
			[CallerCount(0)]
			public unsafe EntityID _GetEndgamePlayableList_b__131_1(WormIntriguePlayable intrigueCard)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(intrigueCard);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetEndgamePlayableList_b__131_1_Internal_EntityID_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600454F RID: 17743 RVA: 0x00185530 File Offset: 0x00183730
			[CallerCount(0)]
			public unsafe EntityID _GetEndgamePlayableList_b__131_3(WormTechTilePlayable techTile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(techTile);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetEndgamePlayableList_b__131_3_Internal_EntityID_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06004550 RID: 17744 RVA: 0x00185580 File Offset: 0x00183780
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39086, XrefRangeEnd = 39095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnusualSelectionsForImperiumSelections_b__133_0(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetUnusualSelectionsForImperiumSelections_b__133_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004551 RID: 17745 RVA: 0x001855D0 File Offset: 0x001837D0
			[CallerCount(0)]
			public unsafe EntityID _GetUnusualSelectionsForImperiumSelections_b__133_1(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetUnusualSelectionsForImperiumSelections_b__133_1_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06004552 RID: 17746 RVA: 0x00185620 File Offset: 0x00183820
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39095, XrefRangeEnd = 39104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnusualSelectionsForImperiumSelections_b__133_2(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetUnusualSelectionsForImperiumSelections_b__133_2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004553 RID: 17747 RVA: 0x00185670 File Offset: 0x00183870
			[CallerCount(0)]
			public unsafe EntityID _GetUnusualSelectionsForImperiumSelections_b__133_3(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetUnusualSelectionsForImperiumSelections_b__133_3_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06004554 RID: 17748 RVA: 0x001856C0 File Offset: 0x001838C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39104, XrefRangeEnd = 39113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTargetHintingForImperiumSelections_b__134_0(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetTargetHintingForImperiumSelections_b__134_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004555 RID: 17749 RVA: 0x00185710 File Offset: 0x00183910
			[CallerCount(0)]
			public unsafe EntityID _GetTargetHintingForImperiumSelections_b__134_1(Entity c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetTargetHintingForImperiumSelections_b__134_1_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06004556 RID: 17750 RVA: 0x00185760 File Offset: 0x00183960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39113, XrefRangeEnd = 39133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _GetTargetHintingForImperiumSelections_b__134_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetTargetHintingForImperiumSelections_b__134_2_Internal_ReadOnlyAttributes_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x06004557 RID: 17751 RVA: 0x001857B0 File Offset: 0x001839B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39133, XrefRangeEnd = 39139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnusualSelection _GetPickerAttributesForImperiumSelections_b__137_0(ValueTuple<LocalizableTextVariables, List<EntityID>> w)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(w));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetPickerAttributesForImperiumSelections_b__137_0_Internal_UnusualSelection_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnusualSelection>(intPtr3) : null;
				}
			}

			// Token: 0x06004558 RID: 17752 RVA: 0x00185808 File Offset: 0x00183A08
			[CallerCount(0)]
			public unsafe EntityID _GetTroopSupplyUnusualSelections_b__138_1(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetTroopSupplyUnusualSelections_b__138_1_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06004559 RID: 17753 RVA: 0x00185858 File Offset: 0x00183A58
			[CallerCount(0)]
			public unsafe EntityID _GetTroopSupplyUnusualSelections_b__138_3(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__GetTroopSupplyUnusualSelections_b__138_3_Internal_EntityID_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600455A RID: 17754 RVA: 0x001858A8 File Offset: 0x00183AA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39139, XrefRangeEnd = 39140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ConflictTroops_b__140_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__get_ConflictTroops_b__140_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600455B RID: 17755 RVA: 0x001858F8 File Offset: 0x00183AF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39140, XrefRangeEnd = 39141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_GarrisonTroops_b__142_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__get_GarrisonTroops_b__142_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600455C RID: 17756 RVA: 0x00185948 File Offset: 0x00183B48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39141, XrefRangeEnd = 39142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ConflictUnits_b__144_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__get_ConflictUnits_b__144_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600455D RID: 17757 RVA: 0x00185998 File Offset: 0x00183B98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39142, XrefRangeEnd = 39143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_GarrisonUnits_b__146_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__get_GarrisonUnits_b__146_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600455E RID: 17758 RVA: 0x001859E8 File Offset: 0x00183BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39143, XrefRangeEnd = 39144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ConflictDreadnoughts_b__148_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__get_ConflictDreadnoughts_b__148_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600455F RID: 17759 RVA: 0x00185A38 File Offset: 0x00183C38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39144, XrefRangeEnd = 39145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_GarrisonDreadnoughts_b__150_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__get_GarrisonDreadnoughts_b__150_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004560 RID: 17760 RVA: 0x00185A88 File Offset: 0x00183C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddExtraTimeForOpponents_b__169_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c.NativeMethodInfoPtr__AddExtraTimeForOpponents_b__169_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004561 RID: 17761 RVA: 0x00016F50 File Offset: 0x00015150
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001082 RID: 4226
			// (get) Token: 0x06004562 RID: 17762 RVA: 0x00185AD8 File Offset: 0x00183CD8
			// (set) Token: 0x06004563 RID: 17763 RVA: 0x00016F59 File Offset: 0x00015159
			public unsafe static WormPlayer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001083 RID: 4227
			// (get) Token: 0x06004564 RID: 17764 RVA: 0x00185B00 File Offset: 0x00183D00
			// (set) Token: 0x06004565 RID: 17765 RVA: 0x00016F6B File Offset: 0x0001516B
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<WormAbilityDefinition>> __9__86_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__86_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<WormAbilityDefinition>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__86_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001084 RID: 4228
			// (get) Token: 0x06004566 RID: 17766 RVA: 0x00185B28 File Offset: 0x00183D28
			// (set) Token: 0x06004567 RID: 17767 RVA: 0x00016F7D File Offset: 0x0001517D
			public unsafe static Func<Entity, bool> __9__96_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__96_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__96_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001085 RID: 4229
			// (get) Token: 0x06004568 RID: 17768 RVA: 0x00185B50 File Offset: 0x00183D50
			// (set) Token: 0x06004569 RID: 17769 RVA: 0x00016F8F File Offset: 0x0001518F
			public unsafe static Func<WormPlayable, bool> __9__108_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__108_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__108_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001086 RID: 4230
			// (get) Token: 0x0600456A RID: 17770 RVA: 0x00185B78 File Offset: 0x00183D78
			// (set) Token: 0x0600456B RID: 17771 RVA: 0x00016FA1 File Offset: 0x000151A1
			public unsafe static Func<WormFactionTrack, WormPlayer, bool> __9__120_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__120_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__120_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001087 RID: 4231
			// (get) Token: 0x0600456C RID: 17772 RVA: 0x00185BA0 File Offset: 0x00183DA0
			// (set) Token: 0x0600456D RID: 17773 RVA: 0x00016FB3 File Offset: 0x000151B3
			public unsafe static Func<WormPlayable, bool> __9__125_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__125_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__125_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001088 RID: 4232
			// (get) Token: 0x0600456E RID: 17774 RVA: 0x00185BC8 File Offset: 0x00183DC8
			// (set) Token: 0x0600456F RID: 17775 RVA: 0x00016FC5 File Offset: 0x000151C5
			public unsafe static Func<WormEntity, int> __9__126_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__126_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormEntity, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__126_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001089 RID: 4233
			// (get) Token: 0x06004570 RID: 17776 RVA: 0x00185BF0 File Offset: 0x00183DF0
			// (set) Token: 0x06004571 RID: 17777 RVA: 0x00016FD7 File Offset: 0x000151D7
			public unsafe static Func<WormSpace, bool> __9__126_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__126_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__126_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108A RID: 4234
			// (get) Token: 0x06004572 RID: 17778 RVA: 0x00185C18 File Offset: 0x00183E18
			// (set) Token: 0x06004573 RID: 17779 RVA: 0x00016FE9 File Offset: 0x000151E9
			public unsafe static Func<WormSpace, bool> __9__126_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__126_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__126_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108B RID: 4235
			// (get) Token: 0x06004574 RID: 17780 RVA: 0x00185C40 File Offset: 0x00183E40
			// (set) Token: 0x06004575 RID: 17781 RVA: 0x00016FFB File Offset: 0x000151FB
			public unsafe static Func<WormSpace, bool> __9__126_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__126_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__126_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108C RID: 4236
			// (get) Token: 0x06004576 RID: 17782 RVA: 0x00185C68 File Offset: 0x00183E68
			// (set) Token: 0x06004577 RID: 17783 RVA: 0x0001700D File Offset: 0x0001520D
			public unsafe static Func<SkirmishScoreItem, LocalizableTextVariables> __9__127_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__127_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SkirmishScoreItem, LocalizableTextVariables>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__127_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108D RID: 4237
			// (get) Token: 0x06004578 RID: 17784 RVA: 0x00185C90 File Offset: 0x00183E90
			// (set) Token: 0x06004579 RID: 17785 RVA: 0x0001701F File Offset: 0x0001521F
			public unsafe static Func<SkirmishScoreItem, int> __9__127_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__127_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SkirmishScoreItem, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__127_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108E RID: 4238
			// (get) Token: 0x0600457A RID: 17786 RVA: 0x00185CB8 File Offset: 0x00183EB8
			// (set) Token: 0x0600457B RID: 17787 RVA: 0x00017031 File Offset: 0x00015231
			public unsafe static Func<WormPlayable, bool> __9__128_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__128_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__128_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700108F RID: 4239
			// (get) Token: 0x0600457C RID: 17788 RVA: 0x00185CE0 File Offset: 0x00183EE0
			// (set) Token: 0x0600457D RID: 17789 RVA: 0x00017043 File Offset: 0x00015243
			public unsafe static Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<RevealAbility>> __9__128_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__128_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IHasAbilities<WormMatch, WormAbilityDefinition>, IEnumerable<RevealAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__128_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001090 RID: 4240
			// (get) Token: 0x0600457E RID: 17790 RVA: 0x00185D08 File Offset: 0x00183F08
			// (set) Token: 0x0600457F RID: 17791 RVA: 0x00017055 File Offset: 0x00015255
			public unsafe static Func<Entity, bool> __9__128_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__128_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__128_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001091 RID: 4241
			// (get) Token: 0x06004580 RID: 17792 RVA: 0x00185D30 File Offset: 0x00183F30
			// (set) Token: 0x06004581 RID: 17793 RVA: 0x00017067 File Offset: 0x00015267
			public unsafe static Func<WormPlayer, int> __9__129_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__129_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__129_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001092 RID: 4242
			// (get) Token: 0x06004582 RID: 17794 RVA: 0x00185D58 File Offset: 0x00183F58
			// (set) Token: 0x06004583 RID: 17795 RVA: 0x00017079 File Offset: 0x00015279
			public unsafe static Func<WormPlayer, int> __9__129_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__129_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__129_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001093 RID: 4243
			// (get) Token: 0x06004584 RID: 17796 RVA: 0x00185D80 File Offset: 0x00183F80
			// (set) Token: 0x06004585 RID: 17797 RVA: 0x0001708B File Offset: 0x0001528B
			public unsafe static Func<WormSpace, bool> __9__129_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__129_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__129_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001094 RID: 4244
			// (get) Token: 0x06004586 RID: 17798 RVA: 0x00185DA8 File Offset: 0x00183FA8
			// (set) Token: 0x06004587 RID: 17799 RVA: 0x0001709D File Offset: 0x0001529D
			public unsafe static Func<Entity, bool> __9__129_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__129_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__129_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001095 RID: 4245
			// (get) Token: 0x06004588 RID: 17800 RVA: 0x00185DD0 File Offset: 0x00183FD0
			// (set) Token: 0x06004589 RID: 17801 RVA: 0x000170AF File Offset: 0x000152AF
			public unsafe static Func<WormImperiumPlayable, bool> __9__129_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__129_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__129_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001096 RID: 4246
			// (get) Token: 0x0600458A RID: 17802 RVA: 0x00185DF8 File Offset: 0x00183FF8
			// (set) Token: 0x0600458B RID: 17803 RVA: 0x000170C1 File Offset: 0x000152C1
			public unsafe static Func<WormIntriguePlayable, EntityID> __9__131_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__131_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormIntriguePlayable, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__131_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001097 RID: 4247
			// (get) Token: 0x0600458C RID: 17804 RVA: 0x00185E20 File Offset: 0x00184020
			// (set) Token: 0x0600458D RID: 17805 RVA: 0x000170D3 File Offset: 0x000152D3
			public unsafe static Func<WormTechTilePlayable, EntityID> __9__131_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__131_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__131_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001098 RID: 4248
			// (get) Token: 0x0600458E RID: 17806 RVA: 0x00185E48 File Offset: 0x00184048
			// (set) Token: 0x0600458F RID: 17807 RVA: 0x000170E5 File Offset: 0x000152E5
			public unsafe static Func<Entity, bool> __9__133_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__133_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__133_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001099 RID: 4249
			// (get) Token: 0x06004590 RID: 17808 RVA: 0x00185E70 File Offset: 0x00184070
			// (set) Token: 0x06004591 RID: 17809 RVA: 0x000170F7 File Offset: 0x000152F7
			public unsafe static Func<Entity, EntityID> __9__133_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__133_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__133_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109A RID: 4250
			// (get) Token: 0x06004592 RID: 17810 RVA: 0x00185E98 File Offset: 0x00184098
			// (set) Token: 0x06004593 RID: 17811 RVA: 0x00017109 File Offset: 0x00015309
			public unsafe static Func<Entity, bool> __9__133_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__133_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__133_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109B RID: 4251
			// (get) Token: 0x06004594 RID: 17812 RVA: 0x00185EC0 File Offset: 0x001840C0
			// (set) Token: 0x06004595 RID: 17813 RVA: 0x0001711B File Offset: 0x0001531B
			public unsafe static Func<Entity, EntityID> __9__133_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__133_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__133_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109C RID: 4252
			// (get) Token: 0x06004596 RID: 17814 RVA: 0x00185EE8 File Offset: 0x001840E8
			// (set) Token: 0x06004597 RID: 17815 RVA: 0x0001712D File Offset: 0x0001532D
			public unsafe static Func<Entity, bool> __9__134_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__134_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__134_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109D RID: 4253
			// (get) Token: 0x06004598 RID: 17816 RVA: 0x00185F10 File Offset: 0x00184110
			// (set) Token: 0x06004599 RID: 17817 RVA: 0x0001713F File Offset: 0x0001533F
			public unsafe static Func<Entity, EntityID> __9__134_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__134_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__134_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109E RID: 4254
			// (get) Token: 0x0600459A RID: 17818 RVA: 0x00185F38 File Offset: 0x00184138
			// (set) Token: 0x0600459B RID: 17819 RVA: 0x00017151 File Offset: 0x00015351
			public unsafe static Func<Entity, ReadOnlyAttributes> __9__134_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__134_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, ReadOnlyAttributes>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__134_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109F RID: 4255
			// (get) Token: 0x0600459C RID: 17820 RVA: 0x00185F60 File Offset: 0x00184160
			// (set) Token: 0x0600459D RID: 17821 RVA: 0x00017163 File Offset: 0x00015363
			public unsafe static Func<ValueTuple<LocalizableTextVariables, List<EntityID>>, UnusualSelection> __9__137_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__137_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<LocalizableTextVariables, List<EntityID>>, UnusualSelection>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__137_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A0 RID: 4256
			// (get) Token: 0x0600459E RID: 17822 RVA: 0x00185F88 File Offset: 0x00184188
			// (set) Token: 0x0600459F RID: 17823 RVA: 0x00017175 File Offset: 0x00015375
			public unsafe static Func<Entity, EntityID> __9__138_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__138_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__138_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A1 RID: 4257
			// (get) Token: 0x060045A0 RID: 17824 RVA: 0x00185FB0 File Offset: 0x001841B0
			// (set) Token: 0x060045A1 RID: 17825 RVA: 0x00017187 File Offset: 0x00015387
			public unsafe static Func<Entity, EntityID> __9__138_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__138_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__138_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A2 RID: 4258
			// (get) Token: 0x060045A2 RID: 17826 RVA: 0x00185FD8 File Offset: 0x001841D8
			// (set) Token: 0x060045A3 RID: 17827 RVA: 0x00017199 File Offset: 0x00015399
			public unsafe static Func<Entity, bool> __9__140_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__140_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__140_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A3 RID: 4259
			// (get) Token: 0x060045A4 RID: 17828 RVA: 0x00186000 File Offset: 0x00184200
			// (set) Token: 0x060045A5 RID: 17829 RVA: 0x000171AB File Offset: 0x000153AB
			public unsafe static Func<Entity, bool> __9__142_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__142_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__142_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A4 RID: 4260
			// (get) Token: 0x060045A6 RID: 17830 RVA: 0x00186028 File Offset: 0x00184228
			// (set) Token: 0x060045A7 RID: 17831 RVA: 0x000171BD File Offset: 0x000153BD
			public unsafe static Func<Entity, bool> __9__144_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__144_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__144_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A5 RID: 4261
			// (get) Token: 0x060045A8 RID: 17832 RVA: 0x00186050 File Offset: 0x00184250
			// (set) Token: 0x060045A9 RID: 17833 RVA: 0x000171CF File Offset: 0x000153CF
			public unsafe static Func<Entity, bool> __9__146_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__146_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__146_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A6 RID: 4262
			// (get) Token: 0x060045AA RID: 17834 RVA: 0x00186078 File Offset: 0x00184278
			// (set) Token: 0x060045AB RID: 17835 RVA: 0x000171E1 File Offset: 0x000153E1
			public unsafe static Func<Entity, bool> __9__148_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__148_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__148_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A7 RID: 4263
			// (get) Token: 0x060045AC RID: 17836 RVA: 0x001860A0 File Offset: 0x001842A0
			// (set) Token: 0x060045AD RID: 17837 RVA: 0x000171F3 File Offset: 0x000153F3
			public unsafe static Func<Entity, bool> __9__150_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__150_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__150_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A8 RID: 4264
			// (get) Token: 0x060045AE RID: 17838 RVA: 0x001860C8 File Offset: 0x001842C8
			// (set) Token: 0x060045AF RID: 17839 RVA: 0x00017205 File Offset: 0x00015405
			public unsafe static Func<WormPlayer, bool> __9__169_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormPlayer.__c.NativeFieldInfoPtr___9__169_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormPlayer.__c.NativeFieldInfoPtr___9__169_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002DA4 RID: 11684
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002DA5 RID: 11685
			private static readonly IntPtr NativeFieldInfoPtr___9__86_0;

			// Token: 0x04002DA6 RID: 11686
			private static readonly IntPtr NativeFieldInfoPtr___9__96_0;

			// Token: 0x04002DA7 RID: 11687
			private static readonly IntPtr NativeFieldInfoPtr___9__108_0;

			// Token: 0x04002DA8 RID: 11688
			private static readonly IntPtr NativeFieldInfoPtr___9__120_0;

			// Token: 0x04002DA9 RID: 11689
			private static readonly IntPtr NativeFieldInfoPtr___9__125_0;

			// Token: 0x04002DAA RID: 11690
			private static readonly IntPtr NativeFieldInfoPtr___9__126_0;

			// Token: 0x04002DAB RID: 11691
			private static readonly IntPtr NativeFieldInfoPtr___9__126_1;

			// Token: 0x04002DAC RID: 11692
			private static readonly IntPtr NativeFieldInfoPtr___9__126_2;

			// Token: 0x04002DAD RID: 11693
			private static readonly IntPtr NativeFieldInfoPtr___9__126_3;

			// Token: 0x04002DAE RID: 11694
			private static readonly IntPtr NativeFieldInfoPtr___9__127_1;

			// Token: 0x04002DAF RID: 11695
			private static readonly IntPtr NativeFieldInfoPtr___9__127_2;

			// Token: 0x04002DB0 RID: 11696
			private static readonly IntPtr NativeFieldInfoPtr___9__128_1;

			// Token: 0x04002DB1 RID: 11697
			private static readonly IntPtr NativeFieldInfoPtr___9__128_2;

			// Token: 0x04002DB2 RID: 11698
			private static readonly IntPtr NativeFieldInfoPtr___9__128_3;

			// Token: 0x04002DB3 RID: 11699
			private static readonly IntPtr NativeFieldInfoPtr___9__129_0;

			// Token: 0x04002DB4 RID: 11700
			private static readonly IntPtr NativeFieldInfoPtr___9__129_1;

			// Token: 0x04002DB5 RID: 11701
			private static readonly IntPtr NativeFieldInfoPtr___9__129_2;

			// Token: 0x04002DB6 RID: 11702
			private static readonly IntPtr NativeFieldInfoPtr___9__129_5;

			// Token: 0x04002DB7 RID: 11703
			private static readonly IntPtr NativeFieldInfoPtr___9__129_6;

			// Token: 0x04002DB8 RID: 11704
			private static readonly IntPtr NativeFieldInfoPtr___9__131_1;

			// Token: 0x04002DB9 RID: 11705
			private static readonly IntPtr NativeFieldInfoPtr___9__131_3;

			// Token: 0x04002DBA RID: 11706
			private static readonly IntPtr NativeFieldInfoPtr___9__133_0;

			// Token: 0x04002DBB RID: 11707
			private static readonly IntPtr NativeFieldInfoPtr___9__133_1;

			// Token: 0x04002DBC RID: 11708
			private static readonly IntPtr NativeFieldInfoPtr___9__133_2;

			// Token: 0x04002DBD RID: 11709
			private static readonly IntPtr NativeFieldInfoPtr___9__133_3;

			// Token: 0x04002DBE RID: 11710
			private static readonly IntPtr NativeFieldInfoPtr___9__134_0;

			// Token: 0x04002DBF RID: 11711
			private static readonly IntPtr NativeFieldInfoPtr___9__134_1;

			// Token: 0x04002DC0 RID: 11712
			private static readonly IntPtr NativeFieldInfoPtr___9__134_2;

			// Token: 0x04002DC1 RID: 11713
			private static readonly IntPtr NativeFieldInfoPtr___9__137_0;

			// Token: 0x04002DC2 RID: 11714
			private static readonly IntPtr NativeFieldInfoPtr___9__138_1;

			// Token: 0x04002DC3 RID: 11715
			private static readonly IntPtr NativeFieldInfoPtr___9__138_3;

			// Token: 0x04002DC4 RID: 11716
			private static readonly IntPtr NativeFieldInfoPtr___9__140_0;

			// Token: 0x04002DC5 RID: 11717
			private static readonly IntPtr NativeFieldInfoPtr___9__142_0;

			// Token: 0x04002DC6 RID: 11718
			private static readonly IntPtr NativeFieldInfoPtr___9__144_0;

			// Token: 0x04002DC7 RID: 11719
			private static readonly IntPtr NativeFieldInfoPtr___9__146_0;

			// Token: 0x04002DC8 RID: 11720
			private static readonly IntPtr NativeFieldInfoPtr___9__148_0;

			// Token: 0x04002DC9 RID: 11721
			private static readonly IntPtr NativeFieldInfoPtr___9__150_0;

			// Token: 0x04002DCA RID: 11722
			private static readonly IntPtr NativeFieldInfoPtr___9__169_0;

			// Token: 0x04002DCB RID: 11723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002DCC RID: 11724
			private static readonly IntPtr NativeMethodInfoPtr__PrepareAbilityUsage_b__86_0_Internal_IEnumerable_1_WormAbilityDefinition_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002DCD RID: 11725
			private static readonly IntPtr NativeMethodInfoPtr__get_HasImperiumCards_b__96_0_Internal_Boolean_Entity_0;

			// Token: 0x04002DCE RID: 11726
			private static readonly IntPtr NativeMethodInfoPtr__get_ActiveCards_b__108_0_Internal_Boolean_WormPlayable_0;

			// Token: 0x04002DCF RID: 11727
			private static readonly IntPtr NativeMethodInfoPtr__GetFactionTrackTargets_b__120_0_Internal_Boolean_WormFactionTrack_WormPlayer_0;

			// Token: 0x04002DD0 RID: 11728
			private static readonly IntPtr NativeMethodInfoPtr__DeferredThresholdReached_b__125_0_Internal_Boolean_WormPlayable_0;

			// Token: 0x04002DD1 RID: 11729
			private static readonly IntPtr NativeMethodInfoPtr__DeferredThresholdReached_b__126_0_Internal_Int32_WormEntity_0;

			// Token: 0x04002DD2 RID: 11730
			private static readonly IntPtr NativeMethodInfoPtr__DeferredThresholdReached_b__126_1_Internal_Boolean_WormSpace_0;

			// Token: 0x04002DD3 RID: 11731
			private static readonly IntPtr NativeMethodInfoPtr__DeferredThresholdReached_b__126_2_Internal_Boolean_WormSpace_0;

			// Token: 0x04002DD4 RID: 11732
			private static readonly IntPtr NativeMethodInfoPtr__DeferredThresholdReached_b__126_3_Internal_Boolean_WormSpace_0;

			// Token: 0x04002DD5 RID: 11733
			private static readonly IntPtr NativeMethodInfoPtr__GetSkirmishScore_b__127_1_Internal_LocalizableTextVariables_SkirmishScoreItem_0;

			// Token: 0x04002DD6 RID: 11734
			private static readonly IntPtr NativeMethodInfoPtr__GetSkirmishScore_b__127_2_Internal_Int32_SkirmishScoreItem_0;

			// Token: 0x04002DD7 RID: 11735
			private static readonly IntPtr NativeMethodInfoPtr__GetRevealPreview_b__128_1_Internal_Boolean_WormPlayable_0;

			// Token: 0x04002DD8 RID: 11736
			private static readonly IntPtr NativeMethodInfoPtr__GetRevealPreview_b__128_2_Internal_IEnumerable_1_RevealAbility_IHasAbilities_2_WormMatch_WormAbilityDefinition_0;

			// Token: 0x04002DD9 RID: 11737
			private static readonly IntPtr NativeMethodInfoPtr__GetRevealPreview_b__128_3_Internal_Boolean_Entity_0;

			// Token: 0x04002DDA RID: 11738
			private static readonly IntPtr NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_0_Internal_Int32_WormPlayer_0;

			// Token: 0x04002DDB RID: 11739
			private static readonly IntPtr NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_1_Internal_Int32_WormPlayer_0;

			// Token: 0x04002DDC RID: 11740
			private static readonly IntPtr NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_2_Internal_Boolean_WormSpace_0;

			// Token: 0x04002DDD RID: 11741
			private static readonly IntPtr NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_5_Internal_Boolean_Entity_0;

			// Token: 0x04002DDE RID: 11742
			private static readonly IntPtr NativeMethodInfoPtr__HasMetCampaignRequirment_b__129_6_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04002DDF RID: 11743
			private static readonly IntPtr NativeMethodInfoPtr__GetEndgamePlayableList_b__131_1_Internal_EntityID_WormIntriguePlayable_0;

			// Token: 0x04002DE0 RID: 11744
			private static readonly IntPtr NativeMethodInfoPtr__GetEndgamePlayableList_b__131_3_Internal_EntityID_WormTechTilePlayable_0;

			// Token: 0x04002DE1 RID: 11745
			private static readonly IntPtr NativeMethodInfoPtr__GetUnusualSelectionsForImperiumSelections_b__133_0_Internal_Boolean_Entity_0;

			// Token: 0x04002DE2 RID: 11746
			private static readonly IntPtr NativeMethodInfoPtr__GetUnusualSelectionsForImperiumSelections_b__133_1_Internal_EntityID_Entity_0;

			// Token: 0x04002DE3 RID: 11747
			private static readonly IntPtr NativeMethodInfoPtr__GetUnusualSelectionsForImperiumSelections_b__133_2_Internal_Boolean_Entity_0;

			// Token: 0x04002DE4 RID: 11748
			private static readonly IntPtr NativeMethodInfoPtr__GetUnusualSelectionsForImperiumSelections_b__133_3_Internal_EntityID_Entity_0;

			// Token: 0x04002DE5 RID: 11749
			private static readonly IntPtr NativeMethodInfoPtr__GetTargetHintingForImperiumSelections_b__134_0_Internal_Boolean_Entity_0;

			// Token: 0x04002DE6 RID: 11750
			private static readonly IntPtr NativeMethodInfoPtr__GetTargetHintingForImperiumSelections_b__134_1_Internal_EntityID_Entity_0;

			// Token: 0x04002DE7 RID: 11751
			private static readonly IntPtr NativeMethodInfoPtr__GetTargetHintingForImperiumSelections_b__134_2_Internal_ReadOnlyAttributes_Entity_0;

			// Token: 0x04002DE8 RID: 11752
			private static readonly IntPtr NativeMethodInfoPtr__GetPickerAttributesForImperiumSelections_b__137_0_Internal_UnusualSelection_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_0;

			// Token: 0x04002DE9 RID: 11753
			private static readonly IntPtr NativeMethodInfoPtr__GetTroopSupplyUnusualSelections_b__138_1_Internal_EntityID_Entity_0;

			// Token: 0x04002DEA RID: 11754
			private static readonly IntPtr NativeMethodInfoPtr__GetTroopSupplyUnusualSelections_b__138_3_Internal_EntityID_Entity_0;

			// Token: 0x04002DEB RID: 11755
			private static readonly IntPtr NativeMethodInfoPtr__get_ConflictTroops_b__140_0_Internal_Boolean_Entity_0;

			// Token: 0x04002DEC RID: 11756
			private static readonly IntPtr NativeMethodInfoPtr__get_GarrisonTroops_b__142_0_Internal_Boolean_Entity_0;

			// Token: 0x04002DED RID: 11757
			private static readonly IntPtr NativeMethodInfoPtr__get_ConflictUnits_b__144_0_Internal_Boolean_Entity_0;

			// Token: 0x04002DEE RID: 11758
			private static readonly IntPtr NativeMethodInfoPtr__get_GarrisonUnits_b__146_0_Internal_Boolean_Entity_0;

			// Token: 0x04002DEF RID: 11759
			private static readonly IntPtr NativeMethodInfoPtr__get_ConflictDreadnoughts_b__148_0_Internal_Boolean_Entity_0;

			// Token: 0x04002DF0 RID: 11760
			private static readonly IntPtr NativeMethodInfoPtr__get_GarrisonDreadnoughts_b__150_0_Internal_Boolean_Entity_0;

			// Token: 0x04002DF1 RID: 11761
			private static readonly IntPtr NativeMethodInfoPtr__AddExtraTimeForOpponents_b__169_0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x020005A3 RID: 1443
		[ObfuscatedName("worm.canis.entities.WormPlayer+<>c__DisplayClass119_0")]
		public sealed class __c__DisplayClass119_0 : Object
		{
			// Token: 0x060045B0 RID: 17840 RVA: 0x001860F0 File Offset: 0x001842F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass119_0()
			{
				Il2CppClassPointerStore<WormPlayer.__c__DisplayClass119_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<>c__DisplayClass119_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass119_0>.NativeClassPtr);
				WormPlayer.__c__DisplayClass119_0.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass119_0>.NativeClassPtr, "faction");
				WormPlayer.__c__DisplayClass119_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass119_0>.NativeClassPtr, 100664311);
				WormPlayer.__c__DisplayClass119_0.NativeMethodInfoPtr__InAlliance_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass119_0>.NativeClassPtr, 100664312);
			}

			// Token: 0x060045B1 RID: 17841 RVA: 0x00186158 File Offset: 0x00184358
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass119_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass119_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass119_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045B2 RID: 17842 RVA: 0x00186194 File Offset: 0x00184394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39145, XrefRangeEnd = 39149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InAlliance_b__0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass119_0.NativeMethodInfoPtr__InAlliance_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045B3 RID: 17843 RVA: 0x00017217 File Offset: 0x00015417
			public __c__DisplayClass119_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010A9 RID: 4265
			// (get) Token: 0x060045B4 RID: 17844 RVA: 0x001861E4 File Offset: 0x001843E4
			// (set) Token: 0x060045B5 RID: 17845 RVA: 0x00017220 File Offset: 0x00015420
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass119_0.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass119_0.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x04002DF2 RID: 11762
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x04002DF3 RID: 11763
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002DF4 RID: 11764
			private static readonly IntPtr NativeMethodInfoPtr__InAlliance_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x020005A4 RID: 1444
		[ObfuscatedName("worm.canis.entities.WormPlayer+<>c__DisplayClass121_0")]
		public sealed class __c__DisplayClass121_0 : Object
		{
			// Token: 0x060045B6 RID: 17846 RVA: 0x0018620C File Offset: 0x0018440C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass121_0()
			{
				Il2CppClassPointerStore<WormPlayer.__c__DisplayClass121_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<>c__DisplayClass121_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass121_0>.NativeClassPtr);
				WormPlayer.__c__DisplayClass121_0.NativeFieldInfoPtr_filter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass121_0>.NativeClassPtr, "filter");
				WormPlayer.__c__DisplayClass121_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass121_0>.NativeClassPtr, "<>4__this");
				WormPlayer.__c__DisplayClass121_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass121_0>.NativeClassPtr, 100664313);
				WormPlayer.__c__DisplayClass121_0.NativeMethodInfoPtr__GetFactionTrackTargets_b__0_Internal_Boolean_WormFactionTrack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass121_0>.NativeClassPtr, 100664314);
			}

			// Token: 0x060045B7 RID: 17847 RVA: 0x00186288 File Offset: 0x00184488
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass121_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass121_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass121_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045B8 RID: 17848 RVA: 0x001862C4 File Offset: 0x001844C4
			[CallerCount(0)]
			public unsafe bool _GetFactionTrackTargets_b__0(WormFactionTrack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass121_0.NativeMethodInfoPtr__GetFactionTrackTargets_b__0_Internal_Boolean_WormFactionTrack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045B9 RID: 17849 RVA: 0x0001723B File Offset: 0x0001543B
			public __c__DisplayClass121_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010AA RID: 4266
			// (get) Token: 0x060045BA RID: 17850 RVA: 0x00186314 File Offset: 0x00184514
			// (set) Token: 0x060045BB RID: 17851 RVA: 0x00017244 File Offset: 0x00015444
			public unsafe Func<WormFactionTrack, WormPlayer, bool> filter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass121_0.NativeFieldInfoPtr_filter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass121_0.NativeFieldInfoPtr_filter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010AB RID: 4267
			// (get) Token: 0x060045BC RID: 17852 RVA: 0x00186344 File Offset: 0x00184544
			// (set) Token: 0x060045BD RID: 17853 RVA: 0x00017263 File Offset: 0x00015463
			public unsafe WormPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass121_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass121_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002DF5 RID: 11765
			private static readonly IntPtr NativeFieldInfoPtr_filter;

			// Token: 0x04002DF6 RID: 11766
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002DF7 RID: 11767
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002DF8 RID: 11768
			private static readonly IntPtr NativeMethodInfoPtr__GetFactionTrackTargets_b__0_Internal_Boolean_WormFactionTrack_0;
		}

		// Token: 0x020005A5 RID: 1445
		[ObfuscatedName("worm.canis.entities.WormPlayer+<>c__DisplayClass127_0")]
		public sealed class __c__DisplayClass127_0 : Object
		{
			// Token: 0x060045BE RID: 17854 RVA: 0x00186374 File Offset: 0x00184574
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass127_0()
			{
				Il2CppClassPointerStore<WormPlayer.__c__DisplayClass127_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<>c__DisplayClass127_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass127_0>.NativeClassPtr);
				WormPlayer.__c__DisplayClass127_0.NativeFieldInfoPtr_skirmishScoringMethodsIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass127_0>.NativeClassPtr, "skirmishScoringMethodsIDs");
				WormPlayer.__c__DisplayClass127_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass127_0>.NativeClassPtr, 100664315);
				WormPlayer.__c__DisplayClass127_0.NativeMethodInfoPtr__GetSkirmishScore_b__0_Internal_Boolean_SkirmishScoringMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass127_0>.NativeClassPtr, 100664316);
			}

			// Token: 0x060045BF RID: 17855 RVA: 0x001863DC File Offset: 0x001845DC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass127_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass127_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass127_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045C0 RID: 17856 RVA: 0x00186418 File Offset: 0x00184618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39149, XrefRangeEnd = 39153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetSkirmishScore_b__0(SkirmishScoringMethod _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass127_0.NativeMethodInfoPtr__GetSkirmishScore_b__0_Internal_Boolean_SkirmishScoringMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045C1 RID: 17857 RVA: 0x00017282 File Offset: 0x00015482
			public __c__DisplayClass127_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010AC RID: 4268
			// (get) Token: 0x060045C2 RID: 17858 RVA: 0x00186468 File Offset: 0x00184668
			// (set) Token: 0x060045C3 RID: 17859 RVA: 0x0001728B File Offset: 0x0001548B
			public unsafe List<int> skirmishScoringMethodsIDs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass127_0.NativeFieldInfoPtr_skirmishScoringMethodsIDs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass127_0.NativeFieldInfoPtr_skirmishScoringMethodsIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002DF9 RID: 11769
			private static readonly IntPtr NativeFieldInfoPtr_skirmishScoringMethodsIDs;

			// Token: 0x04002DFA RID: 11770
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002DFB RID: 11771
			private static readonly IntPtr NativeMethodInfoPtr__GetSkirmishScore_b__0_Internal_Boolean_SkirmishScoringMethod_0;
		}

		// Token: 0x020005A6 RID: 1446
		[ObfuscatedName("worm.canis.entities.WormPlayer+<>c__DisplayClass128_0")]
		public sealed class __c__DisplayClass128_0 : Object
		{
			// Token: 0x060045C4 RID: 17860 RVA: 0x00186498 File Offset: 0x00184698
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass128_0()
			{
				Il2CppClassPointerStore<WormPlayer.__c__DisplayClass128_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<>c__DisplayClass128_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass128_0>.NativeClassPtr);
				WormPlayer.__c__DisplayClass128_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass128_0>.NativeClassPtr, "<>4__this");
				WormPlayer.__c__DisplayClass128_0.NativeFieldInfoPtr_chairdogReturnCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass128_0>.NativeClassPtr, "chairdogReturnCards");
				WormPlayer.__c__DisplayClass128_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass128_0>.NativeClassPtr, 100664317);
				WormPlayer.__c__DisplayClass128_0.NativeMethodInfoPtr__GetRevealPreview_b__4_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass128_0>.NativeClassPtr, 100664318);
				WormPlayer.__c__DisplayClass128_0.NativeMethodInfoPtr__GetRevealPreview_b__5_Internal_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass128_0>.NativeClassPtr, 100664319);
				WormPlayer.__c__DisplayClass128_0.NativeMethodInfoPtr__GetRevealPreview_b__6_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass128_0>.NativeClassPtr, 100664320);
				WormPlayer.__c__DisplayClass128_0.NativeMethodInfoPtr__GetRevealPreview_b__0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass128_0>.NativeClassPtr, 100664321);
			}

			// Token: 0x060045C5 RID: 17861 RVA: 0x00186550 File Offset: 0x00184750
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass128_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass128_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass128_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045C6 RID: 17862 RVA: 0x0018658C File Offset: 0x0018478C
			[CallerCount(0)]
			public unsafe bool _GetRevealPreview_b__4(WormAgent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass128_0.NativeMethodInfoPtr__GetRevealPreview_b__4_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045C7 RID: 17863 RVA: 0x001865DC File Offset: 0x001847DC
			[CallerCount(0)]
			public unsafe bool _GetRevealPreview_b__5(WormAgent _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass128_0.NativeMethodInfoPtr__GetRevealPreview_b__5_Internal_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045C8 RID: 17864 RVA: 0x0018662C File Offset: 0x0018482C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39153, XrefRangeEnd = 39154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRevealPreview_b__6(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass128_0.NativeMethodInfoPtr__GetRevealPreview_b__6_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045C9 RID: 17865 RVA: 0x0018667C File Offset: 0x0018487C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39154, XrefRangeEnd = 39158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRevealPreview_b__0(WormPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass128_0.NativeMethodInfoPtr__GetRevealPreview_b__0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045CA RID: 17866 RVA: 0x000172AA File Offset: 0x000154AA
			public __c__DisplayClass128_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010AD RID: 4269
			// (get) Token: 0x060045CB RID: 17867 RVA: 0x001866CC File Offset: 0x001848CC
			// (set) Token: 0x060045CC RID: 17868 RVA: 0x000172B3 File Offset: 0x000154B3
			public unsafe WormPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass128_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass128_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010AE RID: 4270
			// (get) Token: 0x060045CD RID: 17869 RVA: 0x001866FC File Offset: 0x001848FC
			// (set) Token: 0x060045CE RID: 17870 RVA: 0x000172D2 File Offset: 0x000154D2
			public unsafe List<EntityID> chairdogReturnCards
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass128_0.NativeFieldInfoPtr_chairdogReturnCards);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass128_0.NativeFieldInfoPtr_chairdogReturnCards), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002DFC RID: 11772
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002DFD RID: 11773
			private static readonly IntPtr NativeFieldInfoPtr_chairdogReturnCards;

			// Token: 0x04002DFE RID: 11774
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002DFF RID: 11775
			private static readonly IntPtr NativeMethodInfoPtr__GetRevealPreview_b__4_Internal_Boolean_WormAgent_0;

			// Token: 0x04002E00 RID: 11776
			private static readonly IntPtr NativeMethodInfoPtr__GetRevealPreview_b__5_Internal_Boolean_WormAgent_0;

			// Token: 0x04002E01 RID: 11777
			private static readonly IntPtr NativeMethodInfoPtr__GetRevealPreview_b__6_Internal_Boolean_WormSpace_0;

			// Token: 0x04002E02 RID: 11778
			private static readonly IntPtr NativeMethodInfoPtr__GetRevealPreview_b__0_Internal_Boolean_WormPlayable_0;
		}

		// Token: 0x020005A7 RID: 1447
		[ObfuscatedName("worm.canis.entities.WormPlayer+<>c__DisplayClass129_0")]
		public sealed class __c__DisplayClass129_0 : Object
		{
			// Token: 0x060045CF RID: 17871 RVA: 0x0018672C File Offset: 0x0018492C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass129_0()
			{
				Il2CppClassPointerStore<WormPlayer.__c__DisplayClass129_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<>c__DisplayClass129_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass129_0>.NativeClassPtr);
				WormPlayer.__c__DisplayClass129_0.NativeFieldInfoPtr_visitedSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass129_0>.NativeClassPtr, "visitedSpaces");
				WormPlayer.__c__DisplayClass129_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass129_0>.NativeClassPtr, 100664322);
				WormPlayer.__c__DisplayClass129_0.NativeMethodInfoPtr__HasMetCampaignRequirment_b__3_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass129_0>.NativeClassPtr, 100664323);
				WormPlayer.__c__DisplayClass129_0.NativeMethodInfoPtr__HasMetCampaignRequirment_b__4_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass129_0>.NativeClassPtr, 100664324);
			}

			// Token: 0x060045D0 RID: 17872 RVA: 0x001867A8 File Offset: 0x001849A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass129_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass129_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass129_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045D1 RID: 17873 RVA: 0x001867E4 File Offset: 0x001849E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39158, XrefRangeEnd = 39163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasMetCampaignRequirment_b__3(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass129_0.NativeMethodInfoPtr__HasMetCampaignRequirment_b__3_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045D2 RID: 17874 RVA: 0x00186834 File Offset: 0x00184A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39163, XrefRangeEnd = 39168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasMetCampaignRequirment_b__4(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass129_0.NativeMethodInfoPtr__HasMetCampaignRequirment_b__4_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045D3 RID: 17875 RVA: 0x000172F1 File Offset: 0x000154F1
			public __c__DisplayClass129_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010AF RID: 4271
			// (get) Token: 0x060045D4 RID: 17876 RVA: 0x00186884 File Offset: 0x00184A84
			// (set) Token: 0x060045D5 RID: 17877 RVA: 0x000172FA File Offset: 0x000154FA
			public unsafe Dictionary<ArchetypeID, int> visitedSpaces
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass129_0.NativeFieldInfoPtr_visitedSpaces);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ArchetypeID, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass129_0.NativeFieldInfoPtr_visitedSpaces), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E03 RID: 11779
			private static readonly IntPtr NativeFieldInfoPtr_visitedSpaces;

			// Token: 0x04002E04 RID: 11780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E05 RID: 11781
			private static readonly IntPtr NativeMethodInfoPtr__HasMetCampaignRequirment_b__3_Internal_Boolean_WormSpace_0;

			// Token: 0x04002E06 RID: 11782
			private static readonly IntPtr NativeMethodInfoPtr__HasMetCampaignRequirment_b__4_Internal_Boolean_WormSpace_0;
		}

		// Token: 0x020005A8 RID: 1448
		[ObfuscatedName("worm.canis.entities.WormPlayer+<>c__DisplayClass132_0")]
		public sealed class __c__DisplayClass132_0 : Object
		{
			// Token: 0x060045D6 RID: 17878 RVA: 0x001868B4 File Offset: 0x00184AB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass132_0()
			{
				Il2CppClassPointerStore<WormPlayer.__c__DisplayClass132_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<>c__DisplayClass132_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass132_0>.NativeClassPtr);
				WormPlayer.__c__DisplayClass132_0.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass132_0>.NativeClassPtr, "card");
				WormPlayer.__c__DisplayClass132_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass132_0>.NativeClassPtr, 100664325);
				WormPlayer.__c__DisplayClass132_0.NativeMethodInfoPtr__CanAcquireFromImperiumRow_b__1_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass132_0>.NativeClassPtr, 100664326);
			}

			// Token: 0x060045D7 RID: 17879 RVA: 0x0018691C File Offset: 0x00184B1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass132_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass132_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass132_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045D8 RID: 17880 RVA: 0x00186958 File Offset: 0x00184B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39168, XrefRangeEnd = 39172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanAcquireFromImperiumRow_b__1(Factions faction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref faction;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass132_0.NativeMethodInfoPtr__CanAcquireFromImperiumRow_b__1_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045D9 RID: 17881 RVA: 0x00017319 File Offset: 0x00015519
			public __c__DisplayClass132_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010B0 RID: 4272
			// (get) Token: 0x060045DA RID: 17882 RVA: 0x001869A4 File Offset: 0x00184BA4
			// (set) Token: 0x060045DB RID: 17883 RVA: 0x00017322 File Offset: 0x00015522
			public unsafe WormImperiumPlayable card
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass132_0.NativeFieldInfoPtr_card);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass132_0.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E07 RID: 11783
			private static readonly IntPtr NativeFieldInfoPtr_card;

			// Token: 0x04002E08 RID: 11784
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E09 RID: 11785
			private static readonly IntPtr NativeMethodInfoPtr__CanAcquireFromImperiumRow_b__1_Internal_Boolean_Factions_0;
		}

		// Token: 0x020005A9 RID: 1449
		[ObfuscatedName("worm.canis.entities.WormPlayer+<>c__DisplayClass138_0")]
		public sealed class __c__DisplayClass138_0 : Object
		{
			// Token: 0x060045DC RID: 17884 RVA: 0x001869D4 File Offset: 0x00184BD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass138_0()
			{
				Il2CppClassPointerStore<WormPlayer.__c__DisplayClass138_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<>c__DisplayClass138_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass138_0>.NativeClassPtr);
				WormPlayer.__c__DisplayClass138_0.NativeFieldInfoPtr_troopCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass138_0>.NativeClassPtr, "troopCounter");
				WormPlayer.__c__DisplayClass138_0.NativeFieldInfoPtr_supplyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass138_0>.NativeClassPtr, "supplyCount");
				WormPlayer.__c__DisplayClass138_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass138_0>.NativeClassPtr, 100664327);
				WormPlayer.__c__DisplayClass138_0.NativeMethodInfoPtr__GetTroopSupplyUnusualSelections_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass138_0>.NativeClassPtr, 100664328);
				WormPlayer.__c__DisplayClass138_0.NativeMethodInfoPtr__GetTroopSupplyUnusualSelections_b__2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass138_0>.NativeClassPtr, 100664329);
			}

			// Token: 0x060045DD RID: 17885 RVA: 0x00186A64 File Offset: 0x00184C64
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass138_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass138_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass138_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045DE RID: 17886 RVA: 0x00186AA0 File Offset: 0x00184CA0
			[CallerCount(0)]
			public unsafe bool _GetTroopSupplyUnusualSelections_b__0(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass138_0.NativeMethodInfoPtr__GetTroopSupplyUnusualSelections_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045DF RID: 17887 RVA: 0x00186AF0 File Offset: 0x00184CF0
			[CallerCount(0)]
			public unsafe bool _GetTroopSupplyUnusualSelections_b__2(Entity e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass138_0.NativeMethodInfoPtr__GetTroopSupplyUnusualSelections_b__2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045E0 RID: 17888 RVA: 0x00017341 File Offset: 0x00015541
			public __c__DisplayClass138_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010B1 RID: 4273
			// (get) Token: 0x060045E1 RID: 17889 RVA: 0x00186B40 File Offset: 0x00184D40
			// (set) Token: 0x060045E2 RID: 17890 RVA: 0x0001734A File Offset: 0x0001554A
			public unsafe Func<Entity, int> troopCounter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass138_0.NativeFieldInfoPtr_troopCounter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass138_0.NativeFieldInfoPtr_troopCounter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B2 RID: 4274
			// (get) Token: 0x060045E3 RID: 17891 RVA: 0x00186B70 File Offset: 0x00184D70
			// (set) Token: 0x060045E4 RID: 17892 RVA: 0x00017369 File Offset: 0x00015569
			public unsafe int supplyCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass138_0.NativeFieldInfoPtr_supplyCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass138_0.NativeFieldInfoPtr_supplyCount)) = value;
				}
			}

			// Token: 0x04002E0A RID: 11786
			private static readonly IntPtr NativeFieldInfoPtr_troopCounter;

			// Token: 0x04002E0B RID: 11787
			private static readonly IntPtr NativeFieldInfoPtr_supplyCount;

			// Token: 0x04002E0C RID: 11788
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E0D RID: 11789
			private static readonly IntPtr NativeMethodInfoPtr__GetTroopSupplyUnusualSelections_b__0_Internal_Boolean_Entity_0;

			// Token: 0x04002E0E RID: 11790
			private static readonly IntPtr NativeMethodInfoPtr__GetTroopSupplyUnusualSelections_b__2_Internal_Boolean_Entity_0;
		}

		// Token: 0x020005AA RID: 1450
		[ObfuscatedName("worm.canis.entities.WormPlayer+<>c__DisplayClass154_0")]
		public sealed class __c__DisplayClass154_0 : Object
		{
			// Token: 0x060045E5 RID: 17893 RVA: 0x00186B98 File Offset: 0x00184D98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass154_0()
			{
				Il2CppClassPointerStore<WormPlayer.__c__DisplayClass154_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<>c__DisplayClass154_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass154_0>.NativeClassPtr);
				WormPlayer.__c__DisplayClass154_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass154_0>.NativeClassPtr, "archID");
				WormPlayer.__c__DisplayClass154_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass154_0>.NativeClassPtr, 100664330);
				WormPlayer.__c__DisplayClass154_0.NativeMethodInfoPtr__HasTechTile_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass154_0>.NativeClassPtr, 100664331);
			}

			// Token: 0x060045E6 RID: 17894 RVA: 0x00186C00 File Offset: 0x00184E00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass154_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass154_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass154_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045E7 RID: 17895 RVA: 0x00186C3C File Offset: 0x00184E3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39172, XrefRangeEnd = 39177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasTechTile_b__0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass154_0.NativeMethodInfoPtr__HasTechTile_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045E8 RID: 17896 RVA: 0x00017384 File Offset: 0x00015584
			public __c__DisplayClass154_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010B3 RID: 4275
			// (get) Token: 0x060045E9 RID: 17897 RVA: 0x00186C8C File Offset: 0x00184E8C
			// (set) Token: 0x060045EA RID: 17898 RVA: 0x0001738D File Offset: 0x0001558D
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass154_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass154_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E0F RID: 11791
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x04002E10 RID: 11792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E11 RID: 11793
			private static readonly IntPtr NativeMethodInfoPtr__HasTechTile_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x020005AB RID: 1451
		[ObfuscatedName("worm.canis.entities.WormPlayer+<>c__DisplayClass155_0")]
		public sealed class __c__DisplayClass155_0 : Object
		{
			// Token: 0x060045EB RID: 17899 RVA: 0x00186CBC File Offset: 0x00184EBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass155_0()
			{
				Il2CppClassPointerStore<WormPlayer.__c__DisplayClass155_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<>c__DisplayClass155_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass155_0>.NativeClassPtr);
				WormPlayer.__c__DisplayClass155_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass155_0>.NativeClassPtr, "archID");
				WormPlayer.__c__DisplayClass155_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass155_0>.NativeClassPtr, 100664332);
				WormPlayer.__c__DisplayClass155_0.NativeMethodInfoPtr__HasTechTileFaceUp_b__0_Internal_Boolean_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass155_0>.NativeClassPtr, 100664333);
			}

			// Token: 0x060045EC RID: 17900 RVA: 0x00186D24 File Offset: 0x00184F24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass155_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass155_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass155_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045ED RID: 17901 RVA: 0x00186D60 File Offset: 0x00184F60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39177, XrefRangeEnd = 39182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasTechTileFaceUp_b__0(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass155_0.NativeMethodInfoPtr__HasTechTileFaceUp_b__0_Internal_Boolean_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045EE RID: 17902 RVA: 0x000173AC File Offset: 0x000155AC
			public __c__DisplayClass155_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010B4 RID: 4276
			// (get) Token: 0x060045EF RID: 17903 RVA: 0x00186DB0 File Offset: 0x00184FB0
			// (set) Token: 0x060045F0 RID: 17904 RVA: 0x000173B5 File Offset: 0x000155B5
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass155_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass155_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E12 RID: 11794
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x04002E13 RID: 11795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E14 RID: 11796
			private static readonly IntPtr NativeMethodInfoPtr__HasTechTileFaceUp_b__0_Internal_Boolean_WormTechTilePlayable_0;
		}

		// Token: 0x020005AC RID: 1452
		[ObfuscatedName("worm.canis.entities.WormPlayer+<>c__DisplayClass97_0")]
		public sealed class __c__DisplayClass97_0 : Object
		{
			// Token: 0x060045F1 RID: 17905 RVA: 0x00186DE0 File Offset: 0x00184FE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass97_0()
			{
				Il2CppClassPointerStore<WormPlayer.__c__DisplayClass97_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<>c__DisplayClass97_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass97_0>.NativeClassPtr);
				WormPlayer.__c__DisplayClass97_0.NativeFieldInfoPtr_archID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass97_0>.NativeClassPtr, "archID");
				WormPlayer.__c__DisplayClass97_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass97_0>.NativeClassPtr, 100664334);
				WormPlayer.__c__DisplayClass97_0.NativeMethodInfoPtr__HasIntrigueCard_b__0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass97_0>.NativeClassPtr, 100664335);
			}

			// Token: 0x060045F2 RID: 17906 RVA: 0x00186E48 File Offset: 0x00185048
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass97_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer.__c__DisplayClass97_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass97_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045F3 RID: 17907 RVA: 0x00186E84 File Offset: 0x00185084
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39182, XrefRangeEnd = 39236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _HasIntrigueCard_b__0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer.__c__DisplayClass97_0.NativeMethodInfoPtr__HasIntrigueCard_b__0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060045F4 RID: 17908 RVA: 0x000173D4 File Offset: 0x000155D4
			public __c__DisplayClass97_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010B5 RID: 4277
			// (get) Token: 0x060045F5 RID: 17909 RVA: 0x00186ED4 File Offset: 0x001850D4
			// (set) Token: 0x060045F6 RID: 17910 RVA: 0x000173DD File Offset: 0x000155DD
			public unsafe ArchetypeID archID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass97_0.NativeFieldInfoPtr_archID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer.__c__DisplayClass97_0.NativeFieldInfoPtr_archID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E15 RID: 11797
			private static readonly IntPtr NativeFieldInfoPtr_archID;

			// Token: 0x04002E16 RID: 11798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E17 RID: 11799
			private static readonly IntPtr NativeMethodInfoPtr__HasIntrigueCard_b__0_Internal_Boolean_Entity_0;
		}

		// Token: 0x020005AD RID: 1453
		[ObfuscatedName("worm.canis.entities.WormPlayer+<AddExtraTimeForOpponents>d__169")]
		public sealed class _AddExtraTimeForOpponents_d__169 : Object
		{
			// Token: 0x060045F7 RID: 17911 RVA: 0x00186F04 File Offset: 0x00185104
			// Note: this type is marked as 'beforefieldinit'.
			static _AddExtraTimeForOpponents_d__169()
			{
				Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<AddExtraTimeForOpponents>d__169");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr);
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, "<>1__state");
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, "<>2__current");
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, "<>l__initialThreadId");
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr_seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, "seconds");
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___3__seconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, "<>3__seconds");
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, "wormMatch");
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___3__wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, "<>3__wormMatch");
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, "<>4__this");
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, 100664336);
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, 100664337);
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, 100664338);
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, 100664339);
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, 100664340);
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, 100664341);
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, 100664342);
				WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr, 100664343);
			}

			// Token: 0x060045F8 RID: 17912 RVA: 0x00187070 File Offset: 0x00185270
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AddExtraTimeForOpponents_d__169(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer._AddExtraTimeForOpponents_d__169>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060045F9 RID: 17913 RVA: 0x001870B8 File Offset: 0x001852B8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060045FA RID: 17914 RVA: 0x001870EC File Offset: 0x001852EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39236, XrefRangeEnd = 39270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170010BE RID: 4286
			// (get) Token: 0x060045FB RID: 17915 RVA: 0x00187128 File Offset: 0x00185328
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060045FC RID: 17916 RVA: 0x00187168 File Offset: 0x00185368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39270, XrefRangeEnd = 39275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010BF RID: 4287
			// (get) Token: 0x060045FD RID: 17917 RVA: 0x0018719C File Offset: 0x0018539C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060045FE RID: 17918 RVA: 0x001871DC File Offset: 0x001853DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39275, XrefRangeEnd = 39284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060045FF RID: 17919 RVA: 0x0018721C File Offset: 0x0018541C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._AddExtraTimeForOpponents_d__169.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004600 RID: 17920 RVA: 0x000173FC File Offset: 0x000155FC
			public _AddExtraTimeForOpponents_d__169(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010B6 RID: 4278
			// (get) Token: 0x06004601 RID: 17921 RVA: 0x0018725C File Offset: 0x0018545C
			// (set) Token: 0x06004602 RID: 17922 RVA: 0x00017405 File Offset: 0x00015605
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010B7 RID: 4279
			// (get) Token: 0x06004603 RID: 17923 RVA: 0x00187284 File Offset: 0x00185484
			// (set) Token: 0x06004604 RID: 17924 RVA: 0x00017420 File Offset: 0x00015620
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B8 RID: 4280
			// (get) Token: 0x06004605 RID: 17925 RVA: 0x001872B4 File Offset: 0x001854B4
			// (set) Token: 0x06004606 RID: 17926 RVA: 0x0001743F File Offset: 0x0001563F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170010B9 RID: 4281
			// (get) Token: 0x06004607 RID: 17927 RVA: 0x001872DC File Offset: 0x001854DC
			// (set) Token: 0x06004608 RID: 17928 RVA: 0x0001745A File Offset: 0x0001565A
			public unsafe int seconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr_seconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr_seconds)) = value;
				}
			}

			// Token: 0x170010BA RID: 4282
			// (get) Token: 0x06004609 RID: 17929 RVA: 0x00187304 File Offset: 0x00185504
			// (set) Token: 0x0600460A RID: 17930 RVA: 0x00017475 File Offset: 0x00015675
			public unsafe int __3__seconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___3__seconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___3__seconds)) = value;
				}
			}

			// Token: 0x170010BB RID: 4283
			// (get) Token: 0x0600460B RID: 17931 RVA: 0x0018732C File Offset: 0x0018552C
			// (set) Token: 0x0600460C RID: 17932 RVA: 0x00017490 File Offset: 0x00015690
			public unsafe WormMatch wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr_wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010BC RID: 4284
			// (get) Token: 0x0600460D RID: 17933 RVA: 0x0018735C File Offset: 0x0018555C
			// (set) Token: 0x0600460E RID: 17934 RVA: 0x000174AF File Offset: 0x000156AF
			public unsafe WormMatch __3__wormMatch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___3__wormMatch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___3__wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010BD RID: 4285
			// (get) Token: 0x0600460F RID: 17935 RVA: 0x0018738C File Offset: 0x0018558C
			// (set) Token: 0x06004610 RID: 17936 RVA: 0x000174CE File Offset: 0x000156CE
			public unsafe WormPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._AddExtraTimeForOpponents_d__169.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E18 RID: 11800
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002E19 RID: 11801
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002E1A RID: 11802
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002E1B RID: 11803
			private static readonly IntPtr NativeFieldInfoPtr_seconds;

			// Token: 0x04002E1C RID: 11804
			private static readonly IntPtr NativeFieldInfoPtr___3__seconds;

			// Token: 0x04002E1D RID: 11805
			private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

			// Token: 0x04002E1E RID: 11806
			private static readonly IntPtr NativeFieldInfoPtr___3__wormMatch;

			// Token: 0x04002E1F RID: 11807
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002E20 RID: 11808
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002E21 RID: 11809
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E22 RID: 11810
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002E23 RID: 11811
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002E24 RID: 11812
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E25 RID: 11813
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002E26 RID: 11814
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002E27 RID: 11815
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020005AE RID: 1454
		[ObfuscatedName("worm.canis.entities.WormPlayer+<MakeEmptyResponse>d__88")]
		public sealed class _MakeEmptyResponse_d__88 : Object
		{
			// Token: 0x06004611 RID: 17937 RVA: 0x001873BC File Offset: 0x001855BC
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeEmptyResponse_d__88()
			{
				Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<MakeEmptyResponse>d__88");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr);
				WormPlayer._MakeEmptyResponse_d__88.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr, "<>1__state");
				WormPlayer._MakeEmptyResponse_d__88.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr, "<>2__current");
				WormPlayer._MakeEmptyResponse_d__88.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr, "<>l__initialThreadId");
				WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr, 100664344);
				WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr, 100664345);
				WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr, 100664346);
				WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetresponse_TargetResponse__get_Current_Private_Virtual_Final_New_get_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr, 100664347);
				WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr, 100664348);
				WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr, 100664349);
				WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetresponse_TargetResponse__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr, 100664350);
				WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr, 100664351);
			}

			// Token: 0x06004612 RID: 17938 RVA: 0x001874C4 File Offset: 0x001856C4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeEmptyResponse_d__88(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer._MakeEmptyResponse_d__88>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004613 RID: 17939 RVA: 0x0018750C File Offset: 0x0018570C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004614 RID: 17940 RVA: 0x00187540 File Offset: 0x00185740
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170010C3 RID: 4291
			// (get) Token: 0x06004615 RID: 17941 RVA: 0x0018757C File Offset: 0x0018577C
			public unsafe TargetResponse System.Collections.Generic.IEnumerator<Networking.selection.targetresponse.TargetResponse>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetresponse_TargetResponse__get_Current_Private_Virtual_Final_New_get_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr3) : null;
				}
			}

			// Token: 0x06004616 RID: 17942 RVA: 0x001875BC File Offset: 0x001857BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39284, XrefRangeEnd = 39289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010C4 RID: 4292
			// (get) Token: 0x06004617 RID: 17943 RVA: 0x001875F0 File Offset: 0x001857F0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004618 RID: 17944 RVA: 0x00187630 File Offset: 0x00185830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39289, XrefRangeEnd = 39291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetResponse> System_Collections_Generic_IEnumerable_Networking_selection_targetresponse_TargetResponse__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetresponse_TargetResponse__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetResponse>>(intPtr3) : null;
			}

			// Token: 0x06004619 RID: 17945 RVA: 0x00187670 File Offset: 0x00185870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._MakeEmptyResponse_d__88.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600461A RID: 17946 RVA: 0x000174ED File Offset: 0x000156ED
			public _MakeEmptyResponse_d__88(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010C0 RID: 4288
			// (get) Token: 0x0600461B RID: 17947 RVA: 0x001876B0 File Offset: 0x001858B0
			// (set) Token: 0x0600461C RID: 17948 RVA: 0x000174F6 File Offset: 0x000156F6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._MakeEmptyResponse_d__88.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._MakeEmptyResponse_d__88.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010C1 RID: 4289
			// (get) Token: 0x0600461D RID: 17949 RVA: 0x001876D8 File Offset: 0x001858D8
			// (set) Token: 0x0600461E RID: 17950 RVA: 0x00017511 File Offset: 0x00015711
			public unsafe TargetResponse __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._MakeEmptyResponse_d__88.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._MakeEmptyResponse_d__88.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010C2 RID: 4290
			// (get) Token: 0x0600461F RID: 17951 RVA: 0x00187708 File Offset: 0x00185908
			// (set) Token: 0x06004620 RID: 17952 RVA: 0x00017530 File Offset: 0x00015730
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._MakeEmptyResponse_d__88.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._MakeEmptyResponse_d__88.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04002E28 RID: 11816
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002E29 RID: 11817
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002E2A RID: 11818
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002E2B RID: 11819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002E2C RID: 11820
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E2D RID: 11821
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002E2E RID: 11822
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetresponse_TargetResponse__get_Current_Private_Virtual_Final_New_get_TargetResponse_0;

			// Token: 0x04002E2F RID: 11823
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E30 RID: 11824
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002E31 RID: 11825
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetresponse_TargetResponse__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetResponse_0;

			// Token: 0x04002E32 RID: 11826
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020005AF RID: 1455
		[ObfuscatedName("worm.canis.entities.WormPlayer+<PadOpponentTime>d__170")]
		public sealed class _PadOpponentTime_d__170 : Object
		{
			// Token: 0x06004621 RID: 17953 RVA: 0x00187730 File Offset: 0x00185930
			// Note: this type is marked as 'beforefieldinit'.
			static _PadOpponentTime_d__170()
			{
				Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<PadOpponentTime>d__170");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr);
				WormPlayer._PadOpponentTime_d__170.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr, "<>1__state");
				WormPlayer._PadOpponentTime_d__170.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr, "<>2__current");
				WormPlayer._PadOpponentTime_d__170.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr, "<>l__initialThreadId");
				WormPlayer._PadOpponentTime_d__170.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr, "<>4__this");
				WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr, 100664352);
				WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr, 100664353);
				WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr, 100664354);
				WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr, 100664355);
				WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr, 100664356);
				WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr, 100664357);
				WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr, 100664358);
				WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr, 100664359);
			}

			// Token: 0x06004622 RID: 17954 RVA: 0x0018784C File Offset: 0x00185A4C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PadOpponentTime_d__170(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer._PadOpponentTime_d__170>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004623 RID: 17955 RVA: 0x00187894 File Offset: 0x00185A94
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004624 RID: 17956 RVA: 0x001878C8 File Offset: 0x00185AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39291, XrefRangeEnd = 39296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170010C9 RID: 4297
			// (get) Token: 0x06004625 RID: 17957 RVA: 0x00187904 File Offset: 0x00185B04
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06004626 RID: 17958 RVA: 0x00187944 File Offset: 0x00185B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39296, XrefRangeEnd = 39301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010CA RID: 4298
			// (get) Token: 0x06004627 RID: 17959 RVA: 0x00187978 File Offset: 0x00185B78
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06004628 RID: 17960 RVA: 0x001879B8 File Offset: 0x00185BB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39301, XrefRangeEnd = 39303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06004629 RID: 17961 RVA: 0x001879F8 File Offset: 0x00185BF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._PadOpponentTime_d__170.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600462A RID: 17962 RVA: 0x0001754B File Offset: 0x0001574B
			public _PadOpponentTime_d__170(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010C5 RID: 4293
			// (get) Token: 0x0600462B RID: 17963 RVA: 0x00187A38 File Offset: 0x00185C38
			// (set) Token: 0x0600462C RID: 17964 RVA: 0x00017554 File Offset: 0x00015754
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._PadOpponentTime_d__170.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._PadOpponentTime_d__170.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010C6 RID: 4294
			// (get) Token: 0x0600462D RID: 17965 RVA: 0x00187A60 File Offset: 0x00185C60
			// (set) Token: 0x0600462E RID: 17966 RVA: 0x0001756F File Offset: 0x0001576F
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._PadOpponentTime_d__170.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._PadOpponentTime_d__170.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010C7 RID: 4295
			// (get) Token: 0x0600462F RID: 17967 RVA: 0x00187A90 File Offset: 0x00185C90
			// (set) Token: 0x06004630 RID: 17968 RVA: 0x0001758E File Offset: 0x0001578E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._PadOpponentTime_d__170.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._PadOpponentTime_d__170.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170010C8 RID: 4296
			// (get) Token: 0x06004631 RID: 17969 RVA: 0x00187AB8 File Offset: 0x00185CB8
			// (set) Token: 0x06004632 RID: 17970 RVA: 0x000175A9 File Offset: 0x000157A9
			public unsafe WormPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._PadOpponentTime_d__170.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._PadOpponentTime_d__170.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E33 RID: 11827
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002E34 RID: 11828
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002E35 RID: 11829
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002E36 RID: 11830
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002E37 RID: 11831
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002E38 RID: 11832
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E39 RID: 11833
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002E3A RID: 11834
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002E3B RID: 11835
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E3C RID: 11836
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002E3D RID: 11837
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002E3E RID: 11838
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020005B0 RID: 1456
		[ObfuscatedName("worm.canis.entities.WormPlayer+<ResetTurnTimer>d__167")]
		public sealed class _ResetTurnTimer_d__167 : Object
		{
			// Token: 0x06004633 RID: 17971 RVA: 0x00187AE8 File Offset: 0x00185CE8
			// Note: this type is marked as 'beforefieldinit'.
			static _ResetTurnTimer_d__167()
			{
				Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<ResetTurnTimer>d__167");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr);
				WormPlayer._ResetTurnTimer_d__167.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr, "<>1__state");
				WormPlayer._ResetTurnTimer_d__167.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr, "<>2__current");
				WormPlayer._ResetTurnTimer_d__167.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr, "<>l__initialThreadId");
				WormPlayer._ResetTurnTimer_d__167.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr, "<>4__this");
				WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr, 100664360);
				WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr, 100664361);
				WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr, 100664362);
				WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr, 100664363);
				WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr, 100664364);
				WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr, 100664365);
				WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr, 100664366);
				WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr, 100664367);
			}

			// Token: 0x06004634 RID: 17972 RVA: 0x00187C04 File Offset: 0x00185E04
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResetTurnTimer_d__167(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer._ResetTurnTimer_d__167>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004635 RID: 17973 RVA: 0x00187C4C File Offset: 0x00185E4C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004636 RID: 17974 RVA: 0x00187C80 File Offset: 0x00185E80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39303, XrefRangeEnd = 39411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170010CF RID: 4303
			// (get) Token: 0x06004637 RID: 17975 RVA: 0x00187CBC File Offset: 0x00185EBC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06004638 RID: 17976 RVA: 0x00187CFC File Offset: 0x00185EFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39411, XrefRangeEnd = 39416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010D0 RID: 4304
			// (get) Token: 0x06004639 RID: 17977 RVA: 0x00187D30 File Offset: 0x00185F30
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600463A RID: 17978 RVA: 0x00187D70 File Offset: 0x00185F70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39416, XrefRangeEnd = 39418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600463B RID: 17979 RVA: 0x00187DB0 File Offset: 0x00185FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._ResetTurnTimer_d__167.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600463C RID: 17980 RVA: 0x000175C8 File Offset: 0x000157C8
			public _ResetTurnTimer_d__167(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010CB RID: 4299
			// (get) Token: 0x0600463D RID: 17981 RVA: 0x00187DF0 File Offset: 0x00185FF0
			// (set) Token: 0x0600463E RID: 17982 RVA: 0x000175D1 File Offset: 0x000157D1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._ResetTurnTimer_d__167.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._ResetTurnTimer_d__167.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010CC RID: 4300
			// (get) Token: 0x0600463F RID: 17983 RVA: 0x00187E18 File Offset: 0x00186018
			// (set) Token: 0x06004640 RID: 17984 RVA: 0x000175EC File Offset: 0x000157EC
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._ResetTurnTimer_d__167.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._ResetTurnTimer_d__167.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010CD RID: 4301
			// (get) Token: 0x06004641 RID: 17985 RVA: 0x00187E48 File Offset: 0x00186048
			// (set) Token: 0x06004642 RID: 17986 RVA: 0x0001760B File Offset: 0x0001580B
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._ResetTurnTimer_d__167.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._ResetTurnTimer_d__167.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170010CE RID: 4302
			// (get) Token: 0x06004643 RID: 17987 RVA: 0x00187E70 File Offset: 0x00186070
			// (set) Token: 0x06004644 RID: 17988 RVA: 0x00017626 File Offset: 0x00015826
			public unsafe WormPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._ResetTurnTimer_d__167.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._ResetTurnTimer_d__167.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E3F RID: 11839
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002E40 RID: 11840
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002E41 RID: 11841
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002E42 RID: 11842
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002E43 RID: 11843
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002E44 RID: 11844
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E45 RID: 11845
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002E46 RID: 11846
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002E47 RID: 11847
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E48 RID: 11848
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002E49 RID: 11849
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002E4A RID: 11850
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020005B1 RID: 1457
		[ObfuscatedName("worm.canis.entities.WormPlayer+<SelectFrom>d__87")]
		public sealed class _SelectFrom_d__87 : Object
		{
			// Token: 0x06004645 RID: 17989 RVA: 0x00187EA0 File Offset: 0x001860A0
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectFrom_d__87()
			{
				Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<SelectFrom>d__87");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr);
				WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr, "<>1__state");
				WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr, "<>2__current");
				WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr, "<>4__this");
				WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr, "selection");
				WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr__responseMessage_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr, "<responseMessage>5__2");
				WormPlayer._SelectFrom_d__87.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr, 100664368);
				WormPlayer._SelectFrom_d__87.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr, 100664369);
				WormPlayer._SelectFrom_d__87.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr, 100664370);
				WormPlayer._SelectFrom_d__87.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr, 100664371);
				WormPlayer._SelectFrom_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr, 100664372);
				WormPlayer._SelectFrom_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr, 100664373);
			}

			// Token: 0x06004646 RID: 17990 RVA: 0x00187FA8 File Offset: 0x001861A8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39418, XrefRangeEnd = 39419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectFrom_d__87(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer._SelectFrom_d__87>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._SelectFrom_d__87.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004647 RID: 17991 RVA: 0x00187FF0 File Offset: 0x001861F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._SelectFrom_d__87.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004648 RID: 17992 RVA: 0x00188024 File Offset: 0x00186224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39492, XrefRangeEnd = 39515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._SelectFrom_d__87.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170010D6 RID: 4310
			// (get) Token: 0x06004649 RID: 17993 RVA: 0x00188060 File Offset: 0x00186260
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._SelectFrom_d__87.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600464A RID: 17994 RVA: 0x001880A0 File Offset: 0x001862A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39515, XrefRangeEnd = 39520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._SelectFrom_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010D7 RID: 4311
			// (get) Token: 0x0600464B RID: 17995 RVA: 0x001880D4 File Offset: 0x001862D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._SelectFrom_d__87.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600464C RID: 17996 RVA: 0x00017645 File Offset: 0x00015845
			public _SelectFrom_d__87(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010D1 RID: 4305
			// (get) Token: 0x0600464D RID: 17997 RVA: 0x00188114 File Offset: 0x00186314
			// (set) Token: 0x0600464E RID: 17998 RVA: 0x0001764E File Offset: 0x0001584E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010D2 RID: 4306
			// (get) Token: 0x0600464F RID: 17999 RVA: 0x0018813C File Offset: 0x0018633C
			// (set) Token: 0x06004650 RID: 18000 RVA: 0x00017669 File Offset: 0x00015869
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D3 RID: 4307
			// (get) Token: 0x06004651 RID: 18001 RVA: 0x0018816C File Offset: 0x0018636C
			// (set) Token: 0x06004652 RID: 18002 RVA: 0x00017688 File Offset: 0x00015888
			public unsafe WormPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D4 RID: 4308
			// (get) Token: 0x06004653 RID: 18003 RVA: 0x0018819C File Offset: 0x0018639C
			// (set) Token: 0x06004654 RID: 18004 RVA: 0x000176A7 File Offset: 0x000158A7
			public unsafe SelectionMessage selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr_selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010D5 RID: 4309
			// (get) Token: 0x06004655 RID: 18005 RVA: 0x001881CC File Offset: 0x001863CC
			// (set) Token: 0x06004656 RID: 18006 RVA: 0x000176C6 File Offset: 0x000158C6
			public unsafe ISelectionCounter _responseMessage_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr__responseMessage_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionCounter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._SelectFrom_d__87.NativeFieldInfoPtr__responseMessage_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E4B RID: 11851
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002E4C RID: 11852
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002E4D RID: 11853
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002E4E RID: 11854
			private static readonly IntPtr NativeFieldInfoPtr_selection;

			// Token: 0x04002E4F RID: 11855
			private static readonly IntPtr NativeFieldInfoPtr__responseMessage_5__2;

			// Token: 0x04002E50 RID: 11856
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002E51 RID: 11857
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E52 RID: 11858
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002E53 RID: 11859
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002E54 RID: 11860
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E55 RID: 11861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020005B2 RID: 1458
		[ObfuscatedName("worm.canis.entities.WormPlayer+<UpdateTurnTimer>d__168")]
		public sealed class _UpdateTurnTimer_d__168 : Object
		{
			// Token: 0x06004657 RID: 18007 RVA: 0x001881FC File Offset: 0x001863FC
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdateTurnTimer_d__168()
			{
				Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlayer>.NativeClassPtr, "<UpdateTurnTimer>d__168");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr);
				WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, "<>1__state");
				WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, "<>2__current");
				WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, "<>l__initialThreadId");
				WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, "<>4__this");
				WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr_endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, "endTime");
				WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___3__endTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, "<>3__endTime");
				WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr_startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, "startTime");
				WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___3__startTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, "<>3__startTime");
				WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, 100664374);
				WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, 100664375);
				WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, 100664376);
				WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, 100664377);
				WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, 100664378);
				WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, 100664379);
				WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, 100664380);
				WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr, 100664381);
			}

			// Token: 0x06004658 RID: 18008 RVA: 0x00188368 File Offset: 0x00186568
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UpdateTurnTimer_d__168(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayer._UpdateTurnTimer_d__168>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004659 RID: 18009 RVA: 0x001883B0 File Offset: 0x001865B0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600465A RID: 18010 RVA: 0x001883E4 File Offset: 0x001865E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39520, XrefRangeEnd = 39571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170010E0 RID: 4320
			// (get) Token: 0x0600465B RID: 18011 RVA: 0x00188420 File Offset: 0x00186620
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600465C RID: 18012 RVA: 0x00188460 File Offset: 0x00186660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39571, XrefRangeEnd = 39576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170010E1 RID: 4321
			// (get) Token: 0x0600465D RID: 18013 RVA: 0x00188494 File Offset: 0x00186694
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600465E RID: 18014 RVA: 0x001884D4 File Offset: 0x001866D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39576, XrefRangeEnd = 39584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600465F RID: 18015 RVA: 0x00188514 File Offset: 0x00186714
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayer._UpdateTurnTimer_d__168.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06004660 RID: 18016 RVA: 0x000176E5 File Offset: 0x000158E5
			public _UpdateTurnTimer_d__168(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170010D8 RID: 4312
			// (get) Token: 0x06004661 RID: 18017 RVA: 0x00188554 File Offset: 0x00186754
			// (set) Token: 0x06004662 RID: 18018 RVA: 0x000176EE File Offset: 0x000158EE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170010D9 RID: 4313
			// (get) Token: 0x06004663 RID: 18019 RVA: 0x0018857C File Offset: 0x0018677C
			// (set) Token: 0x06004664 RID: 18020 RVA: 0x00017709 File Offset: 0x00015909
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010DA RID: 4314
			// (get) Token: 0x06004665 RID: 18021 RVA: 0x001885AC File Offset: 0x001867AC
			// (set) Token: 0x06004666 RID: 18022 RVA: 0x00017728 File Offset: 0x00015928
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170010DB RID: 4315
			// (get) Token: 0x06004667 RID: 18023 RVA: 0x001885D4 File Offset: 0x001867D4
			// (set) Token: 0x06004668 RID: 18024 RVA: 0x00017743 File Offset: 0x00015943
			public unsafe WormPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010DC RID: 4316
			// (get) Token: 0x06004669 RID: 18025 RVA: 0x00188604 File Offset: 0x00186804
			// (set) Token: 0x0600466A RID: 18026 RVA: 0x00017762 File Offset: 0x00015962
			public unsafe DateTime endTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr_endTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr_endTime)) = value;
				}
			}

			// Token: 0x170010DD RID: 4317
			// (get) Token: 0x0600466B RID: 18027 RVA: 0x0018862C File Offset: 0x0018682C
			// (set) Token: 0x0600466C RID: 18028 RVA: 0x0001777D File Offset: 0x0001597D
			public unsafe DateTime __3__endTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___3__endTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___3__endTime)) = value;
				}
			}

			// Token: 0x170010DE RID: 4318
			// (get) Token: 0x0600466D RID: 18029 RVA: 0x00188654 File Offset: 0x00186854
			// (set) Token: 0x0600466E RID: 18030 RVA: 0x00017798 File Offset: 0x00015998
			public unsafe DateTime startTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr_startTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr_startTime)) = value;
				}
			}

			// Token: 0x170010DF RID: 4319
			// (get) Token: 0x0600466F RID: 18031 RVA: 0x0018867C File Offset: 0x0018687C
			// (set) Token: 0x06004670 RID: 18032 RVA: 0x000177B3 File Offset: 0x000159B3
			public unsafe DateTime __3__startTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___3__startTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayer._UpdateTurnTimer_d__168.NativeFieldInfoPtr___3__startTime)) = value;
				}
			}

			// Token: 0x04002E56 RID: 11862
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002E57 RID: 11863
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002E58 RID: 11864
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002E59 RID: 11865
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002E5A RID: 11866
			private static readonly IntPtr NativeFieldInfoPtr_endTime;

			// Token: 0x04002E5B RID: 11867
			private static readonly IntPtr NativeFieldInfoPtr___3__endTime;

			// Token: 0x04002E5C RID: 11868
			private static readonly IntPtr NativeFieldInfoPtr_startTime;

			// Token: 0x04002E5D RID: 11869
			private static readonly IntPtr NativeFieldInfoPtr___3__startTime;

			// Token: 0x04002E5E RID: 11870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002E5F RID: 11871
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E60 RID: 11872
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002E61 RID: 11873
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04002E62 RID: 11874
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002E63 RID: 11875
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002E64 RID: 11876
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04002E65 RID: 11877
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020005B3 RID: 1459
		private sealed class MethodInfoStoreGeneric_GetNextUnits_Public_IEnumerable_1_Entity_Int32_0<T>
		{
			// Token: 0x04002E66 RID: 11878
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(WormPlayer.NativeMethodInfoPtr_GetNextUnits_Public_IEnumerable_1_Entity_Int32_0, Il2CppClassPointerStore<WormPlayer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005B4 RID: 1460
		private sealed class MethodInfoStoreGeneric_GetNextGarrisonUnits_Public_IEnumerable_1_T_Int32_0<T>
		{
			// Token: 0x04002E67 RID: 11879
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(WormPlayer.NativeMethodInfoPtr_GetNextGarrisonUnits_Public_IEnumerable_1_T_Int32_0, Il2CppClassPointerStore<WormPlayer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005B5 RID: 1461
		private sealed class MethodInfoStoreGeneric_GetGarrisonUnits_Public_List_1_T_0<T>
		{
			// Token: 0x04002E68 RID: 11880
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(WormPlayer.NativeMethodInfoPtr_GetGarrisonUnits_Public_List_1_T_0, Il2CppClassPointerStore<WormPlayer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
