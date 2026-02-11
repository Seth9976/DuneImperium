using System;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using products.rewards;

namespace Canis.attributes
{
	// Token: 0x0200000D RID: 13
	public static class CoreAttributes : Object
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00004B44 File Offset: 0x00002D44
		// Note: this type is marked as 'beforefieldinit'.
		static CoreAttributes()
		{
			Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "CoreAttributes");
			CoreAttributes.NativeFieldInfoPtr_ClientStorageVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ClientStorageVersion");
			CoreAttributes.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "Name");
			CoreAttributes.NativeFieldInfoPtr_Rewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "Rewards");
			CoreAttributes.NativeFieldInfoPtr_AbilityIDAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "AbilityIDAttribute");
			CoreAttributes.NativeFieldInfoPtr_EntityIDAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "EntityIDAttribute");
			CoreAttributes.NativeFieldInfoPtr_MultipleEntityIDsAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "MultipleEntityIDsAttribute");
			CoreAttributes.NativeFieldInfoPtr_ReferencedArchetypeIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ReferencedArchetypeIDs");
			CoreAttributes.NativeFieldInfoPtr_ArchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ArchID");
			CoreAttributes.NativeFieldInfoPtr_ForceSelectionStepOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ForceSelectionStepOne");
			CoreAttributes.NativeFieldInfoPtr_ForceSelectionStepTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ForceSelectionStepTwo");
			CoreAttributes.NativeFieldInfoPtr_FilterSelectionStepOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "FilterSelectionStepOne");
			CoreAttributes.NativeFieldInfoPtr_FilterSelectionStepTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "FilterSelectionStepTwo");
			CoreAttributes.NativeFieldInfoPtr_FilterSelectionStepOneList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "FilterSelectionStepOneList");
			CoreAttributes.NativeFieldInfoPtr_ForceIntChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ForceIntChoice");
			CoreAttributes.NativeFieldInfoPtr_FilterIntChoice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "FilterIntChoice");
			CoreAttributes.NativeFieldInfoPtr_FilterDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "FilterDone");
			CoreAttributes.NativeFieldInfoPtr_ForceDone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ForceDone");
			CoreAttributes.NativeFieldInfoPtr_TutorialScriptType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "TutorialScriptType");
			CoreAttributes.NativeFieldInfoPtr_DialogType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "DialogType");
			CoreAttributes.NativeFieldInfoPtr_Blocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "Blocking");
			CoreAttributes.NativeFieldInfoPtr_TutorialVisualHighlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "TutorialVisualHighlight");
			CoreAttributes.NativeFieldInfoPtr_TutorialID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "TutorialID");
			CoreAttributes.NativeFieldInfoPtr_TutorialEventTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "TutorialEventTriggers");
			CoreAttributes.NativeFieldInfoPtr_SteamID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "SteamID");
			CoreAttributes.NativeFieldInfoPtr_ScreenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ScreenName");
			CoreAttributes.NativeFieldInfoPtr_ScreenNameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ScreenNameID");
			CoreAttributes.NativeFieldInfoPtr_ClientPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ClientPlatform");
			CoreAttributes.NativeFieldInfoPtr_ClientVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ClientVersion");
			CoreAttributes.NativeFieldInfoPtr_AILevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "AILevel");
			CoreAttributes.NativeFieldInfoPtr_GameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "GameText");
			CoreAttributes.NativeFieldInfoPtr_GameTextVars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "GameTextVars");
			CoreAttributes.NativeFieldInfoPtr_AnalyticsGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "AnalyticsGameID");
			CoreAttributes.NativeFieldInfoPtr_TargetEntityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "TargetEntityID");
			CoreAttributes.NativeFieldInfoPtr_TargetEntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "TargetEntityName");
			CoreAttributes.NativeFieldInfoPtr_TargetViewLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "TargetViewLayer");
			CoreAttributes.NativeFieldInfoPtr_AbilityExecutionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "AbilityExecutionState");
			CoreAttributes.NativeFieldInfoPtr_TutorialDisabledActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "TutorialDisabledActions");
			CoreAttributes.NativeFieldInfoPtr_Disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "Disabled");
			CoreAttributes.NativeFieldInfoPtr_TutorialDelayMillis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "TutorialDelayMillis");
			CoreAttributes.NativeFieldInfoPtr_TutorialShowMillis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "TutorialShowMillis");
			CoreAttributes.NativeFieldInfoPtr_WithClickShield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "WithClickShield");
			CoreAttributes.NativeFieldInfoPtr_AbilityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "AbilityIDs");
			CoreAttributes.NativeFieldInfoPtr_CanCancelStepTwo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "CanCancelStepTwo");
			CoreAttributes.NativeFieldInfoPtr_PickerKind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "PickerKind");
			CoreAttributes.NativeFieldInfoPtr_UnusualSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "UnusualSelections");
			CoreAttributes.NativeFieldInfoPtr_TargetHinting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "TargetHinting");
			CoreAttributes.NativeFieldInfoPtr_ObjectiveID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ObjectiveID");
			CoreAttributes.NativeFieldInfoPtr_ObjectiveIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ObjectiveIncrement");
			CoreAttributes.NativeFieldInfoPtr_UnusualSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "UnusualSkip");
			CoreAttributes.NativeFieldInfoPtr_Cheated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "Cheated");
			CoreAttributes.NativeFieldInfoPtr_CustomChoiceFilterByEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "CustomChoiceFilterByEntity");
			CoreAttributes.NativeFieldInfoPtr_FeedbackScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "FeedbackScore");
			CoreAttributes.NativeFieldInfoPtr_CustomChoiceTargetHinting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "CustomChoiceTargetHinting");
			CoreAttributes.NativeFieldInfoPtr_Unparseable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "Unparseable");
			CoreAttributes.NativeFieldInfoPtr_IsOfflineAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "IsOfflineAccount");
			CoreAttributes.NativeFieldInfoPtr_SteamItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "SteamItemID");
			CoreAttributes.NativeFieldInfoPtr_UWPStoreID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "UWPStoreID");
			CoreAttributes.NativeFieldInfoPtr_XBoxStoreID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "XBoxStoreID");
			CoreAttributes.NativeFieldInfoPtr_ProductName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ProductName");
			CoreAttributes.NativeFieldInfoPtr_ProductDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ProductDescription");
			CoreAttributes.NativeFieldInfoPtr_ProductImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ProductImage");
			CoreAttributes.NativeFieldInfoPtr_ProductTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ProductTags");
			CoreAttributes.NativeFieldInfoPtr_ProductPricing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ProductPricing");
			CoreAttributes.NativeFieldInfoPtr_Claimable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "Claimable");
			CoreAttributes.NativeFieldInfoPtr_AITakesPlayerTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "AITakesPlayerTurn");
			CoreAttributes.NativeFieldInfoPtr_PlayerTurnTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "PlayerTurnTimer");
			CoreAttributes.NativeFieldInfoPtr_PlayerTurnTimerPadding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "PlayerTurnTimerPadding");
			CoreAttributes.NativeFieldInfoPtr_PlayerTimeoutAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "PlayerTimeoutAction");
			CoreAttributes.NativeFieldInfoPtr_PlayerActionTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "PlayerActionTimer");
			CoreAttributes.NativeFieldInfoPtr_ReplacedByAIForTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ReplacedByAIForTurn");
			CoreAttributes.NativeFieldInfoPtr_StartedAsAI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "StartedAsAI");
			CoreAttributes.NativeFieldInfoPtr_ShowTimerOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ShowTimerOverride");
			CoreAttributes.NativeFieldInfoPtr_BadSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "BadSelections");
			CoreAttributes.NativeFieldInfoPtr_SelectionStepOneOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "SelectionStepOneOnly");
			CoreAttributes.NativeFieldInfoPtr_SelectionStepTwoOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "SelectionStepTwoOnly");
			CoreAttributes.NativeFieldInfoPtr_CurrentTurnPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "CurrentTurnPlayer");
			CoreAttributes.NativeFieldInfoPtr_CurrentSelectionPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "CurrentSelectionPlayer");
			CoreAttributes.NativeFieldInfoPtr_NonSelectionPromptText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "NonSelectionPromptText");
			CoreAttributes.NativeFieldInfoPtr_DragTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "DragTarget");
			CoreAttributes.NativeFieldInfoPtr_DeferredLeafSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "DeferredLeafSelection");
			CoreAttributes.NativeFieldInfoPtr_Selecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "Selecting");
			CoreAttributes.NativeFieldInfoPtr_VFXTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "VFXTags");
			CoreAttributes.NativeFieldInfoPtr_EntityAnimationSourceOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "EntityAnimationSourceOverrides");
			CoreAttributes.NativeFieldInfoPtr_GenericAnimationSourceOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "GenericAnimationSourceOverrides");
			CoreAttributes.NativeFieldInfoPtr_EntityAnimationDestinationOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "EntityAnimationDestinationOverrides");
			CoreAttributes.NativeFieldInfoPtr_GenericAnimationDestinationOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "GenericAnimationDestinationOverrides");
			CoreAttributes.NativeFieldInfoPtr_VfxSequenceNameOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "VfxSequenceNameOverrides");
			CoreAttributes.NativeFieldInfoPtr_PlatformVFXTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "PlatformVFXTags");
			CoreAttributes.NativeFieldInfoPtr_IAPOfferID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "IAPOfferID");
			CoreAttributes.NativeFieldInfoPtr_IABOfferID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "IABOfferID");
			CoreAttributes.NativeFieldInfoPtr_NintendoItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "NintendoItemID");
			CoreAttributes.NativeFieldInfoPtr_ActiveAbilityState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ActiveAbilityState");
			CoreAttributes.NativeFieldInfoPtr_ActiveAbilityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ActiveAbilityIndex");
			CoreAttributes.NativeFieldInfoPtr_SkipSelectedCosts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "SkipSelectedCosts");
			CoreAttributes.NativeFieldInfoPtr_ActiveAbilitySucceeded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ActiveAbilitySucceeded");
			CoreAttributes.NativeFieldInfoPtr_AbilityRollbackQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "AbilityRollbackQueue");
			CoreAttributes.NativeFieldInfoPtr_MayCancelAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "MayCancelAbility");
			CoreAttributes.NativeFieldInfoPtr_ParentAbilityExecutionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "ParentAbilityExecutionState");
			CoreAttributes.NativeFieldInfoPtr_NumChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "NumChildren");
			CoreAttributes.NativeFieldInfoPtr_StartingCameraAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "StartingCameraAnchor");
			CoreAttributes.NativeFieldInfoPtr_SkipCameraIntro = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "SkipCameraIntro");
			CoreAttributes.NativeFieldInfoPtr_CurrentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "CurrentIndex");
			CoreAttributes.NativeFieldInfoPtr_SkirmishScoringMethods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "SkirmishScoringMethods");
			CoreAttributes.NativeFieldInfoPtr_SkirmishRuleMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "SkirmishRuleMods");
			CoreAttributes.NativeFieldInfoPtr_SequenceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "SequenceID");
			CoreAttributes.NativeFieldInfoPtr_PositionInParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "PositionInParent");
			CoreAttributes.NativeFieldInfoPtr_MultipartSelectionCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "MultipartSelectionCount");
			CoreAttributes.NativeFieldInfoPtr_EventID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "EventID");
			CoreAttributes.NativeFieldInfoPtr_RoundID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "RoundID");
			CoreAttributes.NativeFieldInfoPtr_Ranked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "Ranked");
			CoreAttributes.NativeFieldInfoPtr_FinalPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "FinalPosition");
			CoreAttributes.NativeFieldInfoPtr_RequiredTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "RequiredTutorial");
			CoreAttributes.NativeFieldInfoPtr_FirstTimeTriggerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, "FirstTimeTriggerID");
			CoreAttributes.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoreAttributes>.NativeClassPtr, 100663343);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00005454 File Offset: 0x00003654
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoreAttributes.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002228 File Offset: 0x00000428
		public CoreAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000547C File Offset: 0x0000367C
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002231 File Offset: 0x00000431
		public unsafe static AttributeDefinition<Nullable<int>> ClientStorageVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ClientStorageVersion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ClientStorageVersion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000054A4 File Offset: 0x000036A4
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002243 File Offset: 0x00000443
		public unsafe static AttributeDefinition<LocalizableText> Name
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_Name, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_Name, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000054CC File Offset: 0x000036CC
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002255 File Offset: 0x00000455
		public unsafe static AttributeDefinition<Il2CppReferenceArray<RewardDefinition>> Rewards
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_Rewards, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Il2CppReferenceArray<RewardDefinition>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_Rewards, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000054F4 File Offset: 0x000036F4
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002267 File Offset: 0x00000467
		public unsafe static AttributeDefinition<AbilityID> AbilityIDAttribute
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_AbilityIDAttribute, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<AbilityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_AbilityIDAttribute, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000551C File Offset: 0x0000371C
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002279 File Offset: 0x00000479
		public unsafe static AttributeDefinition<EntityID> EntityIDAttribute
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_EntityIDAttribute, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_EntityIDAttribute, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00005544 File Offset: 0x00003744
		// (set) Token: 0x06000065 RID: 101 RVA: 0x0000228B File Offset: 0x0000048B
		public unsafe static AttributeDefinition<List<EntityID>> MultipleEntityIDsAttribute
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_MultipleEntityIDsAttribute, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_MultipleEntityIDsAttribute, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000556C File Offset: 0x0000376C
		// (set) Token: 0x06000067 RID: 103 RVA: 0x0000229D File Offset: 0x0000049D
		public unsafe static AttributeDefinition<Il2CppReferenceArray<ArchetypeID>> ReferencedArchetypeIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ReferencedArchetypeIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Il2CppReferenceArray<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ReferencedArchetypeIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00005594 File Offset: 0x00003794
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000022AF File Offset: 0x000004AF
		public unsafe static AttributeDefinition<ArchetypeID> ArchID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ArchID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ArchID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006A RID: 106 RVA: 0x000055BC File Offset: 0x000037BC
		// (set) Token: 0x0600006B RID: 107 RVA: 0x000022C1 File Offset: 0x000004C1
		public unsafe static AttributeDefinition<EntityID> ForceSelectionStepOne
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ForceSelectionStepOne, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ForceSelectionStepOne, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000055E4 File Offset: 0x000037E4
		// (set) Token: 0x0600006D RID: 109 RVA: 0x000022D3 File Offset: 0x000004D3
		public unsafe static AttributeDefinition<EntityID> ForceSelectionStepTwo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ForceSelectionStepTwo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ForceSelectionStepTwo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000560C File Offset: 0x0000380C
		// (set) Token: 0x0600006F RID: 111 RVA: 0x000022E5 File Offset: 0x000004E5
		public unsafe static AttributeDefinition<EntityID> FilterSelectionStepOne
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_FilterSelectionStepOne, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_FilterSelectionStepOne, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00005634 File Offset: 0x00003834
		// (set) Token: 0x06000071 RID: 113 RVA: 0x000022F7 File Offset: 0x000004F7
		public unsafe static AttributeDefinition<EntityID> FilterSelectionStepTwo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_FilterSelectionStepTwo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_FilterSelectionStepTwo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000565C File Offset: 0x0000385C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002309 File Offset: 0x00000509
		public unsafe static AttributeDefinition<List<EntityID>> FilterSelectionStepOneList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_FilterSelectionStepOneList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_FilterSelectionStepOneList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00005684 File Offset: 0x00003884
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000231B File Offset: 0x0000051B
		public unsafe static AttributeDefinition<Nullable<int>> ForceIntChoice
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ForceIntChoice, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ForceIntChoice, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000056AC File Offset: 0x000038AC
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000232D File Offset: 0x0000052D
		public unsafe static AttributeDefinition<Nullable<int>> FilterIntChoice
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_FilterIntChoice, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_FilterIntChoice, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000056D4 File Offset: 0x000038D4
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000233F File Offset: 0x0000053F
		public unsafe static AttributeDefinition<Nullable<bool>> FilterDone
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_FilterDone, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_FilterDone, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000056FC File Offset: 0x000038FC
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002351 File Offset: 0x00000551
		public unsafe static AttributeDefinition<Nullable<bool>> ForceDone
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ForceDone, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ForceDone, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00005724 File Offset: 0x00003924
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00002363 File Offset: 0x00000563
		public unsafe static AttributeDefinition<string> TutorialScriptType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_TutorialScriptType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_TutorialScriptType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000574C File Offset: 0x0000394C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x00002375 File Offset: 0x00000575
		public unsafe static AttributeDefinition<string> DialogType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_DialogType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_DialogType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00005774 File Offset: 0x00003974
		// (set) Token: 0x06000081 RID: 129 RVA: 0x00002387 File Offset: 0x00000587
		public unsafe static AttributeDefinition<Nullable<bool>> Blocking
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_Blocking, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_Blocking, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000579C File Offset: 0x0000399C
		// (set) Token: 0x06000083 RID: 131 RVA: 0x00002399 File Offset: 0x00000599
		public unsafe static AttributeDefinition<string> TutorialVisualHighlight
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_TutorialVisualHighlight, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_TutorialVisualHighlight, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000057C4 File Offset: 0x000039C4
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000023AB File Offset: 0x000005AB
		public unsafe static AttributeDefinition<Nullable<int>> TutorialID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_TutorialID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_TutorialID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000057EC File Offset: 0x000039EC
		// (set) Token: 0x06000087 RID: 135 RVA: 0x000023BD File Offset: 0x000005BD
		public unsafe static AttributeDefinition<List<int>> TutorialEventTriggers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_TutorialEventTriggers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_TutorialEventTriggers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00005814 File Offset: 0x00003A14
		// (set) Token: 0x06000089 RID: 137 RVA: 0x000023CF File Offset: 0x000005CF
		public unsafe static AttributeDefinition<string> SteamID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_SteamID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_SteamID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000583C File Offset: 0x00003A3C
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000023E1 File Offset: 0x000005E1
		public unsafe static AttributeDefinition<string> ScreenName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ScreenName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ScreenName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00005864 File Offset: 0x00003A64
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000023F3 File Offset: 0x000005F3
		public unsafe static AttributeDefinition<string> ScreenNameID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ScreenNameID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ScreenNameID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008E RID: 142 RVA: 0x0000588C File Offset: 0x00003A8C
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00002405 File Offset: 0x00000605
		public unsafe static AttributeDefinition<string> ClientPlatform
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ClientPlatform, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ClientPlatform, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000090 RID: 144 RVA: 0x000058B4 File Offset: 0x00003AB4
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002417 File Offset: 0x00000617
		public unsafe static AttributeDefinition<string> ClientVersion
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ClientVersion, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ClientVersion, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000058DC File Offset: 0x00003ADC
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002429 File Offset: 0x00000629
		public unsafe static AttributeDefinition<Nullable<int>> AILevel
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_AILevel, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_AILevel, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00005904 File Offset: 0x00003B04
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000243B File Offset: 0x0000063B
		public unsafe static AttributeDefinition<LocalizableText> GameText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_GameText, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_GameText, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000096 RID: 150 RVA: 0x0000592C File Offset: 0x00003B2C
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000244D File Offset: 0x0000064D
		public unsafe static AttributeDefinition<LocalizableTextVariables> GameTextVars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_GameTextVars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableTextVariables>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_GameTextVars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00005954 File Offset: 0x00003B54
		// (set) Token: 0x06000099 RID: 153 RVA: 0x0000245F File Offset: 0x0000065F
		public unsafe static AttributeDefinition<GameID> AnalyticsGameID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_AnalyticsGameID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<GameID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_AnalyticsGameID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000597C File Offset: 0x00003B7C
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00002471 File Offset: 0x00000671
		public unsafe static AttributeDefinition<EntityID> TargetEntityID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_TargetEntityID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_TargetEntityID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600009C RID: 156 RVA: 0x000059A4 File Offset: 0x00003BA4
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00002483 File Offset: 0x00000683
		public unsafe static AttributeDefinition<string> TargetEntityName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_TargetEntityName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_TargetEntityName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000059CC File Offset: 0x00003BCC
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00002495 File Offset: 0x00000695
		public unsafe static AttributeDefinition<Nullable<int>> TargetViewLayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_TargetViewLayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_TargetViewLayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000059F4 File Offset: 0x00003BF4
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x000024A7 File Offset: 0x000006A7
		public unsafe static AttributeDefinition<Nullable<int>> AbilityExecutionState
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_AbilityExecutionState, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_AbilityExecutionState, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00005A1C File Offset: 0x00003C1C
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000024B9 File Offset: 0x000006B9
		public unsafe static AttributeDefinition<List<string>> TutorialDisabledActions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_TutorialDisabledActions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_TutorialDisabledActions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00005A44 File Offset: 0x00003C44
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000024CB File Offset: 0x000006CB
		public unsafe static AttributeDefinition<Nullable<bool>> Disabled
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_Disabled, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_Disabled, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00005A6C File Offset: 0x00003C6C
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000024DD File Offset: 0x000006DD
		public unsafe static AttributeDefinition<Nullable<int>> TutorialDelayMillis
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_TutorialDelayMillis, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_TutorialDelayMillis, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00005A94 File Offset: 0x00003C94
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000024EF File Offset: 0x000006EF
		public unsafe static AttributeDefinition<Nullable<int>> TutorialShowMillis
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_TutorialShowMillis, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_TutorialShowMillis, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00005ABC File Offset: 0x00003CBC
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00002501 File Offset: 0x00000701
		public unsafe static AttributeDefinition<Nullable<bool>> WithClickShield
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_WithClickShield, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_WithClickShield, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00005AE4 File Offset: 0x00003CE4
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00002513 File Offset: 0x00000713
		public unsafe static AttributeDefinition<List<AbilityID>> AbilityIDs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_AbilityIDs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<AbilityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_AbilityIDs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00005B0C File Offset: 0x00003D0C
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002525 File Offset: 0x00000725
		public unsafe static AttributeDefinition<Nullable<bool>> CanCancelStepTwo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_CanCancelStepTwo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_CanCancelStepTwo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00005B34 File Offset: 0x00003D34
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002537 File Offset: 0x00000737
		public unsafe static AttributeDefinition<string> PickerKind
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_PickerKind, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_PickerKind, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00005B5C File Offset: 0x00003D5C
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002549 File Offset: 0x00000749
		public unsafe static AttributeDefinition<Dictionary<LocalizableTextVariables, List<EntityID>>> UnusualSelections
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_UnusualSelections, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<LocalizableTextVariables, List<EntityID>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_UnusualSelections, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00005B84 File Offset: 0x00003D84
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000255B File Offset: 0x0000075B
		public unsafe static AttributeDefinition<Dictionary<EntityID, ReadOnlyAttributes>> TargetHinting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_TargetHinting, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<EntityID, ReadOnlyAttributes>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_TargetHinting, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00005BAC File Offset: 0x00003DAC
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000256D File Offset: 0x0000076D
		public unsafe static AttributeDefinition<Nullable<int>> ObjectiveID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ObjectiveID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ObjectiveID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00005BD4 File Offset: 0x00003DD4
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000257F File Offset: 0x0000077F
		public unsafe static AttributeDefinition<Nullable<int>> ObjectiveIncrement
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ObjectiveIncrement, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ObjectiveIncrement, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00005BFC File Offset: 0x00003DFC
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00002591 File Offset: 0x00000791
		public unsafe static AttributeDefinition<LocalizableTextVariables> UnusualSkip
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_UnusualSkip, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableTextVariables>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_UnusualSkip, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00005C24 File Offset: 0x00003E24
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000025A3 File Offset: 0x000007A3
		public unsafe static AttributeDefinition<Nullable<bool>> Cheated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_Cheated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_Cheated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00005C4C File Offset: 0x00003E4C
		// (set) Token: 0x060000BF RID: 191 RVA: 0x000025B5 File Offset: 0x000007B5
		public unsafe static AttributeDefinition<Dictionary<EntityID, Il2CppStructArray<int>>> CustomChoiceFilterByEntity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_CustomChoiceFilterByEntity, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<EntityID, Il2CppStructArray<int>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_CustomChoiceFilterByEntity, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00005C74 File Offset: 0x00003E74
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000025C7 File Offset: 0x000007C7
		public unsafe static AttributeDefinition<Nullable<int>> FeedbackScore
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_FeedbackScore, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_FeedbackScore, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00005C9C File Offset: 0x00003E9C
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000025D9 File Offset: 0x000007D9
		public unsafe static AttributeDefinition<Dictionary<int, ReadOnlyAttributes>> CustomChoiceTargetHinting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_CustomChoiceTargetHinting, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<int, ReadOnlyAttributes>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_CustomChoiceTargetHinting, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00005CC4 File Offset: 0x00003EC4
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000025EB File Offset: 0x000007EB
		public unsafe static AttributeDefinition<Nullable<bool>> Unparseable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_Unparseable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_Unparseable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00005CEC File Offset: 0x00003EEC
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x000025FD File Offset: 0x000007FD
		public unsafe static AttributeDefinition<Nullable<bool>> IsOfflineAccount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_IsOfflineAccount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_IsOfflineAccount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00005D14 File Offset: 0x00003F14
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000260F File Offset: 0x0000080F
		public unsafe static AttributeDefinition<Nullable<int>> SteamItemID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_SteamItemID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_SteamItemID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00005D3C File Offset: 0x00003F3C
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00002621 File Offset: 0x00000821
		public unsafe static AttributeDefinition<string> UWPStoreID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_UWPStoreID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_UWPStoreID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00005D64 File Offset: 0x00003F64
		// (set) Token: 0x060000CD RID: 205 RVA: 0x00002633 File Offset: 0x00000833
		public unsafe static AttributeDefinition<string> XBoxStoreID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_XBoxStoreID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_XBoxStoreID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00005D8C File Offset: 0x00003F8C
		// (set) Token: 0x060000CF RID: 207 RVA: 0x00002645 File Offset: 0x00000845
		public unsafe static AttributeDefinition<LocalizableText> ProductName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ProductName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ProductName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005DB4 File Offset: 0x00003FB4
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002657 File Offset: 0x00000857
		public unsafe static AttributeDefinition<LocalizableText> ProductDescription
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ProductDescription, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ProductDescription, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00005DDC File Offset: 0x00003FDC
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002669 File Offset: 0x00000869
		public unsafe static AttributeDefinition<string> ProductImage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ProductImage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ProductImage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00005E04 File Offset: 0x00004004
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000267B File Offset: 0x0000087B
		public unsafe static AttributeDefinition<List<string>> ProductTags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ProductTags, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ProductTags, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00005E2C File Offset: 0x0000402C
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000268D File Offset: 0x0000088D
		public unsafe static AttributeDefinition<Dictionary<string, int>> ProductPricing
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ProductPricing, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<string, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ProductPricing, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x00005E54 File Offset: 0x00004054
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000269F File Offset: 0x0000089F
		public unsafe static AttributeDefinition<Nullable<bool>> Claimable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_Claimable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_Claimable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00005E7C File Offset: 0x0000407C
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000026B1 File Offset: 0x000008B1
		public unsafe static AttributeDefinition<Nullable<bool>> AITakesPlayerTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_AITakesPlayerTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_AITakesPlayerTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00005EA4 File Offset: 0x000040A4
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000026C3 File Offset: 0x000008C3
		public unsafe static AttributeDefinition<Nullable<int>> PlayerTurnTimer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_PlayerTurnTimer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_PlayerTurnTimer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000DE RID: 222 RVA: 0x00005ECC File Offset: 0x000040CC
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000026D5 File Offset: 0x000008D5
		public unsafe static AttributeDefinition<Nullable<int>> PlayerTurnTimerPadding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_PlayerTurnTimerPadding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_PlayerTurnTimerPadding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00005EF4 File Offset: 0x000040F4
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x000026E7 File Offset: 0x000008E7
		public unsafe static AttributeDefinition<Nullable<bool>> PlayerTimeoutAction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_PlayerTimeoutAction, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_PlayerTimeoutAction, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00005F1C File Offset: 0x0000411C
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x000026F9 File Offset: 0x000008F9
		public unsafe static AttributeDefinition<Nullable<int>> PlayerActionTimer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_PlayerActionTimer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_PlayerActionTimer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x00005F44 File Offset: 0x00004144
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000270B File Offset: 0x0000090B
		public unsafe static AttributeDefinition<Nullable<bool>> ReplacedByAIForTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ReplacedByAIForTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ReplacedByAIForTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00005F6C File Offset: 0x0000416C
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000271D File Offset: 0x0000091D
		public unsafe static AttributeDefinition<Nullable<bool>> StartedAsAI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_StartedAsAI, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_StartedAsAI, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005F94 File Offset: 0x00004194
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000272F File Offset: 0x0000092F
		public unsafe static AttributeDefinition<Nullable<int>> ShowTimerOverride
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ShowTimerOverride, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ShowTimerOverride, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00005FBC File Offset: 0x000041BC
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00002741 File Offset: 0x00000941
		public unsafe static AttributeDefinition<Nullable<int>> BadSelections
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_BadSelections, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_BadSelections, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00005FE4 File Offset: 0x000041E4
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002753 File Offset: 0x00000953
		public unsafe static AttributeDefinition<Nullable<bool>> SelectionStepOneOnly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_SelectionStepOneOnly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_SelectionStepOneOnly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000600C File Offset: 0x0000420C
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002765 File Offset: 0x00000965
		public unsafe static AttributeDefinition<Nullable<bool>> SelectionStepTwoOnly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_SelectionStepTwoOnly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_SelectionStepTwoOnly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00006034 File Offset: 0x00004234
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002777 File Offset: 0x00000977
		public unsafe static AttributeDefinition<AccountID> CurrentTurnPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_CurrentTurnPlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<AccountID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_CurrentTurnPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000605C File Offset: 0x0000425C
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002789 File Offset: 0x00000989
		public unsafe static AttributeDefinition<AccountID> CurrentSelectionPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_CurrentSelectionPlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<AccountID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_CurrentSelectionPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00006084 File Offset: 0x00004284
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x0000279B File Offset: 0x0000099B
		public unsafe static AttributeDefinition<LocalizableTextVariables> NonSelectionPromptText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_NonSelectionPromptText, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableTextVariables>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_NonSelectionPromptText, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x000060AC File Offset: 0x000042AC
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x000027AD File Offset: 0x000009AD
		public unsafe static AttributeDefinition<List<EntityID>> DragTarget
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_DragTarget, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_DragTarget, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x000060D4 File Offset: 0x000042D4
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x000027BF File Offset: 0x000009BF
		public unsafe static AttributeDefinition<Nullable<bool>> DeferredLeafSelection
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_DeferredLeafSelection, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_DeferredLeafSelection, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000060FC File Offset: 0x000042FC
		// (set) Token: 0x060000FB RID: 251 RVA: 0x000027D1 File Offset: 0x000009D1
		public unsafe static AttributeDefinition<Nullable<bool>> Selecting
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_Selecting, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_Selecting, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000FC RID: 252 RVA: 0x00006124 File Offset: 0x00004324
		// (set) Token: 0x060000FD RID: 253 RVA: 0x000027E3 File Offset: 0x000009E3
		public unsafe static AttributeDefinition<List<string>> VFXTags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_VFXTags, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_VFXTags, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000614C File Offset: 0x0000434C
		// (set) Token: 0x060000FF RID: 255 RVA: 0x000027F5 File Offset: 0x000009F5
		public unsafe static AttributeDefinition<Dictionary<EntityID, EntityID>> EntityAnimationSourceOverrides
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_EntityAnimationSourceOverrides, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<EntityID, EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_EntityAnimationSourceOverrides, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00006174 File Offset: 0x00004374
		// (set) Token: 0x06000101 RID: 257 RVA: 0x00002807 File Offset: 0x00000A07
		public unsafe static AttributeDefinition<Dictionary<EntityID, string>> GenericAnimationSourceOverrides
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_GenericAnimationSourceOverrides, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<EntityID, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_GenericAnimationSourceOverrides, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000619C File Offset: 0x0000439C
		// (set) Token: 0x06000103 RID: 259 RVA: 0x00002819 File Offset: 0x00000A19
		public unsafe static AttributeDefinition<Dictionary<EntityID, EntityID>> EntityAnimationDestinationOverrides
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_EntityAnimationDestinationOverrides, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<EntityID, EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_EntityAnimationDestinationOverrides, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000104 RID: 260 RVA: 0x000061C4 File Offset: 0x000043C4
		// (set) Token: 0x06000105 RID: 261 RVA: 0x0000282B File Offset: 0x00000A2B
		public unsafe static AttributeDefinition<Dictionary<EntityID, string>> GenericAnimationDestinationOverrides
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_GenericAnimationDestinationOverrides, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<EntityID, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_GenericAnimationDestinationOverrides, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000106 RID: 262 RVA: 0x000061EC File Offset: 0x000043EC
		// (set) Token: 0x06000107 RID: 263 RVA: 0x0000283D File Offset: 0x00000A3D
		public unsafe static AttributeDefinition<Dictionary<EntityID, string>> VfxSequenceNameOverrides
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_VfxSequenceNameOverrides, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<EntityID, string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_VfxSequenceNameOverrides, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00006214 File Offset: 0x00004414
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0000284F File Offset: 0x00000A4F
		public unsafe static AttributeDefinition<Dictionary<string, Il2CppStringArray>> PlatformVFXTags
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_PlatformVFXTags, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<string, Il2CppStringArray>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_PlatformVFXTags, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000623C File Offset: 0x0000443C
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002861 File Offset: 0x00000A61
		public unsafe static AttributeDefinition<string> IAPOfferID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_IAPOfferID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_IAPOfferID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00006264 File Offset: 0x00004464
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002873 File Offset: 0x00000A73
		public unsafe static AttributeDefinition<string> IABOfferID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_IABOfferID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_IABOfferID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000628C File Offset: 0x0000448C
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00002885 File Offset: 0x00000A85
		public unsafe static AttributeDefinition<string> NintendoItemID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_NintendoItemID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_NintendoItemID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000110 RID: 272 RVA: 0x000062B4 File Offset: 0x000044B4
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00002897 File Offset: 0x00000A97
		public unsafe static AttributeDefinition<Nullable<int>> ActiveAbilityState
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ActiveAbilityState, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ActiveAbilityState, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000062DC File Offset: 0x000044DC
		// (set) Token: 0x06000113 RID: 275 RVA: 0x000028A9 File Offset: 0x00000AA9
		public unsafe static AttributeDefinition<Nullable<int>> ActiveAbilityIndex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ActiveAbilityIndex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ActiveAbilityIndex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00006304 File Offset: 0x00004504
		// (set) Token: 0x06000115 RID: 277 RVA: 0x000028BB File Offset: 0x00000ABB
		public unsafe static AttributeDefinition<Nullable<bool>> SkipSelectedCosts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_SkipSelectedCosts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_SkipSelectedCosts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000632C File Offset: 0x0000452C
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000028CD File Offset: 0x00000ACD
		public unsafe static AttributeDefinition<Nullable<bool>> ActiveAbilitySucceeded
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ActiveAbilitySucceeded, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ActiveAbilitySucceeded, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000118 RID: 280 RVA: 0x00006354 File Offset: 0x00004554
		// (set) Token: 0x06000119 RID: 281 RVA: 0x000028DF File Offset: 0x00000ADF
		public unsafe static AttributeDefinition<List<int>> AbilityRollbackQueue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_AbilityRollbackQueue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_AbilityRollbackQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000637C File Offset: 0x0000457C
		// (set) Token: 0x0600011B RID: 283 RVA: 0x000028F1 File Offset: 0x00000AF1
		public unsafe static AttributeDefinition<Nullable<bool>> MayCancelAbility
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_MayCancelAbility, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_MayCancelAbility, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600011C RID: 284 RVA: 0x000063A4 File Offset: 0x000045A4
		// (set) Token: 0x0600011D RID: 285 RVA: 0x00002903 File Offset: 0x00000B03
		public unsafe static AttributeDefinition<Nullable<int>> ParentAbilityExecutionState
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_ParentAbilityExecutionState, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_ParentAbilityExecutionState, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600011E RID: 286 RVA: 0x000063CC File Offset: 0x000045CC
		// (set) Token: 0x0600011F RID: 287 RVA: 0x00002915 File Offset: 0x00000B15
		public unsafe static AttributeDefinition<Nullable<int>> NumChildren
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_NumChildren, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_NumChildren, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000120 RID: 288 RVA: 0x000063F4 File Offset: 0x000045F4
		// (set) Token: 0x06000121 RID: 289 RVA: 0x00002927 File Offset: 0x00000B27
		public unsafe static AttributeDefinition<string> StartingCameraAnchor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_StartingCameraAnchor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_StartingCameraAnchor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000641C File Offset: 0x0000461C
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00002939 File Offset: 0x00000B39
		public unsafe static AttributeDefinition<Nullable<bool>> SkipCameraIntro
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_SkipCameraIntro, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_SkipCameraIntro, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00006444 File Offset: 0x00004644
		// (set) Token: 0x06000125 RID: 293 RVA: 0x0000294B File Offset: 0x00000B4B
		public unsafe static AttributeDefinition<Nullable<int>> CurrentIndex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_CurrentIndex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_CurrentIndex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000646C File Offset: 0x0000466C
		// (set) Token: 0x06000127 RID: 295 RVA: 0x0000295D File Offset: 0x00000B5D
		public unsafe static AttributeDefinition<List<int>> SkirmishScoringMethods
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_SkirmishScoringMethods, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_SkirmishScoringMethods, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00006494 File Offset: 0x00004694
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0000296F File Offset: 0x00000B6F
		public unsafe static AttributeDefinition<List<int>> SkirmishRuleMods
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_SkirmishRuleMods, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_SkirmishRuleMods, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000064BC File Offset: 0x000046BC
		// (set) Token: 0x0600012B RID: 299 RVA: 0x00002981 File Offset: 0x00000B81
		public unsafe static AttributeDefinition<SequenceID> SequenceID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_SequenceID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<SequenceID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_SequenceID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600012C RID: 300 RVA: 0x000064E4 File Offset: 0x000046E4
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00002993 File Offset: 0x00000B93
		public unsafe static AttributeDefinition<Nullable<int>> PositionInParent
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_PositionInParent, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_PositionInParent, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0000650C File Offset: 0x0000470C
		// (set) Token: 0x0600012F RID: 303 RVA: 0x000029A5 File Offset: 0x00000BA5
		public unsafe static AttributeDefinition<Nullable<int>> MultipartSelectionCount
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_MultipartSelectionCount, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_MultipartSelectionCount, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00006534 File Offset: 0x00004734
		// (set) Token: 0x06000131 RID: 305 RVA: 0x000029B7 File Offset: 0x00000BB7
		public unsafe static AttributeDefinition<EventID> EventID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_EventID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EventID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_EventID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000132 RID: 306 RVA: 0x0000655C File Offset: 0x0000475C
		// (set) Token: 0x06000133 RID: 307 RVA: 0x000029C9 File Offset: 0x00000BC9
		public unsafe static AttributeDefinition<RoundID> RoundID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_RoundID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<RoundID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_RoundID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00006584 File Offset: 0x00004784
		// (set) Token: 0x06000135 RID: 309 RVA: 0x000029DB File Offset: 0x00000BDB
		public unsafe static AttributeDefinition<Nullable<bool>> Ranked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_Ranked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_Ranked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000136 RID: 310 RVA: 0x000065AC File Offset: 0x000047AC
		// (set) Token: 0x06000137 RID: 311 RVA: 0x000029ED File Offset: 0x00000BED
		public unsafe static AttributeDefinition<Nullable<int>> FinalPosition
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_FinalPosition, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_FinalPosition, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000138 RID: 312 RVA: 0x000065D4 File Offset: 0x000047D4
		// (set) Token: 0x06000139 RID: 313 RVA: 0x000029FF File Offset: 0x00000BFF
		public unsafe static AttributeDefinition<string> RequiredTutorial
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_RequiredTutorial, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_RequiredTutorial, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000065FC File Offset: 0x000047FC
		// (set) Token: 0x0600013B RID: 315 RVA: 0x00002A11 File Offset: 0x00000C11
		public unsafe static AttributeDefinition<string> FirstTimeTriggerID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoreAttributes.NativeFieldInfoPtr_FirstTimeTriggerID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoreAttributes.NativeFieldInfoPtr_FirstTimeTriggerID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_ClientStorageVersion;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_Rewards;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_AbilityIDAttribute;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_EntityIDAttribute;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_MultipleEntityIDsAttribute;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_ReferencedArchetypeIDs;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_ArchID;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_ForceSelectionStepOne;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_ForceSelectionStepTwo;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_FilterSelectionStepOne;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_FilterSelectionStepTwo;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_FilterSelectionStepOneList;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_ForceIntChoice;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_FilterIntChoice;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_FilterDone;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_ForceDone;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_TutorialScriptType;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_DialogType;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_Blocking;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_TutorialVisualHighlight;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_TutorialID;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr_TutorialEventTriggers;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr_SteamID;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr_ScreenName;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeFieldInfoPtr_ScreenNameID;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeFieldInfoPtr_ClientPlatform;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeFieldInfoPtr_ClientVersion;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeFieldInfoPtr_AILevel;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeFieldInfoPtr_GameText;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_GameTextVars;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_AnalyticsGameID;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_TargetEntityID;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_TargetEntityName;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_TargetViewLayer;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeFieldInfoPtr_AbilityExecutionState;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeFieldInfoPtr_TutorialDisabledActions;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_Disabled;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr_TutorialDelayMillis;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr_TutorialShowMillis;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr_WithClickShield;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr_AbilityIDs;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr_CanCancelStepTwo;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_PickerKind;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_UnusualSelections;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_TargetHinting;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_ObjectiveID;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_ObjectiveIncrement;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_UnusualSkip;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_Cheated;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_CustomChoiceFilterByEntity;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_FeedbackScore;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_CustomChoiceTargetHinting;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_Unparseable;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_IsOfflineAccount;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_SteamItemID;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_UWPStoreID;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_XBoxStoreID;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_ProductName;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_ProductDescription;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_ProductImage;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_ProductTags;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_ProductPricing;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_Claimable;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_AITakesPlayerTurn;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_PlayerTurnTimer;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_PlayerTurnTimerPadding;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeFieldInfoPtr_PlayerTimeoutAction;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeFieldInfoPtr_PlayerActionTimer;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeFieldInfoPtr_ReplacedByAIForTurn;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeFieldInfoPtr_StartedAsAI;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeFieldInfoPtr_ShowTimerOverride;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeFieldInfoPtr_BadSelections;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeFieldInfoPtr_SelectionStepOneOnly;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeFieldInfoPtr_SelectionStepTwoOnly;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTurnPlayer;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeFieldInfoPtr_CurrentSelectionPlayer;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeFieldInfoPtr_NonSelectionPromptText;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeFieldInfoPtr_DragTarget;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeFieldInfoPtr_DeferredLeafSelection;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeFieldInfoPtr_Selecting;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeFieldInfoPtr_VFXTags;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeFieldInfoPtr_EntityAnimationSourceOverrides;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_GenericAnimationSourceOverrides;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_EntityAnimationDestinationOverrides;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_GenericAnimationDestinationOverrides;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_VfxSequenceNameOverrides;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_PlatformVFXTags;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_IAPOfferID;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_IABOfferID;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_NintendoItemID;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAbilityState;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAbilityIndex;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_SkipSelectedCosts;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAbilitySucceeded;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_AbilityRollbackQueue;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeFieldInfoPtr_MayCancelAbility;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeFieldInfoPtr_ParentAbilityExecutionState;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr_NumChildren;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeFieldInfoPtr_StartingCameraAnchor;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeFieldInfoPtr_SkipCameraIntro;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeFieldInfoPtr_CurrentIndex;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishScoringMethods;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeFieldInfoPtr_SkirmishRuleMods;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeFieldInfoPtr_SequenceID;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeFieldInfoPtr_PositionInParent;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeFieldInfoPtr_MultipartSelectionCount;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeFieldInfoPtr_EventID;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeFieldInfoPtr_RoundID;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeFieldInfoPtr_Ranked;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeFieldInfoPtr_FinalPosition;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeFieldInfoPtr_RequiredTutorial;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeFieldInfoPtr_FirstTimeTriggerID;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;
	}
}
