using System;
using Canis.actions.staged;
using Canis.data;
using Canis.entities;
using Canis.entities.ai;
using Canis.events;
using Canis.gameLogs;
using Canis.mathLib;
using Canis.obfuscation;
using Canis.reactions;
using Canis.selectionfilters;
using Canis.stackmodifiers;
using Canis.triggers;
using Canis.tutorialScripts;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using lib.canis.Canis.data;
using Networking.selection.targetresponse;

namespace Canis.attributes
{
	// Token: 0x02000161 RID: 353
	public static class TCAttributes : Object
	{
		// Token: 0x06000F77 RID: 3959 RVA: 0x00059424 File Offset: 0x00057624
		// Note: this type is marked as 'beforefieldinit'.
		static TCAttributes()
		{
			Il2CppClassPointerStore<TCAttributes>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.attributes", "TCAttributes");
			TCAttributes.NativeFieldInfoPtr_AccountSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "AccountSettings");
			TCAttributes.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Name");
			TCAttributes.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Description");
			TCAttributes.NativeFieldInfoPtr_TCCurrentTurnPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "TCCurrentTurnPlayer");
			TCAttributes.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Level");
			TCAttributes.NativeFieldInfoPtr_ModifierStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ModifierStack");
			TCAttributes.NativeFieldInfoPtr_OnTurn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "OnTurn");
			TCAttributes.NativeFieldInfoPtr_ChallengeProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ChallengeProgress");
			TCAttributes.NativeFieldInfoPtr_ScreenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ScreenName");
			TCAttributes.NativeFieldInfoPtr_ScreenNameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ScreenNameID");
			TCAttributes.NativeFieldInfoPtr_ScreenNameFull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ScreenNameFull");
			TCAttributes.NativeFieldInfoPtr_Points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Points");
			TCAttributes.NativeFieldInfoPtr_Reactions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Reactions");
			TCAttributes.NativeFieldInfoPtr_TriggerPhases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "TriggerPhases");
			TCAttributes.NativeFieldInfoPtr_Synergies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Synergies");
			TCAttributes.NativeFieldInfoPtr_ModifierMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ModifierMap");
			TCAttributes.NativeFieldInfoPtr_IsAIPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "IsAIPlayer");
			TCAttributes.NativeFieldInfoPtr_NeighborArchs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "NeighborArchs");
			TCAttributes.NativeFieldInfoPtr_NeighborEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "NeighborEntities");
			TCAttributes.NativeFieldInfoPtr_Triggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Triggers");
			TCAttributes.NativeFieldInfoPtr_SelectionCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "SelectionCounter");
			TCAttributes.NativeFieldInfoPtr_GeneralEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "GeneralEvents");
			TCAttributes.NativeFieldInfoPtr_GameLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "GameLogs");
			TCAttributes.NativeFieldInfoPtr_LogText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "LogText");
			TCAttributes.NativeFieldInfoPtr_LogIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "LogIndex");
			TCAttributes.NativeFieldInfoPtr_LogIndices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "LogIndices");
			TCAttributes.NativeFieldInfoPtr_UndoAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "UndoAbility");
			TCAttributes.NativeFieldInfoPtr_ActionUndoID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ActionUndoID");
			TCAttributes.NativeFieldInfoPtr_ActionLogUndoIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ActionLogUndoIndex");
			TCAttributes.NativeFieldInfoPtr_Position2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Position2");
			TCAttributes.NativeFieldInfoPtr_Position3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Position3");
			TCAttributes.NativeFieldInfoPtr_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Direction");
			TCAttributes.NativeFieldInfoPtr_PassedToPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "PassedToPlayerID");
			TCAttributes.NativeFieldInfoPtr_TCAbilityExecutionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "TCAbilityExecutionState");
			TCAttributes.NativeFieldInfoPtr_Velocity2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Velocity2");
			TCAttributes.NativeFieldInfoPtr_Velocity3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Velocity3");
			TCAttributes.NativeFieldInfoPtr_SelectionPromptOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "SelectionPromptOptions");
			TCAttributes.NativeFieldInfoPtr_Hidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Hidden");
			TCAttributes.NativeFieldInfoPtr_DescendantsHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "DescendantsHidden");
			TCAttributes.NativeFieldInfoPtr_SelectionNodeFilterData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "SelectionNodeFilterData");
			TCAttributes.NativeFieldInfoPtr_SelectionMessageFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "SelectionMessageFilters");
			TCAttributes.NativeFieldInfoPtr_ActiveGameLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ActiveGameLog");
			TCAttributes.NativeFieldInfoPtr_ActionToUndo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ActionToUndo");
			TCAttributes.NativeFieldInfoPtr_ActiveAbilityTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ActiveAbilityTargets");
			TCAttributes.NativeFieldInfoPtr_ActiveAbilitySecondaryTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ActiveAbilitySecondaryTargets");
			TCAttributes.NativeFieldInfoPtr_ActiveAbilityTertiaryTargets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ActiveAbilityTertiaryTargets");
			TCAttributes.NativeFieldInfoPtr_OpponentPromptOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "OpponentPromptOverride");
			TCAttributes.NativeFieldInfoPtr_ActiveSequences = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "ActiveSequences");
			TCAttributes.NativeFieldInfoPtr_UnusualSelectionsV2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "UnusualSelectionsV2");
			TCAttributes.NativeFieldInfoPtr_Objectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "Objectives");
			TCAttributes.NativeFieldInfoPtr_CompletedObjectives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "CompletedObjectives");
			TCAttributes.NativeFieldInfoPtr_CompletedScenarioTasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "CompletedScenarioTasks");
			TCAttributes.NativeFieldInfoPtr_PendingSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "PendingSelections");
			TCAttributes.NativeFieldInfoPtr_EventReactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "EventReactor");
			TCAttributes.NativeFieldInfoPtr_AbilityStagedExecutionActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "AbilityStagedExecutionActions");
			TCAttributes.NativeFieldInfoPtr_AbilityStagedCostActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "AbilityStagedCostActions");
			TCAttributes.NativeFieldInfoPtr_LastCompletedSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "LastCompletedSelection");
			TCAttributes.NativeFieldInfoPtr_AISelectionEvaluator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "AISelectionEvaluator");
			TCAttributes.NativeFieldInfoPtr_GameLogList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "GameLogList");
			TCAttributes.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, 100666540);
			TCAttributes.NativeMethodInfoPtr_DefinitionsList_Public_Static_Il2CppReferenceArray_1_IAttributeDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, 100666542);
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x00059910 File Offset: 0x00057B10
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TCAttributes.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x00059938 File Offset: 0x00057B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578026, XrefRangeEnd = 578641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<IAttributeDefinition> DefinitionsList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TCAttributes.NativeMethodInfoPtr_DefinitionsList_Public_Static_Il2CppReferenceArray_1_IAttributeDefinition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IAttributeDefinition>>(intPtr3) : null;
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00007DF9 File Offset: 0x00005FF9
		public TCAttributes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000F7B RID: 3963 RVA: 0x0005996C File Offset: 0x00057B6C
		// (set) Token: 0x06000F7C RID: 3964 RVA: 0x00007E02 File Offset: 0x00006002
		public unsafe static AttributeDefinition<Dictionary<int, int>> AccountSettings
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_AccountSettings, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<int, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_AccountSettings, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000F7D RID: 3965 RVA: 0x00059994 File Offset: 0x00057B94
		// (set) Token: 0x06000F7E RID: 3966 RVA: 0x00007E14 File Offset: 0x00006014
		public unsafe static AttributeDefinition<LocalizableText> Name
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Name, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Name, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x000599BC File Offset: 0x00057BBC
		// (set) Token: 0x06000F80 RID: 3968 RVA: 0x00007E26 File Offset: 0x00006026
		public unsafe static AttributeDefinition<LocalizableText> Description
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Description, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableText>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Description, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000F81 RID: 3969 RVA: 0x000599E4 File Offset: 0x00057BE4
		// (set) Token: 0x06000F82 RID: 3970 RVA: 0x00007E38 File Offset: 0x00006038
		public unsafe static AttributeDefinition<AccountID> TCCurrentTurnPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_TCCurrentTurnPlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<AccountID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_TCCurrentTurnPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x00059A0C File Offset: 0x00057C0C
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x00007E4A File Offset: 0x0000604A
		public unsafe static AttributeDefinition<Nullable<int>> Level
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Level, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Level, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00059A34 File Offset: 0x00057C34
		// (set) Token: 0x06000F86 RID: 3974 RVA: 0x00007E5C File Offset: 0x0000605C
		public unsafe static AttributeDefinition<List<StackModifier>> ModifierStack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ModifierStack, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<StackModifier>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ModifierStack, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000F87 RID: 3975 RVA: 0x00059A5C File Offset: 0x00057C5C
		// (set) Token: 0x06000F88 RID: 3976 RVA: 0x00007E6E File Offset: 0x0000606E
		public unsafe static AttributeDefinition<Nullable<int>> OnTurn
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_OnTurn, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_OnTurn, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000F89 RID: 3977 RVA: 0x00059A84 File Offset: 0x00057C84
		// (set) Token: 0x06000F8A RID: 3978 RVA: 0x00007E80 File Offset: 0x00006080
		public unsafe static AttributeDefinition<Dictionary<int, int>> ChallengeProgress
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ChallengeProgress, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<int, int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ChallengeProgress, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000F8B RID: 3979 RVA: 0x00059AAC File Offset: 0x00057CAC
		// (set) Token: 0x06000F8C RID: 3980 RVA: 0x00007E92 File Offset: 0x00006092
		public unsafe static AttributeDefinition<string> ScreenName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ScreenName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ScreenName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06000F8D RID: 3981 RVA: 0x00059AD4 File Offset: 0x00057CD4
		// (set) Token: 0x06000F8E RID: 3982 RVA: 0x00007EA4 File Offset: 0x000060A4
		public unsafe static AttributeDefinition<string> ScreenNameID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ScreenNameID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ScreenNameID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00059AFC File Offset: 0x00057CFC
		// (set) Token: 0x06000F90 RID: 3984 RVA: 0x00007EB6 File Offset: 0x000060B6
		public unsafe static AttributeDefinition<string> ScreenNameFull
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ScreenNameFull, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ScreenNameFull, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06000F91 RID: 3985 RVA: 0x00059B24 File Offset: 0x00057D24
		// (set) Token: 0x06000F92 RID: 3986 RVA: 0x00007EC8 File Offset: 0x000060C8
		public unsafe static AttributeDefinition<Nullable<int>> Points
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Points, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Points, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06000F93 RID: 3987 RVA: 0x00059B4C File Offset: 0x00057D4C
		// (set) Token: 0x06000F94 RID: 3988 RVA: 0x00007EDA File Offset: 0x000060DA
		public unsafe static AttributeDefinition<List<OpponentReaction>> Reactions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Reactions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<OpponentReaction>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Reactions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06000F95 RID: 3989 RVA: 0x00059B74 File Offset: 0x00057D74
		// (set) Token: 0x06000F96 RID: 3990 RVA: 0x00007EEC File Offset: 0x000060EC
		public unsafe static AttributeDefinition<Nullable<int>> TriggerPhases
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_TriggerPhases, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_TriggerPhases, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000F97 RID: 3991 RVA: 0x00059B9C File Offset: 0x00057D9C
		// (set) Token: 0x06000F98 RID: 3992 RVA: 0x00007EFE File Offset: 0x000060FE
		public unsafe static AttributeDefinition<List<IntentFitness>> Synergies
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Synergies, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<IntentFitness>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Synergies, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000F99 RID: 3993 RVA: 0x00059BC4 File Offset: 0x00057DC4
		// (set) Token: 0x06000F9A RID: 3994 RVA: 0x00007F10 File Offset: 0x00006110
		public unsafe static AttributeDefinition<Dictionary<EntityID, StackModifier>> ModifierMap
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ModifierMap, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<EntityID, StackModifier>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ModifierMap, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000F9B RID: 3995 RVA: 0x00059BEC File Offset: 0x00057DEC
		// (set) Token: 0x06000F9C RID: 3996 RVA: 0x00007F22 File Offset: 0x00006122
		public unsafe static AttributeDefinition<Nullable<bool>> IsAIPlayer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_IsAIPlayer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_IsAIPlayer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00059C14 File Offset: 0x00057E14
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x00007F34 File Offset: 0x00006134
		public unsafe static AttributeDefinition<List<ArchetypeID>> NeighborArchs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_NeighborArchs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<ArchetypeID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_NeighborArchs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00059C3C File Offset: 0x00057E3C
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x00007F46 File Offset: 0x00006146
		public unsafe static AttributeDefinition<List<EntityID>> NeighborEntities
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_NeighborEntities, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<EntityID>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_NeighborEntities, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00059C64 File Offset: 0x00057E64
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x00007F58 File Offset: 0x00006158
		public unsafe static AttributeDefinition<List<Trigger>> Triggers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Triggers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<Trigger>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Triggers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00059C8C File Offset: 0x00057E8C
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x00007F6A File Offset: 0x0000616A
		public unsafe static AttributeDefinition<Nullable<int>> SelectionCounter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_SelectionCounter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_SelectionCounter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x00059CB4 File Offset: 0x00057EB4
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x00007F7C File Offset: 0x0000617C
		public unsafe static AttributeDefinition<List<string>> GeneralEvents
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_GeneralEvents, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<string>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_GeneralEvents, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000FA7 RID: 4007 RVA: 0x00059CDC File Offset: 0x00057EDC
		// (set) Token: 0x06000FA8 RID: 4008 RVA: 0x00007F8E File Offset: 0x0000618E
		public unsafe static AttributeDefinition<List<SerializedGameLog>> GameLogs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_GameLogs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<SerializedGameLog>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_GameLogs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000FA9 RID: 4009 RVA: 0x00059D04 File Offset: 0x00057F04
		// (set) Token: 0x06000FAA RID: 4010 RVA: 0x00007FA0 File Offset: 0x000061A0
		public unsafe static AttributeDefinition<LocalizableTextVariables> LogText
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_LogText, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<LocalizableTextVariables>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_LogText, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000FAB RID: 4011 RVA: 0x00059D2C File Offset: 0x00057F2C
		// (set) Token: 0x06000FAC RID: 4012 RVA: 0x00007FB2 File Offset: 0x000061B2
		public unsafe static AttributeDefinition<Nullable<int>> LogIndex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_LogIndex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_LogIndex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x00059D54 File Offset: 0x00057F54
		// (set) Token: 0x06000FAE RID: 4014 RVA: 0x00007FC4 File Offset: 0x000061C4
		public unsafe static AttributeDefinition<List<int>> LogIndices
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_LogIndices, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_LogIndices, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000FAF RID: 4015 RVA: 0x00059D7C File Offset: 0x00057F7C
		// (set) Token: 0x06000FB0 RID: 4016 RVA: 0x00007FD6 File Offset: 0x000061D6
		public unsafe static AttributeDefinition<EntityID> UndoAbility
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_UndoAbility, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<EntityID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_UndoAbility, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00059DA4 File Offset: 0x00057FA4
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x00007FE8 File Offset: 0x000061E8
		public unsafe static AttributeDefinition<ActionUndoID> ActionUndoID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ActionUndoID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<ActionUndoID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ActionUndoID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x00059DCC File Offset: 0x00057FCC
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x00007FFA File Offset: 0x000061FA
		public unsafe static AttributeDefinition<Nullable<int>> ActionLogUndoIndex
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ActionLogUndoIndex, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ActionLogUndoIndex, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00059DF4 File Offset: 0x00057FF4
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x0000800C File Offset: 0x0000620C
		public unsafe static AttributeDefinition<Nullable<DwdVector2>> Position2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Position2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<DwdVector2>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Position2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x00059E1C File Offset: 0x0005801C
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x0000801E File Offset: 0x0000621E
		public unsafe static AttributeDefinition<Nullable<DwdVector3>> Position3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Position3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<DwdVector3>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Position3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00059E44 File Offset: 0x00058044
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x00008030 File Offset: 0x00006230
		public unsafe static AttributeDefinition<Nullable<int>> Direction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Direction, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Direction, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00059E6C File Offset: 0x0005806C
		// (set) Token: 0x06000FBC RID: 4028 RVA: 0x00008042 File Offset: 0x00006242
		public unsafe static AttributeDefinition<AccountID> PassedToPlayerID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_PassedToPlayerID, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<AccountID>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_PassedToPlayerID, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x00059E94 File Offset: 0x00058094
		// (set) Token: 0x06000FBE RID: 4030 RVA: 0x00008054 File Offset: 0x00006254
		public unsafe static AttributeDefinition<Nullable<int>> TCAbilityExecutionState
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_TCAbilityExecutionState, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_TCAbilityExecutionState, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x00059EBC File Offset: 0x000580BC
		// (set) Token: 0x06000FC0 RID: 4032 RVA: 0x00008066 File Offset: 0x00006266
		public unsafe static AttributeDefinition<Nullable<DwdVector2>> Velocity2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Velocity2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<DwdVector2>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Velocity2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x00059EE4 File Offset: 0x000580E4
		// (set) Token: 0x06000FC2 RID: 4034 RVA: 0x00008078 File Offset: 0x00006278
		public unsafe static AttributeDefinition<Nullable<DwdVector3>> Velocity3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Velocity3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<DwdVector3>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Velocity3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000FC3 RID: 4035 RVA: 0x00059F0C File Offset: 0x0005810C
		// (set) Token: 0x06000FC4 RID: 4036 RVA: 0x0000808A File Offset: 0x0000628A
		public unsafe static AttributeDefinition<Nullable<int>> SelectionPromptOptions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_SelectionPromptOptions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_SelectionPromptOptions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000FC5 RID: 4037 RVA: 0x00059F34 File Offset: 0x00058134
		// (set) Token: 0x06000FC6 RID: 4038 RVA: 0x0000809C File Offset: 0x0000629C
		public unsafe static AttributeDefinition<Visibility> Hidden
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Hidden, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Visibility>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Hidden, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000FC7 RID: 4039 RVA: 0x00059F5C File Offset: 0x0005815C
		// (set) Token: 0x06000FC8 RID: 4040 RVA: 0x000080AE File Offset: 0x000062AE
		public unsafe static AttributeDefinition<DescendantsHidden> DescendantsHidden
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_DescendantsHidden, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<DescendantsHidden>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_DescendantsHidden, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000FC9 RID: 4041 RVA: 0x00059F84 File Offset: 0x00058184
		// (set) Token: 0x06000FCA RID: 4042 RVA: 0x000080C0 File Offset: 0x000062C0
		public unsafe static AttributeDefinition<List<SelectionNodeFilterData>> SelectionNodeFilterData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_SelectionNodeFilterData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<SelectionNodeFilterData>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_SelectionNodeFilterData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x00059FAC File Offset: 0x000581AC
		// (set) Token: 0x06000FCC RID: 4044 RVA: 0x000080D2 File Offset: 0x000062D2
		public unsafe static AttributeDefinition<Il2CppReferenceArray<SelectionMessageFilter>> SelectionMessageFilters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_SelectionMessageFilters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Il2CppReferenceArray<SelectionMessageFilter>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_SelectionMessageFilters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000FCD RID: 4045 RVA: 0x00059FD4 File Offset: 0x000581D4
		// (set) Token: 0x06000FCE RID: 4046 RVA: 0x000080E4 File Offset: 0x000062E4
		public unsafe static AttributeDefinition<ActiveGameLog> ActiveGameLog
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ActiveGameLog, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<ActiveGameLog>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ActiveGameLog, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000FCF RID: 4047 RVA: 0x00059FFC File Offset: 0x000581FC
		// (set) Token: 0x06000FD0 RID: 4048 RVA: 0x000080F6 File Offset: 0x000062F6
		public unsafe static AttributeDefinition<ActionToUndo> ActionToUndo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ActionToUndo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<ActionToUndo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ActionToUndo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000FD1 RID: 4049 RVA: 0x0005A024 File Offset: 0x00058224
		// (set) Token: 0x06000FD2 RID: 4050 RVA: 0x00008108 File Offset: 0x00006308
		public unsafe static AttributeDefinition<Il2CppReferenceArray<TargetResponse>> ActiveAbilityTargets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ActiveAbilityTargets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Il2CppReferenceArray<TargetResponse>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ActiveAbilityTargets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000FD3 RID: 4051 RVA: 0x0005A04C File Offset: 0x0005824C
		// (set) Token: 0x06000FD4 RID: 4052 RVA: 0x0000811A File Offset: 0x0000631A
		public unsafe static AttributeDefinition<Il2CppReferenceArray<TargetResponse>> ActiveAbilitySecondaryTargets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ActiveAbilitySecondaryTargets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Il2CppReferenceArray<TargetResponse>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ActiveAbilitySecondaryTargets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000FD5 RID: 4053 RVA: 0x0005A074 File Offset: 0x00058274
		// (set) Token: 0x06000FD6 RID: 4054 RVA: 0x0000812C File Offset: 0x0000632C
		public unsafe static AttributeDefinition<Il2CppReferenceArray<TargetResponse>> ActiveAbilityTertiaryTargets
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ActiveAbilityTertiaryTargets, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Il2CppReferenceArray<TargetResponse>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ActiveAbilityTertiaryTargets, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x0005A09C File Offset: 0x0005829C
		// (set) Token: 0x06000FD8 RID: 4056 RVA: 0x0000813E File Offset: 0x0000633E
		public unsafe static AttributeDefinition<string> OpponentPromptOverride
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_OpponentPromptOverride, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_OpponentPromptOverride, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x0005A0C4 File Offset: 0x000582C4
		// (set) Token: 0x06000FDA RID: 4058 RVA: 0x00008150 File Offset: 0x00006350
		public unsafe static AttributeDefinition<List<DBGSequence>> ActiveSequences
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_ActiveSequences, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<DBGSequence>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_ActiveSequences, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x0005A0EC File Offset: 0x000582EC
		// (set) Token: 0x06000FDC RID: 4060 RVA: 0x00008162 File Offset: 0x00006362
		public unsafe static AttributeDefinition<Il2CppReferenceArray<UnusualSelection>> UnusualSelectionsV2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_UnusualSelectionsV2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Il2CppReferenceArray<UnusualSelection>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_UnusualSelectionsV2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x0005A114 File Offset: 0x00058314
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x00008174 File Offset: 0x00006374
		public unsafe static AttributeDefinition<Il2CppReferenceArray<Objective>> Objectives
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_Objectives, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Il2CppReferenceArray<Objective>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_Objectives, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x0005A13C File Offset: 0x0005833C
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x00008186 File Offset: 0x00006386
		public unsafe static AttributeDefinition<Il2CppStructArray<int>> CompletedObjectives
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_CompletedObjectives, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Il2CppStructArray<int>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_CompletedObjectives, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x0005A164 File Offset: 0x00058364
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x00008198 File Offset: 0x00006398
		public unsafe static AttributeDefinition<Nullable<bool>> CompletedScenarioTasks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_CompletedScenarioTasks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Nullable<bool>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_CompletedScenarioTasks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x0005A18C File Offset: 0x0005838C
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x000081AA File Offset: 0x000063AA
		public unsafe static AttributeDefinition<List<PendingSelection>> PendingSelections
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_PendingSelections, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<PendingSelection>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_PendingSelections, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x0005A1B4 File Offset: 0x000583B4
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x000081BC File Offset: 0x000063BC
		public unsafe static AttributeDefinition<SerializedEventReactor> EventReactor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_EventReactor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<SerializedEventReactor>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_EventReactor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x0005A1DC File Offset: 0x000583DC
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x000081CE File Offset: 0x000063CE
		public unsafe static AttributeDefinition<Dictionary<int, List<SerializedStagedAction>>> AbilityStagedExecutionActions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_AbilityStagedExecutionActions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<Dictionary<int, List<SerializedStagedAction>>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_AbilityStagedExecutionActions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x0005A204 File Offset: 0x00058404
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x000081E0 File Offset: 0x000063E0
		public unsafe static AttributeDefinition<List<SerializedStagedAction>> AbilityStagedCostActions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_AbilityStagedCostActions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<List<SerializedStagedAction>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_AbilityStagedCostActions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x0005A22C File Offset: 0x0005842C
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x000081F2 File Offset: 0x000063F2
		public unsafe static AttributeDefinition<PendingSelection> LastCompletedSelection
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_LastCompletedSelection, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<PendingSelection>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_LastCompletedSelection, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x0005A254 File Offset: 0x00058454
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x00008204 File Offset: 0x00006404
		public unsafe static AttributeDefinition<AIEvaluator> AISelectionEvaluator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_AISelectionEvaluator, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<AIEvaluator>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_AISelectionEvaluator, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x0005A27C File Offset: 0x0005847C
		// (set) Token: 0x06000FF0 RID: 4080 RVA: 0x00008216 File Offset: 0x00006416
		public unsafe static AttributeDefinition<GameLogList> GameLogList
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TCAttributes.NativeFieldInfoPtr_GameLogList, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<GameLogList>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TCAttributes.NativeFieldInfoPtr_GameLogList, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeFieldInfoPtr_AccountSettings;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeFieldInfoPtr_TCCurrentTurnPlayer;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeFieldInfoPtr_Level;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeFieldInfoPtr_ModifierStack;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeFieldInfoPtr_OnTurn;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeFieldInfoPtr_ChallengeProgress;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeFieldInfoPtr_ScreenName;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeFieldInfoPtr_ScreenNameID;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeFieldInfoPtr_ScreenNameFull;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeFieldInfoPtr_Points;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeFieldInfoPtr_Reactions;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeFieldInfoPtr_TriggerPhases;

		// Token: 0x04000A5C RID: 2652
		private static readonly IntPtr NativeFieldInfoPtr_Synergies;

		// Token: 0x04000A5D RID: 2653
		private static readonly IntPtr NativeFieldInfoPtr_ModifierMap;

		// Token: 0x04000A5E RID: 2654
		private static readonly IntPtr NativeFieldInfoPtr_IsAIPlayer;

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeFieldInfoPtr_NeighborArchs;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeFieldInfoPtr_NeighborEntities;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeFieldInfoPtr_Triggers;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeFieldInfoPtr_SelectionCounter;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeFieldInfoPtr_GeneralEvents;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeFieldInfoPtr_GameLogs;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeFieldInfoPtr_LogText;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeFieldInfoPtr_LogIndex;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeFieldInfoPtr_LogIndices;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeFieldInfoPtr_UndoAbility;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeFieldInfoPtr_ActionUndoID;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeFieldInfoPtr_ActionLogUndoIndex;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeFieldInfoPtr_Position2;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeFieldInfoPtr_Position3;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeFieldInfoPtr_Direction;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeFieldInfoPtr_PassedToPlayerID;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeFieldInfoPtr_TCAbilityExecutionState;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeFieldInfoPtr_Velocity2;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeFieldInfoPtr_Velocity3;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeFieldInfoPtr_SelectionPromptOptions;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeFieldInfoPtr_Hidden;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeFieldInfoPtr_DescendantsHidden;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeFieldInfoPtr_SelectionNodeFilterData;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeFieldInfoPtr_SelectionMessageFilters;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeFieldInfoPtr_ActiveGameLog;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeFieldInfoPtr_ActionToUndo;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAbilityTargets;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAbilitySecondaryTargets;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeFieldInfoPtr_ActiveAbilityTertiaryTargets;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeFieldInfoPtr_OpponentPromptOverride;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeFieldInfoPtr_ActiveSequences;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeFieldInfoPtr_UnusualSelectionsV2;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeFieldInfoPtr_Objectives;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeFieldInfoPtr_CompletedObjectives;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeFieldInfoPtr_CompletedScenarioTasks;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeFieldInfoPtr_PendingSelections;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeFieldInfoPtr_EventReactor;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeFieldInfoPtr_AbilityStagedExecutionActions;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeFieldInfoPtr_AbilityStagedCostActions;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeFieldInfoPtr_LastCompletedSelection;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeFieldInfoPtr_AISelectionEvaluator;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeFieldInfoPtr_GameLogList;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_DefinitionsList_Public_Static_Il2CppReferenceArray_1_IAttributeDefinition_0;

		// Token: 0x020003A0 RID: 928
		[ObfuscatedName("Canis.attributes.TCAttributes+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600268D RID: 9869 RVA: 0x000A9CE0 File Offset: 0x000A7EE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TCAttributes.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TCAttributes>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TCAttributes.__c>.NativeClassPtr);
				TCAttributes.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes.__c>.NativeClassPtr, "<>9");
				TCAttributes.__c.NativeFieldInfoPtr___9__61_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes.__c>.NativeClassPtr, "<>9__61_0");
				TCAttributes.__c.NativeFieldInfoPtr___9__61_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TCAttributes.__c>.NativeClassPtr, "<>9__61_1");
				TCAttributes.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TCAttributes.__c>.NativeClassPtr, 100666544);
				TCAttributes.__c.NativeMethodInfoPtr__DefinitionsList_b__61_0_Internal_Boolean_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TCAttributes.__c>.NativeClassPtr, 100666545);
				TCAttributes.__c.NativeMethodInfoPtr__DefinitionsList_b__61_1_Internal_IAttributeDefinition_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TCAttributes.__c>.NativeClassPtr, 100666546);
			}

			// Token: 0x0600268E RID: 9870 RVA: 0x000A9D84 File Offset: 0x000A7F84
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TCAttributes.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TCAttributes.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600268F RID: 9871 RVA: 0x000A9DC0 File Offset: 0x000A7FC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578015, XrefRangeEnd = 578022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DefinitionsList_b__61_0(FieldInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TCAttributes.__c.NativeMethodInfoPtr__DefinitionsList_b__61_0_Internal_Boolean_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002690 RID: 9872 RVA: 0x000A9E10 File Offset: 0x000A8010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 578022, XrefRangeEnd = 578026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAttributeDefinition _DefinitionsList_b__61_1(FieldInfo _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TCAttributes.__c.NativeMethodInfoPtr__DefinitionsList_b__61_1_Internal_IAttributeDefinition_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAttributeDefinition>(intPtr3) : null;
				}
			}

			// Token: 0x06002691 RID: 9873 RVA: 0x000125CD File Offset: 0x000107CD
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700097E RID: 2430
			// (get) Token: 0x06002692 RID: 9874 RVA: 0x000A9E60 File Offset: 0x000A8060
			// (set) Token: 0x06002693 RID: 9875 RVA: 0x000125D6 File Offset: 0x000107D6
			public unsafe static TCAttributes.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TCAttributes.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TCAttributes.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TCAttributes.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700097F RID: 2431
			// (get) Token: 0x06002694 RID: 9876 RVA: 0x000A9E88 File Offset: 0x000A8088
			// (set) Token: 0x06002695 RID: 9877 RVA: 0x000125E8 File Offset: 0x000107E8
			public unsafe static Func<FieldInfo, bool> __9__61_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TCAttributes.__c.NativeFieldInfoPtr___9__61_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TCAttributes.__c.NativeFieldInfoPtr___9__61_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000980 RID: 2432
			// (get) Token: 0x06002696 RID: 9878 RVA: 0x000A9EB0 File Offset: 0x000A80B0
			// (set) Token: 0x06002697 RID: 9879 RVA: 0x000125FA File Offset: 0x000107FA
			public unsafe static Func<FieldInfo, IAttributeDefinition> __9__61_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TCAttributes.__c.NativeFieldInfoPtr___9__61_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FieldInfo, IAttributeDefinition>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TCAttributes.__c.NativeFieldInfoPtr___9__61_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400180F RID: 6159
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001810 RID: 6160
			private static readonly IntPtr NativeFieldInfoPtr___9__61_0;

			// Token: 0x04001811 RID: 6161
			private static readonly IntPtr NativeFieldInfoPtr___9__61_1;

			// Token: 0x04001812 RID: 6162
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001813 RID: 6163
			private static readonly IntPtr NativeMethodInfoPtr__DefinitionsList_b__61_0_Internal_Boolean_FieldInfo_0;

			// Token: 0x04001814 RID: 6164
			private static readonly IntPtr NativeMethodInfoPtr__DefinitionsList_b__61_1_Internal_IAttributeDefinition_FieldInfo_0;
		}
	}
}
