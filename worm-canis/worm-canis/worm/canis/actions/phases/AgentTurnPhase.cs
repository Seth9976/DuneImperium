using System;
using Canis;
using Canis.actions;
using Canis.attributes;
using Canis.context;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lib.canis.Canis.data;
using Networking.selection.messages.outgoing;
using worm.canis.abilities;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.abilities.PlayAbilities;
using worm.canis.abilities.SpaceAbilities;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002B0 RID: 688
	public class AgentTurnPhase : StateMachineAction<AgentTurnState>
	{
		// Token: 0x06001C55 RID: 7253 RVA: 0x000C6FC4 File Offset: 0x000C51C4
		// Note: this type is marked as 'beforefieldinit'.
		static AgentTurnPhase()
		{
			Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "AgentTurnPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr);
			AgentTurnPhase.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "wormMatch");
			AgentTurnPhase.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "player");
			AgentTurnPhase.NativeFieldInfoPtr_agentSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "agentSelection");
			AgentTurnPhase.NativeFieldInfoPtr_chosenSpaceAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "chosenSpaceAbility");
			AgentTurnPhase.NativeFieldInfoPtr_chosenAgentAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "chosenAgentAbilities");
			AgentTurnPhase.NativeFieldInfoPtr_chosenAgent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "chosenAgent");
			AgentTurnPhase.NativeFieldInfoPtr_undoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "undoNode");
			AgentTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_EntityIDTargetResponses_WormPlayer_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669121);
			AgentTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedAgentTurnPhase_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669122);
			AgentTurnPhase.NativeMethodInfoPtr_get_ParamContext_Private_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669123);
			AgentTurnPhase.NativeMethodInfoPtr_get_AgentCard_Private_get_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669124);
			AgentTurnPhase.NativeMethodInfoPtr_get_GraftedCard_Private_get_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669125);
			AgentTurnPhase.NativeMethodInfoPtr_get_ChosenSpace_Private_get_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669126);
			AgentTurnPhase.NativeMethodInfoPtr_get_CanGraft_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669127);
			AgentTurnPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_AgentTurnState_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669128);
			AgentTurnPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_AgentTurnState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669129);
			AgentTurnPhase.NativeMethodInfoPtr_InitializeAgentTurn_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669130);
			AgentTurnPhase.NativeMethodInfoPtr_GraftCard_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669131);
			AgentTurnPhase.NativeMethodInfoPtr_DetermineAbilities_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669132);
			AgentTurnPhase.NativeMethodInfoPtr_PlayAgentCard_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669133);
			AgentTurnPhase.NativeMethodInfoPtr_SendAgentToSpace_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669134);
			AgentTurnPhase.NativeMethodInfoPtr_ReevaluatePassiveAbilities_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669135);
			AgentTurnPhase.NativeMethodInfoPtr_ResolveFirstAbilities_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669136);
			AgentTurnPhase.NativeMethodInfoPtr_ResolveSpaceAbility_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669137);
			AgentTurnPhase.NativeMethodInfoPtr_ResolveAgentAbility_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669138);
			AgentTurnPhase.NativeMethodInfoPtr_ResolveImmediateDeferredAbilities_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669139);
			AgentTurnPhase.NativeMethodInfoPtr_FireTriggers_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669140);
			AgentTurnPhase.NativeMethodInfoPtr_GraftWillClearUndo_Private_Boolean_WormSpace_WormImperiumPlayable_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669141);
			AgentTurnPhase.NativeMethodInfoPtr_GraftUnusualSelections_Private_IEnumerable_1_UnusualSelection_WormSpace_WormImperiumPlayable_List_1_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669142);
			AgentTurnPhase.NativeMethodInfoPtr_GraftedExtraSupply_Private_Static_Int32_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669143);
			AgentTurnPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669144);
			AgentTurnPhase.NativeMethodInfoPtr__get_ChosenSpace_b__16_0_Private_IEnumerable_1_WormSpace_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669145);
			AgentTurnPhase.NativeMethodInfoPtr__DetermineAbilities_b__23_0_Private_Boolean_SpaceAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669146);
			AgentTurnPhase.NativeMethodInfoPtr__DetermineAbilities_b__23_1_Private_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, 100669147);
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x000C729C File Offset: 0x000C549C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151685, RefRangeEnd = 151686, XrefRangeStart = 151669, XrefRangeEnd = 151685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AgentTurnPhase(EntityIDTargetResponses agentSelection, WormPlayer player, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(agentSelection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_EntityIDTargetResponses_WormPlayer_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x000C730C File Offset: 0x000C550C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151735, RefRangeEnd = 151736, XrefRangeStart = 151686, XrefRangeEnd = 151735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AgentTurnPhase(SerializedAgentTurnPhase serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedAgentTurnPhase_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x000C736C File Offset: 0x000C556C
		public unsafe Context ParamContext
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 151757, RefRangeEnd = 151761, XrefRangeStart = 151736, XrefRangeEnd = 151757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_get_ParamContext_Private_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001C59 RID: 7257 RVA: 0x000C73AC File Offset: 0x000C55AC
		public unsafe WormImperiumPlayable AgentCard
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 151768, RefRangeEnd = 151779, XrefRangeStart = 151761, XrefRangeEnd = 151768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_get_AgentCard_Private_get_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr3) : null;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x000C73EC File Offset: 0x000C55EC
		public unsafe WormImperiumPlayable GraftedCard
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151779, XrefRangeEnd = 151781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_get_GraftedCard_Private_get_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr3) : null;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001C5B RID: 7259 RVA: 0x000C742C File Offset: 0x000C562C
		public unsafe WormSpace ChosenSpace
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 151799, RefRangeEnd = 151810, XrefRangeStart = 151781, XrefRangeEnd = 151799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_get_ChosenSpace_Private_get_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr3) : null;
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x000C746C File Offset: 0x000C566C
		public unsafe bool CanGraft
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151810, XrefRangeEnd = 151832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_get_CanGraft_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x000C74A8 File Offset: 0x000C56A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151832, XrefRangeEnd = 151943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<AgentTurnState> DetermineNextTypedState(global::Canis.actions.Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentTurnPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_AgentTurnState_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<AgentTurnState>(intPtr);
			}
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x000C74FC File Offset: 0x000C56FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151943, XrefRangeEnd = 151959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior TypedBehaviorFor(AgentTurnState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentTurnPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_AgentTurnState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x000C7554 File Offset: 0x000C5754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151959, XrefRangeEnd = 151965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> InitializeAgentTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_InitializeAgentTurn_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C60 RID: 7264 RVA: 0x000C7594 File Offset: 0x000C5794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151965, XrefRangeEnd = 151971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> GraftCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_GraftCard_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C61 RID: 7265 RVA: 0x000C75D4 File Offset: 0x000C57D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151971, XrefRangeEnd = 151977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> DetermineAbilities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_DetermineAbilities_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x000C7614 File Offset: 0x000C5814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151977, XrefRangeEnd = 151983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> PlayAgentCard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_PlayAgentCard_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x000C7654 File Offset: 0x000C5854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151983, XrefRangeEnd = 151989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> SendAgentToSpace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_SendAgentToSpace_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x000C7694 File Offset: 0x000C5894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151989, XrefRangeEnd = 151995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ReevaluatePassiveAbilities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_ReevaluatePassiveAbilities_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x000C76D4 File Offset: 0x000C58D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151995, XrefRangeEnd = 152001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ResolveFirstAbilities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_ResolveFirstAbilities_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x000C7714 File Offset: 0x000C5914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152001, XrefRangeEnd = 152007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ResolveSpaceAbility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_ResolveSpaceAbility_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x000C7754 File Offset: 0x000C5954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152007, XrefRangeEnd = 152013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ResolveAgentAbility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_ResolveAgentAbility_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x000C7794 File Offset: 0x000C5994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152013, XrefRangeEnd = 152019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ResolveImmediateDeferredAbilities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_ResolveImmediateDeferredAbilities_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x000C77D4 File Offset: 0x000C59D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152019, XrefRangeEnd = 152025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> FireTriggers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_FireTriggers_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x000C7814 File Offset: 0x000C5A14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152209, RefRangeEnd = 152210, XrefRangeStart = 152025, XrefRangeEnd = 152209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GraftWillClearUndo(WormSpace space, WormImperiumPlayable agentCard, WormImperiumPlayable graftCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(agentCard);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graftCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_GraftWillClearUndo_Private_Boolean_WormSpace_WormImperiumPlayable_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x000C7888 File Offset: 0x000C5A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152393, RefRangeEnd = 152394, XrefRangeStart = 152210, XrefRangeEnd = 152393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<UnusualSelection> GraftUnusualSelections(WormSpace space, WormImperiumPlayable agentCard, List<WormImperiumPlayable> graftList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(agentCard);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graftList);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_GraftUnusualSelections_Private_IEnumerable_1_UnusualSelection_WormSpace_WormImperiumPlayable_List_1_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<UnusualSelection>>(intPtr3) : null;
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x000C78FC File Offset: 0x000C5AFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152453, RefRangeEnd = 152454, XrefRangeStart = 152394, XrefRangeEnd = 152453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GraftedExtraSupply(Entity agentCard, Entity graftCard)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(agentCard);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(graftCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr_GraftedExtraSupply_Private_Static_Int32_Entity_Entity_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x000C7950 File Offset: 0x000C5B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152454, XrefRangeEnd = 152488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AgentTurnPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x000C79AC File Offset: 0x000C5BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152488, XrefRangeEnd = 152498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormSpace> _get_ChosenSpace_b__16_0(EntityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr__get_ChosenSpace_b__16_0_Private_IEnumerable_1_WormSpace_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormSpace>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x000C79FC File Offset: 0x000C5BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152498, XrefRangeEnd = 152499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _DetermineAbilities_b__23_0(SpaceAbility _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr__DetermineAbilities_b__23_0_Private_Boolean_SpaceAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x000C7A4C File Offset: 0x000C5C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152499, XrefRangeEnd = 152501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _DetermineAbilities_b__23_1(WormAbilityDefinition _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.NativeMethodInfoPtr__DetermineAbilities_b__23_1_Private_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0000C02F File Offset: 0x0000A22F
		public AgentTurnPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001C72 RID: 7282 RVA: 0x000C7A9C File Offset: 0x000C5C9C
		// (set) Token: 0x06001C73 RID: 7283 RVA: 0x0000C038 File Offset: 0x0000A238
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001C74 RID: 7284 RVA: 0x000C7ACC File Offset: 0x000C5CCC
		// (set) Token: 0x06001C75 RID: 7285 RVA: 0x0000C057 File Offset: 0x0000A257
		public unsafe WormPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001C76 RID: 7286 RVA: 0x000C7AFC File Offset: 0x000C5CFC
		// (set) Token: 0x06001C77 RID: 7287 RVA: 0x0000C076 File Offset: 0x0000A276
		public unsafe EntityIDTargetResponses agentSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_agentSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityIDTargetResponses>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_agentSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001C78 RID: 7288 RVA: 0x000C7B2C File Offset: 0x000C5D2C
		// (set) Token: 0x06001C79 RID: 7289 RVA: 0x0000C095 File Offset: 0x0000A295
		public unsafe SpaceAbility chosenSpaceAbility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_chosenSpaceAbility);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpaceAbility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_chosenSpaceAbility), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001C7A RID: 7290 RVA: 0x000C7B5C File Offset: 0x000C5D5C
		// (set) Token: 0x06001C7B RID: 7291 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		public unsafe List<AgentAbility> chosenAgentAbilities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_chosenAgentAbilities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AgentAbility>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_chosenAgentAbilities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001C7C RID: 7292 RVA: 0x000C7B8C File Offset: 0x000C5D8C
		// (set) Token: 0x06001C7D RID: 7293 RVA: 0x0000C0D3 File Offset: 0x0000A2D3
		public unsafe WormAgent chosenAgent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_chosenAgent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAgent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_chosenAgent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001C7E RID: 7294 RVA: 0x000C7BBC File Offset: 0x000C5DBC
		// (set) Token: 0x06001C7F RID: 7295 RVA: 0x0000C0F2 File Offset: 0x0000A2F2
		public unsafe UndoNode undoNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_undoNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.NativeFieldInfoPtr_undoNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeFieldInfoPtr_agentSelection;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeFieldInfoPtr_chosenSpaceAbility;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeFieldInfoPtr_chosenAgentAbilities;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeFieldInfoPtr_chosenAgent;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeFieldInfoPtr_undoNode;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityIDTargetResponses_WormPlayer_WormMatch_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedAgentTurnPhase_WormMatch_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_get_ParamContext_Private_get_Context_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_get_AgentCard_Private_get_WormImperiumPlayable_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_get_GraftedCard_Private_get_WormImperiumPlayable_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_get_ChosenSpace_Private_get_WormSpace_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_get_CanGraft_Private_get_Boolean_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_AgentTurnState_Action_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_AgentTurnState_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAgentTurn_Private_IEnumerable_1_Action_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_GraftCard_Private_IEnumerable_1_Action_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_DetermineAbilities_Private_IEnumerable_1_Action_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_PlayAgentCard_Private_IEnumerable_1_Action_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_SendAgentToSpace_Private_IEnumerable_1_Action_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_ReevaluatePassiveAbilities_Private_IEnumerable_1_Action_0;

		// Token: 0x0400119D RID: 4509
		private static readonly IntPtr NativeMethodInfoPtr_ResolveFirstAbilities_Private_IEnumerable_1_Action_0;

		// Token: 0x0400119E RID: 4510
		private static readonly IntPtr NativeMethodInfoPtr_ResolveSpaceAbility_Private_IEnumerable_1_Action_0;

		// Token: 0x0400119F RID: 4511
		private static readonly IntPtr NativeMethodInfoPtr_ResolveAgentAbility_Private_IEnumerable_1_Action_0;

		// Token: 0x040011A0 RID: 4512
		private static readonly IntPtr NativeMethodInfoPtr_ResolveImmediateDeferredAbilities_Private_IEnumerable_1_Action_0;

		// Token: 0x040011A1 RID: 4513
		private static readonly IntPtr NativeMethodInfoPtr_FireTriggers_Private_IEnumerable_1_Action_0;

		// Token: 0x040011A2 RID: 4514
		private static readonly IntPtr NativeMethodInfoPtr_GraftWillClearUndo_Private_Boolean_WormSpace_WormImperiumPlayable_WormImperiumPlayable_0;

		// Token: 0x040011A3 RID: 4515
		private static readonly IntPtr NativeMethodInfoPtr_GraftUnusualSelections_Private_IEnumerable_1_UnusualSelection_WormSpace_WormImperiumPlayable_List_1_WormImperiumPlayable_0;

		// Token: 0x040011A4 RID: 4516
		private static readonly IntPtr NativeMethodInfoPtr_GraftedExtraSupply_Private_Static_Int32_Entity_Entity_0;

		// Token: 0x040011A5 RID: 4517
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;

		// Token: 0x040011A6 RID: 4518
		private static readonly IntPtr NativeMethodInfoPtr__get_ChosenSpace_b__16_0_Private_IEnumerable_1_WormSpace_EntityID_0;

		// Token: 0x040011A7 RID: 4519
		private static readonly IntPtr NativeMethodInfoPtr__DetermineAbilities_b__23_0_Private_Boolean_SpaceAbility_0;

		// Token: 0x040011A8 RID: 4520
		private static readonly IntPtr NativeMethodInfoPtr__DetermineAbilities_b__23_1_Private_Boolean_WormAbilityDefinition_0;

		// Token: 0x020006FF RID: 1791
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006169 RID: 24937 RVA: 0x001DC658 File Offset: 0x001DA858
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr);
				AgentTurnPhase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__18_0");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__19_0");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__22_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__22_4");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__27_0");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__27_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__27_1");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__27_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__27_2");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__32_0");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__32_1");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__32_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__32_3");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__33_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__33_0");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__33_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__33_1");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__33_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__33_2");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__33_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__33_3");
				AgentTurnPhase.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, "<>9__35_0");
				AgentTurnPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669149);
				AgentTurnPhase.__c.NativeMethodInfoPtr__get_CanGraft_b__18_0_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669150);
				AgentTurnPhase.__c.NativeMethodInfoPtr__DetermineNextTypedState_b__19_0_Internal_Boolean_AgentAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669151);
				AgentTurnPhase.__c.NativeMethodInfoPtr__GraftCard_b__22_4_Internal_EntityID_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669152);
				AgentTurnPhase.__c.NativeMethodInfoPtr__ResolveFirstAbilities_b__27_0_Internal_Boolean_AgentAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669153);
				AgentTurnPhase.__c.NativeMethodInfoPtr__ResolveFirstAbilities_b__27_1_Internal_Boolean_AgentAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669154);
				AgentTurnPhase.__c.NativeMethodInfoPtr__ResolveFirstAbilities_b__27_2_Internal_Boolean_AgentAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669155);
				AgentTurnPhase.__c.NativeMethodInfoPtr__GraftWillClearUndo_b__32_0_Internal_Boolean_SpaceAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669156);
				AgentTurnPhase.__c.NativeMethodInfoPtr__GraftWillClearUndo_b__32_1_Internal_Boolean_AgentAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669157);
				AgentTurnPhase.__c.NativeMethodInfoPtr__GraftWillClearUndo_b__32_3_Internal_Boolean_AgentAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669158);
				AgentTurnPhase.__c.NativeMethodInfoPtr__GraftUnusualSelections_b__33_0_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669159);
				AgentTurnPhase.__c.NativeMethodInfoPtr__GraftUnusualSelections_b__33_1_Internal_EntityID_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669160);
				AgentTurnPhase.__c.NativeMethodInfoPtr__GraftUnusualSelections_b__33_2_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669161);
				AgentTurnPhase.__c.NativeMethodInfoPtr__GraftUnusualSelections_b__33_3_Internal_EntityID_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669162);
				AgentTurnPhase.__c.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__35_0_Internal_EntityID_AgentAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr, 100669163);
			}

			// Token: 0x0600616A RID: 24938 RVA: 0x001DC8DC File Offset: 0x001DAADC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600616B RID: 24939 RVA: 0x001DC918 File Offset: 0x001DAB18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150874, XrefRangeEnd = 150879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_CanGraft_b__18_0(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__get_CanGraft_b__18_0_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600616C RID: 24940 RVA: 0x001DC968 File Offset: 0x001DAB68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150879, XrefRangeEnd = 150882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineNextTypedState_b__19_0(AgentAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__DetermineNextTypedState_b__19_0_Internal_Boolean_AgentAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600616D RID: 24941 RVA: 0x001DC9B8 File Offset: 0x001DABB8
			[CallerCount(0)]
			public unsafe EntityID _GraftCard_b__22_4(WormImperiumPlayable gc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gc);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__GraftCard_b__22_4_Internal_EntityID_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x0600616E RID: 24942 RVA: 0x001DCA08 File Offset: 0x001DAC08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150882, XrefRangeEnd = 150883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveFirstAbilities_b__27_0(AgentAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__ResolveFirstAbilities_b__27_0_Internal_Boolean_AgentAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600616F RID: 24943 RVA: 0x001DCA58 File Offset: 0x001DAC58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150883, XrefRangeEnd = 150884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveFirstAbilities_b__27_1(AgentAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__ResolveFirstAbilities_b__27_1_Internal_Boolean_AgentAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006170 RID: 24944 RVA: 0x001DCAA8 File Offset: 0x001DACA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150884, XrefRangeEnd = 150885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveFirstAbilities_b__27_2(AgentAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__ResolveFirstAbilities_b__27_2_Internal_Boolean_AgentAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006171 RID: 24945 RVA: 0x001DCAF8 File Offset: 0x001DACF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150885, XrefRangeEnd = 150893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftWillClearUndo_b__32_0(SpaceAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__GraftWillClearUndo_b__32_0_Internal_Boolean_SpaceAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006172 RID: 24946 RVA: 0x001DCB48 File Offset: 0x001DAD48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150893, XrefRangeEnd = 150901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftWillClearUndo_b__32_1(AgentAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__GraftWillClearUndo_b__32_1_Internal_Boolean_AgentAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006173 RID: 24947 RVA: 0x001DCB98 File Offset: 0x001DAD98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150901, XrefRangeEnd = 150909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftWillClearUndo_b__32_3(AgentAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__GraftWillClearUndo_b__32_3_Internal_Boolean_AgentAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006174 RID: 24948 RVA: 0x001DCBE8 File Offset: 0x001DADE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150909, XrefRangeEnd = 150919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftUnusualSelections_b__33_0(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__GraftUnusualSelections_b__33_0_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006175 RID: 24949 RVA: 0x001DCC38 File Offset: 0x001DAE38
			[CallerCount(0)]
			public unsafe EntityID _GraftUnusualSelections_b__33_1(WormImperiumPlayable e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__GraftUnusualSelections_b__33_1_Internal_EntityID_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06006176 RID: 24950 RVA: 0x001DCC88 File Offset: 0x001DAE88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150919, XrefRangeEnd = 150928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftUnusualSelections_b__33_2(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__GraftUnusualSelections_b__33_2_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006177 RID: 24951 RVA: 0x001DCCD8 File Offset: 0x001DAED8
			[CallerCount(0)]
			public unsafe EntityID _GraftUnusualSelections_b__33_3(WormImperiumPlayable e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__GraftUnusualSelections_b__33_3_Internal_EntityID_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06006178 RID: 24952 RVA: 0x001DCD28 File Offset: 0x001DAF28
			[CallerCount(0)]
			public unsafe EntityID _MakeSerializedStateMachineAction_b__35_0(AgentAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__35_0_Internal_EntityID_AgentAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x06006179 RID: 24953 RVA: 0x000256A9 File Offset: 0x000238A9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019EB RID: 6635
			// (get) Token: 0x0600617A RID: 24954 RVA: 0x001DCD78 File Offset: 0x001DAF78
			// (set) Token: 0x0600617B RID: 24955 RVA: 0x000256B2 File Offset: 0x000238B2
			public unsafe static AgentTurnPhase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019EC RID: 6636
			// (get) Token: 0x0600617C RID: 24956 RVA: 0x001DCDA0 File Offset: 0x001DAFA0
			// (set) Token: 0x0600617D RID: 24957 RVA: 0x000256C4 File Offset: 0x000238C4
			public unsafe static Func<WormImperiumPlayable, bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019ED RID: 6637
			// (get) Token: 0x0600617E RID: 24958 RVA: 0x001DCDC8 File Offset: 0x001DAFC8
			// (set) Token: 0x0600617F RID: 24959 RVA: 0x000256D6 File Offset: 0x000238D6
			public unsafe static Func<AgentAbility, bool> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AgentAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019EE RID: 6638
			// (get) Token: 0x06006180 RID: 24960 RVA: 0x001DCDF0 File Offset: 0x001DAFF0
			// (set) Token: 0x06006181 RID: 24961 RVA: 0x000256E8 File Offset: 0x000238E8
			public unsafe static Func<WormImperiumPlayable, EntityID> __9__22_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__22_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__22_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019EF RID: 6639
			// (get) Token: 0x06006182 RID: 24962 RVA: 0x001DCE18 File Offset: 0x001DB018
			// (set) Token: 0x06006183 RID: 24963 RVA: 0x000256FA File Offset: 0x000238FA
			public unsafe static Func<AgentAbility, bool> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AgentAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019F0 RID: 6640
			// (get) Token: 0x06006184 RID: 24964 RVA: 0x001DCE40 File Offset: 0x001DB040
			// (set) Token: 0x06006185 RID: 24965 RVA: 0x0002570C File Offset: 0x0002390C
			public unsafe static Func<AgentAbility, bool> __9__27_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__27_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AgentAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__27_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019F1 RID: 6641
			// (get) Token: 0x06006186 RID: 24966 RVA: 0x001DCE68 File Offset: 0x001DB068
			// (set) Token: 0x06006187 RID: 24967 RVA: 0x0002571E File Offset: 0x0002391E
			public unsafe static Func<AgentAbility, bool> __9__27_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__27_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AgentAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__27_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019F2 RID: 6642
			// (get) Token: 0x06006188 RID: 24968 RVA: 0x001DCE90 File Offset: 0x001DB090
			// (set) Token: 0x06006189 RID: 24969 RVA: 0x00025730 File Offset: 0x00023930
			public unsafe static Func<SpaceAbility, bool> __9__32_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpaceAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__32_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019F3 RID: 6643
			// (get) Token: 0x0600618A RID: 24970 RVA: 0x001DCEB8 File Offset: 0x001DB0B8
			// (set) Token: 0x0600618B RID: 24971 RVA: 0x00025742 File Offset: 0x00023942
			public unsafe static Func<AgentAbility, bool> __9__32_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__32_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AgentAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__32_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019F4 RID: 6644
			// (get) Token: 0x0600618C RID: 24972 RVA: 0x001DCEE0 File Offset: 0x001DB0E0
			// (set) Token: 0x0600618D RID: 24973 RVA: 0x00025754 File Offset: 0x00023954
			public unsafe static Func<AgentAbility, bool> __9__32_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__32_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AgentAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__32_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019F5 RID: 6645
			// (get) Token: 0x0600618E RID: 24974 RVA: 0x001DCF08 File Offset: 0x001DB108
			// (set) Token: 0x0600618F RID: 24975 RVA: 0x00025766 File Offset: 0x00023966
			public unsafe static Func<WormImperiumPlayable, bool> __9__33_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__33_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__33_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019F6 RID: 6646
			// (get) Token: 0x06006190 RID: 24976 RVA: 0x001DCF30 File Offset: 0x001DB130
			// (set) Token: 0x06006191 RID: 24977 RVA: 0x00025778 File Offset: 0x00023978
			public unsafe static Func<WormImperiumPlayable, EntityID> __9__33_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__33_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__33_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019F7 RID: 6647
			// (get) Token: 0x06006192 RID: 24978 RVA: 0x001DCF58 File Offset: 0x001DB158
			// (set) Token: 0x06006193 RID: 24979 RVA: 0x0002578A File Offset: 0x0002398A
			public unsafe static Func<WormImperiumPlayable, bool> __9__33_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__33_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__33_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019F8 RID: 6648
			// (get) Token: 0x06006194 RID: 24980 RVA: 0x001DCF80 File Offset: 0x001DB180
			// (set) Token: 0x06006195 RID: 24981 RVA: 0x0002579C File Offset: 0x0002399C
			public unsafe static Func<WormImperiumPlayable, EntityID> __9__33_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__33_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__33_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019F9 RID: 6649
			// (get) Token: 0x06006196 RID: 24982 RVA: 0x001DCFA8 File Offset: 0x001DB1A8
			// (set) Token: 0x06006197 RID: 24983 RVA: 0x000257AE File Offset: 0x000239AE
			public unsafe static Func<AgentAbility, EntityID> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AgentAbility, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AgentTurnPhase.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F21 RID: 16161
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003F22 RID: 16162
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04003F23 RID: 16163
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04003F24 RID: 16164
			private static readonly IntPtr NativeFieldInfoPtr___9__22_4;

			// Token: 0x04003F25 RID: 16165
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x04003F26 RID: 16166
			private static readonly IntPtr NativeFieldInfoPtr___9__27_1;

			// Token: 0x04003F27 RID: 16167
			private static readonly IntPtr NativeFieldInfoPtr___9__27_2;

			// Token: 0x04003F28 RID: 16168
			private static readonly IntPtr NativeFieldInfoPtr___9__32_0;

			// Token: 0x04003F29 RID: 16169
			private static readonly IntPtr NativeFieldInfoPtr___9__32_1;

			// Token: 0x04003F2A RID: 16170
			private static readonly IntPtr NativeFieldInfoPtr___9__32_3;

			// Token: 0x04003F2B RID: 16171
			private static readonly IntPtr NativeFieldInfoPtr___9__33_0;

			// Token: 0x04003F2C RID: 16172
			private static readonly IntPtr NativeFieldInfoPtr___9__33_1;

			// Token: 0x04003F2D RID: 16173
			private static readonly IntPtr NativeFieldInfoPtr___9__33_2;

			// Token: 0x04003F2E RID: 16174
			private static readonly IntPtr NativeFieldInfoPtr___9__33_3;

			// Token: 0x04003F2F RID: 16175
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x04003F30 RID: 16176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003F31 RID: 16177
			private static readonly IntPtr NativeMethodInfoPtr__get_CanGraft_b__18_0_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04003F32 RID: 16178
			private static readonly IntPtr NativeMethodInfoPtr__DetermineNextTypedState_b__19_0_Internal_Boolean_AgentAbility_0;

			// Token: 0x04003F33 RID: 16179
			private static readonly IntPtr NativeMethodInfoPtr__GraftCard_b__22_4_Internal_EntityID_WormImperiumPlayable_0;

			// Token: 0x04003F34 RID: 16180
			private static readonly IntPtr NativeMethodInfoPtr__ResolveFirstAbilities_b__27_0_Internal_Boolean_AgentAbility_0;

			// Token: 0x04003F35 RID: 16181
			private static readonly IntPtr NativeMethodInfoPtr__ResolveFirstAbilities_b__27_1_Internal_Boolean_AgentAbility_0;

			// Token: 0x04003F36 RID: 16182
			private static readonly IntPtr NativeMethodInfoPtr__ResolveFirstAbilities_b__27_2_Internal_Boolean_AgentAbility_0;

			// Token: 0x04003F37 RID: 16183
			private static readonly IntPtr NativeMethodInfoPtr__GraftWillClearUndo_b__32_0_Internal_Boolean_SpaceAbility_0;

			// Token: 0x04003F38 RID: 16184
			private static readonly IntPtr NativeMethodInfoPtr__GraftWillClearUndo_b__32_1_Internal_Boolean_AgentAbility_0;

			// Token: 0x04003F39 RID: 16185
			private static readonly IntPtr NativeMethodInfoPtr__GraftWillClearUndo_b__32_3_Internal_Boolean_AgentAbility_0;

			// Token: 0x04003F3A RID: 16186
			private static readonly IntPtr NativeMethodInfoPtr__GraftUnusualSelections_b__33_0_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04003F3B RID: 16187
			private static readonly IntPtr NativeMethodInfoPtr__GraftUnusualSelections_b__33_1_Internal_EntityID_WormImperiumPlayable_0;

			// Token: 0x04003F3C RID: 16188
			private static readonly IntPtr NativeMethodInfoPtr__GraftUnusualSelections_b__33_2_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04003F3D RID: 16189
			private static readonly IntPtr NativeMethodInfoPtr__GraftUnusualSelections_b__33_3_Internal_EntityID_WormImperiumPlayable_0;

			// Token: 0x04003F3E RID: 16190
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__35_0_Internal_EntityID_AgentAbility_0;
		}

		// Token: 0x02000700 RID: 1792
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Object
		{
			// Token: 0x06006198 RID: 24984 RVA: 0x001DCFD0 File Offset: 0x001DB1D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_0>.NativeClassPtr);
				AgentTurnPhase.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				AgentTurnPhase.__c__DisplayClass22_0.NativeFieldInfoPtr_agentCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_0>.NativeClassPtr, "agentCard");
				AgentTurnPhase.__c__DisplayClass22_0.NativeFieldInfoPtr_choseGraft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_0>.NativeClassPtr, "choseGraft");
				AgentTurnPhase.__c__DisplayClass22_0.NativeFieldInfoPtr_missingSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_0>.NativeClassPtr, "missingSpace");
				AgentTurnPhase.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_0>.NativeClassPtr, 100669164);
				AgentTurnPhase.__c__DisplayClass22_0.NativeMethodInfoPtr__GraftCard_b__0_Internal_Boolean_SpaceAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_0>.NativeClassPtr, 100669165);
				AgentTurnPhase.__c__DisplayClass22_0.NativeMethodInfoPtr__GraftCard_b__1_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_0>.NativeClassPtr, 100669166);
				AgentTurnPhase.__c__DisplayClass22_0.NativeMethodInfoPtr__GraftCard_b__5_Internal_ReadOnlyAttributes_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_0>.NativeClassPtr, 100669167);
			}

			// Token: 0x06006199 RID: 24985 RVA: 0x001DD09C File Offset: 0x001DB29C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600619A RID: 24986 RVA: 0x001DD0D8 File Offset: 0x001DB2D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150928, XrefRangeEnd = 150929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftCard_b__0(SpaceAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass22_0.NativeMethodInfoPtr__GraftCard_b__0_Internal_Boolean_SpaceAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600619B RID: 24987 RVA: 0x001DD128 File Offset: 0x001DB328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150929, XrefRangeEnd = 150976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftCard_b__1(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass22_0.NativeMethodInfoPtr__GraftCard_b__1_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600619C RID: 24988 RVA: 0x001DD178 File Offset: 0x001DB378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150976, XrefRangeEnd = 150998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadOnlyAttributes _GraftCard_b__5(WormImperiumPlayable gc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gc);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass22_0.NativeMethodInfoPtr__GraftCard_b__5_Internal_ReadOnlyAttributes_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr3) : null;
				}
			}

			// Token: 0x0600619D RID: 24989 RVA: 0x000257C0 File Offset: 0x000239C0
			public __c__DisplayClass22_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019FA RID: 6650
			// (get) Token: 0x0600619E RID: 24990 RVA: 0x001DD1C8 File Offset: 0x001DB3C8
			// (set) Token: 0x0600619F RID: 24991 RVA: 0x000257C9 File Offset: 0x000239C9
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019FB RID: 6651
			// (get) Token: 0x060061A0 RID: 24992 RVA: 0x001DD1F8 File Offset: 0x001DB3F8
			// (set) Token: 0x060061A1 RID: 24993 RVA: 0x000257E8 File Offset: 0x000239E8
			public unsafe WormImperiumPlayable agentCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass22_0.NativeFieldInfoPtr_agentCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass22_0.NativeFieldInfoPtr_agentCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019FC RID: 6652
			// (get) Token: 0x060061A2 RID: 24994 RVA: 0x001DD228 File Offset: 0x001DB428
			// (set) Token: 0x060061A3 RID: 24995 RVA: 0x00025807 File Offset: 0x00023A07
			public unsafe bool choseGraft
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass22_0.NativeFieldInfoPtr_choseGraft);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass22_0.NativeFieldInfoPtr_choseGraft)) = value;
				}
			}

			// Token: 0x170019FD RID: 6653
			// (get) Token: 0x060061A4 RID: 24996 RVA: 0x001DD250 File Offset: 0x001DB450
			// (set) Token: 0x060061A5 RID: 24997 RVA: 0x00025822 File Offset: 0x00023A22
			public unsafe bool missingSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass22_0.NativeFieldInfoPtr_missingSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass22_0.NativeFieldInfoPtr_missingSpace)) = value;
				}
			}

			// Token: 0x04003F3F RID: 16191
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F40 RID: 16192
			private static readonly IntPtr NativeFieldInfoPtr_agentCard;

			// Token: 0x04003F41 RID: 16193
			private static readonly IntPtr NativeFieldInfoPtr_choseGraft;

			// Token: 0x04003F42 RID: 16194
			private static readonly IntPtr NativeFieldInfoPtr_missingSpace;

			// Token: 0x04003F43 RID: 16195
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003F44 RID: 16196
			private static readonly IntPtr NativeMethodInfoPtr__GraftCard_b__0_Internal_Boolean_SpaceAbility_0;

			// Token: 0x04003F45 RID: 16197
			private static readonly IntPtr NativeMethodInfoPtr__GraftCard_b__1_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04003F46 RID: 16198
			private static readonly IntPtr NativeMethodInfoPtr__GraftCard_b__5_Internal_ReadOnlyAttributes_WormImperiumPlayable_0;
		}

		// Token: 0x02000701 RID: 1793
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<>c__DisplayClass22_1")]
		public sealed class __c__DisplayClass22_1 : Object
		{
			// Token: 0x060061A6 RID: 24998 RVA: 0x001DD278 File Offset: 0x001DB478
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_1()
			{
				Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<>c__DisplayClass22_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_1>.NativeClassPtr);
				AgentTurnPhase.__c__DisplayClass22_1.NativeFieldInfoPtr_iconContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_1>.NativeClassPtr, "iconContext");
				AgentTurnPhase.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_1>.NativeClassPtr, "CS$<>8__locals1");
				AgentTurnPhase.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_1>.NativeClassPtr, 100669168);
				AgentTurnPhase.__c__DisplayClass22_1.NativeMethodInfoPtr__GraftCard_b__2_Internal_Boolean_AgentAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_1>.NativeClassPtr, 100669169);
				AgentTurnPhase.__c__DisplayClass22_1.NativeMethodInfoPtr__GraftCard_b__3_Internal_Boolean_SpaceAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_1>.NativeClassPtr, 100669170);
			}

			// Token: 0x060061A7 RID: 24999 RVA: 0x001DD308 File Offset: 0x001DB508
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass22_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061A8 RID: 25000 RVA: 0x001DD344 File Offset: 0x001DB544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150998, XrefRangeEnd = 150999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftCard_b__2(AgentAbility agentAbility)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(agentAbility);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass22_1.NativeMethodInfoPtr__GraftCard_b__2_Internal_Boolean_AgentAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060061A9 RID: 25001 RVA: 0x001DD394 File Offset: 0x001DB594
			[CallerCount(0)]
			public unsafe bool _GraftCard_b__3(SpaceAbility spaceAbility)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(spaceAbility);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass22_1.NativeMethodInfoPtr__GraftCard_b__3_Internal_Boolean_SpaceAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060061AA RID: 25002 RVA: 0x0002583D File Offset: 0x00023A3D
			public __c__DisplayClass22_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170019FE RID: 6654
			// (get) Token: 0x060061AB RID: 25003 RVA: 0x001DD3E4 File Offset: 0x001DB5E4
			// (set) Token: 0x060061AC RID: 25004 RVA: 0x00025846 File Offset: 0x00023A46
			public unsafe Context iconContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass22_1.NativeFieldInfoPtr_iconContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass22_1.NativeFieldInfoPtr_iconContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170019FF RID: 6655
			// (get) Token: 0x060061AD RID: 25005 RVA: 0x001DD414 File Offset: 0x001DB614
			// (set) Token: 0x060061AE RID: 25006 RVA: 0x00025865 File Offset: 0x00023A65
			public unsafe AgentTurnPhase.__c__DisplayClass22_0 field_Public___c__DisplayClass22_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase.__c__DisplayClass22_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F47 RID: 16199
			private static readonly IntPtr NativeFieldInfoPtr_iconContext;

			// Token: 0x04003F48 RID: 16200
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0;

			// Token: 0x04003F49 RID: 16201
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003F4A RID: 16202
			private static readonly IntPtr NativeMethodInfoPtr__GraftCard_b__2_Internal_Boolean_AgentAbility_0;

			// Token: 0x04003F4B RID: 16203
			private static readonly IntPtr NativeMethodInfoPtr__GraftCard_b__3_Internal_Boolean_SpaceAbility_0;
		}

		// Token: 0x02000702 RID: 1794
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Object
		{
			// Token: 0x060061AF RID: 25007 RVA: 0x001DD444 File Offset: 0x001DB644
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass30_0>.NativeClassPtr);
				AgentTurnPhase.__c__DisplayClass30_0.NativeFieldInfoPtr_evalContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass30_0>.NativeClassPtr, "evalContext");
				AgentTurnPhase.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass30_0>.NativeClassPtr, 100669171);
				AgentTurnPhase.__c__DisplayClass30_0.NativeMethodInfoPtr__ResolveImmediateDeferredAbilities_b__0_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass30_0>.NativeClassPtr, 100669172);
			}

			// Token: 0x060061B0 RID: 25008 RVA: 0x001DD4AC File Offset: 0x001DB6AC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061B1 RID: 25009 RVA: 0x001DD4E8 File Offset: 0x001DB6E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150999, XrefRangeEnd = 151000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveImmediateDeferredAbilities_b__0(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass30_0.NativeMethodInfoPtr__ResolveImmediateDeferredAbilities_b__0_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060061B2 RID: 25010 RVA: 0x00025884 File Offset: 0x00023A84
			public __c__DisplayClass30_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A00 RID: 6656
			// (get) Token: 0x060061B3 RID: 25011 RVA: 0x001DD538 File Offset: 0x001DB738
			// (set) Token: 0x060061B4 RID: 25012 RVA: 0x0002588D File Offset: 0x00023A8D
			public unsafe Context evalContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass30_0.NativeFieldInfoPtr_evalContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass30_0.NativeFieldInfoPtr_evalContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F4C RID: 16204
			private static readonly IntPtr NativeFieldInfoPtr_evalContext;

			// Token: 0x04003F4D RID: 16205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003F4E RID: 16206
			private static readonly IntPtr NativeMethodInfoPtr__ResolveImmediateDeferredAbilities_b__0_Internal_Boolean_DeferredAbility_0;
		}

		// Token: 0x02000703 RID: 1795
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Object
		{
			// Token: 0x060061B5 RID: 25013 RVA: 0x001DD568 File Offset: 0x001DB768
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass32_0>.NativeClassPtr);
				AgentTurnPhase.__c__DisplayClass32_0.NativeFieldInfoPtr_agentCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass32_0>.NativeClassPtr, "agentCard");
				AgentTurnPhase.__c__DisplayClass32_0.NativeFieldInfoPtr_graftCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass32_0>.NativeClassPtr, "graftCard");
				AgentTurnPhase.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				AgentTurnPhase.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass32_0>.NativeClassPtr, 100669173);
				AgentTurnPhase.__c__DisplayClass32_0.NativeMethodInfoPtr__GraftWillClearUndo_b__2_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass32_0>.NativeClassPtr, 100669174);
				AgentTurnPhase.__c__DisplayClass32_0.NativeMethodInfoPtr__GraftWillClearUndo_b__4_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass32_0>.NativeClassPtr, 100669175);
				AgentTurnPhase.__c__DisplayClass32_0.NativeMethodInfoPtr__GraftWillClearUndo_b__5_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass32_0>.NativeClassPtr, 100669176);
				AgentTurnPhase.__c__DisplayClass32_0.NativeMethodInfoPtr__GraftWillClearUndo_b__6_Internal_Boolean_SignetAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass32_0>.NativeClassPtr, 100669177);
			}

			// Token: 0x060061B6 RID: 25014 RVA: 0x001DD634 File Offset: 0x001DB834
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061B7 RID: 25015 RVA: 0x001DD670 File Offset: 0x001DB870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151000, XrefRangeEnd = 151008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftWillClearUndo_b__2(DeferredAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass32_0.NativeMethodInfoPtr__GraftWillClearUndo_b__2_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060061B8 RID: 25016 RVA: 0x001DD6C0 File Offset: 0x001DB8C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151008, XrefRangeEnd = 151016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GraftWillClearUndo_b__4(DeferredAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass32_0.NativeMethodInfoPtr__GraftWillClearUndo_b__4_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060061B9 RID: 25017 RVA: 0x001DD710 File Offset: 0x001DB910
			[CallerCount(0)]
			public unsafe bool _GraftWillClearUndo_b__5(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass32_0.NativeMethodInfoPtr__GraftWillClearUndo_b__5_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060061BA RID: 25018 RVA: 0x001DD760 File Offset: 0x001DB960
			[CallerCount(0)]
			public unsafe bool _GraftWillClearUndo_b__6(SignetAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass32_0.NativeMethodInfoPtr__GraftWillClearUndo_b__6_Internal_Boolean_SignetAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060061BB RID: 25019 RVA: 0x000258AC File Offset: 0x00023AAC
			public __c__DisplayClass32_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A01 RID: 6657
			// (get) Token: 0x060061BC RID: 25020 RVA: 0x001DD7B0 File Offset: 0x001DB9B0
			// (set) Token: 0x060061BD RID: 25021 RVA: 0x000258B5 File Offset: 0x00023AB5
			public unsafe WormImperiumPlayable agentCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass32_0.NativeFieldInfoPtr_agentCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass32_0.NativeFieldInfoPtr_agentCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A02 RID: 6658
			// (get) Token: 0x060061BE RID: 25022 RVA: 0x001DD7E0 File Offset: 0x001DB9E0
			// (set) Token: 0x060061BF RID: 25023 RVA: 0x000258D4 File Offset: 0x00023AD4
			public unsafe WormImperiumPlayable graftCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass32_0.NativeFieldInfoPtr_graftCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass32_0.NativeFieldInfoPtr_graftCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A03 RID: 6659
			// (get) Token: 0x060061C0 RID: 25024 RVA: 0x001DD810 File Offset: 0x001DBA10
			// (set) Token: 0x060061C1 RID: 25025 RVA: 0x000258F3 File Offset: 0x00023AF3
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F4F RID: 16207
			private static readonly IntPtr NativeFieldInfoPtr_agentCard;

			// Token: 0x04003F50 RID: 16208
			private static readonly IntPtr NativeFieldInfoPtr_graftCard;

			// Token: 0x04003F51 RID: 16209
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F52 RID: 16210
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003F53 RID: 16211
			private static readonly IntPtr NativeMethodInfoPtr__GraftWillClearUndo_b__2_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04003F54 RID: 16212
			private static readonly IntPtr NativeMethodInfoPtr__GraftWillClearUndo_b__4_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04003F55 RID: 16213
			private static readonly IntPtr NativeMethodInfoPtr__GraftWillClearUndo_b__5_Internal_Boolean_DeferredAbility_0;

			// Token: 0x04003F56 RID: 16214
			private static readonly IntPtr NativeMethodInfoPtr__GraftWillClearUndo_b__6_Internal_Boolean_SignetAbility_0;
		}

		// Token: 0x02000704 RID: 1796
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Object
		{
			// Token: 0x060061C2 RID: 25026 RVA: 0x001DD840 File Offset: 0x001DBA40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass33_0>.NativeClassPtr);
				AgentTurnPhase.__c__DisplayClass33_0.NativeFieldInfoPtr_agentCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass33_0>.NativeClassPtr, "agentCard");
				AgentTurnPhase.__c__DisplayClass33_0.NativeFieldInfoPtr_agentTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass33_0>.NativeClassPtr, "agentTroops");
				AgentTurnPhase.__c__DisplayClass33_0.NativeFieldInfoPtr_spaceTroops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass33_0>.NativeClassPtr, "spaceTroops");
				AgentTurnPhase.__c__DisplayClass33_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass33_0>.NativeClassPtr, "<>9__4");
				AgentTurnPhase.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass33_0>.NativeClassPtr, 100669178);
				AgentTurnPhase.__c__DisplayClass33_0.NativeMethodInfoPtr__GraftUnusualSelections_b__4_Internal_Int32_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass33_0>.NativeClassPtr, 100669179);
			}

			// Token: 0x060061C3 RID: 25027 RVA: 0x001DD8E4 File Offset: 0x001DBAE4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061C4 RID: 25028 RVA: 0x001DD920 File Offset: 0x001DBB20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151016, XrefRangeEnd = 151019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GraftUnusualSelections_b__4(Entity gc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gc);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase.__c__DisplayClass33_0.NativeMethodInfoPtr__GraftUnusualSelections_b__4_Internal_Int32_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060061C5 RID: 25029 RVA: 0x00025912 File Offset: 0x00023B12
			public __c__DisplayClass33_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A04 RID: 6660
			// (get) Token: 0x060061C6 RID: 25030 RVA: 0x001DD970 File Offset: 0x001DBB70
			// (set) Token: 0x060061C7 RID: 25031 RVA: 0x0002591B File Offset: 0x00023B1B
			public unsafe WormImperiumPlayable agentCard
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass33_0.NativeFieldInfoPtr_agentCard);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass33_0.NativeFieldInfoPtr_agentCard), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A05 RID: 6661
			// (get) Token: 0x060061C8 RID: 25032 RVA: 0x001DD9A0 File Offset: 0x001DBBA0
			// (set) Token: 0x060061C9 RID: 25033 RVA: 0x0002593A File Offset: 0x00023B3A
			public unsafe int agentTroops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass33_0.NativeFieldInfoPtr_agentTroops);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass33_0.NativeFieldInfoPtr_agentTroops)) = value;
				}
			}

			// Token: 0x17001A06 RID: 6662
			// (get) Token: 0x060061CA RID: 25034 RVA: 0x001DD9C8 File Offset: 0x001DBBC8
			// (set) Token: 0x060061CB RID: 25035 RVA: 0x00025955 File Offset: 0x00023B55
			public unsafe int spaceTroops
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass33_0.NativeFieldInfoPtr_spaceTroops);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass33_0.NativeFieldInfoPtr_spaceTroops)) = value;
				}
			}

			// Token: 0x17001A07 RID: 6663
			// (get) Token: 0x060061CC RID: 25036 RVA: 0x001DD9F0 File Offset: 0x001DBBF0
			// (set) Token: 0x060061CD RID: 25037 RVA: 0x00025970 File Offset: 0x00023B70
			public unsafe Func<Entity, int> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass33_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase.__c__DisplayClass33_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F57 RID: 16215
			private static readonly IntPtr NativeFieldInfoPtr_agentCard;

			// Token: 0x04003F58 RID: 16216
			private static readonly IntPtr NativeFieldInfoPtr_agentTroops;

			// Token: 0x04003F59 RID: 16217
			private static readonly IntPtr NativeFieldInfoPtr_spaceTroops;

			// Token: 0x04003F5A RID: 16218
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04003F5B RID: 16219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003F5C RID: 16220
			private static readonly IntPtr NativeMethodInfoPtr__GraftUnusualSelections_b__4_Internal_Int32_Entity_0;
		}

		// Token: 0x02000705 RID: 1797
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<DetermineAbilities>d__23")]
		public sealed class _DetermineAbilities_d__23 : Object
		{
			// Token: 0x060061CE RID: 25038 RVA: 0x001DDA20 File Offset: 0x001DBC20
			// Note: this type is marked as 'beforefieldinit'.
			static _DetermineAbilities_d__23()
			{
				Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<DetermineAbilities>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr);
				AgentTurnPhase._DetermineAbilities_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr, "<>1__state");
				AgentTurnPhase._DetermineAbilities_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr, "<>2__current");
				AgentTurnPhase._DetermineAbilities_d__23.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr, "<>l__initialThreadId");
				AgentTurnPhase._DetermineAbilities_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr, "<>4__this");
				AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr, 100669180);
				AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr, 100669181);
				AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr, 100669182);
				AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr, 100669183);
				AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr, 100669184);
				AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr, 100669185);
				AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr, 100669186);
				AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr, 100669187);
			}

			// Token: 0x060061CF RID: 25039 RVA: 0x001DDB3C File Offset: 0x001DBD3C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DetermineAbilities_d__23(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase._DetermineAbilities_d__23>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060061D0 RID: 25040 RVA: 0x001DDB84 File Offset: 0x001DBD84
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061D1 RID: 25041 RVA: 0x001DDBB8 File Offset: 0x001DBDB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151019, XrefRangeEnd = 151196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001A0C RID: 6668
			// (get) Token: 0x060061D2 RID: 25042 RVA: 0x001DDBF4 File Offset: 0x001DBDF4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060061D3 RID: 25043 RVA: 0x001DDC34 File Offset: 0x001DBE34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151196, XrefRangeEnd = 151201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A0D RID: 6669
			// (get) Token: 0x060061D4 RID: 25044 RVA: 0x001DDC68 File Offset: 0x001DBE68
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060061D5 RID: 25045 RVA: 0x001DDCA8 File Offset: 0x001DBEA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151201, XrefRangeEnd = 151203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060061D6 RID: 25046 RVA: 0x001DDCE8 File Offset: 0x001DBEE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._DetermineAbilities_d__23.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060061D7 RID: 25047 RVA: 0x0002598F File Offset: 0x00023B8F
			public _DetermineAbilities_d__23(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A08 RID: 6664
			// (get) Token: 0x060061D8 RID: 25048 RVA: 0x001DDD28 File Offset: 0x001DBF28
			// (set) Token: 0x060061D9 RID: 25049 RVA: 0x00025998 File Offset: 0x00023B98
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._DetermineAbilities_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._DetermineAbilities_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A09 RID: 6665
			// (get) Token: 0x060061DA RID: 25050 RVA: 0x001DDD50 File Offset: 0x001DBF50
			// (set) Token: 0x060061DB RID: 25051 RVA: 0x000259B3 File Offset: 0x00023BB3
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._DetermineAbilities_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._DetermineAbilities_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A0A RID: 6666
			// (get) Token: 0x060061DC RID: 25052 RVA: 0x001DDD80 File Offset: 0x001DBF80
			// (set) Token: 0x060061DD RID: 25053 RVA: 0x000259D2 File Offset: 0x00023BD2
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._DetermineAbilities_d__23.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._DetermineAbilities_d__23.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A0B RID: 6667
			// (get) Token: 0x060061DE RID: 25054 RVA: 0x001DDDA8 File Offset: 0x001DBFA8
			// (set) Token: 0x060061DF RID: 25055 RVA: 0x000259ED File Offset: 0x00023BED
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._DetermineAbilities_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._DetermineAbilities_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F5D RID: 16221
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F5E RID: 16222
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F5F RID: 16223
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003F60 RID: 16224
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F61 RID: 16225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F62 RID: 16226
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F63 RID: 16227
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F64 RID: 16228
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003F65 RID: 16229
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F66 RID: 16230
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F67 RID: 16231
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003F68 RID: 16232
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000706 RID: 1798
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<FireTriggers>d__31")]
		public sealed class _FireTriggers_d__31 : Object
		{
			// Token: 0x060061E0 RID: 25056 RVA: 0x001DDDD8 File Offset: 0x001DBFD8
			// Note: this type is marked as 'beforefieldinit'.
			static _FireTriggers_d__31()
			{
				Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<FireTriggers>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr);
				AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, "<>1__state");
				AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, "<>2__current");
				AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, "<>l__initialThreadId");
				AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, "<>4__this");
				AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr__playedContext_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, "<playedContext>5__2");
				AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, 100669188);
				AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, 100669189);
				AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, 100669190);
				AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, 100669191);
				AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, 100669192);
				AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, 100669193);
				AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, 100669194);
				AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr, 100669195);
			}

			// Token: 0x060061E1 RID: 25057 RVA: 0x001DDF08 File Offset: 0x001DC108
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FireTriggers_d__31(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase._FireTriggers_d__31>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060061E2 RID: 25058 RVA: 0x001DDF50 File Offset: 0x001DC150
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061E3 RID: 25059 RVA: 0x001DDF84 File Offset: 0x001DC184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151203, XrefRangeEnd = 151257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001A13 RID: 6675
			// (get) Token: 0x060061E4 RID: 25060 RVA: 0x001DDFC0 File Offset: 0x001DC1C0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060061E5 RID: 25061 RVA: 0x001DE000 File Offset: 0x001DC200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151257, XrefRangeEnd = 151262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A14 RID: 6676
			// (get) Token: 0x060061E6 RID: 25062 RVA: 0x001DE034 File Offset: 0x001DC234
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060061E7 RID: 25063 RVA: 0x001DE074 File Offset: 0x001DC274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151262, XrefRangeEnd = 151264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060061E8 RID: 25064 RVA: 0x001DE0B4 File Offset: 0x001DC2B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._FireTriggers_d__31.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060061E9 RID: 25065 RVA: 0x00025A0C File Offset: 0x00023C0C
			public _FireTriggers_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A0E RID: 6670
			// (get) Token: 0x060061EA RID: 25066 RVA: 0x001DE0F4 File Offset: 0x001DC2F4
			// (set) Token: 0x060061EB RID: 25067 RVA: 0x00025A15 File Offset: 0x00023C15
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A0F RID: 6671
			// (get) Token: 0x060061EC RID: 25068 RVA: 0x001DE11C File Offset: 0x001DC31C
			// (set) Token: 0x060061ED RID: 25069 RVA: 0x00025A30 File Offset: 0x00023C30
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A10 RID: 6672
			// (get) Token: 0x060061EE RID: 25070 RVA: 0x001DE14C File Offset: 0x001DC34C
			// (set) Token: 0x060061EF RID: 25071 RVA: 0x00025A4F File Offset: 0x00023C4F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A11 RID: 6673
			// (get) Token: 0x060061F0 RID: 25072 RVA: 0x001DE174 File Offset: 0x001DC374
			// (set) Token: 0x060061F1 RID: 25073 RVA: 0x00025A6A File Offset: 0x00023C6A
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A12 RID: 6674
			// (get) Token: 0x060061F2 RID: 25074 RVA: 0x001DE1A4 File Offset: 0x001DC3A4
			// (set) Token: 0x060061F3 RID: 25075 RVA: 0x00025A89 File Offset: 0x00023C89
			public unsafe Context _playedContext_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr__playedContext_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._FireTriggers_d__31.NativeFieldInfoPtr__playedContext_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F69 RID: 16233
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F6A RID: 16234
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F6B RID: 16235
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003F6C RID: 16236
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F6D RID: 16237
			private static readonly IntPtr NativeFieldInfoPtr__playedContext_5__2;

			// Token: 0x04003F6E RID: 16238
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F6F RID: 16239
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F70 RID: 16240
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F71 RID: 16241
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003F72 RID: 16242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F73 RID: 16243
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F74 RID: 16244
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003F75 RID: 16245
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000707 RID: 1799
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<GraftCard>d__22")]
		public sealed class _GraftCard_d__22 : Object
		{
			// Token: 0x060061F4 RID: 25076 RVA: 0x001DE1D4 File Offset: 0x001DC3D4
			// Note: this type is marked as 'beforefieldinit'.
			static _GraftCard_d__22()
			{
				Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<GraftCard>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr);
				AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, "<>1__state");
				AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, "<>2__current");
				AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, "<>l__initialThreadId");
				AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, "<>4__this");
				AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, "<>8__1");
				AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr__kind_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, "<kind>5__2");
				AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, 100669196);
				AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, 100669197);
				AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, 100669198);
				AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, 100669199);
				AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, 100669200);
				AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, 100669201);
				AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, 100669202);
				AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr, 100669203);
			}

			// Token: 0x060061F5 RID: 25077 RVA: 0x001DE318 File Offset: 0x001DC518
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GraftCard_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase._GraftCard_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060061F6 RID: 25078 RVA: 0x001DE360 File Offset: 0x001DC560
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060061F7 RID: 25079 RVA: 0x001DE394 File Offset: 0x001DC594
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151264, XrefRangeEnd = 151470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001A1B RID: 6683
			// (get) Token: 0x060061F8 RID: 25080 RVA: 0x001DE3D0 File Offset: 0x001DC5D0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060061F9 RID: 25081 RVA: 0x001DE410 File Offset: 0x001DC610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151470, XrefRangeEnd = 151475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A1C RID: 6684
			// (get) Token: 0x060061FA RID: 25082 RVA: 0x001DE444 File Offset: 0x001DC644
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060061FB RID: 25083 RVA: 0x001DE484 File Offset: 0x001DC684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151475, XrefRangeEnd = 151477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060061FC RID: 25084 RVA: 0x001DE4C4 File Offset: 0x001DC6C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._GraftCard_d__22.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060061FD RID: 25085 RVA: 0x00025AA8 File Offset: 0x00023CA8
			public _GraftCard_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A15 RID: 6677
			// (get) Token: 0x060061FE RID: 25086 RVA: 0x001DE504 File Offset: 0x001DC704
			// (set) Token: 0x060061FF RID: 25087 RVA: 0x00025AB1 File Offset: 0x00023CB1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A16 RID: 6678
			// (get) Token: 0x06006200 RID: 25088 RVA: 0x001DE52C File Offset: 0x001DC72C
			// (set) Token: 0x06006201 RID: 25089 RVA: 0x00025ACC File Offset: 0x00023CCC
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A17 RID: 6679
			// (get) Token: 0x06006202 RID: 25090 RVA: 0x001DE55C File Offset: 0x001DC75C
			// (set) Token: 0x06006203 RID: 25091 RVA: 0x00025AEB File Offset: 0x00023CEB
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A18 RID: 6680
			// (get) Token: 0x06006204 RID: 25092 RVA: 0x001DE584 File Offset: 0x001DC784
			// (set) Token: 0x06006205 RID: 25093 RVA: 0x00025B06 File Offset: 0x00023D06
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A19 RID: 6681
			// (get) Token: 0x06006206 RID: 25094 RVA: 0x001DE5B4 File Offset: 0x001DC7B4
			// (set) Token: 0x06006207 RID: 25095 RVA: 0x00025B25 File Offset: 0x00023D25
			public unsafe AgentTurnPhase.__c__DisplayClass22_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase.__c__DisplayClass22_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A1A RID: 6682
			// (get) Token: 0x06006208 RID: 25096 RVA: 0x001DE5E4 File Offset: 0x001DC7E4
			// (set) Token: 0x06006209 RID: 25097 RVA: 0x00025B44 File Offset: 0x00023D44
			public unsafe string _kind_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr__kind_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._GraftCard_d__22.NativeFieldInfoPtr__kind_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04003F76 RID: 16246
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F77 RID: 16247
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F78 RID: 16248
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003F79 RID: 16249
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F7A RID: 16250
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04003F7B RID: 16251
			private static readonly IntPtr NativeFieldInfoPtr__kind_5__2;

			// Token: 0x04003F7C RID: 16252
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F7D RID: 16253
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F7E RID: 16254
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F7F RID: 16255
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003F80 RID: 16256
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F81 RID: 16257
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F82 RID: 16258
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003F83 RID: 16259
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000708 RID: 1800
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<InitializeAgentTurn>d__21")]
		public sealed class _InitializeAgentTurn_d__21 : Object
		{
			// Token: 0x0600620A RID: 25098 RVA: 0x001DE60C File Offset: 0x001DC80C
			// Note: this type is marked as 'beforefieldinit'.
			static _InitializeAgentTurn_d__21()
			{
				Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<InitializeAgentTurn>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr);
				AgentTurnPhase._InitializeAgentTurn_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr, "<>1__state");
				AgentTurnPhase._InitializeAgentTurn_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr, "<>2__current");
				AgentTurnPhase._InitializeAgentTurn_d__21.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr, "<>l__initialThreadId");
				AgentTurnPhase._InitializeAgentTurn_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr, "<>4__this");
				AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr, 100669204);
				AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr, 100669205);
				AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr, 100669206);
				AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr, 100669207);
				AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr, 100669208);
				AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr, 100669209);
				AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr, 100669210);
				AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr, 100669211);
			}

			// Token: 0x0600620B RID: 25099 RVA: 0x001DE728 File Offset: 0x001DC928
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _InitializeAgentTurn_d__21(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase._InitializeAgentTurn_d__21>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600620C RID: 25100 RVA: 0x001DE770 File Offset: 0x001DC970
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600620D RID: 25101 RVA: 0x001DE7A4 File Offset: 0x001DC9A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151477, XrefRangeEnd = 151483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001A21 RID: 6689
			// (get) Token: 0x0600620E RID: 25102 RVA: 0x001DE7E0 File Offset: 0x001DC9E0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600620F RID: 25103 RVA: 0x001DE820 File Offset: 0x001DCA20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151483, XrefRangeEnd = 151488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A22 RID: 6690
			// (get) Token: 0x06006210 RID: 25104 RVA: 0x001DE854 File Offset: 0x001DCA54
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006211 RID: 25105 RVA: 0x001DE894 File Offset: 0x001DCA94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151488, XrefRangeEnd = 151490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006212 RID: 25106 RVA: 0x001DE8D4 File Offset: 0x001DCAD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._InitializeAgentTurn_d__21.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006213 RID: 25107 RVA: 0x00025B63 File Offset: 0x00023D63
			public _InitializeAgentTurn_d__21(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A1D RID: 6685
			// (get) Token: 0x06006214 RID: 25108 RVA: 0x001DE914 File Offset: 0x001DCB14
			// (set) Token: 0x06006215 RID: 25109 RVA: 0x00025B6C File Offset: 0x00023D6C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._InitializeAgentTurn_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._InitializeAgentTurn_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A1E RID: 6686
			// (get) Token: 0x06006216 RID: 25110 RVA: 0x001DE93C File Offset: 0x001DCB3C
			// (set) Token: 0x06006217 RID: 25111 RVA: 0x00025B87 File Offset: 0x00023D87
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._InitializeAgentTurn_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._InitializeAgentTurn_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A1F RID: 6687
			// (get) Token: 0x06006218 RID: 25112 RVA: 0x001DE96C File Offset: 0x001DCB6C
			// (set) Token: 0x06006219 RID: 25113 RVA: 0x00025BA6 File Offset: 0x00023DA6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._InitializeAgentTurn_d__21.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._InitializeAgentTurn_d__21.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A20 RID: 6688
			// (get) Token: 0x0600621A RID: 25114 RVA: 0x001DE994 File Offset: 0x001DCB94
			// (set) Token: 0x0600621B RID: 25115 RVA: 0x00025BC1 File Offset: 0x00023DC1
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._InitializeAgentTurn_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._InitializeAgentTurn_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F84 RID: 16260
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F85 RID: 16261
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F86 RID: 16262
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003F87 RID: 16263
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F88 RID: 16264
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F89 RID: 16265
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F8A RID: 16266
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F8B RID: 16267
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003F8C RID: 16268
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F8D RID: 16269
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F8E RID: 16270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003F8F RID: 16271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000709 RID: 1801
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<PlayAgentCard>d__24")]
		public sealed class _PlayAgentCard_d__24 : Object
		{
			// Token: 0x0600621C RID: 25116 RVA: 0x001DE9C4 File Offset: 0x001DCBC4
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayAgentCard_d__24()
			{
				Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<PlayAgentCard>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr);
				AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, "<>1__state");
				AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, "<>2__current");
				AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, "<>l__initialThreadId");
				AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, "<>4__this");
				AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr__agentCard_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, "<agentCard>5__2");
				AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, 100669212);
				AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, 100669213);
				AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, 100669214);
				AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, 100669215);
				AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, 100669216);
				AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, 100669217);
				AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, 100669218);
				AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr, 100669219);
			}

			// Token: 0x0600621D RID: 25117 RVA: 0x001DEAF4 File Offset: 0x001DCCF4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayAgentCard_d__24(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase._PlayAgentCard_d__24>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600621E RID: 25118 RVA: 0x001DEB3C File Offset: 0x001DCD3C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600621F RID: 25119 RVA: 0x001DEB70 File Offset: 0x001DCD70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151490, XrefRangeEnd = 151505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001A28 RID: 6696
			// (get) Token: 0x06006220 RID: 25120 RVA: 0x001DEBAC File Offset: 0x001DCDAC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006221 RID: 25121 RVA: 0x001DEBEC File Offset: 0x001DCDEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151505, XrefRangeEnd = 151510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A29 RID: 6697
			// (get) Token: 0x06006222 RID: 25122 RVA: 0x001DEC20 File Offset: 0x001DCE20
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006223 RID: 25123 RVA: 0x001DEC60 File Offset: 0x001DCE60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151510, XrefRangeEnd = 151512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006224 RID: 25124 RVA: 0x001DECA0 File Offset: 0x001DCEA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._PlayAgentCard_d__24.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006225 RID: 25125 RVA: 0x00025BE0 File Offset: 0x00023DE0
			public _PlayAgentCard_d__24(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A23 RID: 6691
			// (get) Token: 0x06006226 RID: 25126 RVA: 0x001DECE0 File Offset: 0x001DCEE0
			// (set) Token: 0x06006227 RID: 25127 RVA: 0x00025BE9 File Offset: 0x00023DE9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A24 RID: 6692
			// (get) Token: 0x06006228 RID: 25128 RVA: 0x001DED08 File Offset: 0x001DCF08
			// (set) Token: 0x06006229 RID: 25129 RVA: 0x00025C04 File Offset: 0x00023E04
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A25 RID: 6693
			// (get) Token: 0x0600622A RID: 25130 RVA: 0x001DED38 File Offset: 0x001DCF38
			// (set) Token: 0x0600622B RID: 25131 RVA: 0x00025C23 File Offset: 0x00023E23
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A26 RID: 6694
			// (get) Token: 0x0600622C RID: 25132 RVA: 0x001DED60 File Offset: 0x001DCF60
			// (set) Token: 0x0600622D RID: 25133 RVA: 0x00025C3E File Offset: 0x00023E3E
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A27 RID: 6695
			// (get) Token: 0x0600622E RID: 25134 RVA: 0x001DED90 File Offset: 0x001DCF90
			// (set) Token: 0x0600622F RID: 25135 RVA: 0x00025C5D File Offset: 0x00023E5D
			public unsafe WormImperiumPlayable _agentCard_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr__agentCard_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._PlayAgentCard_d__24.NativeFieldInfoPtr__agentCard_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F90 RID: 16272
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F91 RID: 16273
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F92 RID: 16274
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003F93 RID: 16275
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003F94 RID: 16276
			private static readonly IntPtr NativeFieldInfoPtr__agentCard_5__2;

			// Token: 0x04003F95 RID: 16277
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003F96 RID: 16278
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F97 RID: 16279
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003F98 RID: 16280
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003F99 RID: 16281
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003F9A RID: 16282
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003F9B RID: 16283
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003F9C RID: 16284
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200070A RID: 1802
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<ReevaluatePassiveAbilities>d__26")]
		public sealed class _ReevaluatePassiveAbilities_d__26 : Object
		{
			// Token: 0x06006230 RID: 25136 RVA: 0x001DEDC0 File Offset: 0x001DCFC0
			// Note: this type is marked as 'beforefieldinit'.
			static _ReevaluatePassiveAbilities_d__26()
			{
				Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<ReevaluatePassiveAbilities>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr);
				AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr, "<>1__state");
				AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr, "<>2__current");
				AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr, "<>l__initialThreadId");
				AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr, "<>4__this");
				AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr, 100669220);
				AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr, 100669221);
				AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr, 100669222);
				AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr, 100669223);
				AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr, 100669224);
				AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr, 100669225);
				AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr, 100669226);
				AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr, 100669227);
			}

			// Token: 0x06006231 RID: 25137 RVA: 0x001DEEDC File Offset: 0x001DD0DC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ReevaluatePassiveAbilities_d__26(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase._ReevaluatePassiveAbilities_d__26>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006232 RID: 25138 RVA: 0x001DEF24 File Offset: 0x001DD124
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006233 RID: 25139 RVA: 0x001DEF58 File Offset: 0x001DD158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001A2E RID: 6702
			// (get) Token: 0x06006234 RID: 25140 RVA: 0x001DEF94 File Offset: 0x001DD194
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006235 RID: 25141 RVA: 0x001DEFD4 File Offset: 0x001DD1D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151512, XrefRangeEnd = 151517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A2F RID: 6703
			// (get) Token: 0x06006236 RID: 25142 RVA: 0x001DF008 File Offset: 0x001DD208
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006237 RID: 25143 RVA: 0x001DF048 File Offset: 0x001DD248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151517, XrefRangeEnd = 151519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006238 RID: 25144 RVA: 0x001DF088 File Offset: 0x001DD288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006239 RID: 25145 RVA: 0x00025C7C File Offset: 0x00023E7C
			public _ReevaluatePassiveAbilities_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A2A RID: 6698
			// (get) Token: 0x0600623A RID: 25146 RVA: 0x001DF0C8 File Offset: 0x001DD2C8
			// (set) Token: 0x0600623B RID: 25147 RVA: 0x00025C85 File Offset: 0x00023E85
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A2B RID: 6699
			// (get) Token: 0x0600623C RID: 25148 RVA: 0x001DF0F0 File Offset: 0x001DD2F0
			// (set) Token: 0x0600623D RID: 25149 RVA: 0x00025CA0 File Offset: 0x00023EA0
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A2C RID: 6700
			// (get) Token: 0x0600623E RID: 25150 RVA: 0x001DF120 File Offset: 0x001DD320
			// (set) Token: 0x0600623F RID: 25151 RVA: 0x00025CBF File Offset: 0x00023EBF
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A2D RID: 6701
			// (get) Token: 0x06006240 RID: 25152 RVA: 0x001DF148 File Offset: 0x001DD348
			// (set) Token: 0x06006241 RID: 25153 RVA: 0x00025CDA File Offset: 0x00023EDA
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ReevaluatePassiveAbilities_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003F9D RID: 16285
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003F9E RID: 16286
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003F9F RID: 16287
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003FA0 RID: 16288
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FA1 RID: 16289
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003FA2 RID: 16290
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FA3 RID: 16291
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003FA4 RID: 16292
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003FA5 RID: 16293
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FA6 RID: 16294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FA7 RID: 16295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003FA8 RID: 16296
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200070B RID: 1803
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<ResolveAgentAbility>d__29")]
		public sealed class _ResolveAgentAbility_d__29 : Object
		{
			// Token: 0x06006242 RID: 25154 RVA: 0x001DF178 File Offset: 0x001DD378
			// Note: this type is marked as 'beforefieldinit'.
			static _ResolveAgentAbility_d__29()
			{
				Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<ResolveAgentAbility>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr);
				AgentTurnPhase._ResolveAgentAbility_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr, "<>1__state");
				AgentTurnPhase._ResolveAgentAbility_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr, "<>2__current");
				AgentTurnPhase._ResolveAgentAbility_d__29.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr, "<>l__initialThreadId");
				AgentTurnPhase._ResolveAgentAbility_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr, "<>4__this");
				AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr, 100669228);
				AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr, 100669229);
				AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr, 100669230);
				AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr, 100669231);
				AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr, 100669232);
				AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr, 100669233);
				AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr, 100669234);
				AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr, 100669235);
			}

			// Token: 0x06006243 RID: 25155 RVA: 0x001DF294 File Offset: 0x001DD494
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResolveAgentAbility_d__29(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase._ResolveAgentAbility_d__29>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006244 RID: 25156 RVA: 0x001DF2DC File Offset: 0x001DD4DC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006245 RID: 25157 RVA: 0x001DF310 File Offset: 0x001DD510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151519, XrefRangeEnd = 151525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001A34 RID: 6708
			// (get) Token: 0x06006246 RID: 25158 RVA: 0x001DF34C File Offset: 0x001DD54C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006247 RID: 25159 RVA: 0x001DF38C File Offset: 0x001DD58C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151525, XrefRangeEnd = 151530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A35 RID: 6709
			// (get) Token: 0x06006248 RID: 25160 RVA: 0x001DF3C0 File Offset: 0x001DD5C0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006249 RID: 25161 RVA: 0x001DF400 File Offset: 0x001DD600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151530, XrefRangeEnd = 151532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600624A RID: 25162 RVA: 0x001DF440 File Offset: 0x001DD640
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveAgentAbility_d__29.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600624B RID: 25163 RVA: 0x00025CF9 File Offset: 0x00023EF9
			public _ResolveAgentAbility_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A30 RID: 6704
			// (get) Token: 0x0600624C RID: 25164 RVA: 0x001DF480 File Offset: 0x001DD680
			// (set) Token: 0x0600624D RID: 25165 RVA: 0x00025D02 File Offset: 0x00023F02
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveAgentAbility_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveAgentAbility_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A31 RID: 6705
			// (get) Token: 0x0600624E RID: 25166 RVA: 0x001DF4A8 File Offset: 0x001DD6A8
			// (set) Token: 0x0600624F RID: 25167 RVA: 0x00025D1D File Offset: 0x00023F1D
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveAgentAbility_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveAgentAbility_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A32 RID: 6706
			// (get) Token: 0x06006250 RID: 25168 RVA: 0x001DF4D8 File Offset: 0x001DD6D8
			// (set) Token: 0x06006251 RID: 25169 RVA: 0x00025D3C File Offset: 0x00023F3C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveAgentAbility_d__29.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveAgentAbility_d__29.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A33 RID: 6707
			// (get) Token: 0x06006252 RID: 25170 RVA: 0x001DF500 File Offset: 0x001DD700
			// (set) Token: 0x06006253 RID: 25171 RVA: 0x00025D57 File Offset: 0x00023F57
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveAgentAbility_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveAgentAbility_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FA9 RID: 16297
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003FAA RID: 16298
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003FAB RID: 16299
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003FAC RID: 16300
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FAD RID: 16301
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003FAE RID: 16302
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FAF RID: 16303
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003FB0 RID: 16304
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003FB1 RID: 16305
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FB2 RID: 16306
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FB3 RID: 16307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003FB4 RID: 16308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200070C RID: 1804
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<ResolveFirstAbilities>d__27")]
		public sealed class _ResolveFirstAbilities_d__27 : Object
		{
			// Token: 0x06006254 RID: 25172 RVA: 0x001DF530 File Offset: 0x001DD730
			// Note: this type is marked as 'beforefieldinit'.
			static _ResolveFirstAbilities_d__27()
			{
				Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<ResolveFirstAbilities>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr);
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, "<>1__state");
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, "<>2__current");
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, "<>l__initialThreadId");
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, "<>4__this");
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr__resolutionContext_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, "<resolutionContext>5__2");
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, 100669236);
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, 100669237);
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, 100669238);
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, 100669239);
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, 100669240);
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, 100669241);
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, 100669242);
				AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr, 100669243);
			}

			// Token: 0x06006255 RID: 25173 RVA: 0x001DF660 File Offset: 0x001DD860
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResolveFirstAbilities_d__27(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase._ResolveFirstAbilities_d__27>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006256 RID: 25174 RVA: 0x001DF6A8 File Offset: 0x001DD8A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006257 RID: 25175 RVA: 0x001DF6DC File Offset: 0x001DD8DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151532, XrefRangeEnd = 151571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001A3B RID: 6715
			// (get) Token: 0x06006258 RID: 25176 RVA: 0x001DF718 File Offset: 0x001DD918
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006259 RID: 25177 RVA: 0x001DF758 File Offset: 0x001DD958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151571, XrefRangeEnd = 151576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A3C RID: 6716
			// (get) Token: 0x0600625A RID: 25178 RVA: 0x001DF78C File Offset: 0x001DD98C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600625B RID: 25179 RVA: 0x001DF7CC File Offset: 0x001DD9CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151576, XrefRangeEnd = 151578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600625C RID: 25180 RVA: 0x001DF80C File Offset: 0x001DDA0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600625D RID: 25181 RVA: 0x00025D76 File Offset: 0x00023F76
			public _ResolveFirstAbilities_d__27(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A36 RID: 6710
			// (get) Token: 0x0600625E RID: 25182 RVA: 0x001DF84C File Offset: 0x001DDA4C
			// (set) Token: 0x0600625F RID: 25183 RVA: 0x00025D7F File Offset: 0x00023F7F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A37 RID: 6711
			// (get) Token: 0x06006260 RID: 25184 RVA: 0x001DF874 File Offset: 0x001DDA74
			// (set) Token: 0x06006261 RID: 25185 RVA: 0x00025D9A File Offset: 0x00023F9A
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A38 RID: 6712
			// (get) Token: 0x06006262 RID: 25186 RVA: 0x001DF8A4 File Offset: 0x001DDAA4
			// (set) Token: 0x06006263 RID: 25187 RVA: 0x00025DB9 File Offset: 0x00023FB9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A39 RID: 6713
			// (get) Token: 0x06006264 RID: 25188 RVA: 0x001DF8CC File Offset: 0x001DDACC
			// (set) Token: 0x06006265 RID: 25189 RVA: 0x00025DD4 File Offset: 0x00023FD4
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A3A RID: 6714
			// (get) Token: 0x06006266 RID: 25190 RVA: 0x001DF8FC File Offset: 0x001DDAFC
			// (set) Token: 0x06006267 RID: 25191 RVA: 0x00025DF3 File Offset: 0x00023FF3
			public unsafe Context _resolutionContext_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr__resolutionContext_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveFirstAbilities_d__27.NativeFieldInfoPtr__resolutionContext_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FB5 RID: 16309
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003FB6 RID: 16310
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003FB7 RID: 16311
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003FB8 RID: 16312
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FB9 RID: 16313
			private static readonly IntPtr NativeFieldInfoPtr__resolutionContext_5__2;

			// Token: 0x04003FBA RID: 16314
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003FBB RID: 16315
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FBC RID: 16316
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003FBD RID: 16317
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003FBE RID: 16318
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FBF RID: 16319
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FC0 RID: 16320
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003FC1 RID: 16321
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200070D RID: 1805
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<ResolveImmediateDeferredAbilities>d__30")]
		public sealed class _ResolveImmediateDeferredAbilities_d__30 : Object
		{
			// Token: 0x06006268 RID: 25192 RVA: 0x001DF92C File Offset: 0x001DDB2C
			// Note: this type is marked as 'beforefieldinit'.
			static _ResolveImmediateDeferredAbilities_d__30()
			{
				Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<ResolveImmediateDeferredAbilities>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr);
				AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr, "<>1__state");
				AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr, "<>2__current");
				AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr, "<>l__initialThreadId");
				AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr, "<>4__this");
				AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr, 100669244);
				AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr, 100669245);
				AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr, 100669246);
				AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr, 100669247);
				AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr, 100669248);
				AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr, 100669249);
				AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr, 100669250);
				AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr, 100669251);
			}

			// Token: 0x06006269 RID: 25193 RVA: 0x001DFA48 File Offset: 0x001DDC48
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResolveImmediateDeferredAbilities_d__30(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600626A RID: 25194 RVA: 0x001DFA90 File Offset: 0x001DDC90
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600626B RID: 25195 RVA: 0x001DFAC4 File Offset: 0x001DDCC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151578, XrefRangeEnd = 151616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001A41 RID: 6721
			// (get) Token: 0x0600626C RID: 25196 RVA: 0x001DFB00 File Offset: 0x001DDD00
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600626D RID: 25197 RVA: 0x001DFB40 File Offset: 0x001DDD40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151616, XrefRangeEnd = 151621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A42 RID: 6722
			// (get) Token: 0x0600626E RID: 25198 RVA: 0x001DFB74 File Offset: 0x001DDD74
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600626F RID: 25199 RVA: 0x001DFBB4 File Offset: 0x001DDDB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151621, XrefRangeEnd = 151623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006270 RID: 25200 RVA: 0x001DFBF4 File Offset: 0x001DDDF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006271 RID: 25201 RVA: 0x00025E12 File Offset: 0x00024012
			public _ResolveImmediateDeferredAbilities_d__30(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A3D RID: 6717
			// (get) Token: 0x06006272 RID: 25202 RVA: 0x001DFC34 File Offset: 0x001DDE34
			// (set) Token: 0x06006273 RID: 25203 RVA: 0x00025E1B File Offset: 0x0002401B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A3E RID: 6718
			// (get) Token: 0x06006274 RID: 25204 RVA: 0x001DFC5C File Offset: 0x001DDE5C
			// (set) Token: 0x06006275 RID: 25205 RVA: 0x00025E36 File Offset: 0x00024036
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A3F RID: 6719
			// (get) Token: 0x06006276 RID: 25206 RVA: 0x001DFC8C File Offset: 0x001DDE8C
			// (set) Token: 0x06006277 RID: 25207 RVA: 0x00025E55 File Offset: 0x00024055
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A40 RID: 6720
			// (get) Token: 0x06006278 RID: 25208 RVA: 0x001DFCB4 File Offset: 0x001DDEB4
			// (set) Token: 0x06006279 RID: 25209 RVA: 0x00025E70 File Offset: 0x00024070
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveImmediateDeferredAbilities_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FC2 RID: 16322
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003FC3 RID: 16323
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003FC4 RID: 16324
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003FC5 RID: 16325
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FC6 RID: 16326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003FC7 RID: 16327
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FC8 RID: 16328
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003FC9 RID: 16329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003FCA RID: 16330
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FCB RID: 16331
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FCC RID: 16332
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003FCD RID: 16333
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200070E RID: 1806
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<ResolveSpaceAbility>d__28")]
		public sealed class _ResolveSpaceAbility_d__28 : Object
		{
			// Token: 0x0600627A RID: 25210 RVA: 0x001DFCE4 File Offset: 0x001DDEE4
			// Note: this type is marked as 'beforefieldinit'.
			static _ResolveSpaceAbility_d__28()
			{
				Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<ResolveSpaceAbility>d__28");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr);
				AgentTurnPhase._ResolveSpaceAbility_d__28.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr, "<>1__state");
				AgentTurnPhase._ResolveSpaceAbility_d__28.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr, "<>2__current");
				AgentTurnPhase._ResolveSpaceAbility_d__28.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr, "<>l__initialThreadId");
				AgentTurnPhase._ResolveSpaceAbility_d__28.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr, "<>4__this");
				AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr, 100669252);
				AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr, 100669253);
				AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr, 100669254);
				AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr, 100669255);
				AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr, 100669256);
				AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr, 100669257);
				AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr, 100669258);
				AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr, 100669259);
			}

			// Token: 0x0600627B RID: 25211 RVA: 0x001DFE00 File Offset: 0x001DE000
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResolveSpaceAbility_d__28(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase._ResolveSpaceAbility_d__28>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600627C RID: 25212 RVA: 0x001DFE48 File Offset: 0x001DE048
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600627D RID: 25213 RVA: 0x001DFE7C File Offset: 0x001DE07C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151623, XrefRangeEnd = 151636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001A47 RID: 6727
			// (get) Token: 0x0600627E RID: 25214 RVA: 0x001DFEB8 File Offset: 0x001DE0B8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600627F RID: 25215 RVA: 0x001DFEF8 File Offset: 0x001DE0F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151636, XrefRangeEnd = 151641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A48 RID: 6728
			// (get) Token: 0x06006280 RID: 25216 RVA: 0x001DFF2C File Offset: 0x001DE12C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006281 RID: 25217 RVA: 0x001DFF6C File Offset: 0x001DE16C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151641, XrefRangeEnd = 151643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006282 RID: 25218 RVA: 0x001DFFAC File Offset: 0x001DE1AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006283 RID: 25219 RVA: 0x00025E8F File Offset: 0x0002408F
			public _ResolveSpaceAbility_d__28(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A43 RID: 6723
			// (get) Token: 0x06006284 RID: 25220 RVA: 0x001DFFEC File Offset: 0x001DE1EC
			// (set) Token: 0x06006285 RID: 25221 RVA: 0x00025E98 File Offset: 0x00024098
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A44 RID: 6724
			// (get) Token: 0x06006286 RID: 25222 RVA: 0x001E0014 File Offset: 0x001DE214
			// (set) Token: 0x06006287 RID: 25223 RVA: 0x00025EB3 File Offset: 0x000240B3
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A45 RID: 6725
			// (get) Token: 0x06006288 RID: 25224 RVA: 0x001E0044 File Offset: 0x001DE244
			// (set) Token: 0x06006289 RID: 25225 RVA: 0x00025ED2 File Offset: 0x000240D2
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A46 RID: 6726
			// (get) Token: 0x0600628A RID: 25226 RVA: 0x001E006C File Offset: 0x001DE26C
			// (set) Token: 0x0600628B RID: 25227 RVA: 0x00025EED File Offset: 0x000240ED
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._ResolveSpaceAbility_d__28.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FCE RID: 16334
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003FCF RID: 16335
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003FD0 RID: 16336
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003FD1 RID: 16337
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FD2 RID: 16338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003FD3 RID: 16339
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FD4 RID: 16340
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003FD5 RID: 16341
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003FD6 RID: 16342
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FD7 RID: 16343
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FD8 RID: 16344
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003FD9 RID: 16345
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200070F RID: 1807
		[ObfuscatedName("worm.canis.actions.phases.AgentTurnPhase+<SendAgentToSpace>d__25")]
		public sealed class _SendAgentToSpace_d__25 : Object
		{
			// Token: 0x0600628C RID: 25228 RVA: 0x001E009C File Offset: 0x001DE29C
			// Note: this type is marked as 'beforefieldinit'.
			static _SendAgentToSpace_d__25()
			{
				Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AgentTurnPhase>.NativeClassPtr, "<SendAgentToSpace>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr);
				AgentTurnPhase._SendAgentToSpace_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr, "<>1__state");
				AgentTurnPhase._SendAgentToSpace_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr, "<>2__current");
				AgentTurnPhase._SendAgentToSpace_d__25.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr, "<>l__initialThreadId");
				AgentTurnPhase._SendAgentToSpace_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr, "<>4__this");
				AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr, 100669260);
				AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr, 100669261);
				AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr, 100669262);
				AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr, 100669263);
				AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr, 100669264);
				AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr, 100669265);
				AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr, 100669266);
				AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr, 100669267);
			}

			// Token: 0x0600628D RID: 25229 RVA: 0x001E01B8 File Offset: 0x001DE3B8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SendAgentToSpace_d__25(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AgentTurnPhase._SendAgentToSpace_d__25>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600628E RID: 25230 RVA: 0x001E0200 File Offset: 0x001DE400
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600628F RID: 25231 RVA: 0x001E0234 File Offset: 0x001DE434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151643, XrefRangeEnd = 151662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001A4D RID: 6733
			// (get) Token: 0x06006290 RID: 25232 RVA: 0x001E0270 File Offset: 0x001DE470
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006291 RID: 25233 RVA: 0x001E02B0 File Offset: 0x001DE4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151662, XrefRangeEnd = 151667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001A4E RID: 6734
			// (get) Token: 0x06006292 RID: 25234 RVA: 0x001E02E4 File Offset: 0x001DE4E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006293 RID: 25235 RVA: 0x001E0324 File Offset: 0x001DE524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151667, XrefRangeEnd = 151669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006294 RID: 25236 RVA: 0x001E0364 File Offset: 0x001DE564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AgentTurnPhase._SendAgentToSpace_d__25.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006295 RID: 25237 RVA: 0x00025F0C File Offset: 0x0002410C
			public _SendAgentToSpace_d__25(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001A49 RID: 6729
			// (get) Token: 0x06006296 RID: 25238 RVA: 0x001E03A4 File Offset: 0x001DE5A4
			// (set) Token: 0x06006297 RID: 25239 RVA: 0x00025F15 File Offset: 0x00024115
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._SendAgentToSpace_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._SendAgentToSpace_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001A4A RID: 6730
			// (get) Token: 0x06006298 RID: 25240 RVA: 0x001E03CC File Offset: 0x001DE5CC
			// (set) Token: 0x06006299 RID: 25241 RVA: 0x00025F30 File Offset: 0x00024130
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._SendAgentToSpace_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._SendAgentToSpace_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001A4B RID: 6731
			// (get) Token: 0x0600629A RID: 25242 RVA: 0x001E03FC File Offset: 0x001DE5FC
			// (set) Token: 0x0600629B RID: 25243 RVA: 0x00025F4F File Offset: 0x0002414F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._SendAgentToSpace_d__25.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._SendAgentToSpace_d__25.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001A4C RID: 6732
			// (get) Token: 0x0600629C RID: 25244 RVA: 0x001E0424 File Offset: 0x001DE624
			// (set) Token: 0x0600629D RID: 25245 RVA: 0x00025F6A File Offset: 0x0002416A
			public unsafe AgentTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._SendAgentToSpace_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AgentTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AgentTurnPhase._SendAgentToSpace_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003FDA RID: 16346
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003FDB RID: 16347
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003FDC RID: 16348
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003FDD RID: 16349
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003FDE RID: 16350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003FDF RID: 16351
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FE0 RID: 16352
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003FE1 RID: 16353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003FE2 RID: 16354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003FE3 RID: 16355
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003FE4 RID: 16356
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003FE5 RID: 16357
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
