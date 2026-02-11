using System;
using Canis.attributes;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.actions.phases;
using worm.canis.data.attributes.resource;
using worm.canis.data.enums;

namespace worm.canis.data
{
	// Token: 0x02000040 RID: 64
	public static class WormAttributes : Object
	{
		// Token: 0x06000524 RID: 1316 RVA: 0x0007EC1C File Offset: 0x0007CE1C
		// Note: this type is marked as 'beforefieldinit'.
		static WormAttributes()
		{
			Il2CppClassPointerStore<WormAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data", "WormAttributes");
			WormAttributes.NativeFieldInfoPtr_VictoryPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "VictoryPoints");
			WormAttributes.NativeFieldInfoPtr_Winner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Winner");
			WormAttributes.NativeFieldInfoPtr_Spice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Spice");
			WormAttributes.NativeFieldInfoPtr_Water = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Water");
			WormAttributes.NativeFieldInfoPtr_Solari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Solari");
			WormAttributes.NativeFieldInfoPtr_Troops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Troops");
			WormAttributes.NativeFieldInfoPtr_Persuasion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Persuasion");
			WormAttributes.NativeFieldInfoPtr_Strength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Strength");
			WormAttributes.NativeFieldInfoPtr_Faction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Faction");
			WormAttributes.NativeFieldInfoPtr_SpiceCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SpiceCost");
			WormAttributes.NativeFieldInfoPtr_WaterCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "WaterCost");
			WormAttributes.NativeFieldInfoPtr_SolariCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SolariCost");
			WormAttributes.NativeFieldInfoPtr_WormAbilityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "WormAbilityIDs");
			WormAttributes.NativeFieldInfoPtr_SetList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SetList");
			WormAttributes.NativeFieldInfoPtr_ChosenEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ChosenEntity");
			WormAttributes.NativeFieldInfoPtr_PlayerRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "PlayerRewards");
			WormAttributes.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "EntityType");
			WormAttributes.NativeFieldInfoPtr_ConflictParticipants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ConflictParticipants");
			WormAttributes.NativeFieldInfoPtr_RoundNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "RoundNumber");
			WormAttributes.NativeFieldInfoPtr_SecondConflictDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SecondConflictDeck");
			WormAttributes.NativeFieldInfoPtr_SkipRecallThisRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SkipRecallThisRound");
			WormAttributes.NativeFieldInfoPtr_ConflictRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ConflictRewards");
			WormAttributes.NativeFieldInfoPtr_WormSkirmishScoringMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "WormSkirmishScoringMethods");
			WormAttributes.NativeFieldInfoPtr_SpiceMustFlowBaseCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SpiceMustFlowBaseCost");
			WormAttributes.NativeFieldInfoPtr_WarningText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "WarningText");
			WormAttributes.NativeFieldInfoPtr_HiddenElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HiddenElements");
			WormAttributes.NativeFieldInfoPtr_RevealOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "RevealOrder");
			WormAttributes.NativeFieldInfoPtr_Conflict2Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Conflict2Count");
			WormAttributes.NativeFieldInfoPtr_Conflict3Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Conflict3Count");
			WormAttributes.NativeFieldInfoPtr_LastRoundTriggered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LastRoundTriggered");
			WormAttributes.NativeFieldInfoPtr_EndgameTriggerScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "EndgameTriggerScore");
			WormAttributes.NativeFieldInfoPtr_AllowDisplayClearOnSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AllowDisplayClearOnSave");
			WormAttributes.NativeFieldInfoPtr_WormSkirmishRuleMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "WormSkirmishRuleMods");
			WormAttributes.NativeFieldInfoPtr_LeaderAssignmentMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LeaderAssignmentMode");
			WormAttributes.NativeFieldInfoPtr_LeaderSelectionPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LeaderSelectionPlayer");
			WormAttributes.NativeFieldInfoPtr_EndgameStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "EndgameStarted");
			WormAttributes.NativeFieldInfoPtr_EnabledSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "EnabledSets");
			WormAttributes.NativeFieldInfoPtr_NewDreadnoughtSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "NewDreadnoughtSpace");
			WormAttributes.NativeFieldInfoPtr_ConflictPassedPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ConflictPassedPlayers");
			WormAttributes.NativeFieldInfoPtr_Dreadnought = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Dreadnought");
			WormAttributes.NativeFieldInfoPtr_LastConflictIntriguePlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LastConflictIntriguePlayer");
			WormAttributes.NativeFieldInfoPtr_EpicGameMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "EpicGameMode");
			WormAttributes.NativeFieldInfoPtr_DeadlyAllianceAwarded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "DeadlyAllianceAwarded");
			WormAttributes.NativeFieldInfoPtr_TutorialStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TutorialStep");
			WormAttributes.NativeFieldInfoPtr_HoldFirstPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HoldFirstPlayer");
			WormAttributes.NativeFieldInfoPtr_ShowSequenceToAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ShowSequenceToAll");
			WormAttributes.NativeFieldInfoPtr_HasMigratedReserveRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HasMigratedReserveRow");
			WormAttributes.NativeFieldInfoPtr_HasMigratedReserveRowTwice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HasMigratedReserveRowTwice");
			WormAttributes.NativeFieldInfoPtr_Specimen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Specimen");
			WormAttributes.NativeFieldInfoPtr_GoTo11Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "GoTo11Mode");
			WormAttributes.NativeFieldInfoPtr_TechNegotiator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TechNegotiator");
			WormAttributes.NativeFieldInfoPtr_IntrigueCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "IntrigueCard");
			WormAttributes.NativeFieldInfoPtr_ImperiumCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ImperiumCard");
			WormAttributes.NativeFieldInfoPtr_UndoIsCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "UndoIsCancel");
			WormAttributes.NativeFieldInfoPtr_TurnPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TurnPhase");
			WormAttributes.NativeFieldInfoPtr_FactionInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "FactionInfluence");
			WormAttributes.NativeFieldInfoPtr_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Color");
			WormAttributes.NativeFieldInfoPtr_FirstPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "FirstPlayer");
			WormAttributes.NativeFieldInfoPtr_PlayerTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "PlayerTurn");
			WormAttributes.NativeFieldInfoPtr_HighCouncilSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HighCouncilSeat");
			WormAttributes.NativeFieldInfoPtr_PassTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "PassTurn");
			WormAttributes.NativeFieldInfoPtr_CanAcquireToDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "CanAcquireToDeck");
			WormAttributes.NativeFieldInfoPtr_Infiltrate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Infiltrate");
			WormAttributes.NativeFieldInfoPtr_EnvoyDispatched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "EnvoyDispatched");
			WormAttributes.NativeFieldInfoPtr_AdditionalSpaceInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AdditionalSpaceInfluence");
			WormAttributes.NativeFieldInfoPtr_BaronHarkonnenSecretFactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "BaronHarkonnenSecretFactions");
			WormAttributes.NativeFieldInfoPtr_Swordmaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Swordmaster");
			WormAttributes.NativeFieldInfoPtr_UnitsGainedThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "UnitsGainedThisTurn");
			WormAttributes.NativeFieldInfoPtr_DeckList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "DeckList");
			WormAttributes.NativeFieldInfoPtr_HasRevealed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HasRevealed");
			WormAttributes.NativeFieldInfoPtr_PossibleStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "PossibleStrength");
			WormAttributes.NativeFieldInfoPtr_TurnOfRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TurnOfRound");
			WormAttributes.NativeFieldInfoPtr_ShuffleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ShuffleCount");
			WormAttributes.NativeFieldInfoPtr_CustomDeferralThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "CustomDeferralThreshold");
			WormAttributes.NativeFieldInfoPtr_VisitedSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "VisitedSpaces");
			WormAttributes.NativeFieldInfoPtr_TutorialAllianceTokenStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TutorialAllianceTokenStarted");
			WormAttributes.NativeFieldInfoPtr_TrashedCardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TrashedCardCount");
			WormAttributes.NativeFieldInfoPtr_EmperorAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "EmperorAcquired");
			WormAttributes.NativeFieldInfoPtr_FremenAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "FremenAcquired");
			WormAttributes.NativeFieldInfoPtr_SpacingGuildAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SpacingGuildAcquired");
			WormAttributes.NativeFieldInfoPtr_BeneGesseritAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "BeneGesseritAcquired");
			WormAttributes.NativeFieldInfoPtr_SpiceMustFlowAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SpiceMustFlowAcquired");
			WormAttributes.NativeFieldInfoPtr_MentatUsedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "MentatUsedCount");
			WormAttributes.NativeFieldInfoPtr_CombatFirstCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "CombatFirstCount");
			WormAttributes.NativeFieldInfoPtr_IntriguePlayedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "IntriguePlayedCount");
			WormAttributes.NativeFieldInfoPtr_WaterSpent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "WaterSpent");
			WormAttributes.NativeFieldInfoPtr_CombatHighestSwords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "CombatHighestSwords");
			WormAttributes.NativeFieldInfoPtr_CombatFirstFewerUnitsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "CombatFirstFewerUnitsCount");
			WormAttributes.NativeFieldInfoPtr_ExtraDrawCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ExtraDrawCount");
			WormAttributes.NativeFieldInfoPtr_ExpensiveAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ExpensiveAcquired");
			WormAttributes.NativeFieldInfoPtr_CheapAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "CheapAcquired");
			WormAttributes.NativeFieldInfoPtr_WithAbilityAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "WithAbilityAcquired");
			WormAttributes.NativeFieldInfoPtr_FremenBondCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "FremenBondCount");
			WormAttributes.NativeFieldInfoPtr_TroopsRetreatedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TroopsRetreatedCount");
			WormAttributes.NativeFieldInfoPtr_TurnCardsAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TurnCardsAcquired");
			WormAttributes.NativeFieldInfoPtr_ConflictFirstPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ConflictFirstPlace");
			WormAttributes.NativeFieldInfoPtr_BaseDeployableUnits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "BaseDeployableUnits");
			WormAttributes.NativeFieldInfoPtr_RevealPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "RevealPreview");
			WormAttributes.NativeFieldInfoPtr_StartingPlayerOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "StartingPlayerOrder");
			WormAttributes.NativeFieldInfoPtr_EndlessAssaultCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "EndlessAssaultCount");
			WormAttributes.NativeFieldInfoPtr_InfluenceRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "InfluenceRank");
			WormAttributes.NativeFieldInfoPtr_ControlMarkers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ControlMarkers");
			WormAttributes.NativeFieldInfoPtr_EarlyPersuasion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "EarlyPersuasion");
			WormAttributes.NativeFieldInfoPtr_DesertPowerSwords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "DesertPowerSwords");
			WormAttributes.NativeFieldInfoPtr_VPSources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "VPSources");
			WormAttributes.NativeFieldInfoPtr_Reshuffle1DeckOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Reshuffle1DeckOrder");
			WormAttributes.NativeFieldInfoPtr_Reshuffle2DeckOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Reshuffle2DeckOrder");
			WormAttributes.NativeFieldInfoPtr_Reshuffle3DeckOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Reshuffle3DeckOrder");
			WormAttributes.NativeFieldInfoPtr_IsHagalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "IsHagalPlayer");
			WormAttributes.NativeFieldInfoPtr_FactionsBlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "FactionsBlocked");
			WormAttributes.NativeFieldInfoPtr_PrescienceTopCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "PrescienceTopCard");
			WormAttributes.NativeFieldInfoPtr_DarkSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "DarkSpaces");
			WormAttributes.NativeFieldInfoPtr_AllianceTokenVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AllianceTokenVP");
			WormAttributes.NativeFieldInfoPtr_TutorialHighCouncilStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TutorialHighCouncilStarted");
			WormAttributes.NativeFieldInfoPtr_InitialLeaderOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "InitialLeaderOptions");
			WormAttributes.NativeFieldInfoPtr_AcquiredListThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AcquiredListThisTurn");
			WormAttributes.NativeFieldInfoPtr_AcquiredEntitiesThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AcquiredEntitiesThisTurn");
			WormAttributes.NativeFieldInfoPtr_LeaderDrawAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LeaderDrawAbility");
			WormAttributes.NativeFieldInfoPtr_RevealStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "RevealStrength");
			WormAttributes.NativeFieldInfoPtr_CustomAbilityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "CustomAbilityIDs");
			WormAttributes.NativeFieldInfoPtr_MentatControllerThisRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "MentatControllerThisRound");
			WormAttributes.NativeFieldInfoPtr_DiscardedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "DiscardedList");
			WormAttributes.NativeFieldInfoPtr_LietKynesPersuasion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LietKynesPersuasion");
			WormAttributes.NativeFieldInfoPtr_RevealCardsProvidingStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "RevealCardsProvidingStrength");
			WormAttributes.NativeFieldInfoPtr_ShippingTroopsGainedThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ShippingTroopsGainedThisTurn");
			WormAttributes.NativeFieldInfoPtr_TiebreakerScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TiebreakerScore");
			WormAttributes.NativeFieldInfoPtr_EndgamePlayableList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "EndgamePlayableList");
			WormAttributes.NativeFieldInfoPtr_SignetSwapAbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SignetSwapAbilityID");
			WormAttributes.NativeFieldInfoPtr_CanAcquireFromImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "CanAcquireFromImperiumRow");
			WormAttributes.NativeFieldInfoPtr_TroopsDeployedThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TroopsDeployedThisTurn");
			WormAttributes.NativeFieldInfoPtr_ExtraTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ExtraTurn");
			WormAttributes.NativeFieldInfoPtr_OneStepAheadCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "OneStepAheadCard");
			WormAttributes.NativeFieldInfoPtr_LastShippingRecallSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LastShippingRecallSpace");
			WormAttributes.NativeFieldInfoPtr_TechTileActionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TechTileActionCount");
			WormAttributes.NativeFieldInfoPtr_DreadnoughtCombatCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "DreadnoughtCombatCount");
			WormAttributes.NativeFieldInfoPtr_OperativeCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "OperativeCount");
			WormAttributes.NativeFieldInfoPtr_UnloadCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "UnloadCount");
			WormAttributes.NativeFieldInfoPtr_ShippingFromTopCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ShippingFromTopCount");
			WormAttributes.NativeFieldInfoPtr_ShippingCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ShippingCount");
			WormAttributes.NativeFieldInfoPtr_IxianSupremacyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "IxianSupremacyCount");
			WormAttributes.NativeFieldInfoPtr_SpaceControlCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SpaceControlCount");
			WormAttributes.NativeFieldInfoPtr_LastCardAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LastCardAcquired");
			WormAttributes.NativeFieldInfoPtr_FinalDeliveryCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "FinalDeliveryCount");
			WormAttributes.NativeFieldInfoPtr_TheWeirdingWayTurnCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TheWeirdingWayTurnCount");
			WormAttributes.NativeFieldInfoPtr_InfiltrateThisRoundCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "InfiltrateThisRoundCount");
			WormAttributes.NativeFieldInfoPtr_OneStepAheadConsecutiveCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "OneStepAheadConsecutiveCount");
			WormAttributes.NativeFieldInfoPtr_OneStepAheadThisRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "OneStepAheadThisRound");
			WormAttributes.NativeFieldInfoPtr_RevealedThisRoundCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "RevealedThisRoundCount");
			WormAttributes.NativeFieldInfoPtr_SpacingGuildPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SpacingGuildPlayed");
			WormAttributes.NativeFieldInfoPtr_UnaddedTechNegotiators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "UnaddedTechNegotiators");
			WormAttributes.NativeFieldInfoPtr_UngainedTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "UngainedTroops");
			WormAttributes.NativeFieldInfoPtr_TechTileAcquiredCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TechTileAcquiredCount");
			WormAttributes.NativeFieldInfoPtr_OneStepAheadEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "OneStepAheadEntity");
			WormAttributes.NativeFieldInfoPtr_UndeployedTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "UndeployedTroops");
			WormAttributes.NativeFieldInfoPtr_RevealedStrengthApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "RevealedStrengthApplied");
			WormAttributes.NativeFieldInfoPtr_ResourceMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ResourceMods");
			WormAttributes.NativeFieldInfoPtr_HasDreadnought = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HasDreadnought");
			WormAttributes.NativeFieldInfoPtr_TurnAchievements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TurnAchievements");
			WormAttributes.NativeFieldInfoPtr_EconomicSupremacyPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "EconomicSupremacyPoints");
			WormAttributes.NativeFieldInfoPtr_NoConflictVPThisRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "NoConflictVPThisRound");
			WormAttributes.NativeFieldInfoPtr_TurnSwordmasterAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TurnSwordmasterAcquired");
			WormAttributes.NativeFieldInfoPtr_TurnHighCouncilSeatAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TurnHighCouncilSeatAcquired");
			WormAttributes.NativeFieldInfoPtr_ConflictIntriguesPlayedThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ConflictIntriguesPlayedThisTurn");
			WormAttributes.NativeFieldInfoPtr_DesertAmbushUnitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "DesertAmbushUnitCount");
			WormAttributes.NativeFieldInfoPtr_ExtraTurnsStacked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ExtraTurnsStacked");
			WormAttributes.NativeFieldInfoPtr_SignetIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SignetIcons");
			WormAttributes.NativeFieldInfoPtr_HasEndedTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HasEndedTurn");
			WormAttributes.NativeFieldInfoPtr_FamilyAtomics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "FamilyAtomics");
			WormAttributes.NativeFieldInfoPtr_GeneticMarkers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "GeneticMarkers");
			WormAttributes.NativeFieldInfoPtr_GainedSpiceThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "GainedSpiceThisTurn");
			WormAttributes.NativeFieldInfoPtr_UsurpGraftCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "UsurpGraftCard");
			WormAttributes.NativeFieldInfoPtr_ReclaimedForcesCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ReclaimedForcesCount");
			WormAttributes.NativeFieldInfoPtr_GraftedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "GraftedCount");
			WormAttributes.NativeFieldInfoPtr_TleilaxuAgentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TleilaxuAgentCount");
			WormAttributes.NativeFieldInfoPtr_PlansRevealedEntityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "PlansRevealedEntityIDs");
			WormAttributes.NativeFieldInfoPtr_FamilyAtomicsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "FamilyAtomicsCount");
			WormAttributes.NativeFieldInfoPtr_ChairdogReturnCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ChairdogReturnCards");
			WormAttributes.NativeFieldInfoPtr_UngainedSpecimens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "UngainedSpecimens");
			WormAttributes.NativeFieldInfoPtr_CannotDrawIntrigue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "CannotDrawIntrigue");
			WormAttributes.NativeFieldInfoPtr_ResearchCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ResearchCount");
			WormAttributes.NativeFieldInfoPtr_BeneTleilaxAcquired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "BeneTleilaxAcquired");
			WormAttributes.NativeFieldInfoPtr_SpecimenSpent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SpecimenSpent");
			WormAttributes.NativeFieldInfoPtr_SpecimenSpentOnTleilaxCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SpecimenSpentOnTleilaxCards");
			WormAttributes.NativeFieldInfoPtr_TleilaxuInfluence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TleilaxuInfluence");
			WormAttributes.NativeFieldInfoPtr_TrashList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TrashList");
			WormAttributes.NativeFieldInfoPtr_TroopsDeployedThisConflict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TroopsDeployedThisConflict");
			WormAttributes.NativeFieldInfoPtr_PlayedAndMovedCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "PlayedAndMovedCleanup");
			WormAttributes.NativeFieldInfoPtr_TroopDeployNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TroopDeployNumber");
			WormAttributes.NativeFieldInfoPtr_DreadnoughtDeployNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "DreadnoughtDeployNumber");
			WormAttributes.NativeFieldInfoPtr_GraftedThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "GraftedThisTurn");
			WormAttributes.NativeFieldInfoPtr_HighPriorityTravelDeploy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HighPriorityTravelDeploy");
			WormAttributes.NativeFieldInfoPtr_GainedPersuasionThisTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "GainedPersuasionThisTurn");
			WormAttributes.NativeFieldInfoPtr_DoubleAgentsAcquiredThisRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "DoubleAgentsAcquiredThisRound");
			WormAttributes.NativeFieldInfoPtr_AgentText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AgentText");
			WormAttributes.NativeFieldInfoPtr_RevealText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "RevealText");
			WormAttributes.NativeFieldInfoPtr_AcquireText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AcquireText");
			WormAttributes.NativeFieldInfoPtr_Image = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Image");
			WormAttributes.NativeFieldInfoPtr_IconList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "IconList");
			WormAttributes.NativeFieldInfoPtr_FactionList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "FactionList");
			WormAttributes.NativeFieldInfoPtr_PersuasionCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "PersuasionCost");
			WormAttributes.NativeFieldInfoPtr_ConflictLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ConflictLevel");
			WormAttributes.NativeFieldInfoPtr_Tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Tags");
			WormAttributes.NativeFieldInfoPtr_ImperiumType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ImperiumType");
			WormAttributes.NativeFieldInfoPtr_IntrigueTypeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "IntrigueTypeList");
			WormAttributes.NativeFieldInfoPtr_AgentSpice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AgentSpice");
			WormAttributes.NativeFieldInfoPtr_AgentWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AgentWater");
			WormAttributes.NativeFieldInfoPtr_AgentSolari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AgentSolari");
			WormAttributes.NativeFieldInfoPtr_HagalPlayerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HagalPlayerCount");
			WormAttributes.NativeFieldInfoPtr_AgentTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AgentTroops");
			WormAttributes.NativeFieldInfoPtr_CardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "CardCount");
			WormAttributes.NativeFieldInfoPtr_Permanent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Permanent");
			WormAttributes.NativeFieldInfoPtr_ShowHinting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ShowHinting");
			WormAttributes.NativeFieldInfoPtr_AcquireEffectList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AcquireEffectList");
			WormAttributes.NativeFieldInfoPtr_PlayedSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "PlayedSpace");
			WormAttributes.NativeFieldInfoPtr_InfiltrationIconList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "InfiltrationIconList");
			WormAttributes.NativeFieldInfoPtr_Flipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Flipped");
			WormAttributes.NativeFieldInfoPtr_Rating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Rating");
			WormAttributes.NativeFieldInfoPtr_TriggeredTechTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TriggeredTechTile");
			WormAttributes.NativeFieldInfoPtr_AgentSpecimen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AgentSpecimen");
			WormAttributes.NativeFieldInfoPtr_SpecimenCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SpecimenCost");
			WormAttributes.NativeFieldInfoPtr_GraftedTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "GraftedTo");
			WormAttributes.NativeFieldInfoPtr_ConditionalIconList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ConditionalIconList");
			WormAttributes.NativeFieldInfoPtr_ConditionalIconsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ConditionalIconsUsed");
			WormAttributes.NativeFieldInfoPtr_PersuasionDiscountAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "PersuasionDiscountAmount");
			WormAttributes.NativeFieldInfoPtr_ConditionalEndgameVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ConditionalEndgameVP");
			WormAttributes.NativeFieldInfoPtr_Blocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Blocked");
			WormAttributes.NativeFieldInfoPtr_CombatSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "CombatSpace");
			WormAttributes.NativeFieldInfoPtr_AgentIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AgentIcon");
			WormAttributes.NativeFieldInfoPtr_ControllingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ControllingPlayer");
			WormAttributes.NativeFieldInfoPtr_BonusSpice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "BonusSpice");
			WormAttributes.NativeFieldInfoPtr_ControlSpice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ControlSpice");
			WormAttributes.NativeFieldInfoPtr_ControlWater = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ControlWater");
			WormAttributes.NativeFieldInfoPtr_ControlSolari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ControlSolari");
			WormAttributes.NativeFieldInfoPtr_BlockExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "BlockExceptions");
			WormAttributes.NativeFieldInfoPtr_SolariDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SolariDiscount");
			WormAttributes.NativeFieldInfoPtr_SpiceGainReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SpiceGainReduction");
			WormAttributes.NativeFieldInfoPtr_SpiceDiscount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SpiceDiscount");
			WormAttributes.NativeFieldInfoPtr_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Index");
			WormAttributes.NativeFieldInfoPtr_NextIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "NextIndices");
			WormAttributes.NativeFieldInfoPtr_LeaderComplexity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LeaderComplexity");
			WormAttributes.NativeFieldInfoPtr_LeaderHouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LeaderHouse");
			WormAttributes.NativeFieldInfoPtr_SnooperFactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SnooperFactions");
			WormAttributes.NativeFieldInfoPtr_HagalLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HagalLeader");
			WormAttributes.NativeFieldInfoPtr_SnooperFactionsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SnooperFactionsUsed");
			WormAttributes.NativeFieldInfoPtr_WormCurrentTurnPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "WormCurrentTurnPlayer");
			WormAttributes.NativeFieldInfoPtr_RoundPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "RoundPhase");
			WormAttributes.NativeFieldInfoPtr_Exhausted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "Exhausted");
			WormAttributes.NativeFieldInfoPtr_AbilityTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AbilityTiming");
			WormAttributes.NativeFieldInfoPtr_TrashValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "TrashValue");
			WormAttributes.NativeFieldInfoPtr_AcquireValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "AcquireValue");
			WormAttributes.NativeFieldInfoPtr_EarlyMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "EarlyMod");
			WormAttributes.NativeFieldInfoPtr_LateMod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LateMod");
			WormAttributes.NativeFieldInfoPtr_DeferValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "DeferValue");
			WormAttributes.NativeFieldInfoPtr_HagalMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HagalMode");
			WormAttributes.NativeFieldInfoPtr_HagalDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HagalDifficulty");
			WormAttributes.NativeFieldInfoPtr_HagalSwordmasterRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HagalSwordmasterRound");
			WormAttributes.NativeFieldInfoPtr_HagalDeckList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HagalDeckList");
			WormAttributes.NativeFieldInfoPtr_HagalClaimedConflictBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HagalClaimedConflictBonus");
			WormAttributes.NativeFieldInfoPtr_CombatValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "CombatValue");
			WormAttributes.NativeFieldInfoPtr_HagalChurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HagalChurn");
			WormAttributes.NativeFieldInfoPtr_HagalBrutalEscalation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HagalBrutalEscalation");
			WormAttributes.NativeFieldInfoPtr_MinToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "MinToSelect");
			WormAttributes.NativeFieldInfoPtr_MaxToSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "MaxToSelect");
			WormAttributes.NativeFieldInfoPtr_InfluenceDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "InfluenceDelta");
			WormAttributes.NativeFieldInfoPtr_WillClearUndo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "WillClearUndo");
			WormAttributes.NativeFieldInfoPtr_UndoSequenceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "UndoSequenceName");
			WormAttributes.NativeFieldInfoPtr_SequenceAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SequenceAttributes");
			WormAttributes.NativeFieldInfoPtr_UnusableAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "UnusableAbilities");
			WormAttributes.NativeFieldInfoPtr_UndoSequenceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "UndoSequenceID");
			WormAttributes.NativeFieldInfoPtr_UndoSequenceWrap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "UndoSequenceWrap");
			WormAttributes.NativeFieldInfoPtr_DeferredAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "DeferredAbility");
			WormAttributes.NativeFieldInfoPtr_ConflictPlace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ConflictPlace");
			WormAttributes.NativeFieldInfoPtr_SpaceNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SpaceNumber");
			WormAttributes.NativeFieldInfoPtr_BackgroundAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "BackgroundAbility");
			WormAttributes.NativeFieldInfoPtr_SkipNextExhaust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SkipNextExhaust");
			WormAttributes.NativeFieldInfoPtr_HideInvalidDeferred = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "HideInvalidDeferred");
			WormAttributes.NativeFieldInfoPtr_NoCancelButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "NoCancelButton");
			WormAttributes.NativeFieldInfoPtr_SourceArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "SourceArchetype");
			WormAttributes.NativeFieldInfoPtr_ResearchAssignmentEarmarked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ResearchAssignmentEarmarked");
			WormAttributes.NativeFieldInfoPtr_ShowOfStrengthCardDrawable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ShowOfStrengthCardDrawable");
			WormAttributes.NativeFieldInfoPtr_ResearchAssignmentEntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ResearchAssignmentEntityID");
			WormAttributes.NativeFieldInfoPtr_LogTemplate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LogTemplate");
			WormAttributes.NativeFieldInfoPtr_LeaderArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "LeaderArchetype");
			WormAttributes.NativeFieldInfoPtr_ChosenArchetype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, "ChosenArchetype");
			WormAttributes.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAttributes>.NativeClassPtr, 100664720);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00080288 File Offset: 0x0007E488
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAttributes.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00003DF1 File Offset: 0x00001FF1
		public WormAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x000802B0 File Offset: 0x0007E4B0
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00003DFA File Offset: 0x00001FFA
		public unsafe static AttributeDefinition<Nullable<int>> VictoryPoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_VictoryPoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_VictoryPoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x000802D8 File Offset: 0x0007E4D8
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00003E0C File Offset: 0x0000200C
		public unsafe static AttributeDefinition<Nullable<bool>> Winner
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Winner, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Winner, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00080300 File Offset: 0x0007E500
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00003E1E File Offset: 0x0000201E
		public unsafe static AttributeDefinition<Nullable<int>> Spice
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Spice, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Spice, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00080328 File Offset: 0x0007E528
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00003E30 File Offset: 0x00002030
		public unsafe static AttributeDefinition<Nullable<int>> Water
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Water, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Water, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00080350 File Offset: 0x0007E550
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00003E42 File Offset: 0x00002042
		public unsafe static AttributeDefinition<Nullable<int>> Solari
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Solari, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Solari, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00080378 File Offset: 0x0007E578
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00003E54 File Offset: 0x00002054
		public unsafe static AttributeDefinition<Nullable<int>> Troops
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Troops, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Troops, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x000803A0 File Offset: 0x0007E5A0
		// (set) Token: 0x06000534 RID: 1332 RVA: 0x00003E66 File Offset: 0x00002066
		public unsafe static AttributeDefinition<Nullable<int>> Persuasion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Persuasion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Persuasion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x000803C8 File Offset: 0x0007E5C8
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00003E78 File Offset: 0x00002078
		public unsafe static AttributeDefinition<Nullable<int>> Strength
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Strength, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Strength, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x000803F0 File Offset: 0x0007E5F0
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00003E8A File Offset: 0x0000208A
		public unsafe static AttributeDefinition<Nullable<Factions>> Faction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Faction, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<Factions>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Faction, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00080418 File Offset: 0x0007E618
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x00003E9C File Offset: 0x0000209C
		public unsafe static AttributeDefinition<Nullable<int>> SpiceCost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SpiceCost, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SpiceCost, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00080440 File Offset: 0x0007E640
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x00003EAE File Offset: 0x000020AE
		public unsafe static AttributeDefinition<Nullable<int>> WaterCost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_WaterCost, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_WaterCost, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00080468 File Offset: 0x0007E668
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00003EC0 File Offset: 0x000020C0
		public unsafe static AttributeDefinition<Nullable<int>> SolariCost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SolariCost, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SolariCost, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00080490 File Offset: 0x0007E690
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00003ED2 File Offset: 0x000020D2
		public unsafe static AttributeDefinition<List<AbilityID>> WormAbilityIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_WormAbilityIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<AbilityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_WormAbilityIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x000804B8 File Offset: 0x0007E6B8
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x00003EE4 File Offset: 0x000020E4
		public unsafe static AttributeDefinition<List<Set>> SetList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SetList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<Set>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SetList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x000804E0 File Offset: 0x0007E6E0
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00003EF6 File Offset: 0x000020F6
		public unsafe static AttributeDefinition<EntityID> ChosenEntity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ChosenEntity, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ChosenEntity, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000545 RID: 1349 RVA: 0x00080508 File Offset: 0x0007E708
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x00003F08 File Offset: 0x00002108
		public unsafe static AttributeDefinition<List<SerializedPlayerReward>> PlayerRewards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_PlayerRewards, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<SerializedPlayerReward>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_PlayerRewards, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00080530 File Offset: 0x0007E730
		// (set) Token: 0x06000548 RID: 1352 RVA: 0x00003F1A File Offset: 0x0000211A
		public unsafe static AttributeDefinition<Nullable<EntityTypes>> EntityType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_EntityType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<EntityTypes>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_EntityType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00080558 File Offset: 0x0007E758
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x00003F2C File Offset: 0x0000212C
		public unsafe static AttributeDefinition<List<AccountID>> ConflictParticipants
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ConflictParticipants, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<AccountID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ConflictParticipants, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00080580 File Offset: 0x0007E780
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00003F3E File Offset: 0x0000213E
		public unsafe static AttributeDefinition<Nullable<int>> RoundNumber
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_RoundNumber, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_RoundNumber, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x000805A8 File Offset: 0x0007E7A8
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00003F50 File Offset: 0x00002150
		public unsafe static AttributeDefinition<Nullable<bool>> SecondConflictDeck
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SecondConflictDeck, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SecondConflictDeck, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x000805D0 File Offset: 0x0007E7D0
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00003F62 File Offset: 0x00002162
		public unsafe static AttributeDefinition<Nullable<bool>> SkipRecallThisRound
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SkipRecallThisRound, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SkipRecallThisRound, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x000805F8 File Offset: 0x0007E7F8
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x00003F74 File Offset: 0x00002174
		public unsafe static AttributeDefinition<List<PlayerRewards>> ConflictRewards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ConflictRewards, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<PlayerRewards>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ConflictRewards, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x00080620 File Offset: 0x0007E820
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x00003F86 File Offset: 0x00002186
		public unsafe static AttributeDefinition<List<int>> WormSkirmishScoringMethods
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_WormSkirmishScoringMethods, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_WormSkirmishScoringMethods, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x00080648 File Offset: 0x0007E848
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x00003F98 File Offset: 0x00002198
		public unsafe static AttributeDefinition<Nullable<int>> SpiceMustFlowBaseCost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SpiceMustFlowBaseCost, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SpiceMustFlowBaseCost, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x00080670 File Offset: 0x0007E870
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00003FAA File Offset: 0x000021AA
		public unsafe static AttributeDefinition<LocalizableText> WarningText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_WarningText, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_WarningText, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00080698 File Offset: 0x0007E898
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00003FBC File Offset: 0x000021BC
		public unsafe static AttributeDefinition<List<string>> HiddenElements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HiddenElements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HiddenElements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x000806C0 File Offset: 0x0007E8C0
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00003FCE File Offset: 0x000021CE
		public unsafe static AttributeDefinition<List<EntityID>> RevealOrder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_RevealOrder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_RevealOrder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x000806E8 File Offset: 0x0007E8E8
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00003FE0 File Offset: 0x000021E0
		public unsafe static AttributeDefinition<Nullable<int>> Conflict2Count
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Conflict2Count, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Conflict2Count, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00080710 File Offset: 0x0007E910
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00003FF2 File Offset: 0x000021F2
		public unsafe static AttributeDefinition<Nullable<int>> Conflict3Count
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Conflict3Count, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Conflict3Count, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00080738 File Offset: 0x0007E938
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00004004 File Offset: 0x00002204
		public unsafe static AttributeDefinition<Nullable<bool>> LastRoundTriggered
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LastRoundTriggered, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LastRoundTriggered, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00080760 File Offset: 0x0007E960
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00004016 File Offset: 0x00002216
		public unsafe static AttributeDefinition<Nullable<int>> EndgameTriggerScore
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_EndgameTriggerScore, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_EndgameTriggerScore, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x00080788 File Offset: 0x0007E988
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00004028 File Offset: 0x00002228
		public unsafe static AttributeDefinition<Nullable<bool>> AllowDisplayClearOnSave
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AllowDisplayClearOnSave, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AllowDisplayClearOnSave, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x000807B0 File Offset: 0x0007E9B0
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x0000403A File Offset: 0x0000223A
		public unsafe static AttributeDefinition<List<int>> WormSkirmishRuleMods
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_WormSkirmishRuleMods, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_WormSkirmishRuleMods, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x000807D8 File Offset: 0x0007E9D8
		// (set) Token: 0x0600056A RID: 1386 RVA: 0x0000404C File Offset: 0x0000224C
		public unsafe static AttributeDefinition<LeaderAssignmentMode> LeaderAssignmentMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LeaderAssignmentMode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LeaderAssignmentMode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LeaderAssignmentMode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00080800 File Offset: 0x0007EA00
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0000405E File Offset: 0x0000225E
		public unsafe static AttributeDefinition<AccountID> LeaderSelectionPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LeaderSelectionPlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<AccountID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LeaderSelectionPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x00080828 File Offset: 0x0007EA28
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00004070 File Offset: 0x00002270
		public unsafe static AttributeDefinition<Nullable<bool>> EndgameStarted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_EndgameStarted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_EndgameStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00080850 File Offset: 0x0007EA50
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00004082 File Offset: 0x00002282
		public unsafe static AttributeDefinition<Il2CppStructArray<Set>> EnabledSets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_EnabledSets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Il2CppStructArray<Set>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_EnabledSets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00080878 File Offset: 0x0007EA78
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00004094 File Offset: 0x00002294
		public unsafe static AttributeDefinition<ArchetypeID> NewDreadnoughtSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_NewDreadnoughtSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_NewDreadnoughtSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x000808A0 File Offset: 0x0007EAA0
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x000040A6 File Offset: 0x000022A6
		public unsafe static AttributeDefinition<List<AccountID>> ConflictPassedPlayers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ConflictPassedPlayers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<AccountID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ConflictPassedPlayers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x000808C8 File Offset: 0x0007EAC8
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x000040B8 File Offset: 0x000022B8
		public unsafe static AttributeDefinition<Nullable<int>> Dreadnought
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Dreadnought, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Dreadnought, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x000808F0 File Offset: 0x0007EAF0
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x000040CA File Offset: 0x000022CA
		public unsafe static AttributeDefinition<AccountID> LastConflictIntriguePlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LastConflictIntriguePlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<AccountID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LastConflictIntriguePlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00080918 File Offset: 0x0007EB18
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x000040DC File Offset: 0x000022DC
		public unsafe static AttributeDefinition<Nullable<bool>> EpicGameMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_EpicGameMode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_EpicGameMode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x00080940 File Offset: 0x0007EB40
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x000040EE File Offset: 0x000022EE
		public unsafe static AttributeDefinition<Nullable<bool>> DeadlyAllianceAwarded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_DeadlyAllianceAwarded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_DeadlyAllianceAwarded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x00080968 File Offset: 0x0007EB68
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x00004100 File Offset: 0x00002300
		public unsafe static AttributeDefinition<Nullable<int>> TutorialStep
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TutorialStep, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TutorialStep, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x00080990 File Offset: 0x0007EB90
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00004112 File Offset: 0x00002312
		public unsafe static AttributeDefinition<Nullable<bool>> HoldFirstPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HoldFirstPlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HoldFirstPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x000809B8 File Offset: 0x0007EBB8
		// (set) Token: 0x06000582 RID: 1410 RVA: 0x00004124 File Offset: 0x00002324
		public unsafe static AttributeDefinition<Nullable<bool>> ShowSequenceToAll
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ShowSequenceToAll, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ShowSequenceToAll, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x000809E0 File Offset: 0x0007EBE0
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x00004136 File Offset: 0x00002336
		public unsafe static AttributeDefinition<Nullable<bool>> HasMigratedReserveRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HasMigratedReserveRow, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HasMigratedReserveRow, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00080A08 File Offset: 0x0007EC08
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00004148 File Offset: 0x00002348
		public unsafe static AttributeDefinition<Nullable<bool>> HasMigratedReserveRowTwice
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HasMigratedReserveRowTwice, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HasMigratedReserveRowTwice, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00080A30 File Offset: 0x0007EC30
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x0000415A File Offset: 0x0000235A
		public unsafe static AttributeDefinition<Nullable<int>> Specimen
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Specimen, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Specimen, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x00080A58 File Offset: 0x0007EC58
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x0000416C File Offset: 0x0000236C
		public unsafe static AttributeDefinition<Nullable<bool>> GoTo11Mode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_GoTo11Mode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_GoTo11Mode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x00080A80 File Offset: 0x0007EC80
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x0000417E File Offset: 0x0000237E
		public unsafe static AttributeDefinition<Nullable<int>> TechNegotiator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TechNegotiator, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TechNegotiator, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x00080AA8 File Offset: 0x0007ECA8
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00004190 File Offset: 0x00002390
		public unsafe static AttributeDefinition<Nullable<int>> IntrigueCard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_IntrigueCard, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_IntrigueCard, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x00080AD0 File Offset: 0x0007ECD0
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x000041A2 File Offset: 0x000023A2
		public unsafe static AttributeDefinition<Nullable<int>> ImperiumCard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ImperiumCard, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ImperiumCard, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00080AF8 File Offset: 0x0007ECF8
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x000041B4 File Offset: 0x000023B4
		public unsafe static AttributeDefinition<Nullable<int>> UndoIsCancel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_UndoIsCancel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_UndoIsCancel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x00080B20 File Offset: 0x0007ED20
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x000041C6 File Offset: 0x000023C6
		public unsafe static AttributeDefinition<Nullable<int>> TurnPhase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TurnPhase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TurnPhase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x00080B48 File Offset: 0x0007ED48
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x000041D8 File Offset: 0x000023D8
		public unsafe static AttributeDefinition<Dictionary<Factions, int>> FactionInfluence
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_FactionInfluence, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<Factions, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_FactionInfluence, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x00080B70 File Offset: 0x0007ED70
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x000041EA File Offset: 0x000023EA
		public unsafe static AttributeDefinition<Nullable<PieceColor>> Color
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Color, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<PieceColor>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Color, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00080B98 File Offset: 0x0007ED98
		// (set) Token: 0x0600059A RID: 1434 RVA: 0x000041FC File Offset: 0x000023FC
		public unsafe static AttributeDefinition<Nullable<bool>> FirstPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_FirstPlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_FirstPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600059B RID: 1435 RVA: 0x00080BC0 File Offset: 0x0007EDC0
		// (set) Token: 0x0600059C RID: 1436 RVA: 0x0000420E File Offset: 0x0000240E
		public unsafe static AttributeDefinition<Nullable<PlayerTurnTypes>> PlayerTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_PlayerTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<PlayerTurnTypes>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_PlayerTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x00080BE8 File Offset: 0x0007EDE8
		// (set) Token: 0x0600059E RID: 1438 RVA: 0x00004220 File Offset: 0x00002420
		public unsafe static AttributeDefinition<Nullable<bool>> HighCouncilSeat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HighCouncilSeat, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HighCouncilSeat, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600059F RID: 1439 RVA: 0x00080C10 File Offset: 0x0007EE10
		// (set) Token: 0x060005A0 RID: 1440 RVA: 0x00004232 File Offset: 0x00002432
		public unsafe static AttributeDefinition<Nullable<bool>> PassTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_PassTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_PassTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00080C38 File Offset: 0x0007EE38
		// (set) Token: 0x060005A2 RID: 1442 RVA: 0x00004244 File Offset: 0x00002444
		public unsafe static AttributeDefinition<Nullable<bool>> CanAcquireToDeck
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_CanAcquireToDeck, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_CanAcquireToDeck, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00080C60 File Offset: 0x0007EE60
		// (set) Token: 0x060005A4 RID: 1444 RVA: 0x00004256 File Offset: 0x00002456
		public unsafe static AttributeDefinition<Nullable<bool>> Infiltrate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Infiltrate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Infiltrate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060005A5 RID: 1445 RVA: 0x00080C88 File Offset: 0x0007EE88
		// (set) Token: 0x060005A6 RID: 1446 RVA: 0x00004268 File Offset: 0x00002468
		public unsafe static AttributeDefinition<Nullable<bool>> EnvoyDispatched
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_EnvoyDispatched, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_EnvoyDispatched, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x060005A7 RID: 1447 RVA: 0x00080CB0 File Offset: 0x0007EEB0
		// (set) Token: 0x060005A8 RID: 1448 RVA: 0x0000427A File Offset: 0x0000247A
		public unsafe static AttributeDefinition<Nullable<bool>> AdditionalSpaceInfluence
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AdditionalSpaceInfluence, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AdditionalSpaceInfluence, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00080CD8 File Offset: 0x0007EED8
		// (set) Token: 0x060005AA RID: 1450 RVA: 0x0000428C File Offset: 0x0000248C
		public unsafe static AttributeDefinition<List<Factions>> BaronHarkonnenSecretFactions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_BaronHarkonnenSecretFactions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<Factions>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_BaronHarkonnenSecretFactions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00080D00 File Offset: 0x0007EF00
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0000429E File Offset: 0x0000249E
		public unsafe static AttributeDefinition<Nullable<bool>> Swordmaster
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Swordmaster, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Swordmaster, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00080D28 File Offset: 0x0007EF28
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x000042B0 File Offset: 0x000024B0
		public unsafe static AttributeDefinition<Nullable<int>> UnitsGainedThisTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_UnitsGainedThisTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_UnitsGainedThisTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00080D50 File Offset: 0x0007EF50
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x000042C2 File Offset: 0x000024C2
		public unsafe static AttributeDefinition<List<ArchetypeID>> DeckList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_DeckList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_DeckList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00080D78 File Offset: 0x0007EF78
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x000042D4 File Offset: 0x000024D4
		public unsafe static AttributeDefinition<Nullable<bool>> HasRevealed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HasRevealed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HasRevealed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x00080DA0 File Offset: 0x0007EFA0
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x000042E6 File Offset: 0x000024E6
		public unsafe static AttributeDefinition<Nullable<int>> PossibleStrength
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_PossibleStrength, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_PossibleStrength, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x00080DC8 File Offset: 0x0007EFC8
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x000042F8 File Offset: 0x000024F8
		public unsafe static AttributeDefinition<Nullable<int>> TurnOfRound
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TurnOfRound, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TurnOfRound, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00080DF0 File Offset: 0x0007EFF0
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x0000430A File Offset: 0x0000250A
		public unsafe static AttributeDefinition<Nullable<int>> ShuffleCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ShuffleCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ShuffleCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00080E18 File Offset: 0x0007F018
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x0000431C File Offset: 0x0000251C
		public unsafe static AttributeDefinition<Nullable<int>> CustomDeferralThreshold
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_CustomDeferralThreshold, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_CustomDeferralThreshold, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060005BB RID: 1467 RVA: 0x00080E40 File Offset: 0x0007F040
		// (set) Token: 0x060005BC RID: 1468 RVA: 0x0000432E File Offset: 0x0000252E
		public unsafe static AttributeDefinition<Dictionary<ArchetypeID, int>> VisitedSpaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_VisitedSpaces, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<ArchetypeID, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_VisitedSpaces, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060005BD RID: 1469 RVA: 0x00080E68 File Offset: 0x0007F068
		// (set) Token: 0x060005BE RID: 1470 RVA: 0x00004340 File Offset: 0x00002540
		public unsafe static AttributeDefinition<Nullable<bool>> TutorialAllianceTokenStarted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TutorialAllianceTokenStarted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TutorialAllianceTokenStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060005BF RID: 1471 RVA: 0x00080E90 File Offset: 0x0007F090
		// (set) Token: 0x060005C0 RID: 1472 RVA: 0x00004352 File Offset: 0x00002552
		public unsafe static AttributeDefinition<Nullable<int>> TrashedCardCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TrashedCardCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TrashedCardCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00080EB8 File Offset: 0x0007F0B8
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00004364 File Offset: 0x00002564
		public unsafe static AttributeDefinition<Nullable<int>> EmperorAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_EmperorAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_EmperorAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00080EE0 File Offset: 0x0007F0E0
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00004376 File Offset: 0x00002576
		public unsafe static AttributeDefinition<Nullable<int>> FremenAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_FremenAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_FremenAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x00080F08 File Offset: 0x0007F108
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x00004388 File Offset: 0x00002588
		public unsafe static AttributeDefinition<Nullable<int>> SpacingGuildAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SpacingGuildAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SpacingGuildAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x00080F30 File Offset: 0x0007F130
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x0000439A File Offset: 0x0000259A
		public unsafe static AttributeDefinition<Nullable<int>> BeneGesseritAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_BeneGesseritAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_BeneGesseritAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x00080F58 File Offset: 0x0007F158
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x000043AC File Offset: 0x000025AC
		public unsafe static AttributeDefinition<Nullable<int>> SpiceMustFlowAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SpiceMustFlowAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SpiceMustFlowAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x00080F80 File Offset: 0x0007F180
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x000043BE File Offset: 0x000025BE
		public unsafe static AttributeDefinition<Nullable<int>> MentatUsedCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_MentatUsedCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_MentatUsedCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00080FA8 File Offset: 0x0007F1A8
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x000043D0 File Offset: 0x000025D0
		public unsafe static AttributeDefinition<Nullable<int>> CombatFirstCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_CombatFirstCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_CombatFirstCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00080FD0 File Offset: 0x0007F1D0
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x000043E2 File Offset: 0x000025E2
		public unsafe static AttributeDefinition<Nullable<int>> IntriguePlayedCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_IntriguePlayedCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_IntriguePlayedCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00080FF8 File Offset: 0x0007F1F8
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x000043F4 File Offset: 0x000025F4
		public unsafe static AttributeDefinition<Nullable<int>> WaterSpent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_WaterSpent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_WaterSpent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00081020 File Offset: 0x0007F220
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00004406 File Offset: 0x00002606
		public unsafe static AttributeDefinition<Nullable<int>> CombatHighestSwords
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_CombatHighestSwords, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_CombatHighestSwords, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00081048 File Offset: 0x0007F248
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00004418 File Offset: 0x00002618
		public unsafe static AttributeDefinition<Nullable<int>> CombatFirstFewerUnitsCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_CombatFirstFewerUnitsCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_CombatFirstFewerUnitsCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00081070 File Offset: 0x0007F270
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x0000442A File Offset: 0x0000262A
		public unsafe static AttributeDefinition<Nullable<int>> ExtraDrawCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ExtraDrawCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ExtraDrawCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00081098 File Offset: 0x0007F298
		// (set) Token: 0x060005DA RID: 1498 RVA: 0x0000443C File Offset: 0x0000263C
		public unsafe static AttributeDefinition<Nullable<int>> ExpensiveAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ExpensiveAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ExpensiveAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x000810C0 File Offset: 0x0007F2C0
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x0000444E File Offset: 0x0000264E
		public unsafe static AttributeDefinition<Nullable<int>> CheapAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_CheapAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_CheapAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x000810E8 File Offset: 0x0007F2E8
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00004460 File Offset: 0x00002660
		public unsafe static AttributeDefinition<Nullable<int>> WithAbilityAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_WithAbilityAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_WithAbilityAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00081110 File Offset: 0x0007F310
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00004472 File Offset: 0x00002672
		public unsafe static AttributeDefinition<Nullable<int>> FremenBondCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_FremenBondCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_FremenBondCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x00081138 File Offset: 0x0007F338
		// (set) Token: 0x060005E2 RID: 1506 RVA: 0x00004484 File Offset: 0x00002684
		public unsafe static AttributeDefinition<Nullable<int>> TroopsRetreatedCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TroopsRetreatedCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TroopsRetreatedCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00081160 File Offset: 0x0007F360
		// (set) Token: 0x060005E4 RID: 1508 RVA: 0x00004496 File Offset: 0x00002696
		public unsafe static AttributeDefinition<Nullable<int>> TurnCardsAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TurnCardsAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TurnCardsAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060005E5 RID: 1509 RVA: 0x00081188 File Offset: 0x0007F388
		// (set) Token: 0x060005E6 RID: 1510 RVA: 0x000044A8 File Offset: 0x000026A8
		public unsafe static AttributeDefinition<Nullable<bool>> ConflictFirstPlace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ConflictFirstPlace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ConflictFirstPlace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000811B0 File Offset: 0x0007F3B0
		// (set) Token: 0x060005E8 RID: 1512 RVA: 0x000044BA File Offset: 0x000026BA
		public unsafe static AttributeDefinition<Nullable<int>> BaseDeployableUnits
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_BaseDeployableUnits, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_BaseDeployableUnits, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x000811D8 File Offset: 0x0007F3D8
		// (set) Token: 0x060005EA RID: 1514 RVA: 0x000044CC File Offset: 0x000026CC
		public unsafe static AttributeDefinition<Dictionary<string, int>> RevealPreview
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_RevealPreview, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<string, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_RevealPreview, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x00081200 File Offset: 0x0007F400
		// (set) Token: 0x060005EC RID: 1516 RVA: 0x000044DE File Offset: 0x000026DE
		public unsafe static AttributeDefinition<Nullable<int>> StartingPlayerOrder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_StartingPlayerOrder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_StartingPlayerOrder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00081228 File Offset: 0x0007F428
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x000044F0 File Offset: 0x000026F0
		public unsafe static AttributeDefinition<Nullable<int>> EndlessAssaultCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_EndlessAssaultCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_EndlessAssaultCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060005EF RID: 1519 RVA: 0x00081250 File Offset: 0x0007F450
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00004502 File Offset: 0x00002702
		public unsafe static AttributeDefinition<Nullable<int>> InfluenceRank
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_InfluenceRank, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_InfluenceRank, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00081278 File Offset: 0x0007F478
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00004514 File Offset: 0x00002714
		public unsafe static AttributeDefinition<Nullable<int>> ControlMarkers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ControlMarkers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ControlMarkers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x000812A0 File Offset: 0x0007F4A0
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00004526 File Offset: 0x00002726
		public unsafe static AttributeDefinition<Dictionary<EntityID, int>> EarlyPersuasion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_EarlyPersuasion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<EntityID, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_EarlyPersuasion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x000812C8 File Offset: 0x0007F4C8
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x00004538 File Offset: 0x00002738
		public unsafe static AttributeDefinition<Nullable<int>> DesertPowerSwords
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_DesertPowerSwords, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_DesertPowerSwords, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000812F0 File Offset: 0x0007F4F0
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x0000454A File Offset: 0x0000274A
		public unsafe static AttributeDefinition<Dictionary<EntityID, int>> VPSources
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_VPSources, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<EntityID, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_VPSources, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x00081318 File Offset: 0x0007F518
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x0000455C File Offset: 0x0000275C
		public unsafe static AttributeDefinition<List<ArchetypeID>> Reshuffle1DeckOrder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Reshuffle1DeckOrder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Reshuffle1DeckOrder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x00081340 File Offset: 0x0007F540
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x0000456E File Offset: 0x0000276E
		public unsafe static AttributeDefinition<List<ArchetypeID>> Reshuffle2DeckOrder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Reshuffle2DeckOrder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Reshuffle2DeckOrder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x00081368 File Offset: 0x0007F568
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00004580 File Offset: 0x00002780
		public unsafe static AttributeDefinition<List<ArchetypeID>> Reshuffle3DeckOrder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Reshuffle3DeckOrder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Reshuffle3DeckOrder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x00081390 File Offset: 0x0007F590
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00004592 File Offset: 0x00002792
		public unsafe static AttributeDefinition<Nullable<bool>> IsHagalPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_IsHagalPlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_IsHagalPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x000813B8 File Offset: 0x0007F5B8
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x000045A4 File Offset: 0x000027A4
		public unsafe static AttributeDefinition<List<Factions>> FactionsBlocked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_FactionsBlocked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<Factions>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_FactionsBlocked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x000813E0 File Offset: 0x0007F5E0
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x000045B6 File Offset: 0x000027B6
		public unsafe static AttributeDefinition<ArchetypeID> PrescienceTopCard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_PrescienceTopCard, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_PrescienceTopCard, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x00081408 File Offset: 0x0007F608
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x000045C8 File Offset: 0x000027C8
		public unsafe static AttributeDefinition<List<EntityID>> DarkSpaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_DarkSpaces, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_DarkSpaces, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x00081430 File Offset: 0x0007F630
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x000045DA File Offset: 0x000027DA
		public unsafe static AttributeDefinition<Nullable<int>> AllianceTokenVP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AllianceTokenVP, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AllianceTokenVP, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00081458 File Offset: 0x0007F658
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x000045EC File Offset: 0x000027EC
		public unsafe static AttributeDefinition<Nullable<bool>> TutorialHighCouncilStarted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TutorialHighCouncilStarted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TutorialHighCouncilStarted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x00081480 File Offset: 0x0007F680
		// (set) Token: 0x0600060C RID: 1548 RVA: 0x000045FE File Offset: 0x000027FE
		public unsafe static AttributeDefinition<List<ArchetypeID>> InitialLeaderOptions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_InitialLeaderOptions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_InitialLeaderOptions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x000814A8 File Offset: 0x0007F6A8
		// (set) Token: 0x0600060E RID: 1550 RVA: 0x00004610 File Offset: 0x00002810
		public unsafe static AttributeDefinition<List<ArchetypeID>> AcquiredListThisTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AcquiredListThisTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AcquiredListThisTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x000814D0 File Offset: 0x0007F6D0
		// (set) Token: 0x06000610 RID: 1552 RVA: 0x00004622 File Offset: 0x00002822
		public unsafe static AttributeDefinition<List<EntityID>> AcquiredEntitiesThisTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AcquiredEntitiesThisTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AcquiredEntitiesThisTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x000814F8 File Offset: 0x0007F6F8
		// (set) Token: 0x06000612 RID: 1554 RVA: 0x00004634 File Offset: 0x00002834
		public unsafe static AttributeDefinition<Nullable<bool>> LeaderDrawAbility
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LeaderDrawAbility, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LeaderDrawAbility, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x00081520 File Offset: 0x0007F720
		// (set) Token: 0x06000614 RID: 1556 RVA: 0x00004646 File Offset: 0x00002846
		public unsafe static AttributeDefinition<Nullable<int>> RevealStrength
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_RevealStrength, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_RevealStrength, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x00081548 File Offset: 0x0007F748
		// (set) Token: 0x06000616 RID: 1558 RVA: 0x00004658 File Offset: 0x00002858
		public unsafe static AttributeDefinition<List<AbilityID>> CustomAbilityIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_CustomAbilityIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<AbilityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_CustomAbilityIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000617 RID: 1559 RVA: 0x00081570 File Offset: 0x0007F770
		// (set) Token: 0x06000618 RID: 1560 RVA: 0x0000466A File Offset: 0x0000286A
		public unsafe static AttributeDefinition<Nullable<bool>> MentatControllerThisRound
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_MentatControllerThisRound, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_MentatControllerThisRound, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x00081598 File Offset: 0x0007F798
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x0000467C File Offset: 0x0000287C
		public unsafe static AttributeDefinition<List<ArchetypeID>> DiscardedList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_DiscardedList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_DiscardedList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x000815C0 File Offset: 0x0007F7C0
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x0000468E File Offset: 0x0000288E
		public unsafe static AttributeDefinition<Nullable<int>> LietKynesPersuasion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LietKynesPersuasion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LietKynesPersuasion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x000815E8 File Offset: 0x0007F7E8
		// (set) Token: 0x0600061E RID: 1566 RVA: 0x000046A0 File Offset: 0x000028A0
		public unsafe static AttributeDefinition<Nullable<int>> RevealCardsProvidingStrength
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_RevealCardsProvidingStrength, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_RevealCardsProvidingStrength, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x00081610 File Offset: 0x0007F810
		// (set) Token: 0x06000620 RID: 1568 RVA: 0x000046B2 File Offset: 0x000028B2
		public unsafe static AttributeDefinition<Nullable<int>> ShippingTroopsGainedThisTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ShippingTroopsGainedThisTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ShippingTroopsGainedThisTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x00081638 File Offset: 0x0007F838
		// (set) Token: 0x06000622 RID: 1570 RVA: 0x000046C4 File Offset: 0x000028C4
		public unsafe static AttributeDefinition<Nullable<int>> TiebreakerScore
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TiebreakerScore, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TiebreakerScore, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00081660 File Offset: 0x0007F860
		// (set) Token: 0x06000624 RID: 1572 RVA: 0x000046D6 File Offset: 0x000028D6
		public unsafe static AttributeDefinition<List<EntityID>> EndgamePlayableList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_EndgamePlayableList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_EndgamePlayableList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00081688 File Offset: 0x0007F888
		// (set) Token: 0x06000626 RID: 1574 RVA: 0x000046E8 File Offset: 0x000028E8
		public unsafe static AttributeDefinition<AbilityID> SignetSwapAbilityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SignetSwapAbilityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<AbilityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SignetSwapAbilityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x000816B0 File Offset: 0x0007F8B0
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x000046FA File Offset: 0x000028FA
		public unsafe static AttributeDefinition<Nullable<bool>> CanAcquireFromImperiumRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_CanAcquireFromImperiumRow, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_CanAcquireFromImperiumRow, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x000816D8 File Offset: 0x0007F8D8
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x0000470C File Offset: 0x0000290C
		public unsafe static AttributeDefinition<Nullable<int>> TroopsDeployedThisTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TroopsDeployedThisTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TroopsDeployedThisTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600062B RID: 1579 RVA: 0x00081700 File Offset: 0x0007F900
		// (set) Token: 0x0600062C RID: 1580 RVA: 0x0000471E File Offset: 0x0000291E
		public unsafe static AttributeDefinition<Nullable<bool>> ExtraTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ExtraTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ExtraTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x00081728 File Offset: 0x0007F928
		// (set) Token: 0x0600062E RID: 1582 RVA: 0x00004730 File Offset: 0x00002930
		public unsafe static AttributeDefinition<ArchetypeID> OneStepAheadCard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_OneStepAheadCard, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_OneStepAheadCard, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x00081750 File Offset: 0x0007F950
		// (set) Token: 0x06000630 RID: 1584 RVA: 0x00004742 File Offset: 0x00002942
		public unsafe static AttributeDefinition<Nullable<int>> LastShippingRecallSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LastShippingRecallSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LastShippingRecallSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00081778 File Offset: 0x0007F978
		// (set) Token: 0x06000632 RID: 1586 RVA: 0x00004754 File Offset: 0x00002954
		public unsafe static AttributeDefinition<Nullable<int>> TechTileActionCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TechTileActionCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TechTileActionCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x000817A0 File Offset: 0x0007F9A0
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00004766 File Offset: 0x00002966
		public unsafe static AttributeDefinition<Nullable<int>> DreadnoughtCombatCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_DreadnoughtCombatCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_DreadnoughtCombatCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x000817C8 File Offset: 0x0007F9C8
		// (set) Token: 0x06000636 RID: 1590 RVA: 0x00004778 File Offset: 0x00002978
		public unsafe static AttributeDefinition<Nullable<int>> OperativeCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_OperativeCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_OperativeCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x000817F0 File Offset: 0x0007F9F0
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x0000478A File Offset: 0x0000298A
		public unsafe static AttributeDefinition<Nullable<int>> UnloadCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_UnloadCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_UnloadCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00081818 File Offset: 0x0007FA18
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x0000479C File Offset: 0x0000299C
		public unsafe static AttributeDefinition<Nullable<int>> ShippingFromTopCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ShippingFromTopCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ShippingFromTopCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00081840 File Offset: 0x0007FA40
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x000047AE File Offset: 0x000029AE
		public unsafe static AttributeDefinition<Nullable<int>> ShippingCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ShippingCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ShippingCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00081868 File Offset: 0x0007FA68
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x000047C0 File Offset: 0x000029C0
		public unsafe static AttributeDefinition<Nullable<int>> IxianSupremacyCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_IxianSupremacyCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_IxianSupremacyCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00081890 File Offset: 0x0007FA90
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x000047D2 File Offset: 0x000029D2
		public unsafe static AttributeDefinition<Nullable<int>> SpaceControlCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SpaceControlCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SpaceControlCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000641 RID: 1601 RVA: 0x000818B8 File Offset: 0x0007FAB8
		// (set) Token: 0x06000642 RID: 1602 RVA: 0x000047E4 File Offset: 0x000029E4
		public unsafe static AttributeDefinition<ArchetypeID> LastCardAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LastCardAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LastCardAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000643 RID: 1603 RVA: 0x000818E0 File Offset: 0x0007FAE0
		// (set) Token: 0x06000644 RID: 1604 RVA: 0x000047F6 File Offset: 0x000029F6
		public unsafe static AttributeDefinition<Nullable<int>> FinalDeliveryCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_FinalDeliveryCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_FinalDeliveryCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x00081908 File Offset: 0x0007FB08
		// (set) Token: 0x06000646 RID: 1606 RVA: 0x00004808 File Offset: 0x00002A08
		public unsafe static AttributeDefinition<Nullable<int>> TheWeirdingWayTurnCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TheWeirdingWayTurnCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TheWeirdingWayTurnCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00081930 File Offset: 0x0007FB30
		// (set) Token: 0x06000648 RID: 1608 RVA: 0x0000481A File Offset: 0x00002A1A
		public unsafe static AttributeDefinition<Nullable<int>> InfiltrateThisRoundCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_InfiltrateThisRoundCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_InfiltrateThisRoundCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x00081958 File Offset: 0x0007FB58
		// (set) Token: 0x0600064A RID: 1610 RVA: 0x0000482C File Offset: 0x00002A2C
		public unsafe static AttributeDefinition<Nullable<int>> OneStepAheadConsecutiveCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_OneStepAheadConsecutiveCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_OneStepAheadConsecutiveCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x00081980 File Offset: 0x0007FB80
		// (set) Token: 0x0600064C RID: 1612 RVA: 0x0000483E File Offset: 0x00002A3E
		public unsafe static AttributeDefinition<Nullable<bool>> OneStepAheadThisRound
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_OneStepAheadThisRound, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_OneStepAheadThisRound, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x000819A8 File Offset: 0x0007FBA8
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00004850 File Offset: 0x00002A50
		public unsafe static AttributeDefinition<Nullable<int>> RevealedThisRoundCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_RevealedThisRoundCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_RevealedThisRoundCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x000819D0 File Offset: 0x0007FBD0
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00004862 File Offset: 0x00002A62
		public unsafe static AttributeDefinition<Nullable<int>> SpacingGuildPlayed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SpacingGuildPlayed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SpacingGuildPlayed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x000819F8 File Offset: 0x0007FBF8
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00004874 File Offset: 0x00002A74
		public unsafe static AttributeDefinition<Nullable<int>> UnaddedTechNegotiators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_UnaddedTechNegotiators, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_UnaddedTechNegotiators, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x00081A20 File Offset: 0x0007FC20
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x00004886 File Offset: 0x00002A86
		public unsafe static AttributeDefinition<Nullable<int>> UngainedTroops
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_UngainedTroops, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_UngainedTroops, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x00081A48 File Offset: 0x0007FC48
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x00004898 File Offset: 0x00002A98
		public unsafe static AttributeDefinition<Nullable<int>> TechTileAcquiredCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TechTileAcquiredCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TechTileAcquiredCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x00081A70 File Offset: 0x0007FC70
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x000048AA File Offset: 0x00002AAA
		public unsafe static AttributeDefinition<EntityID> OneStepAheadEntity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_OneStepAheadEntity, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_OneStepAheadEntity, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x00081A98 File Offset: 0x0007FC98
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x000048BC File Offset: 0x00002ABC
		public unsafe static AttributeDefinition<Nullable<int>> UndeployedTroops
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_UndeployedTroops, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_UndeployedTroops, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x00081AC0 File Offset: 0x0007FCC0
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x000048CE File Offset: 0x00002ACE
		public unsafe static AttributeDefinition<Nullable<bool>> RevealedStrengthApplied
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_RevealedStrengthApplied, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_RevealedStrengthApplied, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x00081AE8 File Offset: 0x0007FCE8
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x000048E0 File Offset: 0x00002AE0
		public unsafe static AttributeDefinition<Il2CppReferenceArray<ResourceMod>> ResourceMods
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ResourceMods, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Il2CppReferenceArray<ResourceMod>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ResourceMods, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x00081B10 File Offset: 0x0007FD10
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x000048F2 File Offset: 0x00002AF2
		public unsafe static AttributeDefinition<Nullable<bool>> HasDreadnought
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HasDreadnought, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HasDreadnought, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00081B38 File Offset: 0x0007FD38
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x00004904 File Offset: 0x00002B04
		public unsafe static AttributeDefinition<List<string>> TurnAchievements
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TurnAchievements, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TurnAchievements, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x00081B60 File Offset: 0x0007FD60
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x00004916 File Offset: 0x00002B16
		public unsafe static AttributeDefinition<Nullable<int>> EconomicSupremacyPoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_EconomicSupremacyPoints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_EconomicSupremacyPoints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00081B88 File Offset: 0x0007FD88
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00004928 File Offset: 0x00002B28
		public unsafe static AttributeDefinition<Nullable<bool>> NoConflictVPThisRound
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_NoConflictVPThisRound, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_NoConflictVPThisRound, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x00081BB0 File Offset: 0x0007FDB0
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x0000493A File Offset: 0x00002B3A
		public unsafe static AttributeDefinition<Nullable<int>> TurnSwordmasterAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TurnSwordmasterAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TurnSwordmasterAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x00081BD8 File Offset: 0x0007FDD8
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x0000494C File Offset: 0x00002B4C
		public unsafe static AttributeDefinition<Nullable<int>> TurnHighCouncilSeatAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TurnHighCouncilSeatAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TurnHighCouncilSeatAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00081C00 File Offset: 0x0007FE00
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x0000495E File Offset: 0x00002B5E
		public unsafe static AttributeDefinition<Nullable<int>> ConflictIntriguesPlayedThisTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ConflictIntriguesPlayedThisTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ConflictIntriguesPlayedThisTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00081C28 File Offset: 0x0007FE28
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00004970 File Offset: 0x00002B70
		public unsafe static AttributeDefinition<Nullable<int>> DesertAmbushUnitCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_DesertAmbushUnitCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_DesertAmbushUnitCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00081C50 File Offset: 0x0007FE50
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x00004982 File Offset: 0x00002B82
		public unsafe static AttributeDefinition<Nullable<int>> ExtraTurnsStacked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ExtraTurnsStacked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ExtraTurnsStacked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x00081C78 File Offset: 0x0007FE78
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x00004994 File Offset: 0x00002B94
		public unsafe static AttributeDefinition<Nullable<int>> SignetIcons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SignetIcons, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SignetIcons, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x00081CA0 File Offset: 0x0007FEA0
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x000049A6 File Offset: 0x00002BA6
		public unsafe static AttributeDefinition<Nullable<bool>> HasEndedTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HasEndedTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HasEndedTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x00081CC8 File Offset: 0x0007FEC8
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x000049B8 File Offset: 0x00002BB8
		public unsafe static AttributeDefinition<Nullable<bool>> FamilyAtomics
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_FamilyAtomics, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_FamilyAtomics, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00081CF0 File Offset: 0x0007FEF0
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x000049CA File Offset: 0x00002BCA
		public unsafe static AttributeDefinition<Nullable<int>> GeneticMarkers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_GeneticMarkers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_GeneticMarkers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00081D18 File Offset: 0x0007FF18
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x000049DC File Offset: 0x00002BDC
		public unsafe static AttributeDefinition<Nullable<int>> GainedSpiceThisTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_GainedSpiceThisTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_GainedSpiceThisTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00081D40 File Offset: 0x0007FF40
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x000049EE File Offset: 0x00002BEE
		public unsafe static AttributeDefinition<EntityID> UsurpGraftCard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_UsurpGraftCard, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_UsurpGraftCard, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x0600067D RID: 1661 RVA: 0x00081D68 File Offset: 0x0007FF68
		// (set) Token: 0x0600067E RID: 1662 RVA: 0x00004A00 File Offset: 0x00002C00
		public unsafe static AttributeDefinition<Nullable<int>> ReclaimedForcesCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ReclaimedForcesCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ReclaimedForcesCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x00081D90 File Offset: 0x0007FF90
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x00004A12 File Offset: 0x00002C12
		public unsafe static AttributeDefinition<Nullable<int>> GraftedCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_GraftedCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_GraftedCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x00081DB8 File Offset: 0x0007FFB8
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x00004A24 File Offset: 0x00002C24
		public unsafe static AttributeDefinition<Nullable<int>> TleilaxuAgentCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TleilaxuAgentCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TleilaxuAgentCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00081DE0 File Offset: 0x0007FFE0
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00004A36 File Offset: 0x00002C36
		public unsafe static AttributeDefinition<List<EntityID>> PlansRevealedEntityIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_PlansRevealedEntityIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_PlansRevealedEntityIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00081E08 File Offset: 0x00080008
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00004A48 File Offset: 0x00002C48
		public unsafe static AttributeDefinition<Nullable<int>> FamilyAtomicsCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_FamilyAtomicsCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_FamilyAtomicsCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00081E30 File Offset: 0x00080030
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00004A5A File Offset: 0x00002C5A
		public unsafe static AttributeDefinition<List<EntityID>> ChairdogReturnCards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ChairdogReturnCards, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ChairdogReturnCards, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00081E58 File Offset: 0x00080058
		// (set) Token: 0x0600068A RID: 1674 RVA: 0x00004A6C File Offset: 0x00002C6C
		public unsafe static AttributeDefinition<Nullable<int>> UngainedSpecimens
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_UngainedSpecimens, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_UngainedSpecimens, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600068B RID: 1675 RVA: 0x00081E80 File Offset: 0x00080080
		// (set) Token: 0x0600068C RID: 1676 RVA: 0x00004A7E File Offset: 0x00002C7E
		public unsafe static AttributeDefinition<Nullable<bool>> CannotDrawIntrigue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_CannotDrawIntrigue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_CannotDrawIntrigue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600068D RID: 1677 RVA: 0x00081EA8 File Offset: 0x000800A8
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00004A90 File Offset: 0x00002C90
		public unsafe static AttributeDefinition<Nullable<int>> ResearchCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ResearchCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ResearchCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x00081ED0 File Offset: 0x000800D0
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00004AA2 File Offset: 0x00002CA2
		public unsafe static AttributeDefinition<Nullable<int>> BeneTleilaxAcquired
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_BeneTleilaxAcquired, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_BeneTleilaxAcquired, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x00081EF8 File Offset: 0x000800F8
		// (set) Token: 0x06000692 RID: 1682 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public unsafe static AttributeDefinition<Nullable<int>> SpecimenSpent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SpecimenSpent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SpecimenSpent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000693 RID: 1683 RVA: 0x00081F20 File Offset: 0x00080120
		// (set) Token: 0x06000694 RID: 1684 RVA: 0x00004AC6 File Offset: 0x00002CC6
		public unsafe static AttributeDefinition<Nullable<int>> SpecimenSpentOnTleilaxCards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SpecimenSpentOnTleilaxCards, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SpecimenSpentOnTleilaxCards, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x00081F48 File Offset: 0x00080148
		// (set) Token: 0x06000696 RID: 1686 RVA: 0x00004AD8 File Offset: 0x00002CD8
		public unsafe static AttributeDefinition<Nullable<int>> TleilaxuInfluence
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TleilaxuInfluence, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TleilaxuInfluence, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x00081F70 File Offset: 0x00080170
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x00004AEA File Offset: 0x00002CEA
		public unsafe static AttributeDefinition<List<ArchetypeID>> TrashList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TrashList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TrashList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x00081F98 File Offset: 0x00080198
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x00004AFC File Offset: 0x00002CFC
		public unsafe static AttributeDefinition<Nullable<int>> TroopsDeployedThisConflict
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TroopsDeployedThisConflict, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TroopsDeployedThisConflict, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x00081FC0 File Offset: 0x000801C0
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x00004B0E File Offset: 0x00002D0E
		public unsafe static AttributeDefinition<List<EntityID>> PlayedAndMovedCleanup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_PlayedAndMovedCleanup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_PlayedAndMovedCleanup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x00081FE8 File Offset: 0x000801E8
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x00004B20 File Offset: 0x00002D20
		public unsafe static AttributeDefinition<Nullable<int>> TroopDeployNumber
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TroopDeployNumber, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TroopDeployNumber, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00082010 File Offset: 0x00080210
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00004B32 File Offset: 0x00002D32
		public unsafe static AttributeDefinition<Nullable<int>> DreadnoughtDeployNumber
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_DreadnoughtDeployNumber, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_DreadnoughtDeployNumber, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00082038 File Offset: 0x00080238
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00004B44 File Offset: 0x00002D44
		public unsafe static AttributeDefinition<Nullable<bool>> GraftedThisTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_GraftedThisTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_GraftedThisTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00082060 File Offset: 0x00080260
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00004B56 File Offset: 0x00002D56
		public unsafe static AttributeDefinition<Nullable<bool>> HighPriorityTravelDeploy
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HighPriorityTravelDeploy, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HighPriorityTravelDeploy, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00082088 File Offset: 0x00080288
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x00004B68 File Offset: 0x00002D68
		public unsafe static AttributeDefinition<Nullable<int>> GainedPersuasionThisTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_GainedPersuasionThisTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_GainedPersuasionThisTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x000820B0 File Offset: 0x000802B0
		// (set) Token: 0x060006A8 RID: 1704 RVA: 0x00004B7A File Offset: 0x00002D7A
		public unsafe static AttributeDefinition<Nullable<int>> DoubleAgentsAcquiredThisRound
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_DoubleAgentsAcquiredThisRound, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_DoubleAgentsAcquiredThisRound, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x000820D8 File Offset: 0x000802D8
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00004B8C File Offset: 0x00002D8C
		public unsafe static AttributeDefinition<LocalizableText> AgentText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AgentText, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AgentText, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x00082100 File Offset: 0x00080300
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x00004B9E File Offset: 0x00002D9E
		public unsafe static AttributeDefinition<LocalizableText> RevealText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_RevealText, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_RevealText, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x00082128 File Offset: 0x00080328
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x00004BB0 File Offset: 0x00002DB0
		public unsafe static AttributeDefinition<LocalizableText> AcquireText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AcquireText, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AcquireText, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x00082150 File Offset: 0x00080350
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public unsafe static AttributeDefinition<string> Image
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Image, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Image, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x00082178 File Offset: 0x00080378
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x00004BD4 File Offset: 0x00002DD4
		public unsafe static AttributeDefinition<List<AgentIcons>> IconList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_IconList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<AgentIcons>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_IconList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x000821A0 File Offset: 0x000803A0
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x00004BE6 File Offset: 0x00002DE6
		public unsafe static AttributeDefinition<List<Factions>> FactionList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_FactionList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<Factions>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_FactionList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x000821C8 File Offset: 0x000803C8
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x00004BF8 File Offset: 0x00002DF8
		public unsafe static AttributeDefinition<Nullable<int>> PersuasionCost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_PersuasionCost, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_PersuasionCost, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x000821F0 File Offset: 0x000803F0
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x00004C0A File Offset: 0x00002E0A
		public unsafe static AttributeDefinition<Nullable<int>> ConflictLevel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ConflictLevel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ConflictLevel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x00082218 File Offset: 0x00080418
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x00004C1C File Offset: 0x00002E1C
		public unsafe static AttributeDefinition<List<CardTags>> Tags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Tags, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<CardTags>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Tags, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x00082240 File Offset: 0x00080440
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00004C2E File Offset: 0x00002E2E
		public unsafe static AttributeDefinition<Nullable<ImperiumTypes>> ImperiumType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ImperiumType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<ImperiumTypes>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ImperiumType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00082268 File Offset: 0x00080468
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00004C40 File Offset: 0x00002E40
		public unsafe static AttributeDefinition<List<IntrigueTypes>> IntrigueTypeList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_IntrigueTypeList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<IntrigueTypes>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_IntrigueTypeList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x00082290 File Offset: 0x00080490
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00004C52 File Offset: 0x00002E52
		public unsafe static AttributeDefinition<Nullable<int>> AgentSpice
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AgentSpice, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AgentSpice, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x000822B8 File Offset: 0x000804B8
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00004C64 File Offset: 0x00002E64
		public unsafe static AttributeDefinition<Nullable<int>> AgentWater
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AgentWater, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AgentWater, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x000822E0 File Offset: 0x000804E0
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00004C76 File Offset: 0x00002E76
		public unsafe static AttributeDefinition<Nullable<int>> AgentSolari
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AgentSolari, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AgentSolari, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x00082308 File Offset: 0x00080508
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x00004C88 File Offset: 0x00002E88
		public unsafe static AttributeDefinition<Nullable<int>> HagalPlayerCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HagalPlayerCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HagalPlayerCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00082330 File Offset: 0x00080530
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x00004C9A File Offset: 0x00002E9A
		public unsafe static AttributeDefinition<Nullable<int>> AgentTroops
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AgentTroops, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AgentTroops, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x00082358 File Offset: 0x00080558
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00004CAC File Offset: 0x00002EAC
		public unsafe static AttributeDefinition<Nullable<int>> CardCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_CardCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_CardCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00082380 File Offset: 0x00080580
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x00004CBE File Offset: 0x00002EBE
		public unsafe static AttributeDefinition<Nullable<bool>> Permanent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Permanent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Permanent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x000823A8 File Offset: 0x000805A8
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00004CD0 File Offset: 0x00002ED0
		public unsafe static AttributeDefinition<Nullable<bool>> ShowHinting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ShowHinting, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ShowHinting, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x000823D0 File Offset: 0x000805D0
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00004CE2 File Offset: 0x00002EE2
		public unsafe static AttributeDefinition<List<AcquireEffects>> AcquireEffectList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AcquireEffectList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<AcquireEffects>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AcquireEffectList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x000823F8 File Offset: 0x000805F8
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00004CF4 File Offset: 0x00002EF4
		public unsafe static AttributeDefinition<ArchetypeID> PlayedSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_PlayedSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_PlayedSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00082420 File Offset: 0x00080620
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00004D06 File Offset: 0x00002F06
		public unsafe static AttributeDefinition<List<AgentIcons>> InfiltrationIconList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_InfiltrationIconList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<AgentIcons>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_InfiltrationIconList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00082448 File Offset: 0x00080648
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x00004D18 File Offset: 0x00002F18
		public unsafe static AttributeDefinition<Nullable<bool>> Flipped
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Flipped, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Flipped, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00082470 File Offset: 0x00080670
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x00004D2A File Offset: 0x00002F2A
		public unsafe static AttributeDefinition<Nullable<int>> Rating
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Rating, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Rating, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00082498 File Offset: 0x00080698
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x00004D3C File Offset: 0x00002F3C
		public unsafe static AttributeDefinition<Nullable<bool>> TriggeredTechTile
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TriggeredTechTile, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TriggeredTechTile, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x000824C0 File Offset: 0x000806C0
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x00004D4E File Offset: 0x00002F4E
		public unsafe static AttributeDefinition<Nullable<int>> AgentSpecimen
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AgentSpecimen, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AgentSpecimen, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x000824E8 File Offset: 0x000806E8
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00004D60 File Offset: 0x00002F60
		public unsafe static AttributeDefinition<Nullable<int>> SpecimenCost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SpecimenCost, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SpecimenCost, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x00082510 File Offset: 0x00080710
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00004D72 File Offset: 0x00002F72
		public unsafe static AttributeDefinition<EntityID> GraftedTo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_GraftedTo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_GraftedTo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x00082538 File Offset: 0x00080738
		// (set) Token: 0x060006E2 RID: 1762 RVA: 0x00004D84 File Offset: 0x00002F84
		public unsafe static AttributeDefinition<List<AgentIcons>> ConditionalIconList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ConditionalIconList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<AgentIcons>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ConditionalIconList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x00082560 File Offset: 0x00080760
		// (set) Token: 0x060006E4 RID: 1764 RVA: 0x00004D96 File Offset: 0x00002F96
		public unsafe static AttributeDefinition<Nullable<bool>> ConditionalIconsUsed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ConditionalIconsUsed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ConditionalIconsUsed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x00082588 File Offset: 0x00080788
		// (set) Token: 0x060006E6 RID: 1766 RVA: 0x00004DA8 File Offset: 0x00002FA8
		public unsafe static AttributeDefinition<Nullable<int>> PersuasionDiscountAmount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_PersuasionDiscountAmount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_PersuasionDiscountAmount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x000825B0 File Offset: 0x000807B0
		// (set) Token: 0x060006E8 RID: 1768 RVA: 0x00004DBA File Offset: 0x00002FBA
		public unsafe static AttributeDefinition<Dictionary<AccountID, int>> ConditionalEndgameVP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ConditionalEndgameVP, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<AccountID, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ConditionalEndgameVP, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x000825D8 File Offset: 0x000807D8
		// (set) Token: 0x060006EA RID: 1770 RVA: 0x00004DCC File Offset: 0x00002FCC
		public unsafe static AttributeDefinition<Nullable<bool>> Blocked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Blocked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Blocked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x00082600 File Offset: 0x00080800
		// (set) Token: 0x060006EC RID: 1772 RVA: 0x00004DDE File Offset: 0x00002FDE
		public unsafe static AttributeDefinition<Nullable<bool>> CombatSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_CombatSpace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_CombatSpace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060006ED RID: 1773 RVA: 0x00082628 File Offset: 0x00080828
		// (set) Token: 0x060006EE RID: 1774 RVA: 0x00004DF0 File Offset: 0x00002FF0
		public unsafe static AttributeDefinition<Nullable<AgentIcons>> AgentIcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AgentIcon, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<AgentIcons>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AgentIcon, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060006EF RID: 1775 RVA: 0x00082650 File Offset: 0x00080850
		// (set) Token: 0x060006F0 RID: 1776 RVA: 0x00004E02 File Offset: 0x00003002
		public unsafe static AttributeDefinition<AccountID> ControllingPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ControllingPlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<AccountID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ControllingPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x00082678 File Offset: 0x00080878
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00004E14 File Offset: 0x00003014
		public unsafe static AttributeDefinition<Nullable<int>> BonusSpice
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_BonusSpice, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_BonusSpice, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x000826A0 File Offset: 0x000808A0
		// (set) Token: 0x060006F4 RID: 1780 RVA: 0x00004E26 File Offset: 0x00003026
		public unsafe static AttributeDefinition<Nullable<int>> ControlSpice
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ControlSpice, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ControlSpice, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060006F5 RID: 1781 RVA: 0x000826C8 File Offset: 0x000808C8
		// (set) Token: 0x060006F6 RID: 1782 RVA: 0x00004E38 File Offset: 0x00003038
		public unsafe static AttributeDefinition<Nullable<int>> ControlWater
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ControlWater, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ControlWater, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060006F7 RID: 1783 RVA: 0x000826F0 File Offset: 0x000808F0
		// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00004E4A File Offset: 0x0000304A
		public unsafe static AttributeDefinition<Nullable<int>> ControlSolari
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ControlSolari, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ControlSolari, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00082718 File Offset: 0x00080918
		// (set) Token: 0x060006FA RID: 1786 RVA: 0x00004E5C File Offset: 0x0000305C
		public unsafe static AttributeDefinition<List<AccountID>> BlockExceptions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_BlockExceptions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<AccountID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_BlockExceptions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060006FB RID: 1787 RVA: 0x00082740 File Offset: 0x00080940
		// (set) Token: 0x060006FC RID: 1788 RVA: 0x00004E6E File Offset: 0x0000306E
		public unsafe static AttributeDefinition<Nullable<int>> SolariDiscount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SolariDiscount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SolariDiscount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x00082768 File Offset: 0x00080968
		// (set) Token: 0x060006FE RID: 1790 RVA: 0x00004E80 File Offset: 0x00003080
		public unsafe static AttributeDefinition<Nullable<int>> SpiceGainReduction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SpiceGainReduction, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SpiceGainReduction, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00082790 File Offset: 0x00080990
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x00004E92 File Offset: 0x00003092
		public unsafe static AttributeDefinition<Nullable<int>> SpiceDiscount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SpiceDiscount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SpiceDiscount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x000827B8 File Offset: 0x000809B8
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x00004EA4 File Offset: 0x000030A4
		public unsafe static AttributeDefinition<Nullable<int>> Index
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Index, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Index, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x000827E0 File Offset: 0x000809E0
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x00004EB6 File Offset: 0x000030B6
		public unsafe static AttributeDefinition<List<int>> NextIndices
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_NextIndices, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_NextIndices, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x00082808 File Offset: 0x00080A08
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x00004EC8 File Offset: 0x000030C8
		public unsafe static AttributeDefinition<Nullable<int>> LeaderComplexity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LeaderComplexity, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LeaderComplexity, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00082830 File Offset: 0x00080A30
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x00004EDA File Offset: 0x000030DA
		public unsafe static AttributeDefinition<Nullable<Houses>> LeaderHouse
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LeaderHouse, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<Houses>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LeaderHouse, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00082858 File Offset: 0x00080A58
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x00004EEC File Offset: 0x000030EC
		public unsafe static AttributeDefinition<List<Factions>> SnooperFactions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SnooperFactions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<Factions>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SnooperFactions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x00082880 File Offset: 0x00080A80
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x00004EFE File Offset: 0x000030FE
		public unsafe static AttributeDefinition<Nullable<bool>> HagalLeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HagalLeader, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HagalLeader, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x000828A8 File Offset: 0x00080AA8
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x00004F10 File Offset: 0x00003110
		public unsafe static AttributeDefinition<List<Factions>> SnooperFactionsUsed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SnooperFactionsUsed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<Factions>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SnooperFactionsUsed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x000828D0 File Offset: 0x00080AD0
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x00004F22 File Offset: 0x00003122
		public unsafe static AttributeDefinition<AccountID> WormCurrentTurnPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_WormCurrentTurnPlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<AccountID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_WormCurrentTurnPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x000828F8 File Offset: 0x00080AF8
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x00004F34 File Offset: 0x00003134
		public unsafe static AttributeDefinition<Nullable<RoundState>> RoundPhase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_RoundPhase, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<RoundState>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_RoundPhase, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00082920 File Offset: 0x00080B20
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x00004F46 File Offset: 0x00003146
		public unsafe static AttributeDefinition<Nullable<bool>> Exhausted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_Exhausted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_Exhausted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x00082948 File Offset: 0x00080B48
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x00004F58 File Offset: 0x00003158
		public unsafe static AttributeDefinition<Nullable<AbilityTiming>> AbilityTiming
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AbilityTiming, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<AbilityTiming>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AbilityTiming, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00082970 File Offset: 0x00080B70
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x00004F6A File Offset: 0x0000316A
		public unsafe static AttributeDefinition<Nullable<double>> TrashValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_TrashValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<double>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_TrashValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000719 RID: 1817 RVA: 0x00082998 File Offset: 0x00080B98
		// (set) Token: 0x0600071A RID: 1818 RVA: 0x00004F7C File Offset: 0x0000317C
		public unsafe static AttributeDefinition<Nullable<double>> AcquireValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_AcquireValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<double>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_AcquireValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x000829C0 File Offset: 0x00080BC0
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x00004F8E File Offset: 0x0000318E
		public unsafe static AttributeDefinition<Nullable<double>> EarlyMod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_EarlyMod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<double>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_EarlyMod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x000829E8 File Offset: 0x00080BE8
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x00004FA0 File Offset: 0x000031A0
		public unsafe static AttributeDefinition<Nullable<double>> LateMod
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LateMod, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<double>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LateMod, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00082A10 File Offset: 0x00080C10
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x00004FB2 File Offset: 0x000031B2
		public unsafe static AttributeDefinition<Nullable<int>> DeferValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_DeferValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_DeferValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x00082A38 File Offset: 0x00080C38
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x00004FC4 File Offset: 0x000031C4
		public unsafe static AttributeDefinition<Nullable<HagalModes>> HagalMode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HagalMode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<HagalModes>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HagalMode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x00082A60 File Offset: 0x00080C60
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x00004FD6 File Offset: 0x000031D6
		public unsafe static AttributeDefinition<Nullable<HagalDifficultyLevels>> HagalDifficulty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HagalDifficulty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<HagalDifficultyLevels>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HagalDifficulty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00082A88 File Offset: 0x00080C88
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x00004FE8 File Offset: 0x000031E8
		public unsafe static AttributeDefinition<Nullable<int>> HagalSwordmasterRound
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HagalSwordmasterRound, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HagalSwordmasterRound, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00082AB0 File Offset: 0x00080CB0
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00004FFA File Offset: 0x000031FA
		public unsafe static AttributeDefinition<List<ArchetypeID>> HagalDeckList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HagalDeckList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HagalDeckList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00082AD8 File Offset: 0x00080CD8
		// (set) Token: 0x0600072A RID: 1834 RVA: 0x0000500C File Offset: 0x0000320C
		public unsafe static AttributeDefinition<Nullable<bool>> HagalClaimedConflictBonus
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HagalClaimedConflictBonus, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HagalClaimedConflictBonus, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00082B00 File Offset: 0x00080D00
		// (set) Token: 0x0600072C RID: 1836 RVA: 0x0000501E File Offset: 0x0000321E
		public unsafe static AttributeDefinition<Nullable<double>> CombatValue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_CombatValue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<double>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_CombatValue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00082B28 File Offset: 0x00080D28
		// (set) Token: 0x0600072E RID: 1838 RVA: 0x00005030 File Offset: 0x00003230
		public unsafe static AttributeDefinition<Nullable<bool>> HagalChurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HagalChurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HagalChurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x00082B50 File Offset: 0x00080D50
		// (set) Token: 0x06000730 RID: 1840 RVA: 0x00005042 File Offset: 0x00003242
		public unsafe static AttributeDefinition<Nullable<bool>> HagalBrutalEscalation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HagalBrutalEscalation, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HagalBrutalEscalation, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000731 RID: 1841 RVA: 0x00082B78 File Offset: 0x00080D78
		// (set) Token: 0x06000732 RID: 1842 RVA: 0x00005054 File Offset: 0x00003254
		public unsafe static AttributeDefinition<Nullable<int>> MinToSelect
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_MinToSelect, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_MinToSelect, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00082BA0 File Offset: 0x00080DA0
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x00005066 File Offset: 0x00003266
		public unsafe static AttributeDefinition<Nullable<int>> MaxToSelect
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_MaxToSelect, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_MaxToSelect, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00082BC8 File Offset: 0x00080DC8
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x00005078 File Offset: 0x00003278
		public unsafe static AttributeDefinition<Nullable<int>> InfluenceDelta
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_InfluenceDelta, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_InfluenceDelta, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00082BF0 File Offset: 0x00080DF0
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x0000508A File Offset: 0x0000328A
		public unsafe static AttributeDefinition<Nullable<bool>> WillClearUndo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_WillClearUndo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_WillClearUndo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00082C18 File Offset: 0x00080E18
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x0000509C File Offset: 0x0000329C
		public unsafe static AttributeDefinition<string> UndoSequenceName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_UndoSequenceName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_UndoSequenceName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00082C40 File Offset: 0x00080E40
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x000050AE File Offset: 0x000032AE
		public unsafe static AttributeDefinition<MutableAttributes> SequenceAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SequenceAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<MutableAttributes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SequenceAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600073D RID: 1853 RVA: 0x00082C68 File Offset: 0x00080E68
		// (set) Token: 0x0600073E RID: 1854 RVA: 0x000050C0 File Offset: 0x000032C0
		public unsafe static AttributeDefinition<List<EntityID>> UnusableAbilities
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_UnusableAbilities, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_UnusableAbilities, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600073F RID: 1855 RVA: 0x00082C90 File Offset: 0x00080E90
		// (set) Token: 0x06000740 RID: 1856 RVA: 0x000050D2 File Offset: 0x000032D2
		public unsafe static AttributeDefinition<SequenceID> UndoSequenceID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_UndoSequenceID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<SequenceID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_UndoSequenceID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x00082CB8 File Offset: 0x00080EB8
		// (set) Token: 0x06000742 RID: 1858 RVA: 0x000050E4 File Offset: 0x000032E4
		public unsafe static AttributeDefinition<Nullable<bool>> UndoSequenceWrap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_UndoSequenceWrap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_UndoSequenceWrap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x00082CE0 File Offset: 0x00080EE0
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x000050F6 File Offset: 0x000032F6
		public unsafe static AttributeDefinition<Nullable<bool>> DeferredAbility
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_DeferredAbility, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_DeferredAbility, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x00082D08 File Offset: 0x00080F08
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00005108 File Offset: 0x00003308
		public unsafe static AttributeDefinition<Nullable<int>> ConflictPlace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ConflictPlace, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ConflictPlace, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x00082D30 File Offset: 0x00080F30
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x0000511A File Offset: 0x0000331A
		public unsafe static AttributeDefinition<Nullable<int>> SpaceNumber
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SpaceNumber, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SpaceNumber, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x00082D58 File Offset: 0x00080F58
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x0000512C File Offset: 0x0000332C
		public unsafe static AttributeDefinition<Nullable<bool>> BackgroundAbility
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_BackgroundAbility, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_BackgroundAbility, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00082D80 File Offset: 0x00080F80
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x0000513E File Offset: 0x0000333E
		public unsafe static AttributeDefinition<Nullable<int>> SkipNextExhaust
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SkipNextExhaust, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SkipNextExhaust, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x00082DA8 File Offset: 0x00080FA8
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00005150 File Offset: 0x00003350
		public unsafe static AttributeDefinition<Nullable<bool>> HideInvalidDeferred
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_HideInvalidDeferred, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_HideInvalidDeferred, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00082DD0 File Offset: 0x00080FD0
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00005162 File Offset: 0x00003362
		public unsafe static AttributeDefinition<Nullable<bool>> NoCancelButton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_NoCancelButton, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_NoCancelButton, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00082DF8 File Offset: 0x00080FF8
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00005174 File Offset: 0x00003374
		public unsafe static AttributeDefinition<ArchetypeID> SourceArchetype
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_SourceArchetype, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_SourceArchetype, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00082E20 File Offset: 0x00081020
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00005186 File Offset: 0x00003386
		public unsafe static AttributeDefinition<Nullable<bool>> ResearchAssignmentEarmarked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ResearchAssignmentEarmarked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ResearchAssignmentEarmarked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00082E48 File Offset: 0x00081048
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00005198 File Offset: 0x00003398
		public unsafe static AttributeDefinition<List<ArchetypeID>> ShowOfStrengthCardDrawable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ShowOfStrengthCardDrawable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ShowOfStrengthCardDrawable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00082E70 File Offset: 0x00081070
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x000051AA File Offset: 0x000033AA
		public unsafe static AttributeDefinition<EntityID> ResearchAssignmentEntityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ResearchAssignmentEntityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ResearchAssignmentEntityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00082E98 File Offset: 0x00081098
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x000051BC File Offset: 0x000033BC
		public unsafe static AttributeDefinition<Nullable<LogTemplates>> LogTemplate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LogTemplate, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<LogTemplates>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LogTemplate, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00082EC0 File Offset: 0x000810C0
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x000051CE File Offset: 0x000033CE
		public unsafe static AttributeDefinition<ArchetypeID> LeaderArchetype
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_LeaderArchetype, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_LeaderArchetype, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00082EE8 File Offset: 0x000810E8
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x000051E0 File Offset: 0x000033E0
		public unsafe static AttributeDefinition<ArchetypeID> ChosenArchetype
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormAttributes.NativeFieldInfoPtr_ChosenArchetype, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormAttributes.NativeFieldInfoPtr_ChosenArchetype, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeFieldInfoPtr_VictoryPoints;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeFieldInfoPtr_Winner;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_Spice;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_Water;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeFieldInfoPtr_Solari;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeFieldInfoPtr_Troops;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_Persuasion;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_Strength;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_Faction;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_SpiceCost;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_WaterCost;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_SolariCost;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_WormAbilityIDs;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_SetList;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_ChosenEntity;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_PlayerRewards;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeFieldInfoPtr_EntityType;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeFieldInfoPtr_ConflictParticipants;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_RoundNumber;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr_SecondConflictDeck;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeFieldInfoPtr_SkipRecallThisRound;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeFieldInfoPtr_ConflictRewards;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeFieldInfoPtr_WormSkirmishScoringMethods;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeFieldInfoPtr_SpiceMustFlowBaseCost;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeFieldInfoPtr_WarningText;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr_HiddenElements;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_RevealOrder;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr_Conflict2Count;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr_Conflict3Count;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeFieldInfoPtr_LastRoundTriggered;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeFieldInfoPtr_EndgameTriggerScore;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeFieldInfoPtr_AllowDisplayClearOnSave;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeFieldInfoPtr_WormSkirmishRuleMods;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeFieldInfoPtr_LeaderAssignmentMode;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeFieldInfoPtr_LeaderSelectionPlayer;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeFieldInfoPtr_EndgameStarted;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeFieldInfoPtr_EnabledSets;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeFieldInfoPtr_NewDreadnoughtSpace;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr_ConflictPassedPlayers;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr_Dreadnought;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr_LastConflictIntriguePlayer;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeFieldInfoPtr_EpicGameMode;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeFieldInfoPtr_DeadlyAllianceAwarded;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_TutorialStep;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_HoldFirstPlayer;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_ShowSequenceToAll;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeFieldInfoPtr_HasMigratedReserveRow;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeFieldInfoPtr_HasMigratedReserveRowTwice;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr_Specimen;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr_GoTo11Mode;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_TechNegotiator;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_IntrigueCard;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr_ImperiumCard;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_UndoIsCancel;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_TurnPhase;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr_FactionInfluence;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr_Color;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr_FirstPlayer;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr_PlayerTurn;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr_HighCouncilSeat;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr_PassTurn;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr_CanAcquireToDeck;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr_Infiltrate;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr_EnvoyDispatched;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeFieldInfoPtr_AdditionalSpaceInfluence;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeFieldInfoPtr_BaronHarkonnenSecretFactions;

		// Token: 0x0400040B RID: 1035
		private static readonly IntPtr NativeFieldInfoPtr_Swordmaster;

		// Token: 0x0400040C RID: 1036
		private static readonly IntPtr NativeFieldInfoPtr_UnitsGainedThisTurn;

		// Token: 0x0400040D RID: 1037
		private static readonly IntPtr NativeFieldInfoPtr_DeckList;

		// Token: 0x0400040E RID: 1038
		private static readonly IntPtr NativeFieldInfoPtr_HasRevealed;

		// Token: 0x0400040F RID: 1039
		private static readonly IntPtr NativeFieldInfoPtr_PossibleStrength;

		// Token: 0x04000410 RID: 1040
		private static readonly IntPtr NativeFieldInfoPtr_TurnOfRound;

		// Token: 0x04000411 RID: 1041
		private static readonly IntPtr NativeFieldInfoPtr_ShuffleCount;

		// Token: 0x04000412 RID: 1042
		private static readonly IntPtr NativeFieldInfoPtr_CustomDeferralThreshold;

		// Token: 0x04000413 RID: 1043
		private static readonly IntPtr NativeFieldInfoPtr_VisitedSpaces;

		// Token: 0x04000414 RID: 1044
		private static readonly IntPtr NativeFieldInfoPtr_TutorialAllianceTokenStarted;

		// Token: 0x04000415 RID: 1045
		private static readonly IntPtr NativeFieldInfoPtr_TrashedCardCount;

		// Token: 0x04000416 RID: 1046
		private static readonly IntPtr NativeFieldInfoPtr_EmperorAcquired;

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr_FremenAcquired;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr_SpacingGuildAcquired;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeFieldInfoPtr_BeneGesseritAcquired;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeFieldInfoPtr_SpiceMustFlowAcquired;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeFieldInfoPtr_MentatUsedCount;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeFieldInfoPtr_CombatFirstCount;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeFieldInfoPtr_IntriguePlayedCount;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeFieldInfoPtr_WaterSpent;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeFieldInfoPtr_CombatHighestSwords;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeFieldInfoPtr_CombatFirstFewerUnitsCount;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr_ExtraDrawCount;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeFieldInfoPtr_ExpensiveAcquired;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeFieldInfoPtr_CheapAcquired;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeFieldInfoPtr_WithAbilityAcquired;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_FremenBondCount;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeFieldInfoPtr_TroopsRetreatedCount;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeFieldInfoPtr_TurnCardsAcquired;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeFieldInfoPtr_ConflictFirstPlace;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeFieldInfoPtr_BaseDeployableUnits;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeFieldInfoPtr_RevealPreview;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeFieldInfoPtr_StartingPlayerOrder;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeFieldInfoPtr_EndlessAssaultCount;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeFieldInfoPtr_InfluenceRank;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeFieldInfoPtr_ControlMarkers;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeFieldInfoPtr_EarlyPersuasion;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeFieldInfoPtr_DesertPowerSwords;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeFieldInfoPtr_VPSources;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeFieldInfoPtr_Reshuffle1DeckOrder;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeFieldInfoPtr_Reshuffle2DeckOrder;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeFieldInfoPtr_Reshuffle3DeckOrder;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeFieldInfoPtr_IsHagalPlayer;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeFieldInfoPtr_FactionsBlocked;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeFieldInfoPtr_PrescienceTopCard;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeFieldInfoPtr_DarkSpaces;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeFieldInfoPtr_AllianceTokenVP;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeFieldInfoPtr_TutorialHighCouncilStarted;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeFieldInfoPtr_InitialLeaderOptions;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeFieldInfoPtr_AcquiredListThisTurn;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeFieldInfoPtr_AcquiredEntitiesThisTurn;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeFieldInfoPtr_LeaderDrawAbility;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeFieldInfoPtr_RevealStrength;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr_CustomAbilityIDs;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeFieldInfoPtr_MentatControllerThisRound;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeFieldInfoPtr_DiscardedList;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeFieldInfoPtr_LietKynesPersuasion;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeFieldInfoPtr_RevealCardsProvidingStrength;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeFieldInfoPtr_ShippingTroopsGainedThisTurn;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeFieldInfoPtr_TiebreakerScore;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeFieldInfoPtr_EndgamePlayableList;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeFieldInfoPtr_SignetSwapAbilityID;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeFieldInfoPtr_CanAcquireFromImperiumRow;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr_TroopsDeployedThisTurn;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeFieldInfoPtr_ExtraTurn;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeFieldInfoPtr_OneStepAheadCard;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr_LastShippingRecallSpace;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeFieldInfoPtr_TechTileActionCount;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeFieldInfoPtr_DreadnoughtCombatCount;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeFieldInfoPtr_OperativeCount;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeFieldInfoPtr_UnloadCount;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeFieldInfoPtr_ShippingFromTopCount;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeFieldInfoPtr_ShippingCount;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeFieldInfoPtr_IxianSupremacyCount;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeFieldInfoPtr_SpaceControlCount;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeFieldInfoPtr_LastCardAcquired;

		// Token: 0x04000457 RID: 1111
		private static readonly IntPtr NativeFieldInfoPtr_FinalDeliveryCount;

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeFieldInfoPtr_TheWeirdingWayTurnCount;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeFieldInfoPtr_InfiltrateThisRoundCount;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeFieldInfoPtr_OneStepAheadConsecutiveCount;

		// Token: 0x0400045B RID: 1115
		private static readonly IntPtr NativeFieldInfoPtr_OneStepAheadThisRound;

		// Token: 0x0400045C RID: 1116
		private static readonly IntPtr NativeFieldInfoPtr_RevealedThisRoundCount;

		// Token: 0x0400045D RID: 1117
		private static readonly IntPtr NativeFieldInfoPtr_SpacingGuildPlayed;

		// Token: 0x0400045E RID: 1118
		private static readonly IntPtr NativeFieldInfoPtr_UnaddedTechNegotiators;

		// Token: 0x0400045F RID: 1119
		private static readonly IntPtr NativeFieldInfoPtr_UngainedTroops;

		// Token: 0x04000460 RID: 1120
		private static readonly IntPtr NativeFieldInfoPtr_TechTileAcquiredCount;

		// Token: 0x04000461 RID: 1121
		private static readonly IntPtr NativeFieldInfoPtr_OneStepAheadEntity;

		// Token: 0x04000462 RID: 1122
		private static readonly IntPtr NativeFieldInfoPtr_UndeployedTroops;

		// Token: 0x04000463 RID: 1123
		private static readonly IntPtr NativeFieldInfoPtr_RevealedStrengthApplied;

		// Token: 0x04000464 RID: 1124
		private static readonly IntPtr NativeFieldInfoPtr_ResourceMods;

		// Token: 0x04000465 RID: 1125
		private static readonly IntPtr NativeFieldInfoPtr_HasDreadnought;

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeFieldInfoPtr_TurnAchievements;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_EconomicSupremacyPoints;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr_NoConflictVPThisRound;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr_TurnSwordmasterAcquired;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeFieldInfoPtr_TurnHighCouncilSeatAcquired;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeFieldInfoPtr_ConflictIntriguesPlayedThisTurn;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeFieldInfoPtr_DesertAmbushUnitCount;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeFieldInfoPtr_ExtraTurnsStacked;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeFieldInfoPtr_SignetIcons;

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr_HasEndedTurn;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_FamilyAtomics;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_GeneticMarkers;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr_GainedSpiceThisTurn;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr_UsurpGraftCard;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr_ReclaimedForcesCount;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeFieldInfoPtr_GraftedCount;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuAgentCount;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeFieldInfoPtr_PlansRevealedEntityIDs;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeFieldInfoPtr_FamilyAtomicsCount;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeFieldInfoPtr_ChairdogReturnCards;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeFieldInfoPtr_UngainedSpecimens;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeFieldInfoPtr_CannotDrawIntrigue;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeFieldInfoPtr_ResearchCount;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeFieldInfoPtr_BeneTleilaxAcquired;

		// Token: 0x0400047E RID: 1150
		private static readonly IntPtr NativeFieldInfoPtr_SpecimenSpent;

		// Token: 0x0400047F RID: 1151
		private static readonly IntPtr NativeFieldInfoPtr_SpecimenSpentOnTleilaxCards;

		// Token: 0x04000480 RID: 1152
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuInfluence;

		// Token: 0x04000481 RID: 1153
		private static readonly IntPtr NativeFieldInfoPtr_TrashList;

		// Token: 0x04000482 RID: 1154
		private static readonly IntPtr NativeFieldInfoPtr_TroopsDeployedThisConflict;

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeFieldInfoPtr_PlayedAndMovedCleanup;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr_TroopDeployNumber;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeFieldInfoPtr_DreadnoughtDeployNumber;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeFieldInfoPtr_GraftedThisTurn;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeFieldInfoPtr_HighPriorityTravelDeploy;

		// Token: 0x04000488 RID: 1160
		private static readonly IntPtr NativeFieldInfoPtr_GainedPersuasionThisTurn;

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeFieldInfoPtr_DoubleAgentsAcquiredThisRound;

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeFieldInfoPtr_AgentText;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeFieldInfoPtr_RevealText;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeFieldInfoPtr_AcquireText;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeFieldInfoPtr_Image;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeFieldInfoPtr_IconList;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeFieldInfoPtr_FactionList;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeFieldInfoPtr_PersuasionCost;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeFieldInfoPtr_ConflictLevel;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeFieldInfoPtr_Tags;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeFieldInfoPtr_ImperiumType;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeFieldInfoPtr_IntrigueTypeList;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeFieldInfoPtr_AgentSpice;

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeFieldInfoPtr_AgentWater;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr_AgentSolari;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeFieldInfoPtr_HagalPlayerCount;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeFieldInfoPtr_AgentTroops;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeFieldInfoPtr_CardCount;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeFieldInfoPtr_Permanent;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeFieldInfoPtr_ShowHinting;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeFieldInfoPtr_AcquireEffectList;

		// Token: 0x0400049E RID: 1182
		private static readonly IntPtr NativeFieldInfoPtr_PlayedSpace;

		// Token: 0x0400049F RID: 1183
		private static readonly IntPtr NativeFieldInfoPtr_InfiltrationIconList;

		// Token: 0x040004A0 RID: 1184
		private static readonly IntPtr NativeFieldInfoPtr_Flipped;

		// Token: 0x040004A1 RID: 1185
		private static readonly IntPtr NativeFieldInfoPtr_Rating;

		// Token: 0x040004A2 RID: 1186
		private static readonly IntPtr NativeFieldInfoPtr_TriggeredTechTile;

		// Token: 0x040004A3 RID: 1187
		private static readonly IntPtr NativeFieldInfoPtr_AgentSpecimen;

		// Token: 0x040004A4 RID: 1188
		private static readonly IntPtr NativeFieldInfoPtr_SpecimenCost;

		// Token: 0x040004A5 RID: 1189
		private static readonly IntPtr NativeFieldInfoPtr_GraftedTo;

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeFieldInfoPtr_ConditionalIconList;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr_ConditionalIconsUsed;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeFieldInfoPtr_PersuasionDiscountAmount;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeFieldInfoPtr_ConditionalEndgameVP;

		// Token: 0x040004AA RID: 1194
		private static readonly IntPtr NativeFieldInfoPtr_Blocked;

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeFieldInfoPtr_CombatSpace;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeFieldInfoPtr_AgentIcon;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeFieldInfoPtr_ControllingPlayer;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeFieldInfoPtr_BonusSpice;

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeFieldInfoPtr_ControlSpice;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeFieldInfoPtr_ControlWater;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeFieldInfoPtr_ControlSolari;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeFieldInfoPtr_BlockExceptions;

		// Token: 0x040004B3 RID: 1203
		private static readonly IntPtr NativeFieldInfoPtr_SolariDiscount;

		// Token: 0x040004B4 RID: 1204
		private static readonly IntPtr NativeFieldInfoPtr_SpiceGainReduction;

		// Token: 0x040004B5 RID: 1205
		private static readonly IntPtr NativeFieldInfoPtr_SpiceDiscount;

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeFieldInfoPtr_Index;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeFieldInfoPtr_NextIndices;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeFieldInfoPtr_LeaderComplexity;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr_LeaderHouse;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeFieldInfoPtr_SnooperFactions;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeFieldInfoPtr_HagalLeader;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeFieldInfoPtr_SnooperFactionsUsed;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeFieldInfoPtr_WormCurrentTurnPlayer;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr_RoundPhase;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_Exhausted;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr_AbilityTiming;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_TrashValue;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_AcquireValue;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_EarlyMod;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr_LateMod;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_DeferValue;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_HagalMode;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_HagalDifficulty;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeFieldInfoPtr_HagalSwordmasterRound;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeFieldInfoPtr_HagalDeckList;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeFieldInfoPtr_HagalClaimedConflictBonus;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeFieldInfoPtr_CombatValue;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr_HagalChurn;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_HagalBrutalEscalation;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_MinToSelect;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr_MaxToSelect;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeFieldInfoPtr_InfluenceDelta;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeFieldInfoPtr_WillClearUndo;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeFieldInfoPtr_UndoSequenceName;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeFieldInfoPtr_SequenceAttributes;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeFieldInfoPtr_UnusableAbilities;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr_UndoSequenceID;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr_UndoSequenceWrap;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr_DeferredAbility;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_ConflictPlace;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeFieldInfoPtr_SpaceNumber;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeFieldInfoPtr_BackgroundAbility;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeFieldInfoPtr_SkipNextExhaust;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeFieldInfoPtr_HideInvalidDeferred;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr_NoCancelButton;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeFieldInfoPtr_SourceArchetype;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeFieldInfoPtr_ResearchAssignmentEarmarked;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeFieldInfoPtr_ShowOfStrengthCardDrawable;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeFieldInfoPtr_ResearchAssignmentEntityID;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeFieldInfoPtr_LogTemplate;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeFieldInfoPtr_LeaderArchetype;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeFieldInfoPtr_ChosenArchetype;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;
	}
}
