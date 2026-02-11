using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.gameLogs;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.abilities.PlayAbilities;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002D1 RID: 721
	public class RevealTurnPhase : StateMachineAction<RevealTurnState>
	{
		// Token: 0x06001DA2 RID: 7586 RVA: 0x000CC778 File Offset: 0x000CA978
		// Note: this type is marked as 'beforefieldinit'.
		static RevealTurnPhase()
		{
			Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "RevealTurnPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr);
			RevealTurnPhase.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "wormMatch");
			RevealTurnPhase.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "player");
			RevealTurnPhase.NativeFieldInfoPtr_initialReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "initialReveal");
			RevealTurnPhase.NativeFieldInfoPtr_revealedCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "revealedCards");
			RevealTurnPhase.NativeFieldInfoPtr_revealLogID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "revealLogID");
			RevealTurnPhase.NativeFieldInfoPtr_undoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "undoNode");
			RevealTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_Boolean_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669901);
			RevealTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedRevealTurnPhase_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669902);
			RevealTurnPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_RevealTurnState_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669903);
			RevealTurnPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_RevealTurnState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669904);
			RevealTurnPhase.NativeMethodInfoPtr_DoInitialReveal_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669905);
			RevealTurnPhase.NativeMethodInfoPtr_PlayRevealCardsPlay_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669906);
			RevealTurnPhase.NativeMethodInfoPtr_FireRevealStartTriggers_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669907);
			RevealTurnPhase.NativeMethodInfoPtr_GetUsableRevealAbilities_Private_IEnumerable_1_RevealAbility_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669908);
			RevealTurnPhase.NativeMethodInfoPtr_ResolveRevealAbilities_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669909);
			RevealTurnPhase.NativeMethodInfoPtr_ResolveImmediateDeferredAbilities_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669910);
			RevealTurnPhase.NativeMethodInfoPtr_FireTriggers_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669911);
			RevealTurnPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669912);
			RevealTurnPhase.NativeMethodInfoPtr__DetermineNextTypedState_b__8_0_Private_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669913);
			RevealTurnPhase.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_0_Private_SerializedGameLog_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669914);
			RevealTurnPhase.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_6_Private_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669915);
			RevealTurnPhase.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_7_Private_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669916);
			RevealTurnPhase.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_8_Private_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, 100669917);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x000CC974 File Offset: 0x000CAB74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164030, RefRangeEnd = 164031, XrefRangeStart = 164004, XrefRangeEnd = 164030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RevealTurnPhase(WormPlayer player, bool initialReveal, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialReveal;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_Boolean_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x000CC9E0 File Offset: 0x000CABE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164073, RefRangeEnd = 164074, XrefRangeStart = 164031, XrefRangeEnd = 164073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RevealTurnPhase(SerializedRevealTurnPhase serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedRevealTurnPhase_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x000CCA40 File Offset: 0x000CAC40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164074, XrefRangeEnd = 164103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<RevealTurnState> DetermineNextTypedState(global::Canis.actions.Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RevealTurnPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_RevealTurnState_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<RevealTurnState>(intPtr);
			}
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x000CCA94 File Offset: 0x000CAC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164103, XrefRangeEnd = 164114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior TypedBehaviorFor(RevealTurnState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RevealTurnPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_RevealTurnState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x000CCAEC File Offset: 0x000CACEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164114, XrefRangeEnd = 164120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> DoInitialReveal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr_DoInitialReveal_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x000CCB2C File Offset: 0x000CAD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164120, XrefRangeEnd = 164126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> PlayRevealCardsPlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr_PlayRevealCardsPlay_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x000CCB6C File Offset: 0x000CAD6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164126, XrefRangeEnd = 164132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> FireRevealStartTriggers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr_FireRevealStartTriggers_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x000CCBAC File Offset: 0x000CADAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164132, XrefRangeEnd = 164157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<RevealAbility> GetUsableRevealAbilities(WormPlayable card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr_GetUsableRevealAbilities_Private_IEnumerable_1_RevealAbility_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<RevealAbility>>(intPtr3) : null;
			}
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x000CCBFC File Offset: 0x000CADFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164157, XrefRangeEnd = 164162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ResolveRevealAbilities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr_ResolveRevealAbilities_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x000CCC3C File Offset: 0x000CAE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164162, XrefRangeEnd = 164167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ResolveImmediateDeferredAbilities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr_ResolveImmediateDeferredAbilities_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x000CCC7C File Offset: 0x000CAE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164167, XrefRangeEnd = 164173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> FireTriggers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr_FireTriggers_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x000CCCBC File Offset: 0x000CAEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164173, XrefRangeEnd = 164201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RevealTurnPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000CCD18 File Offset: 0x000CAF18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164201, XrefRangeEnd = 164229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _DetermineNextTypedState_b__8_0(WormPlayable card)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr__DetermineNextTypedState_b__8_0_Private_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x000CCD68 File Offset: 0x000CAF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164229, XrefRangeEnd = 164284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGameLog _PlayRevealCardsPlay_b__11_0(SerializedGameLog existingLog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(existingLog);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_0_Private_SerializedGameLog_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
			}
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x000CCDB8 File Offset: 0x000CAFB8
		[CallerCount(0)]
		public unsafe bool _PlayRevealCardsPlay_b__11_6(WormAgent _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_6_Private_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x000CCE08 File Offset: 0x000CB008
		[CallerCount(0)]
		public unsafe bool _PlayRevealCardsPlay_b__11_7(WormAgent _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_7_Private_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x000CCE58 File Offset: 0x000CB058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164284, XrefRangeEnd = 164285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlayRevealCardsPlay_b__11_8(WormSpace _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_8_Private_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x0000C731 File Offset: 0x0000A931
		public RevealTurnPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x000CCEA8 File Offset: 0x000CB0A8
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x0000C73A File Offset: 0x0000A93A
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x000CCED8 File Offset: 0x000CB0D8
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x0000C759 File Offset: 0x0000A959
		public unsafe WormPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x000CCF08 File Offset: 0x000CB108
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x0000C778 File Offset: 0x0000A978
		public unsafe bool initialReveal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.NativeFieldInfoPtr_initialReveal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.NativeFieldInfoPtr_initialReveal)) = value;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x000CCF30 File Offset: 0x000CB130
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x0000C793 File Offset: 0x0000A993
		public unsafe List<WormImperiumPlayable> revealedCards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.NativeFieldInfoPtr_revealedCards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormImperiumPlayable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.NativeFieldInfoPtr_revealedCards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x000CCF60 File Offset: 0x000CB160
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x0000C7B2 File Offset: 0x0000A9B2
		public Nullable<int> revealLogID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.NativeFieldInfoPtr_revealLogID);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.NativeFieldInfoPtr_revealLogID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x000CCF90 File Offset: 0x000CB190
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		public unsafe UndoNode undoNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.NativeFieldInfoPtr_undoNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.NativeFieldInfoPtr_undoNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001295 RID: 4757
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x04001296 RID: 4758
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001297 RID: 4759
		private static readonly IntPtr NativeFieldInfoPtr_initialReveal;

		// Token: 0x04001298 RID: 4760
		private static readonly IntPtr NativeFieldInfoPtr_revealedCards;

		// Token: 0x04001299 RID: 4761
		private static readonly IntPtr NativeFieldInfoPtr_revealLogID;

		// Token: 0x0400129A RID: 4762
		private static readonly IntPtr NativeFieldInfoPtr_undoNode;

		// Token: 0x0400129B RID: 4763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_Boolean_WormMatch_0;

		// Token: 0x0400129C RID: 4764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedRevealTurnPhase_WormMatch_0;

		// Token: 0x0400129D RID: 4765
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_RevealTurnState_Action_0;

		// Token: 0x0400129E RID: 4766
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_RevealTurnState_0;

		// Token: 0x0400129F RID: 4767
		private static readonly IntPtr NativeMethodInfoPtr_DoInitialReveal_Private_IEnumerable_1_Action_0;

		// Token: 0x040012A0 RID: 4768
		private static readonly IntPtr NativeMethodInfoPtr_PlayRevealCardsPlay_Private_IEnumerable_1_Action_0;

		// Token: 0x040012A1 RID: 4769
		private static readonly IntPtr NativeMethodInfoPtr_FireRevealStartTriggers_Private_IEnumerable_1_Action_0;

		// Token: 0x040012A2 RID: 4770
		private static readonly IntPtr NativeMethodInfoPtr_GetUsableRevealAbilities_Private_IEnumerable_1_RevealAbility_WormPlayable_0;

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr_ResolveRevealAbilities_Private_IEnumerable_1_Action_0;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_ResolveImmediateDeferredAbilities_Private_IEnumerable_1_Action_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr_FireTriggers_Private_IEnumerable_1_Action_0;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr__DetermineNextTypedState_b__8_0_Private_Boolean_WormPlayable_0;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_0_Private_SerializedGameLog_SerializedGameLog_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_6_Private_Boolean_WormAgent_0;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_7_Private_Boolean_WormAgent_0;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_8_Private_Boolean_WormSpace_0;

		// Token: 0x0200074F RID: 1871
		[ObfuscatedName("worm.canis.actions.phases.RevealTurnPhase+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060067E6 RID: 26598 RVA: 0x001F0B68 File Offset: 0x001EED68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr);
				RevealTurnPhase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, "<>9");
				RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, "<>9__11_4");
				RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, "<>9__11_5");
				RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, "<>9__11_9");
				RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, "<>9__11_1");
				RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, "<>9__11_2");
				RevealTurnPhase.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, "<>9__14_0");
				RevealTurnPhase.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, "<>9__14_1");
				RevealTurnPhase.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, "<>9__17_0");
				RevealTurnPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, 100669919);
				RevealTurnPhase.__c.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_4_Internal_ArchetypeID_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, 100669920);
				RevealTurnPhase.__c.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_5_Internal_Int32_KeyValuePair_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, 100669921);
				RevealTurnPhase.__c.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_9_Internal_ArchetypeID_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, 100669922);
				RevealTurnPhase.__c.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_1_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, 100669923);
				RevealTurnPhase.__c.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_2_Internal_ArchetypeID_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, 100669924);
				RevealTurnPhase.__c.NativeMethodInfoPtr__ResolveRevealAbilities_b__14_0_Internal_Boolean_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, 100669925);
				RevealTurnPhase.__c.NativeMethodInfoPtr__ResolveRevealAbilities_b__14_1_Internal_Int32_RevealAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, 100669926);
				RevealTurnPhase.__c.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__17_0_Internal_EntityID_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr, 100669927);
			}

			// Token: 0x060067E7 RID: 26599 RVA: 0x001F0CFC File Offset: 0x001EEEFC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealTurnPhase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060067E8 RID: 26600 RVA: 0x001F0D38 File Offset: 0x001EEF38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _PlayRevealCardsPlay_b__11_4(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_4_Internal_ArchetypeID_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x060067E9 RID: 26601 RVA: 0x001F0D88 File Offset: 0x001EEF88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163210, XrefRangeEnd = 163211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _PlayRevealCardsPlay_b__11_5(KeyValuePair<EntityID, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_5_Internal_Int32_KeyValuePair_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060067EA RID: 26602 RVA: 0x001F0DDC File Offset: 0x001EEFDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _PlayRevealCardsPlay_b__11_9(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_9_Internal_ArchetypeID_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x060067EB RID: 26603 RVA: 0x001F0E2C File Offset: 0x001EF02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163211, XrefRangeEnd = 163228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayRevealCardsPlay_b__11_1(WormImperiumPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_1_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060067EC RID: 26604 RVA: 0x001F0E7C File Offset: 0x001EF07C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _PlayRevealCardsPlay_b__11_2(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c.NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_2_Internal_ArchetypeID_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x060067ED RID: 26605 RVA: 0x001F0ECC File Offset: 0x001EF0CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163228, XrefRangeEnd = 163236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveRevealAbilities_b__14_0(WormPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c.NativeMethodInfoPtr__ResolveRevealAbilities_b__14_0_Internal_Boolean_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060067EE RID: 26606 RVA: 0x001F0F1C File Offset: 0x001EF11C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163236, XrefRangeEnd = 163239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ResolveRevealAbilities_b__14_1(RevealAbility ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c.NativeMethodInfoPtr__ResolveRevealAbilities_b__14_1_Internal_Int32_RevealAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060067EF RID: 26607 RVA: 0x001F0F6C File Offset: 0x001EF16C
			[CallerCount(0)]
			public unsafe EntityID _MakeSerializedStateMachineAction_b__17_0(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__17_0_Internal_EntityID_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060067F0 RID: 26608 RVA: 0x000289C0 File Offset: 0x00026BC0
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C0F RID: 7183
			// (get) Token: 0x060067F1 RID: 26609 RVA: 0x001F0FBC File Offset: 0x001EF1BC
			// (set) Token: 0x060067F2 RID: 26610 RVA: 0x000289C9 File Offset: 0x00026BC9
			public unsafe static RevealTurnPhase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RevealTurnPhase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C10 RID: 7184
			// (get) Token: 0x060067F3 RID: 26611 RVA: 0x001F0FE4 File Offset: 0x001EF1E4
			// (set) Token: 0x060067F4 RID: 26612 RVA: 0x000289DB File Offset: 0x00026BDB
			public unsafe static Func<WormImperiumPlayable, ArchetypeID> __9__11_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C11 RID: 7185
			// (get) Token: 0x060067F5 RID: 26613 RVA: 0x001F100C File Offset: 0x001EF20C
			// (set) Token: 0x060067F6 RID: 26614 RVA: 0x000289ED File Offset: 0x00026BED
			public unsafe static Func<KeyValuePair<EntityID, int>, int> __9__11_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C12 RID: 7186
			// (get) Token: 0x060067F7 RID: 26615 RVA: 0x001F1034 File Offset: 0x001EF234
			// (set) Token: 0x060067F8 RID: 26616 RVA: 0x000289FF File Offset: 0x00026BFF
			public unsafe static Func<WormSpace, ArchetypeID> __9__11_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C13 RID: 7187
			// (get) Token: 0x060067F9 RID: 26617 RVA: 0x001F105C File Offset: 0x001EF25C
			// (set) Token: 0x060067FA RID: 26618 RVA: 0x00028A11 File Offset: 0x00026C11
			public unsafe static Func<WormImperiumPlayable, bool> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C14 RID: 7188
			// (get) Token: 0x060067FB RID: 26619 RVA: 0x001F1084 File Offset: 0x001EF284
			// (set) Token: 0x060067FC RID: 26620 RVA: 0x00028A23 File Offset: 0x00026C23
			public unsafe static Func<WormImperiumPlayable, ArchetypeID> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C15 RID: 7189
			// (get) Token: 0x060067FD RID: 26621 RVA: 0x001F10AC File Offset: 0x001EF2AC
			// (set) Token: 0x060067FE RID: 26622 RVA: 0x00028A35 File Offset: 0x00026C35
			public unsafe static Func<WormPlayable, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C16 RID: 7190
			// (get) Token: 0x060067FF RID: 26623 RVA: 0x001F10D4 File Offset: 0x001EF2D4
			// (set) Token: 0x06006800 RID: 26624 RVA: 0x00028A47 File Offset: 0x00026C47
			public unsafe static Func<RevealAbility, int> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RevealAbility, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C17 RID: 7191
			// (get) Token: 0x06006801 RID: 26625 RVA: 0x001F10FC File Offset: 0x001EF2FC
			// (set) Token: 0x06006802 RID: 26626 RVA: 0x00028A59 File Offset: 0x00026C59
			public unsafe static Func<WormImperiumPlayable, EntityID> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RevealTurnPhase.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004338 RID: 17208
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004339 RID: 17209
			private static readonly IntPtr NativeFieldInfoPtr___9__11_4;

			// Token: 0x0400433A RID: 17210
			private static readonly IntPtr NativeFieldInfoPtr___9__11_5;

			// Token: 0x0400433B RID: 17211
			private static readonly IntPtr NativeFieldInfoPtr___9__11_9;

			// Token: 0x0400433C RID: 17212
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x0400433D RID: 17213
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x0400433E RID: 17214
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x0400433F RID: 17215
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x04004340 RID: 17216
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04004341 RID: 17217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004342 RID: 17218
			private static readonly IntPtr NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_4_Internal_ArchetypeID_WormImperiumPlayable_0;

			// Token: 0x04004343 RID: 17219
			private static readonly IntPtr NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_5_Internal_Int32_KeyValuePair_2_EntityID_Int32_0;

			// Token: 0x04004344 RID: 17220
			private static readonly IntPtr NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_9_Internal_ArchetypeID_WormSpace_0;

			// Token: 0x04004345 RID: 17221
			private static readonly IntPtr NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_1_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x04004346 RID: 17222
			private static readonly IntPtr NativeMethodInfoPtr__PlayRevealCardsPlay_b__11_2_Internal_ArchetypeID_WormImperiumPlayable_0;

			// Token: 0x04004347 RID: 17223
			private static readonly IntPtr NativeMethodInfoPtr__ResolveRevealAbilities_b__14_0_Internal_Boolean_WormPlayable_0;

			// Token: 0x04004348 RID: 17224
			private static readonly IntPtr NativeMethodInfoPtr__ResolveRevealAbilities_b__14_1_Internal_Int32_RevealAbility_0;

			// Token: 0x04004349 RID: 17225
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__17_0_Internal_EntityID_WormImperiumPlayable_0;
		}

		// Token: 0x02000750 RID: 1872
		[ObfuscatedName("worm.canis.actions.phases.RevealTurnPhase+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06006803 RID: 26627 RVA: 0x001F1124 File Offset: 0x001EF324
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass11_0>.NativeClassPtr);
				RevealTurnPhase.__c__DisplayClass11_0.NativeFieldInfoPtr_oneStepAheadArchID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass11_0>.NativeClassPtr, "oneStepAheadArchID");
				RevealTurnPhase.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass11_0>.NativeClassPtr, 100669928);
				RevealTurnPhase.__c__DisplayClass11_0.NativeMethodInfoPtr__PlayRevealCardsPlay_b__3_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass11_0>.NativeClassPtr, 100669929);
			}

			// Token: 0x06006804 RID: 26628 RVA: 0x001F118C File Offset: 0x001EF38C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006805 RID: 26629 RVA: 0x001F11C8 File Offset: 0x001EF3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163239, XrefRangeEnd = 163244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayRevealCardsPlay_b__3(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c__DisplayClass11_0.NativeMethodInfoPtr__PlayRevealCardsPlay_b__3_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006806 RID: 26630 RVA: 0x00028A6B File Offset: 0x00026C6B
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C18 RID: 7192
			// (get) Token: 0x06006807 RID: 26631 RVA: 0x001F1218 File Offset: 0x001EF418
			// (set) Token: 0x06006808 RID: 26632 RVA: 0x00028A74 File Offset: 0x00026C74
			public unsafe ArchetypeID oneStepAheadArchID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.__c__DisplayClass11_0.NativeFieldInfoPtr_oneStepAheadArchID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.__c__DisplayClass11_0.NativeFieldInfoPtr_oneStepAheadArchID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400434A RID: 17226
			private static readonly IntPtr NativeFieldInfoPtr_oneStepAheadArchID;

			// Token: 0x0400434B RID: 17227
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400434C RID: 17228
			private static readonly IntPtr NativeMethodInfoPtr__PlayRevealCardsPlay_b__3_Internal_Boolean_WormImperiumPlayable_0;
		}

		// Token: 0x02000751 RID: 1873
		[ObfuscatedName("worm.canis.actions.phases.RevealTurnPhase+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06006809 RID: 26633 RVA: 0x001F1248 File Offset: 0x001EF448
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass13_0>.NativeClassPtr);
				RevealTurnPhase.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				RevealTurnPhase.__c__DisplayClass13_0.NativeFieldInfoPtr_paramContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass13_0>.NativeClassPtr, "paramContext");
				RevealTurnPhase.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass13_0>.NativeClassPtr, 100669930);
				RevealTurnPhase.__c__DisplayClass13_0.NativeMethodInfoPtr__GetUsableRevealAbilities_b__0_Internal_Boolean_RevealAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass13_0>.NativeClassPtr, 100669931);
			}

			// Token: 0x0600680A RID: 26634 RVA: 0x001F12C4 File Offset: 0x001EF4C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600680B RID: 26635 RVA: 0x001F1300 File Offset: 0x001EF500
			[CallerCount(0)]
			public unsafe bool _GetUsableRevealAbilities_b__0(RevealAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c__DisplayClass13_0.NativeMethodInfoPtr__GetUsableRevealAbilities_b__0_Internal_Boolean_RevealAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600680C RID: 26636 RVA: 0x00028A93 File Offset: 0x00026C93
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C19 RID: 7193
			// (get) Token: 0x0600680D RID: 26637 RVA: 0x001F1350 File Offset: 0x001EF550
			// (set) Token: 0x0600680E RID: 26638 RVA: 0x00028A9C File Offset: 0x00026C9C
			public unsafe RevealTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RevealTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C1A RID: 7194
			// (get) Token: 0x0600680F RID: 26639 RVA: 0x001F1380 File Offset: 0x001EF580
			// (set) Token: 0x06006810 RID: 26640 RVA: 0x00028ABB File Offset: 0x00026CBB
			public unsafe Context paramContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.__c__DisplayClass13_0.NativeFieldInfoPtr_paramContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.__c__DisplayClass13_0.NativeFieldInfoPtr_paramContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400434D RID: 17229
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400434E RID: 17230
			private static readonly IntPtr NativeFieldInfoPtr_paramContext;

			// Token: 0x0400434F RID: 17231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004350 RID: 17232
			private static readonly IntPtr NativeMethodInfoPtr__GetUsableRevealAbilities_b__0_Internal_Boolean_RevealAbility_0;
		}

		// Token: 0x02000752 RID: 1874
		[ObfuscatedName("worm.canis.actions.phases.RevealTurnPhase+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x06006811 RID: 26641 RVA: 0x001F13B0 File Offset: 0x001EF5B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass15_0>.NativeClassPtr);
				RevealTurnPhase.__c__DisplayClass15_0.NativeFieldInfoPtr_evalContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass15_0>.NativeClassPtr, "evalContext");
				RevealTurnPhase.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass15_0>.NativeClassPtr, 100669932);
				RevealTurnPhase.__c__DisplayClass15_0.NativeMethodInfoPtr__ResolveImmediateDeferredAbilities_b__0_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass15_0>.NativeClassPtr, 100669933);
			}

			// Token: 0x06006812 RID: 26642 RVA: 0x001F1418 File Offset: 0x001EF618
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealTurnPhase.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006813 RID: 26643 RVA: 0x001F1454 File Offset: 0x001EF654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveImmediateDeferredAbilities_b__0(DeferredAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase.__c__DisplayClass15_0.NativeMethodInfoPtr__ResolveImmediateDeferredAbilities_b__0_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006814 RID: 26644 RVA: 0x00028ADA File Offset: 0x00026CDA
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C1B RID: 7195
			// (get) Token: 0x06006815 RID: 26645 RVA: 0x001F14A4 File Offset: 0x001EF6A4
			// (set) Token: 0x06006816 RID: 26646 RVA: 0x00028AE3 File Offset: 0x00026CE3
			public unsafe Context evalContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.__c__DisplayClass15_0.NativeFieldInfoPtr_evalContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase.__c__DisplayClass15_0.NativeFieldInfoPtr_evalContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004351 RID: 17233
			private static readonly IntPtr NativeFieldInfoPtr_evalContext;

			// Token: 0x04004352 RID: 17234
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004353 RID: 17235
			private static readonly IntPtr NativeMethodInfoPtr__ResolveImmediateDeferredAbilities_b__0_Internal_Boolean_DeferredAbility_0;
		}

		// Token: 0x02000753 RID: 1875
		[ObfuscatedName("worm.canis.actions.phases.RevealTurnPhase+<DoInitialReveal>d__10")]
		public sealed class _DoInitialReveal_d__10 : Object
		{
			// Token: 0x06006817 RID: 26647 RVA: 0x001F14D4 File Offset: 0x001EF6D4
			// Note: this type is marked as 'beforefieldinit'.
			static _DoInitialReveal_d__10()
			{
				Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "<DoInitialReveal>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr);
				RevealTurnPhase._DoInitialReveal_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr, "<>1__state");
				RevealTurnPhase._DoInitialReveal_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr, "<>2__current");
				RevealTurnPhase._DoInitialReveal_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr, "<>l__initialThreadId");
				RevealTurnPhase._DoInitialReveal_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr, "<>4__this");
				RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr, 100669934);
				RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr, 100669935);
				RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr, 100669936);
				RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr, 100669937);
				RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr, 100669938);
				RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr, 100669939);
				RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr, 100669940);
				RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr, 100669941);
			}

			// Token: 0x06006818 RID: 26648 RVA: 0x001F15F0 File Offset: 0x001EF7F0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoInitialReveal_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealTurnPhase._DoInitialReveal_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006819 RID: 26649 RVA: 0x001F1638 File Offset: 0x001EF838
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600681A RID: 26650 RVA: 0x001F166C File Offset: 0x001EF86C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163244, XrefRangeEnd = 163264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C20 RID: 7200
			// (get) Token: 0x0600681B RID: 26651 RVA: 0x001F16A8 File Offset: 0x001EF8A8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600681C RID: 26652 RVA: 0x001F16E8 File Offset: 0x001EF8E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163264, XrefRangeEnd = 163269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C21 RID: 7201
			// (get) Token: 0x0600681D RID: 26653 RVA: 0x001F171C File Offset: 0x001EF91C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600681E RID: 26654 RVA: 0x001F175C File Offset: 0x001EF95C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163269, XrefRangeEnd = 163271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600681F RID: 26655 RVA: 0x001F179C File Offset: 0x001EF99C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._DoInitialReveal_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006820 RID: 26656 RVA: 0x00028B02 File Offset: 0x00026D02
			public _DoInitialReveal_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C1C RID: 7196
			// (get) Token: 0x06006821 RID: 26657 RVA: 0x001F17DC File Offset: 0x001EF9DC
			// (set) Token: 0x06006822 RID: 26658 RVA: 0x00028B0B File Offset: 0x00026D0B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._DoInitialReveal_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._DoInitialReveal_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C1D RID: 7197
			// (get) Token: 0x06006823 RID: 26659 RVA: 0x001F1804 File Offset: 0x001EFA04
			// (set) Token: 0x06006824 RID: 26660 RVA: 0x00028B26 File Offset: 0x00026D26
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._DoInitialReveal_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._DoInitialReveal_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C1E RID: 7198
			// (get) Token: 0x06006825 RID: 26661 RVA: 0x001F1834 File Offset: 0x001EFA34
			// (set) Token: 0x06006826 RID: 26662 RVA: 0x00028B45 File Offset: 0x00026D45
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._DoInitialReveal_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._DoInitialReveal_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C1F RID: 7199
			// (get) Token: 0x06006827 RID: 26663 RVA: 0x001F185C File Offset: 0x001EFA5C
			// (set) Token: 0x06006828 RID: 26664 RVA: 0x00028B60 File Offset: 0x00026D60
			public unsafe RevealTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._DoInitialReveal_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RevealTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._DoInitialReveal_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004354 RID: 17236
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004355 RID: 17237
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004356 RID: 17238
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004357 RID: 17239
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004358 RID: 17240
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004359 RID: 17241
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400435A RID: 17242
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400435B RID: 17243
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400435C RID: 17244
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400435D RID: 17245
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400435E RID: 17246
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400435F RID: 17247
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000754 RID: 1876
		[ObfuscatedName("worm.canis.actions.phases.RevealTurnPhase+<FireRevealStartTriggers>d__12")]
		public sealed class _FireRevealStartTriggers_d__12 : Object
		{
			// Token: 0x06006829 RID: 26665 RVA: 0x001F188C File Offset: 0x001EFA8C
			// Note: this type is marked as 'beforefieldinit'.
			static _FireRevealStartTriggers_d__12()
			{
				Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "<FireRevealStartTriggers>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr);
				RevealTurnPhase._FireRevealStartTriggers_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr, "<>1__state");
				RevealTurnPhase._FireRevealStartTriggers_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr, "<>2__current");
				RevealTurnPhase._FireRevealStartTriggers_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr, "<>l__initialThreadId");
				RevealTurnPhase._FireRevealStartTriggers_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr, "<>4__this");
				RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr, 100669942);
				RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr, 100669943);
				RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr, 100669944);
				RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr, 100669945);
				RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr, 100669946);
				RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr, 100669947);
				RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr, 100669948);
				RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr, 100669949);
			}

			// Token: 0x0600682A RID: 26666 RVA: 0x001F19A8 File Offset: 0x001EFBA8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FireRevealStartTriggers_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealTurnPhase._FireRevealStartTriggers_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600682B RID: 26667 RVA: 0x001F19F0 File Offset: 0x001EFBF0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600682C RID: 26668 RVA: 0x001F1A24 File Offset: 0x001EFC24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C26 RID: 7206
			// (get) Token: 0x0600682D RID: 26669 RVA: 0x001F1A60 File Offset: 0x001EFC60
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600682E RID: 26670 RVA: 0x001F1AA0 File Offset: 0x001EFCA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163271, XrefRangeEnd = 163276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C27 RID: 7207
			// (get) Token: 0x0600682F RID: 26671 RVA: 0x001F1AD4 File Offset: 0x001EFCD4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006830 RID: 26672 RVA: 0x001F1B14 File Offset: 0x001EFD14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163276, XrefRangeEnd = 163278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006831 RID: 26673 RVA: 0x001F1B54 File Offset: 0x001EFD54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006832 RID: 26674 RVA: 0x00028B7F File Offset: 0x00026D7F
			public _FireRevealStartTriggers_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C22 RID: 7202
			// (get) Token: 0x06006833 RID: 26675 RVA: 0x001F1B94 File Offset: 0x001EFD94
			// (set) Token: 0x06006834 RID: 26676 RVA: 0x00028B88 File Offset: 0x00026D88
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C23 RID: 7203
			// (get) Token: 0x06006835 RID: 26677 RVA: 0x001F1BBC File Offset: 0x001EFDBC
			// (set) Token: 0x06006836 RID: 26678 RVA: 0x00028BA3 File Offset: 0x00026DA3
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C24 RID: 7204
			// (get) Token: 0x06006837 RID: 26679 RVA: 0x001F1BEC File Offset: 0x001EFDEC
			// (set) Token: 0x06006838 RID: 26680 RVA: 0x00028BC2 File Offset: 0x00026DC2
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C25 RID: 7205
			// (get) Token: 0x06006839 RID: 26681 RVA: 0x001F1C14 File Offset: 0x001EFE14
			// (set) Token: 0x0600683A RID: 26682 RVA: 0x00028BDD File Offset: 0x00026DDD
			public unsafe RevealTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RevealTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireRevealStartTriggers_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004360 RID: 17248
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004361 RID: 17249
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004362 RID: 17250
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004363 RID: 17251
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004364 RID: 17252
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004365 RID: 17253
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004366 RID: 17254
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004367 RID: 17255
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004368 RID: 17256
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004369 RID: 17257
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400436A RID: 17258
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400436B RID: 17259
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000755 RID: 1877
		[ObfuscatedName("worm.canis.actions.phases.RevealTurnPhase+<FireTriggers>d__16")]
		public sealed class _FireTriggers_d__16 : Object
		{
			// Token: 0x0600683B RID: 26683 RVA: 0x001F1C44 File Offset: 0x001EFE44
			// Note: this type is marked as 'beforefieldinit'.
			static _FireTriggers_d__16()
			{
				Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "<FireTriggers>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr);
				RevealTurnPhase._FireTriggers_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr, "<>1__state");
				RevealTurnPhase._FireTriggers_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr, "<>2__current");
				RevealTurnPhase._FireTriggers_d__16.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr, "<>l__initialThreadId");
				RevealTurnPhase._FireTriggers_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr, "<>4__this");
				RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr, 100669950);
				RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr, 100669951);
				RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr, 100669952);
				RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr, 100669953);
				RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr, 100669954);
				RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr, 100669955);
				RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr, 100669956);
				RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr, 100669957);
			}

			// Token: 0x0600683C RID: 26684 RVA: 0x001F1D60 File Offset: 0x001EFF60
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FireTriggers_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealTurnPhase._FireTriggers_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600683D RID: 26685 RVA: 0x001F1DA8 File Offset: 0x001EFFA8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600683E RID: 26686 RVA: 0x001F1DDC File Offset: 0x001EFFDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163278, XrefRangeEnd = 163284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C2C RID: 7212
			// (get) Token: 0x0600683F RID: 26687 RVA: 0x001F1E18 File Offset: 0x001F0018
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006840 RID: 26688 RVA: 0x001F1E58 File Offset: 0x001F0058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163284, XrefRangeEnd = 163289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C2D RID: 7213
			// (get) Token: 0x06006841 RID: 26689 RVA: 0x001F1E8C File Offset: 0x001F008C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006842 RID: 26690 RVA: 0x001F1ECC File Offset: 0x001F00CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163289, XrefRangeEnd = 163291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006843 RID: 26691 RVA: 0x001F1F0C File Offset: 0x001F010C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._FireTriggers_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006844 RID: 26692 RVA: 0x00028BFC File Offset: 0x00026DFC
			public _FireTriggers_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C28 RID: 7208
			// (get) Token: 0x06006845 RID: 26693 RVA: 0x001F1F4C File Offset: 0x001F014C
			// (set) Token: 0x06006846 RID: 26694 RVA: 0x00028C05 File Offset: 0x00026E05
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireTriggers_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireTriggers_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C29 RID: 7209
			// (get) Token: 0x06006847 RID: 26695 RVA: 0x001F1F74 File Offset: 0x001F0174
			// (set) Token: 0x06006848 RID: 26696 RVA: 0x00028C20 File Offset: 0x00026E20
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireTriggers_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireTriggers_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C2A RID: 7210
			// (get) Token: 0x06006849 RID: 26697 RVA: 0x001F1FA4 File Offset: 0x001F01A4
			// (set) Token: 0x0600684A RID: 26698 RVA: 0x00028C3F File Offset: 0x00026E3F
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireTriggers_d__16.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireTriggers_d__16.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C2B RID: 7211
			// (get) Token: 0x0600684B RID: 26699 RVA: 0x001F1FCC File Offset: 0x001F01CC
			// (set) Token: 0x0600684C RID: 26700 RVA: 0x00028C5A File Offset: 0x00026E5A
			public unsafe RevealTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireTriggers_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RevealTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._FireTriggers_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400436C RID: 17260
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400436D RID: 17261
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400436E RID: 17262
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400436F RID: 17263
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004370 RID: 17264
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004371 RID: 17265
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004372 RID: 17266
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004373 RID: 17267
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004374 RID: 17268
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004375 RID: 17269
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004376 RID: 17270
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004377 RID: 17271
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000756 RID: 1878
		[ObfuscatedName("worm.canis.actions.phases.RevealTurnPhase+<PlayRevealCardsPlay>d__11")]
		public sealed class _PlayRevealCardsPlay_d__11 : Object
		{
			// Token: 0x0600684D RID: 26701 RVA: 0x001F1FFC File Offset: 0x001F01FC
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayRevealCardsPlay_d__11()
			{
				Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "<PlayRevealCardsPlay>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr);
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, "<>1__state");
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, "<>2__current");
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, "<>l__initialThreadId");
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, "<>4__this");
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__cardsToReveal_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, "<cardsToReveal>5__2");
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__firstReveal_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, "<firstReveal>5__3");
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__existingID_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, "<existingID>5__4");
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__sequence_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, "<sequence>5__5");
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__epSum_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, "<epSum>5__6");
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__strengthSum_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, "<strengthSum>5__7");
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, "<>7__wrap7");
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___7__wrap8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, "<>7__wrap8");
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, 100669958);
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, 100669959);
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, 100669960);
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, 100669961);
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, 100669962);
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, 100669963);
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, 100669964);
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, 100669965);
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, 100669966);
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, 100669967);
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, 100669968);
				RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr, 100669969);
			}

			// Token: 0x0600684E RID: 26702 RVA: 0x001F2208 File Offset: 0x001F0408
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayRevealCardsPlay_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealTurnPhase._PlayRevealCardsPlay_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600684F RID: 26703 RVA: 0x001F2250 File Offset: 0x001F0450
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163291, XrefRangeEnd = 163311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006850 RID: 26704 RVA: 0x001F2284 File Offset: 0x001F0484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163311, XrefRangeEnd = 163831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006851 RID: 26705 RVA: 0x001F22C0 File Offset: 0x001F04C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163831, XrefRangeEnd = 163834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006852 RID: 26706 RVA: 0x001F22F4 File Offset: 0x001F04F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163834, XrefRangeEnd = 163837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006853 RID: 26707 RVA: 0x001F2328 File Offset: 0x001F0528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163837, XrefRangeEnd = 163840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006854 RID: 26708 RVA: 0x001F235C File Offset: 0x001F055C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 163843, RefRangeEnd = 163844, XrefRangeStart = 163840, XrefRangeEnd = 163843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C3A RID: 7226
			// (get) Token: 0x06006855 RID: 26709 RVA: 0x001F2390 File Offset: 0x001F0590
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006856 RID: 26710 RVA: 0x001F23D0 File Offset: 0x001F05D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163844, XrefRangeEnd = 163849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C3B RID: 7227
			// (get) Token: 0x06006857 RID: 26711 RVA: 0x001F2404 File Offset: 0x001F0604
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006858 RID: 26712 RVA: 0x001F2444 File Offset: 0x001F0644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163849, XrefRangeEnd = 163851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006859 RID: 26713 RVA: 0x001F2484 File Offset: 0x001F0684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600685A RID: 26714 RVA: 0x00028C79 File Offset: 0x00026E79
			public _PlayRevealCardsPlay_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C2E RID: 7214
			// (get) Token: 0x0600685B RID: 26715 RVA: 0x001F24C4 File Offset: 0x001F06C4
			// (set) Token: 0x0600685C RID: 26716 RVA: 0x00028C82 File Offset: 0x00026E82
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C2F RID: 7215
			// (get) Token: 0x0600685D RID: 26717 RVA: 0x001F24EC File Offset: 0x001F06EC
			// (set) Token: 0x0600685E RID: 26718 RVA: 0x00028C9D File Offset: 0x00026E9D
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C30 RID: 7216
			// (get) Token: 0x0600685F RID: 26719 RVA: 0x001F251C File Offset: 0x001F071C
			// (set) Token: 0x06006860 RID: 26720 RVA: 0x00028CBC File Offset: 0x00026EBC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C31 RID: 7217
			// (get) Token: 0x06006861 RID: 26721 RVA: 0x001F2544 File Offset: 0x001F0744
			// (set) Token: 0x06006862 RID: 26722 RVA: 0x00028CD7 File Offset: 0x00026ED7
			public unsafe RevealTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RevealTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C32 RID: 7218
			// (get) Token: 0x06006863 RID: 26723 RVA: 0x001F2574 File Offset: 0x001F0774
			// (set) Token: 0x06006864 RID: 26724 RVA: 0x00028CF6 File Offset: 0x00026EF6
			public unsafe List<WormImperiumPlayable> _cardsToReveal_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__cardsToReveal_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormImperiumPlayable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__cardsToReveal_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C33 RID: 7219
			// (get) Token: 0x06006865 RID: 26725 RVA: 0x001F25A4 File Offset: 0x001F07A4
			// (set) Token: 0x06006866 RID: 26726 RVA: 0x00028D15 File Offset: 0x00026F15
			public unsafe bool _firstReveal_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__firstReveal_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__firstReveal_5__3)) = value;
				}
			}

			// Token: 0x17001C34 RID: 7220
			// (get) Token: 0x06006867 RID: 26727 RVA: 0x001F25CC File Offset: 0x001F07CC
			// (set) Token: 0x06006868 RID: 26728 RVA: 0x00028D30 File Offset: 0x00026F30
			public unsafe int _existingID_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__existingID_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__existingID_5__4)) = value;
				}
			}

			// Token: 0x17001C35 RID: 7221
			// (get) Token: 0x06006869 RID: 26729 RVA: 0x001F25F4 File Offset: 0x001F07F4
			// (set) Token: 0x0600686A RID: 26730 RVA: 0x00028D4B File Offset: 0x00026F4B
			public unsafe SequenceHelper _sequence_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__sequence_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__sequence_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C36 RID: 7222
			// (get) Token: 0x0600686B RID: 26731 RVA: 0x001F2624 File Offset: 0x001F0824
			// (set) Token: 0x0600686C RID: 26732 RVA: 0x00028D6A File Offset: 0x00026F6A
			public unsafe int _epSum_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__epSum_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__epSum_5__6)) = value;
				}
			}

			// Token: 0x17001C37 RID: 7223
			// (get) Token: 0x0600686D RID: 26733 RVA: 0x001F264C File Offset: 0x001F084C
			// (set) Token: 0x0600686E RID: 26734 RVA: 0x00028D85 File Offset: 0x00026F85
			public unsafe int _strengthSum_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__strengthSum_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr__strengthSum_5__7)) = value;
				}
			}

			// Token: 0x17001C38 RID: 7224
			// (get) Token: 0x0600686F RID: 26735 RVA: 0x001F2674 File Offset: 0x001F0874
			// (set) Token: 0x06006870 RID: 26736 RVA: 0x00028DA0 File Offset: 0x00026FA0
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___7__wrap7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___7__wrap7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C39 RID: 7225
			// (get) Token: 0x06006871 RID: 26737 RVA: 0x001F26A4 File Offset: 0x001F08A4
			// (set) Token: 0x06006872 RID: 26738 RVA: 0x00028DBF File Offset: 0x00026FBF
			public List<WormImperiumPlayable>.Enumerator __7__wrap8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___7__wrap8);
					return new List<WormImperiumPlayable>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormImperiumPlayable>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._PlayRevealCardsPlay_d__11.NativeFieldInfoPtr___7__wrap8), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormImperiumPlayable>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04004378 RID: 17272
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004379 RID: 17273
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400437A RID: 17274
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400437B RID: 17275
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400437C RID: 17276
			private static readonly IntPtr NativeFieldInfoPtr__cardsToReveal_5__2;

			// Token: 0x0400437D RID: 17277
			private static readonly IntPtr NativeFieldInfoPtr__firstReveal_5__3;

			// Token: 0x0400437E RID: 17278
			private static readonly IntPtr NativeFieldInfoPtr__existingID_5__4;

			// Token: 0x0400437F RID: 17279
			private static readonly IntPtr NativeFieldInfoPtr__sequence_5__5;

			// Token: 0x04004380 RID: 17280
			private static readonly IntPtr NativeFieldInfoPtr__epSum_5__6;

			// Token: 0x04004381 RID: 17281
			private static readonly IntPtr NativeFieldInfoPtr__strengthSum_5__7;

			// Token: 0x04004382 RID: 17282
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x04004383 RID: 17283
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap8;

			// Token: 0x04004384 RID: 17284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004385 RID: 17285
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004386 RID: 17286
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004387 RID: 17287
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004388 RID: 17288
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04004389 RID: 17289
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x0400438A RID: 17290
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x0400438B RID: 17291
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400438C RID: 17292
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400438D RID: 17293
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400438E RID: 17294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400438F RID: 17295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000757 RID: 1879
		[ObfuscatedName("worm.canis.actions.phases.RevealTurnPhase+<ResolveImmediateDeferredAbilities>d__15")]
		public sealed class _ResolveImmediateDeferredAbilities_d__15 : Object
		{
			// Token: 0x06006873 RID: 26739 RVA: 0x001F26D4 File Offset: 0x001F08D4
			// Note: this type is marked as 'beforefieldinit'.
			static _ResolveImmediateDeferredAbilities_d__15()
			{
				Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "<ResolveImmediateDeferredAbilities>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr);
				RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr, "<>1__state");
				RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr, "<>2__current");
				RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr, "<>l__initialThreadId");
				RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr, "<>4__this");
				RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr, 100669970);
				RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr, 100669971);
				RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr, 100669972);
				RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr, 100669973);
				RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr, 100669974);
				RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr, 100669975);
				RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr, 100669976);
				RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr, 100669977);
			}

			// Token: 0x06006874 RID: 26740 RVA: 0x001F27F0 File Offset: 0x001F09F0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResolveImmediateDeferredAbilities_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006875 RID: 26741 RVA: 0x001F2838 File Offset: 0x001F0A38
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006876 RID: 26742 RVA: 0x001F286C File Offset: 0x001F0A6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163851, XrefRangeEnd = 163888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C40 RID: 7232
			// (get) Token: 0x06006877 RID: 26743 RVA: 0x001F28A8 File Offset: 0x001F0AA8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006878 RID: 26744 RVA: 0x001F28E8 File Offset: 0x001F0AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163888, XrefRangeEnd = 163893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C41 RID: 7233
			// (get) Token: 0x06006879 RID: 26745 RVA: 0x001F291C File Offset: 0x001F0B1C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600687A RID: 26746 RVA: 0x001F295C File Offset: 0x001F0B5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163893, XrefRangeEnd = 163895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600687B RID: 26747 RVA: 0x001F299C File Offset: 0x001F0B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600687C RID: 26748 RVA: 0x00028DED File Offset: 0x00026FED
			public _ResolveImmediateDeferredAbilities_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C3C RID: 7228
			// (get) Token: 0x0600687D RID: 26749 RVA: 0x001F29DC File Offset: 0x001F0BDC
			// (set) Token: 0x0600687E RID: 26750 RVA: 0x00028DF6 File Offset: 0x00026FF6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C3D RID: 7229
			// (get) Token: 0x0600687F RID: 26751 RVA: 0x001F2A04 File Offset: 0x001F0C04
			// (set) Token: 0x06006880 RID: 26752 RVA: 0x00028E11 File Offset: 0x00027011
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C3E RID: 7230
			// (get) Token: 0x06006881 RID: 26753 RVA: 0x001F2A34 File Offset: 0x001F0C34
			// (set) Token: 0x06006882 RID: 26754 RVA: 0x00028E30 File Offset: 0x00027030
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C3F RID: 7231
			// (get) Token: 0x06006883 RID: 26755 RVA: 0x001F2A5C File Offset: 0x001F0C5C
			// (set) Token: 0x06006884 RID: 26756 RVA: 0x00028E4B File Offset: 0x0002704B
			public unsafe RevealTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RevealTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveImmediateDeferredAbilities_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004390 RID: 17296
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004391 RID: 17297
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004392 RID: 17298
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004393 RID: 17299
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004394 RID: 17300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004395 RID: 17301
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004396 RID: 17302
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004397 RID: 17303
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004398 RID: 17304
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004399 RID: 17305
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400439A RID: 17306
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400439B RID: 17307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000758 RID: 1880
		[ObfuscatedName("worm.canis.actions.phases.RevealTurnPhase+<ResolveRevealAbilities>d__14")]
		public sealed class _ResolveRevealAbilities_d__14 : Object
		{
			// Token: 0x06006885 RID: 26757 RVA: 0x001F2A8C File Offset: 0x001F0C8C
			// Note: this type is marked as 'beforefieldinit'.
			static _ResolveRevealAbilities_d__14()
			{
				Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RevealTurnPhase>.NativeClassPtr, "<ResolveRevealAbilities>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr);
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, "<>1__state");
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, "<>2__current");
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, "<>l__initialThreadId");
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, "<>4__this");
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, "<>7__wrap1");
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr__revealAbility_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, "<revealAbility>5__3");
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, 100669978);
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, 100669979);
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, 100669980);
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, 100669981);
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, 100669982);
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, 100669983);
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, 100669984);
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, 100669985);
				RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr, 100669986);
			}

			// Token: 0x06006886 RID: 26758 RVA: 0x001F2BE4 File Offset: 0x001F0DE4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResolveRevealAbilities_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RevealTurnPhase._ResolveRevealAbilities_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006887 RID: 26759 RVA: 0x001F2C2C File Offset: 0x001F0E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163895, XrefRangeEnd = 163900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006888 RID: 26760 RVA: 0x001F2C60 File Offset: 0x001F0E60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163900, XrefRangeEnd = 163994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006889 RID: 26761 RVA: 0x001F2C9C File Offset: 0x001F0E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163994, XrefRangeEnd = 163997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C48 RID: 7240
			// (get) Token: 0x0600688A RID: 26762 RVA: 0x001F2CD0 File Offset: 0x001F0ED0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600688B RID: 26763 RVA: 0x001F2D10 File Offset: 0x001F0F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163997, XrefRangeEnd = 164002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C49 RID: 7241
			// (get) Token: 0x0600688C RID: 26764 RVA: 0x001F2D44 File Offset: 0x001F0F44
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600688D RID: 26765 RVA: 0x001F2D84 File Offset: 0x001F0F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164002, XrefRangeEnd = 164004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600688E RID: 26766 RVA: 0x001F2DC4 File Offset: 0x001F0FC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600688F RID: 26767 RVA: 0x00028E6A File Offset: 0x0002706A
			public _ResolveRevealAbilities_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C42 RID: 7234
			// (get) Token: 0x06006890 RID: 26768 RVA: 0x001F2E04 File Offset: 0x001F1004
			// (set) Token: 0x06006891 RID: 26769 RVA: 0x00028E73 File Offset: 0x00027073
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C43 RID: 7235
			// (get) Token: 0x06006892 RID: 26770 RVA: 0x001F2E2C File Offset: 0x001F102C
			// (set) Token: 0x06006893 RID: 26771 RVA: 0x00028E8E File Offset: 0x0002708E
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C44 RID: 7236
			// (get) Token: 0x06006894 RID: 26772 RVA: 0x001F2E5C File Offset: 0x001F105C
			// (set) Token: 0x06006895 RID: 26773 RVA: 0x00028EAD File Offset: 0x000270AD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C45 RID: 7237
			// (get) Token: 0x06006896 RID: 26774 RVA: 0x001F2E84 File Offset: 0x001F1084
			// (set) Token: 0x06006897 RID: 26775 RVA: 0x00028EC8 File Offset: 0x000270C8
			public unsafe RevealTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RevealTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C46 RID: 7238
			// (get) Token: 0x06006898 RID: 26776 RVA: 0x001F2EB4 File Offset: 0x001F10B4
			// (set) Token: 0x06006899 RID: 26777 RVA: 0x00028EE7 File Offset: 0x000270E7
			public List<RevealAbility>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___7__wrap1);
					return new List<RevealAbility>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<RevealAbility>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<RevealAbility>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001C47 RID: 7239
			// (get) Token: 0x0600689A RID: 26778 RVA: 0x001F2EE4 File Offset: 0x001F10E4
			// (set) Token: 0x0600689B RID: 26779 RVA: 0x00028F15 File Offset: 0x00027115
			public unsafe RevealAbility _revealAbility_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr__revealAbility_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RevealAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RevealTurnPhase._ResolveRevealAbilities_d__14.NativeFieldInfoPtr__revealAbility_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400439C RID: 17308
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400439D RID: 17309
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400439E RID: 17310
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400439F RID: 17311
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040043A0 RID: 17312
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040043A1 RID: 17313
			private static readonly IntPtr NativeFieldInfoPtr__revealAbility_5__3;

			// Token: 0x040043A2 RID: 17314
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040043A3 RID: 17315
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040043A4 RID: 17316
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040043A5 RID: 17317
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040043A6 RID: 17318
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040043A7 RID: 17319
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040043A8 RID: 17320
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040043A9 RID: 17321
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040043AA RID: 17322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
