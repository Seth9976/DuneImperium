using System;
using System.Runtime.InteropServices;
using Canis;
using Canis.actions;
using Canis.attributes;
using Canis.context;
using Canis.entities;
using Canis.entities.ai;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;
using worm.canis.ai;
using worm.canis.ai.choices;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.abilities
{
	// Token: 0x0200031A RID: 794
	public class WormAbilityDefinition : AbilityStateMachineDefinition<WormMatch, WormActiveAbility, WormAbilityDefinition>
	{
		// Token: 0x06002058 RID: 8280 RVA: 0x000D7890 File Offset: 0x000D5A90
		// Note: this type is marked as 'beforefieldinit'.
		static WormAbilityDefinition()
		{
			Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.abilities", "WormAbilityDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr);
			WormAbilityDefinition.NativeFieldInfoPtr_WormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, "WormMatch");
			WormAbilityDefinition.NativeMethodInfoPtr__ctor_Protected_Void_WormMatch_String_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671208);
			WormAbilityDefinition.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_WormMatch_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671209);
			WormAbilityDefinition.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_New_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671210);
			WormAbilityDefinition.NativeMethodInfoPtr_ValueInPileForOtherPlay_Public_Virtual_New_AIValueSummer_1_Double_WormPlayArea_WormPlayable_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671211);
			WormAbilityDefinition.NativeMethodInfoPtr_SpecificAcquireValue_Public_Virtual_New_AIValueSummer_1_Double_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671212);
			WormAbilityDefinition.NativeMethodInfoPtr_Evaluate_Public_Virtual_New_WormAIChoice_WormAIChoiceContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671213);
			WormAbilityDefinition.NativeMethodInfoPtr_UnexhaustedDependency_Protected_Abstract_Virtual_New_IEnumerable_1_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671214);
			WormAbilityDefinition.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_New_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671215);
			WormAbilityDefinition.NativeMethodInfoPtr_CanBeRun_Public_Virtual_Boolean_Match_PlayerEntity_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671216);
			WormAbilityDefinition.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_New_GameLogBuilder_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671217);
			WormAbilityDefinition.NativeMethodInfoPtr_MakeEntityListTargetInformation_Protected_Virtual_EntityListTargetInformation_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671218);
			WormAbilityDefinition.NativeMethodInfoPtr_MakeEntityListTargetInformation_Protected_EntityListTargetInformation_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_Boolean_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671219);
			WormAbilityDefinition.NativeMethodInfoPtr_GetUnusualSelections_Public_Virtual_New_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671220);
			WormAbilityDefinition.NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_New_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671221);
			WormAbilityDefinition.NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_New_Dictionary_2_AccountID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671222);
			WormAbilityDefinition.NativeMethodInfoPtr_ShowHinting_Public_Virtual_New_Boolean_WormMatch_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671223);
			WormAbilityDefinition.NativeMethodInfoPtr_BuildStingerSequence_Protected_Virtual_New_SequenceHelper_WormPlayer_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671224);
			WormAbilityDefinition.NativeMethodInfoPtr_GetFactionTarget_Protected_Virtual_New_Factions_WormActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671225);
			WormAbilityDefinition.NativeMethodInfoPtr_GetFactionTarget_Protected_Virtual_New_Factions_WormActiveAbility_Func_3_WormFactionTrack_WormPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671226);
			WormAbilityDefinition.NativeMethodInfoPtr_get_GetAbilityTiming_Public_get_AbilityTiming_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671227);
			WormAbilityDefinition.NativeMethodInfoPtr_HasMatchingTiming_Public_Boolean_PlayerTurnTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671228);
			WormAbilityDefinition.NativeMethodInfoPtr_get_HasAgentOrRevealTiming_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671229);
			WormAbilityDefinition.NativeMethodInfoPtr_WillClearUndo_Public_Virtual_New_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, 100671230);
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x000D7AA0 File Offset: 0x000D5CA0
		[CallerCount(93)]
		[CachedScanResults(RefRangeStart = 175231, RefRangeEnd = 175324, XrefRangeStart = 175227, XrefRangeEnd = 175231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAbilityDefinition(WormMatch m, string name = "", PlayerEntity owningPlayer = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owningPlayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityDefinition.NativeMethodInfoPtr__ctor_Protected_Void_WormMatch_String_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x000D7B10 File Offset: 0x000D5D10
		[CallerCount(105)]
		[CachedScanResults(RefRangeStart = 175328, RefRangeEnd = 175433, XrefRangeStart = 175324, XrefRangeEnd = 175328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormAbilityDefinition(SerializedEntity se, WormMatch m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityDefinition.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_WormMatch_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x000D7B80 File Offset: 0x000D5D80
		[CallerCount(205)]
		[CachedScanResults(RefRangeStart = 175434, RefRangeEnd = 175639, XrefRangeStart = 175433, XrefRangeEnd = 175434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AIValueSummer<double> ValueForPlayer(WormPlayer player, [Optional] Il2CppReferenceArray<WormEntity> withEntities)
		{
			if (withEntities == null)
			{
				withEntities = new Il2CppReferenceArray<WormEntity>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(withEntities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_New_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x000D7BFC File Offset: 0x000D5DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175639, XrefRangeEnd = 175739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AIValueSummer<double> ValueInPileForOtherPlay(WormPlayArea pile, WormPlayable card, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(card);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_ValueInPileForOtherPlay_Public_Virtual_New_AIValueSummer_1_Double_WormPlayArea_WormPlayable_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x000D7C7C File Offset: 0x000D5E7C
		[CallerCount(205)]
		[CachedScanResults(RefRangeStart = 175434, RefRangeEnd = 175639, XrefRangeStart = 175434, XrefRangeEnd = 175639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AIValueSummer<double> SpecificAcquireValue(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_SpecificAcquireValue_Public_Virtual_New_AIValueSummer_1_Double_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AIValueSummer<double>>(intPtr3) : null;
			}
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x000D7CD8 File Offset: 0x000D5ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175739, XrefRangeEnd = 175743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual WormAIChoice Evaluate(WormAIChoiceContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_Evaluate_Public_Virtual_New_WormAIChoice_WormAIChoiceContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormAIChoice>(intPtr3) : null;
			}
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x000D7D34 File Offset: 0x000D5F34
		[CallerCount(0)]
		public unsafe virtual IEnumerable<Entity> UnexhaustedDependency(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_UnexhaustedDependency_Protected_Abstract_Virtual_New_IEnumerable_1_Entity_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x000D7D90 File Offset: 0x000D5F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175743, XrefRangeEnd = 175751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsUnexhausted(PlayerEntity player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_New_Boolean_PlayerEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x000D7DE8 File Offset: 0x000D5FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175751, XrefRangeEnd = 175752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeRun(Match match, PlayerEntity player, Context paramContext = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_CanBeRun_Public_Virtual_Boolean_Match_PlayerEntity_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x000D7E64 File Offset: 0x000D6064
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameLogBuilder MakeGameLogBuilder(IHasGameLogs hasGameLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(hasGameLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_New_GameLogBuilder_IHasGameLogs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x000D7EC0 File Offset: 0x000D60C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175752, XrefRangeEnd = 175753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityListTargetInformation MakeEntityListTargetInformation(IEnumerable<Entity> targets, PlayerEntity player, LocalizableTextVariables prompt, AIEvaluateSelection evaluator = null, string kind = null, bool forced = true, bool deferDrag = false, int max = 1, int min = -1, IEnumerable<IAttribute> attributes = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prompt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(kind);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deferDrag;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_MakeEntityListTargetInformation_Protected_Virtual_EntityListTargetInformation_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityListTargetInformation>(intPtr3) : null;
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x000D7FB4 File Offset: 0x000D61B4
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 175813, RefRangeEnd = 175840, XrefRangeStart = 175753, XrefRangeEnd = 175813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityListTargetInformation MakeEntityListTargetInformation(IEnumerable<Entity> targets, PlayerEntity player, LocalizableTextVariables prompt, bool addClearUndoHints, AIEvaluateSelection evaluator = null, string kind = null, bool forced = true, bool deferDrag = false, int max = 1, int min = -1, IEnumerable<IAttribute> attributes = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prompt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addClearUndoHints;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(evaluator);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(kind);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forced;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deferDrag;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityDefinition.NativeMethodInfoPtr_MakeEntityListTargetInformation_Protected_EntityListTargetInformation_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_Boolean_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityListTargetInformation>(intPtr3) : null;
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x000D80AC File Offset: 0x000D62AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175840, XrefRangeEnd = 175846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<ValueTuple<LocalizableTextVariables, List<EntityID>>> GetUnusualSelections(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_GetUnusualSelections_Public_Virtual_New_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<LocalizableTextVariables, List<EntityID>>>>(intPtr3) : null;
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x000D811C File Offset: 0x000D631C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsEndgamePlayable(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_New_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x000D8188 File Offset: 0x000D6388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175846, XrefRangeEnd = 175852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dictionary<AccountID, int> GetConditionalEndgameVP()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_New_Dictionary_2_AccountID_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, int>>(intPtr3) : null;
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x000D81D4 File Offset: 0x000D63D4
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShowHinting(WormMatch match, WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_ShowHinting_Public_Virtual_New_Boolean_WormMatch_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x000D8240 File Offset: 0x000D6440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 175908, RefRangeEnd = 175909, XrefRangeStart = 175852, XrefRangeEnd = 175908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SequenceHelper BuildStingerSequence(WormPlayer player, string sequenceName, bool ownerEntity = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sequenceName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ownerEntity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_BuildStingerSequence_Protected_Virtual_New_SequenceHelper_WormPlayer_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr3) : null;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x000D82BC File Offset: 0x000D64BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175909, XrefRangeEnd = 175925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Factions GetFactionTarget(WormActiveAbility activeAbility)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_GetFactionTarget_Protected_Virtual_New_Factions_WormActiveAbility_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x000D8314 File Offset: 0x000D6514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175925, XrefRangeEnd = 175939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Factions GetFactionTarget(WormActiveAbility activeAbility, Func<WormFactionTrack, WormPlayer, bool> filter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_GetFactionTarget_Protected_Virtual_New_Factions_WormActiveAbility_Func_3_WormFactionTrack_WormPlayer_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x000D8380 File Offset: 0x000D6580
		public unsafe AbilityTiming GetAbilityTiming
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 175950, RefRangeEnd = 175956, XrefRangeStart = 175939, XrefRangeEnd = 175950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityDefinition.NativeMethodInfoPtr_get_GetAbilityTiming_Public_get_AbilityTiming_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x000D83BC File Offset: 0x000D65BC
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 175957, RefRangeEnd = 175976, XrefRangeStart = 175956, XrefRangeEnd = 175957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasMatchingTiming(PlayerTurnTypes turnType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref turnType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityDefinition.NativeMethodInfoPtr_HasMatchingTiming_Public_Boolean_PlayerTurnTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x000D8408 File Offset: 0x000D6608
		public unsafe bool HasAgentOrRevealTiming
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175976, XrefRangeEnd = 175977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityDefinition.NativeMethodInfoPtr_get_HasAgentOrRevealTiming_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x000D8444 File Offset: 0x000D6644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175977, XrefRangeEnd = 175984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool WillClearUndo(WormPlayer player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormAbilityDefinition.NativeMethodInfoPtr_WillClearUndo_Public_Virtual_New_Boolean_WormPlayer_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002070 RID: 8304 RVA: 0x0000D626 File Offset: 0x0000B826
		public virtual AIValueSummer<double> ValueForPlayer(WormPlayer player, params WormEntity[] withEntities)
		{
			return this.ValueForPlayer(player, new Il2CppReferenceArray<WormEntity>(withEntities));
		}

		// Token: 0x06002071 RID: 8305 RVA: 0x0000D635 File Offset: 0x0000B835
		public WormAbilityDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x000D849C File Offset: 0x000D669C
		// (set) Token: 0x06002073 RID: 8307 RVA: 0x0000D63E File Offset: 0x0000B83E
		public unsafe WormMatch WormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityDefinition.NativeFieldInfoPtr_WormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormAbilityDefinition.NativeFieldInfoPtr_WormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeFieldInfoPtr_WormMatch;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_WormMatch_String_PlayerEntity_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_WormMatch_Entity_0;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr_ValueForPlayer_Public_Virtual_New_AIValueSummer_1_Double_WormPlayer_Il2CppReferenceArray_1_WormEntity_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_ValueInPileForOtherPlay_Public_Virtual_New_AIValueSummer_1_Double_WormPlayArea_WormPlayable_WormPlayer_0;

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeMethodInfoPtr_SpecificAcquireValue_Public_Virtual_New_AIValueSummer_1_Double_WormPlayer_0;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_New_WormAIChoice_WormAIChoiceContext_0;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeMethodInfoPtr_UnexhaustedDependency_Protected_Abstract_Virtual_New_IEnumerable_1_Entity_WormPlayer_0;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr_IsUnexhausted_Protected_Virtual_New_Boolean_PlayerEntity_0;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr_CanBeRun_Public_Virtual_Boolean_Match_PlayerEntity_Context_0;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr_MakeGameLogBuilder_Public_Virtual_New_GameLogBuilder_IHasGameLogs_0;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr_MakeEntityListTargetInformation_Protected_Virtual_EntityListTargetInformation_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr_MakeEntityListTargetInformation_Protected_EntityListTargetInformation_IEnumerable_1_Entity_PlayerEntity_LocalizableTextVariables_Boolean_AIEvaluateSelection_String_Boolean_Boolean_Int32_Int32_IEnumerable_1_IAttribute_0;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeMethodInfoPtr_GetUnusualSelections_Public_Virtual_New_List_1_ValueTuple_2_LocalizableTextVariables_List_1_EntityID_WormMatch_WormPlayer_0;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeMethodInfoPtr_IsEndgamePlayable_Public_Virtual_New_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr_GetConditionalEndgameVP_Public_Virtual_New_Dictionary_2_AccountID_Int32_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr_ShowHinting_Public_Virtual_New_Boolean_WormMatch_WormPlayer_0;

		// Token: 0x04001473 RID: 5235
		private static readonly IntPtr NativeMethodInfoPtr_BuildStingerSequence_Protected_Virtual_New_SequenceHelper_WormPlayer_String_Boolean_0;

		// Token: 0x04001474 RID: 5236
		private static readonly IntPtr NativeMethodInfoPtr_GetFactionTarget_Protected_Virtual_New_Factions_WormActiveAbility_0;

		// Token: 0x04001475 RID: 5237
		private static readonly IntPtr NativeMethodInfoPtr_GetFactionTarget_Protected_Virtual_New_Factions_WormActiveAbility_Func_3_WormFactionTrack_WormPlayer_Boolean_0;

		// Token: 0x04001476 RID: 5238
		private static readonly IntPtr NativeMethodInfoPtr_get_GetAbilityTiming_Public_get_AbilityTiming_0;

		// Token: 0x04001477 RID: 5239
		private static readonly IntPtr NativeMethodInfoPtr_HasMatchingTiming_Public_Boolean_PlayerTurnTypes_0;

		// Token: 0x04001478 RID: 5240
		private static readonly IntPtr NativeMethodInfoPtr_get_HasAgentOrRevealTiming_Public_get_Boolean_0;

		// Token: 0x04001479 RID: 5241
		private static readonly IntPtr NativeMethodInfoPtr_WillClearUndo_Public_Virtual_New_Boolean_WormPlayer_0;

		// Token: 0x020007D7 RID: 2007
		[ObfuscatedName("worm.canis.abilities.WormAbilityDefinition+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060071A4 RID: 29092 RVA: 0x0020FD18 File Offset: 0x0020DF18
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormAbilityDefinition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormAbilityDefinition>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormAbilityDefinition.__c>.NativeClassPtr);
				WormAbilityDefinition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityDefinition.__c>.NativeClassPtr, "<>9");
				WormAbilityDefinition.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityDefinition.__c>.NativeClassPtr, "<>9__4_0");
				WormAbilityDefinition.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityDefinition.__c>.NativeClassPtr, "<>9__8_0");
				WormAbilityDefinition.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormAbilityDefinition.__c>.NativeClassPtr, "<>9__18_0");
				WormAbilityDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition.__c>.NativeClassPtr, 100671232);
				WormAbilityDefinition.__c.NativeMethodInfoPtr__ValueInPileForOtherPlay_b__4_0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition.__c>.NativeClassPtr, 100671233);
				WormAbilityDefinition.__c.NativeMethodInfoPtr__IsUnexhausted_b__8_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition.__c>.NativeClassPtr, 100671234);
				WormAbilityDefinition.__c.NativeMethodInfoPtr__GetFactionTarget_b__18_0_Internal_Boolean_WormFactionTrack_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormAbilityDefinition.__c>.NativeClassPtr, 100671235);
			}

			// Token: 0x060071A5 RID: 29093 RVA: 0x0020FDE4 File Offset: 0x0020DFE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormAbilityDefinition.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityDefinition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060071A6 RID: 29094 RVA: 0x0020FE20 File Offset: 0x0020E020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 175224, XrefRangeEnd = 175227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ValueInPileForOtherPlay_b__4_0(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityDefinition.__c.NativeMethodInfoPtr__ValueInPileForOtherPlay_b__4_0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060071A7 RID: 29095 RVA: 0x0020FE70 File Offset: 0x0020E070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsUnexhausted_b__8_0(Entity dependency)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dependency);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityDefinition.__c.NativeMethodInfoPtr__IsUnexhausted_b__8_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060071A8 RID: 29096 RVA: 0x0020FEC0 File Offset: 0x0020E0C0
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFactionTarget_b__18_0(WormFactionTrack x, WormPlayer y)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormAbilityDefinition.__c.NativeMethodInfoPtr__GetFactionTarget_b__18_0_Internal_Boolean_WormFactionTrack_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060071A9 RID: 29097 RVA: 0x0002D25C File Offset: 0x0002B45C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001F40 RID: 8000
			// (get) Token: 0x060071AA RID: 29098 RVA: 0x0020FF20 File Offset: 0x0020E120
			// (set) Token: 0x060071AB RID: 29099 RVA: 0x0002D265 File Offset: 0x0002B465
			public unsafe static WormAbilityDefinition.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAbilityDefinition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAbilityDefinition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F41 RID: 8001
			// (get) Token: 0x060071AC RID: 29100 RVA: 0x0020FF48 File Offset: 0x0020E148
			// (set) Token: 0x060071AD RID: 29101 RVA: 0x0002D277 File Offset: 0x0002B477
			public unsafe static Func<WormAbilityDefinition, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAbilityDefinition.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAbilityDefinition.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F42 RID: 8002
			// (get) Token: 0x060071AE RID: 29102 RVA: 0x0020FF70 File Offset: 0x0020E170
			// (set) Token: 0x060071AF RID: 29103 RVA: 0x0002D289 File Offset: 0x0002B489
			public unsafe static Func<Entity, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAbilityDefinition.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAbilityDefinition.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001F43 RID: 8003
			// (get) Token: 0x060071B0 RID: 29104 RVA: 0x0020FF98 File Offset: 0x0020E198
			// (set) Token: 0x060071B1 RID: 29105 RVA: 0x0002D29B File Offset: 0x0002B49B
			public unsafe static Func<WormFactionTrack, WormPlayer, bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormAbilityDefinition.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormFactionTrack, WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormAbilityDefinition.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004969 RID: 18793
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400496A RID: 18794
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400496B RID: 18795
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400496C RID: 18796
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x0400496D RID: 18797
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400496E RID: 18798
			private static readonly IntPtr NativeMethodInfoPtr__ValueInPileForOtherPlay_b__4_0_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x0400496F RID: 18799
			private static readonly IntPtr NativeMethodInfoPtr__IsUnexhausted_b__8_0_Internal_Boolean_Entity_0;

			// Token: 0x04004970 RID: 18800
			private static readonly IntPtr NativeMethodInfoPtr__GetFactionTarget_b__18_0_Internal_Boolean_WormFactionTrack_WormPlayer_0;
		}
	}
}
