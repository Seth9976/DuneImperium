using System;
using Canis;
using Canis.actions;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.attributes.resource;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002D6 RID: 726
	public class RoundPhase : StateMachineAction<RoundState>
	{
		// Token: 0x06001DDD RID: 7645 RVA: 0x000CD5AC File Offset: 0x000CB7AC
		// Note: this type is marked as 'beforefieldinit'.
		static RoundPhase()
		{
			Il2CppClassPointerStore<RoundPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "RoundPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr);
			RoundPhase.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, "wormMatch");
			RoundPhase.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670014);
			RoundPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedRoundPhase_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670015);
			RoundPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_RoundState_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670016);
			RoundPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_RoundState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670017);
			RoundPhase.NativeMethodInfoPtr_RoundStart_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670018);
			RoundPhase.NativeMethodInfoPtr_GenerateConflict_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670019);
			RoundPhase.NativeMethodInfoPtr_DrawCards_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670020);
			RoundPhase.NativeMethodInfoPtr_PlayerTurns_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670021);
			RoundPhase.NativeMethodInfoPtr_Combat_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670022);
			RoundPhase.NativeMethodInfoPtr_Makers_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670023);
			RoundPhase.NativeMethodInfoPtr_Recall_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670024);
			RoundPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670025);
			RoundPhase.NativeMethodInfoPtr__DetermineNextTypedState_b__3_1_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670026);
			RoundPhase.NativeMethodInfoPtr__DetermineNextTypedState_b__3_2_Private_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, 100670027);
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x000CD708 File Offset: 0x000CB908
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166487, RefRangeEnd = 166488, XrefRangeStart = 166480, XrefRangeEnd = 166487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundPhase(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x000CD754 File Offset: 0x000CB954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166488, XrefRangeEnd = 166495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundPhase(SerializedRoundPhase serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedRoundPhase_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x000CD7B4 File Offset: 0x000CB9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166495, XrefRangeEnd = 166603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<RoundState> DetermineNextTypedState(global::Canis.actions.Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_RoundState_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<RoundState>(intPtr);
			}
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x000CD808 File Offset: 0x000CBA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166603, XrefRangeEnd = 166615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior TypedBehaviorFor(RoundState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_RoundState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x000CD860 File Offset: 0x000CBA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166615, XrefRangeEnd = 166621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> RoundStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.NativeMethodInfoPtr_RoundStart_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x000CD8A0 File Offset: 0x000CBAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166621, XrefRangeEnd = 166627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> GenerateConflict()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.NativeMethodInfoPtr_GenerateConflict_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x000CD8E0 File Offset: 0x000CBAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166627, XrefRangeEnd = 166633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> DrawCards()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.NativeMethodInfoPtr_DrawCards_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x000CD920 File Offset: 0x000CBB20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166633, XrefRangeEnd = 166639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> PlayerTurns()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.NativeMethodInfoPtr_PlayerTurns_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x000CD960 File Offset: 0x000CBB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166639, XrefRangeEnd = 166645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> Combat()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.NativeMethodInfoPtr_Combat_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DE7 RID: 7655 RVA: 0x000CD9A0 File Offset: 0x000CBBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166645, XrefRangeEnd = 166651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> Makers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.NativeMethodInfoPtr_Makers_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x000CD9E0 File Offset: 0x000CBBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166651, XrefRangeEnd = 166657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> Recall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.NativeMethodInfoPtr_Recall_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x000CDA20 File Offset: 0x000CBC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166657, XrefRangeEnd = 166661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RoundPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x000CDA7C File Offset: 0x000CBC7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166661, XrefRangeEnd = 166666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _DetermineNextTypedState_b__3_1(WormPlayer _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.NativeMethodInfoPtr__DetermineNextTypedState_b__3_1_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DEB RID: 7659 RVA: 0x000CDACC File Offset: 0x000CBCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166666, XrefRangeEnd = 166671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _DetermineNextTypedState_b__3_2(WormPlayer _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.NativeMethodInfoPtr__DetermineNextTypedState_b__3_2_Private_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x0000C8DF File Offset: 0x0000AADF
		public RoundPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x000CDB1C File Offset: 0x000CBD1C
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedRoundPhase_WormMatch_0;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_RoundState_Action_0;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_RoundState_0;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeMethodInfoPtr_RoundStart_Private_IEnumerable_1_Action_0;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr_GenerateConflict_Private_IEnumerable_1_Action_0;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeMethodInfoPtr_DrawCards_Private_IEnumerable_1_Action_0;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr_PlayerTurns_Private_IEnumerable_1_Action_0;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_Combat_Private_IEnumerable_1_Action_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_Makers_Private_IEnumerable_1_Action_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_Recall_Private_IEnumerable_1_Action_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr__DetermineNextTypedState_b__3_1_Private_Boolean_WormPlayer_0;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeMethodInfoPtr__DetermineNextTypedState_b__3_2_Private_Boolean_WormPlayer_0;

		// Token: 0x0200075B RID: 1883
		[ObfuscatedName("worm.canis.actions.phases.RoundPhase+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060068C3 RID: 26819 RVA: 0x001F3710 File Offset: 0x001F1910
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr);
				RoundPhase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, "<>9");
				RoundPhase.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, "<>9__3_0");
				RoundPhase.__c.NativeFieldInfoPtr___9__3_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, "<>9__3_3");
				RoundPhase.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, "<>9__5_0");
				RoundPhase.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, "<>9__10_0");
				RoundPhase.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, "<>9__11_0");
				RoundPhase.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, "<>9__11_1");
				RoundPhase.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, "<>9__11_2");
				RoundPhase.__c.NativeFieldInfoPtr___9__11_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, "<>9__11_3");
				RoundPhase.__c.NativeFieldInfoPtr___9__11_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, "<>9__11_9");
				RoundPhase.__c.NativeFieldInfoPtr___9__11_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, "<>9__11_10");
				RoundPhase.__c.NativeFieldInfoPtr___9__11_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, "<>9__11_7");
				RoundPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, 100670029);
				RoundPhase.__c.NativeMethodInfoPtr__DetermineNextTypedState_b__3_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, 100670030);
				RoundPhase.__c.NativeMethodInfoPtr__DetermineNextTypedState_b__3_3_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, 100670031);
				RoundPhase.__c.NativeMethodInfoPtr__RoundStart_b__5_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, 100670032);
				RoundPhase.__c.NativeMethodInfoPtr__Makers_b__10_0_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, 100670033);
				RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, 100670034);
				RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, 100670035);
				RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_2_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, 100670036);
				RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_3_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, 100670037);
				RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_9_Internal_Boolean_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, 100670038);
				RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_10_Internal_Boolean_WormTechTilePlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, 100670039);
				RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_7_Internal_Boolean_ResourceMod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr, 100670040);
			}

			// Token: 0x060068C4 RID: 26820 RVA: 0x001F391C File Offset: 0x001F1B1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060068C5 RID: 26821 RVA: 0x001F3958 File Offset: 0x001F1B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164359, XrefRangeEnd = 164361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineNextTypedState_b__3_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c.NativeMethodInfoPtr__DetermineNextTypedState_b__3_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068C6 RID: 26822 RVA: 0x001F39A8 File Offset: 0x001F1BA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineNextTypedState_b__3_3(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c.NativeMethodInfoPtr__DetermineNextTypedState_b__3_3_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068C7 RID: 26823 RVA: 0x001F39F8 File Offset: 0x001F1BF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RoundStart_b__5_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c.NativeMethodInfoPtr__RoundStart_b__5_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068C8 RID: 26824 RVA: 0x001F3A48 File Offset: 0x001F1C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164361, XrefRangeEnd = 164362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Makers_b__10_0(WormSpace space)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c.NativeMethodInfoPtr__Makers_b__10_0_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068C9 RID: 26825 RVA: 0x001F3A98 File Offset: 0x001F1C98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164362, XrefRangeEnd = 164364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Recall_b__11_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068CA RID: 26826 RVA: 0x001F3AE8 File Offset: 0x001F1CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164364, XrefRangeEnd = 164372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Recall_b__11_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068CB RID: 26827 RVA: 0x001F3B38 File Offset: 0x001F1D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164372, XrefRangeEnd = 164380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Recall_b__11_2(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_2_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068CC RID: 26828 RVA: 0x001F3B88 File Offset: 0x001F1D88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164380, XrefRangeEnd = 164384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Recall_b__11_3(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_3_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068CD RID: 26829 RVA: 0x001F3BD8 File Offset: 0x001F1DD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164384, XrefRangeEnd = 164386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Recall_b__11_9(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_9_Internal_Boolean_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068CE RID: 26830 RVA: 0x001F3C28 File Offset: 0x001F1E28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164386, XrefRangeEnd = 164394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Recall_b__11_10(WormTechTilePlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_10_Internal_Boolean_WormTechTilePlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068CF RID: 26831 RVA: 0x001F3C78 File Offset: 0x001F1E78
			[CallerCount(0)]
			public unsafe bool _Recall_b__11_7(ResourceMod rm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rm);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c.NativeMethodInfoPtr__Recall_b__11_7_Internal_Boolean_ResourceMod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068D0 RID: 26832 RVA: 0x0002904D File Offset: 0x0002724D
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C57 RID: 7255
			// (get) Token: 0x060068D1 RID: 26833 RVA: 0x001F3CC8 File Offset: 0x001F1EC8
			// (set) Token: 0x060068D2 RID: 26834 RVA: 0x00029056 File Offset: 0x00027256
			public unsafe static RoundPhase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RoundPhase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundPhase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RoundPhase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C58 RID: 7256
			// (get) Token: 0x060068D3 RID: 26835 RVA: 0x001F3CF0 File Offset: 0x001F1EF0
			// (set) Token: 0x060068D4 RID: 26836 RVA: 0x00029068 File Offset: 0x00027268
			public unsafe static Func<WormPlayer, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RoundPhase.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RoundPhase.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C59 RID: 7257
			// (get) Token: 0x060068D5 RID: 26837 RVA: 0x001F3D18 File Offset: 0x001F1F18
			// (set) Token: 0x060068D6 RID: 26838 RVA: 0x0002907A File Offset: 0x0002727A
			public unsafe static Func<WormPlayer, bool> __9__3_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RoundPhase.__c.NativeFieldInfoPtr___9__3_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RoundPhase.__c.NativeFieldInfoPtr___9__3_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C5A RID: 7258
			// (get) Token: 0x060068D7 RID: 26839 RVA: 0x001F3D40 File Offset: 0x001F1F40
			// (set) Token: 0x060068D8 RID: 26840 RVA: 0x0002908C File Offset: 0x0002728C
			public unsafe static Func<WormPlayer, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RoundPhase.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RoundPhase.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C5B RID: 7259
			// (get) Token: 0x060068D9 RID: 26841 RVA: 0x001F3D68 File Offset: 0x001F1F68
			// (set) Token: 0x060068DA RID: 26842 RVA: 0x0002909E File Offset: 0x0002729E
			public unsafe static Func<WormSpace, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RoundPhase.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RoundPhase.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C5C RID: 7260
			// (get) Token: 0x060068DB RID: 26843 RVA: 0x001F3D90 File Offset: 0x001F1F90
			// (set) Token: 0x060068DC RID: 26844 RVA: 0x000290B0 File Offset: 0x000272B0
			public unsafe static Func<Entity, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C5D RID: 7261
			// (get) Token: 0x060068DD RID: 26845 RVA: 0x001F3DB8 File Offset: 0x001F1FB8
			// (set) Token: 0x060068DE RID: 26846 RVA: 0x000290C2 File Offset: 0x000272C2
			public unsafe static Func<Entity, bool> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C5E RID: 7262
			// (get) Token: 0x060068DF RID: 26847 RVA: 0x001F3DE0 File Offset: 0x001F1FE0
			// (set) Token: 0x060068E0 RID: 26848 RVA: 0x000290D4 File Offset: 0x000272D4
			public unsafe static Func<Entity, bool> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C5F RID: 7263
			// (get) Token: 0x060068E1 RID: 26849 RVA: 0x001F3E08 File Offset: 0x001F2008
			// (set) Token: 0x060068E2 RID: 26850 RVA: 0x000290E6 File Offset: 0x000272E6
			public unsafe static Func<Entity, bool> __9__11_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C60 RID: 7264
			// (get) Token: 0x060068E3 RID: 26851 RVA: 0x001F3E30 File Offset: 0x001F2030
			// (set) Token: 0x060068E4 RID: 26852 RVA: 0x000290F8 File Offset: 0x000272F8
			public unsafe static Func<WormTechTilePlayable, bool> __9__11_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C61 RID: 7265
			// (get) Token: 0x060068E5 RID: 26853 RVA: 0x001F3E58 File Offset: 0x001F2058
			// (set) Token: 0x060068E6 RID: 26854 RVA: 0x0002910A File Offset: 0x0002730A
			public unsafe static Func<WormTechTilePlayable, bool> __9__11_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormTechTilePlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C62 RID: 7266
			// (get) Token: 0x060068E7 RID: 26855 RVA: 0x001F3E80 File Offset: 0x001F2080
			// (set) Token: 0x060068E8 RID: 26856 RVA: 0x0002911C File Offset: 0x0002731C
			public unsafe static Func<ResourceMod, bool> __9__11_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ResourceMod, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RoundPhase.__c.NativeFieldInfoPtr___9__11_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043C5 RID: 17349
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040043C6 RID: 17350
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040043C7 RID: 17351
			private static readonly IntPtr NativeFieldInfoPtr___9__3_3;

			// Token: 0x040043C8 RID: 17352
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040043C9 RID: 17353
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x040043CA RID: 17354
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x040043CB RID: 17355
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x040043CC RID: 17356
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x040043CD RID: 17357
			private static readonly IntPtr NativeFieldInfoPtr___9__11_3;

			// Token: 0x040043CE RID: 17358
			private static readonly IntPtr NativeFieldInfoPtr___9__11_9;

			// Token: 0x040043CF RID: 17359
			private static readonly IntPtr NativeFieldInfoPtr___9__11_10;

			// Token: 0x040043D0 RID: 17360
			private static readonly IntPtr NativeFieldInfoPtr___9__11_7;

			// Token: 0x040043D1 RID: 17361
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040043D2 RID: 17362
			private static readonly IntPtr NativeMethodInfoPtr__DetermineNextTypedState_b__3_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040043D3 RID: 17363
			private static readonly IntPtr NativeMethodInfoPtr__DetermineNextTypedState_b__3_3_Internal_Boolean_WormPlayer_0;

			// Token: 0x040043D4 RID: 17364
			private static readonly IntPtr NativeMethodInfoPtr__RoundStart_b__5_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x040043D5 RID: 17365
			private static readonly IntPtr NativeMethodInfoPtr__Makers_b__10_0_Internal_Boolean_WormSpace_0;

			// Token: 0x040043D6 RID: 17366
			private static readonly IntPtr NativeMethodInfoPtr__Recall_b__11_0_Internal_Boolean_Entity_0;

			// Token: 0x040043D7 RID: 17367
			private static readonly IntPtr NativeMethodInfoPtr__Recall_b__11_1_Internal_Boolean_Entity_0;

			// Token: 0x040043D8 RID: 17368
			private static readonly IntPtr NativeMethodInfoPtr__Recall_b__11_2_Internal_Boolean_Entity_0;

			// Token: 0x040043D9 RID: 17369
			private static readonly IntPtr NativeMethodInfoPtr__Recall_b__11_3_Internal_Boolean_Entity_0;

			// Token: 0x040043DA RID: 17370
			private static readonly IntPtr NativeMethodInfoPtr__Recall_b__11_9_Internal_Boolean_WormTechTilePlayable_0;

			// Token: 0x040043DB RID: 17371
			private static readonly IntPtr NativeMethodInfoPtr__Recall_b__11_10_Internal_Boolean_WormTechTilePlayable_0;

			// Token: 0x040043DC RID: 17372
			private static readonly IntPtr NativeMethodInfoPtr__Recall_b__11_7_Internal_Boolean_ResourceMod_0;
		}

		// Token: 0x0200075C RID: 1884
		[ObfuscatedName("worm.canis.actions.phases.RoundPhase+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x060068E9 RID: 26857 RVA: 0x001F3EA8 File Offset: 0x001F20A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_0>.NativeClassPtr);
				RoundPhase.__c__DisplayClass11_0.NativeFieldInfoPtr_playmat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_0>.NativeClassPtr, "playmat");
				RoundPhase.__c__DisplayClass11_0.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_0>.NativeClassPtr, "<>9__5");
				RoundPhase.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_0>.NativeClassPtr, 100670041);
				RoundPhase.__c__DisplayClass11_0.NativeMethodInfoPtr__Recall_b__5_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_0>.NativeClassPtr, 100670042);
			}

			// Token: 0x060068EA RID: 26858 RVA: 0x001F3F24 File Offset: 0x001F2124
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060068EB RID: 26859 RVA: 0x001F3F60 File Offset: 0x001F2160
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164394, XrefRangeEnd = 164411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Recall_b__5(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c__DisplayClass11_0.NativeMethodInfoPtr__Recall_b__5_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068EC RID: 26860 RVA: 0x0002912E File Offset: 0x0002732E
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C63 RID: 7267
			// (get) Token: 0x060068ED RID: 26861 RVA: 0x001F3FB0 File Offset: 0x001F21B0
			// (set) Token: 0x060068EE RID: 26862 RVA: 0x00029137 File Offset: 0x00027337
			public unsafe WormPlaymat playmat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_0.NativeFieldInfoPtr_playmat);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_0.NativeFieldInfoPtr_playmat), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C64 RID: 7268
			// (get) Token: 0x060068EF RID: 26863 RVA: 0x001F3FE0 File Offset: 0x001F21E0
			// (set) Token: 0x060068F0 RID: 26864 RVA: 0x00029156 File Offset: 0x00027356
			public unsafe Func<WormSpace, bool> __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_0.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_0.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043DD RID: 17373
			private static readonly IntPtr NativeFieldInfoPtr_playmat;

			// Token: 0x040043DE RID: 17374
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x040043DF RID: 17375
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040043E0 RID: 17376
			private static readonly IntPtr NativeMethodInfoPtr__Recall_b__5_Internal_Boolean_WormSpace_0;
		}

		// Token: 0x0200075D RID: 1885
		[ObfuscatedName("worm.canis.actions.phases.RoundPhase+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Object
		{
			// Token: 0x060068F1 RID: 26865 RVA: 0x001F4010 File Offset: 0x001F2210
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_1>.NativeClassPtr);
				RoundPhase.__c__DisplayClass11_1.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_1>.NativeClassPtr, "player");
				RoundPhase.__c__DisplayClass11_1.NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_1>.NativeClassPtr, "CS$<>8__locals1");
				RoundPhase.__c__DisplayClass11_1.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_1>.NativeClassPtr, "<>9__8");
				RoundPhase.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_1>.NativeClassPtr, 100670043);
				RoundPhase.__c__DisplayClass11_1.NativeMethodInfoPtr__Recall_b__6_Internal_IEnumerable_1_WormUnit_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_1>.NativeClassPtr, 100670044);
				RoundPhase.__c__DisplayClass11_1.NativeMethodInfoPtr__Recall_b__8_Internal_Boolean_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_1>.NativeClassPtr, 100670045);
			}

			// Token: 0x060068F2 RID: 26866 RVA: 0x001F40B4 File Offset: 0x001F22B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060068F3 RID: 26867 RVA: 0x001F40F0 File Offset: 0x001F22F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164411, XrefRangeEnd = 164425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormUnit> _Recall_b__6(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c__DisplayClass11_1.NativeMethodInfoPtr__Recall_b__6_Internal_IEnumerable_1_WormUnit_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormUnit>>(intPtr3) : null;
				}
			}

			// Token: 0x060068F4 RID: 26868 RVA: 0x001F4140 File Offset: 0x001F2340
			[CallerCount(0)]
			public unsafe bool _Recall_b__8(WormUnit unit)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c__DisplayClass11_1.NativeMethodInfoPtr__Recall_b__8_Internal_Boolean_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068F5 RID: 26869 RVA: 0x00029175 File Offset: 0x00027375
			public __c__DisplayClass11_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C65 RID: 7269
			// (get) Token: 0x060068F6 RID: 26870 RVA: 0x001F4190 File Offset: 0x001F2390
			// (set) Token: 0x060068F7 RID: 26871 RVA: 0x0002917E File Offset: 0x0002737E
			public unsafe WormPlayer player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_1.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_1.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C66 RID: 7270
			// (get) Token: 0x060068F8 RID: 26872 RVA: 0x001F41C0 File Offset: 0x001F23C0
			// (set) Token: 0x060068F9 RID: 26873 RVA: 0x0002919D File Offset: 0x0002739D
			public unsafe RoundPhase.__c__DisplayClass11_0 field_Public___c__DisplayClass11_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_1.NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundPhase.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_1.NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C67 RID: 7271
			// (get) Token: 0x060068FA RID: 26874 RVA: 0x001F41F0 File Offset: 0x001F23F0
			// (set) Token: 0x060068FB RID: 26875 RVA: 0x000291BC File Offset: 0x000273BC
			public unsafe Func<WormUnit, bool> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_1.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_1.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043E1 RID: 17377
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x040043E2 RID: 17378
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0;

			// Token: 0x040043E3 RID: 17379
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x040043E4 RID: 17380
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040043E5 RID: 17381
			private static readonly IntPtr NativeMethodInfoPtr__Recall_b__6_Internal_IEnumerable_1_WormUnit_WormSpace_0;

			// Token: 0x040043E6 RID: 17382
			private static readonly IntPtr NativeMethodInfoPtr__Recall_b__8_Internal_Boolean_WormUnit_0;
		}

		// Token: 0x0200075E RID: 1886
		[ObfuscatedName("worm.canis.actions.phases.RoundPhase+<>c__DisplayClass11_2")]
		public sealed class __c__DisplayClass11_2 : Object
		{
			// Token: 0x060068FC RID: 26876 RVA: 0x001F4220 File Offset: 0x001F2420
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_2()
			{
				Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, "<>c__DisplayClass11_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_2>.NativeClassPtr);
				RoundPhase.__c__DisplayClass11_2.NativeFieldInfoPtr_agentSupply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_2>.NativeClassPtr, "agentSupply");
				RoundPhase.__c__DisplayClass11_2.NativeFieldInfoPtr_isSwordmaster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_2>.NativeClassPtr, "isSwordmaster");
				RoundPhase.__c__DisplayClass11_2.NativeFieldInfoPtr_field_Public___c__DisplayClass11_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_2>.NativeClassPtr, "CS$<>8__locals2");
				RoundPhase.__c__DisplayClass11_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_2>.NativeClassPtr, 100670046);
				RoundPhase.__c__DisplayClass11_2.NativeMethodInfoPtr__Recall_b__4_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_2>.NativeClassPtr, 100670047);
			}

			// Token: 0x060068FD RID: 26877 RVA: 0x001F42B0 File Offset: 0x001F24B0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase.__c__DisplayClass11_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c__DisplayClass11_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060068FE RID: 26878 RVA: 0x001F42EC File Offset: 0x001F24EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164425, XrefRangeEnd = 164436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Recall_b__4(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase.__c__DisplayClass11_2.NativeMethodInfoPtr__Recall_b__4_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060068FF RID: 26879 RVA: 0x000291DB File Offset: 0x000273DB
			public __c__DisplayClass11_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C68 RID: 7272
			// (get) Token: 0x06006900 RID: 26880 RVA: 0x001F433C File Offset: 0x001F253C
			// (set) Token: 0x06006901 RID: 26881 RVA: 0x000291E4 File Offset: 0x000273E4
			public unsafe WormPlayArea agentSupply
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_2.NativeFieldInfoPtr_agentSupply);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayArea>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_2.NativeFieldInfoPtr_agentSupply), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C69 RID: 7273
			// (get) Token: 0x06006902 RID: 26882 RVA: 0x001F436C File Offset: 0x001F256C
			// (set) Token: 0x06006903 RID: 26883 RVA: 0x00029203 File Offset: 0x00027403
			public unsafe bool isSwordmaster
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_2.NativeFieldInfoPtr_isSwordmaster);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_2.NativeFieldInfoPtr_isSwordmaster)) = value;
				}
			}

			// Token: 0x17001C6A RID: 7274
			// (get) Token: 0x06006904 RID: 26884 RVA: 0x001F4394 File Offset: 0x001F2594
			// (set) Token: 0x06006905 RID: 26885 RVA: 0x0002921E File Offset: 0x0002741E
			public unsafe RoundPhase.__c__DisplayClass11_1 field_Public___c__DisplayClass11_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_2.NativeFieldInfoPtr_field_Public___c__DisplayClass11_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundPhase.__c__DisplayClass11_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase.__c__DisplayClass11_2.NativeFieldInfoPtr_field_Public___c__DisplayClass11_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043E7 RID: 17383
			private static readonly IntPtr NativeFieldInfoPtr_agentSupply;

			// Token: 0x040043E8 RID: 17384
			private static readonly IntPtr NativeFieldInfoPtr_isSwordmaster;

			// Token: 0x040043E9 RID: 17385
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass11_1_0;

			// Token: 0x040043EA RID: 17386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040043EB RID: 17387
			private static readonly IntPtr NativeMethodInfoPtr__Recall_b__4_Internal_Boolean_Entity_0;
		}

		// Token: 0x0200075F RID: 1887
		[ObfuscatedName("worm.canis.actions.phases.RoundPhase+<Combat>d__9")]
		public sealed class _Combat_d__9 : Object
		{
			// Token: 0x06006906 RID: 26886 RVA: 0x001F43C4 File Offset: 0x001F25C4
			// Note: this type is marked as 'beforefieldinit'.
			static _Combat_d__9()
			{
				Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, "<Combat>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr);
				RoundPhase._Combat_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr, "<>1__state");
				RoundPhase._Combat_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr, "<>2__current");
				RoundPhase._Combat_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr, "<>l__initialThreadId");
				RoundPhase._Combat_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr, "<>4__this");
				RoundPhase._Combat_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr, 100670048);
				RoundPhase._Combat_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr, 100670049);
				RoundPhase._Combat_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr, 100670050);
				RoundPhase._Combat_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr, 100670051);
				RoundPhase._Combat_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr, 100670052);
				RoundPhase._Combat_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr, 100670053);
				RoundPhase._Combat_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr, 100670054);
				RoundPhase._Combat_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr, 100670055);
			}

			// Token: 0x06006907 RID: 26887 RVA: 0x001F44E0 File Offset: 0x001F26E0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Combat_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase._Combat_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Combat_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006908 RID: 26888 RVA: 0x001F4528 File Offset: 0x001F2728
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Combat_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006909 RID: 26889 RVA: 0x001F455C File Offset: 0x001F275C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164436, XrefRangeEnd = 164443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Combat_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C6F RID: 7279
			// (get) Token: 0x0600690A RID: 26890 RVA: 0x001F4598 File Offset: 0x001F2798
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Combat_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600690B RID: 26891 RVA: 0x001F45D8 File Offset: 0x001F27D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164443, XrefRangeEnd = 164448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Combat_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C70 RID: 7280
			// (get) Token: 0x0600690C RID: 26892 RVA: 0x001F460C File Offset: 0x001F280C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Combat_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600690D RID: 26893 RVA: 0x001F464C File Offset: 0x001F284C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164448, XrefRangeEnd = 164450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Combat_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600690E RID: 26894 RVA: 0x001F468C File Offset: 0x001F288C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Combat_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600690F RID: 26895 RVA: 0x0002923D File Offset: 0x0002743D
			public _Combat_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C6B RID: 7275
			// (get) Token: 0x06006910 RID: 26896 RVA: 0x001F46CC File Offset: 0x001F28CC
			// (set) Token: 0x06006911 RID: 26897 RVA: 0x00029246 File Offset: 0x00027446
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Combat_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Combat_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C6C RID: 7276
			// (get) Token: 0x06006912 RID: 26898 RVA: 0x001F46F4 File Offset: 0x001F28F4
			// (set) Token: 0x06006913 RID: 26899 RVA: 0x00029261 File Offset: 0x00027461
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Combat_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Combat_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C6D RID: 7277
			// (get) Token: 0x06006914 RID: 26900 RVA: 0x001F4724 File Offset: 0x001F2924
			// (set) Token: 0x06006915 RID: 26901 RVA: 0x00029280 File Offset: 0x00027480
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Combat_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Combat_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C6E RID: 7278
			// (get) Token: 0x06006916 RID: 26902 RVA: 0x001F474C File Offset: 0x001F294C
			// (set) Token: 0x06006917 RID: 26903 RVA: 0x0002929B File Offset: 0x0002749B
			public unsafe RoundPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Combat_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Combat_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040043EC RID: 17388
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040043ED RID: 17389
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040043EE RID: 17390
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040043EF RID: 17391
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040043F0 RID: 17392
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040043F1 RID: 17393
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040043F2 RID: 17394
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040043F3 RID: 17395
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040043F4 RID: 17396
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040043F5 RID: 17397
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040043F6 RID: 17398
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040043F7 RID: 17399
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000760 RID: 1888
		[ObfuscatedName("worm.canis.actions.phases.RoundPhase+<DrawCards>d__7")]
		public sealed class _DrawCards_d__7 : Object
		{
			// Token: 0x06006918 RID: 26904 RVA: 0x001F477C File Offset: 0x001F297C
			// Note: this type is marked as 'beforefieldinit'.
			static _DrawCards_d__7()
			{
				Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, "<DrawCards>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr);
				RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, "<>1__state");
				RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, "<>2__current");
				RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, "<>l__initialThreadId");
				RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, "<>4__this");
				RoundPhase._DrawCards_d__7.NativeFieldInfoPtr__roundNumber_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, "<roundNumber>5__2");
				RoundPhase._DrawCards_d__7.NativeFieldInfoPtr__isTutorial1_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, "<isTutorial1>5__3");
				RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, "<>7__wrap3");
				RoundPhase._DrawCards_d__7.NativeFieldInfoPtr__player_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, "<player>5__5");
				RoundPhase._DrawCards_d__7.NativeFieldInfoPtr__deckCount_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, "<deckCount>5__6");
				RoundPhase._DrawCards_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, 100670056);
				RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, 100670057);
				RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, 100670058);
				RoundPhase._DrawCards_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, 100670059);
				RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, 100670060);
				RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, 100670061);
				RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, 100670062);
				RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, 100670063);
				RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr, 100670064);
			}

			// Token: 0x06006919 RID: 26905 RVA: 0x001F4910 File Offset: 0x001F2B10
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DrawCards_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase._DrawCards_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._DrawCards_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600691A RID: 26906 RVA: 0x001F4958 File Offset: 0x001F2B58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164450, XrefRangeEnd = 164455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600691B RID: 26907 RVA: 0x001F498C File Offset: 0x001F2B8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164455, XrefRangeEnd = 164623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600691C RID: 26908 RVA: 0x001F49C8 File Offset: 0x001F2BC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164623, XrefRangeEnd = 164626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._DrawCards_d__7.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C7A RID: 7290
			// (get) Token: 0x0600691D RID: 26909 RVA: 0x001F49FC File Offset: 0x001F2BFC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600691E RID: 26910 RVA: 0x001F4A3C File Offset: 0x001F2C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164626, XrefRangeEnd = 164631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C7B RID: 7291
			// (get) Token: 0x0600691F RID: 26911 RVA: 0x001F4A70 File Offset: 0x001F2C70
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006920 RID: 26912 RVA: 0x001F4AB0 File Offset: 0x001F2CB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164631, XrefRangeEnd = 164633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006921 RID: 26913 RVA: 0x001F4AF0 File Offset: 0x001F2CF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._DrawCards_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006922 RID: 26914 RVA: 0x000292BA File Offset: 0x000274BA
			public _DrawCards_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C71 RID: 7281
			// (get) Token: 0x06006923 RID: 26915 RVA: 0x001F4B30 File Offset: 0x001F2D30
			// (set) Token: 0x06006924 RID: 26916 RVA: 0x000292C3 File Offset: 0x000274C3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C72 RID: 7282
			// (get) Token: 0x06006925 RID: 26917 RVA: 0x001F4B58 File Offset: 0x001F2D58
			// (set) Token: 0x06006926 RID: 26918 RVA: 0x000292DE File Offset: 0x000274DE
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C73 RID: 7283
			// (get) Token: 0x06006927 RID: 26919 RVA: 0x001F4B88 File Offset: 0x001F2D88
			// (set) Token: 0x06006928 RID: 26920 RVA: 0x000292FD File Offset: 0x000274FD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C74 RID: 7284
			// (get) Token: 0x06006929 RID: 26921 RVA: 0x001F4BB0 File Offset: 0x001F2DB0
			// (set) Token: 0x0600692A RID: 26922 RVA: 0x00029318 File Offset: 0x00027518
			public unsafe RoundPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C75 RID: 7285
			// (get) Token: 0x0600692B RID: 26923 RVA: 0x001F4BE0 File Offset: 0x001F2DE0
			// (set) Token: 0x0600692C RID: 26924 RVA: 0x00029337 File Offset: 0x00027537
			public unsafe int _roundNumber_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr__roundNumber_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr__roundNumber_5__2)) = value;
				}
			}

			// Token: 0x17001C76 RID: 7286
			// (get) Token: 0x0600692D RID: 26925 RVA: 0x001F4C08 File Offset: 0x001F2E08
			// (set) Token: 0x0600692E RID: 26926 RVA: 0x00029352 File Offset: 0x00027552
			public unsafe bool _isTutorial1_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr__isTutorial1_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr__isTutorial1_5__3)) = value;
				}
			}

			// Token: 0x17001C77 RID: 7287
			// (get) Token: 0x0600692F RID: 26927 RVA: 0x001F4C30 File Offset: 0x001F2E30
			// (set) Token: 0x06006930 RID: 26928 RVA: 0x0002936D File Offset: 0x0002756D
			public unsafe IEnumerator<WormPlayer> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C78 RID: 7288
			// (get) Token: 0x06006931 RID: 26929 RVA: 0x001F4C60 File Offset: 0x001F2E60
			// (set) Token: 0x06006932 RID: 26930 RVA: 0x0002938C File Offset: 0x0002758C
			public unsafe WormPlayer _player_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr__player_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr__player_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C79 RID: 7289
			// (get) Token: 0x06006933 RID: 26931 RVA: 0x001F4C90 File Offset: 0x001F2E90
			// (set) Token: 0x06006934 RID: 26932 RVA: 0x000293AB File Offset: 0x000275AB
			public unsafe int _deckCount_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr__deckCount_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._DrawCards_d__7.NativeFieldInfoPtr__deckCount_5__6)) = value;
				}
			}

			// Token: 0x040043F8 RID: 17400
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040043F9 RID: 17401
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040043FA RID: 17402
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040043FB RID: 17403
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040043FC RID: 17404
			private static readonly IntPtr NativeFieldInfoPtr__roundNumber_5__2;

			// Token: 0x040043FD RID: 17405
			private static readonly IntPtr NativeFieldInfoPtr__isTutorial1_5__3;

			// Token: 0x040043FE RID: 17406
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040043FF RID: 17407
			private static readonly IntPtr NativeFieldInfoPtr__player_5__5;

			// Token: 0x04004400 RID: 17408
			private static readonly IntPtr NativeFieldInfoPtr__deckCount_5__6;

			// Token: 0x04004401 RID: 17409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004402 RID: 17410
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004403 RID: 17411
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004404 RID: 17412
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004405 RID: 17413
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004406 RID: 17414
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004407 RID: 17415
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004408 RID: 17416
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004409 RID: 17417
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000761 RID: 1889
		[ObfuscatedName("worm.canis.actions.phases.RoundPhase+<GenerateConflict>d__6")]
		public sealed class _GenerateConflict_d__6 : Object
		{
			// Token: 0x06006935 RID: 26933 RVA: 0x001F4CB8 File Offset: 0x001F2EB8
			// Note: this type is marked as 'beforefieldinit'.
			static _GenerateConflict_d__6()
			{
				Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, "<GenerateConflict>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr);
				RoundPhase._GenerateConflict_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr, "<>1__state");
				RoundPhase._GenerateConflict_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr, "<>2__current");
				RoundPhase._GenerateConflict_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr, "<>l__initialThreadId");
				RoundPhase._GenerateConflict_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr, "<>4__this");
				RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr, 100670065);
				RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr, 100670066);
				RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr, 100670067);
				RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr, 100670068);
				RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr, 100670069);
				RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr, 100670070);
				RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr, 100670071);
				RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr, 100670072);
			}

			// Token: 0x06006936 RID: 26934 RVA: 0x001F4DD4 File Offset: 0x001F2FD4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GenerateConflict_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase._GenerateConflict_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006937 RID: 26935 RVA: 0x001F4E1C File Offset: 0x001F301C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006938 RID: 26936 RVA: 0x001F4E50 File Offset: 0x001F3050
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164633, XrefRangeEnd = 164642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C80 RID: 7296
			// (get) Token: 0x06006939 RID: 26937 RVA: 0x001F4E8C File Offset: 0x001F308C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600693A RID: 26938 RVA: 0x001F4ECC File Offset: 0x001F30CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164642, XrefRangeEnd = 164647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C81 RID: 7297
			// (get) Token: 0x0600693B RID: 26939 RVA: 0x001F4F00 File Offset: 0x001F3100
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600693C RID: 26940 RVA: 0x001F4F40 File Offset: 0x001F3140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164647, XrefRangeEnd = 164649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600693D RID: 26941 RVA: 0x001F4F80 File Offset: 0x001F3180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._GenerateConflict_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600693E RID: 26942 RVA: 0x000293C6 File Offset: 0x000275C6
			public _GenerateConflict_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C7C RID: 7292
			// (get) Token: 0x0600693F RID: 26943 RVA: 0x001F4FC0 File Offset: 0x001F31C0
			// (set) Token: 0x06006940 RID: 26944 RVA: 0x000293CF File Offset: 0x000275CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._GenerateConflict_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._GenerateConflict_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C7D RID: 7293
			// (get) Token: 0x06006941 RID: 26945 RVA: 0x001F4FE8 File Offset: 0x001F31E8
			// (set) Token: 0x06006942 RID: 26946 RVA: 0x000293EA File Offset: 0x000275EA
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._GenerateConflict_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._GenerateConflict_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C7E RID: 7294
			// (get) Token: 0x06006943 RID: 26947 RVA: 0x001F5018 File Offset: 0x001F3218
			// (set) Token: 0x06006944 RID: 26948 RVA: 0x00029409 File Offset: 0x00027609
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._GenerateConflict_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._GenerateConflict_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C7F RID: 7295
			// (get) Token: 0x06006945 RID: 26949 RVA: 0x001F5040 File Offset: 0x001F3240
			// (set) Token: 0x06006946 RID: 26950 RVA: 0x00029424 File Offset: 0x00027624
			public unsafe RoundPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._GenerateConflict_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._GenerateConflict_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400440A RID: 17418
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400440B RID: 17419
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400440C RID: 17420
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400440D RID: 17421
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400440E RID: 17422
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400440F RID: 17423
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004410 RID: 17424
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004411 RID: 17425
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004412 RID: 17426
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004413 RID: 17427
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004414 RID: 17428
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004415 RID: 17429
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000762 RID: 1890
		[ObfuscatedName("worm.canis.actions.phases.RoundPhase+<Makers>d__10")]
		public sealed class _Makers_d__10 : Object
		{
			// Token: 0x06006947 RID: 26951 RVA: 0x001F5070 File Offset: 0x001F3270
			// Note: this type is marked as 'beforefieldinit'.
			static _Makers_d__10()
			{
				Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, "<Makers>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr);
				RoundPhase._Makers_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, "<>1__state");
				RoundPhase._Makers_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, "<>2__current");
				RoundPhase._Makers_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, "<>l__initialThreadId");
				RoundPhase._Makers_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, "<>4__this");
				RoundPhase._Makers_d__10.NativeFieldInfoPtr__board_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, "<board>5__2");
				RoundPhase._Makers_d__10.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, "<>7__wrap2");
				RoundPhase._Makers_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, 100670073);
				RoundPhase._Makers_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, 100670074);
				RoundPhase._Makers_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, 100670075);
				RoundPhase._Makers_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, 100670076);
				RoundPhase._Makers_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, 100670077);
				RoundPhase._Makers_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, 100670078);
				RoundPhase._Makers_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, 100670079);
				RoundPhase._Makers_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, 100670080);
				RoundPhase._Makers_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr, 100670081);
			}

			// Token: 0x06006948 RID: 26952 RVA: 0x001F51C8 File Offset: 0x001F33C8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Makers_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase._Makers_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Makers_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006949 RID: 26953 RVA: 0x001F5210 File Offset: 0x001F3410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164649, XrefRangeEnd = 164654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Makers_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600694A RID: 26954 RVA: 0x001F5244 File Offset: 0x001F3444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164654, XrefRangeEnd = 164780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Makers_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600694B RID: 26955 RVA: 0x001F5280 File Offset: 0x001F3480
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164780, XrefRangeEnd = 164783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Makers_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C88 RID: 7304
			// (get) Token: 0x0600694C RID: 26956 RVA: 0x001F52B4 File Offset: 0x001F34B4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Makers_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600694D RID: 26957 RVA: 0x001F52F4 File Offset: 0x001F34F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164783, XrefRangeEnd = 164788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Makers_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C89 RID: 7305
			// (get) Token: 0x0600694E RID: 26958 RVA: 0x001F5328 File Offset: 0x001F3528
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Makers_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600694F RID: 26959 RVA: 0x001F5368 File Offset: 0x001F3568
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164788, XrefRangeEnd = 164790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Makers_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006950 RID: 26960 RVA: 0x001F53A8 File Offset: 0x001F35A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Makers_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006951 RID: 26961 RVA: 0x00029443 File Offset: 0x00027643
			public _Makers_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C82 RID: 7298
			// (get) Token: 0x06006952 RID: 26962 RVA: 0x001F53E8 File Offset: 0x001F35E8
			// (set) Token: 0x06006953 RID: 26963 RVA: 0x0002944C File Offset: 0x0002764C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Makers_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Makers_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C83 RID: 7299
			// (get) Token: 0x06006954 RID: 26964 RVA: 0x001F5410 File Offset: 0x001F3610
			// (set) Token: 0x06006955 RID: 26965 RVA: 0x00029467 File Offset: 0x00027667
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Makers_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Makers_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C84 RID: 7300
			// (get) Token: 0x06006956 RID: 26966 RVA: 0x001F5440 File Offset: 0x001F3640
			// (set) Token: 0x06006957 RID: 26967 RVA: 0x00029486 File Offset: 0x00027686
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Makers_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Makers_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C85 RID: 7301
			// (get) Token: 0x06006958 RID: 26968 RVA: 0x001F5468 File Offset: 0x001F3668
			// (set) Token: 0x06006959 RID: 26969 RVA: 0x000294A1 File Offset: 0x000276A1
			public unsafe RoundPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Makers_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Makers_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C86 RID: 7302
			// (get) Token: 0x0600695A RID: 26970 RVA: 0x001F5498 File Offset: 0x001F3698
			// (set) Token: 0x0600695B RID: 26971 RVA: 0x000294C0 File Offset: 0x000276C0
			public unsafe WormBoard _board_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Makers_d__10.NativeFieldInfoPtr__board_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormBoard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Makers_d__10.NativeFieldInfoPtr__board_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C87 RID: 7303
			// (get) Token: 0x0600695C RID: 26972 RVA: 0x001F54C8 File Offset: 0x001F36C8
			// (set) Token: 0x0600695D RID: 26973 RVA: 0x000294DF File Offset: 0x000276DF
			public unsafe IEnumerator<WormSpace> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Makers_d__10.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormSpace>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Makers_d__10.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004416 RID: 17430
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004417 RID: 17431
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004418 RID: 17432
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004419 RID: 17433
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400441A RID: 17434
			private static readonly IntPtr NativeFieldInfoPtr__board_5__2;

			// Token: 0x0400441B RID: 17435
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x0400441C RID: 17436
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400441D RID: 17437
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400441E RID: 17438
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400441F RID: 17439
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004420 RID: 17440
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004421 RID: 17441
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004422 RID: 17442
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004423 RID: 17443
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004424 RID: 17444
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000763 RID: 1891
		[ObfuscatedName("worm.canis.actions.phases.RoundPhase+<PlayerTurns>d__8")]
		public sealed class _PlayerTurns_d__8 : Object
		{
			// Token: 0x0600695E RID: 26974 RVA: 0x001F54F8 File Offset: 0x001F36F8
			// Note: this type is marked as 'beforefieldinit'.
			static _PlayerTurns_d__8()
			{
				Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, "<PlayerTurns>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr);
				RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, "<>1__state");
				RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, "<>2__current");
				RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, "<>l__initialThreadId");
				RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, "<>4__this");
				RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr__currentPlayer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, "<currentPlayer>5__2");
				RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr__sequence_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, "<sequence>5__3");
				RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, 100670082);
				RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, 100670083);
				RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, 100670084);
				RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, 100670085);
				RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, 100670086);
				RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, 100670087);
				RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, 100670088);
				RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr, 100670089);
			}

			// Token: 0x0600695F RID: 26975 RVA: 0x001F563C File Offset: 0x001F383C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PlayerTurns_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase._PlayerTurns_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006960 RID: 26976 RVA: 0x001F5684 File Offset: 0x001F3884
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006961 RID: 26977 RVA: 0x001F56B8 File Offset: 0x001F38B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164790, XrefRangeEnd = 164873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C90 RID: 7312
			// (get) Token: 0x06006962 RID: 26978 RVA: 0x001F56F4 File Offset: 0x001F38F4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006963 RID: 26979 RVA: 0x001F5734 File Offset: 0x001F3934
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164873, XrefRangeEnd = 164878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C91 RID: 7313
			// (get) Token: 0x06006964 RID: 26980 RVA: 0x001F5768 File Offset: 0x001F3968
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006965 RID: 26981 RVA: 0x001F57A8 File Offset: 0x001F39A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164878, XrefRangeEnd = 164880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006966 RID: 26982 RVA: 0x001F57E8 File Offset: 0x001F39E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._PlayerTurns_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006967 RID: 26983 RVA: 0x000294FE File Offset: 0x000276FE
			public _PlayerTurns_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C8A RID: 7306
			// (get) Token: 0x06006968 RID: 26984 RVA: 0x001F5828 File Offset: 0x001F3A28
			// (set) Token: 0x06006969 RID: 26985 RVA: 0x00029507 File Offset: 0x00027707
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C8B RID: 7307
			// (get) Token: 0x0600696A RID: 26986 RVA: 0x001F5850 File Offset: 0x001F3A50
			// (set) Token: 0x0600696B RID: 26987 RVA: 0x00029522 File Offset: 0x00027722
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C8C RID: 7308
			// (get) Token: 0x0600696C RID: 26988 RVA: 0x001F5880 File Offset: 0x001F3A80
			// (set) Token: 0x0600696D RID: 26989 RVA: 0x00029541 File Offset: 0x00027741
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C8D RID: 7309
			// (get) Token: 0x0600696E RID: 26990 RVA: 0x001F58A8 File Offset: 0x001F3AA8
			// (set) Token: 0x0600696F RID: 26991 RVA: 0x0002955C File Offset: 0x0002775C
			public unsafe RoundPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C8E RID: 7310
			// (get) Token: 0x06006970 RID: 26992 RVA: 0x001F58D8 File Offset: 0x001F3AD8
			// (set) Token: 0x06006971 RID: 26993 RVA: 0x0002957B File Offset: 0x0002777B
			public unsafe WormPlayer _currentPlayer_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr__currentPlayer_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr__currentPlayer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C8F RID: 7311
			// (get) Token: 0x06006972 RID: 26994 RVA: 0x001F5908 File Offset: 0x001F3B08
			// (set) Token: 0x06006973 RID: 26995 RVA: 0x0002959A File Offset: 0x0002779A
			public unsafe SequenceHelper _sequence_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr__sequence_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._PlayerTurns_d__8.NativeFieldInfoPtr__sequence_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004425 RID: 17445
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004426 RID: 17446
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004427 RID: 17447
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004428 RID: 17448
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004429 RID: 17449
			private static readonly IntPtr NativeFieldInfoPtr__currentPlayer_5__2;

			// Token: 0x0400442A RID: 17450
			private static readonly IntPtr NativeFieldInfoPtr__sequence_5__3;

			// Token: 0x0400442B RID: 17451
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400442C RID: 17452
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400442D RID: 17453
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400442E RID: 17454
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400442F RID: 17455
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004430 RID: 17456
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004431 RID: 17457
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004432 RID: 17458
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000764 RID: 1892
		[ObfuscatedName("worm.canis.actions.phases.RoundPhase+<Recall>d__11")]
		public sealed class _Recall_d__11 : Object
		{
			// Token: 0x06006974 RID: 26996 RVA: 0x001F5938 File Offset: 0x001F3B38
			// Note: this type is marked as 'beforefieldinit'.
			static _Recall_d__11()
			{
				Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, "<Recall>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr);
				RoundPhase._Recall_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<>1__state");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<>2__current");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<>l__initialThreadId");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<>4__this");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<>8__1");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<>8__2");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr__board_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<board>5__2");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr__reservedToTrash_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<reservedToTrash>5__3");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr__mentatAgent_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<mentatAgent>5__4");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr__mentatSpace_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<mentatSpace>5__5");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<>7__wrap5");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr__sequenceHelper_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<sequenceHelper>5__7");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<>7__wrap7");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr__techTiles_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<techTiles>5__9");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr__nextFirstPlayer_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<nextFirstPlayer>5__10");
				RoundPhase._Recall_d__11.NativeFieldInfoPtr__nextHagalFirstPlayer_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, "<nextHagalFirstPlayer>5__11");
				RoundPhase._Recall_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, 100670090);
				RoundPhase._Recall_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, 100670091);
				RoundPhase._Recall_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, 100670092);
				RoundPhase._Recall_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, 100670093);
				RoundPhase._Recall_d__11.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, 100670094);
				RoundPhase._Recall_d__11.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, 100670095);
				RoundPhase._Recall_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, 100670096);
				RoundPhase._Recall_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, 100670097);
				RoundPhase._Recall_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, 100670098);
				RoundPhase._Recall_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, 100670099);
				RoundPhase._Recall_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr, 100670100);
			}

			// Token: 0x06006975 RID: 26997 RVA: 0x001F5B80 File Offset: 0x001F3D80
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Recall_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase._Recall_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Recall_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006976 RID: 26998 RVA: 0x001F5BC8 File Offset: 0x001F3DC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164880, XrefRangeEnd = 164895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Recall_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006977 RID: 26999 RVA: 0x001F5BFC File Offset: 0x001F3DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164895, XrefRangeEnd = 166209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Recall_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006978 RID: 27000 RVA: 0x001F5C38 File Offset: 0x001F3E38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166209, XrefRangeEnd = 166212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Recall_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006979 RID: 27001 RVA: 0x001F5C6C File Offset: 0x001F3E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166212, XrefRangeEnd = 166215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Recall_d__11.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600697A RID: 27002 RVA: 0x001F5CA0 File Offset: 0x001F3EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166215, XrefRangeEnd = 166218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Recall_d__11.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CA2 RID: 7330
			// (get) Token: 0x0600697B RID: 27003 RVA: 0x001F5CD4 File Offset: 0x001F3ED4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Recall_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600697C RID: 27004 RVA: 0x001F5D14 File Offset: 0x001F3F14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166218, XrefRangeEnd = 166223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Recall_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CA3 RID: 7331
			// (get) Token: 0x0600697D RID: 27005 RVA: 0x001F5D48 File Offset: 0x001F3F48
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Recall_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600697E RID: 27006 RVA: 0x001F5D88 File Offset: 0x001F3F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166223, XrefRangeEnd = 166225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Recall_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600697F RID: 27007 RVA: 0x001F5DC8 File Offset: 0x001F3FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._Recall_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006980 RID: 27008 RVA: 0x000295B9 File Offset: 0x000277B9
			public _Recall_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C92 RID: 7314
			// (get) Token: 0x06006981 RID: 27009 RVA: 0x001F5E08 File Offset: 0x001F4008
			// (set) Token: 0x06006982 RID: 27010 RVA: 0x000295C2 File Offset: 0x000277C2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C93 RID: 7315
			// (get) Token: 0x06006983 RID: 27011 RVA: 0x001F5E30 File Offset: 0x001F4030
			// (set) Token: 0x06006984 RID: 27012 RVA: 0x000295DD File Offset: 0x000277DD
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C94 RID: 7316
			// (get) Token: 0x06006985 RID: 27013 RVA: 0x001F5E60 File Offset: 0x001F4060
			// (set) Token: 0x06006986 RID: 27014 RVA: 0x000295FC File Offset: 0x000277FC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C95 RID: 7317
			// (get) Token: 0x06006987 RID: 27015 RVA: 0x001F5E88 File Offset: 0x001F4088
			// (set) Token: 0x06006988 RID: 27016 RVA: 0x00029617 File Offset: 0x00027817
			public unsafe RoundPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C96 RID: 7318
			// (get) Token: 0x06006989 RID: 27017 RVA: 0x001F5EB8 File Offset: 0x001F40B8
			// (set) Token: 0x0600698A RID: 27018 RVA: 0x00029636 File Offset: 0x00027836
			public unsafe RoundPhase.__c__DisplayClass11_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundPhase.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C97 RID: 7319
			// (get) Token: 0x0600698B RID: 27019 RVA: 0x001F5EE8 File Offset: 0x001F40E8
			// (set) Token: 0x0600698C RID: 27020 RVA: 0x00029655 File Offset: 0x00027855
			public unsafe RoundPhase.__c__DisplayClass11_2 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundPhase.__c__DisplayClass11_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C98 RID: 7320
			// (get) Token: 0x0600698D RID: 27021 RVA: 0x001F5F18 File Offset: 0x001F4118
			// (set) Token: 0x0600698E RID: 27022 RVA: 0x00029674 File Offset: 0x00027874
			public unsafe WormBoard _board_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__board_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormBoard>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__board_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C99 RID: 7321
			// (get) Token: 0x0600698F RID: 27023 RVA: 0x001F5F48 File Offset: 0x001F4148
			// (set) Token: 0x06006990 RID: 27024 RVA: 0x00029693 File Offset: 0x00027893
			public unsafe Il2CppReferenceArray<Entity> _reservedToTrash_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__reservedToTrash_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__reservedToTrash_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C9A RID: 7322
			// (get) Token: 0x06006991 RID: 27025 RVA: 0x001F5F78 File Offset: 0x001F4178
			// (set) Token: 0x06006992 RID: 27026 RVA: 0x000296B2 File Offset: 0x000278B2
			public unsafe WormAgent _mentatAgent_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__mentatAgent_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormAgent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__mentatAgent_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C9B RID: 7323
			// (get) Token: 0x06006993 RID: 27027 RVA: 0x001F5FA8 File Offset: 0x001F41A8
			// (set) Token: 0x06006994 RID: 27028 RVA: 0x000296D1 File Offset: 0x000278D1
			public unsafe WormSpace _mentatSpace_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__mentatSpace_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSpace>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__mentatSpace_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C9C RID: 7324
			// (get) Token: 0x06006995 RID: 27029 RVA: 0x001F5FD8 File Offset: 0x001F41D8
			// (set) Token: 0x06006996 RID: 27030 RVA: 0x000296F0 File Offset: 0x000278F0
			public unsafe IEnumerator<Entity> __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___7__wrap5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___7__wrap5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C9D RID: 7325
			// (get) Token: 0x06006997 RID: 27031 RVA: 0x001F6008 File Offset: 0x001F4208
			// (set) Token: 0x06006998 RID: 27032 RVA: 0x0002970F File Offset: 0x0002790F
			public unsafe SequenceHelper _sequenceHelper_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__sequenceHelper_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__sequenceHelper_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C9E RID: 7326
			// (get) Token: 0x06006999 RID: 27033 RVA: 0x001F6038 File Offset: 0x001F4238
			// (set) Token: 0x0600699A RID: 27034 RVA: 0x0002972E File Offset: 0x0002792E
			public unsafe IEnumerator<WormPlayer> __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___7__wrap7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr___7__wrap7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C9F RID: 7327
			// (get) Token: 0x0600699B RID: 27035 RVA: 0x001F6068 File Offset: 0x001F4268
			// (set) Token: 0x0600699C RID: 27036 RVA: 0x0002974D File Offset: 0x0002794D
			public unsafe Il2CppReferenceArray<WormTechTilePlayable> _techTiles_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__techTiles_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<WormTechTilePlayable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__techTiles_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CA0 RID: 7328
			// (get) Token: 0x0600699D RID: 27037 RVA: 0x001F6098 File Offset: 0x001F4298
			// (set) Token: 0x0600699E RID: 27038 RVA: 0x0002976C File Offset: 0x0002796C
			public unsafe WormPlayer _nextFirstPlayer_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__nextFirstPlayer_5__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__nextFirstPlayer_5__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CA1 RID: 7329
			// (get) Token: 0x0600699F RID: 27039 RVA: 0x001F60C8 File Offset: 0x001F42C8
			// (set) Token: 0x060069A0 RID: 27040 RVA: 0x0002978B File Offset: 0x0002798B
			public unsafe WormPlayer _nextHagalFirstPlayer_5__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__nextHagalFirstPlayer_5__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._Recall_d__11.NativeFieldInfoPtr__nextHagalFirstPlayer_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004433 RID: 17459
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004434 RID: 17460
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004435 RID: 17461
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004436 RID: 17462
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004437 RID: 17463
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04004438 RID: 17464
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x04004439 RID: 17465
			private static readonly IntPtr NativeFieldInfoPtr__board_5__2;

			// Token: 0x0400443A RID: 17466
			private static readonly IntPtr NativeFieldInfoPtr__reservedToTrash_5__3;

			// Token: 0x0400443B RID: 17467
			private static readonly IntPtr NativeFieldInfoPtr__mentatAgent_5__4;

			// Token: 0x0400443C RID: 17468
			private static readonly IntPtr NativeFieldInfoPtr__mentatSpace_5__5;

			// Token: 0x0400443D RID: 17469
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x0400443E RID: 17470
			private static readonly IntPtr NativeFieldInfoPtr__sequenceHelper_5__7;

			// Token: 0x0400443F RID: 17471
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x04004440 RID: 17472
			private static readonly IntPtr NativeFieldInfoPtr__techTiles_5__9;

			// Token: 0x04004441 RID: 17473
			private static readonly IntPtr NativeFieldInfoPtr__nextFirstPlayer_5__10;

			// Token: 0x04004442 RID: 17474
			private static readonly IntPtr NativeFieldInfoPtr__nextHagalFirstPlayer_5__11;

			// Token: 0x04004443 RID: 17475
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004444 RID: 17476
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004445 RID: 17477
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004446 RID: 17478
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004447 RID: 17479
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04004448 RID: 17480
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04004449 RID: 17481
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400444A RID: 17482
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400444B RID: 17483
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400444C RID: 17484
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400444D RID: 17485
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000765 RID: 1893
		[ObfuscatedName("worm.canis.actions.phases.RoundPhase+<RoundStart>d__5")]
		public sealed class _RoundStart_d__5 : Object
		{
			// Token: 0x060069A1 RID: 27041 RVA: 0x001F60F8 File Offset: 0x001F42F8
			// Note: this type is marked as 'beforefieldinit'.
			static _RoundStart_d__5()
			{
				Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RoundPhase>.NativeClassPtr, "<RoundStart>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr);
				RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, "<>1__state");
				RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, "<>2__current");
				RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, "<>l__initialThreadId");
				RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, "<>4__this");
				RoundPhase._RoundStart_d__5.NativeFieldInfoPtr__roundNumber_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, "<roundNumber>5__2");
				RoundPhase._RoundStart_d__5.NativeFieldInfoPtr__firstPlayer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, "<firstPlayer>5__3");
				RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, "<>7__wrap3");
				RoundPhase._RoundStart_d__5.NativeFieldInfoPtr__firstRoll_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, "<firstRoll>5__5");
				RoundPhase._RoundStart_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, 100670101);
				RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, 100670102);
				RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, 100670103);
				RoundPhase._RoundStart_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, 100670104);
				RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, 100670105);
				RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, 100670106);
				RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, 100670107);
				RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, 100670108);
				RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr, 100670109);
			}

			// Token: 0x060069A2 RID: 27042 RVA: 0x001F6278 File Offset: 0x001F4478
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RoundStart_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundPhase._RoundStart_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._RoundStart_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060069A3 RID: 27043 RVA: 0x001F62C0 File Offset: 0x001F44C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166225, XrefRangeEnd = 166230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060069A4 RID: 27044 RVA: 0x001F62F4 File Offset: 0x001F44F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166230, XrefRangeEnd = 166470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060069A5 RID: 27045 RVA: 0x001F6330 File Offset: 0x001F4530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166470, XrefRangeEnd = 166473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._RoundStart_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CAC RID: 7340
			// (get) Token: 0x060069A6 RID: 27046 RVA: 0x001F6364 File Offset: 0x001F4564
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060069A7 RID: 27047 RVA: 0x001F63A4 File Offset: 0x001F45A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166473, XrefRangeEnd = 166478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CAD RID: 7341
			// (get) Token: 0x060069A8 RID: 27048 RVA: 0x001F63D8 File Offset: 0x001F45D8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060069A9 RID: 27049 RVA: 0x001F6418 File Offset: 0x001F4618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166478, XrefRangeEnd = 166480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060069AA RID: 27050 RVA: 0x001F6458 File Offset: 0x001F4658
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundPhase._RoundStart_d__5.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060069AB RID: 27051 RVA: 0x000297AA File Offset: 0x000279AA
			public _RoundStart_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CA4 RID: 7332
			// (get) Token: 0x060069AC RID: 27052 RVA: 0x001F6498 File Offset: 0x001F4698
			// (set) Token: 0x060069AD RID: 27053 RVA: 0x000297B3 File Offset: 0x000279B3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CA5 RID: 7333
			// (get) Token: 0x060069AE RID: 27054 RVA: 0x001F64C0 File Offset: 0x001F46C0
			// (set) Token: 0x060069AF RID: 27055 RVA: 0x000297CE File Offset: 0x000279CE
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CA6 RID: 7334
			// (get) Token: 0x060069B0 RID: 27056 RVA: 0x001F64F0 File Offset: 0x001F46F0
			// (set) Token: 0x060069B1 RID: 27057 RVA: 0x000297ED File Offset: 0x000279ED
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001CA7 RID: 7335
			// (get) Token: 0x060069B2 RID: 27058 RVA: 0x001F6518 File Offset: 0x001F4718
			// (set) Token: 0x060069B3 RID: 27059 RVA: 0x00029808 File Offset: 0x00027A08
			public unsafe RoundPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RoundPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CA8 RID: 7336
			// (get) Token: 0x060069B4 RID: 27060 RVA: 0x001F6548 File Offset: 0x001F4748
			// (set) Token: 0x060069B5 RID: 27061 RVA: 0x00029827 File Offset: 0x00027A27
			public unsafe int _roundNumber_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr__roundNumber_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr__roundNumber_5__2)) = value;
				}
			}

			// Token: 0x17001CA9 RID: 7337
			// (get) Token: 0x060069B6 RID: 27062 RVA: 0x001F6570 File Offset: 0x001F4770
			// (set) Token: 0x060069B7 RID: 27063 RVA: 0x00029842 File Offset: 0x00027A42
			public unsafe WormPlayer _firstPlayer_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr__firstPlayer_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr__firstPlayer_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CAA RID: 7338
			// (get) Token: 0x060069B8 RID: 27064 RVA: 0x001F65A0 File Offset: 0x001F47A0
			// (set) Token: 0x060069B9 RID: 27065 RVA: 0x00029861 File Offset: 0x00027A61
			public unsafe IEnumerator<WormPlayer> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CAB RID: 7339
			// (get) Token: 0x060069BA RID: 27066 RVA: 0x001F65D0 File Offset: 0x001F47D0
			// (set) Token: 0x060069BB RID: 27067 RVA: 0x00029880 File Offset: 0x00027A80
			public unsafe int _firstRoll_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr__firstRoll_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundPhase._RoundStart_d__5.NativeFieldInfoPtr__firstRoll_5__5)) = value;
				}
			}

			// Token: 0x0400444E RID: 17486
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400444F RID: 17487
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004450 RID: 17488
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004451 RID: 17489
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004452 RID: 17490
			private static readonly IntPtr NativeFieldInfoPtr__roundNumber_5__2;

			// Token: 0x04004453 RID: 17491
			private static readonly IntPtr NativeFieldInfoPtr__firstPlayer_5__3;

			// Token: 0x04004454 RID: 17492
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04004455 RID: 17493
			private static readonly IntPtr NativeFieldInfoPtr__firstRoll_5__5;

			// Token: 0x04004456 RID: 17494
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004457 RID: 17495
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004458 RID: 17496
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004459 RID: 17497
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400445A RID: 17498
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400445B RID: 17499
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400445C RID: 17500
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400445D RID: 17501
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400445E RID: 17502
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
