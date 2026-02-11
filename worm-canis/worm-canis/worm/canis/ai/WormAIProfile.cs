using System;
using Canis;
using Canis.attributes;
using Canis.entities;
using Canis.entities.ai;
using Canis.selectionfilters;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using Networking.selection.messages;
using Networking.selection.messages.outgoing;
using Networking.selection.targetresponse;
using worm.canis.abilities;
using worm.canis.abilities.PlayAbilities;
using worm.canis.abilities.TriggeredAbilities;
using worm.canis.ai.choices;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.ai
{
	// Token: 0x02000217 RID: 535
	public class WormAIProfile : AIProfileAbs
	{
		// Token: 0x06001742 RID: 5954 RVA: 0x000B264C File Offset: 0x000B084C
		// Note: this type is marked as 'beforefieldinit'.
		static WormAIProfile()
		{
			Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.ai", "WormAIProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr);
			WormAIProfile.NativeFieldInfoPtr_WormPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "WormPlayer");
			WormAIProfile.NativeFieldInfoPtr_WormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "WormMatch");
			WormAIProfile.NativeFieldInfoPtr__isClimax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "_isClimax");
			WormAIProfile.NativeFieldInfoPtr__cachedBuyGains = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "_cachedBuyGains");
			WormAIProfile.NativeMethodInfoPtr_get_Match_Protected_Virtual_get_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667072);
			WormAIProfile.NativeMethodInfoPtr_get_Player_Protected_Virtual_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667073);
			WormAIProfile.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667074);
			WormAIProfile.NativeMethodInfoPtr_get_Constants_Public_get_AIConstantsRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667075);
			WormAIProfile.NativeMethodInfoPtr_IsPredeterminedSelection_Public_Boolean_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667076);
			WormAIProfile.NativeMethodInfoPtr_MakeChoice_Public_Virtual_New_ISelectionCounter_SelectionMessage_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667077);
			WormAIProfile.NativeMethodInfoPtr_get_DefaultValueSummer_Public_Static_get_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667078);
			WormAIProfile.NativeMethodInfoPtr_get_PossiblePersuasion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667079);
			WormAIProfile.NativeMethodInfoPtr_PredictCardBuys_Public_IEnumerable_1_WormImperiumPlayable_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667080);
			WormAIProfile.NativeMethodInfoPtr_get_DeckAgentIcons_Public_get_Dictionary_2_AgentIcons_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667081);
			WormAIProfile.NativeMethodInfoPtr_get_IsClimax_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667082);
			WormAIProfile.NativeMethodInfoPtr_get_IsFinalRound_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667083);
			WormAIProfile.NativeMethodInfoPtr_GetGameArc_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667084);
			WormAIProfile.NativeMethodInfoPtr_get_ValuesDict_Private_get_Dictionary_2_AttributeDefinition_1_Nullable_1_Int32_IEnumerable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667085);
			WormAIProfile.NativeMethodInfoPtr_get_AbundanceThresholdDict_Private_get_Dictionary_2_AttributeDefinition_1_Nullable_1_Int32_IEnumerable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667086);
			WormAIProfile.NativeMethodInfoPtr_GetResourceValue_Public_Double_AttributeDefinition_1_Nullable_1_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667087);
			WormAIProfile.NativeMethodInfoPtr_SelectForGameArc_Private_Double_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667088);
			WormAIProfile.NativeMethodInfoPtr_get_CardDrawValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667089);
			WormAIProfile.NativeMethodInfoPtr_get_IntrigueValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667090);
			WormAIProfile.NativeMethodInfoPtr_get_TrashCardValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667091);
			WormAIProfile.NativeMethodInfoPtr_get_MinimumAcquireValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667092);
			WormAIProfile.NativeMethodInfoPtr_TrashMod_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667093);
			WormAIProfile.NativeMethodInfoPtr_DeployValue_Public_Double_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667094);
			WormAIProfile.NativeMethodInfoPtr_get_SwordmasterValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667095);
			WormAIProfile.NativeMethodInfoPtr_get_HighCouncilValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667096);
			WormAIProfile.NativeMethodInfoPtr_get_FoldspaceValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667097);
			WormAIProfile.NativeMethodInfoPtr_get_MentatValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667098);
			WormAIProfile.NativeMethodInfoPtr_get_ControlSolariValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667099);
			WormAIProfile.NativeMethodInfoPtr_get_ControlSpiceValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667100);
			WormAIProfile.NativeMethodInfoPtr_GetBuyGains_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667101);
			WormAIProfile.NativeMethodInfoPtr_GetBuyValue_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667102);
			WormAIProfile.NativeMethodInfoPtr_CurrentConflictInterest_Public_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667103);
			WormAIProfile.NativeMethodInfoPtr_get_ConflictCompetitors_Private_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667104);
			WormAIProfile.NativeMethodInfoPtr_get_ConflictPostureBounds_Public_get_ValueTuple_2_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667105);
			WormAIProfile.NativeMethodInfoPtr_GetCombatPositioning_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667106);
			WormAIProfile.NativeMethodInfoPtr_GetCombatPostureMod_Public_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667107);
			WormAIProfile.NativeMethodInfoPtr_RelativeConflictValue_Public_AIValueSummer_1_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667108);
			WormAIProfile.NativeMethodInfoPtr_IntrigueHandStrengthValue_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667109);
			WormAIProfile.NativeMethodInfoPtr_EstOpponentStrength_Public_AIValueSummer_1_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667110);
			WormAIProfile.NativeMethodInfoPtr_EstStrength_Public_AIValueSummer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667111);
			WormAIProfile.NativeMethodInfoPtr_PotentialStrength_Public_AIValueSummer_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667112);
			WormAIProfile.NativeMethodInfoPtr_GetVictoryPointValue_Public_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667113);
			WormAIProfile.NativeMethodInfoPtr_GetGainInfluenceValue_Public_AIValueSummer_1_Double_Factions_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667114);
			WormAIProfile.NativeMethodInfoPtr_GetBestInfluenceExchange_Public_ValueTuple_3_Factions_Factions_Double_Int32_Int32_Boolean_List_1_Factions_List_1_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667115);
			WormAIProfile.NativeMethodInfoPtr_GetSynergyMod_Public_AIValueSummer_1_Double_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667116);
			WormAIProfile.NativeMethodInfoPtr_GetFriendshipMod_Public_AIValueSummer_1_Double_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667117);
			WormAIProfile.NativeMethodInfoPtr_GetAcquireEffectsValue_Public_AIValueSummer_1_Double_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667118);
			WormAIProfile.NativeMethodInfoPtr_GetSpecificAcquireBonus_Public_AIValueSummer_1_Double_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667119);
			WormAIProfile.NativeMethodInfoPtr_GetUnitsToDeploy_Public_List_1_WormUnit_List_1_WormUnit_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667120);
			WormAIProfile.NativeMethodInfoPtr_GetTroopsToRetreat_Public_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667121);
			WormAIProfile.NativeMethodInfoPtr_OpponentRatio_Public_Double_Func_2_WormPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667122);
			WormAIProfile.NativeMethodInfoPtr_EstimatedConflictRank_Public_Nullable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667123);
			WormAIProfile.NativeMethodInfoPtr_CurrentConflictRank_Public_Nullable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667124);
			WormAIProfile.NativeMethodInfoPtr_GetConflictRank_Private_Nullable_1_Int32_Func_2_WormPlayer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667125);
			WormAIProfile.NativeMethodInfoPtr_GetCurrentCombatOrder_Public_List_1_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667126);
			WormAIProfile.NativeMethodInfoPtr_GetExpectedCombatOrder_Public_List_1_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667127);
			WormAIProfile.NativeMethodInfoPtr_GetExpectedCombatOrderWithStrength_Public_List_1_Tuple_2_WormPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667128);
			WormAIProfile.NativeMethodInfoPtr_GetSpiceForSellMelange_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667129);
			WormAIProfile.NativeMethodInfoPtr_CanAgentAbilityBePlayedWithSpaceCost_Public_Boolean_WormSpace_AttributeDefinition_1_Nullable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667130);
			WormAIProfile.NativeMethodInfoPtr_GetCardToTrash_Public_ValueTuple_2_WormImperiumPlayable_Double_IEnumerable_1_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667131);
			WormAIProfile.NativeMethodInfoPtr_GetHeighlinerPotentialPlayer_Public_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667132);
			WormAIProfile.NativeMethodInfoPtr_HasHighlinerPotential_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667133);
			WormAIProfile.NativeMethodInfoPtr_HasHighlinerPotential_Public_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667134);
			WormAIProfile.NativeMethodInfoPtr_PossiblePersuasionGain_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667135);
			WormAIProfile.NativeMethodInfoPtr_GetBestOption_Public_ValueTuple_3_WormImperiumPlayable_WormSpace_Double_IEnumerable_1_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667136);
			WormAIProfile.NativeMethodInfoPtr_HasTurnBeforeOpponentNextRound_Public_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667137);
			WormAIProfile.NativeMethodInfoPtr_get_IsSolariShort_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667138);
			WormAIProfile.NativeMethodInfoPtr_get_IsSolariLong_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667139);
			WormAIProfile.NativeMethodInfoPtr_get_IsSpiceShort_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667140);
			WormAIProfile.NativeMethodInfoPtr_get_IsTroopShort_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667141);
			WormAIProfile.NativeMethodInfoPtr_get_IsWaterLong_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667142);
			WormAIProfile.NativeMethodInfoPtr_get_GetBadIntrigueCardsInHand_Public_get_List_1_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667143);
			WormAIProfile.NativeMethodInfoPtr_get_NegotiateTechValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667144);
			WormAIProfile.NativeMethodInfoPtr_get_DiscardValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667145);
			WormAIProfile.NativeMethodInfoPtr_get_FreighterValue_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667146);
			WormAIProfile.NativeMethodInfoPtr_BuyTechValue_Public_Double_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667147);
			WormAIProfile.NativeMethodInfoPtr_TechTileToAcquire_Public_WormTechTilePlayable_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667148);
			WormAIProfile.NativeMethodInfoPtr_TechOptionsMod_Public_Double_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667149);
			WormAIProfile.NativeMethodInfoPtr_GetFreighterSelections_Public_ValueTuple_3_Int32_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667150);
			WormAIProfile.NativeMethodInfoPtr_ResearchValue_Public_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667151);
			WormAIProfile.NativeMethodInfoPtr_TleilaxuValue_Public_AIValueSummer_1_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667152);
			WormAIProfile.NativeMethodInfoPtr__GetResourceValue_b__28_0_Private_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667153);
			WormAIProfile.NativeMethodInfoPtr__GetResourceValue_b__28_2_Private_AIValueSummer_1_Double_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667154);
			WormAIProfile.NativeMethodInfoPtr__GetBuyGains_b__53_0_Private_Double_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667155);
			WormAIProfile.NativeMethodInfoPtr__GetBuyGains_b__53_1_Private_Double_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667156);
			WormAIProfile.NativeMethodInfoPtr__GetBuyValue_b__54_0_Private_Double_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667157);
			WormAIProfile.NativeMethodInfoPtr__GetCombatPositioning_b__60_0_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667158);
			WormAIProfile.NativeMethodInfoPtr__IntrigueHandStrengthValue_b__63_1_Private_Int32_StrengthIntrigueAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667159);
			WormAIProfile.NativeMethodInfoPtr__EstStrength_b__65_2_Private_Int32_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667160);
			WormAIProfile.NativeMethodInfoPtr__EstStrength_b__65_3_Private_Int32_IntrigueAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667161);
			WormAIProfile.NativeMethodInfoPtr__PotentialStrength_b__66_1_Private_Int32_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667162);
			WormAIProfile.NativeMethodInfoPtr__PotentialStrength_b__66_3_Private_Int32_IntrigueAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667163);
			WormAIProfile.NativeMethodInfoPtr_Method_Private_Double_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667164);
			WormAIProfile.NativeMethodInfoPtr_Method_Private_Double_Factions_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667165);
			WormAIProfile.NativeMethodInfoPtr__GetSpecificAcquireBonus_b__73_0_Private_AIValueSummer_1_Double_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667166);
			WormAIProfile.NativeMethodInfoPtr__EstimatedConflictRank_b__77_0_Private_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667167);
			WormAIProfile.NativeMethodInfoPtr__GetExpectedCombatOrderWithStrength_b__82_0_Private_Tuple_2_WormPlayer_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667168);
			WormAIProfile.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_0_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667169);
			WormAIProfile.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_1_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667170);
			WormAIProfile.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_7_Private_Boolean_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667171);
			WormAIProfile.NativeMethodInfoPtr__GetBestOption_b__90_0_Private_AIValueSummer_1_Double_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667172);
			WormAIProfile.NativeMethodInfoPtr__get_GetBadIntrigueCardsInHand_b__103_0_Private_Boolean_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667173);
			WormAIProfile.NativeMethodInfoPtr__get_GetBadIntrigueCardsInHand_b__103_1_Private_Boolean_IntrigueAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667174);
			WormAIProfile.NativeMethodInfoPtr__TechTileToAcquire_b__111_0_Private_AIValueSummer_1_Double_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667175);
			WormAIProfile.NativeMethodInfoPtr__GetFreighterSelections_b__113_1_Private_Boolean_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, 100667176);
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x000B2F00 File Offset: 0x000B1100
		public unsafe override Match Match
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAIProfile.NativeMethodInfoPtr_get_Match_Protected_Virtual_get_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x000B2F4C File Offset: 0x000B114C
		public unsafe override PlayerEntity Player
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAIProfile.NativeMethodInfoPtr_get_Player_Protected_Virtual_get_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x000B2F98 File Offset: 0x000B1198
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123268, RefRangeEnd = 123270, XrefRangeStart = 123258, XrefRangeEnd = 123268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAIProfile(WormPlayer wormPlayer, WormMatch match)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wormPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x000B2FF8 File Offset: 0x000B11F8
		public unsafe AIConstantsRef Constants
		{
			[CallerCount(254)]
			[CachedScanResults(RefRangeStart = 123277, RefRangeEnd = 123531, XrefRangeStart = 123270, XrefRangeEnd = 123277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_Constants_Public_get_AIConstantsRef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIConstantsRef>(intPtr3) : null;
			}
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x000B3038 File Offset: 0x000B1238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123735, RefRangeEnd = 123736, XrefRangeStart = 123531, XrefRangeEnd = 123735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPredeterminedSelection(SelectionMessage selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_IsPredeterminedSelection_Public_Boolean_SelectionMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x000B3088 File Offset: 0x000B1288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123736, XrefRangeEnd = 123822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionCounter MakeChoice(SelectionMessage selection, WormAIChoiceContext choiceContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choiceContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAIProfile.NativeMethodInfoPtr_MakeChoice_Public_Virtual_New_ISelectionCounter_SelectionMessage_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionCounter>(intPtr3) : null;
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x000B30F8 File Offset: 0x000B12F8
		public unsafe static AIValueSummer<double> DefaultValueSummer
		{
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 123823, RefRangeEnd = 123902, XrefRangeStart = 123822, XrefRangeEnd = 123823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_DefaultValueSummer_Public_Static_get_AIValueSummer_1_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x000B312C File Offset: 0x000B132C
		public unsafe int PossiblePersuasion
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 123909, RefRangeEnd = 123912, XrefRangeStart = 123902, XrefRangeEnd = 123909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_PossiblePersuasion_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x000B3168 File Offset: 0x000B1368
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 123943, RefRangeEnd = 123947, XrefRangeStart = 123912, XrefRangeEnd = 123943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormImperiumPlayable> PredictCardBuys(int withPersuasion)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref withPersuasion;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_PredictCardBuys_Public_IEnumerable_1_WormImperiumPlayable_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormImperiumPlayable>>(intPtr3) : null;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x000B31B4 File Offset: 0x000B13B4
		public unsafe Dictionary<AgentIcons, int> DeckAgentIcons
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124017, RefRangeEnd = 124018, XrefRangeStart = 123947, XrefRangeEnd = 124017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_DeckAgentIcons_Public_get_Dictionary_2_AgentIcons_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AgentIcons, int>>(intPtr3) : null;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x000B31F4 File Offset: 0x000B13F4
		public unsafe bool IsClimax
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 124068, RefRangeEnd = 124110, XrefRangeStart = 124018, XrefRangeEnd = 124068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_IsClimax_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x000B3230 File Offset: 0x000B1430
		public unsafe bool IsFinalRound
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 124128, RefRangeEnd = 124137, XrefRangeStart = 124110, XrefRangeEnd = 124128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_IsFinalRound_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x000B326C File Offset: 0x000B146C
		[CallerCount(71)]
		[CachedScanResults(RefRangeStart = 124142, RefRangeEnd = 124213, XrefRangeStart = 124137, XrefRangeEnd = 124142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetGameArc()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetGameArc_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x000B32A8 File Offset: 0x000B14A8
		public unsafe Dictionary<AttributeDefinition<Nullable<int>>, IEnumerable<double>> ValuesDict
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 124288, RefRangeEnd = 124289, XrefRangeStart = 124213, XrefRangeEnd = 124288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_ValuesDict_Private_get_Dictionary_2_AttributeDefinition_1_Nullable_1_Int32_IEnumerable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AttributeDefinition<Nullable<int>>, IEnumerable<double>>>(intPtr3) : null;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x000B32E8 File Offset: 0x000B14E8
		public unsafe Dictionary<AttributeDefinition<Nullable<int>>, IEnumerable<double>> AbundanceThresholdDict
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124289, XrefRangeEnd = 124340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_AbundanceThresholdDict_Private_get_Dictionary_2_AttributeDefinition_1_Nullable_1_Int32_IEnumerable_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AttributeDefinition<Nullable<int>>, IEnumerable<double>>>(intPtr3) : null;
			}
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x000B3328 File Offset: 0x000B1528
		[CallerCount(217)]
		[CachedScanResults(RefRangeStart = 124452, RefRangeEnd = 124669, XrefRangeStart = 124340, XrefRangeEnd = 124452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetResourceValue(AttributeDefinition<Nullable<int>> attribute, int amount = 1, bool includeCombatPostureMod = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includeCombatPostureMod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetResourceValue_Public_Double_AttributeDefinition_1_Nullable_1_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x000B3394 File Offset: 0x000B1594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124669, XrefRangeEnd = 124670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double SelectForGameArc(Il2CppStructArray<double> choices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(choices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_SelectForGameArc_Private_Double_Il2CppStructArray_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x000B33E4 File Offset: 0x000B15E4
		public unsafe double CardDrawValue
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 124697, RefRangeEnd = 124717, XrefRangeStart = 124670, XrefRangeEnd = 124697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_CardDrawValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x000B3420 File Offset: 0x000B1620
		public unsafe double IntrigueValue
		{
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 124731, RefRangeEnd = 124766, XrefRangeStart = 124717, XrefRangeEnd = 124731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_IntrigueValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x000B345C File Offset: 0x000B165C
		public unsafe double TrashCardValue
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 124773, RefRangeEnd = 124786, XrefRangeStart = 124766, XrefRangeEnd = 124773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_TrashCardValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x000B3498 File Offset: 0x000B1698
		public unsafe double MinimumAcquireValue
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 124793, RefRangeEnd = 124795, XrefRangeStart = 124786, XrefRangeEnd = 124793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_MinimumAcquireValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x000B34D4 File Offset: 0x000B16D4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 124817, RefRangeEnd = 124827, XrefRangeStart = 124795, XrefRangeEnd = 124817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double TrashMod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_TrashMod_Public_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x000B3510 File Offset: 0x000B1710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125058, RefRangeEnd = 125060, XrefRangeStart = 124827, XrefRangeEnd = 125058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double DeployValue(Entity ownerEntity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ownerEntity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_DeployValue_Public_Double_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x000B3560 File Offset: 0x000B1760
		public unsafe double SwordmasterValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125067, RefRangeEnd = 125068, XrefRangeStart = 125060, XrefRangeEnd = 125067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_SwordmasterValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x000B359C File Offset: 0x000B179C
		public unsafe double HighCouncilValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125075, RefRangeEnd = 125076, XrefRangeStart = 125068, XrefRangeEnd = 125075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_HighCouncilValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x000B35D8 File Offset: 0x000B17D8
		public unsafe double FoldspaceValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 125083, RefRangeEnd = 125084, XrefRangeStart = 125076, XrefRangeEnd = 125083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_FoldspaceValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x000B3614 File Offset: 0x000B1814
		public unsafe double MentatValue
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 125105, RefRangeEnd = 125108, XrefRangeStart = 125084, XrefRangeEnd = 125105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_MentatValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x0600175E RID: 5982 RVA: 0x000B3650 File Offset: 0x000B1850
		public unsafe double ControlSolariValue
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 125115, RefRangeEnd = 125120, XrefRangeStart = 125108, XrefRangeEnd = 125115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_ControlSolariValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x000B368C File Offset: 0x000B188C
		public unsafe double ControlSpiceValue
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 125127, RefRangeEnd = 125130, XrefRangeStart = 125120, XrefRangeEnd = 125127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_ControlSpiceValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x000B36C8 File Offset: 0x000B18C8
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 125159, RefRangeEnd = 125179, XrefRangeStart = 125130, XrefRangeEnd = 125159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetBuyGains(int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetBuyGains_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x000B3714 File Offset: 0x000B1914
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 125196, RefRangeEnd = 125199, XrefRangeStart = 125179, XrefRangeEnd = 125196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetBuyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetBuyValue_Public_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x000B3750 File Offset: 0x000B1950
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 125293, RefRangeEnd = 125319, XrefRangeStart = 125199, XrefRangeEnd = 125293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> CurrentConflictInterest()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_CurrentConflictInterest_Public_AIValueSummer_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x000B3790 File Offset: 0x000B1990
		public unsafe double ConflictCompetitors
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 125342, RefRangeEnd = 125345, XrefRangeStart = 125319, XrefRangeEnd = 125342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_ConflictCompetitors_Private_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x000B37CC File Offset: 0x000B19CC
		public unsafe ValueTuple<double, double> ConflictPostureBounds
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 125363, RefRangeEnd = 125384, XrefRangeStart = 125345, XrefRangeEnd = 125363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_ConflictPostureBounds_Public_get_ValueTuple_2_Double_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<double, double>(intPtr);
			}
		}

		// Token: 0x06001765 RID: 5989 RVA: 0x000B3804 File Offset: 0x000B1A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 125399, RefRangeEnd = 125400, XrefRangeStart = 125384, XrefRangeEnd = 125399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetCombatPositioning()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetCombatPositioning_Public_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x000B3840 File Offset: 0x000B1A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 125400, XrefRangeEnd = 125407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetCombatPostureMod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetCombatPostureMod_Public_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000B387C File Offset: 0x000B1A7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 125692, RefRangeEnd = 125694, XrefRangeStart = 125407, XrefRangeEnd = 125692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> RelativeConflictValue(bool logAvgConflictValue = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logAvgConflictValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_RelativeConflictValue_Public_AIValueSummer_1_Double_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x000B38C8 File Offset: 0x000B1AC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 125725, RefRangeEnd = 125729, XrefRangeStart = 125694, XrefRangeEnd = 125725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IntrigueHandStrengthValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_IntrigueHandStrengthValue_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x000B3904 File Offset: 0x000B1B04
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 125802, RefRangeEnd = 125813, XrefRangeStart = 125729, XrefRangeEnd = 125802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<int> EstOpponentStrength(WormPlayer opponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(opponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_EstOpponentStrength_Public_AIValueSummer_1_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x000B3954 File Offset: 0x000B1B54
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 125908, RefRangeEnd = 125918, XrefRangeStart = 125813, XrefRangeEnd = 125908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<int> EstStrength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_EstStrength_Public_AIValueSummer_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<int>>(intPtr3) : null;
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x000B3994 File Offset: 0x000B1B94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126020, RefRangeEnd = 126021, XrefRangeStart = 125918, XrefRangeEnd = 126020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<int> PotentialStrength(int maxUnits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxUnits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_PotentialStrength_Public_AIValueSummer_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x000B39E0 File Offset: 0x000B1BE0
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 126030, RefRangeEnd = 126054, XrefRangeStart = 126021, XrefRangeEnd = 126030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double GetVictoryPointValue(int amount = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetVictoryPointValue_Public_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x000B3A2C File Offset: 0x000B1C2C
		[CallerCount(82)]
		[CachedScanResults(RefRangeStart = 126154, RefRangeEnd = 126236, XrefRangeStart = 126054, XrefRangeEnd = 126154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> GetGainInfluenceValue(Factions faction = Factions.None, int amount = 1, int currentRank = -1, bool hasAlliance = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentRank;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasAlliance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetGainInfluenceValue_Public_AIValueSummer_1_Double_Factions_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000B3AA4 File Offset: 0x000B1CA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 126399, RefRangeEnd = 126405, XrefRangeStart = 126236, XrefRangeEnd = 126399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<Factions, Factions, double> GetBestInfluenceExchange(int loseAmount, int gainAmount, bool showLog = true, List<Factions> loseFactionList = null, List<Factions> gainFactionList = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loseAmount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gainAmount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showLog;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loseFactionList);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(gainFactionList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetBestInfluenceExchange_Public_ValueTuple_3_Factions_Factions_Double_Int32_Int32_Boolean_List_1_Factions_List_1_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<Factions, Factions, double>(intPtr);
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x000B3B2C File Offset: 0x000B1D2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126537, RefRangeEnd = 126539, XrefRangeStart = 126405, XrefRangeEnd = 126537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> GetSynergyMod(WormPlayable card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetSynergyMod_Public_AIValueSummer_1_Double_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x06001770 RID: 6000 RVA: 0x000B3B7C File Offset: 0x000B1D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 126584, RefRangeEnd = 126585, XrefRangeStart = 126539, XrefRangeEnd = 126584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> GetFriendshipMod(WormPlayable card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetFriendshipMod_Public_AIValueSummer_1_Double_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x000B3BCC File Offset: 0x000B1DCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 126670, RefRangeEnd = 126673, XrefRangeStart = 126585, XrefRangeEnd = 126670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> GetAcquireEffectsValue(WormPlayable wp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetAcquireEffectsValue_Public_AIValueSummer_1_Double_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x000B3C1C File Offset: 0x000B1E1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 126719, RefRangeEnd = 126721, XrefRangeStart = 126673, XrefRangeEnd = 126719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> GetSpecificAcquireBonus(WormPlayable wp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(wp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetSpecificAcquireBonus_Public_AIValueSummer_1_Double_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x000B3C6C File Offset: 0x000B1E6C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 127205, RefRangeEnd = 127217, XrefRangeStart = 126721, XrefRangeEnd = 127205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WormUnit> GetUnitsToDeploy(List<WormUnit> unitList, int max = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unitList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetUnitsToDeploy_Public_List_1_WormUnit_List_1_WormUnit_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WormUnit>>(intPtr3) : null;
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x000B3CCC File Offset: 0x000B1ECC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127336, RefRangeEnd = 127338, XrefRangeStart = 127217, XrefRangeEnd = 127336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTroopsToRetreat(int max, int min = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref max;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetTroopsToRetreat_Public_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x000B3D24 File Offset: 0x000B1F24
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 127346, RefRangeEnd = 127350, XrefRangeStart = 127338, XrefRangeEnd = 127346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double OpponentRatio(Func<WormPlayer, bool> condition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(condition);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_OpponentRatio_Public_Double_Func_2_WormPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x000B3D74 File Offset: 0x000B1F74
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 127357, RefRangeEnd = 127365, XrefRangeStart = 127350, XrefRangeEnd = 127357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<int> EstimatedConflictRank(int bonusStrength = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bonusStrength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_EstimatedConflictRank_Public_Nullable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x000B3DB8 File Offset: 0x000B1FB8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 127382, RefRangeEnd = 127388, XrefRangeStart = 127365, XrefRangeEnd = 127382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<int> CurrentConflictRank(int bonusStrength = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bonusStrength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_CurrentConflictRank_Public_Nullable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x000B3DFC File Offset: 0x000B1FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127442, RefRangeEnd = 127444, XrefRangeStart = 127388, XrefRangeEnd = 127442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Nullable<int> GetConflictRank(Func<WormPlayer, int> oppStrengthFunc, int bonusStrength = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oppStrengthFunc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bonusStrength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetConflictRank_Private_Nullable_1_Int32_Func_2_WormPlayer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<int>(intPtr);
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x000B3E54 File Offset: 0x000B2054
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127504, RefRangeEnd = 127506, XrefRangeStart = 127444, XrefRangeEnd = 127504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WormPlayer> GetCurrentCombatOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetCurrentCombatOrder_Public_List_1_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WormPlayer>>(intPtr3) : null;
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x000B3E94 File Offset: 0x000B2094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 127528, RefRangeEnd = 127529, XrefRangeStart = 127506, XrefRangeEnd = 127528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<WormPlayer> GetExpectedCombatOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetExpectedCombatOrder_Public_List_1_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WormPlayer>>(intPtr3) : null;
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x000B3ED4 File Offset: 0x000B20D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127579, RefRangeEnd = 127581, XrefRangeStart = 127529, XrefRangeEnd = 127579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Tuple<WormPlayer, int>> GetExpectedCombatOrderWithStrength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetExpectedCombatOrderWithStrength_Public_List_1_Tuple_2_WormPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Tuple<WormPlayer, int>>>(intPtr3) : null;
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x000B3F14 File Offset: 0x000B2114
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 127603, RefRangeEnd = 127605, XrefRangeStart = 127581, XrefRangeEnd = 127603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetSpiceForSellMelange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetSpiceForSellMelange_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x000B3F50 File Offset: 0x000B2150
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 127628, RefRangeEnd = 127643, XrefRangeStart = 127605, XrefRangeEnd = 127628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanAgentAbilityBePlayedWithSpaceCost(WormSpace space, AttributeDefinition<Nullable<int>> attribute, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_CanAgentAbilityBePlayedWithSpaceCost_Public_Boolean_WormSpace_AttributeDefinition_1_Nullable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x000B3FC0 File Offset: 0x000B21C0
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 127922, RefRangeEnd = 127941, XrefRangeStart = 127643, XrefRangeEnd = 127922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<WormImperiumPlayable, double> GetCardToTrash(IEnumerable<WormImperiumPlayable> targets)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetCardToTrash_Public_ValueTuple_2_WormImperiumPlayable_Double_IEnumerable_1_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<WormImperiumPlayable, double>(intPtr);
			}
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x000B4008 File Offset: 0x000B2208
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 128157, RefRangeEnd = 128160, XrefRangeStart = 127941, XrefRangeEnd = 128157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayer GetHeighlinerPotentialPlayer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetHeighlinerPotentialPlayer_Public_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x000B4048 File Offset: 0x000B2248
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 128167, RefRangeEnd = 128170, XrefRangeStart = 128160, XrefRangeEnd = 128167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasHighlinerPotential()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_HasHighlinerPotential_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x000B4084 File Offset: 0x000B2284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128170, XrefRangeEnd = 128177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasHighlinerPotential(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_HasHighlinerPotential_Public_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x000B40D4 File Offset: 0x000B22D4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 128219, RefRangeEnd = 128233, XrefRangeStart = 128177, XrefRangeEnd = 128219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int PossiblePersuasionGain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_PossiblePersuasionGain_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x000B4110 File Offset: 0x000B2310
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 128318, RefRangeEnd = 128321, XrefRangeStart = 128233, XrefRangeEnd = 128318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<WormImperiumPlayable, WormSpace, double> GetBestOption(IEnumerable<WormImperiumPlayable> possibleCards = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(possibleCards);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetBestOption_Public_ValueTuple_3_WormImperiumPlayable_WormSpace_Double_IEnumerable_1_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<WormImperiumPlayable, WormSpace, double>(intPtr);
			}
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x000B4158 File Offset: 0x000B2358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128321, XrefRangeEnd = 128357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasTurnBeforeOpponentNextRound(WormPlayer opponent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(opponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_HasTurnBeforeOpponentNextRound_Public_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x000B41A8 File Offset: 0x000B23A8
		public unsafe bool IsSolariShort
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 128363, RefRangeEnd = 128368, XrefRangeStart = 128357, XrefRangeEnd = 128363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_IsSolariShort_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x000B41E4 File Offset: 0x000B23E4
		public unsafe bool IsSolariLong
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 128369, RefRangeEnd = 128370, XrefRangeStart = 128368, XrefRangeEnd = 128369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_IsSolariLong_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x000B4220 File Offset: 0x000B2420
		public unsafe bool IsSpiceShort
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128370, XrefRangeEnd = 128377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_IsSpiceShort_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x000B425C File Offset: 0x000B245C
		public unsafe bool IsTroopShort
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128377, XrefRangeEnd = 128379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_IsTroopShort_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x000B4298 File Offset: 0x000B2498
		public unsafe bool IsWaterLong
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 128380, RefRangeEnd = 128381, XrefRangeStart = 128379, XrefRangeEnd = 128380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_IsWaterLong_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x000B42D4 File Offset: 0x000B24D4
		public unsafe List<WormIntriguePlayable> GetBadIntrigueCardsInHand
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 128397, RefRangeEnd = 128400, XrefRangeStart = 128381, XrefRangeEnd = 128397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_GetBadIntrigueCardsInHand_Public_get_List_1_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<WormIntriguePlayable>>(intPtr3) : null;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x000B4314 File Offset: 0x000B2514
		public unsafe double NegotiateTechValue
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 128413, RefRangeEnd = 128416, XrefRangeStart = 128400, XrefRangeEnd = 128413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_NegotiateTechValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x000B4350 File Offset: 0x000B2550
		public unsafe double DiscardValue
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 128423, RefRangeEnd = 128439, XrefRangeStart = 128416, XrefRangeEnd = 128423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_DiscardValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x000B438C File Offset: 0x000B258C
		public unsafe double FreighterValue
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 128453, RefRangeEnd = 128472, XrefRangeStart = 128439, XrefRangeEnd = 128453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_get_FreighterValue_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x000B43C8 File Offset: 0x000B25C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 128481, RefRangeEnd = 128485, XrefRangeStart = 128472, XrefRangeEnd = 128481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double BuyTechValue(int discount = 0, bool allowSolari = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref discount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowSolari;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_BuyTechValue_Public_Double_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x000B4420 File Offset: 0x000B2620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128501, RefRangeEnd = 128502, XrefRangeStart = 128485, XrefRangeEnd = 128501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormTechTilePlayable TechTileToAcquire(int discount = 0, bool allowSolari = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref discount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowSolari;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_TechTileToAcquire_Public_WormTechTilePlayable_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormTechTilePlayable>(intPtr3) : null;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x000B447C File Offset: 0x000B267C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128529, RefRangeEnd = 128530, XrefRangeStart = 128502, XrefRangeEnd = 128529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double TechOptionsMod(int discount = 0, bool allowSolari = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref discount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowSolari;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_TechOptionsMod_Public_Double_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x000B44D4 File Offset: 0x000B26D4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 128572, RefRangeEnd = 128582, XrefRangeStart = 128530, XrefRangeEnd = 128572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, int, string> GetFreighterSelections(int space = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref space;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_GetFreighterSelections_Public_ValueTuple_3_Int32_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ValueTuple<int, int, string>(intPtr);
			}
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x000B4518 File Offset: 0x000B2718
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 128681, RefRangeEnd = 128684, XrefRangeStart = 128582, XrefRangeEnd = 128681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> ResearchValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_ResearchValue_Public_AIValueSummer_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x000B4558 File Offset: 0x000B2758
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 128717, RefRangeEnd = 128731, XrefRangeStart = 128684, XrefRangeEnd = 128717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> TleilaxuValue(int amount = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_TleilaxuValue_Public_AIValueSummer_1_Double_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x000B45A4 File Offset: 0x000B27A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128731, XrefRangeEnd = 128732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetResourceValue_b__28_0(Factions _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetResourceValue_b__28_0_Private_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x000B45F0 File Offset: 0x000B27F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> _GetResourceValue_b__28_2(WormImperiumPlayable btc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(btc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetResourceValue_b__28_2_Private_AIValueSummer_1_Double_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x000B4640 File Offset: 0x000B2840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128732, XrefRangeEnd = 128737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double _GetBuyGains_b__53_0(WormImperiumPlayable _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetBuyGains_b__53_0_Private_Double_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x000B4690 File Offset: 0x000B2890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128737, XrefRangeEnd = 128742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double _GetBuyGains_b__53_1(WormImperiumPlayable _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetBuyGains_b__53_1_Private_Double_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x000B46E0 File Offset: 0x000B28E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128742, XrefRangeEnd = 128747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double _GetBuyValue_b__54_0(WormImperiumPlayable _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetBuyValue_b__54_0_Private_Double_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x000B4730 File Offset: 0x000B2930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128747, XrefRangeEnd = 128748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetCombatPositioning_b__60_0(WormPlayer _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetCombatPositioning_b__60_0_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x000B4780 File Offset: 0x000B2980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128748, XrefRangeEnd = 128749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _IntrigueHandStrengthValue_b__63_1(StrengthIntrigueAbility ability)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__IntrigueHandStrengthValue_b__63_1_Private_Int32_StrengthIntrigueAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x000B47D0 File Offset: 0x000B29D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128749, XrefRangeEnd = 128763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _EstStrength_b__65_2(WormIntriguePlayable handCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handCard);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__EstStrength_b__65_2_Private_Int32_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x000B4820 File Offset: 0x000B2A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128763, XrefRangeEnd = 128764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _EstStrength_b__65_3(IntrigueAbility _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__EstStrength_b__65_3_Private_Int32_IntrigueAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x000B4870 File Offset: 0x000B2A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128764, XrefRangeEnd = 128778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _PotentialStrength_b__66_1(WormIntriguePlayable handCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handCard);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__PotentialStrength_b__66_1_Private_Int32_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x000B48C0 File Offset: 0x000B2AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _PotentialStrength_b__66_3(IntrigueAbility _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__PotentialStrength_b__66_3_Private_Int32_IntrigueAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x000B4910 File Offset: 0x000B2B10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 128794, RefRangeEnd = 128795, XrefRangeStart = 128778, XrefRangeEnd = 128794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double Method_Private_Double_Factions_0(Factions faction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_Method_Private_Double_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x000B495C File Offset: 0x000B2B5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 128797, RefRangeEnd = 128801, XrefRangeStart = 128795, XrefRangeEnd = 128797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double Method_Private_Double_Factions_1(Factions faction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref faction;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr_Method_Private_Double_Factions_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x000B49A8 File Offset: 0x000B2BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128801, XrefRangeEnd = 128802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> _GetSpecificAcquireBonus_b__73_0(WormAbilityDefinition _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetSpecificAcquireBonus_b__73_0_Private_AIValueSummer_1_Double_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x000B49F8 File Offset: 0x000B2BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128802, XrefRangeEnd = 128807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int _EstimatedConflictRank_b__77_0(WormPlayer _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__EstimatedConflictRank_b__77_0_Private_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x000B4A48 File Offset: 0x000B2C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128807, XrefRangeEnd = 128817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tuple<WormPlayer, int> _GetExpectedCombatOrderWithStrength_b__82_0(WormPlayer _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetExpectedCombatOrderWithStrength_b__82_0_Private_Tuple_2_WormPlayer_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<WormPlayer, int>>(intPtr3) : null;
			}
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x000B4A98 File Offset: 0x000B2C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128817, XrefRangeEnd = 128822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetHeighlinerPotentialPlayer_b__86_0(WormPlayer _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_0_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x000B4AE8 File Offset: 0x000B2CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128822, XrefRangeEnd = 128827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetHeighlinerPotentialPlayer_b__86_1(WormPlayer _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_1_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x000B4B38 File Offset: 0x000B2D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128827, XrefRangeEnd = 128844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetHeighlinerPotentialPlayer_b__86_7(ArchetypeID _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_7_Private_Boolean_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x000B4B88 File Offset: 0x000B2D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128844, XrefRangeEnd = 128848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> _GetBestOption_b__90_0(WormAbilityDefinition _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetBestOption_b__90_0_Private_AIValueSummer_1_Double_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x000B4BD8 File Offset: 0x000B2DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128848, XrefRangeEnd = 128860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_GetBadIntrigueCardsInHand_b__103_0(WormIntriguePlayable card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__get_GetBadIntrigueCardsInHand_b__103_0_Private_Boolean_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x000B4C28 File Offset: 0x000B2E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128860, XrefRangeEnd = 128861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_GetBadIntrigueCardsInHand_b__103_1(IntrigueAbility ability)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__get_GetBadIntrigueCardsInHand_b__103_1_Private_Boolean_IntrigueAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x000B4C78 File Offset: 0x000B2E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128861, XrefRangeEnd = 128863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AIValueSummer<double> _TechTileToAcquire_b__111_0(WormTechTilePlayable _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__TechTileToAcquire_b__111_0_Private_AIValueSummer_1_Double_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x000B4CC8 File Offset: 0x000B2EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128863, XrefRangeEnd = 128871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _GetFreighterSelections_b__113_1(WormTechTilePlayable _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.NativeMethodInfoPtr__GetFreighterSelections_b__113_1_Private_Boolean_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0000A51F File Offset: 0x0000871F
		public WormAIProfile(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x000B4D18 File Offset: 0x000B2F18
		// (set) Token: 0x060017AE RID: 6062 RVA: 0x0000A528 File Offset: 0x00008728
		public unsafe WormPlayer WormPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.NativeFieldInfoPtr_WormPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.NativeFieldInfoPtr_WormPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060017AF RID: 6063 RVA: 0x000B4D48 File Offset: 0x000B2F48
		// (set) Token: 0x060017B0 RID: 6064 RVA: 0x0000A547 File Offset: 0x00008747
		public unsafe WormMatch WormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.NativeFieldInfoPtr_WormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.NativeFieldInfoPtr_WormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x000B4D78 File Offset: 0x000B2F78
		// (set) Token: 0x060017B2 RID: 6066 RVA: 0x0000A566 File Offset: 0x00008766
		public Nullable<bool> _isClimax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.NativeFieldInfoPtr__isClimax);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.NativeFieldInfoPtr__isClimax), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x000B4DA8 File Offset: 0x000B2FA8
		// (set) Token: 0x060017B4 RID: 6068 RVA: 0x0000A594 File Offset: 0x00008794
		public unsafe Dictionary<int, double> _cachedBuyGains
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.NativeFieldInfoPtr__cachedBuyGains);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, double>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.NativeFieldInfoPtr__cachedBuyGains), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeFieldInfoPtr_WormPlayer;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeFieldInfoPtr_WormMatch;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeFieldInfoPtr__isClimax;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeFieldInfoPtr__cachedBuyGains;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_get_Match_Protected_Virtual_get_Match_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr_get_Player_Protected_Virtual_get_PlayerEntity_0;

		// Token: 0x04000E3C RID: 3644
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0;

		// Token: 0x04000E3D RID: 3645
		private static readonly IntPtr NativeMethodInfoPtr_get_Constants_Public_get_AIConstantsRef_0;

		// Token: 0x04000E3E RID: 3646
		private static readonly IntPtr NativeMethodInfoPtr_IsPredeterminedSelection_Public_Boolean_SelectionMessage_0;

		// Token: 0x04000E3F RID: 3647
		private static readonly IntPtr NativeMethodInfoPtr_MakeChoice_Public_Virtual_New_ISelectionCounter_SelectionMessage_WormAIChoiceContext_0;

		// Token: 0x04000E40 RID: 3648
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueSummer_Public_Static_get_AIValueSummer_1_Double_0;

		// Token: 0x04000E41 RID: 3649
		private static readonly IntPtr NativeMethodInfoPtr_get_PossiblePersuasion_Public_get_Int32_0;

		// Token: 0x04000E42 RID: 3650
		private static readonly IntPtr NativeMethodInfoPtr_PredictCardBuys_Public_IEnumerable_1_WormImperiumPlayable_Int32_0;

		// Token: 0x04000E43 RID: 3651
		private static readonly IntPtr NativeMethodInfoPtr_get_DeckAgentIcons_Public_get_Dictionary_2_AgentIcons_Int32_0;

		// Token: 0x04000E44 RID: 3652
		private static readonly IntPtr NativeMethodInfoPtr_get_IsClimax_Public_get_Boolean_0;

		// Token: 0x04000E45 RID: 3653
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFinalRound_Public_get_Boolean_0;

		// Token: 0x04000E46 RID: 3654
		private static readonly IntPtr NativeMethodInfoPtr_GetGameArc_Public_Int32_0;

		// Token: 0x04000E47 RID: 3655
		private static readonly IntPtr NativeMethodInfoPtr_get_ValuesDict_Private_get_Dictionary_2_AttributeDefinition_1_Nullable_1_Int32_IEnumerable_1_Double_0;

		// Token: 0x04000E48 RID: 3656
		private static readonly IntPtr NativeMethodInfoPtr_get_AbundanceThresholdDict_Private_get_Dictionary_2_AttributeDefinition_1_Nullable_1_Int32_IEnumerable_1_Double_0;

		// Token: 0x04000E49 RID: 3657
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceValue_Public_Double_AttributeDefinition_1_Nullable_1_Int32_Int32_Boolean_0;

		// Token: 0x04000E4A RID: 3658
		private static readonly IntPtr NativeMethodInfoPtr_SelectForGameArc_Private_Double_Il2CppStructArray_1_Double_0;

		// Token: 0x04000E4B RID: 3659
		private static readonly IntPtr NativeMethodInfoPtr_get_CardDrawValue_Public_get_Double_0;

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeMethodInfoPtr_get_IntrigueValue_Public_get_Double_0;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeMethodInfoPtr_get_TrashCardValue_Public_get_Double_0;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr_get_MinimumAcquireValue_Public_get_Double_0;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr_TrashMod_Public_Double_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr_DeployValue_Public_Double_Entity_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_get_SwordmasterValue_Public_get_Double_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_get_HighCouncilValue_Public_get_Double_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_get_FoldspaceValue_Public_get_Double_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_get_MentatValue_Public_get_Double_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_get_ControlSolariValue_Public_get_Double_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_get_ControlSpiceValue_Public_get_Double_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_GetBuyGains_Public_Double_Int32_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_GetBuyValue_Public_Double_0;

		// Token: 0x04000E59 RID: 3673
		private static readonly IntPtr NativeMethodInfoPtr_CurrentConflictInterest_Public_AIValueSummer_1_Double_0;

		// Token: 0x04000E5A RID: 3674
		private static readonly IntPtr NativeMethodInfoPtr_get_ConflictCompetitors_Private_get_Double_0;

		// Token: 0x04000E5B RID: 3675
		private static readonly IntPtr NativeMethodInfoPtr_get_ConflictPostureBounds_Public_get_ValueTuple_2_Double_Double_0;

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr_GetCombatPositioning_Public_Double_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_GetCombatPostureMod_Public_Double_0;

		// Token: 0x04000E5E RID: 3678
		private static readonly IntPtr NativeMethodInfoPtr_RelativeConflictValue_Public_AIValueSummer_1_Double_Boolean_0;

		// Token: 0x04000E5F RID: 3679
		private static readonly IntPtr NativeMethodInfoPtr_IntrigueHandStrengthValue_Public_Int32_0;

		// Token: 0x04000E60 RID: 3680
		private static readonly IntPtr NativeMethodInfoPtr_EstOpponentStrength_Public_AIValueSummer_1_Int32_WormPlayer_0;

		// Token: 0x04000E61 RID: 3681
		private static readonly IntPtr NativeMethodInfoPtr_EstStrength_Public_AIValueSummer_1_Int32_0;

		// Token: 0x04000E62 RID: 3682
		private static readonly IntPtr NativeMethodInfoPtr_PotentialStrength_Public_AIValueSummer_1_Int32_Int32_0;

		// Token: 0x04000E63 RID: 3683
		private static readonly IntPtr NativeMethodInfoPtr_GetVictoryPointValue_Public_Double_Int32_0;

		// Token: 0x04000E64 RID: 3684
		private static readonly IntPtr NativeMethodInfoPtr_GetGainInfluenceValue_Public_AIValueSummer_1_Double_Factions_Int32_Int32_Boolean_0;

		// Token: 0x04000E65 RID: 3685
		private static readonly IntPtr NativeMethodInfoPtr_GetBestInfluenceExchange_Public_ValueTuple_3_Factions_Factions_Double_Int32_Int32_Boolean_List_1_Factions_List_1_Factions_0;

		// Token: 0x04000E66 RID: 3686
		private static readonly IntPtr NativeMethodInfoPtr_GetSynergyMod_Public_AIValueSummer_1_Double_WormPlayable_0;

		// Token: 0x04000E67 RID: 3687
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendshipMod_Public_AIValueSummer_1_Double_WormPlayable_0;

		// Token: 0x04000E68 RID: 3688
		private static readonly IntPtr NativeMethodInfoPtr_GetAcquireEffectsValue_Public_AIValueSummer_1_Double_WormPlayable_0;

		// Token: 0x04000E69 RID: 3689
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecificAcquireBonus_Public_AIValueSummer_1_Double_WormPlayable_0;

		// Token: 0x04000E6A RID: 3690
		private static readonly IntPtr NativeMethodInfoPtr_GetUnitsToDeploy_Public_List_1_WormUnit_List_1_WormUnit_Int32_0;

		// Token: 0x04000E6B RID: 3691
		private static readonly IntPtr NativeMethodInfoPtr_GetTroopsToRetreat_Public_Int32_Int32_Int32_0;

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeMethodInfoPtr_OpponentRatio_Public_Double_Func_2_WormPlayer_Boolean_0;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeMethodInfoPtr_EstimatedConflictRank_Public_Nullable_1_Int32_Int32_0;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeMethodInfoPtr_CurrentConflictRank_Public_Nullable_1_Int32_Int32_0;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeMethodInfoPtr_GetConflictRank_Private_Nullable_1_Int32_Func_2_WormPlayer_Int32_Int32_0;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentCombatOrder_Public_List_1_WormPlayer_0;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeMethodInfoPtr_GetExpectedCombatOrder_Public_List_1_WormPlayer_0;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeMethodInfoPtr_GetExpectedCombatOrderWithStrength_Public_List_1_Tuple_2_WormPlayer_Int32_0;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeMethodInfoPtr_GetSpiceForSellMelange_Public_Int32_0;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr_CanAgentAbilityBePlayedWithSpaceCost_Public_Boolean_WormSpace_AttributeDefinition_1_Nullable_1_Int32_Int32_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_GetCardToTrash_Public_ValueTuple_2_WormImperiumPlayable_Double_IEnumerable_1_WormImperiumPlayable_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr_GetHeighlinerPotentialPlayer_Public_WormPlayer_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr_HasHighlinerPotential_Public_Boolean_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr_HasHighlinerPotential_Public_Boolean_WormPlayer_0;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeMethodInfoPtr_PossiblePersuasionGain_Public_Int32_0;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeMethodInfoPtr_GetBestOption_Public_ValueTuple_3_WormImperiumPlayable_WormSpace_Double_IEnumerable_1_WormImperiumPlayable_0;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeMethodInfoPtr_HasTurnBeforeOpponentNextRound_Public_Boolean_WormPlayer_0;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSolariShort_Public_get_Boolean_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSolariLong_Public_get_Boolean_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSpiceShort_Public_get_Boolean_0;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTroopShort_Public_get_Boolean_0;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr_get_IsWaterLong_Public_get_Boolean_0;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr_get_GetBadIntrigueCardsInHand_Public_get_List_1_WormIntriguePlayable_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr_get_NegotiateTechValue_Public_get_Double_0;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr_get_DiscardValue_Public_get_Double_0;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeMethodInfoPtr_get_FreighterValue_Public_get_Double_0;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeMethodInfoPtr_BuyTechValue_Public_Double_Int32_Boolean_0;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeMethodInfoPtr_TechTileToAcquire_Public_WormTechTilePlayable_Int32_Boolean_0;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeMethodInfoPtr_TechOptionsMod_Public_Double_Int32_Boolean_0;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeMethodInfoPtr_GetFreighterSelections_Public_ValueTuple_3_Int32_Int32_String_Int32_0;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeMethodInfoPtr_ResearchValue_Public_AIValueSummer_1_Double_0;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_TleilaxuValue_Public_AIValueSummer_1_Double_Int32_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr__GetResourceValue_b__28_0_Private_Boolean_Factions_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr__GetResourceValue_b__28_2_Private_AIValueSummer_1_Double_WormImperiumPlayable_0;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeMethodInfoPtr__GetBuyGains_b__53_0_Private_Double_WormImperiumPlayable_0;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeMethodInfoPtr__GetBuyGains_b__53_1_Private_Double_WormImperiumPlayable_0;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr__GetBuyValue_b__54_0_Private_Double_WormImperiumPlayable_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr__GetCombatPositioning_b__60_0_Private_Boolean_WormPlayer_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr__IntrigueHandStrengthValue_b__63_1_Private_Int32_StrengthIntrigueAbility_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr__EstStrength_b__65_2_Private_Int32_WormIntriguePlayable_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr__EstStrength_b__65_3_Private_Int32_IntrigueAbility_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr__PotentialStrength_b__66_1_Private_Int32_WormIntriguePlayable_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr__PotentialStrength_b__66_3_Private_Int32_IntrigueAbility_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Double_Factions_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Double_Factions_1;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr__GetSpecificAcquireBonus_b__73_0_Private_AIValueSummer_1_Double_WormAbilityDefinition_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr__EstimatedConflictRank_b__77_0_Private_Int32_WormPlayer_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr__GetExpectedCombatOrderWithStrength_b__82_0_Private_Tuple_2_WormPlayer_Int32_WormPlayer_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_0_Private_Boolean_WormPlayer_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_1_Private_Boolean_WormPlayer_0;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_7_Private_Boolean_ArchetypeID_0;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeMethodInfoPtr__GetBestOption_b__90_0_Private_AIValueSummer_1_Double_WormAbilityDefinition_0;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeMethodInfoPtr__get_GetBadIntrigueCardsInHand_b__103_0_Private_Boolean_WormIntriguePlayable_0;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr__get_GetBadIntrigueCardsInHand_b__103_1_Private_Boolean_IntrigueAbility_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr__TechTileToAcquire_b__111_0_Private_AIValueSummer_1_Double_WormTechTilePlayable_0;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr__GetFreighterSelections_b__113_1_Private_Boolean_WormTechTilePlayable_0;

		// Token: 0x02000639 RID: 1593
		[ObfuscatedName("worm.canis.ai.WormAIProfile+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x06005053 RID: 20563 RVA: 0x001A9BCC File Offset: 0x001A7DCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr);
				WormAIProfile.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9");
				WormAIProfile.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__9_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__10_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__10_2");
				WormAIProfile.__c.NativeFieldInfoPtr___9__10_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__10_3");
				WormAIProfile.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__10_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__10_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__17_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__17_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__17_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__17_2");
				WormAIProfile.__c.NativeFieldInfoPtr___9__17_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__17_3");
				WormAIProfile.__c.NativeFieldInfoPtr___9__28_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__28_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__28_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__28_3");
				WormAIProfile.__c.NativeFieldInfoPtr___9__38_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__38_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__38_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__38_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__38_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__38_2");
				WormAIProfile.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__39_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__39_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__39_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__39_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__39_2");
				WormAIProfile.__c.NativeFieldInfoPtr___9__39_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__39_3");
				WormAIProfile.__c.NativeFieldInfoPtr___9__39_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__39_5");
				WormAIProfile.__c.NativeFieldInfoPtr___9__39_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__39_4");
				WormAIProfile.__c.NativeFieldInfoPtr___9__55_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__55_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__55_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__55_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__57_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__57_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__63_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__63_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__64_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__64_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__65_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__65_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__65_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__65_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__66_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__66_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__66_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__66_2");
				WormAIProfile.__c.NativeFieldInfoPtr___9__69_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__69_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__69_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__69_3");
				WormAIProfile.__c.NativeFieldInfoPtr___9__70_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__70_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__70_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__70_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__70_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__70_2");
				WormAIProfile.__c.NativeFieldInfoPtr___9__74_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__74_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__74_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__74_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__74_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__74_2");
				WormAIProfile.__c.NativeFieldInfoPtr___9__74_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__74_3");
				WormAIProfile.__c.NativeFieldInfoPtr___9__74_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__74_4");
				WormAIProfile.__c.NativeFieldInfoPtr___9__74_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__74_9");
				WormAIProfile.__c.NativeFieldInfoPtr___9__74_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__74_10");
				WormAIProfile.__c.NativeFieldInfoPtr___9__74_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__74_5");
				WormAIProfile.__c.NativeFieldInfoPtr___9__74_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__74_11");
				WormAIProfile.__c.NativeFieldInfoPtr___9__74_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__74_12");
				WormAIProfile.__c.NativeFieldInfoPtr___9__74_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__74_13");
				WormAIProfile.__c.NativeFieldInfoPtr___9__74_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__74_8");
				WormAIProfile.__c.NativeFieldInfoPtr___9__75_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__75_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__75_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__75_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__75_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__75_3");
				WormAIProfile.__c.NativeFieldInfoPtr___9__75_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__75_6");
				WormAIProfile.__c.NativeFieldInfoPtr___9__78_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__78_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__80_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__80_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__80_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__80_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__80_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__80_2");
				WormAIProfile.__c.NativeFieldInfoPtr___9__81_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__81_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__82_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__82_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__85_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__85_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__85_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__85_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__86_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__86_2");
				WormAIProfile.__c.NativeFieldInfoPtr___9__86_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__86_3");
				WormAIProfile.__c.NativeFieldInfoPtr___9__86_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__86_6");
				WormAIProfile.__c.NativeFieldInfoPtr___9__86_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__86_4");
				WormAIProfile.__c.NativeFieldInfoPtr___9__86_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__86_5");
				WormAIProfile.__c.NativeFieldInfoPtr___9__89_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__89_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__89_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__89_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__90_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__90_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__113_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__113_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__114_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__114_0");
				WormAIProfile.__c.NativeFieldInfoPtr___9__114_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__114_1");
				WormAIProfile.__c.NativeFieldInfoPtr___9__114_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__114_2");
				WormAIProfile.__c.NativeFieldInfoPtr___9__114_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, "<>9__114_3");
				WormAIProfile.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667178);
				WormAIProfile.__c.NativeMethodInfoPtr__IsPredeterminedSelection_b__9_0_Internal_TargetResponse_SelectionNodeFilterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667179);
				WormAIProfile.__c.NativeMethodInfoPtr__MakeChoice_b__10_2_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667180);
				WormAIProfile.__c.NativeMethodInfoPtr__MakeChoice_b__10_3_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667181);
				WormAIProfile.__c.NativeMethodInfoPtr__MakeChoice_b__10_0_Internal_Boolean_WormAIChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667182);
				WormAIProfile.__c.NativeMethodInfoPtr__MakeChoice_b__10_1_Internal_Double_WormAIChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667183);
				WormAIProfile.__c.NativeMethodInfoPtr__get_DeckAgentIcons_b__17_0_Internal_IEnumerable_1_AgentIcons_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667184);
				WormAIProfile.__c.NativeMethodInfoPtr__get_DeckAgentIcons_b__17_1_Internal_AgentIcons_AgentIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667185);
				WormAIProfile.__c.NativeMethodInfoPtr__get_DeckAgentIcons_b__17_2_Internal_AgentIcons_IGrouping_2_AgentIcons_AgentIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667186);
				WormAIProfile.__c.NativeMethodInfoPtr__get_DeckAgentIcons_b__17_3_Internal_Int32_IGrouping_2_AgentIcons_AgentIcons_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667187);
				WormAIProfile.__c.NativeMethodInfoPtr__GetResourceValue_b__28_1_Internal_WormImperiumPlayable_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667188);
				WormAIProfile.__c.NativeMethodInfoPtr__GetResourceValue_b__28_3_Internal_Double_KeyValuePair_2_WormImperiumPlayable_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667189);
				WormAIProfile.__c.NativeMethodInfoPtr__TrashMod_b__38_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667190);
				WormAIProfile.__c.NativeMethodInfoPtr__TrashMod_b__38_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667191);
				WormAIProfile.__c.NativeMethodInfoPtr__TrashMod_b__38_2_Internal_Double_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667192);
				WormAIProfile.__c.NativeMethodInfoPtr__DeployValue_b__39_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667193);
				WormAIProfile.__c.NativeMethodInfoPtr__DeployValue_b__39_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667194);
				WormAIProfile.__c.NativeMethodInfoPtr__DeployValue_b__39_2_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667195);
				WormAIProfile.__c.NativeMethodInfoPtr__DeployValue_b__39_3_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667196);
				WormAIProfile.__c.NativeMethodInfoPtr__DeployValue_b__39_5_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667197);
				WormAIProfile.__c.NativeMethodInfoPtr__DeployValue_b__39_4_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667198);
				WormAIProfile.__c.NativeMethodInfoPtr__CurrentConflictInterest_b__55_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667199);
				WormAIProfile.__c.NativeMethodInfoPtr__CurrentConflictInterest_b__55_1_Internal_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667200);
				WormAIProfile.__c.NativeMethodInfoPtr__get_ConflictCompetitors_b__57_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667201);
				WormAIProfile.__c.NativeMethodInfoPtr__IntrigueHandStrengthValue_b__63_0_Internal_IEnumerable_1_StrengthIntrigueAbility_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667202);
				WormAIProfile.__c.NativeMethodInfoPtr__EstOpponentStrength_b__64_0_Internal_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667203);
				WormAIProfile.__c.NativeMethodInfoPtr__EstStrength_b__65_0_Internal_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667204);
				WormAIProfile.__c.NativeMethodInfoPtr__EstStrength_b__65_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667205);
				WormAIProfile.__c.NativeMethodInfoPtr__PotentialStrength_b__66_0_Internal_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667206);
				WormAIProfile.__c.NativeMethodInfoPtr__PotentialStrength_b__66_2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667207);
				WormAIProfile.__c.NativeMethodInfoPtr__GetBestInfluenceExchange_b__69_1_Internal_Factions_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667208);
				WormAIProfile.__c.NativeMethodInfoPtr__GetBestInfluenceExchange_b__69_3_Internal_Factions_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667209);
				WormAIProfile.__c.NativeMethodInfoPtr__GetSynergyMod_b__70_0_Internal_IEnumerable_1_WormAbilityDefinition_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667210);
				WormAIProfile.__c.NativeMethodInfoPtr__GetSynergyMod_b__70_1_Internal_IEnumerable_1_WormAbilityDefinition_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667211);
				WormAIProfile.__c.NativeMethodInfoPtr__GetSynergyMod_b__70_2_Internal_IEnumerable_1_WormAbilityDefinition_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667212);
				WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_0_Internal_AIValueSummer_1_Int32_AIValueSummer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667213);
				WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_1_Internal_Int32_AIValueSummer_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667214);
				WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_2_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667215);
				WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_3_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667216);
				WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_4_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667217);
				WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_9_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667218);
				WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_10_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667219);
				WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_5_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667220);
				WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_11_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667221);
				WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_12_Internal_Boolean_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667222);
				WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_13_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667223);
				WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_8_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667224);
				WormAIProfile.__c.NativeMethodInfoPtr__GetTroopsToRetreat_b__75_0_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667225);
				WormAIProfile.__c.NativeMethodInfoPtr__GetTroopsToRetreat_b__75_1_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667226);
				WormAIProfile.__c.NativeMethodInfoPtr__GetTroopsToRetreat_b__75_3_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667227);
				WormAIProfile.__c.NativeMethodInfoPtr__GetTroopsToRetreat_b__75_6_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667228);
				WormAIProfile.__c.NativeMethodInfoPtr__CurrentConflictRank_b__78_0_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667229);
				WormAIProfile.__c.NativeMethodInfoPtr__GetCurrentCombatOrder_b__80_0_Internal_Tuple_2_WormPlayer_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667230);
				WormAIProfile.__c.NativeMethodInfoPtr__GetCurrentCombatOrder_b__80_1_Internal_Int32_Tuple_2_WormPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667231);
				WormAIProfile.__c.NativeMethodInfoPtr__GetCurrentCombatOrder_b__80_2_Internal_WormPlayer_Tuple_2_WormPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667232);
				WormAIProfile.__c.NativeMethodInfoPtr__GetExpectedCombatOrder_b__81_0_Internal_WormPlayer_Tuple_2_WormPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667233);
				WormAIProfile.__c.NativeMethodInfoPtr__GetExpectedCombatOrderWithStrength_b__82_1_Internal_Int32_Tuple_2_WormPlayer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667234);
				WormAIProfile.__c.NativeMethodInfoPtr__GetCardToTrash_b__85_0_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667235);
				WormAIProfile.__c.NativeMethodInfoPtr__GetCardToTrash_b__85_1_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667236);
				WormAIProfile.__c.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667237);
				WormAIProfile.__c.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_3_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667238);
				WormAIProfile.__c.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_6_Internal_ArchetypeID_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667239);
				WormAIProfile.__c.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_4_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667240);
				WormAIProfile.__c.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_5_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667241);
				WormAIProfile.__c.NativeMethodInfoPtr__PossiblePersuasionGain_b__89_0_Internal_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667242);
				WormAIProfile.__c.NativeMethodInfoPtr__PossiblePersuasionGain_b__89_1_Internal_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667243);
				WormAIProfile.__c.NativeMethodInfoPtr__GetBestOption_b__90_1_Internal_AIValueSummer_1_Double_AIValueSummer_1_Double_AIValueSummer_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667244);
				WormAIProfile.__c.NativeMethodInfoPtr__GetFreighterSelections_b__113_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667245);
				WormAIProfile.__c.NativeMethodInfoPtr__ResearchValue_b__114_0_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667246);
				WormAIProfile.__c.NativeMethodInfoPtr__ResearchValue_b__114_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667247);
				WormAIProfile.__c.NativeMethodInfoPtr__ResearchValue_b__114_2_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667248);
				WormAIProfile.__c.NativeMethodInfoPtr__ResearchValue_b__114_3_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr, 100667249);
			}

			// Token: 0x06005054 RID: 20564 RVA: 0x001AA738 File Offset: 0x001A8938
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005055 RID: 20565 RVA: 0x001AA774 File Offset: 0x001A8974
			[CallerCount(0)]
			public unsafe TargetResponse _IsPredeterminedSelection_b__9_0(SelectionNodeFilterData nodeFilterData)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodeFilterData);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__IsPredeterminedSelection_b__9_0_Internal_TargetResponse_SelectionNodeFilterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr3) : null;
				}
			}

			// Token: 0x06005056 RID: 20566 RVA: 0x001AA7C4 File Offset: 0x001A89C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122948, XrefRangeEnd = 122949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MakeChoice_b__10_2(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__MakeChoice_b__10_2_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005057 RID: 20567 RVA: 0x001AA814 File Offset: 0x001A8A14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122949, XrefRangeEnd = 122951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MakeChoice_b__10_3(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__MakeChoice_b__10_3_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005058 RID: 20568 RVA: 0x001AA864 File Offset: 0x001A8A64
			[CallerCount(0)]
			public unsafe bool _MakeChoice_b__10_0(WormAIChoice _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__MakeChoice_b__10_0_Internal_Boolean_WormAIChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005059 RID: 20569 RVA: 0x001AA8B4 File Offset: 0x001A8AB4
			[CallerCount(0)]
			public unsafe double _MakeChoice_b__10_1(WormAIChoice _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__MakeChoice_b__10_1_Internal_Double_WormAIChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600505A RID: 20570 RVA: 0x001AA904 File Offset: 0x001A8B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122951, XrefRangeEnd = 122965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<AgentIcons> _get_DeckAgentIcons_b__17_0(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__get_DeckAgentIcons_b__17_0_Internal_IEnumerable_1_AgentIcons_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AgentIcons>>(intPtr3) : null;
				}
			}

			// Token: 0x0600505B RID: 20571 RVA: 0x001AA954 File Offset: 0x001A8B54
			[CallerCount(0)]
			public unsafe AgentIcons _get_DeckAgentIcons_b__17_1(AgentIcons _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__get_DeckAgentIcons_b__17_1_Internal_AgentIcons_AgentIcons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600505C RID: 20572 RVA: 0x001AA9A0 File Offset: 0x001A8BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122965, XrefRangeEnd = 122969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AgentIcons _get_DeckAgentIcons_b__17_2(IGrouping<AgentIcons, AgentIcons> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__get_DeckAgentIcons_b__17_2_Internal_AgentIcons_IGrouping_2_AgentIcons_AgentIcons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600505D RID: 20573 RVA: 0x001AA9F0 File Offset: 0x001A8BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122969, XrefRangeEnd = 122972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _get_DeckAgentIcons_b__17_3(IGrouping<AgentIcons, AgentIcons> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__get_DeckAgentIcons_b__17_3_Internal_Int32_IGrouping_2_AgentIcons_AgentIcons_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600505E RID: 20574 RVA: 0x001AAA40 File Offset: 0x001A8C40
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WormImperiumPlayable _GetResourceValue_b__28_1(WormImperiumPlayable btc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(btc);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetResourceValue_b__28_1_Internal_WormImperiumPlayable_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr3) : null;
				}
			}

			// Token: 0x0600505F RID: 20575 RVA: 0x001AAA90 File Offset: 0x001A8C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122972, XrefRangeEnd = 122977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _GetResourceValue_b__28_3(KeyValuePair<WormImperiumPlayable, AIValueSummer<double>> kvp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kvp));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetResourceValue_b__28_3_Internal_Double_KeyValuePair_2_WormImperiumPlayable_AIValueSummer_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005060 RID: 20576 RVA: 0x001AAAE4 File Offset: 0x001A8CE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122977, XrefRangeEnd = 122986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TrashMod_b__38_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__TrashMod_b__38_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005061 RID: 20577 RVA: 0x001AAB34 File Offset: 0x001A8D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122986, XrefRangeEnd = 122995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TrashMod_b__38_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__TrashMod_b__38_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005062 RID: 20578 RVA: 0x001AAB84 File Offset: 0x001A8D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122995, XrefRangeEnd = 123003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _TrashMod_b__38_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__TrashMod_b__38_2_Internal_Double_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005063 RID: 20579 RVA: 0x001AABD4 File Offset: 0x001A8DD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123003, XrefRangeEnd = 123004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeployValue_b__39_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__DeployValue_b__39_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005064 RID: 20580 RVA: 0x001AAC24 File Offset: 0x001A8E24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeployValue_b__39_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__DeployValue_b__39_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005065 RID: 20581 RVA: 0x001AAC74 File Offset: 0x001A8E74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeployValue_b__39_2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__DeployValue_b__39_2_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005066 RID: 20582 RVA: 0x001AACC4 File Offset: 0x001A8EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123004, XrefRangeEnd = 123006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeployValue_b__39_3(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__DeployValue_b__39_3_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005067 RID: 20583 RVA: 0x001AAD14 File Offset: 0x001A8F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123006, XrefRangeEnd = 123013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeployValue_b__39_5(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__DeployValue_b__39_5_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005068 RID: 20584 RVA: 0x001AAD64 File Offset: 0x001A8F64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123013, XrefRangeEnd = 123022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeployValue_b__39_4(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__DeployValue_b__39_4_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005069 RID: 20585 RVA: 0x001AADB4 File Offset: 0x001A8FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123022, XrefRangeEnd = 123030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CurrentConflictInterest_b__55_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__CurrentConflictInterest_b__55_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600506A RID: 20586 RVA: 0x001AAE04 File Offset: 0x001A9004
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123030, XrefRangeEnd = 123031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CurrentConflictInterest_b__55_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__CurrentConflictInterest_b__55_1_Internal_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600506B RID: 20587 RVA: 0x001AAE54 File Offset: 0x001A9054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_ConflictCompetitors_b__57_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__get_ConflictCompetitors_b__57_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600506C RID: 20588 RVA: 0x001AAEA4 File Offset: 0x001A90A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123031, XrefRangeEnd = 123036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<StrengthIntrigueAbility> _IntrigueHandStrengthValue_b__63_0(WormIntriguePlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__IntrigueHandStrengthValue_b__63_0_Internal_IEnumerable_1_StrengthIntrigueAbility_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<StrengthIntrigueAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x0600506D RID: 20589 RVA: 0x001AAEF4 File Offset: 0x001A90F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _EstOpponentStrength_b__64_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__EstOpponentStrength_b__64_0_Internal_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600506E RID: 20590 RVA: 0x001AAF44 File Offset: 0x001A9144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _EstStrength_b__65_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__EstStrength_b__65_0_Internal_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600506F RID: 20591 RVA: 0x001AAF94 File Offset: 0x001A9194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123036, XrefRangeEnd = 123045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _EstStrength_b__65_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__EstStrength_b__65_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005070 RID: 20592 RVA: 0x001AAFE4 File Offset: 0x001A91E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _PotentialStrength_b__66_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__PotentialStrength_b__66_0_Internal_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005071 RID: 20593 RVA: 0x001AB034 File Offset: 0x001A9234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123045, XrefRangeEnd = 123054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PotentialStrength_b__66_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__PotentialStrength_b__66_2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005072 RID: 20594 RVA: 0x001AB084 File Offset: 0x001A9284
			[CallerCount(0)]
			public unsafe Factions _GetBestInfluenceExchange_b__69_1(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetBestInfluenceExchange_b__69_1_Internal_Factions_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005073 RID: 20595 RVA: 0x001AB0D0 File Offset: 0x001A92D0
			[CallerCount(0)]
			public unsafe Factions _GetBestInfluenceExchange_b__69_3(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetBestInfluenceExchange_b__69_3_Internal_Factions_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005074 RID: 20596 RVA: 0x001AB11C File Offset: 0x001A931C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123054, XrefRangeEnd = 123056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormAbilityDefinition> _GetSynergyMod_b__70_0(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetSynergyMod_b__70_0_Internal_IEnumerable_1_WormAbilityDefinition_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr3) : null;
				}
			}

			// Token: 0x06005075 RID: 20597 RVA: 0x001AB16C File Offset: 0x001A936C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123056, XrefRangeEnd = 123060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormAbilityDefinition> _GetSynergyMod_b__70_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetSynergyMod_b__70_1_Internal_IEnumerable_1_WormAbilityDefinition_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr3) : null;
				}
			}

			// Token: 0x06005076 RID: 20598 RVA: 0x001AB1BC File Offset: 0x001A93BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123060, XrefRangeEnd = 123064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormAbilityDefinition> _GetSynergyMod_b__70_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetSynergyMod_b__70_2_Internal_IEnumerable_1_WormAbilityDefinition_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr3) : null;
				}
			}

			// Token: 0x06005077 RID: 20599 RVA: 0x001AB20C File Offset: 0x001A940C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<int> _GetUnitsToDeploy_b__74_0(AIValueSummer<int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_0_Internal_AIValueSummer_1_Int32_AIValueSummer_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<int>>(intPtr3) : null;
				}
			}

			// Token: 0x06005078 RID: 20600 RVA: 0x001AB25C File Offset: 0x001A945C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123064, XrefRangeEnd = 123068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetUnitsToDeploy_b__74_1(AIValueSummer<int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_1_Internal_Int32_AIValueSummer_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005079 RID: 20601 RVA: 0x001AB2AC File Offset: 0x001A94AC
			[CallerCount(0)]
			public unsafe int _GetUnitsToDeploy_b__74_2(int _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_2_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600507A RID: 20602 RVA: 0x001AB2F8 File Offset: 0x001A94F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123068, XrefRangeEnd = 123069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetUnitsToDeploy_b__74_3(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_3_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600507B RID: 20603 RVA: 0x001AB348 File Offset: 0x001A9548
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnitsToDeploy_b__74_4(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_4_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600507C RID: 20604 RVA: 0x001AB398 File Offset: 0x001A9598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnitsToDeploy_b__74_9(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_9_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600507D RID: 20605 RVA: 0x001AB3E8 File Offset: 0x001A95E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnitsToDeploy_b__74_10(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_10_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600507E RID: 20606 RVA: 0x001AB438 File Offset: 0x001A9638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetUnitsToDeploy_b__74_5(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_5_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600507F RID: 20607 RVA: 0x001AB488 File Offset: 0x001A9688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnitsToDeploy_b__74_11(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_11_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005080 RID: 20608 RVA: 0x001AB4D8 File Offset: 0x001A96D8
			[CallerCount(0)]
			public unsafe bool _GetUnitsToDeploy_b__74_12(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_12_Internal_Boolean_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005081 RID: 20609 RVA: 0x001AB528 File Offset: 0x001A9728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnitsToDeploy_b__74_13(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_13_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005082 RID: 20610 RVA: 0x001AB578 File Offset: 0x001A9778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetUnitsToDeploy_b__74_8(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetUnitsToDeploy_b__74_8_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005083 RID: 20611 RVA: 0x001AB5C8 File Offset: 0x001A97C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123069, XrefRangeEnd = 123071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetTroopsToRetreat_b__75_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetTroopsToRetreat_b__75_0_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005084 RID: 20612 RVA: 0x001AB618 File Offset: 0x001A9818
			[CallerCount(0)]
			public unsafe int _GetTroopsToRetreat_b__75_1(int _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetTroopsToRetreat_b__75_1_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005085 RID: 20613 RVA: 0x001AB664 File Offset: 0x001A9864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123071, XrefRangeEnd = 123072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetTroopsToRetreat_b__75_3(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetTroopsToRetreat_b__75_3_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005086 RID: 20614 RVA: 0x001AB6B4 File Offset: 0x001A98B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123072, XrefRangeEnd = 123074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTroopsToRetreat_b__75_6(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetTroopsToRetreat_b__75_6_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005087 RID: 20615 RVA: 0x001AB704 File Offset: 0x001A9904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CurrentConflictRank_b__78_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__CurrentConflictRank_b__78_0_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005088 RID: 20616 RVA: 0x001AB754 File Offset: 0x001A9954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123074, XrefRangeEnd = 123081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Tuple<WormPlayer, int> _GetCurrentCombatOrder_b__80_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetCurrentCombatOrder_b__80_0_Internal_Tuple_2_WormPlayer_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<WormPlayer, int>>(intPtr3) : null;
				}
			}

			// Token: 0x06005089 RID: 20617 RVA: 0x001AB7A4 File Offset: 0x001A99A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123081, XrefRangeEnd = 123082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetCurrentCombatOrder_b__80_1(Tuple<WormPlayer, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetCurrentCombatOrder_b__80_1_Internal_Int32_Tuple_2_WormPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600508A RID: 20618 RVA: 0x001AB7F4 File Offset: 0x001A99F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123082, XrefRangeEnd = 123083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WormPlayer _GetCurrentCombatOrder_b__80_2(Tuple<WormPlayer, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetCurrentCombatOrder_b__80_2_Internal_WormPlayer_Tuple_2_WormPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
				}
			}

			// Token: 0x0600508B RID: 20619 RVA: 0x001AB844 File Offset: 0x001A9A44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123083, XrefRangeEnd = 123084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WormPlayer _GetExpectedCombatOrder_b__81_0(Tuple<WormPlayer, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetExpectedCombatOrder_b__81_0_Internal_WormPlayer_Tuple_2_WormPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr3) : null;
				}
			}

			// Token: 0x0600508C RID: 20620 RVA: 0x001AB894 File Offset: 0x001A9A94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123084, XrefRangeEnd = 123085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetExpectedCombatOrderWithStrength_b__82_1(Tuple<WormPlayer, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetExpectedCombatOrderWithStrength_b__82_1_Internal_Int32_Tuple_2_WormPlayer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600508D RID: 20621 RVA: 0x001AB8E4 File Offset: 0x001A9AE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123085, XrefRangeEnd = 123094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetCardToTrash_b__85_0(WormImperiumPlayable wip)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(wip);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetCardToTrash_b__85_0_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600508E RID: 20622 RVA: 0x001AB934 File Offset: 0x001A9B34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123094, XrefRangeEnd = 123101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetCardToTrash_b__85_1(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetCardToTrash_b__85_1_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600508F RID: 20623 RVA: 0x001AB984 File Offset: 0x001A9B84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123101, XrefRangeEnd = 123110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetHeighlinerPotentialPlayer_b__86_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005090 RID: 20624 RVA: 0x001AB9D4 File Offset: 0x001A9BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123110, XrefRangeEnd = 123119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetHeighlinerPotentialPlayer_b__86_3(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_3_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005091 RID: 20625 RVA: 0x001ABA24 File Offset: 0x001A9C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _GetHeighlinerPotentialPlayer_b__86_6(WormPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_6_Internal_ArchetypeID_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x06005092 RID: 20626 RVA: 0x001ABA74 File Offset: 0x001A9C74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123119, XrefRangeEnd = 123128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetHeighlinerPotentialPlayer_b__86_4(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_4_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005093 RID: 20627 RVA: 0x001ABAC4 File Offset: 0x001A9CC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123128, XrefRangeEnd = 123145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetHeighlinerPotentialPlayer_b__86_5(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_5_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005094 RID: 20628 RVA: 0x001ABB14 File Offset: 0x001A9D14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123145, XrefRangeEnd = 123146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _PossiblePersuasionGain_b__89_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__PossiblePersuasionGain_b__89_0_Internal_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005095 RID: 20629 RVA: 0x001ABB64 File Offset: 0x001A9D64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _PossiblePersuasionGain_b__89_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__PossiblePersuasionGain_b__89_1_Internal_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005096 RID: 20630 RVA: 0x001ABBB4 File Offset: 0x001A9DB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123146, XrefRangeEnd = 123149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _GetBestOption_b__90_1(AIValueSummer<double> a, AIValueSummer<double> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetBestOption_b__90_1_Internal_AIValueSummer_1_Double_AIValueSummer_1_Double_AIValueSummer_1_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}

			// Token: 0x06005097 RID: 20631 RVA: 0x001ABC18 File Offset: 0x001A9E18
			[CallerCount(0)]
			public unsafe IEnumerable<Entity> _GetFreighterSelections_b__113_0(WormTechTileStack _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__GetFreighterSelections_b__113_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06005098 RID: 20632 RVA: 0x001ABC68 File Offset: 0x001A9E68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123149, XrefRangeEnd = 123154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResearchValue_b__114_0(WormImperiumPlayable imperium)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(imperium);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__ResearchValue_b__114_0_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005099 RID: 20633 RVA: 0x001ABCB8 File Offset: 0x001A9EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123154, XrefRangeEnd = 123159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResearchValue_b__114_1(Entity intrigue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(intrigue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__ResearchValue_b__114_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600509A RID: 20634 RVA: 0x001ABD08 File Offset: 0x001A9F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123159, XrefRangeEnd = 123164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResearchValue_b__114_2(WormImperiumPlayable imperium)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(imperium);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__ResearchValue_b__114_2_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600509B RID: 20635 RVA: 0x001ABD58 File Offset: 0x001A9F58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123164, XrefRangeEnd = 123169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResearchValue_b__114_3(Entity intrigue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(intrigue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c.NativeMethodInfoPtr__ResearchValue_b__114_3_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600509C RID: 20636 RVA: 0x0001BCF1 File Offset: 0x00019EF1
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013C7 RID: 5063
			// (get) Token: 0x0600509D RID: 20637 RVA: 0x001ABDA8 File Offset: 0x001A9FA8
			// (set) Token: 0x0600509E RID: 20638 RVA: 0x0001BCFA File Offset: 0x00019EFA
			public unsafe static WormAIProfile.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIProfile.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013C8 RID: 5064
			// (get) Token: 0x0600509F RID: 20639 RVA: 0x001ABDD0 File Offset: 0x001A9FD0
			// (set) Token: 0x060050A0 RID: 20640 RVA: 0x0001BD0C File Offset: 0x00019F0C
			public unsafe static Func<SelectionNodeFilterData, TargetResponse> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SelectionNodeFilterData, TargetResponse>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013C9 RID: 5065
			// (get) Token: 0x060050A1 RID: 20641 RVA: 0x001ABDF8 File Offset: 0x001A9FF8
			// (set) Token: 0x060050A2 RID: 20642 RVA: 0x0001BD1E File Offset: 0x00019F1E
			public unsafe static Func<WormAbilityDefinition, bool> __9__10_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__10_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__10_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013CA RID: 5066
			// (get) Token: 0x060050A3 RID: 20643 RVA: 0x001ABE20 File Offset: 0x001AA020
			// (set) Token: 0x060050A4 RID: 20644 RVA: 0x0001BD30 File Offset: 0x00019F30
			public unsafe static Func<WormAbilityDefinition, bool> __9__10_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__10_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__10_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013CB RID: 5067
			// (get) Token: 0x060050A5 RID: 20645 RVA: 0x001ABE48 File Offset: 0x001AA048
			// (set) Token: 0x060050A6 RID: 20646 RVA: 0x0001BD42 File Offset: 0x00019F42
			public unsafe static Func<WormAIChoice, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAIChoice, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013CC RID: 5068
			// (get) Token: 0x060050A7 RID: 20647 RVA: 0x001ABE70 File Offset: 0x001AA070
			// (set) Token: 0x060050A8 RID: 20648 RVA: 0x0001BD54 File Offset: 0x00019F54
			public unsafe static Func<WormAIChoice, double> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAIChoice, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013CD RID: 5069
			// (get) Token: 0x060050A9 RID: 20649 RVA: 0x001ABE98 File Offset: 0x001AA098
			// (set) Token: 0x060050AA RID: 20650 RVA: 0x0001BD66 File Offset: 0x00019F66
			public unsafe static Func<WormImperiumPlayable, IEnumerable<AgentIcons>> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, IEnumerable<AgentIcons>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013CE RID: 5070
			// (get) Token: 0x060050AB RID: 20651 RVA: 0x001ABEC0 File Offset: 0x001AA0C0
			// (set) Token: 0x060050AC RID: 20652 RVA: 0x0001BD78 File Offset: 0x00019F78
			public unsafe static Func<AgentIcons, AgentIcons> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AgentIcons, AgentIcons>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013CF RID: 5071
			// (get) Token: 0x060050AD RID: 20653 RVA: 0x001ABEE8 File Offset: 0x001AA0E8
			// (set) Token: 0x060050AE RID: 20654 RVA: 0x0001BD8A File Offset: 0x00019F8A
			public unsafe static Func<IGrouping<AgentIcons, AgentIcons>, AgentIcons> __9__17_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__17_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<AgentIcons, AgentIcons>, AgentIcons>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__17_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013D0 RID: 5072
			// (get) Token: 0x060050AF RID: 20655 RVA: 0x001ABF10 File Offset: 0x001AA110
			// (set) Token: 0x060050B0 RID: 20656 RVA: 0x0001BD9C File Offset: 0x00019F9C
			public unsafe static Func<IGrouping<AgentIcons, AgentIcons>, int> __9__17_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__17_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<AgentIcons, AgentIcons>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__17_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013D1 RID: 5073
			// (get) Token: 0x060050B1 RID: 20657 RVA: 0x001ABF38 File Offset: 0x001AA138
			// (set) Token: 0x060050B2 RID: 20658 RVA: 0x0001BDAE File Offset: 0x00019FAE
			public unsafe static Func<WormImperiumPlayable, WormImperiumPlayable> __9__28_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__28_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, WormImperiumPlayable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__28_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013D2 RID: 5074
			// (get) Token: 0x060050B3 RID: 20659 RVA: 0x001ABF60 File Offset: 0x001AA160
			// (set) Token: 0x060050B4 RID: 20660 RVA: 0x0001BDC0 File Offset: 0x00019FC0
			public unsafe static Func<KeyValuePair<WormImperiumPlayable, AIValueSummer<double>>, double> __9__28_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__28_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<WormImperiumPlayable, AIValueSummer<double>>, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__28_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013D3 RID: 5075
			// (get) Token: 0x060050B5 RID: 20661 RVA: 0x001ABF88 File Offset: 0x001AA188
			// (set) Token: 0x060050B6 RID: 20662 RVA: 0x0001BDD2 File Offset: 0x00019FD2
			public unsafe static Predicate<Entity> __9__38_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__38_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__38_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013D4 RID: 5076
			// (get) Token: 0x060050B7 RID: 20663 RVA: 0x001ABFB0 File Offset: 0x001AA1B0
			// (set) Token: 0x060050B8 RID: 20664 RVA: 0x0001BDE4 File Offset: 0x00019FE4
			public unsafe static Predicate<Entity> __9__38_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__38_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Entity>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__38_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013D5 RID: 5077
			// (get) Token: 0x060050B9 RID: 20665 RVA: 0x001ABFD8 File Offset: 0x001AA1D8
			// (set) Token: 0x060050BA RID: 20666 RVA: 0x0001BDF6 File Offset: 0x00019FF6
			public unsafe static Func<Entity, double> __9__38_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__38_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__38_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013D6 RID: 5078
			// (get) Token: 0x060050BB RID: 20667 RVA: 0x001AC000 File Offset: 0x001AA200
			// (set) Token: 0x060050BC RID: 20668 RVA: 0x0001BE08 File Offset: 0x0001A008
			public unsafe static Func<WormPlayer, bool> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013D7 RID: 5079
			// (get) Token: 0x060050BD RID: 20669 RVA: 0x001AC028 File Offset: 0x001AA228
			// (set) Token: 0x060050BE RID: 20670 RVA: 0x0001BE1A File Offset: 0x0001A01A
			public unsafe static Func<WormPlayer, bool> __9__39_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__39_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__39_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013D8 RID: 5080
			// (get) Token: 0x060050BF RID: 20671 RVA: 0x001AC050 File Offset: 0x001AA250
			// (set) Token: 0x060050C0 RID: 20672 RVA: 0x0001BE2C File Offset: 0x0001A02C
			public unsafe static Func<WormPlayer, bool> __9__39_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__39_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__39_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013D9 RID: 5081
			// (get) Token: 0x060050C1 RID: 20673 RVA: 0x001AC078 File Offset: 0x001AA278
			// (set) Token: 0x060050C2 RID: 20674 RVA: 0x0001BE3E File Offset: 0x0001A03E
			public unsafe static Func<WormPlayer, bool> __9__39_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__39_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__39_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013DA RID: 5082
			// (get) Token: 0x060050C3 RID: 20675 RVA: 0x001AC0A0 File Offset: 0x001AA2A0
			// (set) Token: 0x060050C4 RID: 20676 RVA: 0x0001BE50 File Offset: 0x0001A050
			public unsafe static Func<WormAbilityDefinition, bool> __9__39_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__39_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__39_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013DB RID: 5083
			// (get) Token: 0x060050C5 RID: 20677 RVA: 0x001AC0C8 File Offset: 0x001AA2C8
			// (set) Token: 0x060050C6 RID: 20678 RVA: 0x0001BE62 File Offset: 0x0001A062
			public unsafe static Func<Entity, bool> __9__39_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__39_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__39_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013DC RID: 5084
			// (get) Token: 0x060050C7 RID: 20679 RVA: 0x001AC0F0 File Offset: 0x001AA2F0
			// (set) Token: 0x060050C8 RID: 20680 RVA: 0x0001BE74 File Offset: 0x0001A074
			public unsafe static Func<WormPlayer, bool> __9__55_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__55_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__55_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013DD RID: 5085
			// (get) Token: 0x060050C9 RID: 20681 RVA: 0x001AC118 File Offset: 0x001AA318
			// (set) Token: 0x060050CA RID: 20682 RVA: 0x0001BE86 File Offset: 0x0001A086
			public unsafe static Func<Entity, int> __9__55_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__55_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__55_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013DE RID: 5086
			// (get) Token: 0x060050CB RID: 20683 RVA: 0x001AC140 File Offset: 0x001AA340
			// (set) Token: 0x060050CC RID: 20684 RVA: 0x0001BE98 File Offset: 0x0001A098
			public unsafe static Func<WormPlayer, bool> __9__57_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__57_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__57_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013DF RID: 5087
			// (get) Token: 0x060050CD RID: 20685 RVA: 0x001AC168 File Offset: 0x001AA368
			// (set) Token: 0x060050CE RID: 20686 RVA: 0x0001BEAA File Offset: 0x0001A0AA
			public unsafe static Func<WormIntriguePlayable, IEnumerable<StrengthIntrigueAbility>> __9__63_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__63_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormIntriguePlayable, IEnumerable<StrengthIntrigueAbility>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__63_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E0 RID: 5088
			// (get) Token: 0x060050CF RID: 20687 RVA: 0x001AC190 File Offset: 0x001AA390
			// (set) Token: 0x060050D0 RID: 20688 RVA: 0x0001BEBC File Offset: 0x0001A0BC
			public unsafe static Func<Entity, int> __9__64_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__64_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__64_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E1 RID: 5089
			// (get) Token: 0x060050D1 RID: 20689 RVA: 0x001AC1B8 File Offset: 0x001AA3B8
			// (set) Token: 0x060050D2 RID: 20690 RVA: 0x0001BECE File Offset: 0x0001A0CE
			public unsafe static Func<Entity, int> __9__65_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__65_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__65_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E2 RID: 5090
			// (get) Token: 0x060050D3 RID: 20691 RVA: 0x001AC1E0 File Offset: 0x001AA3E0
			// (set) Token: 0x060050D4 RID: 20692 RVA: 0x0001BEE0 File Offset: 0x0001A0E0
			public unsafe static Func<Entity, bool> __9__65_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__65_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__65_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E3 RID: 5091
			// (get) Token: 0x060050D5 RID: 20693 RVA: 0x001AC208 File Offset: 0x001AA408
			// (set) Token: 0x060050D6 RID: 20694 RVA: 0x0001BEF2 File Offset: 0x0001A0F2
			public unsafe static Func<Entity, int> __9__66_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__66_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__66_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E4 RID: 5092
			// (get) Token: 0x060050D7 RID: 20695 RVA: 0x001AC230 File Offset: 0x001AA430
			// (set) Token: 0x060050D8 RID: 20696 RVA: 0x0001BF04 File Offset: 0x0001A104
			public unsafe static Func<Entity, bool> __9__66_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__66_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__66_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E5 RID: 5093
			// (get) Token: 0x060050D9 RID: 20697 RVA: 0x001AC258 File Offset: 0x001AA458
			// (set) Token: 0x060050DA RID: 20698 RVA: 0x0001BF16 File Offset: 0x0001A116
			public unsafe static Func<Factions, Factions> __9__69_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__69_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Factions, Factions>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__69_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E6 RID: 5094
			// (get) Token: 0x060050DB RID: 20699 RVA: 0x001AC280 File Offset: 0x001AA480
			// (set) Token: 0x060050DC RID: 20700 RVA: 0x0001BF28 File Offset: 0x0001A128
			public unsafe static Func<Factions, Factions> __9__69_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__69_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Factions, Factions>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__69_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E7 RID: 5095
			// (get) Token: 0x060050DD RID: 20701 RVA: 0x001AC2A8 File Offset: 0x001AA4A8
			// (set) Token: 0x060050DE RID: 20702 RVA: 0x0001BF3A File Offset: 0x0001A13A
			public unsafe static Func<WormImperiumPlayable, IEnumerable<WormAbilityDefinition>> __9__70_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__70_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, IEnumerable<WormAbilityDefinition>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__70_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E8 RID: 5096
			// (get) Token: 0x060050DF RID: 20703 RVA: 0x001AC2D0 File Offset: 0x001AA4D0
			// (set) Token: 0x060050E0 RID: 20704 RVA: 0x0001BF4C File Offset: 0x0001A14C
			public unsafe static Func<Entity, IEnumerable<WormAbilityDefinition>> __9__70_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__70_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, IEnumerable<WormAbilityDefinition>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__70_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E9 RID: 5097
			// (get) Token: 0x060050E1 RID: 20705 RVA: 0x001AC2F8 File Offset: 0x001AA4F8
			// (set) Token: 0x060050E2 RID: 20706 RVA: 0x0001BF5E File Offset: 0x0001A15E
			public unsafe static Func<Entity, IEnumerable<WormAbilityDefinition>> __9__70_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__70_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, IEnumerable<WormAbilityDefinition>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__70_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013EA RID: 5098
			// (get) Token: 0x060050E3 RID: 20707 RVA: 0x001AC320 File Offset: 0x001AA520
			// (set) Token: 0x060050E4 RID: 20708 RVA: 0x0001BF70 File Offset: 0x0001A170
			public unsafe static Func<AIValueSummer<int>, AIValueSummer<int>> __9__74_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIValueSummer<int>, AIValueSummer<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013EB RID: 5099
			// (get) Token: 0x060050E5 RID: 20709 RVA: 0x001AC348 File Offset: 0x001AA548
			// (set) Token: 0x060050E6 RID: 20710 RVA: 0x0001BF82 File Offset: 0x0001A182
			public unsafe static Func<AIValueSummer<int>, int> __9__74_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIValueSummer<int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013EC RID: 5100
			// (get) Token: 0x060050E7 RID: 20711 RVA: 0x001AC370 File Offset: 0x001AA570
			// (set) Token: 0x060050E8 RID: 20712 RVA: 0x0001BF94 File Offset: 0x0001A194
			public unsafe static Func<int, int> __9__74_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013ED RID: 5101
			// (get) Token: 0x060050E9 RID: 20713 RVA: 0x001AC398 File Offset: 0x001AA598
			// (set) Token: 0x060050EA RID: 20714 RVA: 0x0001BFA6 File Offset: 0x0001A1A6
			public unsafe static Func<WormUnit, int> __9__74_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013EE RID: 5102
			// (get) Token: 0x060050EB RID: 20715 RVA: 0x001AC3C0 File Offset: 0x001AA5C0
			// (set) Token: 0x060050EC RID: 20716 RVA: 0x0001BFB8 File Offset: 0x0001A1B8
			public unsafe static Func<WormPlayer, bool> __9__74_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013EF RID: 5103
			// (get) Token: 0x060050ED RID: 20717 RVA: 0x001AC3E8 File Offset: 0x001AA5E8
			// (set) Token: 0x060050EE RID: 20718 RVA: 0x0001BFCA File Offset: 0x0001A1CA
			public unsafe static Func<WormPlayer, bool> __9__74_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F0 RID: 5104
			// (get) Token: 0x060050EF RID: 20719 RVA: 0x001AC410 File Offset: 0x001AA610
			// (set) Token: 0x060050F0 RID: 20720 RVA: 0x0001BFDC File Offset: 0x0001A1DC
			public unsafe static Func<WormPlayer, bool> __9__74_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F1 RID: 5105
			// (get) Token: 0x060050F1 RID: 20721 RVA: 0x001AC438 File Offset: 0x001AA638
			// (set) Token: 0x060050F2 RID: 20722 RVA: 0x0001BFEE File Offset: 0x0001A1EE
			public unsafe static Func<WormUnit, int> __9__74_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F2 RID: 5106
			// (get) Token: 0x060050F3 RID: 20723 RVA: 0x001AC460 File Offset: 0x001AA660
			// (set) Token: 0x060050F4 RID: 20724 RVA: 0x0001C000 File Offset: 0x0001A200
			public unsafe static Func<Entity, bool> __9__74_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F3 RID: 5107
			// (get) Token: 0x060050F5 RID: 20725 RVA: 0x001AC488 File Offset: 0x001AA688
			// (set) Token: 0x060050F6 RID: 20726 RVA: 0x0001C012 File Offset: 0x0001A212
			public unsafe static Predicate<WormUnit> __9__74_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<WormUnit>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F4 RID: 5108
			// (get) Token: 0x060050F7 RID: 20727 RVA: 0x001AC4B0 File Offset: 0x001AA6B0
			// (set) Token: 0x060050F8 RID: 20728 RVA: 0x0001C024 File Offset: 0x0001A224
			public unsafe static Func<Entity, bool> __9__74_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F5 RID: 5109
			// (get) Token: 0x060050F9 RID: 20729 RVA: 0x001AC4D8 File Offset: 0x001AA6D8
			// (set) Token: 0x060050FA RID: 20730 RVA: 0x0001C036 File Offset: 0x0001A236
			public unsafe static Func<WormUnit, int> __9__74_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__74_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F6 RID: 5110
			// (get) Token: 0x060050FB RID: 20731 RVA: 0x001AC500 File Offset: 0x001AA700
			// (set) Token: 0x060050FC RID: 20732 RVA: 0x0001C048 File Offset: 0x0001A248
			public unsafe static Func<WormPlayer, int> __9__75_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__75_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__75_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F7 RID: 5111
			// (get) Token: 0x060050FD RID: 20733 RVA: 0x001AC528 File Offset: 0x001AA728
			// (set) Token: 0x060050FE RID: 20734 RVA: 0x0001C05A File Offset: 0x0001A25A
			public unsafe static Func<int, int> __9__75_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__75_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__75_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F8 RID: 5112
			// (get) Token: 0x060050FF RID: 20735 RVA: 0x001AC550 File Offset: 0x001AA750
			// (set) Token: 0x06005100 RID: 20736 RVA: 0x0001C06C File Offset: 0x0001A26C
			public unsafe static Func<WormPlayer, int> __9__75_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__75_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__75_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013F9 RID: 5113
			// (get) Token: 0x06005101 RID: 20737 RVA: 0x001AC578 File Offset: 0x001AA778
			// (set) Token: 0x06005102 RID: 20738 RVA: 0x0001C07E File Offset: 0x0001A27E
			public unsafe static Func<WormPlayer, bool> __9__75_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__75_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__75_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013FA RID: 5114
			// (get) Token: 0x06005103 RID: 20739 RVA: 0x001AC5A0 File Offset: 0x001AA7A0
			// (set) Token: 0x06005104 RID: 20740 RVA: 0x0001C090 File Offset: 0x0001A290
			public unsafe static Func<WormPlayer, int> __9__78_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__78_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__78_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013FB RID: 5115
			// (get) Token: 0x06005105 RID: 20741 RVA: 0x001AC5C8 File Offset: 0x001AA7C8
			// (set) Token: 0x06005106 RID: 20742 RVA: 0x0001C0A2 File Offset: 0x0001A2A2
			public unsafe static Func<WormPlayer, Tuple<WormPlayer, int>> __9__80_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__80_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, Tuple<WormPlayer, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__80_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013FC RID: 5116
			// (get) Token: 0x06005107 RID: 20743 RVA: 0x001AC5F0 File Offset: 0x001AA7F0
			// (set) Token: 0x06005108 RID: 20744 RVA: 0x0001C0B4 File Offset: 0x0001A2B4
			public unsafe static Func<Tuple<WormPlayer, int>, int> __9__80_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__80_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<WormPlayer, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__80_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013FD RID: 5117
			// (get) Token: 0x06005109 RID: 20745 RVA: 0x001AC618 File Offset: 0x001AA818
			// (set) Token: 0x0600510A RID: 20746 RVA: 0x0001C0C6 File Offset: 0x0001A2C6
			public unsafe static Func<Tuple<WormPlayer, int>, WormPlayer> __9__80_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__80_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<WormPlayer, int>, WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__80_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013FE RID: 5118
			// (get) Token: 0x0600510B RID: 20747 RVA: 0x001AC640 File Offset: 0x001AA840
			// (set) Token: 0x0600510C RID: 20748 RVA: 0x0001C0D8 File Offset: 0x0001A2D8
			public unsafe static Func<Tuple<WormPlayer, int>, WormPlayer> __9__81_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__81_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<WormPlayer, int>, WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__81_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013FF RID: 5119
			// (get) Token: 0x0600510D RID: 20749 RVA: 0x001AC668 File Offset: 0x001AA868
			// (set) Token: 0x0600510E RID: 20750 RVA: 0x0001C0EA File Offset: 0x0001A2EA
			public unsafe static Func<Tuple<WormPlayer, int>, int> __9__82_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__82_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Tuple<WormPlayer, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__82_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001400 RID: 5120
			// (get) Token: 0x0600510F RID: 20751 RVA: 0x001AC690 File Offset: 0x001AA890
			// (set) Token: 0x06005110 RID: 20752 RVA: 0x0001C0FC File Offset: 0x0001A2FC
			public unsafe static Func<WormImperiumPlayable, bool> __9__85_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__85_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__85_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001401 RID: 5121
			// (get) Token: 0x06005111 RID: 20753 RVA: 0x001AC6B8 File Offset: 0x001AA8B8
			// (set) Token: 0x06005112 RID: 20754 RVA: 0x0001C10E File Offset: 0x0001A30E
			public unsafe static Func<WormImperiumPlayable, bool> __9__85_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__85_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__85_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001402 RID: 5122
			// (get) Token: 0x06005113 RID: 20755 RVA: 0x001AC6E0 File Offset: 0x001AA8E0
			// (set) Token: 0x06005114 RID: 20756 RVA: 0x0001C120 File Offset: 0x0001A320
			public unsafe static Func<Entity, bool> __9__86_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__86_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__86_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001403 RID: 5123
			// (get) Token: 0x06005115 RID: 20757 RVA: 0x001AC708 File Offset: 0x001AA908
			// (set) Token: 0x06005116 RID: 20758 RVA: 0x0001C132 File Offset: 0x0001A332
			public unsafe static Func<Entity, bool> __9__86_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__86_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__86_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001404 RID: 5124
			// (get) Token: 0x06005117 RID: 20759 RVA: 0x001AC730 File Offset: 0x001AA930
			// (set) Token: 0x06005118 RID: 20760 RVA: 0x0001C144 File Offset: 0x0001A344
			public unsafe static Func<WormPlayable, ArchetypeID> __9__86_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__86_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__86_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001405 RID: 5125
			// (get) Token: 0x06005119 RID: 20761 RVA: 0x001AC758 File Offset: 0x001AA958
			// (set) Token: 0x0600511A RID: 20762 RVA: 0x0001C156 File Offset: 0x0001A356
			public unsafe static Func<Entity, bool> __9__86_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__86_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__86_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001406 RID: 5126
			// (get) Token: 0x0600511B RID: 20763 RVA: 0x001AC780 File Offset: 0x001AA980
			// (set) Token: 0x0600511C RID: 20764 RVA: 0x0001C168 File Offset: 0x0001A368
			public unsafe static Func<WormImperiumPlayable, bool> __9__86_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__86_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__86_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001407 RID: 5127
			// (get) Token: 0x0600511D RID: 20765 RVA: 0x001AC7A8 File Offset: 0x001AA9A8
			// (set) Token: 0x0600511E RID: 20766 RVA: 0x0001C17A File Offset: 0x0001A37A
			public unsafe static Func<Entity, int> __9__89_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__89_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__89_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001408 RID: 5128
			// (get) Token: 0x0600511F RID: 20767 RVA: 0x001AC7D0 File Offset: 0x001AA9D0
			// (set) Token: 0x06005120 RID: 20768 RVA: 0x0001C18C File Offset: 0x0001A38C
			public unsafe static Func<Entity, int> __9__89_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__89_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__89_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001409 RID: 5129
			// (get) Token: 0x06005121 RID: 20769 RVA: 0x001AC7F8 File Offset: 0x001AA9F8
			// (set) Token: 0x06005122 RID: 20770 RVA: 0x0001C19E File Offset: 0x0001A39E
			public unsafe static Func<AIValueSummer<double>, AIValueSummer<double>, AIValueSummer<double>> __9__90_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__90_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AIValueSummer<double>, AIValueSummer<double>, AIValueSummer<double>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__90_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700140A RID: 5130
			// (get) Token: 0x06005123 RID: 20771 RVA: 0x001AC820 File Offset: 0x001AAA20
			// (set) Token: 0x06005124 RID: 20772 RVA: 0x0001C1B0 File Offset: 0x0001A3B0
			public unsafe static Func<WormTechTileStack, IEnumerable<Entity>> __9__113_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__113_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTileStack, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__113_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700140B RID: 5131
			// (get) Token: 0x06005125 RID: 20773 RVA: 0x001AC848 File Offset: 0x001AAA48
			// (set) Token: 0x06005126 RID: 20774 RVA: 0x0001C1C2 File Offset: 0x0001A3C2
			public unsafe static Func<WormImperiumPlayable, bool> __9__114_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__114_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__114_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700140C RID: 5132
			// (get) Token: 0x06005127 RID: 20775 RVA: 0x001AC870 File Offset: 0x001AAA70
			// (set) Token: 0x06005128 RID: 20776 RVA: 0x0001C1D4 File Offset: 0x0001A3D4
			public unsafe static Func<Entity, bool> __9__114_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__114_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__114_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700140D RID: 5133
			// (get) Token: 0x06005129 RID: 20777 RVA: 0x001AC898 File Offset: 0x001AAA98
			// (set) Token: 0x0600512A RID: 20778 RVA: 0x0001C1E6 File Offset: 0x0001A3E6
			public unsafe static Func<WormImperiumPlayable, bool> __9__114_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__114_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__114_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700140E RID: 5134
			// (get) Token: 0x0600512B RID: 20779 RVA: 0x001AC8C0 File Offset: 0x001AAAC0
			// (set) Token: 0x0600512C RID: 20780 RVA: 0x0001C1F8 File Offset: 0x0001A3F8
			public unsafe static Func<Entity, bool> __9__114_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAIProfile.__c.NativeFieldInfoPtr___9__114_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAIProfile.__c.NativeFieldInfoPtr___9__114_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040034B3 RID: 13491
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040034B4 RID: 13492
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040034B5 RID: 13493
			private static readonly IntPtr NativeFieldInfoPtr___9__10_2;

			// Token: 0x040034B6 RID: 13494
			private static readonly IntPtr NativeFieldInfoPtr___9__10_3;

			// Token: 0x040034B7 RID: 13495
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x040034B8 RID: 13496
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x040034B9 RID: 13497
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x040034BA RID: 13498
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x040034BB RID: 13499
			private static readonly IntPtr NativeFieldInfoPtr___9__17_2;

			// Token: 0x040034BC RID: 13500
			private static readonly IntPtr NativeFieldInfoPtr___9__17_3;

			// Token: 0x040034BD RID: 13501
			private static readonly IntPtr NativeFieldInfoPtr___9__28_1;

			// Token: 0x040034BE RID: 13502
			private static readonly IntPtr NativeFieldInfoPtr___9__28_3;

			// Token: 0x040034BF RID: 13503
			private static readonly IntPtr NativeFieldInfoPtr___9__38_0;

			// Token: 0x040034C0 RID: 13504
			private static readonly IntPtr NativeFieldInfoPtr___9__38_1;

			// Token: 0x040034C1 RID: 13505
			private static readonly IntPtr NativeFieldInfoPtr___9__38_2;

			// Token: 0x040034C2 RID: 13506
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x040034C3 RID: 13507
			private static readonly IntPtr NativeFieldInfoPtr___9__39_1;

			// Token: 0x040034C4 RID: 13508
			private static readonly IntPtr NativeFieldInfoPtr___9__39_2;

			// Token: 0x040034C5 RID: 13509
			private static readonly IntPtr NativeFieldInfoPtr___9__39_3;

			// Token: 0x040034C6 RID: 13510
			private static readonly IntPtr NativeFieldInfoPtr___9__39_5;

			// Token: 0x040034C7 RID: 13511
			private static readonly IntPtr NativeFieldInfoPtr___9__39_4;

			// Token: 0x040034C8 RID: 13512
			private static readonly IntPtr NativeFieldInfoPtr___9__55_0;

			// Token: 0x040034C9 RID: 13513
			private static readonly IntPtr NativeFieldInfoPtr___9__55_1;

			// Token: 0x040034CA RID: 13514
			private static readonly IntPtr NativeFieldInfoPtr___9__57_0;

			// Token: 0x040034CB RID: 13515
			private static readonly IntPtr NativeFieldInfoPtr___9__63_0;

			// Token: 0x040034CC RID: 13516
			private static readonly IntPtr NativeFieldInfoPtr___9__64_0;

			// Token: 0x040034CD RID: 13517
			private static readonly IntPtr NativeFieldInfoPtr___9__65_0;

			// Token: 0x040034CE RID: 13518
			private static readonly IntPtr NativeFieldInfoPtr___9__65_1;

			// Token: 0x040034CF RID: 13519
			private static readonly IntPtr NativeFieldInfoPtr___9__66_0;

			// Token: 0x040034D0 RID: 13520
			private static readonly IntPtr NativeFieldInfoPtr___9__66_2;

			// Token: 0x040034D1 RID: 13521
			private static readonly IntPtr NativeFieldInfoPtr___9__69_1;

			// Token: 0x040034D2 RID: 13522
			private static readonly IntPtr NativeFieldInfoPtr___9__69_3;

			// Token: 0x040034D3 RID: 13523
			private static readonly IntPtr NativeFieldInfoPtr___9__70_0;

			// Token: 0x040034D4 RID: 13524
			private static readonly IntPtr NativeFieldInfoPtr___9__70_1;

			// Token: 0x040034D5 RID: 13525
			private static readonly IntPtr NativeFieldInfoPtr___9__70_2;

			// Token: 0x040034D6 RID: 13526
			private static readonly IntPtr NativeFieldInfoPtr___9__74_0;

			// Token: 0x040034D7 RID: 13527
			private static readonly IntPtr NativeFieldInfoPtr___9__74_1;

			// Token: 0x040034D8 RID: 13528
			private static readonly IntPtr NativeFieldInfoPtr___9__74_2;

			// Token: 0x040034D9 RID: 13529
			private static readonly IntPtr NativeFieldInfoPtr___9__74_3;

			// Token: 0x040034DA RID: 13530
			private static readonly IntPtr NativeFieldInfoPtr___9__74_4;

			// Token: 0x040034DB RID: 13531
			private static readonly IntPtr NativeFieldInfoPtr___9__74_9;

			// Token: 0x040034DC RID: 13532
			private static readonly IntPtr NativeFieldInfoPtr___9__74_10;

			// Token: 0x040034DD RID: 13533
			private static readonly IntPtr NativeFieldInfoPtr___9__74_5;

			// Token: 0x040034DE RID: 13534
			private static readonly IntPtr NativeFieldInfoPtr___9__74_11;

			// Token: 0x040034DF RID: 13535
			private static readonly IntPtr NativeFieldInfoPtr___9__74_12;

			// Token: 0x040034E0 RID: 13536
			private static readonly IntPtr NativeFieldInfoPtr___9__74_13;

			// Token: 0x040034E1 RID: 13537
			private static readonly IntPtr NativeFieldInfoPtr___9__74_8;

			// Token: 0x040034E2 RID: 13538
			private static readonly IntPtr NativeFieldInfoPtr___9__75_0;

			// Token: 0x040034E3 RID: 13539
			private static readonly IntPtr NativeFieldInfoPtr___9__75_1;

			// Token: 0x040034E4 RID: 13540
			private static readonly IntPtr NativeFieldInfoPtr___9__75_3;

			// Token: 0x040034E5 RID: 13541
			private static readonly IntPtr NativeFieldInfoPtr___9__75_6;

			// Token: 0x040034E6 RID: 13542
			private static readonly IntPtr NativeFieldInfoPtr___9__78_0;

			// Token: 0x040034E7 RID: 13543
			private static readonly IntPtr NativeFieldInfoPtr___9__80_0;

			// Token: 0x040034E8 RID: 13544
			private static readonly IntPtr NativeFieldInfoPtr___9__80_1;

			// Token: 0x040034E9 RID: 13545
			private static readonly IntPtr NativeFieldInfoPtr___9__80_2;

			// Token: 0x040034EA RID: 13546
			private static readonly IntPtr NativeFieldInfoPtr___9__81_0;

			// Token: 0x040034EB RID: 13547
			private static readonly IntPtr NativeFieldInfoPtr___9__82_1;

			// Token: 0x040034EC RID: 13548
			private static readonly IntPtr NativeFieldInfoPtr___9__85_0;

			// Token: 0x040034ED RID: 13549
			private static readonly IntPtr NativeFieldInfoPtr___9__85_1;

			// Token: 0x040034EE RID: 13550
			private static readonly IntPtr NativeFieldInfoPtr___9__86_2;

			// Token: 0x040034EF RID: 13551
			private static readonly IntPtr NativeFieldInfoPtr___9__86_3;

			// Token: 0x040034F0 RID: 13552
			private static readonly IntPtr NativeFieldInfoPtr___9__86_6;

			// Token: 0x040034F1 RID: 13553
			private static readonly IntPtr NativeFieldInfoPtr___9__86_4;

			// Token: 0x040034F2 RID: 13554
			private static readonly IntPtr NativeFieldInfoPtr___9__86_5;

			// Token: 0x040034F3 RID: 13555
			private static readonly IntPtr NativeFieldInfoPtr___9__89_0;

			// Token: 0x040034F4 RID: 13556
			private static readonly IntPtr NativeFieldInfoPtr___9__89_1;

			// Token: 0x040034F5 RID: 13557
			private static readonly IntPtr NativeFieldInfoPtr___9__90_1;

			// Token: 0x040034F6 RID: 13558
			private static readonly IntPtr NativeFieldInfoPtr___9__113_0;

			// Token: 0x040034F7 RID: 13559
			private static readonly IntPtr NativeFieldInfoPtr___9__114_0;

			// Token: 0x040034F8 RID: 13560
			private static readonly IntPtr NativeFieldInfoPtr___9__114_1;

			// Token: 0x040034F9 RID: 13561
			private static readonly IntPtr NativeFieldInfoPtr___9__114_2;

			// Token: 0x040034FA RID: 13562
			private static readonly IntPtr NativeFieldInfoPtr___9__114_3;

			// Token: 0x040034FB RID: 13563
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040034FC RID: 13564
			private static readonly IntPtr NativeMethodInfoPtr__IsPredeterminedSelection_b__9_0_Internal_TargetResponse_SelectionNodeFilterData_0;

			// Token: 0x040034FD RID: 13565
			private static readonly IntPtr NativeMethodInfoPtr__MakeChoice_b__10_2_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x040034FE RID: 13566
			private static readonly IntPtr NativeMethodInfoPtr__MakeChoice_b__10_3_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x040034FF RID: 13567
			private static readonly IntPtr NativeMethodInfoPtr__MakeChoice_b__10_0_Internal_Boolean_WormAIChoice_0;

			// Token: 0x04003500 RID: 13568
			private static readonly IntPtr NativeMethodInfoPtr__MakeChoice_b__10_1_Internal_Double_WormAIChoice_0;

			// Token: 0x04003501 RID: 13569
			private static readonly IntPtr NativeMethodInfoPtr__get_DeckAgentIcons_b__17_0_Internal_IEnumerable_1_AgentIcons_WormImperiumPlayable_0;

			// Token: 0x04003502 RID: 13570
			private static readonly IntPtr NativeMethodInfoPtr__get_DeckAgentIcons_b__17_1_Internal_AgentIcons_AgentIcons_0;

			// Token: 0x04003503 RID: 13571
			private static readonly IntPtr NativeMethodInfoPtr__get_DeckAgentIcons_b__17_2_Internal_AgentIcons_IGrouping_2_AgentIcons_AgentIcons_0;

			// Token: 0x04003504 RID: 13572
			private static readonly IntPtr NativeMethodInfoPtr__get_DeckAgentIcons_b__17_3_Internal_Int32_IGrouping_2_AgentIcons_AgentIcons_0;

			// Token: 0x04003505 RID: 13573
			private static readonly IntPtr NativeMethodInfoPtr__GetResourceValue_b__28_1_Internal_WormImperiumPlayable_WormImperiumPlayable_0;

			// Token: 0x04003506 RID: 13574
			private static readonly IntPtr NativeMethodInfoPtr__GetResourceValue_b__28_3_Internal_Double_KeyValuePair_2_WormImperiumPlayable_AIValueSummer_1_Double_0;

			// Token: 0x04003507 RID: 13575
			private static readonly IntPtr NativeMethodInfoPtr__TrashMod_b__38_0_Internal_Boolean_Entity_0;

			// Token: 0x04003508 RID: 13576
			private static readonly IntPtr NativeMethodInfoPtr__TrashMod_b__38_1_Internal_Boolean_Entity_0;

			// Token: 0x04003509 RID: 13577
			private static readonly IntPtr NativeMethodInfoPtr__TrashMod_b__38_2_Internal_Double_Entity_0;

			// Token: 0x0400350A RID: 13578
			private static readonly IntPtr NativeMethodInfoPtr__DeployValue_b__39_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400350B RID: 13579
			private static readonly IntPtr NativeMethodInfoPtr__DeployValue_b__39_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400350C RID: 13580
			private static readonly IntPtr NativeMethodInfoPtr__DeployValue_b__39_2_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400350D RID: 13581
			private static readonly IntPtr NativeMethodInfoPtr__DeployValue_b__39_3_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400350E RID: 13582
			private static readonly IntPtr NativeMethodInfoPtr__DeployValue_b__39_5_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x0400350F RID: 13583
			private static readonly IntPtr NativeMethodInfoPtr__DeployValue_b__39_4_Internal_Boolean_Entity_0;

			// Token: 0x04003510 RID: 13584
			private static readonly IntPtr NativeMethodInfoPtr__CurrentConflictInterest_b__55_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003511 RID: 13585
			private static readonly IntPtr NativeMethodInfoPtr__CurrentConflictInterest_b__55_1_Internal_Int32_Entity_0;

			// Token: 0x04003512 RID: 13586
			private static readonly IntPtr NativeMethodInfoPtr__get_ConflictCompetitors_b__57_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003513 RID: 13587
			private static readonly IntPtr NativeMethodInfoPtr__IntrigueHandStrengthValue_b__63_0_Internal_IEnumerable_1_StrengthIntrigueAbility_WormIntriguePlayable_0;

			// Token: 0x04003514 RID: 13588
			private static readonly IntPtr NativeMethodInfoPtr__EstOpponentStrength_b__64_0_Internal_Int32_Entity_0;

			// Token: 0x04003515 RID: 13589
			private static readonly IntPtr NativeMethodInfoPtr__EstStrength_b__65_0_Internal_Int32_Entity_0;

			// Token: 0x04003516 RID: 13590
			private static readonly IntPtr NativeMethodInfoPtr__EstStrength_b__65_1_Internal_Boolean_Entity_0;

			// Token: 0x04003517 RID: 13591
			private static readonly IntPtr NativeMethodInfoPtr__PotentialStrength_b__66_0_Internal_Int32_Entity_0;

			// Token: 0x04003518 RID: 13592
			private static readonly IntPtr NativeMethodInfoPtr__PotentialStrength_b__66_2_Internal_Boolean_Entity_0;

			// Token: 0x04003519 RID: 13593
			private static readonly IntPtr NativeMethodInfoPtr__GetBestInfluenceExchange_b__69_1_Internal_Factions_Factions_0;

			// Token: 0x0400351A RID: 13594
			private static readonly IntPtr NativeMethodInfoPtr__GetBestInfluenceExchange_b__69_3_Internal_Factions_Factions_0;

			// Token: 0x0400351B RID: 13595
			private static readonly IntPtr NativeMethodInfoPtr__GetSynergyMod_b__70_0_Internal_IEnumerable_1_WormAbilityDefinition_WormImperiumPlayable_0;

			// Token: 0x0400351C RID: 13596
			private static readonly IntPtr NativeMethodInfoPtr__GetSynergyMod_b__70_1_Internal_IEnumerable_1_WormAbilityDefinition_Entity_0;

			// Token: 0x0400351D RID: 13597
			private static readonly IntPtr NativeMethodInfoPtr__GetSynergyMod_b__70_2_Internal_IEnumerable_1_WormAbilityDefinition_Entity_0;

			// Token: 0x0400351E RID: 13598
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__74_0_Internal_AIValueSummer_1_Int32_AIValueSummer_1_Int32_0;

			// Token: 0x0400351F RID: 13599
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__74_1_Internal_Int32_AIValueSummer_1_Int32_0;

			// Token: 0x04003520 RID: 13600
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__74_2_Internal_Int32_Int32_0;

			// Token: 0x04003521 RID: 13601
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__74_3_Internal_Int32_WormUnit_0;

			// Token: 0x04003522 RID: 13602
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__74_4_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003523 RID: 13603
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__74_9_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003524 RID: 13604
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__74_10_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003525 RID: 13605
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__74_5_Internal_Int32_WormUnit_0;

			// Token: 0x04003526 RID: 13606
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__74_11_Internal_Boolean_Entity_0;

			// Token: 0x04003527 RID: 13607
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__74_12_Internal_Boolean_WormUnit_0;

			// Token: 0x04003528 RID: 13608
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__74_13_Internal_Boolean_Entity_0;

			// Token: 0x04003529 RID: 13609
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__74_8_Internal_Int32_WormUnit_0;

			// Token: 0x0400352A RID: 13610
			private static readonly IntPtr NativeMethodInfoPtr__GetTroopsToRetreat_b__75_0_Internal_Int32_WormPlayer_0;

			// Token: 0x0400352B RID: 13611
			private static readonly IntPtr NativeMethodInfoPtr__GetTroopsToRetreat_b__75_1_Internal_Int32_Int32_0;

			// Token: 0x0400352C RID: 13612
			private static readonly IntPtr NativeMethodInfoPtr__GetTroopsToRetreat_b__75_3_Internal_Int32_WormPlayer_0;

			// Token: 0x0400352D RID: 13613
			private static readonly IntPtr NativeMethodInfoPtr__GetTroopsToRetreat_b__75_6_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400352E RID: 13614
			private static readonly IntPtr NativeMethodInfoPtr__CurrentConflictRank_b__78_0_Internal_Int32_WormPlayer_0;

			// Token: 0x0400352F RID: 13615
			private static readonly IntPtr NativeMethodInfoPtr__GetCurrentCombatOrder_b__80_0_Internal_Tuple_2_WormPlayer_Int32_WormPlayer_0;

			// Token: 0x04003530 RID: 13616
			private static readonly IntPtr NativeMethodInfoPtr__GetCurrentCombatOrder_b__80_1_Internal_Int32_Tuple_2_WormPlayer_Int32_0;

			// Token: 0x04003531 RID: 13617
			private static readonly IntPtr NativeMethodInfoPtr__GetCurrentCombatOrder_b__80_2_Internal_WormPlayer_Tuple_2_WormPlayer_Int32_0;

			// Token: 0x04003532 RID: 13618
			private static readonly IntPtr NativeMethodInfoPtr__GetExpectedCombatOrder_b__81_0_Internal_WormPlayer_Tuple_2_WormPlayer_Int32_0;

			// Token: 0x04003533 RID: 13619
			private static readonly IntPtr NativeMethodInfoPtr__GetExpectedCombatOrderWithStrength_b__82_1_Internal_Int32_Tuple_2_WormPlayer_Int32_0;

			// Token: 0x04003534 RID: 13620
			private static readonly IntPtr NativeMethodInfoPtr__GetCardToTrash_b__85_0_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04003535 RID: 13621
			private static readonly IntPtr NativeMethodInfoPtr__GetCardToTrash_b__85_1_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04003536 RID: 13622
			private static readonly IntPtr NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_2_Internal_Boolean_Entity_0;

			// Token: 0x04003537 RID: 13623
			private static readonly IntPtr NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_3_Internal_Boolean_Entity_0;

			// Token: 0x04003538 RID: 13624
			private static readonly IntPtr NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_6_Internal_ArchetypeID_WormPlayable_0;

			// Token: 0x04003539 RID: 13625
			private static readonly IntPtr NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_4_Internal_Boolean_Entity_0;

			// Token: 0x0400353A RID: 13626
			private static readonly IntPtr NativeMethodInfoPtr__GetHeighlinerPotentialPlayer_b__86_5_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x0400353B RID: 13627
			private static readonly IntPtr NativeMethodInfoPtr__PossiblePersuasionGain_b__89_0_Internal_Int32_Entity_0;

			// Token: 0x0400353C RID: 13628
			private static readonly IntPtr NativeMethodInfoPtr__PossiblePersuasionGain_b__89_1_Internal_Int32_Entity_0;

			// Token: 0x0400353D RID: 13629
			private static readonly IntPtr NativeMethodInfoPtr__GetBestOption_b__90_1_Internal_AIValueSummer_1_Double_AIValueSummer_1_Double_AIValueSummer_1_Double_0;

			// Token: 0x0400353E RID: 13630
			private static readonly IntPtr NativeMethodInfoPtr__GetFreighterSelections_b__113_0_Internal_IEnumerable_1_Entity_WormTechTileStack_0;

			// Token: 0x0400353F RID: 13631
			private static readonly IntPtr NativeMethodInfoPtr__ResearchValue_b__114_0_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04003540 RID: 13632
			private static readonly IntPtr NativeMethodInfoPtr__ResearchValue_b__114_1_Internal_Boolean_Entity_0;

			// Token: 0x04003541 RID: 13633
			private static readonly IntPtr NativeMethodInfoPtr__ResearchValue_b__114_2_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04003542 RID: 13634
			private static readonly IntPtr NativeMethodInfoPtr__ResearchValue_b__114_3_Internal_Boolean_Entity_0;
		}

		// Token: 0x0200063A RID: 1594
		[ObfuscatedName("worm.canis.ai.WormAIProfile+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x0600512D RID: 20781 RVA: 0x001AC8E8 File Offset: 0x001AAAE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass15_0>.NativeClassPtr);
				WormAIProfile.__c__DisplayClass15_0.NativeFieldInfoPtr_withPersuasion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass15_0>.NativeClassPtr, "withPersuasion");
				WormAIProfile.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				WormAIProfile.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass15_0>.NativeClassPtr, 100667250);
				WormAIProfile.__c__DisplayClass15_0.NativeMethodInfoPtr__PredictCardBuys_b__0_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass15_0>.NativeClassPtr, 100667251);
				WormAIProfile.__c__DisplayClass15_0.NativeMethodInfoPtr__PredictCardBuys_b__1_Internal_KnapsackItem_1_WormImperiumPlayable_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass15_0>.NativeClassPtr, 100667252);
			}

			// Token: 0x0600512E RID: 20782 RVA: 0x001AC978 File Offset: 0x001AAB78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600512F RID: 20783 RVA: 0x001AC9B4 File Offset: 0x001AABB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123169, XrefRangeEnd = 123176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PredictCardBuys_b__0(WormImperiumPlayable c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass15_0.NativeMethodInfoPtr__PredictCardBuys_b__0_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005130 RID: 20784 RVA: 0x001ACA04 File Offset: 0x001AAC04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123176, XrefRangeEnd = 123187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIAlgorithmUtil.KnapsackItem<WormImperiumPlayable> _PredictCardBuys_b__1(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass15_0.NativeMethodInfoPtr__PredictCardBuys_b__1_Internal_KnapsackItem_1_WormImperiumPlayable_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new AIAlgorithmUtil.KnapsackItem<WormImperiumPlayable>(intPtr);
				}
			}

			// Token: 0x06005131 RID: 20785 RVA: 0x0001C20A File Offset: 0x0001A40A
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700140F RID: 5135
			// (get) Token: 0x06005132 RID: 20786 RVA: 0x001ACA4C File Offset: 0x001AAC4C
			// (set) Token: 0x06005133 RID: 20787 RVA: 0x0001C213 File Offset: 0x0001A413
			public unsafe int withPersuasion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass15_0.NativeFieldInfoPtr_withPersuasion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass15_0.NativeFieldInfoPtr_withPersuasion)) = value;
				}
			}

			// Token: 0x17001410 RID: 5136
			// (get) Token: 0x06005134 RID: 20788 RVA: 0x001ACA74 File Offset: 0x001AAC74
			// (set) Token: 0x06005135 RID: 20789 RVA: 0x0001C22E File Offset: 0x0001A42E
			public unsafe WormAIProfile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIProfile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003543 RID: 13635
			private static readonly IntPtr NativeFieldInfoPtr_withPersuasion;

			// Token: 0x04003544 RID: 13636
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003545 RID: 13637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003546 RID: 13638
			private static readonly IntPtr NativeMethodInfoPtr__PredictCardBuys_b__0_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04003547 RID: 13639
			private static readonly IntPtr NativeMethodInfoPtr__PredictCardBuys_b__1_Internal_KnapsackItem_1_WormImperiumPlayable_WormImperiumPlayable_0;
		}

		// Token: 0x0200063B RID: 1595
		[ObfuscatedName("worm.canis.ai.WormAIProfile+<>c__DisplayClass20_0")]
		public sealed class __c__DisplayClass20_0 : Object
		{
			// Token: 0x06005136 RID: 20790 RVA: 0x001ACAA4 File Offset: 0x001AACA4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass20_0()
			{
				Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "<>c__DisplayClass20_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass20_0>.NativeClassPtr);
				WormAIProfile.__c__DisplayClass20_0.NativeFieldInfoPtr_endgameTriggerScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass20_0>.NativeClassPtr, "endgameTriggerScore");
				WormAIProfile.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass20_0>.NativeClassPtr, "<>4__this");
				WormAIProfile.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass20_0>.NativeClassPtr, 100667253);
				WormAIProfile.__c__DisplayClass20_0.NativeMethodInfoPtr__get_IsClimax_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass20_0>.NativeClassPtr, 100667254);
				WormAIProfile.__c__DisplayClass20_0.NativeMethodInfoPtr__get_IsClimax_b__1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass20_0>.NativeClassPtr, 100667255);
				WormAIProfile.__c__DisplayClass20_0.NativeMethodInfoPtr__get_IsClimax_b__2_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass20_0>.NativeClassPtr, 100667256);
			}

			// Token: 0x06005137 RID: 20791 RVA: 0x001ACB48 File Offset: 0x001AAD48
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass20_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass20_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005138 RID: 20792 RVA: 0x001ACB84 File Offset: 0x001AAD84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123187, XrefRangeEnd = 123188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_IsClimax_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass20_0.NativeMethodInfoPtr__get_IsClimax_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005139 RID: 20793 RVA: 0x001ACBD4 File Offset: 0x001AADD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123188, XrefRangeEnd = 123189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_IsClimax_b__1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass20_0.NativeMethodInfoPtr__get_IsClimax_b__1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600513A RID: 20794 RVA: 0x001ACC24 File Offset: 0x001AAE24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123189, XrefRangeEnd = 123193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_IsClimax_b__2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass20_0.NativeMethodInfoPtr__get_IsClimax_b__2_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600513B RID: 20795 RVA: 0x0001C24D File Offset: 0x0001A44D
			public __c__DisplayClass20_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001411 RID: 5137
			// (get) Token: 0x0600513C RID: 20796 RVA: 0x001ACC74 File Offset: 0x001AAE74
			// (set) Token: 0x0600513D RID: 20797 RVA: 0x0001C256 File Offset: 0x0001A456
			public unsafe int endgameTriggerScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass20_0.NativeFieldInfoPtr_endgameTriggerScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass20_0.NativeFieldInfoPtr_endgameTriggerScore)) = value;
				}
			}

			// Token: 0x17001412 RID: 5138
			// (get) Token: 0x0600513E RID: 20798 RVA: 0x001ACC9C File Offset: 0x001AAE9C
			// (set) Token: 0x0600513F RID: 20799 RVA: 0x0001C271 File Offset: 0x0001A471
			public unsafe WormAIProfile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIProfile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass20_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003548 RID: 13640
			private static readonly IntPtr NativeFieldInfoPtr_endgameTriggerScore;

			// Token: 0x04003549 RID: 13641
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400354A RID: 13642
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400354B RID: 13643
			private static readonly IntPtr NativeMethodInfoPtr__get_IsClimax_b__0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400354C RID: 13644
			private static readonly IntPtr NativeMethodInfoPtr__get_IsClimax_b__1_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400354D RID: 13645
			private static readonly IntPtr NativeMethodInfoPtr__get_IsClimax_b__2_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x0200063C RID: 1596
		[ObfuscatedName("worm.canis.ai.WormAIProfile+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x06005140 RID: 20800 RVA: 0x001ACCCC File Offset: 0x001AAECC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass22_0>.NativeClassPtr);
				WormAIProfile.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				WormAIProfile.__c__DisplayClass22_0.NativeFieldInfoPtr_endgameTriggerScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass22_0>.NativeClassPtr, "endgameTriggerScore");
				WormAIProfile.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass22_0>.NativeClassPtr, 100667257);
				WormAIProfile.__c__DisplayClass22_0.NativeMethodInfoPtr__get_IsFinalRound_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass22_0>.NativeClassPtr, 100667258);
			}

			// Token: 0x06005141 RID: 20801 RVA: 0x001ACD48 File Offset: 0x001AAF48
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005142 RID: 20802 RVA: 0x001ACD84 File Offset: 0x001AAF84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123193, XrefRangeEnd = 123197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_IsFinalRound_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass22_0.NativeMethodInfoPtr__get_IsFinalRound_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005143 RID: 20803 RVA: 0x0001C290 File Offset: 0x0001A490
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001413 RID: 5139
			// (get) Token: 0x06005144 RID: 20804 RVA: 0x001ACDD4 File Offset: 0x001AAFD4
			// (set) Token: 0x06005145 RID: 20805 RVA: 0x0001C299 File Offset: 0x0001A499
			public unsafe WormAIProfile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIProfile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001414 RID: 5140
			// (get) Token: 0x06005146 RID: 20806 RVA: 0x001ACE04 File Offset: 0x001AB004
			// (set) Token: 0x06005147 RID: 20807 RVA: 0x0001C2B8 File Offset: 0x0001A4B8
			public unsafe int endgameTriggerScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass22_0.NativeFieldInfoPtr_endgameTriggerScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass22_0.NativeFieldInfoPtr_endgameTriggerScore)) = value;
				}
			}

			// Token: 0x0400354E RID: 13646
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400354F RID: 13647
			private static readonly IntPtr NativeFieldInfoPtr_endgameTriggerScore;

			// Token: 0x04003550 RID: 13648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003551 RID: 13649
			private static readonly IntPtr NativeMethodInfoPtr__get_IsFinalRound_b__0_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x0200063D RID: 1597
		[ObfuscatedName("worm.canis.ai.WormAIProfile+<>c__DisplayClass68_0")]
		public sealed class __c__DisplayClass68_0 : Object
		{
			// Token: 0x06005148 RID: 20808 RVA: 0x001ACE2C File Offset: 0x001AB02C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass68_0()
			{
				Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "<>c__DisplayClass68_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr);
				WormAIProfile.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr, "<>4__this");
				WormAIProfile.__c__DisplayClass68_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr, "amount");
				WormAIProfile.__c__DisplayClass68_0.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr, "faction");
				WormAIProfile.__c__DisplayClass68_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr, "<>9__6");
				WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr, 100667259);
				WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__2_Internal_AIValueSummer_1_Double_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr, 100667260);
				WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__3_Internal_AIValueSummer_1_Double_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr, 100667261);
				WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__0_Internal_Boolean_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr, 100667262);
				WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__4_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr, 100667263);
				WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__5_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr, 100667264);
				WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__1_Internal_IEnumerable_1_AllianceAbility_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr, 100667265);
				WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__6_Internal_Boolean_AllianceAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr, 100667266);
			}

			// Token: 0x06005149 RID: 20809 RVA: 0x001ACF48 File Offset: 0x001AB148
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass68_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass68_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600514A RID: 20810 RVA: 0x001ACF84 File Offset: 0x001AB184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123197, XrefRangeEnd = 123198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _GetGainInfluenceValue_b__2(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__2_Internal_AIValueSummer_1_Double_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600514B RID: 20811 RVA: 0x001ACFD0 File Offset: 0x001AB1D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _GetGainInfluenceValue_b__3(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__3_Internal_AIValueSummer_1_Double_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600514C RID: 20812 RVA: 0x001AD01C File Offset: 0x001AB21C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123198, XrefRangeEnd = 123205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetGainInfluenceValue_b__0(WormIntriguePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__0_Internal_Boolean_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600514D RID: 20813 RVA: 0x001AD06C File Offset: 0x001AB26C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123205, XrefRangeEnd = 123206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetGainInfluenceValue_b__4(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__4_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600514E RID: 20814 RVA: 0x001AD0B8 File Offset: 0x001AB2B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123206, XrefRangeEnd = 123210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetGainInfluenceValue_b__5(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__5_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600514F RID: 20815 RVA: 0x001AD108 File Offset: 0x001AB308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123210, XrefRangeEnd = 123225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<AllianceAbility> _GetGainInfluenceValue_b__1(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__1_Internal_IEnumerable_1_AllianceAbility_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AllianceAbility>>(intPtr3) : null;
				}
			}

			// Token: 0x06005150 RID: 20816 RVA: 0x001AD158 File Offset: 0x001AB358
			[CallerCount(0)]
			public unsafe bool _GetGainInfluenceValue_b__6(AllianceAbility ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass68_0.NativeMethodInfoPtr__GetGainInfluenceValue_b__6_Internal_Boolean_AllianceAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005151 RID: 20817 RVA: 0x0001C2D3 File Offset: 0x0001A4D3
			public __c__DisplayClass68_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001415 RID: 5141
			// (get) Token: 0x06005152 RID: 20818 RVA: 0x001AD1A8 File Offset: 0x001AB3A8
			// (set) Token: 0x06005153 RID: 20819 RVA: 0x0001C2DC File Offset: 0x0001A4DC
			public unsafe WormAIProfile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIProfile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass68_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001416 RID: 5142
			// (get) Token: 0x06005154 RID: 20820 RVA: 0x001AD1D8 File Offset: 0x001AB3D8
			// (set) Token: 0x06005155 RID: 20821 RVA: 0x0001C2FB File Offset: 0x0001A4FB
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass68_0.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass68_0.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x17001417 RID: 5143
			// (get) Token: 0x06005156 RID: 20822 RVA: 0x001AD200 File Offset: 0x001AB400
			// (set) Token: 0x06005157 RID: 20823 RVA: 0x0001C316 File Offset: 0x0001A516
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass68_0.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass68_0.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x17001418 RID: 5144
			// (get) Token: 0x06005158 RID: 20824 RVA: 0x001AD228 File Offset: 0x001AB428
			// (set) Token: 0x06005159 RID: 20825 RVA: 0x0001C331 File Offset: 0x0001A531
			public unsafe Func<AllianceAbility, bool> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass68_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AllianceAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass68_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003552 RID: 13650
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003553 RID: 13651
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04003554 RID: 13652
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x04003555 RID: 13653
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x04003556 RID: 13654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003557 RID: 13655
			private static readonly IntPtr NativeMethodInfoPtr__GetGainInfluenceValue_b__2_Internal_AIValueSummer_1_Double_Factions_0;

			// Token: 0x04003558 RID: 13656
			private static readonly IntPtr NativeMethodInfoPtr__GetGainInfluenceValue_b__3_Internal_AIValueSummer_1_Double_Factions_0;

			// Token: 0x04003559 RID: 13657
			private static readonly IntPtr NativeMethodInfoPtr__GetGainInfluenceValue_b__0_Internal_Boolean_WormIntriguePlayable_0;

			// Token: 0x0400355A RID: 13658
			private static readonly IntPtr NativeMethodInfoPtr__GetGainInfluenceValue_b__4_Internal_Boolean_Factions_0;

			// Token: 0x0400355B RID: 13659
			private static readonly IntPtr NativeMethodInfoPtr__GetGainInfluenceValue_b__5_Internal_Boolean_Entity_0;

			// Token: 0x0400355C RID: 13660
			private static readonly IntPtr NativeMethodInfoPtr__GetGainInfluenceValue_b__1_Internal_IEnumerable_1_AllianceAbility_WormImperiumPlayable_0;

			// Token: 0x0400355D RID: 13661
			private static readonly IntPtr NativeMethodInfoPtr__GetGainInfluenceValue_b__6_Internal_Boolean_AllianceAbility_0;
		}

		// Token: 0x0200063E RID: 1598
		[ObfuscatedName("worm.canis.ai.WormAIProfile+<>c__DisplayClass69_0")]
		public sealed class __c__DisplayClass69_0 : Object
		{
			// Token: 0x0600515A RID: 20826 RVA: 0x001AD258 File Offset: 0x001AB458
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass69_0()
			{
				Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass69_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "<>c__DisplayClass69_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass69_0>.NativeClassPtr);
				WormAIProfile.__c__DisplayClass69_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass69_0>.NativeClassPtr, "<>4__this");
				WormAIProfile.__c__DisplayClass69_0.NativeFieldInfoPtr_loseAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass69_0>.NativeClassPtr, "loseAmount");
				WormAIProfile.__c__DisplayClass69_0.NativeFieldInfoPtr_gainAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass69_0>.NativeClassPtr, "gainAmount");
				WormAIProfile.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass69_0>.NativeClassPtr, 100667267);
				WormAIProfile.__c__DisplayClass69_0.NativeMethodInfoPtr__GetBestInfluenceExchange_b__0_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass69_0>.NativeClassPtr, 100667268);
				WormAIProfile.__c__DisplayClass69_0.NativeMethodInfoPtr__GetBestInfluenceExchange_b__2_Internal_AIValueSummer_1_Double_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass69_0>.NativeClassPtr, 100667269);
				WormAIProfile.__c__DisplayClass69_0.NativeMethodInfoPtr__GetBestInfluenceExchange_b__4_Internal_AIValueSummer_1_Double_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass69_0>.NativeClassPtr, 100667270);
			}

			// Token: 0x0600515B RID: 20827 RVA: 0x001AD310 File Offset: 0x001AB510
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass69_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass69_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass69_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600515C RID: 20828 RVA: 0x001AD34C File Offset: 0x001AB54C
			[CallerCount(0)]
			public unsafe bool _GetBestInfluenceExchange_b__0(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass69_0.NativeMethodInfoPtr__GetBestInfluenceExchange_b__0_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600515D RID: 20829 RVA: 0x001AD398 File Offset: 0x001AB598
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _GetBestInfluenceExchange_b__2(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass69_0.NativeMethodInfoPtr__GetBestInfluenceExchange_b__2_Internal_AIValueSummer_1_Double_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600515E RID: 20830 RVA: 0x001AD3E4 File Offset: 0x001AB5E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123225, XrefRangeEnd = 123226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AIValueSummer<double> _GetBestInfluenceExchange_b__4(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass69_0.NativeMethodInfoPtr__GetBestInfluenceExchange_b__4_Internal_AIValueSummer_1_Double_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x0600515F RID: 20831 RVA: 0x0001C350 File Offset: 0x0001A550
			public __c__DisplayClass69_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001419 RID: 5145
			// (get) Token: 0x06005160 RID: 20832 RVA: 0x001AD430 File Offset: 0x001AB630
			// (set) Token: 0x06005161 RID: 20833 RVA: 0x0001C359 File Offset: 0x0001A559
			public unsafe WormAIProfile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass69_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIProfile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass69_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700141A RID: 5146
			// (get) Token: 0x06005162 RID: 20834 RVA: 0x001AD460 File Offset: 0x001AB660
			// (set) Token: 0x06005163 RID: 20835 RVA: 0x0001C378 File Offset: 0x0001A578
			public unsafe int loseAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass69_0.NativeFieldInfoPtr_loseAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass69_0.NativeFieldInfoPtr_loseAmount)) = value;
				}
			}

			// Token: 0x1700141B RID: 5147
			// (get) Token: 0x06005164 RID: 20836 RVA: 0x001AD488 File Offset: 0x001AB688
			// (set) Token: 0x06005165 RID: 20837 RVA: 0x0001C393 File Offset: 0x0001A593
			public unsafe int gainAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass69_0.NativeFieldInfoPtr_gainAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass69_0.NativeFieldInfoPtr_gainAmount)) = value;
				}
			}

			// Token: 0x0400355E RID: 13662
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400355F RID: 13663
			private static readonly IntPtr NativeFieldInfoPtr_loseAmount;

			// Token: 0x04003560 RID: 13664
			private static readonly IntPtr NativeFieldInfoPtr_gainAmount;

			// Token: 0x04003561 RID: 13665
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003562 RID: 13666
			private static readonly IntPtr NativeMethodInfoPtr__GetBestInfluenceExchange_b__0_Internal_Boolean_Factions_0;

			// Token: 0x04003563 RID: 13667
			private static readonly IntPtr NativeMethodInfoPtr__GetBestInfluenceExchange_b__2_Internal_AIValueSummer_1_Double_Factions_0;

			// Token: 0x04003564 RID: 13668
			private static readonly IntPtr NativeMethodInfoPtr__GetBestInfluenceExchange_b__4_Internal_AIValueSummer_1_Double_Factions_0;
		}

		// Token: 0x0200063F RID: 1599
		[ObfuscatedName("worm.canis.ai.WormAIProfile+<>c__DisplayClass70_0")]
		public sealed class __c__DisplayClass70_0 : Object
		{
			// Token: 0x06005166 RID: 20838 RVA: 0x001AD4B0 File Offset: 0x001AB6B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass70_0()
			{
				Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass70_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "<>c__DisplayClass70_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass70_0>.NativeClassPtr);
				WormAIProfile.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass70_0>.NativeClassPtr, "<>4__this");
				WormAIProfile.__c__DisplayClass70_0.NativeFieldInfoPtr_card = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass70_0>.NativeClassPtr, "card");
				WormAIProfile.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass70_0>.NativeClassPtr, 100667271);
				WormAIProfile.__c__DisplayClass70_0.NativeMethodInfoPtr__GetSynergyMod_b__3_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass70_0>.NativeClassPtr, 100667272);
			}

			// Token: 0x06005167 RID: 20839 RVA: 0x001AD52C File Offset: 0x001AB72C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass70_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass70_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass70_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005168 RID: 20840 RVA: 0x001AD568 File Offset: 0x001AB768
			[CallerCount(0)]
			public unsafe AIValueSummer<double> _GetSynergyMod_b__3(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass70_0.NativeMethodInfoPtr__GetSynergyMod_b__3_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
				}
			}

			// Token: 0x06005169 RID: 20841 RVA: 0x0001C3AE File Offset: 0x0001A5AE
			public __c__DisplayClass70_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700141C RID: 5148
			// (get) Token: 0x0600516A RID: 20842 RVA: 0x001AD5B8 File Offset: 0x001AB7B8
			// (set) Token: 0x0600516B RID: 20843 RVA: 0x0001C3B7 File Offset: 0x0001A5B7
			public unsafe WormAIProfile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIProfile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass70_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700141D RID: 5149
			// (get) Token: 0x0600516C RID: 20844 RVA: 0x001AD5E8 File Offset: 0x001AB7E8
			// (set) Token: 0x0600516D RID: 20845 RVA: 0x0001C3D6 File Offset: 0x0001A5D6
			public unsafe WormPlayable card
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass70_0.NativeFieldInfoPtr_card);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass70_0.NativeFieldInfoPtr_card), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003565 RID: 13669
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003566 RID: 13670
			private static readonly IntPtr NativeFieldInfoPtr_card;

			// Token: 0x04003567 RID: 13671
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003568 RID: 13672
			private static readonly IntPtr NativeMethodInfoPtr__GetSynergyMod_b__3_Internal_AIValueSummer_1_Double_WormAbilityDefinition_0;
		}

		// Token: 0x02000640 RID: 1600
		[ObfuscatedName("worm.canis.ai.WormAIProfile+<>c__DisplayClass71_0")]
		public sealed class __c__DisplayClass71_0 : Object
		{
			// Token: 0x0600516E RID: 20846 RVA: 0x001AD618 File Offset: 0x001AB818
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass71_0()
			{
				Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass71_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "<>c__DisplayClass71_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass71_0>.NativeClassPtr);
				WormAIProfile.__c__DisplayClass71_0.NativeFieldInfoPtr_faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass71_0>.NativeClassPtr, "faction");
				WormAIProfile.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass71_0>.NativeClassPtr, 100667273);
				WormAIProfile.__c__DisplayClass71_0.NativeMethodInfoPtr__GetFriendshipMod_b__2_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass71_0>.NativeClassPtr, 100667274);
			}

			// Token: 0x0600516F RID: 20847 RVA: 0x001AD680 File Offset: 0x001AB880
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass71_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass71_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass71_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005170 RID: 20848 RVA: 0x001AD6BC File Offset: 0x001AB8BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123226, XrefRangeEnd = 123227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFriendshipMod_b__2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass71_0.NativeMethodInfoPtr__GetFriendshipMod_b__2_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005171 RID: 20849 RVA: 0x0001C3F5 File Offset: 0x0001A5F5
			public __c__DisplayClass71_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700141E RID: 5150
			// (get) Token: 0x06005172 RID: 20850 RVA: 0x001AD70C File Offset: 0x001AB90C
			// (set) Token: 0x06005173 RID: 20851 RVA: 0x0001C3FE File Offset: 0x0001A5FE
			public unsafe Factions faction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass71_0.NativeFieldInfoPtr_faction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass71_0.NativeFieldInfoPtr_faction)) = value;
				}
			}

			// Token: 0x04003569 RID: 13673
			private static readonly IntPtr NativeFieldInfoPtr_faction;

			// Token: 0x0400356A RID: 13674
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400356B RID: 13675
			private static readonly IntPtr NativeMethodInfoPtr__GetFriendshipMod_b__2_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000641 RID: 1601
		[ObfuscatedName("worm.canis.ai.WormAIProfile+<>c__DisplayClass74_0")]
		public sealed class __c__DisplayClass74_0 : Object
		{
			// Token: 0x06005174 RID: 20852 RVA: 0x001AD734 File Offset: 0x001AB934
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass74_0()
			{
				Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass74_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "<>c__DisplayClass74_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass74_0>.NativeClassPtr);
				WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_sum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass74_0>.NativeClassPtr, "sum");
				WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_strengthRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass74_0>.NativeClassPtr, "strengthRequested");
				WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_numTaken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass74_0>.NativeClassPtr, "numTaken");
				WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass74_0>.NativeClassPtr, "max");
				WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_deployList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass74_0>.NativeClassPtr, "deployList");
				WormAIProfile.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass74_0>.NativeClassPtr, 100667275);
				WormAIProfile.__c__DisplayClass74_0.NativeMethodInfoPtr__GetUnitsToDeploy_b__6_Internal_Boolean_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass74_0>.NativeClassPtr, 100667276);
				WormAIProfile.__c__DisplayClass74_0.NativeMethodInfoPtr__GetUnitsToDeploy_b__7_Internal_Boolean_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass74_0>.NativeClassPtr, 100667277);
			}

			// Token: 0x06005175 RID: 20853 RVA: 0x001AD800 File Offset: 0x001ABA00
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass74_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass74_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass74_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005176 RID: 20854 RVA: 0x001AD83C File Offset: 0x001ABA3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123227, XrefRangeEnd = 123228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnitsToDeploy_b__6(WormUnit unit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass74_0.NativeMethodInfoPtr__GetUnitsToDeploy_b__6_Internal_Boolean_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005177 RID: 20855 RVA: 0x001AD88C File Offset: 0x001ABA8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123228, XrefRangeEnd = 123232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetUnitsToDeploy_b__7(WormUnit unit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass74_0.NativeMethodInfoPtr__GetUnitsToDeploy_b__7_Internal_Boolean_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005178 RID: 20856 RVA: 0x0001C419 File Offset: 0x0001A619
			public __c__DisplayClass74_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700141F RID: 5151
			// (get) Token: 0x06005179 RID: 20857 RVA: 0x001AD8DC File Offset: 0x001ABADC
			// (set) Token: 0x0600517A RID: 20858 RVA: 0x0001C422 File Offset: 0x0001A622
			public unsafe int sum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_sum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_sum)) = value;
				}
			}

			// Token: 0x17001420 RID: 5152
			// (get) Token: 0x0600517B RID: 20859 RVA: 0x001AD904 File Offset: 0x001ABB04
			// (set) Token: 0x0600517C RID: 20860 RVA: 0x0001C43D File Offset: 0x0001A63D
			public unsafe int strengthRequested
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_strengthRequested);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_strengthRequested)) = value;
				}
			}

			// Token: 0x17001421 RID: 5153
			// (get) Token: 0x0600517D RID: 20861 RVA: 0x001AD92C File Offset: 0x001ABB2C
			// (set) Token: 0x0600517E RID: 20862 RVA: 0x0001C458 File Offset: 0x0001A658
			public unsafe int numTaken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_numTaken);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_numTaken)) = value;
				}
			}

			// Token: 0x17001422 RID: 5154
			// (get) Token: 0x0600517F RID: 20863 RVA: 0x001AD954 File Offset: 0x001ABB54
			// (set) Token: 0x06005180 RID: 20864 RVA: 0x0001C473 File Offset: 0x0001A673
			public unsafe int max
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_max);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_max)) = value;
				}
			}

			// Token: 0x17001423 RID: 5155
			// (get) Token: 0x06005181 RID: 20865 RVA: 0x001AD97C File Offset: 0x001ABB7C
			// (set) Token: 0x06005182 RID: 20866 RVA: 0x0001C48E File Offset: 0x0001A68E
			public unsafe List<WormUnit> deployList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_deployList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormUnit>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass74_0.NativeFieldInfoPtr_deployList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400356C RID: 13676
			private static readonly IntPtr NativeFieldInfoPtr_sum;

			// Token: 0x0400356D RID: 13677
			private static readonly IntPtr NativeFieldInfoPtr_strengthRequested;

			// Token: 0x0400356E RID: 13678
			private static readonly IntPtr NativeFieldInfoPtr_numTaken;

			// Token: 0x0400356F RID: 13679
			private static readonly IntPtr NativeFieldInfoPtr_max;

			// Token: 0x04003570 RID: 13680
			private static readonly IntPtr NativeFieldInfoPtr_deployList;

			// Token: 0x04003571 RID: 13681
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003572 RID: 13682
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__6_Internal_Boolean_WormUnit_0;

			// Token: 0x04003573 RID: 13683
			private static readonly IntPtr NativeMethodInfoPtr__GetUnitsToDeploy_b__7_Internal_Boolean_WormUnit_0;
		}

		// Token: 0x02000642 RID: 1602
		[ObfuscatedName("worm.canis.ai.WormAIProfile+<>c__DisplayClass75_0")]
		public sealed class __c__DisplayClass75_0 : Object
		{
			// Token: 0x06005183 RID: 20867 RVA: 0x001AD9AC File Offset: 0x001ABBAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass75_0()
			{
				Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass75_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "<>c__DisplayClass75_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass75_0>.NativeClassPtr);
				WormAIProfile.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass75_0>.NativeClassPtr, "<>4__this");
				WormAIProfile.__c__DisplayClass75_0.NativeFieldInfoPtr_myEstimatedStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass75_0>.NativeClassPtr, "myEstimatedStrength");
				WormAIProfile.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass75_0>.NativeClassPtr, 100667278);
				WormAIProfile.__c__DisplayClass75_0.NativeMethodInfoPtr__GetTroopsToRetreat_b__2_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass75_0>.NativeClassPtr, 100667279);
				WormAIProfile.__c__DisplayClass75_0.NativeMethodInfoPtr__GetTroopsToRetreat_b__4_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass75_0>.NativeClassPtr, 100667280);
				WormAIProfile.__c__DisplayClass75_0.NativeMethodInfoPtr__GetTroopsToRetreat_b__5_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass75_0>.NativeClassPtr, 100667281);
			}

			// Token: 0x06005184 RID: 20868 RVA: 0x001ADA50 File Offset: 0x001ABC50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass75_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass75_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass75_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005185 RID: 20869 RVA: 0x001ADA8C File Offset: 0x001ABC8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123232, XrefRangeEnd = 123239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetTroopsToRetreat_b__2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass75_0.NativeMethodInfoPtr__GetTroopsToRetreat_b__2_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005186 RID: 20870 RVA: 0x001ADADC File Offset: 0x001ABCDC
			[CallerCount(0)]
			public unsafe bool _GetTroopsToRetreat_b__4(int _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass75_0.NativeMethodInfoPtr__GetTroopsToRetreat_b__4_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005187 RID: 20871 RVA: 0x001ADB28 File Offset: 0x001ABD28
			[CallerCount(0)]
			public unsafe bool _GetTroopsToRetreat_b__5(int _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass75_0.NativeMethodInfoPtr__GetTroopsToRetreat_b__5_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005188 RID: 20872 RVA: 0x0001C4AD File Offset: 0x0001A6AD
			public __c__DisplayClass75_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001424 RID: 5156
			// (get) Token: 0x06005189 RID: 20873 RVA: 0x001ADB74 File Offset: 0x001ABD74
			// (set) Token: 0x0600518A RID: 20874 RVA: 0x0001C4B6 File Offset: 0x0001A6B6
			public unsafe WormAIProfile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIProfile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass75_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001425 RID: 5157
			// (get) Token: 0x0600518B RID: 20875 RVA: 0x001ADBA4 File Offset: 0x001ABDA4
			// (set) Token: 0x0600518C RID: 20876 RVA: 0x0001C4D5 File Offset: 0x0001A6D5
			public unsafe int myEstimatedStrength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass75_0.NativeFieldInfoPtr_myEstimatedStrength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass75_0.NativeFieldInfoPtr_myEstimatedStrength)) = value;
				}
			}

			// Token: 0x04003574 RID: 13684
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003575 RID: 13685
			private static readonly IntPtr NativeFieldInfoPtr_myEstimatedStrength;

			// Token: 0x04003576 RID: 13686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003577 RID: 13687
			private static readonly IntPtr NativeMethodInfoPtr__GetTroopsToRetreat_b__2_Internal_Int32_WormPlayer_0;

			// Token: 0x04003578 RID: 13688
			private static readonly IntPtr NativeMethodInfoPtr__GetTroopsToRetreat_b__4_Internal_Boolean_Int32_0;

			// Token: 0x04003579 RID: 13689
			private static readonly IntPtr NativeMethodInfoPtr__GetTroopsToRetreat_b__5_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000643 RID: 1603
		[ObfuscatedName("worm.canis.ai.WormAIProfile+<>c__DisplayClass79_0")]
		public sealed class __c__DisplayClass79_0 : Object
		{
			// Token: 0x0600518D RID: 20877 RVA: 0x001ADBCC File Offset: 0x001ABDCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass79_0()
			{
				Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass79_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "<>c__DisplayClass79_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass79_0>.NativeClassPtr);
				WormAIProfile.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass79_0>.NativeClassPtr, "<>4__this");
				WormAIProfile.__c__DisplayClass79_0.NativeFieldInfoPtr_bonusStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass79_0>.NativeClassPtr, "bonusStrength");
				WormAIProfile.__c__DisplayClass79_0.NativeFieldInfoPtr_oppStrengthFunc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass79_0>.NativeClassPtr, "oppStrengthFunc");
				WormAIProfile.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass79_0>.NativeClassPtr, 100667282);
				WormAIProfile.__c__DisplayClass79_0.NativeMethodInfoPtr__GetConflictRank_b__0_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass79_0>.NativeClassPtr, 100667283);
				WormAIProfile.__c__DisplayClass79_0.NativeMethodInfoPtr__GetConflictRank_b__1_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass79_0>.NativeClassPtr, 100667284);
				WormAIProfile.__c__DisplayClass79_0.NativeMethodInfoPtr__GetConflictRank_b__2_Internal_Boolean_IGrouping_2_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass79_0>.NativeClassPtr, 100667285);
				WormAIProfile.__c__DisplayClass79_0.NativeMethodInfoPtr__GetConflictRank_b__3_Internal_Boolean_IGrouping_2_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass79_0>.NativeClassPtr, 100667286);
			}

			// Token: 0x0600518E RID: 20878 RVA: 0x001ADC98 File Offset: 0x001ABE98
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass79_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass79_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass79_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600518F RID: 20879 RVA: 0x001ADCD4 File Offset: 0x001ABED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123239, XrefRangeEnd = 123240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetConflictRank_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass79_0.NativeMethodInfoPtr__GetConflictRank_b__0_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005190 RID: 20880 RVA: 0x001ADD24 File Offset: 0x001ABF24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetConflictRank_b__1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass79_0.NativeMethodInfoPtr__GetConflictRank_b__1_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005191 RID: 20881 RVA: 0x001ADD74 File Offset: 0x001ABF74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123240, XrefRangeEnd = 123244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetConflictRank_b__2(IGrouping<int, WormPlayer> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass79_0.NativeMethodInfoPtr__GetConflictRank_b__2_Internal_Boolean_IGrouping_2_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005192 RID: 20882 RVA: 0x001ADDC4 File Offset: 0x001ABFC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123244, XrefRangeEnd = 123248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetConflictRank_b__3(IGrouping<int, WormPlayer> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass79_0.NativeMethodInfoPtr__GetConflictRank_b__3_Internal_Boolean_IGrouping_2_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005193 RID: 20883 RVA: 0x0001C4F0 File Offset: 0x0001A6F0
			public __c__DisplayClass79_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001426 RID: 5158
			// (get) Token: 0x06005194 RID: 20884 RVA: 0x001ADE14 File Offset: 0x001AC014
			// (set) Token: 0x06005195 RID: 20885 RVA: 0x0001C4F9 File Offset: 0x0001A6F9
			public unsafe WormAIProfile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIProfile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass79_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001427 RID: 5159
			// (get) Token: 0x06005196 RID: 20886 RVA: 0x001ADE44 File Offset: 0x001AC044
			// (set) Token: 0x06005197 RID: 20887 RVA: 0x0001C518 File Offset: 0x0001A718
			public unsafe int bonusStrength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass79_0.NativeFieldInfoPtr_bonusStrength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass79_0.NativeFieldInfoPtr_bonusStrength)) = value;
				}
			}

			// Token: 0x17001428 RID: 5160
			// (get) Token: 0x06005198 RID: 20888 RVA: 0x001ADE6C File Offset: 0x001AC06C
			// (set) Token: 0x06005199 RID: 20889 RVA: 0x0001C533 File Offset: 0x0001A733
			public unsafe Func<WormPlayer, int> oppStrengthFunc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass79_0.NativeFieldInfoPtr_oppStrengthFunc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass79_0.NativeFieldInfoPtr_oppStrengthFunc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400357A RID: 13690
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400357B RID: 13691
			private static readonly IntPtr NativeFieldInfoPtr_bonusStrength;

			// Token: 0x0400357C RID: 13692
			private static readonly IntPtr NativeFieldInfoPtr_oppStrengthFunc;

			// Token: 0x0400357D RID: 13693
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400357E RID: 13694
			private static readonly IntPtr NativeMethodInfoPtr__GetConflictRank_b__0_Internal_Int32_WormPlayer_0;

			// Token: 0x0400357F RID: 13695
			private static readonly IntPtr NativeMethodInfoPtr__GetConflictRank_b__1_Internal_Int32_WormPlayer_0;

			// Token: 0x04003580 RID: 13696
			private static readonly IntPtr NativeMethodInfoPtr__GetConflictRank_b__2_Internal_Boolean_IGrouping_2_Int32_WormPlayer_0;

			// Token: 0x04003581 RID: 13697
			private static readonly IntPtr NativeMethodInfoPtr__GetConflictRank_b__3_Internal_Boolean_IGrouping_2_Int32_WormPlayer_0;
		}

		// Token: 0x02000644 RID: 1604
		[ObfuscatedName("worm.canis.ai.WormAIProfile+<>c__DisplayClass91_0")]
		public sealed class __c__DisplayClass91_0 : Object
		{
			// Token: 0x0600519A RID: 20890 RVA: 0x001ADE9C File Offset: 0x001AC09C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass91_0()
			{
				Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass91_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAIProfile>.NativeClassPtr, "<>c__DisplayClass91_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass91_0>.NativeClassPtr);
				WormAIProfile.__c__DisplayClass91_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass91_0>.NativeClassPtr, "<>4__this");
				WormAIProfile.__c__DisplayClass91_0.NativeFieldInfoPtr_opponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass91_0>.NativeClassPtr, "opponent");
				WormAIProfile.__c__DisplayClass91_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass91_0>.NativeClassPtr, 100667287);
				WormAIProfile.__c__DisplayClass91_0.NativeMethodInfoPtr__HasTurnBeforeOpponentNextRound_b__0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass91_0>.NativeClassPtr, 100667288);
				WormAIProfile.__c__DisplayClass91_0.NativeMethodInfoPtr__HasTurnBeforeOpponentNextRound_b__1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass91_0>.NativeClassPtr, 100667289);
			}

			// Token: 0x0600519B RID: 20891 RVA: 0x001ADF2C File Offset: 0x001AC12C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass91_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAIProfile.__c__DisplayClass91_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass91_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600519C RID: 20892 RVA: 0x001ADF68 File Offset: 0x001AC168
			[CallerCount(0)]
			public unsafe bool _HasTurnBeforeOpponentNextRound_b__0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass91_0.NativeMethodInfoPtr__HasTurnBeforeOpponentNextRound_b__0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600519D RID: 20893 RVA: 0x001ADFB8 File Offset: 0x001AC1B8
			[CallerCount(0)]
			public unsafe bool _HasTurnBeforeOpponentNextRound_b__1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAIProfile.__c__DisplayClass91_0.NativeMethodInfoPtr__HasTurnBeforeOpponentNextRound_b__1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600519E RID: 20894 RVA: 0x0001C552 File Offset: 0x0001A752
			public __c__DisplayClass91_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001429 RID: 5161
			// (get) Token: 0x0600519F RID: 20895 RVA: 0x001AE008 File Offset: 0x001AC208
			// (set) Token: 0x060051A0 RID: 20896 RVA: 0x0001C55B File Offset: 0x0001A75B
			public unsafe WormAIProfile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass91_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAIProfile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass91_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700142A RID: 5162
			// (get) Token: 0x060051A1 RID: 20897 RVA: 0x001AE038 File Offset: 0x001AC238
			// (set) Token: 0x060051A2 RID: 20898 RVA: 0x0001C57A File Offset: 0x0001A77A
			public unsafe WormPlayer opponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass91_0.NativeFieldInfoPtr_opponent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAIProfile.__c__DisplayClass91_0.NativeFieldInfoPtr_opponent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003582 RID: 13698
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003583 RID: 13699
			private static readonly IntPtr NativeFieldInfoPtr_opponent;

			// Token: 0x04003584 RID: 13700
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003585 RID: 13701
			private static readonly IntPtr NativeMethodInfoPtr__HasTurnBeforeOpponentNextRound_b__0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04003586 RID: 13702
			private static readonly IntPtr NativeMethodInfoPtr__HasTurnBeforeOpponentNextRound_b__1_Internal_Boolean_WormPlayer_0;
		}
	}
}
