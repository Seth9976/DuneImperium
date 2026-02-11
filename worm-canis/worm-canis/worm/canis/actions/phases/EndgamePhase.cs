using System;
using Canis;
using Canis.actions;
using Canis.context;
using Canis.entities;
using Canis.gameLogs;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.abilities.PlayAbilities;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002C2 RID: 706
	public class EndgamePhase : StateMachineAction<EndgameState>
	{
		// Token: 0x06001D1E RID: 7454 RVA: 0x000CA3E0 File Offset: 0x000C85E0
		// Note: this type is marked as 'beforefieldinit'.
		static EndgamePhase()
		{
			Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "EndgamePhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr);
			EndgamePhase.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, "wormMatch");
			EndgamePhase.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669510);
			EndgamePhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedEndgamePhase_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669511);
			EndgamePhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_EndgameState_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669512);
			EndgamePhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_EndgameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669513);
			EndgamePhase.NativeMethodInfoPtr_get_PlayableEndgameIntrigueCards_Private_get_IEnumerable_1_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669514);
			EndgamePhase.NativeMethodInfoPtr_get_PlayableEndgameTechTiles_Private_get_IEnumerable_1_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669515);
			EndgamePhase.NativeMethodInfoPtr_PlayEndgameIntrigues_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669516);
			EndgamePhase.NativeMethodInfoPtr_AdjustScores_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669517);
			EndgamePhase.NativeMethodInfoPtr_DetermineWinner_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669518);
			EndgamePhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669519);
			EndgamePhase.NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__6_0_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669520);
			EndgamePhase.NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__6_2_Private_Boolean_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669521);
			EndgamePhase.NativeMethodInfoPtr__get_PlayableEndgameTechTiles_b__8_2_Private_Boolean_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669522);
			EndgamePhase.NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_2_Private_Boolean_ValueTuple_2_WormAbilityDefinition_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, 100669523);
		}

		// Token: 0x06001D1F RID: 7455 RVA: 0x000CA53C File Offset: 0x000C873C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157175, XrefRangeEnd = 157182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndgamePhase(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x000CA588 File Offset: 0x000C8788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157182, XrefRangeEnd = 157189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EndgamePhase(SerializedEndgamePhase serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedEndgamePhase_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D21 RID: 7457 RVA: 0x000CA5E8 File Offset: 0x000C87E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157189, XrefRangeEnd = 157201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<EndgameState> DetermineNextTypedState(global::Canis.actions.Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndgamePhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_EndgameState_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<EndgameState>(intPtr);
			}
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x000CA63C File Offset: 0x000C883C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157201, XrefRangeEnd = 157209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior TypedBehaviorFor(EndgameState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndgamePhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_EndgameState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x000CA694 File Offset: 0x000C8894
		public unsafe IEnumerable<WormIntriguePlayable> PlayableEndgameIntrigueCards
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 157250, RefRangeEnd = 157252, XrefRangeStart = 157209, XrefRangeEnd = 157250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.NativeMethodInfoPtr_get_PlayableEndgameIntrigueCards_Private_get_IEnumerable_1_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormIntriguePlayable>>(intPtr3) : null;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x000CA6D4 File Offset: 0x000C88D4
		public unsafe IEnumerable<WormTechTilePlayable> PlayableEndgameTechTiles
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157301, RefRangeEnd = 157302, XrefRangeStart = 157252, XrefRangeEnd = 157301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.NativeMethodInfoPtr_get_PlayableEndgameTechTiles_Private_get_IEnumerable_1_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormTechTilePlayable>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000CA714 File Offset: 0x000C8914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157302, XrefRangeEnd = 157308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> PlayEndgameIntrigues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.NativeMethodInfoPtr_PlayEndgameIntrigues_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x000CA754 File Offset: 0x000C8954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157308, XrefRangeEnd = 157314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> AdjustScores()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.NativeMethodInfoPtr_AdjustScores_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x000CA794 File Offset: 0x000C8994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157314, XrefRangeEnd = 157320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> DetermineWinner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.NativeMethodInfoPtr_DetermineWinner_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x000CA7D4 File Offset: 0x000C89D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157320, XrefRangeEnd = 157324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EndgamePhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x000CA830 File Offset: 0x000C8A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157324, XrefRangeEnd = 157332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_PlayableEndgameIntrigueCards_b__6_0(WormPlayer _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__6_0_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x000CA880 File Offset: 0x000C8A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157332, XrefRangeEnd = 157351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_PlayableEndgameIntrigueCards_b__6_2(WormIntriguePlayable intrigue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(intrigue);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__6_2_Private_Boolean_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x000CA8D0 File Offset: 0x000C8AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157351, XrefRangeEnd = 157370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_PlayableEndgameTechTiles_b__8_2(WormTechTilePlayable techTile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(techTile);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.NativeMethodInfoPtr__get_PlayableEndgameTechTiles_b__8_2_Private_Boolean_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D2C RID: 7468 RVA: 0x000CA920 File Offset: 0x000C8B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157370, XrefRangeEnd = 157377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlayEndgameIntrigues_b__9_2(ValueTuple<WormAbilityDefinition, PlayerEntity> pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_2_Private_Boolean_ValueTuple_2_WormAbilityDefinition_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D2D RID: 7469 RVA: 0x0000C4C7 File Offset: 0x0000A6C7
		public EndgamePhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x000CA974 File Offset: 0x000C8B74
		// (set) Token: 0x06001D2F RID: 7471 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400121D RID: 4637
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEndgamePhase_WormMatch_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_EndgameState_Action_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_EndgameState_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayableEndgameIntrigueCards_Private_get_IEnumerable_1_WormIntriguePlayable_0;

		// Token: 0x04001223 RID: 4643
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayableEndgameTechTiles_Private_get_IEnumerable_1_WormTechTilePlayable_0;

		// Token: 0x04001224 RID: 4644
		private static readonly IntPtr NativeMethodInfoPtr_PlayEndgameIntrigues_Private_IEnumerable_1_Action_0;

		// Token: 0x04001225 RID: 4645
		private static readonly IntPtr NativeMethodInfoPtr_AdjustScores_Private_IEnumerable_1_Action_0;

		// Token: 0x04001226 RID: 4646
		private static readonly IntPtr NativeMethodInfoPtr_DetermineWinner_Private_IEnumerable_1_Action_0;

		// Token: 0x04001227 RID: 4647
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;

		// Token: 0x04001228 RID: 4648
		private static readonly IntPtr NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__6_0_Private_Boolean_WormPlayer_0;

		// Token: 0x04001229 RID: 4649
		private static readonly IntPtr NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__6_2_Private_Boolean_WormIntriguePlayable_0;

		// Token: 0x0400122A RID: 4650
		private static readonly IntPtr NativeMethodInfoPtr__get_PlayableEndgameTechTiles_b__8_2_Private_Boolean_WormTechTilePlayable_0;

		// Token: 0x0400122B RID: 4651
		private static readonly IntPtr NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_2_Private_Boolean_ValueTuple_2_WormAbilityDefinition_PlayerEntity_0;

		// Token: 0x02000728 RID: 1832
		[ObfuscatedName("worm.canis.actions.phases.EndgamePhase+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006486 RID: 25734 RVA: 0x001E628C File Offset: 0x001E448C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr);
				EndgamePhase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, "<>9");
				EndgamePhase.__c.NativeFieldInfoPtr___9__6_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, "<>9__6_3");
				EndgamePhase.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, "<>9__6_1");
				EndgamePhase.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, "<>9__8_0");
				EndgamePhase.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, "<>9__8_1");
				EndgamePhase.__c.NativeFieldInfoPtr___9__9_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, "<>9__9_4");
				EndgamePhase.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, "<>9__9_0");
				EndgamePhase.__c.NativeFieldInfoPtr___9__9_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, "<>9__9_5");
				EndgamePhase.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, "<>9__9_1");
				EndgamePhase.__c.NativeFieldInfoPtr___9__9_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, "<>9__9_3");
				EndgamePhase.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, "<>9__10_0");
				EndgamePhase.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, "<>9__11_2");
				EndgamePhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, 100669525);
				EndgamePhase.__c.NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__6_1_Internal_IEnumerable_1_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, 100669526);
				EndgamePhase.__c.NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__6_3_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, 100669527);
				EndgamePhase.__c.NativeMethodInfoPtr__get_PlayableEndgameTechTiles_b__8_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, 100669528);
				EndgamePhase.__c.NativeMethodInfoPtr__get_PlayableEndgameTechTiles_b__8_1_Internal_IEnumerable_1_Entity_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, 100669529);
				EndgamePhase.__c.NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_0_Internal_IEnumerable_1_ValueTuple_2_WormAbilityDefinition_PlayerEntity_WormIntriguePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, 100669530);
				EndgamePhase.__c.NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_4_Internal_ValueTuple_2_WormAbilityDefinition_PlayerEntity_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, 100669531);
				EndgamePhase.__c.NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_1_Internal_IEnumerable_1_ValueTuple_2_WormAbilityDefinition_PlayerEntity_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, 100669532);
				EndgamePhase.__c.NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_5_Internal_ValueTuple_2_WormAbilityDefinition_PlayerEntity_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, 100669533);
				EndgamePhase.__c.NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_3_Internal_Nullable_1_Int32_ValueTuple_2_WormAbilityDefinition_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, 100669534);
				EndgamePhase.__c.NativeMethodInfoPtr__AdjustScores_b__10_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, 100669535);
				EndgamePhase.__c.NativeMethodInfoPtr__DetermineWinner_b__11_2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr, 100669536);
			}

			// Token: 0x06006487 RID: 25735 RVA: 0x001E6498 File Offset: 0x001E4698
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndgamePhase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006488 RID: 25736 RVA: 0x001E64D4 File Offset: 0x001E46D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156512, XrefRangeEnd = 156531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Entity> _get_PlayableEndgameIntrigueCards_b__6_1(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c.NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__6_1_Internal_IEnumerable_1_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x06006489 RID: 25737 RVA: 0x001E6524 File Offset: 0x001E4724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156531, XrefRangeEnd = 156548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_PlayableEndgameIntrigueCards_b__6_3(Entity intrigueCard)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(intrigueCard);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c.NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__6_3_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600648A RID: 25738 RVA: 0x001E6574 File Offset: 0x001E4774
			[CallerCount(0)]
			public unsafe bool _get_PlayableEndgameTechTiles_b__8_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c.NativeMethodInfoPtr__get_PlayableEndgameTechTiles_b__8_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600648B RID: 25739 RVA: 0x001E65C4 File Offset: 0x001E47C4
			[CallerCount(0)]
			public unsafe IEnumerable<Entity> _get_PlayableEndgameTechTiles_b__8_1(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c.NativeMethodInfoPtr__get_PlayableEndgameTechTiles_b__8_1_Internal_IEnumerable_1_Entity_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x0600648C RID: 25740 RVA: 0x001E6614 File Offset: 0x001E4814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156548, XrefRangeEnd = 156569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ValueTuple<WormAbilityDefinition, PlayerEntity>> _PlayEndgameIntrigues_b__9_0(WormIntriguePlayable intrigue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(intrigue);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c.NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_0_Internal_IEnumerable_1_ValueTuple_2_WormAbilityDefinition_PlayerEntity_WormIntriguePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<WormAbilityDefinition, PlayerEntity>>>(intPtr3) : null;
				}
			}

			// Token: 0x0600648D RID: 25741 RVA: 0x001E6664 File Offset: 0x001E4864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156569, XrefRangeEnd = 156574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<WormAbilityDefinition, PlayerEntity> _PlayEndgameIntrigues_b__9_4(WormAbilityDefinition ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c.NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_4_Internal_ValueTuple_2_WormAbilityDefinition_PlayerEntity_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<WormAbilityDefinition, PlayerEntity>(intPtr);
				}
			}

			// Token: 0x0600648E RID: 25742 RVA: 0x001E66AC File Offset: 0x001E48AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156574, XrefRangeEnd = 156595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ValueTuple<WormAbilityDefinition, PlayerEntity>> _PlayEndgameIntrigues_b__9_1(WormTechTilePlayable techTile)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(techTile);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c.NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_1_Internal_IEnumerable_1_ValueTuple_2_WormAbilityDefinition_PlayerEntity_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<WormAbilityDefinition, PlayerEntity>>>(intPtr3) : null;
				}
			}

			// Token: 0x0600648F RID: 25743 RVA: 0x001E66FC File Offset: 0x001E48FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156595, XrefRangeEnd = 156600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<WormAbilityDefinition, PlayerEntity> _PlayEndgameIntrigues_b__9_5(WormAbilityDefinition ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c.NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_5_Internal_ValueTuple_2_WormAbilityDefinition_PlayerEntity_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<WormAbilityDefinition, PlayerEntity>(intPtr);
				}
			}

			// Token: 0x06006490 RID: 25744 RVA: 0x001E6744 File Offset: 0x001E4944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156600, XrefRangeEnd = 156604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<int> _PlayEndgameIntrigues_b__9_3(ValueTuple<WormAbilityDefinition, PlayerEntity> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c.NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_3_Internal_Nullable_1_Int32_ValueTuple_2_WormAbilityDefinition_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new Nullable<int>(intPtr);
				}
			}

			// Token: 0x06006491 RID: 25745 RVA: 0x001E6794 File Offset: 0x001E4994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AdjustScores_b__10_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c.NativeMethodInfoPtr__AdjustScores_b__10_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006492 RID: 25746 RVA: 0x001E67E4 File Offset: 0x001E49E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156604, XrefRangeEnd = 156605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineWinner_b__11_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c.NativeMethodInfoPtr__DetermineWinner_b__11_2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006493 RID: 25747 RVA: 0x00026F39 File Offset: 0x00025139
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AEF RID: 6895
			// (get) Token: 0x06006494 RID: 25748 RVA: 0x001E6834 File Offset: 0x001E4A34
			// (set) Token: 0x06006495 RID: 25749 RVA: 0x00026F42 File Offset: 0x00025142
			public unsafe static EndgamePhase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EndgamePhase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndgamePhase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EndgamePhase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF0 RID: 6896
			// (get) Token: 0x06006496 RID: 25750 RVA: 0x001E685C File Offset: 0x001E4A5C
			// (set) Token: 0x06006497 RID: 25751 RVA: 0x00026F54 File Offset: 0x00025154
			public unsafe static Func<Entity, bool> __9__6_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EndgamePhase.__c.NativeFieldInfoPtr___9__6_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EndgamePhase.__c.NativeFieldInfoPtr___9__6_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF1 RID: 6897
			// (get) Token: 0x06006498 RID: 25752 RVA: 0x001E6884 File Offset: 0x001E4A84
			// (set) Token: 0x06006499 RID: 25753 RVA: 0x00026F66 File Offset: 0x00025166
			public unsafe static Func<WormPlayer, IEnumerable<Entity>> __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EndgamePhase.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EndgamePhase.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF2 RID: 6898
			// (get) Token: 0x0600649A RID: 25754 RVA: 0x001E68AC File Offset: 0x001E4AAC
			// (set) Token: 0x0600649B RID: 25755 RVA: 0x00026F78 File Offset: 0x00025178
			public unsafe static Func<WormPlayer, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EndgamePhase.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EndgamePhase.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF3 RID: 6899
			// (get) Token: 0x0600649C RID: 25756 RVA: 0x001E68D4 File Offset: 0x001E4AD4
			// (set) Token: 0x0600649D RID: 25757 RVA: 0x00026F8A File Offset: 0x0002518A
			public unsafe static Func<WormPlayer, IEnumerable<Entity>> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EndgamePhase.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EndgamePhase.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF4 RID: 6900
			// (get) Token: 0x0600649E RID: 25758 RVA: 0x001E68FC File Offset: 0x001E4AFC
			// (set) Token: 0x0600649F RID: 25759 RVA: 0x00026F9C File Offset: 0x0002519C
			public unsafe static Func<WormAbilityDefinition, ValueTuple<WormAbilityDefinition, PlayerEntity>> __9__9_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EndgamePhase.__c.NativeFieldInfoPtr___9__9_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, ValueTuple<WormAbilityDefinition, PlayerEntity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EndgamePhase.__c.NativeFieldInfoPtr___9__9_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF5 RID: 6901
			// (get) Token: 0x060064A0 RID: 25760 RVA: 0x001E6924 File Offset: 0x001E4B24
			// (set) Token: 0x060064A1 RID: 25761 RVA: 0x00026FAE File Offset: 0x000251AE
			public unsafe static Func<WormIntriguePlayable, IEnumerable<ValueTuple<WormAbilityDefinition, PlayerEntity>>> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EndgamePhase.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormIntriguePlayable, IEnumerable<ValueTuple<WormAbilityDefinition, PlayerEntity>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EndgamePhase.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF6 RID: 6902
			// (get) Token: 0x060064A2 RID: 25762 RVA: 0x001E694C File Offset: 0x001E4B4C
			// (set) Token: 0x060064A3 RID: 25763 RVA: 0x00026FC0 File Offset: 0x000251C0
			public unsafe static Func<WormAbilityDefinition, ValueTuple<WormAbilityDefinition, PlayerEntity>> __9__9_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EndgamePhase.__c.NativeFieldInfoPtr___9__9_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, ValueTuple<WormAbilityDefinition, PlayerEntity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EndgamePhase.__c.NativeFieldInfoPtr___9__9_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF7 RID: 6903
			// (get) Token: 0x060064A4 RID: 25764 RVA: 0x001E6974 File Offset: 0x001E4B74
			// (set) Token: 0x060064A5 RID: 25765 RVA: 0x00026FD2 File Offset: 0x000251D2
			public unsafe static Func<WormTechTilePlayable, IEnumerable<ValueTuple<WormAbilityDefinition, PlayerEntity>>> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EndgamePhase.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, IEnumerable<ValueTuple<WormAbilityDefinition, PlayerEntity>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EndgamePhase.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF8 RID: 6904
			// (get) Token: 0x060064A6 RID: 25766 RVA: 0x001E699C File Offset: 0x001E4B9C
			// (set) Token: 0x060064A7 RID: 25767 RVA: 0x00026FE4 File Offset: 0x000251E4
			public unsafe static Func<ValueTuple<WormAbilityDefinition, PlayerEntity>, Nullable<int>> __9__9_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EndgamePhase.__c.NativeFieldInfoPtr___9__9_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<WormAbilityDefinition, PlayerEntity>, Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EndgamePhase.__c.NativeFieldInfoPtr___9__9_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AF9 RID: 6905
			// (get) Token: 0x060064A8 RID: 25768 RVA: 0x001E69C4 File Offset: 0x001E4BC4
			// (set) Token: 0x060064A9 RID: 25769 RVA: 0x00026FF6 File Offset: 0x000251F6
			public unsafe static Func<WormPlayer, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EndgamePhase.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EndgamePhase.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFA RID: 6906
			// (get) Token: 0x060064AA RID: 25770 RVA: 0x001E69EC File Offset: 0x001E4BEC
			// (set) Token: 0x060064AB RID: 25771 RVA: 0x00027008 File Offset: 0x00025208
			public unsafe static Func<Entity, bool> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EndgamePhase.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EndgamePhase.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004114 RID: 16660
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004115 RID: 16661
			private static readonly IntPtr NativeFieldInfoPtr___9__6_3;

			// Token: 0x04004116 RID: 16662
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04004117 RID: 16663
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x04004118 RID: 16664
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x04004119 RID: 16665
			private static readonly IntPtr NativeFieldInfoPtr___9__9_4;

			// Token: 0x0400411A RID: 16666
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x0400411B RID: 16667
			private static readonly IntPtr NativeFieldInfoPtr___9__9_5;

			// Token: 0x0400411C RID: 16668
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x0400411D RID: 16669
			private static readonly IntPtr NativeFieldInfoPtr___9__9_3;

			// Token: 0x0400411E RID: 16670
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400411F RID: 16671
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x04004120 RID: 16672
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004121 RID: 16673
			private static readonly IntPtr NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__6_1_Internal_IEnumerable_1_Entity_WormPlayer_0;

			// Token: 0x04004122 RID: 16674
			private static readonly IntPtr NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__6_3_Internal_Boolean_Entity_0;

			// Token: 0x04004123 RID: 16675
			private static readonly IntPtr NativeMethodInfoPtr__get_PlayableEndgameTechTiles_b__8_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004124 RID: 16676
			private static readonly IntPtr NativeMethodInfoPtr__get_PlayableEndgameTechTiles_b__8_1_Internal_IEnumerable_1_Entity_WormPlayer_0;

			// Token: 0x04004125 RID: 16677
			private static readonly IntPtr NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_0_Internal_IEnumerable_1_ValueTuple_2_WormAbilityDefinition_PlayerEntity_WormIntriguePlayable_0;

			// Token: 0x04004126 RID: 16678
			private static readonly IntPtr NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_4_Internal_ValueTuple_2_WormAbilityDefinition_PlayerEntity_WormAbilityDefinition_0;

			// Token: 0x04004127 RID: 16679
			private static readonly IntPtr NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_1_Internal_IEnumerable_1_ValueTuple_2_WormAbilityDefinition_PlayerEntity_WormTechTilePlayable_0;

			// Token: 0x04004128 RID: 16680
			private static readonly IntPtr NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_5_Internal_ValueTuple_2_WormAbilityDefinition_PlayerEntity_WormAbilityDefinition_0;

			// Token: 0x04004129 RID: 16681
			private static readonly IntPtr NativeMethodInfoPtr__PlayEndgameIntrigues_b__9_3_Internal_Nullable_1_Int32_ValueTuple_2_WormAbilityDefinition_PlayerEntity_0;

			// Token: 0x0400412A RID: 16682
			private static readonly IntPtr NativeMethodInfoPtr__AdjustScores_b__10_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400412B RID: 16683
			private static readonly IntPtr NativeMethodInfoPtr__DetermineWinner_b__11_2_Internal_Boolean_Entity_0;
		}

		// Token: 0x02000729 RID: 1833
		[ObfuscatedName("worm.canis.actions.phases.EndgamePhase+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x060064AC RID: 25772 RVA: 0x001E6A14 File Offset: 0x001E4C14
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr);
				EndgamePhase.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				EndgamePhase.__c__DisplayClass11_0.NativeFieldInfoPtr_winner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, "winner");
				EndgamePhase.__c__DisplayClass11_0.NativeFieldInfoPtr_highestScorers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, "highestScorers");
				EndgamePhase.__c__DisplayClass11_0.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, "<>9__8");
				EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, 100669537);
				EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Int32_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, 100669538);
				EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, 100669539);
				EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__7_Internal_GameLogListItem_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, 100669540);
				EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__3_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, 100669541);
				EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__4_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, 100669542);
				EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__5_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, 100669543);
				EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__6_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, 100669544);
				EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__8_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr, 100669545);
			}

			// Token: 0x060064AD RID: 25773 RVA: 0x001E6B44 File Offset: 0x001E4D44
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060064AE RID: 25774 RVA: 0x001E6B80 File Offset: 0x001E4D80
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 156626, RefRangeEnd = 156629, XrefRangeStart = 156605, XrefRangeEnd = 156626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Method_Internal_Int32_WormPlayer_0(WormPlayer player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Int32_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060064AF RID: 25775 RVA: 0x001E6BD0 File Offset: 0x001E4DD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156629, XrefRangeEnd = 156636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineWinner_b__1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060064B0 RID: 25776 RVA: 0x001E6C20 File Offset: 0x001E4E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156636, XrefRangeEnd = 156649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameLogListItem _DetermineWinner_b__7(WormPlayer hs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hs);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__7_Internal_GameLogListItem_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogListItem>(intPtr3) : null;
				}
			}

			// Token: 0x060064B1 RID: 25777 RVA: 0x001E6C70 File Offset: 0x001E4E70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156649, XrefRangeEnd = 156651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineWinner_b__3(WormPlayer hs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hs);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__3_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060064B2 RID: 25778 RVA: 0x001E6CC0 File Offset: 0x001E4EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156651, XrefRangeEnd = 156653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineWinner_b__4(WormPlayer hs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hs);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__4_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060064B3 RID: 25779 RVA: 0x001E6D10 File Offset: 0x001E4F10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156653, XrefRangeEnd = 156655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineWinner_b__5(WormPlayer hs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hs);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__5_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060064B4 RID: 25780 RVA: 0x001E6D60 File Offset: 0x001E4F60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156655, XrefRangeEnd = 156657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineWinner_b__6(WormPlayer hs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(hs);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__6_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060064B5 RID: 25781 RVA: 0x001E6DB0 File Offset: 0x001E4FB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156657, XrefRangeEnd = 156660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineWinner_b__8(WormPlayer loser)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(loser);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass11_0.NativeMethodInfoPtr__DetermineWinner_b__8_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060064B6 RID: 25782 RVA: 0x0002701A File Offset: 0x0002521A
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AFB RID: 6907
			// (get) Token: 0x060064B7 RID: 25783 RVA: 0x001E6E00 File Offset: 0x001E5000
			// (set) Token: 0x060064B8 RID: 25784 RVA: 0x00027023 File Offset: 0x00025223
			public unsafe EndgamePhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndgamePhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFC RID: 6908
			// (get) Token: 0x060064B9 RID: 25785 RVA: 0x001E6E30 File Offset: 0x001E5030
			// (set) Token: 0x060064BA RID: 25786 RVA: 0x00027042 File Offset: 0x00025242
			public unsafe WormPlayer winner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass11_0.NativeFieldInfoPtr_winner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass11_0.NativeFieldInfoPtr_winner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFD RID: 6909
			// (get) Token: 0x060064BB RID: 25787 RVA: 0x001E6E60 File Offset: 0x001E5060
			// (set) Token: 0x060064BC RID: 25788 RVA: 0x00027061 File Offset: 0x00025261
			public unsafe List<WormPlayer> highestScorers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass11_0.NativeFieldInfoPtr_highestScorers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass11_0.NativeFieldInfoPtr_highestScorers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001AFE RID: 6910
			// (get) Token: 0x060064BD RID: 25789 RVA: 0x001E6E90 File Offset: 0x001E5090
			// (set) Token: 0x060064BE RID: 25790 RVA: 0x00027080 File Offset: 0x00025280
			public unsafe Func<WormPlayer, bool> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass11_0.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass11_0.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400412C RID: 16684
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400412D RID: 16685
			private static readonly IntPtr NativeFieldInfoPtr_winner;

			// Token: 0x0400412E RID: 16686
			private static readonly IntPtr NativeFieldInfoPtr_highestScorers;

			// Token: 0x0400412F RID: 16687
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x04004130 RID: 16688
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004131 RID: 16689
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Int32_WormPlayer_0;

			// Token: 0x04004132 RID: 16690
			private static readonly IntPtr NativeMethodInfoPtr__DetermineWinner_b__1_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004133 RID: 16691
			private static readonly IntPtr NativeMethodInfoPtr__DetermineWinner_b__7_Internal_GameLogListItem_WormPlayer_0;

			// Token: 0x04004134 RID: 16692
			private static readonly IntPtr NativeMethodInfoPtr__DetermineWinner_b__3_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004135 RID: 16693
			private static readonly IntPtr NativeMethodInfoPtr__DetermineWinner_b__4_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004136 RID: 16694
			private static readonly IntPtr NativeMethodInfoPtr__DetermineWinner_b__5_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004137 RID: 16695
			private static readonly IntPtr NativeMethodInfoPtr__DetermineWinner_b__6_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004138 RID: 16696
			private static readonly IntPtr NativeMethodInfoPtr__DetermineWinner_b__8_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x0200072A RID: 1834
		[ObfuscatedName("worm.canis.actions.phases.EndgamePhase+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Object
		{
			// Token: 0x060064BF RID: 25791 RVA: 0x001E6EC0 File Offset: 0x001E50C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_1>.NativeClassPtr);
				EndgamePhase.__c__DisplayClass11_1.NativeFieldInfoPtr_loser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_1>.NativeClassPtr, "loser");
				EndgamePhase.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_1>.NativeClassPtr, 100669546);
				EndgamePhase.__c__DisplayClass11_1.NativeMethodInfoPtr__DetermineWinner_b__9_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_1>.NativeClassPtr, 100669547);
			}

			// Token: 0x060064C0 RID: 25792 RVA: 0x001E6F28 File Offset: 0x001E5128
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060064C1 RID: 25793 RVA: 0x001E6F64 File Offset: 0x001E5164
			[CallerCount(0)]
			public unsafe bool _DetermineWinner_b__9(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass11_1.NativeMethodInfoPtr__DetermineWinner_b__9_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060064C2 RID: 25794 RVA: 0x0002709F File Offset: 0x0002529F
			public __c__DisplayClass11_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001AFF RID: 6911
			// (get) Token: 0x060064C3 RID: 25795 RVA: 0x001E6FB4 File Offset: 0x001E51B4
			// (set) Token: 0x060064C4 RID: 25796 RVA: 0x000270A8 File Offset: 0x000252A8
			public unsafe WormPlayer loser
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass11_1.NativeFieldInfoPtr_loser);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass11_1.NativeFieldInfoPtr_loser), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004139 RID: 16697
			private static readonly IntPtr NativeFieldInfoPtr_loser;

			// Token: 0x0400413A RID: 16698
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400413B RID: 16699
			private static readonly IntPtr NativeMethodInfoPtr__DetermineWinner_b__9_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x0200072B RID: 1835
		[ObfuscatedName("worm.canis.actions.phases.EndgamePhase+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x060064C5 RID: 25797 RVA: 0x001E6FE4 File Offset: 0x001E51E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass6_0>.NativeClassPtr);
				EndgamePhase.__c__DisplayClass6_0.NativeFieldInfoPtr_intrigue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass6_0>.NativeClassPtr, "intrigue");
				EndgamePhase.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				EndgamePhase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass6_0>.NativeClassPtr, 100669548);
				EndgamePhase.__c__DisplayClass6_0.NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__4_Internal_Boolean_PlayAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass6_0>.NativeClassPtr, 100669549);
			}

			// Token: 0x060064C6 RID: 25798 RVA: 0x001E7060 File Offset: 0x001E5260
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060064C7 RID: 25799 RVA: 0x001E709C File Offset: 0x001E529C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156660, XrefRangeEnd = 156661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_PlayableEndgameIntrigueCards_b__4(PlayAbility ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass6_0.NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__4_Internal_Boolean_PlayAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060064C8 RID: 25800 RVA: 0x000270C7 File Offset: 0x000252C7
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B00 RID: 6912
			// (get) Token: 0x060064C9 RID: 25801 RVA: 0x001E70EC File Offset: 0x001E52EC
			// (set) Token: 0x060064CA RID: 25802 RVA: 0x000270D0 File Offset: 0x000252D0
			public unsafe WormIntriguePlayable intrigue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass6_0.NativeFieldInfoPtr_intrigue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormIntriguePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass6_0.NativeFieldInfoPtr_intrigue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B01 RID: 6913
			// (get) Token: 0x060064CB RID: 25803 RVA: 0x001E711C File Offset: 0x001E531C
			// (set) Token: 0x060064CC RID: 25804 RVA: 0x000270EF File Offset: 0x000252EF
			public unsafe EndgamePhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndgamePhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400413C RID: 16700
			private static readonly IntPtr NativeFieldInfoPtr_intrigue;

			// Token: 0x0400413D RID: 16701
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400413E RID: 16702
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400413F RID: 16703
			private static readonly IntPtr NativeMethodInfoPtr__get_PlayableEndgameIntrigueCards_b__4_Internal_Boolean_PlayAbility_0;
		}

		// Token: 0x0200072C RID: 1836
		[ObfuscatedName("worm.canis.actions.phases.EndgamePhase+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x060064CD RID: 25805 RVA: 0x001E714C File Offset: 0x001E534C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass8_0>.NativeClassPtr);
				EndgamePhase.__c__DisplayClass8_0.NativeFieldInfoPtr_techTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass8_0>.NativeClassPtr, "techTile");
				EndgamePhase.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				EndgamePhase.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass8_0>.NativeClassPtr, 100669550);
				EndgamePhase.__c__DisplayClass8_0.NativeMethodInfoPtr__get_PlayableEndgameTechTiles_b__3_Internal_Boolean_DeferredAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass8_0>.NativeClassPtr, 100669551);
			}

			// Token: 0x060064CE RID: 25806 RVA: 0x001E71C8 File Offset: 0x001E53C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndgamePhase.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060064CF RID: 25807 RVA: 0x001E7204 File Offset: 0x001E5404
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156661, XrefRangeEnd = 156662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_PlayableEndgameTechTiles_b__3(DeferredAbility ability)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase.__c__DisplayClass8_0.NativeMethodInfoPtr__get_PlayableEndgameTechTiles_b__3_Internal_Boolean_DeferredAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060064D0 RID: 25808 RVA: 0x0002710E File Offset: 0x0002530E
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B02 RID: 6914
			// (get) Token: 0x060064D1 RID: 25809 RVA: 0x001E7254 File Offset: 0x001E5454
			// (set) Token: 0x060064D2 RID: 25810 RVA: 0x00027117 File Offset: 0x00025317
			public unsafe WormTechTilePlayable techTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass8_0.NativeFieldInfoPtr_techTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormTechTilePlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass8_0.NativeFieldInfoPtr_techTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B03 RID: 6915
			// (get) Token: 0x060064D3 RID: 25811 RVA: 0x001E7284 File Offset: 0x001E5484
			// (set) Token: 0x060064D4 RID: 25812 RVA: 0x00027136 File Offset: 0x00025336
			public unsafe EndgamePhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndgamePhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004140 RID: 16704
			private static readonly IntPtr NativeFieldInfoPtr_techTile;

			// Token: 0x04004141 RID: 16705
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004142 RID: 16706
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004143 RID: 16707
			private static readonly IntPtr NativeMethodInfoPtr__get_PlayableEndgameTechTiles_b__3_Internal_Boolean_DeferredAbility_0;
		}

		// Token: 0x0200072D RID: 1837
		[ObfuscatedName("worm.canis.actions.phases.EndgamePhase+<AdjustScores>d__10")]
		public sealed class _AdjustScores_d__10 : Object
		{
			// Token: 0x060064D5 RID: 25813 RVA: 0x001E72B4 File Offset: 0x001E54B4
			// Note: this type is marked as 'beforefieldinit'.
			static _AdjustScores_d__10()
			{
				Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, "<AdjustScores>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr);
				EndgamePhase._AdjustScores_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr, "<>1__state");
				EndgamePhase._AdjustScores_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr, "<>2__current");
				EndgamePhase._AdjustScores_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr, "<>l__initialThreadId");
				EndgamePhase._AdjustScores_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr, "<>4__this");
				EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr, 100669552);
				EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr, 100669553);
				EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr, 100669554);
				EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr, 100669555);
				EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr, 100669556);
				EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr, 100669557);
				EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr, 100669558);
				EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr, 100669559);
			}

			// Token: 0x060064D6 RID: 25814 RVA: 0x001E73D0 File Offset: 0x001E55D0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AdjustScores_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndgamePhase._AdjustScores_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060064D7 RID: 25815 RVA: 0x001E7418 File Offset: 0x001E5618
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060064D8 RID: 25816 RVA: 0x001E744C File Offset: 0x001E564C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156662, XrefRangeEnd = 156691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B08 RID: 6920
			// (get) Token: 0x060064D9 RID: 25817 RVA: 0x001E7488 File Offset: 0x001E5688
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060064DA RID: 25818 RVA: 0x001E74C8 File Offset: 0x001E56C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156691, XrefRangeEnd = 156696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B09 RID: 6921
			// (get) Token: 0x060064DB RID: 25819 RVA: 0x001E74FC File Offset: 0x001E56FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060064DC RID: 25820 RVA: 0x001E753C File Offset: 0x001E573C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156696, XrefRangeEnd = 156698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060064DD RID: 25821 RVA: 0x001E757C File Offset: 0x001E577C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._AdjustScores_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060064DE RID: 25822 RVA: 0x00027155 File Offset: 0x00025355
			public _AdjustScores_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B04 RID: 6916
			// (get) Token: 0x060064DF RID: 25823 RVA: 0x001E75BC File Offset: 0x001E57BC
			// (set) Token: 0x060064E0 RID: 25824 RVA: 0x0002715E File Offset: 0x0002535E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._AdjustScores_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._AdjustScores_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B05 RID: 6917
			// (get) Token: 0x060064E1 RID: 25825 RVA: 0x001E75E4 File Offset: 0x001E57E4
			// (set) Token: 0x060064E2 RID: 25826 RVA: 0x00027179 File Offset: 0x00025379
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._AdjustScores_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._AdjustScores_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B06 RID: 6918
			// (get) Token: 0x060064E3 RID: 25827 RVA: 0x001E7614 File Offset: 0x001E5814
			// (set) Token: 0x060064E4 RID: 25828 RVA: 0x00027198 File Offset: 0x00025398
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._AdjustScores_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._AdjustScores_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B07 RID: 6919
			// (get) Token: 0x060064E5 RID: 25829 RVA: 0x001E763C File Offset: 0x001E583C
			// (set) Token: 0x060064E6 RID: 25830 RVA: 0x000271B3 File Offset: 0x000253B3
			public unsafe EndgamePhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._AdjustScores_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndgamePhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._AdjustScores_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004144 RID: 16708
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004145 RID: 16709
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004146 RID: 16710
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004147 RID: 16711
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004148 RID: 16712
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004149 RID: 16713
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400414A RID: 16714
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400414B RID: 16715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400414C RID: 16716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400414D RID: 16717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400414E RID: 16718
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400414F RID: 16719
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200072E RID: 1838
		[ObfuscatedName("worm.canis.actions.phases.EndgamePhase+<DetermineWinner>d__11")]
		public sealed class _DetermineWinner_d__11 : Object
		{
			// Token: 0x060064E7 RID: 25831 RVA: 0x001E766C File Offset: 0x001E586C
			// Note: this type is marked as 'beforefieldinit'.
			static _DetermineWinner_d__11()
			{
				Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, "<DetermineWinner>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr);
				EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, "<>1__state");
				EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, "<>2__current");
				EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, "<>l__initialThreadId");
				EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, "<>4__this");
				EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, "<>8__1");
				EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, "<>8__2");
				EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr__playerOrder_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, "<playerOrder>5__2");
				EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr__losers_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, "<losers>5__3");
				EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, "<>7__wrap3");
				EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, 100669560);
				EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, 100669561);
				EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, 100669562);
				EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, 100669563);
				EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, 100669564);
				EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, 100669565);
				EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, 100669566);
				EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, 100669567);
				EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr, 100669568);
			}

			// Token: 0x060064E8 RID: 25832 RVA: 0x001E7800 File Offset: 0x001E5A00
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DetermineWinner_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndgamePhase._DetermineWinner_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060064E9 RID: 25833 RVA: 0x001E7848 File Offset: 0x001E5A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156698, XrefRangeEnd = 156703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060064EA RID: 25834 RVA: 0x001E787C File Offset: 0x001E5A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156703, XrefRangeEnd = 156988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060064EB RID: 25835 RVA: 0x001E78B8 File Offset: 0x001E5AB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 156991, RefRangeEnd = 156992, XrefRangeStart = 156988, XrefRangeEnd = 156991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B13 RID: 6931
			// (get) Token: 0x060064EC RID: 25836 RVA: 0x001E78EC File Offset: 0x001E5AEC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060064ED RID: 25837 RVA: 0x001E792C File Offset: 0x001E5B2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156992, XrefRangeEnd = 156997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B14 RID: 6932
			// (get) Token: 0x060064EE RID: 25838 RVA: 0x001E7960 File Offset: 0x001E5B60
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060064EF RID: 25839 RVA: 0x001E79A0 File Offset: 0x001E5BA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156997, XrefRangeEnd = 156999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060064F0 RID: 25840 RVA: 0x001E79E0 File Offset: 0x001E5BE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._DetermineWinner_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060064F1 RID: 25841 RVA: 0x000271D2 File Offset: 0x000253D2
			public _DetermineWinner_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B0A RID: 6922
			// (get) Token: 0x060064F2 RID: 25842 RVA: 0x001E7A20 File Offset: 0x001E5C20
			// (set) Token: 0x060064F3 RID: 25843 RVA: 0x000271DB File Offset: 0x000253DB
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B0B RID: 6923
			// (get) Token: 0x060064F4 RID: 25844 RVA: 0x001E7A48 File Offset: 0x001E5C48
			// (set) Token: 0x060064F5 RID: 25845 RVA: 0x000271F6 File Offset: 0x000253F6
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B0C RID: 6924
			// (get) Token: 0x060064F6 RID: 25846 RVA: 0x001E7A78 File Offset: 0x001E5C78
			// (set) Token: 0x060064F7 RID: 25847 RVA: 0x00027215 File Offset: 0x00025415
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B0D RID: 6925
			// (get) Token: 0x060064F8 RID: 25848 RVA: 0x001E7AA0 File Offset: 0x001E5CA0
			// (set) Token: 0x060064F9 RID: 25849 RVA: 0x00027230 File Offset: 0x00025430
			public unsafe EndgamePhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndgamePhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B0E RID: 6926
			// (get) Token: 0x060064FA RID: 25850 RVA: 0x001E7AD0 File Offset: 0x001E5CD0
			// (set) Token: 0x060064FB RID: 25851 RVA: 0x0002724F File Offset: 0x0002544F
			public unsafe EndgamePhase.__c__DisplayClass11_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndgamePhase.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B0F RID: 6927
			// (get) Token: 0x060064FC RID: 25852 RVA: 0x001E7B00 File Offset: 0x001E5D00
			// (set) Token: 0x060064FD RID: 25853 RVA: 0x0002726E File Offset: 0x0002546E
			public unsafe EndgamePhase.__c__DisplayClass11_1 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndgamePhase.__c__DisplayClass11_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B10 RID: 6928
			// (get) Token: 0x060064FE RID: 25854 RVA: 0x001E7B30 File Offset: 0x001E5D30
			// (set) Token: 0x060064FF RID: 25855 RVA: 0x0002728D File Offset: 0x0002548D
			public unsafe List<WormPlayer> _playerOrder_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr__playerOrder_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr__playerOrder_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B11 RID: 6929
			// (get) Token: 0x06006500 RID: 25856 RVA: 0x001E7B60 File Offset: 0x001E5D60
			// (set) Token: 0x06006501 RID: 25857 RVA: 0x000272AC File Offset: 0x000254AC
			public unsafe Il2CppReferenceArray<Entity> _losers_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr__losers_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr__losers_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B12 RID: 6930
			// (get) Token: 0x06006502 RID: 25858 RVA: 0x001E7B90 File Offset: 0x001E5D90
			// (set) Token: 0x06006503 RID: 25859 RVA: 0x000272CB File Offset: 0x000254CB
			public unsafe IEnumerator<WormPlayer> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._DetermineWinner_d__11.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004150 RID: 16720
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004151 RID: 16721
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004152 RID: 16722
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004153 RID: 16723
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004154 RID: 16724
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04004155 RID: 16725
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x04004156 RID: 16726
			private static readonly IntPtr NativeFieldInfoPtr__playerOrder_5__2;

			// Token: 0x04004157 RID: 16727
			private static readonly IntPtr NativeFieldInfoPtr__losers_5__3;

			// Token: 0x04004158 RID: 16728
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04004159 RID: 16729
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400415A RID: 16730
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400415B RID: 16731
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400415C RID: 16732
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400415D RID: 16733
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400415E RID: 16734
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400415F RID: 16735
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004160 RID: 16736
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004161 RID: 16737
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200072F RID: 1839
		[ObfuscatedName("worm.canis.actions.phases.EndgamePhase+<PlayEndgameIntrigues>d__9")]
		public sealed class _PlayEndgameIntrigues_d__9 : Object
		{
			// Token: 0x06006504 RID: 25860 RVA: 0x001E7BC0 File Offset: 0x001E5DC0
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayEndgameIntrigues_d__9()
			{
				Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EndgamePhase>.NativeClassPtr, "<PlayEndgameIntrigues>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr);
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, "<>1__state");
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, "<>2__current");
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, "<>l__initialThreadId");
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, "<>4__this");
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, "<>7__wrap1");
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr__ability_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, "<ability>5__3");
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr__player_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, "<player>5__4");
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr__abilityContext_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, "<abilityContext>5__5");
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, 100669569);
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, 100669570);
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, 100669571);
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, 100669572);
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, 100669573);
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, 100669574);
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, 100669575);
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, 100669576);
				EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr, 100669577);
			}

			// Token: 0x06006505 RID: 25861 RVA: 0x001E7D40 File Offset: 0x001E5F40
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayEndgameIntrigues_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EndgamePhase._PlayEndgameIntrigues_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006506 RID: 25862 RVA: 0x001E7D88 File Offset: 0x001E5F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156999, XrefRangeEnd = 157004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006507 RID: 25863 RVA: 0x001E7DBC File Offset: 0x001E5FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157004, XrefRangeEnd = 157165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006508 RID: 25864 RVA: 0x001E7DF8 File Offset: 0x001E5FF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157165, XrefRangeEnd = 157168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B1D RID: 6941
			// (get) Token: 0x06006509 RID: 25865 RVA: 0x001E7E2C File Offset: 0x001E602C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600650A RID: 25866 RVA: 0x001E7E6C File Offset: 0x001E606C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157168, XrefRangeEnd = 157173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B1E RID: 6942
			// (get) Token: 0x0600650B RID: 25867 RVA: 0x001E7EA0 File Offset: 0x001E60A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600650C RID: 25868 RVA: 0x001E7EE0 File Offset: 0x001E60E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157173, XrefRangeEnd = 157175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600650D RID: 25869 RVA: 0x001E7F20 File Offset: 0x001E6120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EndgamePhase._PlayEndgameIntrigues_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600650E RID: 25870 RVA: 0x000272EA File Offset: 0x000254EA
			public _PlayEndgameIntrigues_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B15 RID: 6933
			// (get) Token: 0x0600650F RID: 25871 RVA: 0x001E7F60 File Offset: 0x001E6160
			// (set) Token: 0x06006510 RID: 25872 RVA: 0x000272F3 File Offset: 0x000254F3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B16 RID: 6934
			// (get) Token: 0x06006511 RID: 25873 RVA: 0x001E7F88 File Offset: 0x001E6188
			// (set) Token: 0x06006512 RID: 25874 RVA: 0x0002730E File Offset: 0x0002550E
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B17 RID: 6935
			// (get) Token: 0x06006513 RID: 25875 RVA: 0x001E7FB8 File Offset: 0x001E61B8
			// (set) Token: 0x06006514 RID: 25876 RVA: 0x0002732D File Offset: 0x0002552D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B18 RID: 6936
			// (get) Token: 0x06006515 RID: 25877 RVA: 0x001E7FE0 File Offset: 0x001E61E0
			// (set) Token: 0x06006516 RID: 25878 RVA: 0x00027348 File Offset: 0x00025548
			public unsafe EndgamePhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EndgamePhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B19 RID: 6937
			// (get) Token: 0x06006517 RID: 25879 RVA: 0x001E8010 File Offset: 0x001E6210
			// (set) Token: 0x06006518 RID: 25880 RVA: 0x00027367 File Offset: 0x00025567
			public List<ValueTuple<WormAbilityDefinition, PlayerEntity>>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___7__wrap1);
					return new List<ValueTuple<WormAbilityDefinition, PlayerEntity>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ValueTuple<WormAbilityDefinition, PlayerEntity>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ValueTuple<WormAbilityDefinition, PlayerEntity>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001B1A RID: 6938
			// (get) Token: 0x06006519 RID: 25881 RVA: 0x001E8040 File Offset: 0x001E6240
			// (set) Token: 0x0600651A RID: 25882 RVA: 0x00027395 File Offset: 0x00025595
			public unsafe WormAbilityDefinition _ability_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr__ability_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAbilityDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr__ability_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B1B RID: 6939
			// (get) Token: 0x0600651B RID: 25883 RVA: 0x001E8070 File Offset: 0x001E6270
			// (set) Token: 0x0600651C RID: 25884 RVA: 0x000273B4 File Offset: 0x000255B4
			public unsafe PlayerEntity _player_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr__player_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr__player_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B1C RID: 6940
			// (get) Token: 0x0600651D RID: 25885 RVA: 0x001E80A0 File Offset: 0x001E62A0
			// (set) Token: 0x0600651E RID: 25886 RVA: 0x000273D3 File Offset: 0x000255D3
			public unsafe Context _abilityContext_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr__abilityContext_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EndgamePhase._PlayEndgameIntrigues_d__9.NativeFieldInfoPtr__abilityContext_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004162 RID: 16738
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004163 RID: 16739
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004164 RID: 16740
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004165 RID: 16741
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004166 RID: 16742
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04004167 RID: 16743
			private static readonly IntPtr NativeFieldInfoPtr__ability_5__3;

			// Token: 0x04004168 RID: 16744
			private static readonly IntPtr NativeFieldInfoPtr__player_5__4;

			// Token: 0x04004169 RID: 16745
			private static readonly IntPtr NativeFieldInfoPtr__abilityContext_5__5;

			// Token: 0x0400416A RID: 16746
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400416B RID: 16747
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400416C RID: 16748
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400416D RID: 16749
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400416E RID: 16750
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400416F RID: 16751
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004170 RID: 16752
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004171 RID: 16753
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004172 RID: 16754
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
