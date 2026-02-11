using System;
using Canis.utils.ids;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace worm.canis.data.Tutorial
{
	// Token: 0x02000046 RID: 70
	public static class WormTutorialConstants : Object
	{
		// Token: 0x060007FE RID: 2046 RVA: 0x000842C4 File Offset: 0x000824C4
		// Note: this type is marked as 'beforefieldinit'.
		static WormTutorialConstants()
		{
			Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.data.Tutorial", "WormTutorialConstants");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr);
			WormTutorialConstants.NativeFieldInfoPtr_IntroMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "IntroMessage");
			WormTutorialConstants.NativeFieldInfoPtr_TutorialFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "TutorialFinished");
			WormTutorialConstants.NativeFieldInfoPtr_ButtonOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ButtonOnly");
			WormTutorialConstants.NativeFieldInfoPtr_WithLeader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "WithLeader");
			WormTutorialConstants.NativeFieldInfoPtr_Duncan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "Duncan");
			WormTutorialConstants.NativeFieldInfoPtr_Gurney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "Gurney");
			WormTutorialConstants.NativeFieldInfoPtr_Leto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "Leto");
			WormTutorialConstants.NativeFieldInfoPtr_Paul = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "Paul");
			WormTutorialConstants.NativeFieldInfoPtr_Rabban = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "Rabban");
			WormTutorialConstants.NativeFieldInfoPtr_Thorvald = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "Thorvald");
			WormTutorialConstants.NativeFieldInfoPtr_Thufir = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "Thufir");
			WormTutorialConstants.NativeFieldInfoPtr_Stilgar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "Stilgar");
			WormTutorialConstants.NativeFieldInfoPtr_Armand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "Armand");
			WormTutorialConstants.NativeFieldInfoPtr_Ilban = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "Ilban");
			WormTutorialConstants.NativeFieldInfoPtr_DisableConflictPlusButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DisableConflictPlusButton");
			WormTutorialConstants.NativeFieldInfoPtr_EnableConflictPlusButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "EnableConflictPlusButton");
			WormTutorialConstants.NativeFieldInfoPtr_DisableConflictMinusButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DisableConflictMinusButton");
			WormTutorialConstants.NativeFieldInfoPtr_EnableConflictMinusButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "EnableConflictMinusButton");
			WormTutorialConstants.NativeFieldInfoPtr_ForceOpenRevealImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ForceOpenRevealImperiumRow");
			WormTutorialConstants.NativeFieldInfoPtr_CloseImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "CloseImperiumRow");
			WormTutorialConstants.NativeFieldInfoPtr_HideCardHinting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HideCardHinting");
			WormTutorialConstants.NativeFieldInfoPtr_ShowCardHinting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ShowCardHinting");
			WormTutorialConstants.NativeFieldInfoPtr_GamepadSelect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "GamepadSelect");
			WormTutorialConstants.NativeFieldInfoPtr_DisableDeferredAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DisableDeferredAbilities");
			WormTutorialConstants.NativeFieldInfoPtr_EnableDeferredAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "EnableDeferredAbilities");
			WormTutorialConstants.NativeFieldInfoPtr_MinimizeTechRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "MinimizeTechRow");
			WormTutorialConstants.NativeFieldInfoPtr_MinimizeTechTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "MinimizeTechTray");
			WormTutorialConstants.NativeFieldInfoPtr_ForceOpenResearchTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ForceOpenResearchTrack");
			WormTutorialConstants.NativeFieldInfoPtr_CloseResearchTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "CloseResearchTrack");
			WormTutorialConstants.NativeFieldInfoPtr_OpenTleilaxuTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "OpenTleilaxuTrack");
			WormTutorialConstants.NativeFieldInfoPtr_CloseTleilaxuTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "CloseTleilaxuTrack");
			WormTutorialConstants.NativeFieldInfoPtr_OpenImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "OpenImperiumRow");
			WormTutorialConstants.NativeFieldInfoPtr_CardMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "CardMoz");
			WormTutorialConstants.NativeFieldInfoPtr_Doinker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "Doinker");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerBottom");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerDrag");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerDragIntrigue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerDragIntrigue");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerDragLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerDragLeft");
			WormTutorialConstants.NativeFieldInfoPtr_BottomAligned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "BottomAligned");
			WormTutorialConstants.NativeFieldInfoPtr_CenterAligned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "CenterAligned");
			WormTutorialConstants.NativeFieldInfoPtr_RightAligned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "RightAligned");
			WormTutorialConstants.NativeFieldInfoPtr_LeftAligned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "LeftAligned");
			WormTutorialConstants.NativeFieldInfoPtr_DuneTheDesertPlanetMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DuneTheDesertPlanetMoz");
			WormTutorialConstants.NativeFieldInfoPtr_ReconnaissanceMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ReconnaissanceMoz");
			WormTutorialConstants.NativeFieldInfoPtr_SkirmishMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SkirmishMoz");
			WormTutorialConstants.NativeFieldInfoPtr_SignetRingMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SignetRingMoz");
			WormTutorialConstants.NativeFieldInfoPtr_GurneyMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "GurneyMoz");
			WormTutorialConstants.NativeFieldInfoPtr_RecruitmentMissionMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "RecruitmentMissionMoz");
			WormTutorialConstants.NativeFieldInfoPtr_PrivateArmyMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PrivateArmyMoz");
			WormTutorialConstants.NativeFieldInfoPtr_DisplayLocationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DisplayLocationName");
			WormTutorialConstants.NativeFieldInfoPtr_HideLocationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HideLocationName");
			WormTutorialConstants.NativeFieldInfoPtr_ArrowWithLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ArrowWithLabel");
			WormTutorialConstants.NativeFieldInfoPtr_CombatSpaceIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "CombatSpaceIcon");
			WormTutorialConstants.NativeFieldInfoPtr_CombatSpaceIconMulti = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "CombatSpaceIconMulti");
			WormTutorialConstants.NativeFieldInfoPtr_FactionArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FactionArea");
			WormTutorialConstants.NativeFieldInfoPtr_FremenTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FremenTrack");
			WormTutorialConstants.NativeFieldInfoPtr_FremenButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FremenButton");
			WormTutorialConstants.NativeFieldInfoPtr_RecruitmentMissionSecondOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "RecruitmentMissionSecondOption");
			WormTutorialConstants.NativeFieldInfoPtr_PromptContinueButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PromptContinueButton");
			WormTutorialConstants.NativeFieldInfoPtr_AgentTurnAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "AgentTurnAbilities");
			WormTutorialConstants.NativeFieldInfoPtr_RevealTurnAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "RevealTurnAbilities");
			WormTutorialConstants.NativeFieldInfoPtr_ConflictPlusButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ConflictPlusButton");
			WormTutorialConstants.NativeFieldInfoPtr_ConflictCurrentStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ConflictCurrentStrength");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAcquire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxAcquire");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAgents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxAgents");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAgentIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxAgentIcons");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxArrakeenDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxArrakeenDraw");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxArrakeenTroop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxArrakeenTroop");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxCHOAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxCHOAM");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxConflictArea");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictAreaPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxConflictAreaPlayer");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictCurrentStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxConflictCurrentStrength");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxConflictRewards");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictResultsReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxConflictResultsReward");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxControlIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxControlIcon");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDeck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxDeck");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDeckAndDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxDeckAndDiscard");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDiscard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxDiscard");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFirstPlayerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxFirstPlayerMarker");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxHand");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxHUDResources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxHUDResources");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxImperiumRow");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxOpponentInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxOpponentInfo");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxPlayed");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxPersuasion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxPersuasion");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxPersuasionCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxPersuasionCost");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSmallImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxSmallImperiumRow");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpaceCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxSpaceCost");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpaceAgent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxSpaceAgent");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxResourceIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxResourceIcons");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxRevealBoxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxRevealBoxes");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDaggerRevealBoxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxDaggerRevealBoxes");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxTroops");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxVP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxVP");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSwordmasterIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxSwordmasterIcons");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxHighCouncilPersuasion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxHighCouncilPersuasion");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAllianceToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxAllianceToken");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFactionTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxFactionTrack");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxConflictCard");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictCardName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxConflictCardName");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpaceControlIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxSpaceControlIcon");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictThird = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxConflictThird");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFactionTrackSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxFactionTrackSpace");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTSMF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxTSMF");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxReserveRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxReserveRow");
			WormTutorialConstants.NativeFieldInfoPtr_DeckDoinker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DeckDoinker");
			WormTutorialConstants.NativeFieldInfoPtr_DiscardDoinker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DiscardDoinker");
			WormTutorialConstants.NativeFieldInfoPtr_DiscardRevealDoinker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DiscardRevealDoinker");
			WormTutorialConstants.NativeFieldInfoPtr_FoldspaceImperiumMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FoldspaceImperiumMoz");
			WormTutorialConstants.NativeFieldInfoPtr_WithClickShield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "WithClickShield");
			WormTutorialConstants.NativeFieldInfoPtr_SpaceHintFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SpaceHintFlavor");
			WormTutorialConstants.NativeFieldInfoPtr_IntrigueHintFlavor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "IntrigueHintFlavor");
			WormTutorialConstants.NativeFieldInfoPtr_SpaceMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SpaceMoz");
			WormTutorialConstants.NativeFieldInfoPtr_SietchTabrMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SietchTabrMoz");
			WormTutorialConstants.NativeFieldInfoPtr_FremenBondMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FremenBondMoz");
			WormTutorialConstants.NativeFieldInfoPtr_PostMakersDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PostMakersDelay");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxGarrison = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxGarrison");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSolari = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxSolari");
			WormTutorialConstants.NativeFieldInfoPtr_DiscardMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DiscardMoz");
			WormTutorialConstants.NativeFieldInfoPtr_HintGraftCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HintGraftCards");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerFreighterUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerFreighterUp");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerFreighterDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerFreighterDown");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerDragTech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerDragTech");
			WormTutorialConstants.NativeFieldInfoPtr_DuneTheDesertPlanetReplacementMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DuneTheDesertPlanetReplacementMoz");
			WormTutorialConstants.NativeFieldInfoPtr_ExperimentationMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ExperimentationMoz");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxResearchSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxResearchSpace");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpecimens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxSpecimens");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightArrowTleilaxuTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightArrowTleilaxuTrack");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTleilaxuSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxTleilaxuSpace");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpiceReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxSpiceReward");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTleilaxuRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxTleilaxuRow");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTleilaxuSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxTleilaxuSlots");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAgentBox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxAgentBox");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFirstGeneticAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxFirstGeneticAbility");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSecondGeneticAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxSecondGeneticAbility");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpecimenDropArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxSpecimenDropArea");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxMarkers1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxMarkers1");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxMarkers2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxMarkers2");
			WormTutorialConstants.NativeFieldInfoPtr_PlannedCouplingMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PlannedCouplingMoz");
			WormTutorialConstants.NativeFieldInfoPtr_DisguisedBureaucratMoz = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DisguisedBureaucratMoz");
			WormTutorialConstants.NativeFieldInfoPtr_DisableResearchTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DisableResearchTrack");
			WormTutorialConstants.NativeFieldInfoPtr_DisableTleilaxuTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DisableTleilaxuTrack");
			WormTutorialConstants.NativeFieldInfoPtr_EnableTleilaxuTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "EnableTleilaxuTrack");
			WormTutorialConstants.NativeFieldInfoPtr_TutorialArrowsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "TutorialArrowsOn");
			WormTutorialConstants.NativeFieldInfoPtr_TutorialArrowsOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "TutorialArrowsOff");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerAbilities");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerTechOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerTechOffer");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerTechCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerTechCount");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerUndo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerUndo");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerResearchTleilaxuButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerResearchTleilaxuButton");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerResearchUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerResearchUp");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerResearchDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerResearchDown");
			WormTutorialConstants.NativeFieldInfoPtr_DoinkerDragReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DoinkerDragReveal");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxShipping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxShipping");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxShippingAndSmuggling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxShippingAndSmuggling");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFreighterSpaceOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxFreighterSpaceOne");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFreighterSpaceThree = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxFreighterSpaceThree");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxWholeSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxWholeSpace");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDeferredAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxDeferredAbility");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFreighterSpaceThreeRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxFreighterSpaceThreeRewards");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTechSpiceCosts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxTechSpiceCosts");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTechCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxTechCount");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxNegotiatorPersuasion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxNegotiatorPersuasion");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxNegotiatorTech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxNegotiatorTech");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxNegotiatorsHud = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxNegotiatorsHud");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictDreadnought = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxConflictDreadnought");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTechOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxTechOffer");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConfirmFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxConfirmFaction");
			WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxChooseFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HighlightBoxChooseFaction");
			WormTutorialConstants.NativeFieldInfoPtr_ResearchMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ResearchMarker");
			WormTutorialConstants.NativeFieldInfoPtr_SpecimensLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SpecimensLabel");
			WormTutorialConstants.NativeFieldInfoPtr_AcquireArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "AcquireArea");
			WormTutorialConstants.NativeFieldInfoPtr_AcquireCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "AcquireCost");
			WormTutorialConstants.NativeFieldInfoPtr_AcquireEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "AcquireEffect");
			WormTutorialConstants.NativeFieldInfoPtr_AllianceToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "AllianceToken");
			WormTutorialConstants.NativeFieldInfoPtr_ArrakeenTroop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ArrakeenTroop");
			WormTutorialConstants.NativeFieldInfoPtr_ArrakeenDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ArrakeenDraw");
			WormTutorialConstants.NativeFieldInfoPtr_AvailableAgents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "AvailableAgents");
			WormTutorialConstants.NativeFieldInfoPtr_BeastAgent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "BeastAgent");
			WormTutorialConstants.NativeFieldInfoPtr_ContextualButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ContextualButton");
			WormTutorialConstants.NativeFieldInfoPtr_ConflictContinueButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ConflictContinueButton");
			WormTutorialConstants.NativeFieldInfoPtr_ControlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ControlSpace");
			WormTutorialConstants.NativeFieldInfoPtr_FirstPlayerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FirstPlayerMarker");
			WormTutorialConstants.NativeFieldInfoPtr_OpponentInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "OpponentInfo");
			WormTutorialConstants.NativeFieldInfoPtr_ResourceCost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ResourceCost");
			WormTutorialConstants.NativeFieldInfoPtr_RevealDropArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "RevealDropArea");
			WormTutorialConstants.NativeFieldInfoPtr_VictoryPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "VictoryPoints");
			WormTutorialConstants.NativeFieldInfoPtr_VPReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "VPReward");
			WormTutorialConstants.NativeFieldInfoPtr_FactionTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FactionTag");
			WormTutorialConstants.NativeFieldInfoPtr_SmallImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SmallImperiumRow");
			WormTutorialConstants.NativeFieldInfoPtr_ImperiumRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ImperiumRow");
			WormTutorialConstants.NativeFieldInfoPtr_BoardShake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "BoardShake");
			WormTutorialConstants.NativeFieldInfoPtr_FactionBonusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FactionBonusLabel");
			WormTutorialConstants.NativeFieldInfoPtr_ConvertSpecimen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ConvertSpecimen");
			WormTutorialConstants.NativeFieldInfoPtr_FreighterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FreighterLabel");
			WormTutorialConstants.NativeFieldInfoPtr_PlayerInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PlayerInfo");
			WormTutorialConstants.NativeFieldInfoPtr_OpponentPlayerInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "OpponentPlayerInfo");
			WormTutorialConstants.NativeFieldInfoPtr_CityAndDesertSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "CityAndDesertSpaces");
			WormTutorialConstants.NativeFieldInfoPtr_CHOAMSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "CHOAMSpaces");
			WormTutorialConstants.NativeFieldInfoPtr_LandsraadSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "LandsraadSpaces");
			WormTutorialConstants.NativeFieldInfoPtr_LandsraadAdvancedSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "LandsraadAdvancedSpaces");
			WormTutorialConstants.NativeFieldInfoPtr_FactionSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FactionSpaces");
			WormTutorialConstants.NativeFieldInfoPtr_ConflictArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ConflictArea");
			WormTutorialConstants.NativeFieldInfoPtr_ConflictCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ConflictCount");
			WormTutorialConstants.NativeFieldInfoPtr_ConflictPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ConflictPlayers");
			WormTutorialConstants.NativeFieldInfoPtr_ConflictOpponents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ConflictOpponents");
			WormTutorialConstants.NativeFieldInfoPtr_ConflictOpponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ConflictOpponent");
			WormTutorialConstants.NativeFieldInfoPtr_FactionTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FactionTrack");
			WormTutorialConstants.NativeFieldInfoPtr_ControlMarkers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ControlMarkers");
			WormTutorialConstants.NativeFieldInfoPtr_ExpandedPlayerInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ExpandedPlayerInfo");
			WormTutorialConstants.NativeFieldInfoPtr_TechNegotiators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "TechNegotiators");
			WormTutorialConstants.NativeFieldInfoPtr_ShippingTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ShippingTrack");
			WormTutorialConstants.NativeFieldInfoPtr_NegotiatorsHUD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "NegotiatorsHUD");
			WormTutorialConstants.NativeFieldInfoPtr_TechNegotiationSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "TechNegotiationSpace");
			WormTutorialConstants.NativeFieldInfoPtr_DreadnoughtSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DreadnoughtSpace");
			WormTutorialConstants.NativeFieldInfoPtr_SmugglingSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SmugglingSpace");
			WormTutorialConstants.NativeFieldInfoPtr_InterstellarSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "InterstellarSpace");
			WormTutorialConstants.NativeFieldInfoPtr_TechButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "TechButton");
			WormTutorialConstants.NativeFieldInfoPtr_ResearchTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ResearchTrack");
			WormTutorialConstants.NativeFieldInfoPtr_TleilaxuTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "TleilaxuTrack");
			WormTutorialConstants.NativeFieldInfoPtr_TleilaxuRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "TleilaxuRow");
			WormTutorialConstants.NativeFieldInfoPtr_Specimens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "Specimens");
			WormTutorialConstants.NativeFieldInfoPtr_SpecimensConversion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SpecimensConversion");
			WormTutorialConstants.NativeFieldInfoPtr_FamilyAtomics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FamilyAtomics");
			WormTutorialConstants.NativeFieldInfoPtr_TrashingCardFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "TrashingCardFTT");
			WormTutorialConstants.NativeFieldInfoPtr_FoldspaceFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FoldspaceFTT");
			WormTutorialConstants.NativeFieldInfoPtr_FremenBondFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FremenBondFTT");
			WormTutorialConstants.NativeFieldInfoPtr_EndgameIntrigueFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "EndgameIntrigueFTT");
			WormTutorialConstants.NativeFieldInfoPtr_RetreatFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "RetreatFTT");
			WormTutorialConstants.NativeFieldInfoPtr_EndgameFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "EndgameFTT");
			WormTutorialConstants.NativeFieldInfoPtr_ControlBonusFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ControlBonusFTT");
			WormTutorialConstants.NativeFieldInfoPtr_FactionBonusFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FactionBonusFTT");
			WormTutorialConstants.NativeFieldInfoPtr_DiscardFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DiscardFTT");
			WormTutorialConstants.NativeFieldInfoPtr_SpecimenFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SpecimenFTT");
			WormTutorialConstants.NativeFieldInfoPtr_GraftFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "GraftFTT");
			WormTutorialConstants.NativeFieldInfoPtr_ConditionalIconFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ConditionalIconFTT");
			WormTutorialConstants.NativeFieldInfoPtr_TleilaxuFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "TleilaxuFTT");
			WormTutorialConstants.NativeFieldInfoPtr_GraftRevealFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "GraftRevealFTT");
			WormTutorialConstants.NativeFieldInfoPtr_FirstGeneticFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FirstGeneticFTT");
			WormTutorialConstants.NativeFieldInfoPtr_SecondGeneticFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SecondGeneticFTT");
			WormTutorialConstants.NativeFieldInfoPtr_HagalImmortalityFTT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "HagalImmortalityFTT");
			WormTutorialConstants.NativeFieldInfoPtr_OpenTechRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "OpenTechRow");
			WormTutorialConstants.NativeFieldInfoPtr_OpenTechTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "OpenTechTray");
			WormTutorialConstants.NativeFieldInfoPtr_TechAnimationFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "TechAnimationFinished");
			WormTutorialConstants.NativeFieldInfoPtr_SelectFaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SelectFaction");
			WormTutorialConstants.NativeFieldInfoPtr_ActivateBuyTech = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ActivateBuyTech");
			WormTutorialConstants.NativeFieldInfoPtr_AbilityRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "AbilityRegistered");
			WormTutorialConstants.NativeFieldInfoPtr_OpenResearchTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "OpenResearchTrack");
			WormTutorialConstants.NativeFieldInfoPtr_PlayerTurnEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PlayerTurnEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_AgentToSpaceEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "AgentToSpaceEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_PurchaseGurneyHalleckStartDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PurchaseGurneyHalleckStartDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_PurchaseGurneyHalleckStopDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PurchaseGurneyHalleckStopDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_PurchaseThufirStartDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PurchaseThufirStartDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_PurchaseThufirStopDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PurchaseThufirStopDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_PurchaseDuncanStartDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PurchaseDuncanStartDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_PurchaseDuncanStopDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PurchaseDuncanStopDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_StartRevealTurnEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "StartRevealTurnEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_WhileRevealTurnEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "WhileRevealTurnEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_WhileRevealTurnAlreadyOpenEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "WhileRevealTurnAlreadyOpenEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_FinishTroopSelectionEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FinishTroopSelectionEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_StartTroopSelectionEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "StartTroopSelectionEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_WhileConflictPromptEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "WhileConflictPromptEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_DisplayInfluenceSelectionPromptEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DisplayInfluenceSelectionPromptEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_PrivateArmyStartDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PrivateArmyStartDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_PrivateArmyStopDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PrivateArmyStopDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_SelectFremenEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SelectFremenEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_DisplayCustomChoicePromptEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DisplayCustomChoicePromptEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_SelectPromptOption0ResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "SelectPromptOption0ResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_RecruitmentMissionStartDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "RecruitmentMissionStartDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_RecruitmentMissionStopDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "RecruitmentMissionStopDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_BuyTechResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "BuyTechResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_ActivateBuyTechResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ActivateBuyTechResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_AbilityRegisteredResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "AbilityRegisteredResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_ShippingAbilityRegisteredResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ShippingAbilityRegisteredResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_ShippingAbilityTwoRegisteredResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ShippingAbilityTwoRegisteredResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_ShippingAbilityThreeRegisteredResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "ShippingAbilityThreeRegisteredResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_UsedInfluenceAbilityResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "UsedInfluenceAbilityResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_StartTechDragResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "StartTechDragResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_OpenResearchTrackResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "OpenResearchTrackResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_PurchaseContaminatorStartDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PurchaseContaminatorStartDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_PurchasePlannedCouplingStartDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PurchasePlannedCouplingStartDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_PurchasePlannedCouplingStopDragEventResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "PurchasePlannedCouplingStopDragEventResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_GraftCardResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "GraftCardResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_OnTrashAbilityClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "OnTrashAbilityClicked");
			WormTutorialConstants.NativeFieldInfoPtr_FremenBondFTTResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "FremenBondFTTResponseID");
			WormTutorialConstants.NativeFieldInfoPtr_DiscardFTTResponseID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormTutorialConstants>.NativeClassPtr, "DiscardFTTResponseID");
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000056F6 File Offset: 0x000038F6
		public WormTutorialConstants(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0008594C File Offset: 0x00083B4C
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x000056FF File Offset: 0x000038FF
		public unsafe static string IntroMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_IntroMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_IntroMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0008596C File Offset: 0x00083B6C
		// (set) Token: 0x06000803 RID: 2051 RVA: 0x00005711 File Offset: 0x00003911
		public unsafe static string TutorialFinished
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_TutorialFinished, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_TutorialFinished, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x0008598C File Offset: 0x00083B8C
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00005723 File Offset: 0x00003923
		public unsafe static string ButtonOnly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ButtonOnly, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ButtonOnly, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x000859AC File Offset: 0x00083BAC
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00005735 File Offset: 0x00003935
		public unsafe static string WithLeader
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_WithLeader, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_WithLeader, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x000859CC File Offset: 0x00083BCC
		// (set) Token: 0x06000809 RID: 2057 RVA: 0x00005747 File Offset: 0x00003947
		public unsafe static string Duncan
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_Duncan, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_Duncan, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x000859EC File Offset: 0x00083BEC
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x00005759 File Offset: 0x00003959
		public unsafe static string Gurney
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_Gurney, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_Gurney, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00085A0C File Offset: 0x00083C0C
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x0000576B File Offset: 0x0000396B
		public unsafe static string Leto
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_Leto, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_Leto, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00085A2C File Offset: 0x00083C2C
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x0000577D File Offset: 0x0000397D
		public unsafe static string Paul
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_Paul, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_Paul, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00085A4C File Offset: 0x00083C4C
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x0000578F File Offset: 0x0000398F
		public unsafe static string Rabban
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_Rabban, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_Rabban, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00085A6C File Offset: 0x00083C6C
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x000057A1 File Offset: 0x000039A1
		public unsafe static string Thorvald
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_Thorvald, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_Thorvald, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00085A8C File Offset: 0x00083C8C
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x000057B3 File Offset: 0x000039B3
		public unsafe static string Thufir
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_Thufir, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_Thufir, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00085AAC File Offset: 0x00083CAC
		// (set) Token: 0x06000817 RID: 2071 RVA: 0x000057C5 File Offset: 0x000039C5
		public unsafe static string Stilgar
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_Stilgar, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_Stilgar, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00085ACC File Offset: 0x00083CCC
		// (set) Token: 0x06000819 RID: 2073 RVA: 0x000057D7 File Offset: 0x000039D7
		public unsafe static string Armand
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_Armand, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_Armand, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00085AEC File Offset: 0x00083CEC
		// (set) Token: 0x0600081B RID: 2075 RVA: 0x000057E9 File Offset: 0x000039E9
		public unsafe static string Ilban
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_Ilban, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_Ilban, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00085B0C File Offset: 0x00083D0C
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x000057FB File Offset: 0x000039FB
		public unsafe static string DisableConflictPlusButton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DisableConflictPlusButton, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DisableConflictPlusButton, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00085B2C File Offset: 0x00083D2C
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x0000580D File Offset: 0x00003A0D
		public unsafe static string EnableConflictPlusButton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_EnableConflictPlusButton, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_EnableConflictPlusButton, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00085B4C File Offset: 0x00083D4C
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x0000581F File Offset: 0x00003A1F
		public unsafe static string DisableConflictMinusButton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DisableConflictMinusButton, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DisableConflictMinusButton, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00085B6C File Offset: 0x00083D6C
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x00005831 File Offset: 0x00003A31
		public unsafe static string EnableConflictMinusButton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_EnableConflictMinusButton, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_EnableConflictMinusButton, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00085B8C File Offset: 0x00083D8C
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x00005843 File Offset: 0x00003A43
		public unsafe static string ForceOpenRevealImperiumRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ForceOpenRevealImperiumRow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ForceOpenRevealImperiumRow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00085BAC File Offset: 0x00083DAC
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x00005855 File Offset: 0x00003A55
		public unsafe static string CloseImperiumRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_CloseImperiumRow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_CloseImperiumRow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00085BCC File Offset: 0x00083DCC
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x00005867 File Offset: 0x00003A67
		public unsafe static string HideCardHinting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HideCardHinting, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HideCardHinting, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00085BEC File Offset: 0x00083DEC
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x00005879 File Offset: 0x00003A79
		public unsafe static string ShowCardHinting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ShowCardHinting, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ShowCardHinting, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x00085C0C File Offset: 0x00083E0C
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x0000588B File Offset: 0x00003A8B
		public unsafe static string GamepadSelect
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_GamepadSelect, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_GamepadSelect, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00085C2C File Offset: 0x00083E2C
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x0000589D File Offset: 0x00003A9D
		public unsafe static string DisableDeferredAbilities
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DisableDeferredAbilities, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DisableDeferredAbilities, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00085C4C File Offset: 0x00083E4C
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x000058AF File Offset: 0x00003AAF
		public unsafe static string EnableDeferredAbilities
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_EnableDeferredAbilities, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_EnableDeferredAbilities, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00085C6C File Offset: 0x00083E6C
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x000058C1 File Offset: 0x00003AC1
		public unsafe static string MinimizeTechRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_MinimizeTechRow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_MinimizeTechRow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00085C8C File Offset: 0x00083E8C
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x000058D3 File Offset: 0x00003AD3
		public unsafe static string MinimizeTechTray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_MinimizeTechTray, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_MinimizeTechTray, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00085CAC File Offset: 0x00083EAC
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x000058E5 File Offset: 0x00003AE5
		public unsafe static string ForceOpenResearchTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ForceOpenResearchTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ForceOpenResearchTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00085CCC File Offset: 0x00083ECC
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x000058F7 File Offset: 0x00003AF7
		public unsafe static string CloseResearchTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_CloseResearchTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_CloseResearchTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x00085CEC File Offset: 0x00083EEC
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x00005909 File Offset: 0x00003B09
		public unsafe static string OpenTleilaxuTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_OpenTleilaxuTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_OpenTleilaxuTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00085D0C File Offset: 0x00083F0C
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x0000591B File Offset: 0x00003B1B
		public unsafe static string CloseTleilaxuTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_CloseTleilaxuTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_CloseTleilaxuTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00085D2C File Offset: 0x00083F2C
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x0000592D File Offset: 0x00003B2D
		public unsafe static string OpenImperiumRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_OpenImperiumRow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_OpenImperiumRow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00085D4C File Offset: 0x00083F4C
		// (set) Token: 0x06000841 RID: 2113 RVA: 0x0000593F File Offset: 0x00003B3F
		public unsafe static string CardMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_CardMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_CardMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000842 RID: 2114 RVA: 0x00085D6C File Offset: 0x00083F6C
		// (set) Token: 0x06000843 RID: 2115 RVA: 0x00005951 File Offset: 0x00003B51
		public unsafe static string Doinker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_Doinker, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_Doinker, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x00085D8C File Offset: 0x00083F8C
		// (set) Token: 0x06000845 RID: 2117 RVA: 0x00005963 File Offset: 0x00003B63
		public unsafe static string DoinkerBottom
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerBottom, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerBottom, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00085DAC File Offset: 0x00083FAC
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x00005975 File Offset: 0x00003B75
		public unsafe static string DoinkerDrag
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerDrag, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerDrag, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00085DCC File Offset: 0x00083FCC
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x00005987 File Offset: 0x00003B87
		public unsafe static string DoinkerDragIntrigue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerDragIntrigue, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerDragIntrigue, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00085DEC File Offset: 0x00083FEC
		// (set) Token: 0x0600084B RID: 2123 RVA: 0x00005999 File Offset: 0x00003B99
		public unsafe static string DoinkerDragLeft
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerDragLeft, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerDragLeft, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00085E0C File Offset: 0x0008400C
		// (set) Token: 0x0600084D RID: 2125 RVA: 0x000059AB File Offset: 0x00003BAB
		public unsafe static string BottomAligned
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_BottomAligned, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_BottomAligned, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00085E2C File Offset: 0x0008402C
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x000059BD File Offset: 0x00003BBD
		public unsafe static string CenterAligned
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_CenterAligned, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_CenterAligned, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00085E4C File Offset: 0x0008404C
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x000059CF File Offset: 0x00003BCF
		public unsafe static string RightAligned
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_RightAligned, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_RightAligned, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00085E6C File Offset: 0x0008406C
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x000059E1 File Offset: 0x00003BE1
		public unsafe static string LeftAligned
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_LeftAligned, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_LeftAligned, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00085E8C File Offset: 0x0008408C
		// (set) Token: 0x06000855 RID: 2133 RVA: 0x000059F3 File Offset: 0x00003BF3
		public unsafe static string DuneTheDesertPlanetMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DuneTheDesertPlanetMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DuneTheDesertPlanetMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00085EAC File Offset: 0x000840AC
		// (set) Token: 0x06000857 RID: 2135 RVA: 0x00005A05 File Offset: 0x00003C05
		public unsafe static string ReconnaissanceMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ReconnaissanceMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ReconnaissanceMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x00085ECC File Offset: 0x000840CC
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x00005A17 File Offset: 0x00003C17
		public unsafe static string SkirmishMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SkirmishMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SkirmishMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00085EEC File Offset: 0x000840EC
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x00005A29 File Offset: 0x00003C29
		public unsafe static string SignetRingMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SignetRingMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SignetRingMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00085F0C File Offset: 0x0008410C
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x00005A3B File Offset: 0x00003C3B
		public unsafe static string GurneyMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_GurneyMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_GurneyMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x00085F2C File Offset: 0x0008412C
		// (set) Token: 0x0600085F RID: 2143 RVA: 0x00005A4D File Offset: 0x00003C4D
		public unsafe static string RecruitmentMissionMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_RecruitmentMissionMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_RecruitmentMissionMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x00085F4C File Offset: 0x0008414C
		// (set) Token: 0x06000861 RID: 2145 RVA: 0x00005A5F File Offset: 0x00003C5F
		public unsafe static string PrivateArmyMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PrivateArmyMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PrivateArmyMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00085F6C File Offset: 0x0008416C
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x00005A71 File Offset: 0x00003C71
		public unsafe static string DisplayLocationName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DisplayLocationName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DisplayLocationName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x00085F8C File Offset: 0x0008418C
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x00005A83 File Offset: 0x00003C83
		public unsafe static string HideLocationName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HideLocationName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HideLocationName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00085FAC File Offset: 0x000841AC
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x00005A95 File Offset: 0x00003C95
		public unsafe static string ArrowWithLabel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ArrowWithLabel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ArrowWithLabel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00085FCC File Offset: 0x000841CC
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x00005AA7 File Offset: 0x00003CA7
		public unsafe static string CombatSpaceIcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_CombatSpaceIcon, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_CombatSpaceIcon, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00085FEC File Offset: 0x000841EC
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x00005AB9 File Offset: 0x00003CB9
		public unsafe static string CombatSpaceIconMulti
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_CombatSpaceIconMulti, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_CombatSpaceIconMulti, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0008600C File Offset: 0x0008420C
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00005ACB File Offset: 0x00003CCB
		public unsafe static string FactionArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FactionArea, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FactionArea, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0008602C File Offset: 0x0008422C
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x00005ADD File Offset: 0x00003CDD
		public unsafe static string FremenTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FremenTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FremenTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0008604C File Offset: 0x0008424C
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x00005AEF File Offset: 0x00003CEF
		public unsafe static string FremenButton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FremenButton, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FremenButton, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0008606C File Offset: 0x0008426C
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x00005B01 File Offset: 0x00003D01
		public unsafe static string RecruitmentMissionSecondOption
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_RecruitmentMissionSecondOption, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_RecruitmentMissionSecondOption, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x0008608C File Offset: 0x0008428C
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x00005B13 File Offset: 0x00003D13
		public unsafe static string PromptContinueButton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PromptContinueButton, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PromptContinueButton, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x000860AC File Offset: 0x000842AC
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x00005B25 File Offset: 0x00003D25
		public unsafe static string AgentTurnAbilities
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_AgentTurnAbilities, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_AgentTurnAbilities, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x000860CC File Offset: 0x000842CC
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x00005B37 File Offset: 0x00003D37
		public unsafe static string RevealTurnAbilities
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_RevealTurnAbilities, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_RevealTurnAbilities, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x000860EC File Offset: 0x000842EC
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x00005B49 File Offset: 0x00003D49
		public unsafe static string ConflictPlusButton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictPlusButton, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictPlusButton, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0008610C File Offset: 0x0008430C
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x00005B5B File Offset: 0x00003D5B
		public unsafe static string ConflictCurrentStrength
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictCurrentStrength, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictCurrentStrength, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x0008612C File Offset: 0x0008432C
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x00005B6D File Offset: 0x00003D6D
		public unsafe static string HighlightBoxAcquire
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAcquire, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAcquire, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x0008614C File Offset: 0x0008434C
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x00005B7F File Offset: 0x00003D7F
		public unsafe static string HighlightBoxAgents
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAgents, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAgents, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x0008616C File Offset: 0x0008436C
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x00005B91 File Offset: 0x00003D91
		public unsafe static string HighlightBoxAgentIcons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAgentIcons, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAgentIcons, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0008618C File Offset: 0x0008438C
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00005BA3 File Offset: 0x00003DA3
		public unsafe static string HighlightBoxArrakeenDraw
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxArrakeenDraw, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxArrakeenDraw, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x000861AC File Offset: 0x000843AC
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x00005BB5 File Offset: 0x00003DB5
		public unsafe static string HighlightBoxArrakeenTroop
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxArrakeenTroop, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxArrakeenTroop, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x000861CC File Offset: 0x000843CC
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x00005BC7 File Offset: 0x00003DC7
		public unsafe static string HighlightBoxCHOAM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxCHOAM, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxCHOAM, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x000861EC File Offset: 0x000843EC
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x00005BD9 File Offset: 0x00003DD9
		public unsafe static string HighlightBoxConflictArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictArea, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictArea, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x0008620C File Offset: 0x0008440C
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00005BEB File Offset: 0x00003DEB
		public unsafe static string HighlightBoxConflictAreaPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictAreaPlayer, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictAreaPlayer, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x0008622C File Offset: 0x0008442C
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00005BFD File Offset: 0x00003DFD
		public unsafe static string HighlightBoxConflictCurrentStrength
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictCurrentStrength, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictCurrentStrength, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x0008624C File Offset: 0x0008444C
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x00005C0F File Offset: 0x00003E0F
		public unsafe static string HighlightBoxConflictRewards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictRewards, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictRewards, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0008626C File Offset: 0x0008446C
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00005C21 File Offset: 0x00003E21
		public unsafe static string HighlightBoxConflictResultsReward
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictResultsReward, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictResultsReward, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x0008628C File Offset: 0x0008448C
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00005C33 File Offset: 0x00003E33
		public unsafe static string HighlightBoxControlIcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxControlIcon, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxControlIcon, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x000862AC File Offset: 0x000844AC
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00005C45 File Offset: 0x00003E45
		public unsafe static string HighlightBoxDeck
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDeck, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDeck, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x000862CC File Offset: 0x000844CC
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00005C57 File Offset: 0x00003E57
		public unsafe static string HighlightBoxDeckAndDiscard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDeckAndDiscard, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDeckAndDiscard, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x000862EC File Offset: 0x000844EC
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00005C69 File Offset: 0x00003E69
		public unsafe static string HighlightBoxDiscard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDiscard, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDiscard, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0008630C File Offset: 0x0008450C
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00005C7B File Offset: 0x00003E7B
		public unsafe static string HighlightBoxFirstPlayerMarker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFirstPlayerMarker, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFirstPlayerMarker, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x0008632C File Offset: 0x0008452C
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00005C8D File Offset: 0x00003E8D
		public unsafe static string HighlightBoxHand
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxHand, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxHand, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x0008634C File Offset: 0x0008454C
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00005C9F File Offset: 0x00003E9F
		public unsafe static string HighlightBoxHUDResources
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxHUDResources, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxHUDResources, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x0008636C File Offset: 0x0008456C
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x00005CB1 File Offset: 0x00003EB1
		public unsafe static string HighlightBoxImperiumRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxImperiumRow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxImperiumRow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0008638C File Offset: 0x0008458C
		// (set) Token: 0x060008A5 RID: 2213 RVA: 0x00005CC3 File Offset: 0x00003EC3
		public unsafe static string HighlightBoxOpponentInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxOpponentInfo, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxOpponentInfo, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x000863AC File Offset: 0x000845AC
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x00005CD5 File Offset: 0x00003ED5
		public unsafe static string HighlightBoxPlayed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxPlayed, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxPlayed, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x000863CC File Offset: 0x000845CC
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x00005CE7 File Offset: 0x00003EE7
		public unsafe static string HighlightBoxPersuasion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxPersuasion, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxPersuasion, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x000863EC File Offset: 0x000845EC
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00005CF9 File Offset: 0x00003EF9
		public unsafe static string HighlightBoxPersuasionCost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxPersuasionCost, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxPersuasionCost, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x0008640C File Offset: 0x0008460C
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00005D0B File Offset: 0x00003F0B
		public unsafe static string HighlightBoxSmallImperiumRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSmallImperiumRow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSmallImperiumRow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0008642C File Offset: 0x0008462C
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00005D1D File Offset: 0x00003F1D
		public unsafe static string HighlightBoxSpaceCost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpaceCost, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpaceCost, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0008644C File Offset: 0x0008464C
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00005D2F File Offset: 0x00003F2F
		public unsafe static string HighlightBoxSpaceAgent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpaceAgent, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpaceAgent, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0008646C File Offset: 0x0008466C
		// (set) Token: 0x060008B3 RID: 2227 RVA: 0x00005D41 File Offset: 0x00003F41
		public unsafe static string HighlightBoxResourceIcons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxResourceIcons, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxResourceIcons, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0008648C File Offset: 0x0008468C
		// (set) Token: 0x060008B5 RID: 2229 RVA: 0x00005D53 File Offset: 0x00003F53
		public unsafe static string HighlightBoxRevealBoxes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxRevealBoxes, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxRevealBoxes, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x000864AC File Offset: 0x000846AC
		// (set) Token: 0x060008B7 RID: 2231 RVA: 0x00005D65 File Offset: 0x00003F65
		public unsafe static string HighlightBoxDaggerRevealBoxes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDaggerRevealBoxes, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDaggerRevealBoxes, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x000864CC File Offset: 0x000846CC
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00005D77 File Offset: 0x00003F77
		public unsafe static string HighlightBoxTroops
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTroops, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTroops, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x000864EC File Offset: 0x000846EC
		// (set) Token: 0x060008BB RID: 2235 RVA: 0x00005D89 File Offset: 0x00003F89
		public unsafe static string HighlightBoxVP
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxVP, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxVP, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0008650C File Offset: 0x0008470C
		// (set) Token: 0x060008BD RID: 2237 RVA: 0x00005D9B File Offset: 0x00003F9B
		public unsafe static string HighlightBoxSwordmasterIcons
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSwordmasterIcons, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSwordmasterIcons, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0008652C File Offset: 0x0008472C
		// (set) Token: 0x060008BF RID: 2239 RVA: 0x00005DAD File Offset: 0x00003FAD
		public unsafe static string HighlightBoxHighCouncilPersuasion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxHighCouncilPersuasion, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxHighCouncilPersuasion, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0008654C File Offset: 0x0008474C
		// (set) Token: 0x060008C1 RID: 2241 RVA: 0x00005DBF File Offset: 0x00003FBF
		public unsafe static string HighlightBoxAllianceToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAllianceToken, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAllianceToken, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0008656C File Offset: 0x0008476C
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x00005DD1 File Offset: 0x00003FD1
		public unsafe static string HighlightBoxFactionTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFactionTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFactionTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0008658C File Offset: 0x0008478C
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x00005DE3 File Offset: 0x00003FE3
		public unsafe static string HighlightBoxConflictCard
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictCard, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictCard, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x000865AC File Offset: 0x000847AC
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00005DF5 File Offset: 0x00003FF5
		public unsafe static string HighlightBoxConflictCardName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictCardName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictCardName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x000865CC File Offset: 0x000847CC
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00005E07 File Offset: 0x00004007
		public unsafe static string HighlightBoxSpaceControlIcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpaceControlIcon, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpaceControlIcon, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x000865EC File Offset: 0x000847EC
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00005E19 File Offset: 0x00004019
		public unsafe static string HighlightBoxConflictThird
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictThird, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictThird, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0008660C File Offset: 0x0008480C
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x00005E2B File Offset: 0x0000402B
		public unsafe static string HighlightBoxFactionTrackSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFactionTrackSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFactionTrackSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0008662C File Offset: 0x0008482C
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x00005E3D File Offset: 0x0000403D
		public unsafe static string HighlightBoxTSMF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTSMF, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTSMF, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0008664C File Offset: 0x0008484C
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00005E4F File Offset: 0x0000404F
		public unsafe static string HighlightBoxReserveRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxReserveRow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxReserveRow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0008666C File Offset: 0x0008486C
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00005E61 File Offset: 0x00004061
		public unsafe static string DeckDoinker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DeckDoinker, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DeckDoinker, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0008668C File Offset: 0x0008488C
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x00005E73 File Offset: 0x00004073
		public unsafe static string DiscardDoinker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DiscardDoinker, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DiscardDoinker, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000866AC File Offset: 0x000848AC
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x00005E85 File Offset: 0x00004085
		public unsafe static string DiscardRevealDoinker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DiscardRevealDoinker, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DiscardRevealDoinker, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000866CC File Offset: 0x000848CC
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00005E97 File Offset: 0x00004097
		public unsafe static string FoldspaceImperiumMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FoldspaceImperiumMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FoldspaceImperiumMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x000866EC File Offset: 0x000848EC
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x00005EA9 File Offset: 0x000040A9
		public unsafe static string WithClickShield
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_WithClickShield, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_WithClickShield, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0008670C File Offset: 0x0008490C
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00005EBB File Offset: 0x000040BB
		public unsafe static string SpaceHintFlavor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SpaceHintFlavor, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SpaceHintFlavor, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0008672C File Offset: 0x0008492C
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00005ECD File Offset: 0x000040CD
		public unsafe static string IntrigueHintFlavor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_IntrigueHintFlavor, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_IntrigueHintFlavor, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0008674C File Offset: 0x0008494C
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00005EDF File Offset: 0x000040DF
		public unsafe static string SpaceMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SpaceMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SpaceMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0008676C File Offset: 0x0008496C
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00005EF1 File Offset: 0x000040F1
		public unsafe static string SietchTabrMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SietchTabrMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SietchTabrMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0008678C File Offset: 0x0008498C
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00005F03 File Offset: 0x00004103
		public unsafe static string FremenBondMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FremenBondMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FremenBondMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x000867AC File Offset: 0x000849AC
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00005F15 File Offset: 0x00004115
		public unsafe static string PostMakersDelay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PostMakersDelay, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PostMakersDelay, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x000867CC File Offset: 0x000849CC
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00005F27 File Offset: 0x00004127
		public unsafe static string HighlightBoxGarrison
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxGarrison, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxGarrison, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x000867EC File Offset: 0x000849EC
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00005F39 File Offset: 0x00004139
		public unsafe static string HighlightBoxSolari
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSolari, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSolari, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0008680C File Offset: 0x00084A0C
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00005F4B File Offset: 0x0000414B
		public unsafe static string DiscardMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DiscardMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DiscardMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0008682C File Offset: 0x00084A2C
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00005F5D File Offset: 0x0000415D
		public unsafe static string HintGraftCards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HintGraftCards, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HintGraftCards, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0008684C File Offset: 0x00084A4C
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00005F6F File Offset: 0x0000416F
		public unsafe static string DoinkerFreighterUp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerFreighterUp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerFreighterUp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0008686C File Offset: 0x00084A6C
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00005F81 File Offset: 0x00004181
		public unsafe static string DoinkerFreighterDown
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerFreighterDown, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerFreighterDown, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0008688C File Offset: 0x00084A8C
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00005F93 File Offset: 0x00004193
		public unsafe static string DoinkerDragTech
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerDragTech, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerDragTech, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x000868AC File Offset: 0x00084AAC
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00005FA5 File Offset: 0x000041A5
		public unsafe static string DuneTheDesertPlanetReplacementMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DuneTheDesertPlanetReplacementMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DuneTheDesertPlanetReplacementMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x000868CC File Offset: 0x00084ACC
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x00005FB7 File Offset: 0x000041B7
		public unsafe static string ExperimentationMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ExperimentationMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ExperimentationMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x000868EC File Offset: 0x00084AEC
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x00005FC9 File Offset: 0x000041C9
		public unsafe static string HighlightBoxResearchSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxResearchSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxResearchSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0008690C File Offset: 0x00084B0C
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00005FDB File Offset: 0x000041DB
		public unsafe static string HighlightBoxSpecimens
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpecimens, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpecimens, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0008692C File Offset: 0x00084B2C
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x00005FED File Offset: 0x000041ED
		public unsafe static string HighlightArrowTleilaxuTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightArrowTleilaxuTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightArrowTleilaxuTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0008694C File Offset: 0x00084B4C
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00005FFF File Offset: 0x000041FF
		public unsafe static string HighlightBoxTleilaxuSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTleilaxuSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTleilaxuSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0008696C File Offset: 0x00084B6C
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00006011 File Offset: 0x00004211
		public unsafe static string HighlightBoxSpiceReward
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpiceReward, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpiceReward, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0008698C File Offset: 0x00084B8C
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00006023 File Offset: 0x00004223
		public unsafe static string HighlightBoxTleilaxuRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTleilaxuRow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTleilaxuRow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x000869AC File Offset: 0x00084BAC
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x00006035 File Offset: 0x00004235
		public unsafe static string HighlightBoxTleilaxuSlots
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTleilaxuSlots, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTleilaxuSlots, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x000869CC File Offset: 0x00084BCC
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x00006047 File Offset: 0x00004247
		public unsafe static string HighlightBoxAgentBox
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAgentBox, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxAgentBox, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x000869EC File Offset: 0x00084BEC
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00006059 File Offset: 0x00004259
		public unsafe static string HighlightBoxFirstGeneticAbility
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFirstGeneticAbility, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFirstGeneticAbility, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00086A0C File Offset: 0x00084C0C
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x0000606B File Offset: 0x0000426B
		public unsafe static string HighlightBoxSecondGeneticAbility
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSecondGeneticAbility, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSecondGeneticAbility, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00086A2C File Offset: 0x00084C2C
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x0000607D File Offset: 0x0000427D
		public unsafe static string HighlightBoxSpecimenDropArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpecimenDropArea, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxSpecimenDropArea, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x00086A4C File Offset: 0x00084C4C
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x0000608F File Offset: 0x0000428F
		public unsafe static string HighlightBoxMarkers1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxMarkers1, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxMarkers1, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x00086A6C File Offset: 0x00084C6C
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x000060A1 File Offset: 0x000042A1
		public unsafe static string HighlightBoxMarkers2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxMarkers2, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxMarkers2, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x00086A8C File Offset: 0x00084C8C
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x000060B3 File Offset: 0x000042B3
		public unsafe static string PlannedCouplingMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PlannedCouplingMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PlannedCouplingMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x00086AAC File Offset: 0x00084CAC
		// (set) Token: 0x06000917 RID: 2327 RVA: 0x000060C5 File Offset: 0x000042C5
		public unsafe static string DisguisedBureaucratMoz
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DisguisedBureaucratMoz, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DisguisedBureaucratMoz, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x00086ACC File Offset: 0x00084CCC
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x000060D7 File Offset: 0x000042D7
		public unsafe static string DisableResearchTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DisableResearchTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DisableResearchTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x00086AEC File Offset: 0x00084CEC
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x000060E9 File Offset: 0x000042E9
		public unsafe static string DisableTleilaxuTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DisableTleilaxuTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DisableTleilaxuTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x00086B0C File Offset: 0x00084D0C
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x000060FB File Offset: 0x000042FB
		public unsafe static string EnableTleilaxuTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_EnableTleilaxuTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_EnableTleilaxuTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x00086B2C File Offset: 0x00084D2C
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x0000610D File Offset: 0x0000430D
		public unsafe static string TutorialArrowsOn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_TutorialArrowsOn, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_TutorialArrowsOn, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x00086B4C File Offset: 0x00084D4C
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x0000611F File Offset: 0x0000431F
		public unsafe static string TutorialArrowsOff
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_TutorialArrowsOff, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_TutorialArrowsOff, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x00086B6C File Offset: 0x00084D6C
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00006131 File Offset: 0x00004331
		public unsafe static string DoinkerAbilities
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerAbilities, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerAbilities, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00086B8C File Offset: 0x00084D8C
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x00006143 File Offset: 0x00004343
		public unsafe static string DoinkerTechOffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerTechOffer, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerTechOffer, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00086BAC File Offset: 0x00084DAC
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00006155 File Offset: 0x00004355
		public unsafe static string DoinkerTechCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerTechCount, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerTechCount, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00086BCC File Offset: 0x00084DCC
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x00006167 File Offset: 0x00004367
		public unsafe static string DoinkerUndo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerUndo, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerUndo, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00086BEC File Offset: 0x00084DEC
		// (set) Token: 0x0600092B RID: 2347 RVA: 0x00006179 File Offset: 0x00004379
		public unsafe static string DoinkerResearchTleilaxuButton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerResearchTleilaxuButton, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerResearchTleilaxuButton, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00086C0C File Offset: 0x00084E0C
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x0000618B File Offset: 0x0000438B
		public unsafe static string DoinkerResearchUp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerResearchUp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerResearchUp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00086C2C File Offset: 0x00084E2C
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x0000619D File Offset: 0x0000439D
		public unsafe static string DoinkerResearchDown
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerResearchDown, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerResearchDown, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00086C4C File Offset: 0x00084E4C
		// (set) Token: 0x06000931 RID: 2353 RVA: 0x000061AF File Offset: 0x000043AF
		public unsafe static string DoinkerDragReveal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerDragReveal, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DoinkerDragReveal, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00086C6C File Offset: 0x00084E6C
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x000061C1 File Offset: 0x000043C1
		public unsafe static string HighlightBoxShipping
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxShipping, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxShipping, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00086C8C File Offset: 0x00084E8C
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x000061D3 File Offset: 0x000043D3
		public unsafe static string HighlightBoxShippingAndSmuggling
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxShippingAndSmuggling, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxShippingAndSmuggling, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00086CAC File Offset: 0x00084EAC
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x000061E5 File Offset: 0x000043E5
		public unsafe static string HighlightBoxFreighterSpaceOne
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFreighterSpaceOne, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFreighterSpaceOne, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00086CCC File Offset: 0x00084ECC
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x000061F7 File Offset: 0x000043F7
		public unsafe static string HighlightBoxFreighterSpaceThree
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFreighterSpaceThree, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFreighterSpaceThree, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00086CEC File Offset: 0x00084EEC
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00006209 File Offset: 0x00004409
		public unsafe static string HighlightBoxWholeSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxWholeSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxWholeSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00086D0C File Offset: 0x00084F0C
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x0000621B File Offset: 0x0000441B
		public unsafe static string HighlightBoxDeferredAbility
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDeferredAbility, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxDeferredAbility, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00086D2C File Offset: 0x00084F2C
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x0000622D File Offset: 0x0000442D
		public unsafe static string HighlightBoxFreighterSpaceThreeRewards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFreighterSpaceThreeRewards, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxFreighterSpaceThreeRewards, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00086D4C File Offset: 0x00084F4C
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x0000623F File Offset: 0x0000443F
		public unsafe static string HighlightBoxTechSpiceCosts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTechSpiceCosts, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTechSpiceCosts, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00086D6C File Offset: 0x00084F6C
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00006251 File Offset: 0x00004451
		public unsafe static string HighlightBoxTechCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTechCount, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTechCount, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00086D8C File Offset: 0x00084F8C
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00006263 File Offset: 0x00004463
		public unsafe static string HighlightBoxNegotiatorPersuasion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxNegotiatorPersuasion, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxNegotiatorPersuasion, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00086DAC File Offset: 0x00084FAC
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00006275 File Offset: 0x00004475
		public unsafe static string HighlightBoxNegotiatorTech
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxNegotiatorTech, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxNegotiatorTech, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00086DCC File Offset: 0x00084FCC
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x00006287 File Offset: 0x00004487
		public unsafe static string HighlightBoxNegotiatorsHud
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxNegotiatorsHud, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxNegotiatorsHud, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00086DEC File Offset: 0x00084FEC
		// (set) Token: 0x0600094B RID: 2379 RVA: 0x00006299 File Offset: 0x00004499
		public unsafe static string HighlightBoxConflictDreadnought
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictDreadnought, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConflictDreadnought, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x0600094C RID: 2380 RVA: 0x00086E0C File Offset: 0x0008500C
		// (set) Token: 0x0600094D RID: 2381 RVA: 0x000062AB File Offset: 0x000044AB
		public unsafe static string HighlightBoxTechOffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTechOffer, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxTechOffer, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x00086E2C File Offset: 0x0008502C
		// (set) Token: 0x0600094F RID: 2383 RVA: 0x000062BD File Offset: 0x000044BD
		public unsafe static string HighlightBoxConfirmFaction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConfirmFaction, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxConfirmFaction, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x00086E4C File Offset: 0x0008504C
		// (set) Token: 0x06000951 RID: 2385 RVA: 0x000062CF File Offset: 0x000044CF
		public unsafe static string HighlightBoxChooseFaction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxChooseFaction, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HighlightBoxChooseFaction, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00086E6C File Offset: 0x0008506C
		// (set) Token: 0x06000953 RID: 2387 RVA: 0x000062E1 File Offset: 0x000044E1
		public unsafe static string ResearchMarker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ResearchMarker, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ResearchMarker, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000954 RID: 2388 RVA: 0x00086E8C File Offset: 0x0008508C
		// (set) Token: 0x06000955 RID: 2389 RVA: 0x000062F3 File Offset: 0x000044F3
		public unsafe static string SpecimensLabel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SpecimensLabel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SpecimensLabel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x00086EAC File Offset: 0x000850AC
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x00006305 File Offset: 0x00004505
		public unsafe static string AcquireArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_AcquireArea, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_AcquireArea, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x00086ECC File Offset: 0x000850CC
		// (set) Token: 0x06000959 RID: 2393 RVA: 0x00006317 File Offset: 0x00004517
		public unsafe static string AcquireCost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_AcquireCost, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_AcquireCost, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x00086EEC File Offset: 0x000850EC
		// (set) Token: 0x0600095B RID: 2395 RVA: 0x00006329 File Offset: 0x00004529
		public unsafe static string AcquireEffect
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_AcquireEffect, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_AcquireEffect, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x0600095C RID: 2396 RVA: 0x00086F0C File Offset: 0x0008510C
		// (set) Token: 0x0600095D RID: 2397 RVA: 0x0000633B File Offset: 0x0000453B
		public unsafe static string AllianceToken
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_AllianceToken, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_AllianceToken, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x00086F2C File Offset: 0x0008512C
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x0000634D File Offset: 0x0000454D
		public unsafe static string ArrakeenTroop
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ArrakeenTroop, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ArrakeenTroop, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00086F4C File Offset: 0x0008514C
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x0000635F File Offset: 0x0000455F
		public unsafe static string ArrakeenDraw
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ArrakeenDraw, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ArrakeenDraw, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00086F6C File Offset: 0x0008516C
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x00006371 File Offset: 0x00004571
		public unsafe static string AvailableAgents
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_AvailableAgents, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_AvailableAgents, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x00086F8C File Offset: 0x0008518C
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x00006383 File Offset: 0x00004583
		public unsafe static string BeastAgent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_BeastAgent, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_BeastAgent, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00086FAC File Offset: 0x000851AC
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x00006395 File Offset: 0x00004595
		public unsafe static string ContextualButton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ContextualButton, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ContextualButton, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00086FCC File Offset: 0x000851CC
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x000063A7 File Offset: 0x000045A7
		public unsafe static string ConflictContinueButton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictContinueButton, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictContinueButton, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00086FEC File Offset: 0x000851EC
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x000063B9 File Offset: 0x000045B9
		public unsafe static string ControlSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ControlSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ControlSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0008700C File Offset: 0x0008520C
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x000063CB File Offset: 0x000045CB
		public unsafe static string FirstPlayerMarker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FirstPlayerMarker, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FirstPlayerMarker, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0008702C File Offset: 0x0008522C
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x000063DD File Offset: 0x000045DD
		public unsafe static string OpponentInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_OpponentInfo, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_OpponentInfo, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0008704C File Offset: 0x0008524C
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x000063EF File Offset: 0x000045EF
		public unsafe static string ResourceCost
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ResourceCost, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ResourceCost, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0008706C File Offset: 0x0008526C
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x00006401 File Offset: 0x00004601
		public unsafe static string RevealDropArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_RevealDropArea, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_RevealDropArea, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0008708C File Offset: 0x0008528C
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x00006413 File Offset: 0x00004613
		public unsafe static string VictoryPoints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_VictoryPoints, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_VictoryPoints, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x000870AC File Offset: 0x000852AC
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x00006425 File Offset: 0x00004625
		public unsafe static string VPReward
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_VPReward, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_VPReward, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x000870CC File Offset: 0x000852CC
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x00006437 File Offset: 0x00004637
		public unsafe static string FactionTag
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FactionTag, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FactionTag, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x000870EC File Offset: 0x000852EC
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x00006449 File Offset: 0x00004649
		public unsafe static string SmallImperiumRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SmallImperiumRow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SmallImperiumRow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0008710C File Offset: 0x0008530C
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x0000645B File Offset: 0x0000465B
		public unsafe static string ImperiumRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ImperiumRow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ImperiumRow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x0600097E RID: 2430 RVA: 0x0008712C File Offset: 0x0008532C
		// (set) Token: 0x0600097F RID: 2431 RVA: 0x0000646D File Offset: 0x0000466D
		public unsafe static string BoardShake
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_BoardShake, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_BoardShake, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x0008714C File Offset: 0x0008534C
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x0000647F File Offset: 0x0000467F
		public unsafe static string FactionBonusLabel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FactionBonusLabel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FactionBonusLabel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x0008716C File Offset: 0x0008536C
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00006491 File Offset: 0x00004691
		public unsafe static string ConvertSpecimen
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ConvertSpecimen, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ConvertSpecimen, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x0008718C File Offset: 0x0008538C
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x000064A3 File Offset: 0x000046A3
		public unsafe static string FreighterLabel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FreighterLabel, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FreighterLabel, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x000871AC File Offset: 0x000853AC
		// (set) Token: 0x06000987 RID: 2439 RVA: 0x000064B5 File Offset: 0x000046B5
		public unsafe static string PlayerInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PlayerInfo, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PlayerInfo, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x000871CC File Offset: 0x000853CC
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x000064C7 File Offset: 0x000046C7
		public unsafe static string OpponentPlayerInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_OpponentPlayerInfo, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_OpponentPlayerInfo, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x000871EC File Offset: 0x000853EC
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x000064D9 File Offset: 0x000046D9
		public unsafe static string CityAndDesertSpaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_CityAndDesertSpaces, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_CityAndDesertSpaces, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0008720C File Offset: 0x0008540C
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x000064EB File Offset: 0x000046EB
		public unsafe static string CHOAMSpaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_CHOAMSpaces, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_CHOAMSpaces, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0008722C File Offset: 0x0008542C
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x000064FD File Offset: 0x000046FD
		public unsafe static string LandsraadSpaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_LandsraadSpaces, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_LandsraadSpaces, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0008724C File Offset: 0x0008544C
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x0000650F File Offset: 0x0000470F
		public unsafe static string LandsraadAdvancedSpaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_LandsraadAdvancedSpaces, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_LandsraadAdvancedSpaces, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x0008726C File Offset: 0x0008546C
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00006521 File Offset: 0x00004721
		public unsafe static string FactionSpaces
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FactionSpaces, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FactionSpaces, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x0008728C File Offset: 0x0008548C
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00006533 File Offset: 0x00004733
		public unsafe static string ConflictArea
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictArea, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictArea, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x000872AC File Offset: 0x000854AC
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00006545 File Offset: 0x00004745
		public unsafe static string ConflictCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictCount, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictCount, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x000872CC File Offset: 0x000854CC
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x00006557 File Offset: 0x00004757
		public unsafe static string ConflictPlayers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictPlayers, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictPlayers, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x000872EC File Offset: 0x000854EC
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x00006569 File Offset: 0x00004769
		public unsafe static string ConflictOpponents
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictOpponents, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictOpponents, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x0008730C File Offset: 0x0008550C
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x0000657B File Offset: 0x0000477B
		public unsafe static string ConflictOpponent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictOpponent, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ConflictOpponent, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x0008732C File Offset: 0x0008552C
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x0000658D File Offset: 0x0000478D
		public unsafe static string FactionTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FactionTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FactionTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x0008734C File Offset: 0x0008554C
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x0000659F File Offset: 0x0000479F
		public unsafe static string ControlMarkers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ControlMarkers, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ControlMarkers, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0008736C File Offset: 0x0008556C
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x000065B1 File Offset: 0x000047B1
		public unsafe static string ExpandedPlayerInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ExpandedPlayerInfo, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ExpandedPlayerInfo, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060009A4 RID: 2468 RVA: 0x0008738C File Offset: 0x0008558C
		// (set) Token: 0x060009A5 RID: 2469 RVA: 0x000065C3 File Offset: 0x000047C3
		public unsafe static string TechNegotiators
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_TechNegotiators, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_TechNegotiators, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x000873AC File Offset: 0x000855AC
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x000065D5 File Offset: 0x000047D5
		public unsafe static string ShippingTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ShippingTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ShippingTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x000873CC File Offset: 0x000855CC
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x000065E7 File Offset: 0x000047E7
		public unsafe static string NegotiatorsHUD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_NegotiatorsHUD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_NegotiatorsHUD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x000873EC File Offset: 0x000855EC
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x000065F9 File Offset: 0x000047F9
		public unsafe static string TechNegotiationSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_TechNegotiationSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_TechNegotiationSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x0008740C File Offset: 0x0008560C
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x0000660B File Offset: 0x0000480B
		public unsafe static string DreadnoughtSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DreadnoughtSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DreadnoughtSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x0008742C File Offset: 0x0008562C
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x0000661D File Offset: 0x0000481D
		public unsafe static string SmugglingSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SmugglingSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SmugglingSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0008744C File Offset: 0x0008564C
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x0000662F File Offset: 0x0000482F
		public unsafe static string InterstellarSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_InterstellarSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_InterstellarSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060009B2 RID: 2482 RVA: 0x0008746C File Offset: 0x0008566C
		// (set) Token: 0x060009B3 RID: 2483 RVA: 0x00006641 File Offset: 0x00004841
		public unsafe static string TechButton
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_TechButton, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_TechButton, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0008748C File Offset: 0x0008568C
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x00006653 File Offset: 0x00004853
		public unsafe static string ResearchTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ResearchTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ResearchTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x000874AC File Offset: 0x000856AC
		// (set) Token: 0x060009B7 RID: 2487 RVA: 0x00006665 File Offset: 0x00004865
		public unsafe static string TleilaxuTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_TleilaxuTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_TleilaxuTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x000874CC File Offset: 0x000856CC
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x00006677 File Offset: 0x00004877
		public unsafe static string TleilaxuRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_TleilaxuRow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_TleilaxuRow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x060009BA RID: 2490 RVA: 0x000874EC File Offset: 0x000856EC
		// (set) Token: 0x060009BB RID: 2491 RVA: 0x00006689 File Offset: 0x00004889
		public unsafe static string Specimens
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_Specimens, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_Specimens, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x0008750C File Offset: 0x0008570C
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x0000669B File Offset: 0x0000489B
		public unsafe static string SpecimensConversion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SpecimensConversion, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SpecimensConversion, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0008752C File Offset: 0x0008572C
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x000066AD File Offset: 0x000048AD
		public unsafe static string FamilyAtomics
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FamilyAtomics, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FamilyAtomics, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x060009C0 RID: 2496 RVA: 0x0008754C File Offset: 0x0008574C
		// (set) Token: 0x060009C1 RID: 2497 RVA: 0x000066BF File Offset: 0x000048BF
		public unsafe static string TrashingCardFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_TrashingCardFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_TrashingCardFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x060009C2 RID: 2498 RVA: 0x0008756C File Offset: 0x0008576C
		// (set) Token: 0x060009C3 RID: 2499 RVA: 0x000066D1 File Offset: 0x000048D1
		public unsafe static string FoldspaceFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FoldspaceFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FoldspaceFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x0008758C File Offset: 0x0008578C
		// (set) Token: 0x060009C5 RID: 2501 RVA: 0x000066E3 File Offset: 0x000048E3
		public unsafe static string FremenBondFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FremenBondFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FremenBondFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x000875AC File Offset: 0x000857AC
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x000066F5 File Offset: 0x000048F5
		public unsafe static string EndgameIntrigueFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_EndgameIntrigueFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_EndgameIntrigueFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x000875CC File Offset: 0x000857CC
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00006707 File Offset: 0x00004907
		public unsafe static string RetreatFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_RetreatFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_RetreatFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x000875EC File Offset: 0x000857EC
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00006719 File Offset: 0x00004919
		public unsafe static string EndgameFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_EndgameFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_EndgameFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x0008760C File Offset: 0x0008580C
		// (set) Token: 0x060009CD RID: 2509 RVA: 0x0000672B File Offset: 0x0000492B
		public unsafe static string ControlBonusFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ControlBonusFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ControlBonusFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0008762C File Offset: 0x0008582C
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x0000673D File Offset: 0x0000493D
		public unsafe static string FactionBonusFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FactionBonusFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FactionBonusFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0008764C File Offset: 0x0008584C
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x0000674F File Offset: 0x0000494F
		public unsafe static string DiscardFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DiscardFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DiscardFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0008766C File Offset: 0x0008586C
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x00006761 File Offset: 0x00004961
		public unsafe static string SpecimenFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SpecimenFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SpecimenFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0008768C File Offset: 0x0008588C
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x00006773 File Offset: 0x00004973
		public unsafe static string GraftFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_GraftFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_GraftFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x000876AC File Offset: 0x000858AC
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x00006785 File Offset: 0x00004985
		public unsafe static string ConditionalIconFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ConditionalIconFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ConditionalIconFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x000876CC File Offset: 0x000858CC
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x00006797 File Offset: 0x00004997
		public unsafe static string TleilaxuFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_TleilaxuFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_TleilaxuFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x000876EC File Offset: 0x000858EC
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x000067A9 File Offset: 0x000049A9
		public unsafe static string GraftRevealFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_GraftRevealFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_GraftRevealFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0008770C File Offset: 0x0008590C
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x000067BB File Offset: 0x000049BB
		public unsafe static string FirstGeneticFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FirstGeneticFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FirstGeneticFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x060009DE RID: 2526 RVA: 0x0008772C File Offset: 0x0008592C
		// (set) Token: 0x060009DF RID: 2527 RVA: 0x000067CD File Offset: 0x000049CD
		public unsafe static string SecondGeneticFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SecondGeneticFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SecondGeneticFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x060009E0 RID: 2528 RVA: 0x0008774C File Offset: 0x0008594C
		// (set) Token: 0x060009E1 RID: 2529 RVA: 0x000067DF File Offset: 0x000049DF
		public unsafe static string HagalImmortalityFTT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_HagalImmortalityFTT, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_HagalImmortalityFTT, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0008776C File Offset: 0x0008596C
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x000067F1 File Offset: 0x000049F1
		public unsafe static string OpenTechRow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_OpenTechRow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_OpenTechRow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060009E4 RID: 2532 RVA: 0x0008778C File Offset: 0x0008598C
		// (set) Token: 0x060009E5 RID: 2533 RVA: 0x00006803 File Offset: 0x00004A03
		public unsafe static string OpenTechTray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_OpenTechTray, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_OpenTechTray, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060009E6 RID: 2534 RVA: 0x000877AC File Offset: 0x000859AC
		// (set) Token: 0x060009E7 RID: 2535 RVA: 0x00006815 File Offset: 0x00004A15
		public unsafe static string TechAnimationFinished
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_TechAnimationFinished, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_TechAnimationFinished, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060009E8 RID: 2536 RVA: 0x000877CC File Offset: 0x000859CC
		// (set) Token: 0x060009E9 RID: 2537 RVA: 0x00006827 File Offset: 0x00004A27
		public unsafe static string SelectFaction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SelectFaction, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SelectFaction, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060009EA RID: 2538 RVA: 0x000877EC File Offset: 0x000859EC
		// (set) Token: 0x060009EB RID: 2539 RVA: 0x00006839 File Offset: 0x00004A39
		public unsafe static string ActivateBuyTech
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ActivateBuyTech, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ActivateBuyTech, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060009EC RID: 2540 RVA: 0x0008780C File Offset: 0x00085A0C
		// (set) Token: 0x060009ED RID: 2541 RVA: 0x0000684B File Offset: 0x00004A4B
		public unsafe static string AbilityRegistered
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_AbilityRegistered, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_AbilityRegistered, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0008782C File Offset: 0x00085A2C
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x0000685D File Offset: 0x00004A5D
		public unsafe static string OpenResearchTrack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_OpenResearchTrack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_OpenResearchTrack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0008784C File Offset: 0x00085A4C
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x0000686F File Offset: 0x00004A6F
		public unsafe static ClientEventResponseID PlayerTurnEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PlayerTurnEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PlayerTurnEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x00087874 File Offset: 0x00085A74
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x00006881 File Offset: 0x00004A81
		public unsafe static ClientEventResponseID AgentToSpaceEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_AgentToSpaceEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_AgentToSpaceEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0008789C File Offset: 0x00085A9C
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x00006893 File Offset: 0x00004A93
		public unsafe static ClientEventResponseID PurchaseGurneyHalleckStartDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseGurneyHalleckStartDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseGurneyHalleckStartDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060009F6 RID: 2550 RVA: 0x000878C4 File Offset: 0x00085AC4
		// (set) Token: 0x060009F7 RID: 2551 RVA: 0x000068A5 File Offset: 0x00004AA5
		public unsafe static ClientEventResponseID PurchaseGurneyHalleckStopDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseGurneyHalleckStopDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseGurneyHalleckStopDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x000878EC File Offset: 0x00085AEC
		// (set) Token: 0x060009F9 RID: 2553 RVA: 0x000068B7 File Offset: 0x00004AB7
		public unsafe static ClientEventResponseID PurchaseThufirStartDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseThufirStartDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseThufirStartDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x00087914 File Offset: 0x00085B14
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x000068C9 File Offset: 0x00004AC9
		public unsafe static ClientEventResponseID PurchaseThufirStopDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseThufirStopDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseThufirStopDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0008793C File Offset: 0x00085B3C
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x000068DB File Offset: 0x00004ADB
		public unsafe static ClientEventResponseID PurchaseDuncanStartDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseDuncanStartDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseDuncanStartDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x00087964 File Offset: 0x00085B64
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x000068ED File Offset: 0x00004AED
		public unsafe static ClientEventResponseID PurchaseDuncanStopDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseDuncanStopDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseDuncanStopDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0008798C File Offset: 0x00085B8C
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x000068FF File Offset: 0x00004AFF
		public unsafe static ClientEventResponseID StartRevealTurnEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_StartRevealTurnEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_StartRevealTurnEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x000879B4 File Offset: 0x00085BB4
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x00006911 File Offset: 0x00004B11
		public unsafe static ClientEventResponseID WhileRevealTurnEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_WhileRevealTurnEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_WhileRevealTurnEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000A04 RID: 2564 RVA: 0x000879DC File Offset: 0x00085BDC
		// (set) Token: 0x06000A05 RID: 2565 RVA: 0x00006923 File Offset: 0x00004B23
		public unsafe static ClientEventResponseID WhileRevealTurnAlreadyOpenEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_WhileRevealTurnAlreadyOpenEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_WhileRevealTurnAlreadyOpenEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00087A04 File Offset: 0x00085C04
		// (set) Token: 0x06000A07 RID: 2567 RVA: 0x00006935 File Offset: 0x00004B35
		public unsafe static ClientEventResponseID FinishTroopSelectionEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FinishTroopSelectionEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FinishTroopSelectionEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000A08 RID: 2568 RVA: 0x00087A2C File Offset: 0x00085C2C
		// (set) Token: 0x06000A09 RID: 2569 RVA: 0x00006947 File Offset: 0x00004B47
		public unsafe static ClientEventResponseID StartTroopSelectionEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_StartTroopSelectionEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_StartTroopSelectionEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000A0A RID: 2570 RVA: 0x00087A54 File Offset: 0x00085C54
		// (set) Token: 0x06000A0B RID: 2571 RVA: 0x00006959 File Offset: 0x00004B59
		public unsafe static ClientEventResponseID WhileConflictPromptEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_WhileConflictPromptEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_WhileConflictPromptEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x00087A7C File Offset: 0x00085C7C
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0000696B File Offset: 0x00004B6B
		public unsafe static ClientEventResponseID DisplayInfluenceSelectionPromptEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DisplayInfluenceSelectionPromptEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DisplayInfluenceSelectionPromptEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000A0E RID: 2574 RVA: 0x00087AA4 File Offset: 0x00085CA4
		// (set) Token: 0x06000A0F RID: 2575 RVA: 0x0000697D File Offset: 0x00004B7D
		public unsafe static ClientEventResponseID PrivateArmyStartDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PrivateArmyStartDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PrivateArmyStartDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00087ACC File Offset: 0x00085CCC
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x0000698F File Offset: 0x00004B8F
		public unsafe static ClientEventResponseID PrivateArmyStopDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PrivateArmyStopDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PrivateArmyStopDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00087AF4 File Offset: 0x00085CF4
		// (set) Token: 0x06000A13 RID: 2579 RVA: 0x000069A1 File Offset: 0x00004BA1
		public unsafe static ClientEventResponseID SelectFremenEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SelectFremenEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SelectFremenEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000A14 RID: 2580 RVA: 0x00087B1C File Offset: 0x00085D1C
		// (set) Token: 0x06000A15 RID: 2581 RVA: 0x000069B3 File Offset: 0x00004BB3
		public unsafe static ClientEventResponseID DisplayCustomChoicePromptEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DisplayCustomChoicePromptEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DisplayCustomChoicePromptEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000A16 RID: 2582 RVA: 0x00087B44 File Offset: 0x00085D44
		// (set) Token: 0x06000A17 RID: 2583 RVA: 0x000069C5 File Offset: 0x00004BC5
		public unsafe static ClientEventResponseID SelectPromptOption0ResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_SelectPromptOption0ResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_SelectPromptOption0ResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000A18 RID: 2584 RVA: 0x00087B6C File Offset: 0x00085D6C
		// (set) Token: 0x06000A19 RID: 2585 RVA: 0x000069D7 File Offset: 0x00004BD7
		public unsafe static ClientEventResponseID RecruitmentMissionStartDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_RecruitmentMissionStartDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_RecruitmentMissionStartDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000A1A RID: 2586 RVA: 0x00087B94 File Offset: 0x00085D94
		// (set) Token: 0x06000A1B RID: 2587 RVA: 0x000069E9 File Offset: 0x00004BE9
		public unsafe static ClientEventResponseID RecruitmentMissionStopDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_RecruitmentMissionStopDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_RecruitmentMissionStopDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x00087BBC File Offset: 0x00085DBC
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x000069FB File Offset: 0x00004BFB
		public unsafe static ClientEventResponseID BuyTechResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_BuyTechResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_BuyTechResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x00087BE4 File Offset: 0x00085DE4
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x00006A0D File Offset: 0x00004C0D
		public unsafe static ClientEventResponseID ActivateBuyTechResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ActivateBuyTechResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ActivateBuyTechResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x00087C0C File Offset: 0x00085E0C
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x00006A1F File Offset: 0x00004C1F
		public unsafe static ClientEventResponseID AbilityRegisteredResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_AbilityRegisteredResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_AbilityRegisteredResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x00087C34 File Offset: 0x00085E34
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00006A31 File Offset: 0x00004C31
		public unsafe static ClientEventResponseID ShippingAbilityRegisteredResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ShippingAbilityRegisteredResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ShippingAbilityRegisteredResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x00087C5C File Offset: 0x00085E5C
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00006A43 File Offset: 0x00004C43
		public unsafe static ClientEventResponseID ShippingAbilityTwoRegisteredResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ShippingAbilityTwoRegisteredResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ShippingAbilityTwoRegisteredResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x00087C84 File Offset: 0x00085E84
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x00006A55 File Offset: 0x00004C55
		public unsafe static ClientEventResponseID ShippingAbilityThreeRegisteredResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_ShippingAbilityThreeRegisteredResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_ShippingAbilityThreeRegisteredResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00087CAC File Offset: 0x00085EAC
		// (set) Token: 0x06000A29 RID: 2601 RVA: 0x00006A67 File Offset: 0x00004C67
		public unsafe static ClientEventResponseID UsedInfluenceAbilityResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_UsedInfluenceAbilityResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_UsedInfluenceAbilityResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00087CD4 File Offset: 0x00085ED4
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x00006A79 File Offset: 0x00004C79
		public unsafe static ClientEventResponseID StartTechDragResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_StartTechDragResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_StartTechDragResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00087CFC File Offset: 0x00085EFC
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x00006A8B File Offset: 0x00004C8B
		public unsafe static ClientEventResponseID OpenResearchTrackResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_OpenResearchTrackResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_OpenResearchTrackResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00087D24 File Offset: 0x00085F24
		// (set) Token: 0x06000A2F RID: 2607 RVA: 0x00006A9D File Offset: 0x00004C9D
		public unsafe static ClientEventResponseID PurchaseContaminatorStartDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseContaminatorStartDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PurchaseContaminatorStartDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x00087D4C File Offset: 0x00085F4C
		// (set) Token: 0x06000A31 RID: 2609 RVA: 0x00006AAF File Offset: 0x00004CAF
		public unsafe static ClientEventResponseID PurchasePlannedCouplingStartDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PurchasePlannedCouplingStartDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PurchasePlannedCouplingStartDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x00087D74 File Offset: 0x00085F74
		// (set) Token: 0x06000A33 RID: 2611 RVA: 0x00006AC1 File Offset: 0x00004CC1
		public unsafe static ClientEventResponseID PurchasePlannedCouplingStopDragEventResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_PurchasePlannedCouplingStopDragEventResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_PurchasePlannedCouplingStopDragEventResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000A34 RID: 2612 RVA: 0x00087D9C File Offset: 0x00085F9C
		// (set) Token: 0x06000A35 RID: 2613 RVA: 0x00006AD3 File Offset: 0x00004CD3
		public unsafe static ClientEventResponseID GraftCardResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_GraftCardResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_GraftCardResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x00087DC4 File Offset: 0x00085FC4
		// (set) Token: 0x06000A37 RID: 2615 RVA: 0x00006AE5 File Offset: 0x00004CE5
		public unsafe static ClientEventResponseID OnTrashAbilityClicked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_OnTrashAbilityClicked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_OnTrashAbilityClicked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06000A38 RID: 2616 RVA: 0x00087DEC File Offset: 0x00085FEC
		// (set) Token: 0x06000A39 RID: 2617 RVA: 0x00006AF7 File Offset: 0x00004CF7
		public unsafe static ClientEventResponseID FremenBondFTTResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_FremenBondFTTResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_FremenBondFTTResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06000A3A RID: 2618 RVA: 0x00087E14 File Offset: 0x00086014
		// (set) Token: 0x06000A3B RID: 2619 RVA: 0x00006B09 File Offset: 0x00004D09
		public unsafe static ClientEventResponseID DiscardFTTResponseID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormTutorialConstants.NativeFieldInfoPtr_DiscardFTTResponseID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormTutorialConstants.NativeFieldInfoPtr_DiscardFTTResponseID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeFieldInfoPtr_IntroMessage;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeFieldInfoPtr_TutorialFinished;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_ButtonOnly;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeFieldInfoPtr_WithLeader;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeFieldInfoPtr_Duncan;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeFieldInfoPtr_Gurney;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeFieldInfoPtr_Leto;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeFieldInfoPtr_Paul;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeFieldInfoPtr_Rabban;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeFieldInfoPtr_Thorvald;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeFieldInfoPtr_Thufir;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeFieldInfoPtr_Stilgar;

		// Token: 0x04000542 RID: 1346
		private static readonly IntPtr NativeFieldInfoPtr_Armand;

		// Token: 0x04000543 RID: 1347
		private static readonly IntPtr NativeFieldInfoPtr_Ilban;

		// Token: 0x04000544 RID: 1348
		private static readonly IntPtr NativeFieldInfoPtr_DisableConflictPlusButton;

		// Token: 0x04000545 RID: 1349
		private static readonly IntPtr NativeFieldInfoPtr_EnableConflictPlusButton;

		// Token: 0x04000546 RID: 1350
		private static readonly IntPtr NativeFieldInfoPtr_DisableConflictMinusButton;

		// Token: 0x04000547 RID: 1351
		private static readonly IntPtr NativeFieldInfoPtr_EnableConflictMinusButton;

		// Token: 0x04000548 RID: 1352
		private static readonly IntPtr NativeFieldInfoPtr_ForceOpenRevealImperiumRow;

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeFieldInfoPtr_CloseImperiumRow;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeFieldInfoPtr_HideCardHinting;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeFieldInfoPtr_ShowCardHinting;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeFieldInfoPtr_GamepadSelect;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeFieldInfoPtr_DisableDeferredAbilities;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeFieldInfoPtr_EnableDeferredAbilities;

		// Token: 0x0400054F RID: 1359
		private static readonly IntPtr NativeFieldInfoPtr_MinimizeTechRow;

		// Token: 0x04000550 RID: 1360
		private static readonly IntPtr NativeFieldInfoPtr_MinimizeTechTray;

		// Token: 0x04000551 RID: 1361
		private static readonly IntPtr NativeFieldInfoPtr_ForceOpenResearchTrack;

		// Token: 0x04000552 RID: 1362
		private static readonly IntPtr NativeFieldInfoPtr_CloseResearchTrack;

		// Token: 0x04000553 RID: 1363
		private static readonly IntPtr NativeFieldInfoPtr_OpenTleilaxuTrack;

		// Token: 0x04000554 RID: 1364
		private static readonly IntPtr NativeFieldInfoPtr_CloseTleilaxuTrack;

		// Token: 0x04000555 RID: 1365
		private static readonly IntPtr NativeFieldInfoPtr_OpenImperiumRow;

		// Token: 0x04000556 RID: 1366
		private static readonly IntPtr NativeFieldInfoPtr_CardMoz;

		// Token: 0x04000557 RID: 1367
		private static readonly IntPtr NativeFieldInfoPtr_Doinker;

		// Token: 0x04000558 RID: 1368
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerBottom;

		// Token: 0x04000559 RID: 1369
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerDrag;

		// Token: 0x0400055A RID: 1370
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerDragIntrigue;

		// Token: 0x0400055B RID: 1371
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerDragLeft;

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr_BottomAligned;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeFieldInfoPtr_CenterAligned;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeFieldInfoPtr_RightAligned;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeFieldInfoPtr_LeftAligned;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr_DuneTheDesertPlanetMoz;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeFieldInfoPtr_ReconnaissanceMoz;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishMoz;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr_SignetRingMoz;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr_GurneyMoz;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr_RecruitmentMissionMoz;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeFieldInfoPtr_PrivateArmyMoz;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeFieldInfoPtr_DisplayLocationName;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeFieldInfoPtr_HideLocationName;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeFieldInfoPtr_ArrowWithLabel;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeFieldInfoPtr_CombatSpaceIcon;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeFieldInfoPtr_CombatSpaceIconMulti;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeFieldInfoPtr_FactionArea;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeFieldInfoPtr_FremenTrack;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeFieldInfoPtr_FremenButton;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeFieldInfoPtr_RecruitmentMissionSecondOption;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeFieldInfoPtr_PromptContinueButton;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeFieldInfoPtr_AgentTurnAbilities;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeFieldInfoPtr_RevealTurnAbilities;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeFieldInfoPtr_ConflictPlusButton;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeFieldInfoPtr_ConflictCurrentStrength;

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxAcquire;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxAgents;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxAgentIcons;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxArrakeenDraw;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxArrakeenTroop;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxCHOAM;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxConflictArea;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxConflictAreaPlayer;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxConflictCurrentStrength;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxConflictRewards;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxConflictResultsReward;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxControlIcon;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxDeck;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxDeckAndDiscard;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxDiscard;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxFirstPlayerMarker;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxHand;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxHUDResources;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxImperiumRow;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxOpponentInfo;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxPlayed;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxPersuasion;

		// Token: 0x0400058B RID: 1419
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxPersuasionCost;

		// Token: 0x0400058C RID: 1420
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxSmallImperiumRow;

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxSpaceCost;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxSpaceAgent;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxResourceIcons;

		// Token: 0x04000590 RID: 1424
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxRevealBoxes;

		// Token: 0x04000591 RID: 1425
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxDaggerRevealBoxes;

		// Token: 0x04000592 RID: 1426
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxTroops;

		// Token: 0x04000593 RID: 1427
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxVP;

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxSwordmasterIcons;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxHighCouncilPersuasion;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxAllianceToken;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxFactionTrack;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxConflictCard;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxConflictCardName;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxSpaceControlIcon;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxConflictThird;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxFactionTrackSpace;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxTSMF;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxReserveRow;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeFieldInfoPtr_DeckDoinker;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeFieldInfoPtr_DiscardDoinker;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeFieldInfoPtr_DiscardRevealDoinker;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeFieldInfoPtr_FoldspaceImperiumMoz;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeFieldInfoPtr_WithClickShield;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeFieldInfoPtr_SpaceHintFlavor;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeFieldInfoPtr_IntrigueHintFlavor;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeFieldInfoPtr_SpaceMoz;

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_SietchTabrMoz;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_FremenBondMoz;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeFieldInfoPtr_PostMakersDelay;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxGarrison;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxSolari;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeFieldInfoPtr_DiscardMoz;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeFieldInfoPtr_HintGraftCards;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerFreighterUp;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerFreighterDown;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerDragTech;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeFieldInfoPtr_DuneTheDesertPlanetReplacementMoz;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeFieldInfoPtr_ExperimentationMoz;

		// Token: 0x040005B3 RID: 1459
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxResearchSpace;

		// Token: 0x040005B4 RID: 1460
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxSpecimens;

		// Token: 0x040005B5 RID: 1461
		private static readonly IntPtr NativeFieldInfoPtr_HighlightArrowTleilaxuTrack;

		// Token: 0x040005B6 RID: 1462
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxTleilaxuSpace;

		// Token: 0x040005B7 RID: 1463
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxSpiceReward;

		// Token: 0x040005B8 RID: 1464
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxTleilaxuRow;

		// Token: 0x040005B9 RID: 1465
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxTleilaxuSlots;

		// Token: 0x040005BA RID: 1466
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxAgentBox;

		// Token: 0x040005BB RID: 1467
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxFirstGeneticAbility;

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxSecondGeneticAbility;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxSpecimenDropArea;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxMarkers1;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxMarkers2;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeFieldInfoPtr_PlannedCouplingMoz;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeFieldInfoPtr_DisguisedBureaucratMoz;

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeFieldInfoPtr_DisableResearchTrack;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeFieldInfoPtr_DisableTleilaxuTrack;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeFieldInfoPtr_EnableTleilaxuTrack;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeFieldInfoPtr_TutorialArrowsOn;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeFieldInfoPtr_TutorialArrowsOff;

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerAbilities;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerTechOffer;

		// Token: 0x040005C9 RID: 1481
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerTechCount;

		// Token: 0x040005CA RID: 1482
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerUndo;

		// Token: 0x040005CB RID: 1483
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerResearchTleilaxuButton;

		// Token: 0x040005CC RID: 1484
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerResearchUp;

		// Token: 0x040005CD RID: 1485
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerResearchDown;

		// Token: 0x040005CE RID: 1486
		private static readonly IntPtr NativeFieldInfoPtr_DoinkerDragReveal;

		// Token: 0x040005CF RID: 1487
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxShipping;

		// Token: 0x040005D0 RID: 1488
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxShippingAndSmuggling;

		// Token: 0x040005D1 RID: 1489
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxFreighterSpaceOne;

		// Token: 0x040005D2 RID: 1490
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxFreighterSpaceThree;

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxWholeSpace;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxDeferredAbility;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxFreighterSpaceThreeRewards;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxTechSpiceCosts;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxTechCount;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxNegotiatorPersuasion;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxNegotiatorTech;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxNegotiatorsHud;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxConflictDreadnought;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxTechOffer;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxConfirmFaction;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeFieldInfoPtr_HighlightBoxChooseFaction;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeFieldInfoPtr_ResearchMarker;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeFieldInfoPtr_SpecimensLabel;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeFieldInfoPtr_AcquireArea;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeFieldInfoPtr_AcquireCost;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeFieldInfoPtr_AcquireEffect;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeFieldInfoPtr_AllianceToken;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeFieldInfoPtr_ArrakeenTroop;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeFieldInfoPtr_ArrakeenDraw;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeFieldInfoPtr_AvailableAgents;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeFieldInfoPtr_BeastAgent;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeFieldInfoPtr_ContextualButton;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeFieldInfoPtr_ConflictContinueButton;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeFieldInfoPtr_ControlSpace;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeFieldInfoPtr_FirstPlayerMarker;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeFieldInfoPtr_OpponentInfo;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeFieldInfoPtr_ResourceCost;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeFieldInfoPtr_RevealDropArea;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeFieldInfoPtr_VictoryPoints;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeFieldInfoPtr_VPReward;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeFieldInfoPtr_FactionTag;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeFieldInfoPtr_SmallImperiumRow;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeFieldInfoPtr_ImperiumRow;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeFieldInfoPtr_BoardShake;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeFieldInfoPtr_FactionBonusLabel;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeFieldInfoPtr_ConvertSpecimen;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_FreighterLabel;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr_PlayerInfo;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr_OpponentPlayerInfo;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeFieldInfoPtr_CityAndDesertSpaces;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeFieldInfoPtr_CHOAMSpaces;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeFieldInfoPtr_LandsraadSpaces;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeFieldInfoPtr_LandsraadAdvancedSpaces;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeFieldInfoPtr_FactionSpaces;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeFieldInfoPtr_ConflictArea;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeFieldInfoPtr_ConflictCount;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeFieldInfoPtr_ConflictPlayers;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeFieldInfoPtr_ConflictOpponents;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_ConflictOpponent;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeFieldInfoPtr_FactionTrack;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeFieldInfoPtr_ControlMarkers;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeFieldInfoPtr_ExpandedPlayerInfo;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeFieldInfoPtr_TechNegotiators;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeFieldInfoPtr_ShippingTrack;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr_NegotiatorsHUD;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeFieldInfoPtr_TechNegotiationSpace;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr_DreadnoughtSpace;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr_SmugglingSpace;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeFieldInfoPtr_InterstellarSpace;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeFieldInfoPtr_TechButton;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeFieldInfoPtr_ResearchTrack;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuTrack;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuRow;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeFieldInfoPtr_Specimens;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeFieldInfoPtr_SpecimensConversion;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeFieldInfoPtr_FamilyAtomics;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeFieldInfoPtr_TrashingCardFTT;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeFieldInfoPtr_FoldspaceFTT;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeFieldInfoPtr_FremenBondFTT;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeFieldInfoPtr_EndgameIntrigueFTT;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeFieldInfoPtr_RetreatFTT;

		// Token: 0x0400061B RID: 1563
		private static readonly IntPtr NativeFieldInfoPtr_EndgameFTT;

		// Token: 0x0400061C RID: 1564
		private static readonly IntPtr NativeFieldInfoPtr_ControlBonusFTT;

		// Token: 0x0400061D RID: 1565
		private static readonly IntPtr NativeFieldInfoPtr_FactionBonusFTT;

		// Token: 0x0400061E RID: 1566
		private static readonly IntPtr NativeFieldInfoPtr_DiscardFTT;

		// Token: 0x0400061F RID: 1567
		private static readonly IntPtr NativeFieldInfoPtr_SpecimenFTT;

		// Token: 0x04000620 RID: 1568
		private static readonly IntPtr NativeFieldInfoPtr_GraftFTT;

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeFieldInfoPtr_ConditionalIconFTT;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeFieldInfoPtr_TleilaxuFTT;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeFieldInfoPtr_GraftRevealFTT;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeFieldInfoPtr_FirstGeneticFTT;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeFieldInfoPtr_SecondGeneticFTT;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeFieldInfoPtr_HagalImmortalityFTT;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeFieldInfoPtr_OpenTechRow;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeFieldInfoPtr_OpenTechTray;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeFieldInfoPtr_TechAnimationFinished;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeFieldInfoPtr_SelectFaction;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeFieldInfoPtr_ActivateBuyTech;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeFieldInfoPtr_AbilityRegistered;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeFieldInfoPtr_OpenResearchTrack;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeFieldInfoPtr_PlayerTurnEventResponseID;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeFieldInfoPtr_AgentToSpaceEventResponseID;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeFieldInfoPtr_PurchaseGurneyHalleckStartDragEventResponseID;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeFieldInfoPtr_PurchaseGurneyHalleckStopDragEventResponseID;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeFieldInfoPtr_PurchaseThufirStartDragEventResponseID;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeFieldInfoPtr_PurchaseThufirStopDragEventResponseID;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr_PurchaseDuncanStartDragEventResponseID;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeFieldInfoPtr_PurchaseDuncanStopDragEventResponseID;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeFieldInfoPtr_StartRevealTurnEventResponseID;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeFieldInfoPtr_WhileRevealTurnEventResponseID;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeFieldInfoPtr_WhileRevealTurnAlreadyOpenEventResponseID;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeFieldInfoPtr_FinishTroopSelectionEventResponseID;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeFieldInfoPtr_StartTroopSelectionEventResponseID;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeFieldInfoPtr_WhileConflictPromptEventResponseID;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeFieldInfoPtr_DisplayInfluenceSelectionPromptEventResponseID;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeFieldInfoPtr_PrivateArmyStartDragEventResponseID;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeFieldInfoPtr_PrivateArmyStopDragEventResponseID;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeFieldInfoPtr_SelectFremenEventResponseID;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeFieldInfoPtr_DisplayCustomChoicePromptEventResponseID;

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeFieldInfoPtr_SelectPromptOption0ResponseID;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr_RecruitmentMissionStartDragEventResponseID;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr_RecruitmentMissionStopDragEventResponseID;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr_BuyTechResponseID;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeFieldInfoPtr_ActivateBuyTechResponseID;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeFieldInfoPtr_AbilityRegisteredResponseID;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeFieldInfoPtr_ShippingAbilityRegisteredResponseID;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeFieldInfoPtr_ShippingAbilityTwoRegisteredResponseID;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeFieldInfoPtr_ShippingAbilityThreeRegisteredResponseID;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeFieldInfoPtr_UsedInfluenceAbilityResponseID;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeFieldInfoPtr_StartTechDragResponseID;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeFieldInfoPtr_OpenResearchTrackResponseID;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeFieldInfoPtr_PurchaseContaminatorStartDragEventResponseID;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeFieldInfoPtr_PurchasePlannedCouplingStartDragEventResponseID;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeFieldInfoPtr_PurchasePlannedCouplingStopDragEventResponseID;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeFieldInfoPtr_GraftCardResponseID;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeFieldInfoPtr_OnTrashAbilityClicked;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeFieldInfoPtr_FremenBondFTTResponseID;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeFieldInfoPtr_DiscardFTTResponseID;
	}
}
