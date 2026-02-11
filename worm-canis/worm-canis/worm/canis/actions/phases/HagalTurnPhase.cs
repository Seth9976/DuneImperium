using System;
using Canis;
using Canis.actions;
using Canis.entities;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.abilities;
using worm.canis.abilities.ActivatedAbilities;
using worm.canis.abilities.HagalAbilities;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002CB RID: 715
	public class HagalTurnPhase : StateMachineAction<HagalTurnState>
	{
		// Token: 0x06001D5C RID: 7516 RVA: 0x000CB4A4 File Offset: 0x000C96A4
		// Note: this type is marked as 'beforefieldinit'.
		static HagalTurnPhase()
		{
			Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "HagalTurnPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr);
			HagalTurnPhase.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, "wormMatch");
			HagalTurnPhase.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, "player");
			HagalTurnPhase.NativeFieldInfoPtr_foundOpenSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, "foundOpenSpace");
			HagalTurnPhase.NativeFieldInfoPtr_revealedHagalCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, "revealedHagalCards");
			HagalTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669681);
			HagalTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedHagalTurnPhase_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669682);
			HagalTurnPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_HagalTurnState_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669683);
			HagalTurnPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_HagalTurnState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669684);
			HagalTurnPhase.NativeMethodInfoPtr_PrePlayerTurn_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669685);
			HagalTurnPhase.NativeMethodInfoPtr_DetermineTurn_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669686);
			HagalTurnPhase.NativeMethodInfoPtr_TakeAgentTurn_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669687);
			HagalTurnPhase.NativeMethodInfoPtr_ResolveDeferredAbilities_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669688);
			HagalTurnPhase.NativeMethodInfoPtr_DeployUnits_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669689);
			HagalTurnPhase.NativeMethodInfoPtr_TakeRevealTurn_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669690);
			HagalTurnPhase.NativeMethodInfoPtr_Cleanup_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669691);
			HagalTurnPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669692);
			HagalTurnPhase.NativeMethodInfoPtr__TakeRevealTurn_b__13_1_Private_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669693);
			HagalTurnPhase.NativeMethodInfoPtr__Cleanup_b__14_4_Private_IEnumerable_1_WormAgent_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669694);
			HagalTurnPhase.NativeMethodInfoPtr__Cleanup_b__14_5_Private_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, 100669695);
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x000CB650 File Offset: 0x000C9850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159669, RefRangeEnd = 159670, XrefRangeStart = 159654, XrefRangeEnd = 159669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalTurnPhase(WormPlayer player, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x000CB6B0 File Offset: 0x000C98B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159688, RefRangeEnd = 159689, XrefRangeStart = 159670, XrefRangeEnd = 159688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HagalTurnPhase(SerializedHagalTurnPhase serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedHagalTurnPhase_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x000CB710 File Offset: 0x000C9910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159689, XrefRangeEnd = 159740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<HagalTurnState> DetermineNextTypedState(global::Canis.actions.Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalTurnPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_HagalTurnState_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<HagalTurnState>(intPtr);
			}
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x000CB764 File Offset: 0x000C9964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159740, XrefRangeEnd = 159752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior TypedBehaviorFor(HagalTurnState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalTurnPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_HagalTurnState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x000CB7BC File Offset: 0x000C99BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159752, XrefRangeEnd = 159757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> PrePlayerTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.NativeMethodInfoPtr_PrePlayerTurn_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x000CB7FC File Offset: 0x000C99FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159757, XrefRangeEnd = 159762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> DetermineTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.NativeMethodInfoPtr_DetermineTurn_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x000CB83C File Offset: 0x000C9A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159762, XrefRangeEnd = 159767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> TakeAgentTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.NativeMethodInfoPtr_TakeAgentTurn_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x000CB87C File Offset: 0x000C9A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159767, XrefRangeEnd = 159772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ResolveDeferredAbilities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.NativeMethodInfoPtr_ResolveDeferredAbilities_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x000CB8BC File Offset: 0x000C9ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159772, XrefRangeEnd = 159777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> DeployUnits()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.NativeMethodInfoPtr_DeployUnits_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x000CB8FC File Offset: 0x000C9AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159777, XrefRangeEnd = 159782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> TakeRevealTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.NativeMethodInfoPtr_TakeRevealTurn_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x000CB93C File Offset: 0x000C9B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159782, XrefRangeEnd = 159788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.NativeMethodInfoPtr_Cleanup_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x000CB97C File Offset: 0x000C9B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159788, XrefRangeEnd = 159794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HagalTurnPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x000CB9D8 File Offset: 0x000C9BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159794, XrefRangeEnd = 159796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _TakeRevealTurn_b__13_1(Entity entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.NativeMethodInfoPtr__TakeRevealTurn_b__13_1_Private_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x000CBA28 File Offset: 0x000C9C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159796, XrefRangeEnd = 159810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormAgent> _Cleanup_b__14_4(WormSpace space)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.NativeMethodInfoPtr__Cleanup_b__14_4_Private_IEnumerable_1_WormAgent_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAgent>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x000CBA78 File Offset: 0x000C9C78
		[CallerCount(0)]
		public unsafe bool _Cleanup_b__14_5(WormAgent _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.NativeMethodInfoPtr__Cleanup_b__14_5_Private_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x0000C5C0 File Offset: 0x0000A7C0
		public HagalTurnPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x000CBAC8 File Offset: 0x000C9CC8
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x0000C5C9 File Offset: 0x0000A7C9
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x000CBAF8 File Offset: 0x000C9CF8
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		public unsafe WormPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x000CBB28 File Offset: 0x000C9D28
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x0000C607 File Offset: 0x0000A807
		public unsafe bool foundOpenSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase.NativeFieldInfoPtr_foundOpenSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase.NativeFieldInfoPtr_foundOpenSpace)) = value;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x000CBB50 File Offset: 0x000C9D50
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x0000C622 File Offset: 0x0000A822
		public unsafe List<ArchetypeID> revealedHagalCards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase.NativeFieldInfoPtr_revealedHagalCards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase.NativeFieldInfoPtr_revealedHagalCards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeFieldInfoPtr_foundOpenSpace;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeFieldInfoPtr_revealedHagalCards;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedHagalTurnPhase_WormMatch_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_HagalTurnState_Action_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_HagalTurnState_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_PrePlayerTurn_Private_IEnumerable_1_Action_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_DetermineTurn_Private_IEnumerable_1_Action_0;

		// Token: 0x0400125D RID: 4701
		private static readonly IntPtr NativeMethodInfoPtr_TakeAgentTurn_Private_IEnumerable_1_Action_0;

		// Token: 0x0400125E RID: 4702
		private static readonly IntPtr NativeMethodInfoPtr_ResolveDeferredAbilities_Private_IEnumerable_1_Action_0;

		// Token: 0x0400125F RID: 4703
		private static readonly IntPtr NativeMethodInfoPtr_DeployUnits_Private_IEnumerable_1_Action_0;

		// Token: 0x04001260 RID: 4704
		private static readonly IntPtr NativeMethodInfoPtr_TakeRevealTurn_Private_IEnumerable_1_Action_0;

		// Token: 0x04001261 RID: 4705
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_IEnumerable_1_Action_0;

		// Token: 0x04001262 RID: 4706
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;

		// Token: 0x04001263 RID: 4707
		private static readonly IntPtr NativeMethodInfoPtr__TakeRevealTurn_b__13_1_Private_Boolean_Entity_0;

		// Token: 0x04001264 RID: 4708
		private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__14_4_Private_IEnumerable_1_WormAgent_WormSpace_0;

		// Token: 0x04001265 RID: 4709
		private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__14_5_Private_Boolean_WormAgent_0;

		// Token: 0x0200073D RID: 1853
		[ObfuscatedName("worm.canis.actions.phases.HagalTurnPhase+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06006606 RID: 26118 RVA: 0x001EACF4 File Offset: 0x001E8EF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr);
				HagalTurnPhase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, "<>9");
				HagalTurnPhase.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, "<>9__10_0");
				HagalTurnPhase.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, "<>9__11_0");
				HagalTurnPhase.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, "<>9__12_0");
				HagalTurnPhase.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, "<>9__12_1");
				HagalTurnPhase.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, "<>9__13_0");
				HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, "<>9__14_6");
				HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, "<>9__14_0");
				HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, "<>9__14_1");
				HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, "<>9__14_2");
				HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, "<>9__14_3");
				HagalTurnPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, 100669697);
				HagalTurnPhase.__c.NativeMethodInfoPtr__TakeAgentTurn_b__10_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, 100669698);
				HagalTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__11_0_Internal_Boolean_ActivatedAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, 100669699);
				HagalTurnPhase.__c.NativeMethodInfoPtr__DeployUnits_b__12_0_Internal_Int32_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, 100669700);
				HagalTurnPhase.__c.NativeMethodInfoPtr__DeployUnits_b__12_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, 100669701);
				HagalTurnPhase.__c.NativeMethodInfoPtr__TakeRevealTurn_b__13_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, 100669702);
				HagalTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__14_6_Internal_Boolean_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, 100669703);
				HagalTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__14_0_Internal_IEnumerable_1_WormAbilityDefinition_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, 100669704);
				HagalTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__14_1_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, 100669705);
				HagalTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__14_2_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, 100669706);
				HagalTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__14_3_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr, 100669707);
			}

			// Token: 0x06006607 RID: 26119 RVA: 0x001EAED8 File Offset: 0x001E90D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalTurnPhase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006608 RID: 26120 RVA: 0x001EAF14 File Offset: 0x001E9114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TakeAgentTurn_b__10_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.__c.NativeMethodInfoPtr__TakeAgentTurn_b__10_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006609 RID: 26121 RVA: 0x001EAF64 File Offset: 0x001E9164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158446, XrefRangeEnd = 158453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveDeferredAbilities_b__11_0(ActivatedAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__11_0_Internal_Boolean_ActivatedAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600660A RID: 26122 RVA: 0x001EAFB4 File Offset: 0x001E91B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _DeployUnits_b__12_0(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.__c.NativeMethodInfoPtr__DeployUnits_b__12_0_Internal_Int32_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600660B RID: 26123 RVA: 0x001EB004 File Offset: 0x001E9204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158453, XrefRangeEnd = 158454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DeployUnits_b__12_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.__c.NativeMethodInfoPtr__DeployUnits_b__12_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600660C RID: 26124 RVA: 0x001EB054 File Offset: 0x001E9254
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158454, XrefRangeEnd = 158455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TakeRevealTurn_b__13_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.__c.NativeMethodInfoPtr__TakeRevealTurn_b__13_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600660D RID: 26125 RVA: 0x001EB0A4 File Offset: 0x001E92A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__14_6(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__14_6_Internal_Boolean_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600660E RID: 26126 RVA: 0x001EB0F4 File Offset: 0x001E92F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158455, XrefRangeEnd = 158457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormAbilityDefinition> _Cleanup_b__14_0(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__14_0_Internal_IEnumerable_1_WormAbilityDefinition_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr3) : null;
				}
			}

			// Token: 0x0600660F RID: 26127 RVA: 0x001EB144 File Offset: 0x001E9344
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__14_1(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__14_1_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006610 RID: 26128 RVA: 0x001EB194 File Offset: 0x001E9394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158457, XrefRangeEnd = 158458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__14_2(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__14_2_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006611 RID: 26129 RVA: 0x001EB1E4 File Offset: 0x001E93E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__14_3(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__14_3_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006612 RID: 26130 RVA: 0x00027B02 File Offset: 0x00025D02
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B6C RID: 7020
			// (get) Token: 0x06006613 RID: 26131 RVA: 0x001EB234 File Offset: 0x001E9434
			// (set) Token: 0x06006614 RID: 26132 RVA: 0x00027B0B File Offset: 0x00025D0B
			public unsafe static HagalTurnPhase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalTurnPhase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B6D RID: 7021
			// (get) Token: 0x06006615 RID: 26133 RVA: 0x001EB25C File Offset: 0x001E945C
			// (set) Token: 0x06006616 RID: 26134 RVA: 0x00027B1D File Offset: 0x00025D1D
			public unsafe static Func<WormPlayer, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B6E RID: 7022
			// (get) Token: 0x06006617 RID: 26135 RVA: 0x001EB284 File Offset: 0x001E9484
			// (set) Token: 0x06006618 RID: 26136 RVA: 0x00027B2F File Offset: 0x00025D2F
			public unsafe static Func<ActivatedAbility, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ActivatedAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B6F RID: 7023
			// (get) Token: 0x06006619 RID: 26137 RVA: 0x001EB2AC File Offset: 0x001E94AC
			// (set) Token: 0x0600661A RID: 26138 RVA: 0x00027B41 File Offset: 0x00025D41
			public unsafe static Func<WormUnit, int> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B70 RID: 7024
			// (get) Token: 0x0600661B RID: 26139 RVA: 0x001EB2D4 File Offset: 0x001E94D4
			// (set) Token: 0x0600661C RID: 26140 RVA: 0x00027B53 File Offset: 0x00025D53
			public unsafe static Func<WormPlayer, bool> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B71 RID: 7025
			// (get) Token: 0x0600661D RID: 26141 RVA: 0x001EB2FC File Offset: 0x001E94FC
			// (set) Token: 0x0600661E RID: 26142 RVA: 0x00027B65 File Offset: 0x00025D65
			public unsafe static Func<Entity, bool> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B72 RID: 7026
			// (get) Token: 0x0600661F RID: 26143 RVA: 0x001EB324 File Offset: 0x001E9524
			// (set) Token: 0x06006620 RID: 26144 RVA: 0x00027B77 File Offset: 0x00025D77
			public unsafe static Func<WormUnit, bool> __9__14_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B73 RID: 7027
			// (get) Token: 0x06006621 RID: 26145 RVA: 0x001EB34C File Offset: 0x001E954C
			// (set) Token: 0x06006622 RID: 26146 RVA: 0x00027B89 File Offset: 0x00025D89
			public unsafe static Func<WormSpace, IEnumerable<WormAbilityDefinition>> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, IEnumerable<WormAbilityDefinition>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B74 RID: 7028
			// (get) Token: 0x06006623 RID: 26147 RVA: 0x001EB374 File Offset: 0x001E9574
			// (set) Token: 0x06006624 RID: 26148 RVA: 0x00027B9B File Offset: 0x00025D9B
			public unsafe static Func<WormAbilityDefinition, bool> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B75 RID: 7029
			// (get) Token: 0x06006625 RID: 26149 RVA: 0x001EB39C File Offset: 0x001E959C
			// (set) Token: 0x06006626 RID: 26150 RVA: 0x00027BAD File Offset: 0x00025DAD
			public unsafe static Func<WormSpace, bool> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B76 RID: 7030
			// (get) Token: 0x06006627 RID: 26151 RVA: 0x001EB3C4 File Offset: 0x001E95C4
			// (set) Token: 0x06006628 RID: 26152 RVA: 0x00027BBF File Offset: 0x00025DBF
			public unsafe static Func<WormSpace, bool> __9__14_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HagalTurnPhase.__c.NativeFieldInfoPtr___9__14_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004201 RID: 16897
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004202 RID: 16898
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04004203 RID: 16899
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04004204 RID: 16900
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04004205 RID: 16901
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04004206 RID: 16902
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04004207 RID: 16903
			private static readonly IntPtr NativeFieldInfoPtr___9__14_6;

			// Token: 0x04004208 RID: 16904
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04004209 RID: 16905
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x0400420A RID: 16906
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x0400420B RID: 16907
			private static readonly IntPtr NativeFieldInfoPtr___9__14_3;

			// Token: 0x0400420C RID: 16908
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400420D RID: 16909
			private static readonly IntPtr NativeMethodInfoPtr__TakeAgentTurn_b__10_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400420E RID: 16910
			private static readonly IntPtr NativeMethodInfoPtr__ResolveDeferredAbilities_b__11_0_Internal_Boolean_ActivatedAbility_0;

			// Token: 0x0400420F RID: 16911
			private static readonly IntPtr NativeMethodInfoPtr__DeployUnits_b__12_0_Internal_Int32_WormUnit_0;

			// Token: 0x04004210 RID: 16912
			private static readonly IntPtr NativeMethodInfoPtr__DeployUnits_b__12_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004211 RID: 16913
			private static readonly IntPtr NativeMethodInfoPtr__TakeRevealTurn_b__13_0_Internal_Boolean_Entity_0;

			// Token: 0x04004212 RID: 16914
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__14_6_Internal_Boolean_WormUnit_0;

			// Token: 0x04004213 RID: 16915
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__14_0_Internal_IEnumerable_1_WormAbilityDefinition_WormSpace_0;

			// Token: 0x04004214 RID: 16916
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__14_1_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04004215 RID: 16917
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__14_2_Internal_Boolean_WormSpace_0;

			// Token: 0x04004216 RID: 16918
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__14_3_Internal_Boolean_WormSpace_0;
		}

		// Token: 0x0200073E RID: 1854
		[ObfuscatedName("worm.canis.actions.phases.HagalTurnPhase+<Cleanup>d__14")]
		public sealed class _Cleanup_d__14 : Object
		{
			// Token: 0x06006629 RID: 26153 RVA: 0x001EB3EC File Offset: 0x001E95EC
			// Note: this type is marked as 'beforefieldinit'.
			static _Cleanup_d__14()
			{
				Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, "<Cleanup>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr);
				HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, "<>1__state");
				HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, "<>2__current");
				HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, "<>l__initialThreadId");
				HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, "<>4__this");
				HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, "<>7__wrap1");
				HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, "<>7__wrap2");
				HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, 100669708);
				HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, 100669709);
				HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, 100669710);
				HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, 100669711);
				HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, 100669712);
				HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, 100669713);
				HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, 100669714);
				HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, 100669715);
				HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, 100669716);
				HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr, 100669717);
			}

			// Token: 0x0600662A RID: 26154 RVA: 0x001EB558 File Offset: 0x001E9758
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Cleanup_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalTurnPhase._Cleanup_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600662B RID: 26155 RVA: 0x001EB5A0 File Offset: 0x001E97A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158458, XrefRangeEnd = 158468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600662C RID: 26156 RVA: 0x001EB5D4 File Offset: 0x001E97D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158468, XrefRangeEnd = 158918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600662D RID: 26157 RVA: 0x001EB610 File Offset: 0x001E9810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158918, XrefRangeEnd = 158921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600662E RID: 26158 RVA: 0x001EB644 File Offset: 0x001E9844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158921, XrefRangeEnd = 158924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B7D RID: 7037
			// (get) Token: 0x0600662F RID: 26159 RVA: 0x001EB678 File Offset: 0x001E9878
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006630 RID: 26160 RVA: 0x001EB6B8 File Offset: 0x001E98B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158924, XrefRangeEnd = 158929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B7E RID: 7038
			// (get) Token: 0x06006631 RID: 26161 RVA: 0x001EB6EC File Offset: 0x001E98EC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006632 RID: 26162 RVA: 0x001EB72C File Offset: 0x001E992C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158929, XrefRangeEnd = 158931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006633 RID: 26163 RVA: 0x001EB76C File Offset: 0x001E996C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._Cleanup_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006634 RID: 26164 RVA: 0x00027BD1 File Offset: 0x00025DD1
			public _Cleanup_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B77 RID: 7031
			// (get) Token: 0x06006635 RID: 26165 RVA: 0x001EB7AC File Offset: 0x001E99AC
			// (set) Token: 0x06006636 RID: 26166 RVA: 0x00027BDA File Offset: 0x00025DDA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B78 RID: 7032
			// (get) Token: 0x06006637 RID: 26167 RVA: 0x001EB7D4 File Offset: 0x001E99D4
			// (set) Token: 0x06006638 RID: 26168 RVA: 0x00027BF5 File Offset: 0x00025DF5
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B79 RID: 7033
			// (get) Token: 0x06006639 RID: 26169 RVA: 0x001EB804 File Offset: 0x001E9A04
			// (set) Token: 0x0600663A RID: 26170 RVA: 0x00027C14 File Offset: 0x00025E14
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B7A RID: 7034
			// (get) Token: 0x0600663B RID: 26171 RVA: 0x001EB82C File Offset: 0x001E9A2C
			// (set) Token: 0x0600663C RID: 26172 RVA: 0x00027C2F File Offset: 0x00025E2F
			public unsafe HagalTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B7B RID: 7035
			// (get) Token: 0x0600663D RID: 26173 RVA: 0x001EB85C File Offset: 0x001E9A5C
			// (set) Token: 0x0600663E RID: 26174 RVA: 0x00027C4E File Offset: 0x00025E4E
			public unsafe IEnumerator<WormAgent> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormAgent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B7C RID: 7036
			// (get) Token: 0x0600663F RID: 26175 RVA: 0x001EB88C File Offset: 0x001E9A8C
			// (set) Token: 0x06006640 RID: 26176 RVA: 0x00027C6D File Offset: 0x00025E6D
			public unsafe IEnumerator<WormUnit> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormUnit>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._Cleanup_d__14.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004217 RID: 16919
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004218 RID: 16920
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004219 RID: 16921
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400421A RID: 16922
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400421B RID: 16923
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400421C RID: 16924
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400421D RID: 16925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400421E RID: 16926
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400421F RID: 16927
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004220 RID: 16928
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004221 RID: 16929
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04004222 RID: 16930
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004223 RID: 16931
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004224 RID: 16932
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004225 RID: 16933
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004226 RID: 16934
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200073F RID: 1855
		[ObfuscatedName("worm.canis.actions.phases.HagalTurnPhase+<DeployUnits>d__12")]
		public sealed class _DeployUnits_d__12 : Object
		{
			// Token: 0x06006641 RID: 26177 RVA: 0x001EB8BC File Offset: 0x001E9ABC
			// Note: this type is marked as 'beforefieldinit'.
			static _DeployUnits_d__12()
			{
				Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, "<DeployUnits>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr);
				HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, "<>1__state");
				HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, "<>2__current");
				HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, "<>l__initialThreadId");
				HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, "<>4__this");
				HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr__unitsToDeploy_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, "<unitsToDeploy>5__2");
				HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, "<>7__wrap2");
				HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, 100669718);
				HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, 100669719);
				HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, 100669720);
				HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, 100669721);
				HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, 100669722);
				HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, 100669723);
				HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, 100669724);
				HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, 100669725);
				HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr, 100669726);
			}

			// Token: 0x06006642 RID: 26178 RVA: 0x001EBA14 File Offset: 0x001E9C14
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DeployUnits_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalTurnPhase._DeployUnits_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006643 RID: 26179 RVA: 0x001EBA5C File Offset: 0x001E9C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158931, XrefRangeEnd = 158936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006644 RID: 26180 RVA: 0x001EBA90 File Offset: 0x001E9C90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158936, XrefRangeEnd = 159089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006645 RID: 26181 RVA: 0x001EBACC File Offset: 0x001E9CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159089, XrefRangeEnd = 159092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B85 RID: 7045
			// (get) Token: 0x06006646 RID: 26182 RVA: 0x001EBB00 File Offset: 0x001E9D00
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006647 RID: 26183 RVA: 0x001EBB40 File Offset: 0x001E9D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159092, XrefRangeEnd = 159097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B86 RID: 7046
			// (get) Token: 0x06006648 RID: 26184 RVA: 0x001EBB74 File Offset: 0x001E9D74
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006649 RID: 26185 RVA: 0x001EBBB4 File Offset: 0x001E9DB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159097, XrefRangeEnd = 159099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600664A RID: 26186 RVA: 0x001EBBF4 File Offset: 0x001E9DF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DeployUnits_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600664B RID: 26187 RVA: 0x00027C8C File Offset: 0x00025E8C
			public _DeployUnits_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B7F RID: 7039
			// (get) Token: 0x0600664C RID: 26188 RVA: 0x001EBC34 File Offset: 0x001E9E34
			// (set) Token: 0x0600664D RID: 26189 RVA: 0x00027C95 File Offset: 0x00025E95
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B80 RID: 7040
			// (get) Token: 0x0600664E RID: 26190 RVA: 0x001EBC5C File Offset: 0x001E9E5C
			// (set) Token: 0x0600664F RID: 26191 RVA: 0x00027CB0 File Offset: 0x00025EB0
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B81 RID: 7041
			// (get) Token: 0x06006650 RID: 26192 RVA: 0x001EBC8C File Offset: 0x001E9E8C
			// (set) Token: 0x06006651 RID: 26193 RVA: 0x00027CCF File Offset: 0x00025ECF
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B82 RID: 7042
			// (get) Token: 0x06006652 RID: 26194 RVA: 0x001EBCB4 File Offset: 0x001E9EB4
			// (set) Token: 0x06006653 RID: 26195 RVA: 0x00027CEA File Offset: 0x00025EEA
			public unsafe HagalTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B83 RID: 7043
			// (get) Token: 0x06006654 RID: 26196 RVA: 0x001EBCE4 File Offset: 0x001E9EE4
			// (set) Token: 0x06006655 RID: 26197 RVA: 0x00027D09 File Offset: 0x00025F09
			public unsafe List<WormUnit> _unitsToDeploy_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr__unitsToDeploy_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormUnit>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr__unitsToDeploy_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B84 RID: 7044
			// (get) Token: 0x06006656 RID: 26198 RVA: 0x001EBD14 File Offset: 0x001E9F14
			// (set) Token: 0x06006657 RID: 26199 RVA: 0x00027D28 File Offset: 0x00025F28
			public unsafe IEnumerator<WormPlayer> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DeployUnits_d__12.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004227 RID: 16935
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004228 RID: 16936
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004229 RID: 16937
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400422A RID: 16938
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400422B RID: 16939
			private static readonly IntPtr NativeFieldInfoPtr__unitsToDeploy_5__2;

			// Token: 0x0400422C RID: 16940
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400422D RID: 16941
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400422E RID: 16942
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400422F RID: 16943
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004230 RID: 16944
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004231 RID: 16945
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004232 RID: 16946
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004233 RID: 16947
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004234 RID: 16948
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004235 RID: 16949
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000740 RID: 1856
		[ObfuscatedName("worm.canis.actions.phases.HagalTurnPhase+<DetermineTurn>d__9")]
		public sealed class _DetermineTurn_d__9 : Object
		{
			// Token: 0x06006658 RID: 26200 RVA: 0x001EBD44 File Offset: 0x001E9F44
			// Note: this type is marked as 'beforefieldinit'.
			static _DetermineTurn_d__9()
			{
				Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, "<DetermineTurn>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr);
				HagalTurnPhase._DetermineTurn_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr, "<>1__state");
				HagalTurnPhase._DetermineTurn_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr, "<>2__current");
				HagalTurnPhase._DetermineTurn_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr, "<>l__initialThreadId");
				HagalTurnPhase._DetermineTurn_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr, "<>4__this");
				HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr, 100669727);
				HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr, 100669728);
				HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr, 100669729);
				HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr, 100669730);
				HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr, 100669731);
				HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr, 100669732);
				HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr, 100669733);
				HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr, 100669734);
			}

			// Token: 0x06006659 RID: 26201 RVA: 0x001EBE60 File Offset: 0x001EA060
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DetermineTurn_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalTurnPhase._DetermineTurn_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600665A RID: 26202 RVA: 0x001EBEA8 File Offset: 0x001EA0A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600665B RID: 26203 RVA: 0x001EBEDC File Offset: 0x001EA0DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159099, XrefRangeEnd = 159111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B8B RID: 7051
			// (get) Token: 0x0600665C RID: 26204 RVA: 0x001EBF18 File Offset: 0x001EA118
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600665D RID: 26205 RVA: 0x001EBF58 File Offset: 0x001EA158
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159111, XrefRangeEnd = 159116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B8C RID: 7052
			// (get) Token: 0x0600665E RID: 26206 RVA: 0x001EBF8C File Offset: 0x001EA18C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600665F RID: 26207 RVA: 0x001EBFCC File Offset: 0x001EA1CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159116, XrefRangeEnd = 159118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006660 RID: 26208 RVA: 0x001EC00C File Offset: 0x001EA20C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._DetermineTurn_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006661 RID: 26209 RVA: 0x00027D47 File Offset: 0x00025F47
			public _DetermineTurn_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B87 RID: 7047
			// (get) Token: 0x06006662 RID: 26210 RVA: 0x001EC04C File Offset: 0x001EA24C
			// (set) Token: 0x06006663 RID: 26211 RVA: 0x00027D50 File Offset: 0x00025F50
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DetermineTurn_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DetermineTurn_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B88 RID: 7048
			// (get) Token: 0x06006664 RID: 26212 RVA: 0x001EC074 File Offset: 0x001EA274
			// (set) Token: 0x06006665 RID: 26213 RVA: 0x00027D6B File Offset: 0x00025F6B
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DetermineTurn_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DetermineTurn_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B89 RID: 7049
			// (get) Token: 0x06006666 RID: 26214 RVA: 0x001EC0A4 File Offset: 0x001EA2A4
			// (set) Token: 0x06006667 RID: 26215 RVA: 0x00027D8A File Offset: 0x00025F8A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DetermineTurn_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DetermineTurn_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B8A RID: 7050
			// (get) Token: 0x06006668 RID: 26216 RVA: 0x001EC0CC File Offset: 0x001EA2CC
			// (set) Token: 0x06006669 RID: 26217 RVA: 0x00027DA5 File Offset: 0x00025FA5
			public unsafe HagalTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DetermineTurn_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._DetermineTurn_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004236 RID: 16950
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004237 RID: 16951
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004238 RID: 16952
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004239 RID: 16953
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400423A RID: 16954
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400423B RID: 16955
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400423C RID: 16956
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400423D RID: 16957
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400423E RID: 16958
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400423F RID: 16959
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004240 RID: 16960
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004241 RID: 16961
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000741 RID: 1857
		[ObfuscatedName("worm.canis.actions.phases.HagalTurnPhase+<PrePlayerTurn>d__8")]
		public sealed class _PrePlayerTurn_d__8 : Object
		{
			// Token: 0x0600666A RID: 26218 RVA: 0x001EC0FC File Offset: 0x001EA2FC
			// Note: this type is marked as 'beforefieldinit'.
			static _PrePlayerTurn_d__8()
			{
				Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, "<PrePlayerTurn>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr);
				HagalTurnPhase._PrePlayerTurn_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr, "<>1__state");
				HagalTurnPhase._PrePlayerTurn_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr, "<>2__current");
				HagalTurnPhase._PrePlayerTurn_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr, "<>l__initialThreadId");
				HagalTurnPhase._PrePlayerTurn_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr, "<>4__this");
				HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr, 100669735);
				HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr, 100669736);
				HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr, 100669737);
				HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr, 100669738);
				HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr, 100669739);
				HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr, 100669740);
				HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr, 100669741);
				HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr, 100669742);
			}

			// Token: 0x0600666B RID: 26219 RVA: 0x001EC218 File Offset: 0x001EA418
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PrePlayerTurn_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalTurnPhase._PrePlayerTurn_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600666C RID: 26220 RVA: 0x001EC260 File Offset: 0x001EA460
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600666D RID: 26221 RVA: 0x001EC294 File Offset: 0x001EA494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159118, XrefRangeEnd = 159170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B91 RID: 7057
			// (get) Token: 0x0600666E RID: 26222 RVA: 0x001EC2D0 File Offset: 0x001EA4D0
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600666F RID: 26223 RVA: 0x001EC310 File Offset: 0x001EA510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159170, XrefRangeEnd = 159175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B92 RID: 7058
			// (get) Token: 0x06006670 RID: 26224 RVA: 0x001EC344 File Offset: 0x001EA544
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006671 RID: 26225 RVA: 0x001EC384 File Offset: 0x001EA584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159175, XrefRangeEnd = 159177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006672 RID: 26226 RVA: 0x001EC3C4 File Offset: 0x001EA5C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._PrePlayerTurn_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006673 RID: 26227 RVA: 0x00027DC4 File Offset: 0x00025FC4
			public _PrePlayerTurn_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B8D RID: 7053
			// (get) Token: 0x06006674 RID: 26228 RVA: 0x001EC404 File Offset: 0x001EA604
			// (set) Token: 0x06006675 RID: 26229 RVA: 0x00027DCD File Offset: 0x00025FCD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._PrePlayerTurn_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._PrePlayerTurn_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B8E RID: 7054
			// (get) Token: 0x06006676 RID: 26230 RVA: 0x001EC42C File Offset: 0x001EA62C
			// (set) Token: 0x06006677 RID: 26231 RVA: 0x00027DE8 File Offset: 0x00025FE8
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._PrePlayerTurn_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._PrePlayerTurn_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B8F RID: 7055
			// (get) Token: 0x06006678 RID: 26232 RVA: 0x001EC45C File Offset: 0x001EA65C
			// (set) Token: 0x06006679 RID: 26233 RVA: 0x00027E07 File Offset: 0x00026007
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._PrePlayerTurn_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._PrePlayerTurn_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B90 RID: 7056
			// (get) Token: 0x0600667A RID: 26234 RVA: 0x001EC484 File Offset: 0x001EA684
			// (set) Token: 0x0600667B RID: 26235 RVA: 0x00027E22 File Offset: 0x00026022
			public unsafe HagalTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._PrePlayerTurn_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._PrePlayerTurn_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004242 RID: 16962
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004243 RID: 16963
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004244 RID: 16964
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004245 RID: 16965
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004246 RID: 16966
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004247 RID: 16967
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004248 RID: 16968
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004249 RID: 16969
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400424A RID: 16970
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400424B RID: 16971
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400424C RID: 16972
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400424D RID: 16973
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000742 RID: 1858
		[ObfuscatedName("worm.canis.actions.phases.HagalTurnPhase+<ResolveDeferredAbilities>d__11")]
		public sealed class _ResolveDeferredAbilities_d__11 : Object
		{
			// Token: 0x0600667C RID: 26236 RVA: 0x001EC4B4 File Offset: 0x001EA6B4
			// Note: this type is marked as 'beforefieldinit'.
			static _ResolveDeferredAbilities_d__11()
			{
				Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, "<ResolveDeferredAbilities>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr);
				HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr, "<>1__state");
				HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr, "<>2__current");
				HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr, "<>l__initialThreadId");
				HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr, "<>4__this");
				HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr, 100669743);
				HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr, 100669744);
				HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr, 100669745);
				HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr, 100669746);
				HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr, 100669747);
				HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr, 100669748);
				HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr, 100669749);
				HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr, 100669750);
			}

			// Token: 0x0600667D RID: 26237 RVA: 0x001EC5D0 File Offset: 0x001EA7D0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResolveDeferredAbilities_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalTurnPhase._ResolveDeferredAbilities_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600667E RID: 26238 RVA: 0x001EC618 File Offset: 0x001EA818
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600667F RID: 26239 RVA: 0x001EC64C File Offset: 0x001EA84C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159177, XrefRangeEnd = 159238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001B97 RID: 7063
			// (get) Token: 0x06006680 RID: 26240 RVA: 0x001EC688 File Offset: 0x001EA888
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006681 RID: 26241 RVA: 0x001EC6C8 File Offset: 0x001EA8C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159238, XrefRangeEnd = 159243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001B98 RID: 7064
			// (get) Token: 0x06006682 RID: 26242 RVA: 0x001EC6FC File Offset: 0x001EA8FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006683 RID: 26243 RVA: 0x001EC73C File Offset: 0x001EA93C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159243, XrefRangeEnd = 159245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006684 RID: 26244 RVA: 0x001EC77C File Offset: 0x001EA97C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006685 RID: 26245 RVA: 0x00027E41 File Offset: 0x00026041
			public _ResolveDeferredAbilities_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B93 RID: 7059
			// (get) Token: 0x06006686 RID: 26246 RVA: 0x001EC7BC File Offset: 0x001EA9BC
			// (set) Token: 0x06006687 RID: 26247 RVA: 0x00027E4A File Offset: 0x0002604A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B94 RID: 7060
			// (get) Token: 0x06006688 RID: 26248 RVA: 0x001EC7E4 File Offset: 0x001EA9E4
			// (set) Token: 0x06006689 RID: 26249 RVA: 0x00027E65 File Offset: 0x00026065
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B95 RID: 7061
			// (get) Token: 0x0600668A RID: 26250 RVA: 0x001EC814 File Offset: 0x001EAA14
			// (set) Token: 0x0600668B RID: 26251 RVA: 0x00027E84 File Offset: 0x00026084
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B96 RID: 7062
			// (get) Token: 0x0600668C RID: 26252 RVA: 0x001EC83C File Offset: 0x001EAA3C
			// (set) Token: 0x0600668D RID: 26253 RVA: 0x00027E9F File Offset: 0x0002609F
			public unsafe HagalTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._ResolveDeferredAbilities_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400424E RID: 16974
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400424F RID: 16975
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004250 RID: 16976
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004251 RID: 16977
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004252 RID: 16978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004253 RID: 16979
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004254 RID: 16980
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004255 RID: 16981
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004256 RID: 16982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004257 RID: 16983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004258 RID: 16984
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004259 RID: 16985
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000743 RID: 1859
		[ObfuscatedName("worm.canis.actions.phases.HagalTurnPhase+<TakeAgentTurn>d__10")]
		public sealed class _TakeAgentTurn_d__10 : Object
		{
			// Token: 0x0600668E RID: 26254 RVA: 0x001EC86C File Offset: 0x001EAA6C
			// Note: this type is marked as 'beforefieldinit'.
			static _TakeAgentTurn_d__10()
			{
				Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, "<TakeAgentTurn>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr);
				HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, "<>1__state");
				HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, "<>2__current");
				HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, "<>l__initialThreadId");
				HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, "<>4__this");
				HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr__cardsChecked_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, "<cardsChecked>5__2");
				HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr__hagalCard_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, "<hagalCard>5__3");
				HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr__hagalAbility_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, "<hagalAbility>5__4");
				HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr__sequenceHelper_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, "<sequenceHelper>5__5");
				HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, 100669751);
				HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, 100669752);
				HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, 100669753);
				HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, 100669754);
				HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, 100669755);
				HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, 100669756);
				HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, 100669757);
				HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr, 100669758);
			}

			// Token: 0x0600668F RID: 26255 RVA: 0x001EC9D8 File Offset: 0x001EABD8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TakeAgentTurn_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalTurnPhase._TakeAgentTurn_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006690 RID: 26256 RVA: 0x001ECA20 File Offset: 0x001EAC20
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006691 RID: 26257 RVA: 0x001ECA54 File Offset: 0x001EAC54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159245, XrefRangeEnd = 159438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001BA1 RID: 7073
			// (get) Token: 0x06006692 RID: 26258 RVA: 0x001ECA90 File Offset: 0x001EAC90
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006693 RID: 26259 RVA: 0x001ECAD0 File Offset: 0x001EACD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159438, XrefRangeEnd = 159443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BA2 RID: 7074
			// (get) Token: 0x06006694 RID: 26260 RVA: 0x001ECB04 File Offset: 0x001EAD04
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006695 RID: 26261 RVA: 0x001ECB44 File Offset: 0x001EAD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159443, XrefRangeEnd = 159445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006696 RID: 26262 RVA: 0x001ECB84 File Offset: 0x001EAD84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeAgentTurn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006697 RID: 26263 RVA: 0x00027EBE File Offset: 0x000260BE
			public _TakeAgentTurn_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001B99 RID: 7065
			// (get) Token: 0x06006698 RID: 26264 RVA: 0x001ECBC4 File Offset: 0x001EADC4
			// (set) Token: 0x06006699 RID: 26265 RVA: 0x00027EC7 File Offset: 0x000260C7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001B9A RID: 7066
			// (get) Token: 0x0600669A RID: 26266 RVA: 0x001ECBEC File Offset: 0x001EADEC
			// (set) Token: 0x0600669B RID: 26267 RVA: 0x00027EE2 File Offset: 0x000260E2
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B9B RID: 7067
			// (get) Token: 0x0600669C RID: 26268 RVA: 0x001ECC1C File Offset: 0x001EAE1C
			// (set) Token: 0x0600669D RID: 26269 RVA: 0x00027F01 File Offset: 0x00026101
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001B9C RID: 7068
			// (get) Token: 0x0600669E RID: 26270 RVA: 0x001ECC44 File Offset: 0x001EAE44
			// (set) Token: 0x0600669F RID: 26271 RVA: 0x00027F1C File Offset: 0x0002611C
			public unsafe HagalTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B9D RID: 7069
			// (get) Token: 0x060066A0 RID: 26272 RVA: 0x001ECC74 File Offset: 0x001EAE74
			// (set) Token: 0x060066A1 RID: 26273 RVA: 0x00027F3B File Offset: 0x0002613B
			public unsafe int _cardsChecked_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr__cardsChecked_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr__cardsChecked_5__2)) = value;
				}
			}

			// Token: 0x17001B9E RID: 7070
			// (get) Token: 0x060066A2 RID: 26274 RVA: 0x001ECC9C File Offset: 0x001EAE9C
			// (set) Token: 0x060066A3 RID: 26275 RVA: 0x00027F56 File Offset: 0x00026156
			public unsafe WormHagalPlayable _hagalCard_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr__hagalCard_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormHagalPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr__hagalCard_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001B9F RID: 7071
			// (get) Token: 0x060066A4 RID: 26276 RVA: 0x001ECCCC File Offset: 0x001EAECC
			// (set) Token: 0x060066A5 RID: 26277 RVA: 0x00027F75 File Offset: 0x00026175
			public unsafe HagalAbility _hagalAbility_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr__hagalAbility_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr__hagalAbility_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BA0 RID: 7072
			// (get) Token: 0x060066A6 RID: 26278 RVA: 0x001ECCFC File Offset: 0x001EAEFC
			// (set) Token: 0x060066A7 RID: 26279 RVA: 0x00027F94 File Offset: 0x00026194
			public unsafe SequenceHelper _sequenceHelper_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr__sequenceHelper_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeAgentTurn_d__10.NativeFieldInfoPtr__sequenceHelper_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400425A RID: 16986
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400425B RID: 16987
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400425C RID: 16988
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400425D RID: 16989
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400425E RID: 16990
			private static readonly IntPtr NativeFieldInfoPtr__cardsChecked_5__2;

			// Token: 0x0400425F RID: 16991
			private static readonly IntPtr NativeFieldInfoPtr__hagalCard_5__3;

			// Token: 0x04004260 RID: 16992
			private static readonly IntPtr NativeFieldInfoPtr__hagalAbility_5__4;

			// Token: 0x04004261 RID: 16993
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__5;

			// Token: 0x04004262 RID: 16994
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004263 RID: 16995
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004264 RID: 16996
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004265 RID: 16997
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004266 RID: 16998
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004267 RID: 16999
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004268 RID: 17000
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004269 RID: 17001
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000744 RID: 1860
		[ObfuscatedName("worm.canis.actions.phases.HagalTurnPhase+<TakeRevealTurn>d__13")]
		public sealed class _TakeRevealTurn_d__13 : Object
		{
			// Token: 0x060066A8 RID: 26280 RVA: 0x001ECD2C File Offset: 0x001EAF2C
			// Note: this type is marked as 'beforefieldinit'.
			static _TakeRevealTurn_d__13()
			{
				Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HagalTurnPhase>.NativeClassPtr, "<TakeRevealTurn>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr);
				HagalTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, "<>1__state");
				HagalTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, "<>2__current");
				HagalTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, "<>l__initialThreadId");
				HagalTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, "<>4__this");
				HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669759);
				HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669760);
				HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669761);
				HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669762);
				HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669763);
				HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669764);
				HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669765);
				HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669766);
			}

			// Token: 0x060066A9 RID: 26281 RVA: 0x001ECE48 File Offset: 0x001EB048
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TakeRevealTurn_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HagalTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060066AA RID: 26282 RVA: 0x001ECE90 File Offset: 0x001EB090
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060066AB RID: 26283 RVA: 0x001ECEC4 File Offset: 0x001EB0C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159445, XrefRangeEnd = 159647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001BA7 RID: 7079
			// (get) Token: 0x060066AC RID: 26284 RVA: 0x001ECF00 File Offset: 0x001EB100
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060066AD RID: 26285 RVA: 0x001ECF40 File Offset: 0x001EB140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159647, XrefRangeEnd = 159652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BA8 RID: 7080
			// (get) Token: 0x060066AE RID: 26286 RVA: 0x001ECF74 File Offset: 0x001EB174
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060066AF RID: 26287 RVA: 0x001ECFB4 File Offset: 0x001EB1B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159652, XrefRangeEnd = 159654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060066B0 RID: 26288 RVA: 0x001ECFF4 File Offset: 0x001EB1F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HagalTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060066B1 RID: 26289 RVA: 0x00027FB3 File Offset: 0x000261B3
			public _TakeRevealTurn_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BA3 RID: 7075
			// (get) Token: 0x060066B2 RID: 26290 RVA: 0x001ED034 File Offset: 0x001EB234
			// (set) Token: 0x060066B3 RID: 26291 RVA: 0x00027FBC File Offset: 0x000261BC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BA4 RID: 7076
			// (get) Token: 0x060066B4 RID: 26292 RVA: 0x001ED05C File Offset: 0x001EB25C
			// (set) Token: 0x060066B5 RID: 26293 RVA: 0x00027FD7 File Offset: 0x000261D7
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BA5 RID: 7077
			// (get) Token: 0x060066B6 RID: 26294 RVA: 0x001ED08C File Offset: 0x001EB28C
			// (set) Token: 0x060066B7 RID: 26295 RVA: 0x00027FF6 File Offset: 0x000261F6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001BA6 RID: 7078
			// (get) Token: 0x060066B8 RID: 26296 RVA: 0x001ED0B4 File Offset: 0x001EB2B4
			// (set) Token: 0x060066B9 RID: 26297 RVA: 0x00028011 File Offset: 0x00026211
			public unsafe HagalTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HagalTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HagalTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400426A RID: 17002
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400426B RID: 17003
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400426C RID: 17004
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400426D RID: 17005
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400426E RID: 17006
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400426F RID: 17007
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004270 RID: 17008
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004271 RID: 17009
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004272 RID: 17010
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004273 RID: 17011
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004274 RID: 17012
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004275 RID: 17013
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
