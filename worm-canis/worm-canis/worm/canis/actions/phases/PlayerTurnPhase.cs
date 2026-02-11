using System;
using Canis;
using Canis.actions;
using Canis.entities;
using Canis.utils.ids;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages.outgoing;
using Networking.selection.targetinformation;
using worm.canis.abilities;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002CE RID: 718
	public class PlayerTurnPhase : StateMachineAction<PlayerTurnState>
	{
		// Token: 0x06001D7F RID: 7551 RVA: 0x000CBD34 File Offset: 0x000C9F34
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTurnPhase()
		{
			Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "PlayerTurnPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr);
			PlayerTurnPhase.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "wormMatch");
			PlayerTurnPhase.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "player");
			PlayerTurnPhase.NativeFieldInfoPtr_agentSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "agentSelection");
			PlayerTurnPhase.NativeMethodInfoPtr_get_Playmat_Private_get_WormPlaymat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669769);
			PlayerTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669770);
			PlayerTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedPlayerTurnPhase_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669771);
			PlayerTurnPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_PlayerTurnState_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669772);
			PlayerTurnPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_PlayerTurnState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669773);
			PlayerTurnPhase.NativeMethodInfoPtr_MakeKindAndPromptForTurnType_Private_Void_PlayerTurnTypes_byref_String_byref_LocalizableTextVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669774);
			PlayerTurnPhase.NativeMethodInfoPtr_PrePlayerTurn_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669775);
			PlayerTurnPhase.NativeMethodInfoPtr_DetermineTurn_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669776);
			PlayerTurnPhase.NativeMethodInfoPtr_TakeAgentTurn_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669777);
			PlayerTurnPhase.NativeMethodInfoPtr_TakeRevealTurn_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669778);
			PlayerTurnPhase.NativeMethodInfoPtr_ResolveDeferredAbilities_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669779);
			PlayerTurnPhase.NativeMethodInfoPtr_ResolveDelayedAbilities_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669780);
			PlayerTurnPhase.NativeMethodInfoPtr_Cleanup_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669781);
			PlayerTurnPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669782);
			PlayerTurnPhase.NativeMethodInfoPtr_UndoDetermineTurn_Public_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669783);
			PlayerTurnPhase.NativeMethodInfoPtr__DetermineTurn_b__11_0_Private_Boolean_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669784);
			PlayerTurnPhase.NativeMethodInfoPtr__DetermineTurn_b__11_1_Private_IEnumerable_1_EntityID_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669785);
			PlayerTurnPhase.NativeMethodInfoPtr__DetermineTurn_b__11_4_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669786);
			PlayerTurnPhase.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_3_Private_Boolean_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669787);
			PlayerTurnPhase.NativeMethodInfoPtr__Cleanup_b__16_10_Private_IEnumerable_1_WormAgent_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669788);
			PlayerTurnPhase.NativeMethodInfoPtr__Cleanup_b__16_11_Private_Boolean_WormAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, 100669789);
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x000CBF44 File Offset: 0x000CA144
		public unsafe WormPlaymat Playmat
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162943, XrefRangeEnd = 162945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr_get_Playmat_Private_get_WormPlaymat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormPlaymat>(intPtr3) : null;
			}
		}

		// Token: 0x06001D81 RID: 7553 RVA: 0x000CBF84 File Offset: 0x000CA184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 162953, RefRangeEnd = 162954, XrefRangeStart = 162945, XrefRangeEnd = 162953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTurnPhase(WormPlayer player, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D82 RID: 7554 RVA: 0x000CBFE4 File Offset: 0x000CA1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162954, XrefRangeEnd = 162965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTurnPhase(SerializedPlayerTurnPhase serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedPlayerTurnPhase_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D83 RID: 7555 RVA: 0x000CC044 File Offset: 0x000CA244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162965, XrefRangeEnd = 163047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<PlayerTurnState> DetermineNextTypedState(global::Canis.actions.Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerTurnPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_PlayerTurnState_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<PlayerTurnState>(intPtr);
			}
		}

		// Token: 0x06001D84 RID: 7556 RVA: 0x000CC098 File Offset: 0x000CA298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163047, XrefRangeEnd = 163059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior TypedBehaviorFor(PlayerTurnState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerTurnPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_PlayerTurnState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06001D85 RID: 7557 RVA: 0x000CC0F0 File Offset: 0x000CA2F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163088, RefRangeEnd = 163089, XrefRangeStart = 163059, XrefRangeEnd = 163088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MakeKindAndPromptForTurnType(PlayerTurnTypes turnType, out string pickerKind, out LocalizableTextVariables prompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref turnType;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr_MakeKindAndPromptForTurnType_Private_Void_PlayerTurnTypes_byref_String_byref_LocalizableTextVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			pickerKind = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			prompt = ((intPtr5 == 0) ? null : new LocalizableTextVariables(intPtr5));
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x000CC16C File Offset: 0x000CA36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163089, XrefRangeEnd = 163095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> PrePlayerTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr_PrePlayerTurn_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x000CC1AC File Offset: 0x000CA3AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163095, XrefRangeEnd = 163101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> DetermineTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr_DetermineTurn_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x000CC1EC File Offset: 0x000CA3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163101, XrefRangeEnd = 163107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> TakeAgentTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr_TakeAgentTurn_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D89 RID: 7561 RVA: 0x000CC22C File Offset: 0x000CA42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163107, XrefRangeEnd = 163113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> TakeRevealTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr_TakeRevealTurn_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x000CC26C File Offset: 0x000CA46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163113, XrefRangeEnd = 163119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ResolveDeferredAbilities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr_ResolveDeferredAbilities_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x000CC2AC File Offset: 0x000CA4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163119, XrefRangeEnd = 163125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ResolveDelayedAbilities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr_ResolveDelayedAbilities_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x000CC2EC File Offset: 0x000CA4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163125, XrefRangeEnd = 163131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr_Cleanup_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x000CC32C File Offset: 0x000CA52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163131, XrefRangeEnd = 163136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerTurnPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x000CC388 File Offset: 0x000CA588
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163142, RefRangeEnd = 163144, XrefRangeStart = 163136, XrefRangeEnd = 163142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> UndoDetermineTurn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr_UndoDetermineTurn_Public_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x000CC3C8 File Offset: 0x000CA5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163144, XrefRangeEnd = 163148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _DetermineTurn_b__11_0(KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>> pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr__DetermineTurn_b__11_0_Private_Boolean_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x000CC41C File Offset: 0x000CA61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163148, XrefRangeEnd = 163170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<EntityID> _DetermineTurn_b__11_1(KeyValuePair<EntityID, Il2CppReferenceArray<TargetInformation>> pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr__DetermineTurn_b__11_1_Private_IEnumerable_1_EntityID_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<EntityID>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x000CC474 File Offset: 0x000CA674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163170, XrefRangeEnd = 163173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _DetermineTurn_b__11_4(EntityID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr__DetermineTurn_b__11_4_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x000CC4C4 File Offset: 0x000CA6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163173, XrefRangeEnd = 163180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _ResolveDeferredAbilities_b__14_3(AbilityDefinitionForGame<WormMatch> ability)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ability);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_3_Private_Boolean_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x000CC514 File Offset: 0x000CA714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163180, XrefRangeEnd = 163194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<WormAgent> _Cleanup_b__16_10(WormSpace space)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(space);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr__Cleanup_b__16_10_Private_IEnumerable_1_WormAgent_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAgent>>(intPtr3) : null;
			}
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x000CC564 File Offset: 0x000CA764
		[CallerCount(0)]
		public unsafe bool _Cleanup_b__16_11(WormAgent _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.NativeMethodInfoPtr__Cleanup_b__16_11_Private_Boolean_WormAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x0000C6A3 File Offset: 0x0000A8A3
		public PlayerTurnPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x000CC5B4 File Offset: 0x000CA7B4
		// (set) Token: 0x06001D97 RID: 7575 RVA: 0x0000C6AC File Offset: 0x0000A8AC
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x000CC5E4 File Offset: 0x000CA7E4
		// (set) Token: 0x06001D99 RID: 7577 RVA: 0x0000C6CB File Offset: 0x0000A8CB
		public unsafe WormPlayer player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x000CC614 File Offset: 0x000CA814
		// (set) Token: 0x06001D9B RID: 7579 RVA: 0x0000C6EA File Offset: 0x0000A8EA
		public unsafe EntityIDTargetResponses agentSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase.NativeFieldInfoPtr_agentSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityIDTargetResponses>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase.NativeFieldInfoPtr_agentSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x04001274 RID: 4724
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04001275 RID: 4725
		private static readonly IntPtr NativeFieldInfoPtr_agentSelection;

		// Token: 0x04001276 RID: 4726
		private static readonly IntPtr NativeMethodInfoPtr_get_Playmat_Private_get_WormPlaymat_0;

		// Token: 0x04001277 RID: 4727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0;

		// Token: 0x04001278 RID: 4728
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedPlayerTurnPhase_WormMatch_0;

		// Token: 0x04001279 RID: 4729
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_PlayerTurnState_Action_0;

		// Token: 0x0400127A RID: 4730
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_PlayerTurnState_0;

		// Token: 0x0400127B RID: 4731
		private static readonly IntPtr NativeMethodInfoPtr_MakeKindAndPromptForTurnType_Private_Void_PlayerTurnTypes_byref_String_byref_LocalizableTextVariables_0;

		// Token: 0x0400127C RID: 4732
		private static readonly IntPtr NativeMethodInfoPtr_PrePlayerTurn_Private_IEnumerable_1_Action_0;

		// Token: 0x0400127D RID: 4733
		private static readonly IntPtr NativeMethodInfoPtr_DetermineTurn_Private_IEnumerable_1_Action_0;

		// Token: 0x0400127E RID: 4734
		private static readonly IntPtr NativeMethodInfoPtr_TakeAgentTurn_Private_IEnumerable_1_Action_0;

		// Token: 0x0400127F RID: 4735
		private static readonly IntPtr NativeMethodInfoPtr_TakeRevealTurn_Private_IEnumerable_1_Action_0;

		// Token: 0x04001280 RID: 4736
		private static readonly IntPtr NativeMethodInfoPtr_ResolveDeferredAbilities_Private_IEnumerable_1_Action_0;

		// Token: 0x04001281 RID: 4737
		private static readonly IntPtr NativeMethodInfoPtr_ResolveDelayedAbilities_Private_IEnumerable_1_Action_0;

		// Token: 0x04001282 RID: 4738
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_IEnumerable_1_Action_0;

		// Token: 0x04001283 RID: 4739
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;

		// Token: 0x04001284 RID: 4740
		private static readonly IntPtr NativeMethodInfoPtr_UndoDetermineTurn_Public_IEnumerable_1_Action_0;

		// Token: 0x04001285 RID: 4741
		private static readonly IntPtr NativeMethodInfoPtr__DetermineTurn_b__11_0_Private_Boolean_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0;

		// Token: 0x04001286 RID: 4742
		private static readonly IntPtr NativeMethodInfoPtr__DetermineTurn_b__11_1_Private_IEnumerable_1_EntityID_KeyValuePair_2_EntityID_Il2CppReferenceArray_1_TargetInformation_0;

		// Token: 0x04001287 RID: 4743
		private static readonly IntPtr NativeMethodInfoPtr__DetermineTurn_b__11_4_Private_Boolean_EntityID_0;

		// Token: 0x04001288 RID: 4744
		private static readonly IntPtr NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_3_Private_Boolean_AbilityDefinitionForGame_1_WormMatch_0;

		// Token: 0x04001289 RID: 4745
		private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_10_Private_IEnumerable_1_WormAgent_WormSpace_0;

		// Token: 0x0400128A RID: 4746
		private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_11_Private_Boolean_WormAgent_0;

		// Token: 0x02000745 RID: 1861
		[ObfuscatedName("worm.canis.actions.phases.PlayerTurnPhase+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060066BA RID: 26298 RVA: 0x001ED0E4 File Offset: 0x001EB2E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr);
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__10_0");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__11_2");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__11_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__11_3");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__14_0");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__14_1");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__14_2");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__14_4");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__14_5");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__14_6");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_6");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_8");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_7");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_9");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_0");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_12");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_14");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_1");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_2");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_3");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_4");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_5");
				PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, "<>9__16_15");
				PlayerTurnPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669791);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__PrePlayerTurn_b__10_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669792);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__DetermineTurn_b__11_2_Internal_EntityID_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669793);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__DetermineTurn_b__11_3_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669794);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_0_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669795);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_1_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669796);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_2_Internal_EntityID_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669797);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_4_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669798);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_5_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669799);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_6_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669800);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_6_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669801);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_8_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669802);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_7_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669803);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_9_Internal_IEnumerable_1_WormAbilityDefinition_WormPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669804);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_0_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669805);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_12_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669806);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_14_Internal_Boolean_WormUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669807);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_1_Internal_Boolean_WormImperiumPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669808);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_2_Internal_IEnumerable_1_WormAbilityDefinition_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669809);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_3_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669810);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_4_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669811);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_5_Internal_Boolean_WormSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669812);
				PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_15_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr, 100669813);
			}

			// Token: 0x060066BB RID: 26299 RVA: 0x001ED4A8 File Offset: 0x001EB6A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTurnPhase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060066BC RID: 26300 RVA: 0x001ED4E4 File Offset: 0x001EB6E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159816, XrefRangeEnd = 159824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PrePlayerTurn_b__10_0(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__PrePlayerTurn_b__10_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066BD RID: 26301 RVA: 0x001ED534 File Offset: 0x001EB734
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159824, XrefRangeEnd = 159825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _DetermineTurn_b__11_2(AbilityDefinitionForGame<WormMatch> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__DetermineTurn_b__11_2_Internal_EntityID_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060066BE RID: 26302 RVA: 0x001ED584 File Offset: 0x001EB784
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159825, XrefRangeEnd = 159842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineTurn_b__11_3(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__DetermineTurn_b__11_3_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066BF RID: 26303 RVA: 0x001ED5D4 File Offset: 0x001EB7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159842, XrefRangeEnd = 159845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveDeferredAbilities_b__14_0(AbilityDefinitionForGame<WormMatch> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_0_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066C0 RID: 26304 RVA: 0x001ED624 File Offset: 0x001EB824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159845, XrefRangeEnd = 159846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveDeferredAbilities_b__14_1(AbilityDefinitionForGame<WormMatch> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_1_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066C1 RID: 26305 RVA: 0x001ED674 File Offset: 0x001EB874
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EntityID _ResolveDeferredAbilities_b__14_2(AbilityDefinitionForGame<WormMatch> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_2_Internal_EntityID_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr3) : null;
				}
			}

			// Token: 0x060066C2 RID: 26306 RVA: 0x001ED6C4 File Offset: 0x001EB8C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159846, XrefRangeEnd = 159854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveDeferredAbilities_b__14_4(AbilityDefinitionForGame<WormMatch> a)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_4_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066C3 RID: 26307 RVA: 0x001ED714 File Offset: 0x001EB914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159854, XrefRangeEnd = 159855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveDeferredAbilities_b__14_5(AbilityDefinitionForGame<WormMatch> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_5_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066C4 RID: 26308 RVA: 0x001ED764 File Offset: 0x001EB964
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159855, XrefRangeEnd = 159859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ResolveDeferredAbilities_b__14_6(AbilityDefinitionForGame<WormMatch> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_6_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066C5 RID: 26309 RVA: 0x001ED7B4 File Offset: 0x001EB9B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159859, XrefRangeEnd = 159860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__16_6(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_6_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066C6 RID: 26310 RVA: 0x001ED804 File Offset: 0x001EBA04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159860, XrefRangeEnd = 159869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__16_8(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_8_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066C7 RID: 26311 RVA: 0x001ED854 File Offset: 0x001EBA54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159869, XrefRangeEnd = 159878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__16_7(Entity c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_7_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066C8 RID: 26312 RVA: 0x001ED8A4 File Offset: 0x001EBAA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159878, XrefRangeEnd = 159880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormAbilityDefinition> _Cleanup_b__16_9(WormPlayable card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_9_Internal_IEnumerable_1_WormAbilityDefinition_WormPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr3) : null;
				}
			}

			// Token: 0x060066C9 RID: 26313 RVA: 0x001ED8F4 File Offset: 0x001EBAF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159880, XrefRangeEnd = 159888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__16_0(Entity c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_0_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066CA RID: 26314 RVA: 0x001ED944 File Offset: 0x001EBB44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159888, XrefRangeEnd = 159896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__16_12(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_12_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066CB RID: 26315 RVA: 0x001ED994 File Offset: 0x001EBB94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__16_14(WormUnit _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_14_Internal_Boolean_WormUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066CC RID: 26316 RVA: 0x001ED9E4 File Offset: 0x001EBBE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__16_1(WormImperiumPlayable _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_1_Internal_Boolean_WormImperiumPlayable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066CD RID: 26317 RVA: 0x001EDA34 File Offset: 0x001EBC34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<WormAbilityDefinition> _Cleanup_b__16_2(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_2_Internal_IEnumerable_1_WormAbilityDefinition_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<WormAbilityDefinition>>(intPtr3) : null;
				}
			}

			// Token: 0x060066CE RID: 26318 RVA: 0x001EDA84 File Offset: 0x001EBC84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__16_3(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_3_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066CF RID: 26319 RVA: 0x001EDAD4 File Offset: 0x001EBCD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__16_4(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_4_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066D0 RID: 26320 RVA: 0x001EDB24 File Offset: 0x001EBD24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__16_5(WormSpace _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_5_Internal_Boolean_WormSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066D1 RID: 26321 RVA: 0x001EDB74 File Offset: 0x001EBD74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159896, XrefRangeEnd = 159897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__16_15(WormAbilityDefinition ab)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ab);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c.NativeMethodInfoPtr__Cleanup_b__16_15_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060066D2 RID: 26322 RVA: 0x00028030 File Offset: 0x00026230
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BA9 RID: 7081
			// (get) Token: 0x060066D3 RID: 26323 RVA: 0x001EDBC4 File Offset: 0x001EBDC4
			// (set) Token: 0x060066D4 RID: 26324 RVA: 0x00028039 File Offset: 0x00026239
			public unsafe static PlayerTurnPhase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTurnPhase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BAA RID: 7082
			// (get) Token: 0x060066D5 RID: 26325 RVA: 0x001EDBEC File Offset: 0x001EBDEC
			// (set) Token: 0x060066D6 RID: 26326 RVA: 0x0002804B File Offset: 0x0002624B
			public unsafe static Func<Entity, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BAB RID: 7083
			// (get) Token: 0x060066D7 RID: 26327 RVA: 0x001EDC14 File Offset: 0x001EBE14
			// (set) Token: 0x060066D8 RID: 26328 RVA: 0x0002805D File Offset: 0x0002625D
			public unsafe static Func<AbilityDefinitionForGame<WormMatch>, EntityID> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AbilityDefinitionForGame<WormMatch>, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BAC RID: 7084
			// (get) Token: 0x060066D9 RID: 26329 RVA: 0x001EDC3C File Offset: 0x001EBE3C
			// (set) Token: 0x060066DA RID: 26330 RVA: 0x0002806F File Offset: 0x0002626F
			public unsafe static Func<Entity, bool> __9__11_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__11_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__11_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BAD RID: 7085
			// (get) Token: 0x060066DB RID: 26331 RVA: 0x001EDC64 File Offset: 0x001EBE64
			// (set) Token: 0x060066DC RID: 26332 RVA: 0x00028081 File Offset: 0x00026281
			public unsafe static Func<AbilityDefinitionForGame<WormMatch>, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AbilityDefinitionForGame<WormMatch>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BAE RID: 7086
			// (get) Token: 0x060066DD RID: 26333 RVA: 0x001EDC8C File Offset: 0x001EBE8C
			// (set) Token: 0x060066DE RID: 26334 RVA: 0x00028093 File Offset: 0x00026293
			public unsafe static Predicate<AbilityDefinitionForGame<WormMatch>> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<AbilityDefinitionForGame<WormMatch>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BAF RID: 7087
			// (get) Token: 0x060066DF RID: 26335 RVA: 0x001EDCB4 File Offset: 0x001EBEB4
			// (set) Token: 0x060066E0 RID: 26336 RVA: 0x000280A5 File Offset: 0x000262A5
			public unsafe static Func<AbilityDefinitionForGame<WormMatch>, EntityID> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AbilityDefinitionForGame<WormMatch>, EntityID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB0 RID: 7088
			// (get) Token: 0x060066E1 RID: 26337 RVA: 0x001EDCDC File Offset: 0x001EBEDC
			// (set) Token: 0x060066E2 RID: 26338 RVA: 0x000280B7 File Offset: 0x000262B7
			public unsafe static Func<AbilityDefinitionForGame<WormMatch>, bool> __9__14_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AbilityDefinitionForGame<WormMatch>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB1 RID: 7089
			// (get) Token: 0x060066E3 RID: 26339 RVA: 0x001EDD04 File Offset: 0x001EBF04
			// (set) Token: 0x060066E4 RID: 26340 RVA: 0x000280C9 File Offset: 0x000262C9
			public unsafe static Func<AbilityDefinitionForGame<WormMatch>, bool> __9__14_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AbilityDefinitionForGame<WormMatch>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB2 RID: 7090
			// (get) Token: 0x060066E5 RID: 26341 RVA: 0x001EDD2C File Offset: 0x001EBF2C
			// (set) Token: 0x060066E6 RID: 26342 RVA: 0x000280DB File Offset: 0x000262DB
			public unsafe static Func<AbilityDefinitionForGame<WormMatch>, bool> __9__14_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AbilityDefinitionForGame<WormMatch>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__14_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB3 RID: 7091
			// (get) Token: 0x060066E7 RID: 26343 RVA: 0x001EDD54 File Offset: 0x001EBF54
			// (set) Token: 0x060066E8 RID: 26344 RVA: 0x000280ED File Offset: 0x000262ED
			public unsafe static Func<Entity, bool> __9__16_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB4 RID: 7092
			// (get) Token: 0x060066E9 RID: 26345 RVA: 0x001EDD7C File Offset: 0x001EBF7C
			// (set) Token: 0x060066EA RID: 26346 RVA: 0x000280FF File Offset: 0x000262FF
			public unsafe static Func<Entity, bool> __9__16_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB5 RID: 7093
			// (get) Token: 0x060066EB RID: 26347 RVA: 0x001EDDA4 File Offset: 0x001EBFA4
			// (set) Token: 0x060066EC RID: 26348 RVA: 0x00028111 File Offset: 0x00026311
			public unsafe static Func<Entity, bool> __9__16_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB6 RID: 7094
			// (get) Token: 0x060066ED RID: 26349 RVA: 0x001EDDCC File Offset: 0x001EBFCC
			// (set) Token: 0x060066EE RID: 26350 RVA: 0x00028123 File Offset: 0x00026323
			public unsafe static Func<WormPlayable, IEnumerable<WormAbilityDefinition>> __9__16_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayable, IEnumerable<WormAbilityDefinition>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB7 RID: 7095
			// (get) Token: 0x060066EF RID: 26351 RVA: 0x001EDDF4 File Offset: 0x001EBFF4
			// (set) Token: 0x060066F0 RID: 26352 RVA: 0x00028135 File Offset: 0x00026335
			public unsafe static Func<Entity, bool> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB8 RID: 7096
			// (get) Token: 0x060066F1 RID: 26353 RVA: 0x001EDE1C File Offset: 0x001EC01C
			// (set) Token: 0x060066F2 RID: 26354 RVA: 0x00028147 File Offset: 0x00026347
			public unsafe static Func<Entity, bool> __9__16_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BB9 RID: 7097
			// (get) Token: 0x060066F3 RID: 26355 RVA: 0x001EDE44 File Offset: 0x001EC044
			// (set) Token: 0x060066F4 RID: 26356 RVA: 0x00028159 File Offset: 0x00026359
			public unsafe static Func<WormUnit, bool> __9__16_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormUnit, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BBA RID: 7098
			// (get) Token: 0x060066F5 RID: 26357 RVA: 0x001EDE6C File Offset: 0x001EC06C
			// (set) Token: 0x060066F6 RID: 26358 RVA: 0x0002816B File Offset: 0x0002636B
			public unsafe static Func<WormImperiumPlayable, bool> __9__16_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormImperiumPlayable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BBB RID: 7099
			// (get) Token: 0x060066F7 RID: 26359 RVA: 0x001EDE94 File Offset: 0x001EC094
			// (set) Token: 0x060066F8 RID: 26360 RVA: 0x0002817D File Offset: 0x0002637D
			public unsafe static Func<WormSpace, IEnumerable<WormAbilityDefinition>> __9__16_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, IEnumerable<WormAbilityDefinition>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BBC RID: 7100
			// (get) Token: 0x060066F9 RID: 26361 RVA: 0x001EDEBC File Offset: 0x001EC0BC
			// (set) Token: 0x060066FA RID: 26362 RVA: 0x0002818F File Offset: 0x0002638F
			public unsafe static Func<WormAbilityDefinition, bool> __9__16_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BBD RID: 7101
			// (get) Token: 0x060066FB RID: 26363 RVA: 0x001EDEE4 File Offset: 0x001EC0E4
			// (set) Token: 0x060066FC RID: 26364 RVA: 0x000281A1 File Offset: 0x000263A1
			public unsafe static Func<WormSpace, bool> __9__16_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BBE RID: 7102
			// (get) Token: 0x060066FD RID: 26365 RVA: 0x001EDF0C File Offset: 0x001EC10C
			// (set) Token: 0x060066FE RID: 26366 RVA: 0x000281B3 File Offset: 0x000263B3
			public unsafe static Func<WormSpace, bool> __9__16_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormSpace, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BBF RID: 7103
			// (get) Token: 0x060066FF RID: 26367 RVA: 0x001EDF34 File Offset: 0x001EC134
			// (set) Token: 0x06006700 RID: 26368 RVA: 0x000281C5 File Offset: 0x000263C5
			public unsafe static Func<WormAbilityDefinition, bool> __9__16_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormAbilityDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerTurnPhase.__c.NativeFieldInfoPtr___9__16_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004276 RID: 17014
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004277 RID: 17015
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04004278 RID: 17016
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x04004279 RID: 17017
			private static readonly IntPtr NativeFieldInfoPtr___9__11_3;

			// Token: 0x0400427A RID: 17018
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x0400427B RID: 17019
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x0400427C RID: 17020
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x0400427D RID: 17021
			private static readonly IntPtr NativeFieldInfoPtr___9__14_4;

			// Token: 0x0400427E RID: 17022
			private static readonly IntPtr NativeFieldInfoPtr___9__14_5;

			// Token: 0x0400427F RID: 17023
			private static readonly IntPtr NativeFieldInfoPtr___9__14_6;

			// Token: 0x04004280 RID: 17024
			private static readonly IntPtr NativeFieldInfoPtr___9__16_6;

			// Token: 0x04004281 RID: 17025
			private static readonly IntPtr NativeFieldInfoPtr___9__16_8;

			// Token: 0x04004282 RID: 17026
			private static readonly IntPtr NativeFieldInfoPtr___9__16_7;

			// Token: 0x04004283 RID: 17027
			private static readonly IntPtr NativeFieldInfoPtr___9__16_9;

			// Token: 0x04004284 RID: 17028
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04004285 RID: 17029
			private static readonly IntPtr NativeFieldInfoPtr___9__16_12;

			// Token: 0x04004286 RID: 17030
			private static readonly IntPtr NativeFieldInfoPtr___9__16_14;

			// Token: 0x04004287 RID: 17031
			private static readonly IntPtr NativeFieldInfoPtr___9__16_1;

			// Token: 0x04004288 RID: 17032
			private static readonly IntPtr NativeFieldInfoPtr___9__16_2;

			// Token: 0x04004289 RID: 17033
			private static readonly IntPtr NativeFieldInfoPtr___9__16_3;

			// Token: 0x0400428A RID: 17034
			private static readonly IntPtr NativeFieldInfoPtr___9__16_4;

			// Token: 0x0400428B RID: 17035
			private static readonly IntPtr NativeFieldInfoPtr___9__16_5;

			// Token: 0x0400428C RID: 17036
			private static readonly IntPtr NativeFieldInfoPtr___9__16_15;

			// Token: 0x0400428D RID: 17037
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400428E RID: 17038
			private static readonly IntPtr NativeMethodInfoPtr__PrePlayerTurn_b__10_0_Internal_Boolean_Entity_0;

			// Token: 0x0400428F RID: 17039
			private static readonly IntPtr NativeMethodInfoPtr__DetermineTurn_b__11_2_Internal_EntityID_AbilityDefinitionForGame_1_WormMatch_0;

			// Token: 0x04004290 RID: 17040
			private static readonly IntPtr NativeMethodInfoPtr__DetermineTurn_b__11_3_Internal_Boolean_Entity_0;

			// Token: 0x04004291 RID: 17041
			private static readonly IntPtr NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_0_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0;

			// Token: 0x04004292 RID: 17042
			private static readonly IntPtr NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_1_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0;

			// Token: 0x04004293 RID: 17043
			private static readonly IntPtr NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_2_Internal_EntityID_AbilityDefinitionForGame_1_WormMatch_0;

			// Token: 0x04004294 RID: 17044
			private static readonly IntPtr NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_4_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0;

			// Token: 0x04004295 RID: 17045
			private static readonly IntPtr NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_5_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0;

			// Token: 0x04004296 RID: 17046
			private static readonly IntPtr NativeMethodInfoPtr__ResolveDeferredAbilities_b__14_6_Internal_Boolean_AbilityDefinitionForGame_1_WormMatch_0;

			// Token: 0x04004297 RID: 17047
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_6_Internal_Boolean_Entity_0;

			// Token: 0x04004298 RID: 17048
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_8_Internal_Boolean_Entity_0;

			// Token: 0x04004299 RID: 17049
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_7_Internal_Boolean_Entity_0;

			// Token: 0x0400429A RID: 17050
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_9_Internal_IEnumerable_1_WormAbilityDefinition_WormPlayable_0;

			// Token: 0x0400429B RID: 17051
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_0_Internal_Boolean_Entity_0;

			// Token: 0x0400429C RID: 17052
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_12_Internal_Boolean_Entity_0;

			// Token: 0x0400429D RID: 17053
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_14_Internal_Boolean_WormUnit_0;

			// Token: 0x0400429E RID: 17054
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_1_Internal_Boolean_WormImperiumPlayable_0;

			// Token: 0x0400429F RID: 17055
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_2_Internal_IEnumerable_1_WormAbilityDefinition_WormSpace_0;

			// Token: 0x040042A0 RID: 17056
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_3_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x040042A1 RID: 17057
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_4_Internal_Boolean_WormSpace_0;

			// Token: 0x040042A2 RID: 17058
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_5_Internal_Boolean_WormSpace_0;

			// Token: 0x040042A3 RID: 17059
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__16_15_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x02000746 RID: 1862
		[ObfuscatedName("worm.canis.actions.phases.PlayerTurnPhase+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x06006701 RID: 26369 RVA: 0x001EDF5C File Offset: 0x001EC15C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<PlayerTurnPhase.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTurnPhase.__c__DisplayClass16_0>.NativeClassPtr);
				PlayerTurnPhase.__c__DisplayClass16_0.NativeFieldInfoPtr_blockExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase.__c__DisplayClass16_0>.NativeClassPtr, "blockExceptions");
				PlayerTurnPhase.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c__DisplayClass16_0>.NativeClassPtr, 100669814);
				PlayerTurnPhase.__c__DisplayClass16_0.NativeMethodInfoPtr__Cleanup_b__13_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase.__c__DisplayClass16_0>.NativeClassPtr, 100669815);
			}

			// Token: 0x06006702 RID: 26370 RVA: 0x001EDFC4 File Offset: 0x001EC1C4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTurnPhase.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006703 RID: 26371 RVA: 0x001EE000 File Offset: 0x001EC200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159897, XrefRangeEnd = 159915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Cleanup_b__13(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase.__c__DisplayClass16_0.NativeMethodInfoPtr__Cleanup_b__13_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006704 RID: 26372 RVA: 0x000281D7 File Offset: 0x000263D7
			public __c__DisplayClass16_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BC0 RID: 7104
			// (get) Token: 0x06006705 RID: 26373 RVA: 0x001EE050 File Offset: 0x001EC250
			// (set) Token: 0x06006706 RID: 26374 RVA: 0x000281E0 File Offset: 0x000263E0
			public unsafe List<AccountID> blockExceptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase.__c__DisplayClass16_0.NativeFieldInfoPtr_blockExceptions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase.__c__DisplayClass16_0.NativeFieldInfoPtr_blockExceptions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042A4 RID: 17060
			private static readonly IntPtr NativeFieldInfoPtr_blockExceptions;

			// Token: 0x040042A5 RID: 17061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040042A6 RID: 17062
			private static readonly IntPtr NativeMethodInfoPtr__Cleanup_b__13_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000747 RID: 1863
		[ObfuscatedName("worm.canis.actions.phases.PlayerTurnPhase+<Cleanup>d__16")]
		public sealed class _Cleanup_d__16 : Object
		{
			// Token: 0x06006707 RID: 26375 RVA: 0x001EE080 File Offset: 0x001EC280
			// Note: this type is marked as 'beforefieldinit'.
			static _Cleanup_d__16()
			{
				Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "<Cleanup>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr);
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>1__state");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>2__current");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>l__initialThreadId");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>4__this");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__turnAchievements_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<turnAchievements>5__2");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__TSMFBaseCost_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<TSMFBaseCost>5__3");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__toDiscard_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<toDiscard>5__4");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>7__wrap4");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>7__wrap5");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>7__wrap6");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>7__wrap7");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__discountedCard_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<discountedCard>5__9");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>7__wrap9");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>7__wrap10");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>7__wrap11");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__card_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<card>5__13");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>7__wrap13");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<>7__wrap14");
				PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__lastRoundSequence_5__16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, "<lastRoundSequence>5__16");
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669816);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669817);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669818);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669819);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669820);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669821);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669822);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669823);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669824);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669825);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669826);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally9_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669827);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally10_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669828);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally11_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669829);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally12_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669830);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally13_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669831);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669832);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669833);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669834);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669835);
				PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr, 100669836);
			}

			// Token: 0x06006708 RID: 26376 RVA: 0x001EE3CC File Offset: 0x001EC5CC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Cleanup_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTurnPhase._Cleanup_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006709 RID: 26377 RVA: 0x001EE414 File Offset: 0x001EC614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159915, XrefRangeEnd = 159975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600670A RID: 26378 RVA: 0x001EE448 File Offset: 0x001EC648
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159975, XrefRangeEnd = 161788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600670B RID: 26379 RVA: 0x001EE484 File Offset: 0x001EC684
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161788, XrefRangeEnd = 161791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600670C RID: 26380 RVA: 0x001EE4B8 File Offset: 0x001EC6B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 161794, RefRangeEnd = 161795, XrefRangeStart = 161791, XrefRangeEnd = 161794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600670D RID: 26381 RVA: 0x001EE4EC File Offset: 0x001EC6EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 161798, RefRangeEnd = 161799, XrefRangeStart = 161795, XrefRangeEnd = 161798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600670E RID: 26382 RVA: 0x001EE520 File Offset: 0x001EC720
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161799, XrefRangeEnd = 161802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600670F RID: 26383 RVA: 0x001EE554 File Offset: 0x001EC754
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161802, XrefRangeEnd = 161805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006710 RID: 26384 RVA: 0x001EE588 File Offset: 0x001EC788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161805, XrefRangeEnd = 161808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006711 RID: 26385 RVA: 0x001EE5BC File Offset: 0x001EC7BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161808, XrefRangeEnd = 161811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006712 RID: 26386 RVA: 0x001EE5F0 File Offset: 0x001EC7F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 161814, RefRangeEnd = 161815, XrefRangeStart = 161811, XrefRangeEnd = 161814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006713 RID: 26387 RVA: 0x001EE624 File Offset: 0x001EC824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161815, XrefRangeEnd = 161818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally9_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006714 RID: 26388 RVA: 0x001EE658 File Offset: 0x001EC858
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 161821, RefRangeEnd = 161822, XrefRangeStart = 161818, XrefRangeEnd = 161821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally10_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006715 RID: 26389 RVA: 0x001EE68C File Offset: 0x001EC88C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161822, XrefRangeEnd = 161825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally11_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006716 RID: 26390 RVA: 0x001EE6C0 File Offset: 0x001EC8C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161825, XrefRangeEnd = 161828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally12_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006717 RID: 26391 RVA: 0x001EE6F4 File Offset: 0x001EC8F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 161831, RefRangeEnd = 161832, XrefRangeStart = 161828, XrefRangeEnd = 161831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally13()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr___m__Finally13_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BD4 RID: 7124
			// (get) Token: 0x06006718 RID: 26392 RVA: 0x001EE728 File Offset: 0x001EC928
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006719 RID: 26393 RVA: 0x001EE768 File Offset: 0x001EC968
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161832, XrefRangeEnd = 161837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BD5 RID: 7125
			// (get) Token: 0x0600671A RID: 26394 RVA: 0x001EE79C File Offset: 0x001EC99C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600671B RID: 26395 RVA: 0x001EE7DC File Offset: 0x001EC9DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161837, XrefRangeEnd = 161839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600671C RID: 26396 RVA: 0x001EE81C File Offset: 0x001ECA1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._Cleanup_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600671D RID: 26397 RVA: 0x000281FF File Offset: 0x000263FF
			public _Cleanup_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BC1 RID: 7105
			// (get) Token: 0x0600671E RID: 26398 RVA: 0x001EE85C File Offset: 0x001ECA5C
			// (set) Token: 0x0600671F RID: 26399 RVA: 0x00028208 File Offset: 0x00026408
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BC2 RID: 7106
			// (get) Token: 0x06006720 RID: 26400 RVA: 0x001EE884 File Offset: 0x001ECA84
			// (set) Token: 0x06006721 RID: 26401 RVA: 0x00028223 File Offset: 0x00026423
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BC3 RID: 7107
			// (get) Token: 0x06006722 RID: 26402 RVA: 0x001EE8B4 File Offset: 0x001ECAB4
			// (set) Token: 0x06006723 RID: 26403 RVA: 0x00028242 File Offset: 0x00026442
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001BC4 RID: 7108
			// (get) Token: 0x06006724 RID: 26404 RVA: 0x001EE8DC File Offset: 0x001ECADC
			// (set) Token: 0x06006725 RID: 26405 RVA: 0x0002825D File Offset: 0x0002645D
			public unsafe PlayerTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BC5 RID: 7109
			// (get) Token: 0x06006726 RID: 26406 RVA: 0x001EE90C File Offset: 0x001ECB0C
			// (set) Token: 0x06006727 RID: 26407 RVA: 0x0002827C File Offset: 0x0002647C
			public unsafe List<string> _turnAchievements_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__turnAchievements_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__turnAchievements_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BC6 RID: 7110
			// (get) Token: 0x06006728 RID: 26408 RVA: 0x001EE93C File Offset: 0x001ECB3C
			// (set) Token: 0x06006729 RID: 26409 RVA: 0x0002829B File Offset: 0x0002649B
			public unsafe int _TSMFBaseCost_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__TSMFBaseCost_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__TSMFBaseCost_5__3)) = value;
				}
			}

			// Token: 0x17001BC7 RID: 7111
			// (get) Token: 0x0600672A RID: 26410 RVA: 0x001EE964 File Offset: 0x001ECB64
			// (set) Token: 0x0600672B RID: 26411 RVA: 0x000282B6 File Offset: 0x000264B6
			public unsafe Il2CppReferenceArray<Entity> _toDiscard_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__toDiscard_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__toDiscard_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BC8 RID: 7112
			// (get) Token: 0x0600672C RID: 26412 RVA: 0x001EE994 File Offset: 0x001ECB94
			// (set) Token: 0x0600672D RID: 26413 RVA: 0x000282D5 File Offset: 0x000264D5
			public unsafe IEnumerator<Entity> __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Entity>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BC9 RID: 7113
			// (get) Token: 0x0600672E RID: 26414 RVA: 0x001EE9C4 File Offset: 0x001ECBC4
			// (set) Token: 0x0600672F RID: 26415 RVA: 0x000282F4 File Offset: 0x000264F4
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BCA RID: 7114
			// (get) Token: 0x06006730 RID: 26416 RVA: 0x001EE9F4 File Offset: 0x001ECBF4
			// (set) Token: 0x06006731 RID: 26417 RVA: 0x00028313 File Offset: 0x00026513
			public unsafe IEnumerator<WormAbilityDefinition> __7__wrap6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormAbilityDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BCB RID: 7115
			// (get) Token: 0x06006732 RID: 26418 RVA: 0x001EEA24 File Offset: 0x001ECC24
			// (set) Token: 0x06006733 RID: 26419 RVA: 0x00028332 File Offset: 0x00026532
			public unsafe IEnumerator<WormPlayable> __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BCC RID: 7116
			// (get) Token: 0x06006734 RID: 26420 RVA: 0x001EEA54 File Offset: 0x001ECC54
			// (set) Token: 0x06006735 RID: 26421 RVA: 0x00028351 File Offset: 0x00026551
			public unsafe Entity _discountedCard_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__discountedCard_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__discountedCard_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BCD RID: 7117
			// (get) Token: 0x06006736 RID: 26422 RVA: 0x001EEA84 File Offset: 0x001ECC84
			// (set) Token: 0x06006737 RID: 26423 RVA: 0x00028370 File Offset: 0x00026570
			public unsafe IEnumerator<WormAgent> __7__wrap9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormAgent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BCE RID: 7118
			// (get) Token: 0x06006738 RID: 26424 RVA: 0x001EEAB4 File Offset: 0x001ECCB4
			// (set) Token: 0x06006739 RID: 26425 RVA: 0x0002838F File Offset: 0x0002658F
			public unsafe IEnumerator<WormUnit> __7__wrap10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormUnit>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BCF RID: 7119
			// (get) Token: 0x0600673A RID: 26426 RVA: 0x001EEAE4 File Offset: 0x001ECCE4
			// (set) Token: 0x0600673B RID: 26427 RVA: 0x000283AE File Offset: 0x000265AE
			public List<EntityID>.Enumerator __7__wrap11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap11);
					return new List<EntityID>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<EntityID>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap11), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<EntityID>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001BD0 RID: 7120
			// (get) Token: 0x0600673C RID: 26428 RVA: 0x001EEB14 File Offset: 0x001ECD14
			// (set) Token: 0x0600673D RID: 26429 RVA: 0x000283DC File Offset: 0x000265DC
			public unsafe WormImperiumPlayable _card_5__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__card_5__13);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormImperiumPlayable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__card_5__13), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BD1 RID: 7121
			// (get) Token: 0x0600673E RID: 26430 RVA: 0x001EEB44 File Offset: 0x001ECD44
			// (set) Token: 0x0600673F RID: 26431 RVA: 0x000283FB File Offset: 0x000265FB
			public unsafe IEnumerator<WormImperiumPlayable> __7__wrap13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap13);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormImperiumPlayable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap13), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BD2 RID: 7122
			// (get) Token: 0x06006740 RID: 26432 RVA: 0x001EEB74 File Offset: 0x001ECD74
			// (set) Token: 0x06006741 RID: 26433 RVA: 0x0002841A File Offset: 0x0002661A
			public List<WormPlayer>.Enumerator __7__wrap14
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap14);
					return new List<WormPlayer>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr___7__wrap14), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001BD3 RID: 7123
			// (get) Token: 0x06006742 RID: 26434 RVA: 0x001EEBA4 File Offset: 0x001ECDA4
			// (set) Token: 0x06006743 RID: 26435 RVA: 0x00028448 File Offset: 0x00026648
			public unsafe SequenceHelper _lastRoundSequence_5__16
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__lastRoundSequence_5__16);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SequenceHelper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._Cleanup_d__16.NativeFieldInfoPtr__lastRoundSequence_5__16), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042A7 RID: 17063
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040042A8 RID: 17064
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040042A9 RID: 17065
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040042AA RID: 17066
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040042AB RID: 17067
			private static readonly IntPtr NativeFieldInfoPtr__turnAchievements_5__2;

			// Token: 0x040042AC RID: 17068
			private static readonly IntPtr NativeFieldInfoPtr__TSMFBaseCost_5__3;

			// Token: 0x040042AD RID: 17069
			private static readonly IntPtr NativeFieldInfoPtr__toDiscard_5__4;

			// Token: 0x040042AE RID: 17070
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040042AF RID: 17071
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x040042B0 RID: 17072
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap6;

			// Token: 0x040042B1 RID: 17073
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x040042B2 RID: 17074
			private static readonly IntPtr NativeFieldInfoPtr__discountedCard_5__9;

			// Token: 0x040042B3 RID: 17075
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap9;

			// Token: 0x040042B4 RID: 17076
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap10;

			// Token: 0x040042B5 RID: 17077
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap11;

			// Token: 0x040042B6 RID: 17078
			private static readonly IntPtr NativeFieldInfoPtr__card_5__13;

			// Token: 0x040042B7 RID: 17079
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap13;

			// Token: 0x040042B8 RID: 17080
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap14;

			// Token: 0x040042B9 RID: 17081
			private static readonly IntPtr NativeFieldInfoPtr__lastRoundSequence_5__16;

			// Token: 0x040042BA RID: 17082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040042BB RID: 17083
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042BC RID: 17084
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040042BD RID: 17085
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040042BE RID: 17086
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040042BF RID: 17087
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x040042C0 RID: 17088
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x040042C1 RID: 17089
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally5_Private_Void_0;

			// Token: 0x040042C2 RID: 17090
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally6_Private_Void_0;

			// Token: 0x040042C3 RID: 17091
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally7_Private_Void_0;

			// Token: 0x040042C4 RID: 17092
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally8_Private_Void_0;

			// Token: 0x040042C5 RID: 17093
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally9_Private_Void_0;

			// Token: 0x040042C6 RID: 17094
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally10_Private_Void_0;

			// Token: 0x040042C7 RID: 17095
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally11_Private_Void_0;

			// Token: 0x040042C8 RID: 17096
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally12_Private_Void_0;

			// Token: 0x040042C9 RID: 17097
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally13_Private_Void_0;

			// Token: 0x040042CA RID: 17098
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040042CB RID: 17099
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042CC RID: 17100
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040042CD RID: 17101
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040042CE RID: 17102
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000748 RID: 1864
		[ObfuscatedName("worm.canis.actions.phases.PlayerTurnPhase+<DetermineTurn>d__11")]
		public sealed class _DetermineTurn_d__11 : Object
		{
			// Token: 0x06006744 RID: 26436 RVA: 0x001EEBD4 File Offset: 0x001ECDD4
			// Note: this type is marked as 'beforefieldinit'.
			static _DetermineTurn_d__11()
			{
				Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "<DetermineTurn>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr);
				PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, "<>1__state");
				PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, "<>2__current");
				PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, "<>l__initialThreadId");
				PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, "<>4__this");
				PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr__prePlayerTurnSelections_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, "<prePlayerTurnSelections>5__2");
				PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr__picker_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, "<picker>5__3");
				PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, "<>7__wrap3");
				PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, "<>7__wrap4");
				PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, 100669837);
				PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, 100669838);
				PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, 100669839);
				PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, 100669840);
				PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, 100669841);
				PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, 100669842);
				PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, 100669843);
				PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, 100669844);
				PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, 100669845);
				PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr, 100669846);
			}

			// Token: 0x06006745 RID: 26437 RVA: 0x001EED68 File Offset: 0x001ECF68
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DetermineTurn_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTurnPhase._DetermineTurn_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006746 RID: 26438 RVA: 0x001EEDB0 File Offset: 0x001ECFB0
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006747 RID: 26439 RVA: 0x001EEDE4 File Offset: 0x001ECFE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161839, XrefRangeEnd = 162083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006748 RID: 26440 RVA: 0x001EEE20 File Offset: 0x001ED020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162083, XrefRangeEnd = 162086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006749 RID: 26441 RVA: 0x001EEE54 File Offset: 0x001ED054
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 162089, RefRangeEnd = 162090, XrefRangeStart = 162086, XrefRangeEnd = 162089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BDE RID: 7134
			// (get) Token: 0x0600674A RID: 26442 RVA: 0x001EEE88 File Offset: 0x001ED088
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x0600674B RID: 26443 RVA: 0x001EEEC8 File Offset: 0x001ED0C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162090, XrefRangeEnd = 162095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BDF RID: 7135
			// (get) Token: 0x0600674C RID: 26444 RVA: 0x001EEEFC File Offset: 0x001ED0FC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600674D RID: 26445 RVA: 0x001EEF3C File Offset: 0x001ED13C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162095, XrefRangeEnd = 162097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600674E RID: 26446 RVA: 0x001EEF7C File Offset: 0x001ED17C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._DetermineTurn_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600674F RID: 26447 RVA: 0x00028467 File Offset: 0x00026667
			public _DetermineTurn_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BD6 RID: 7126
			// (get) Token: 0x06006750 RID: 26448 RVA: 0x001EEFBC File Offset: 0x001ED1BC
			// (set) Token: 0x06006751 RID: 26449 RVA: 0x00028470 File Offset: 0x00026670
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BD7 RID: 7127
			// (get) Token: 0x06006752 RID: 26450 RVA: 0x001EEFE4 File Offset: 0x001ED1E4
			// (set) Token: 0x06006753 RID: 26451 RVA: 0x0002848B File Offset: 0x0002668B
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BD8 RID: 7128
			// (get) Token: 0x06006754 RID: 26452 RVA: 0x001EF014 File Offset: 0x001ED214
			// (set) Token: 0x06006755 RID: 26453 RVA: 0x000284AA File Offset: 0x000266AA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001BD9 RID: 7129
			// (get) Token: 0x06006756 RID: 26454 RVA: 0x001EF03C File Offset: 0x001ED23C
			// (set) Token: 0x06006757 RID: 26455 RVA: 0x000284C5 File Offset: 0x000266C5
			public unsafe PlayerTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BDA RID: 7130
			// (get) Token: 0x06006758 RID: 26456 RVA: 0x001EF06C File Offset: 0x001ED26C
			// (set) Token: 0x06006759 RID: 26457 RVA: 0x000284E4 File Offset: 0x000266E4
			public unsafe List<AbilityDefinitionForGame<WormMatch>> _prePlayerTurnSelections_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr__prePlayerTurnSelections_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AbilityDefinitionForGame<WormMatch>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr__prePlayerTurnSelections_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BDB RID: 7131
			// (get) Token: 0x0600675A RID: 26458 RVA: 0x001EF09C File Offset: 0x001ED29C
			// (set) Token: 0x0600675B RID: 26459 RVA: 0x00028503 File Offset: 0x00026703
			public unsafe TargetPicker<EntityIDTargetResponses> _picker_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr__picker_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetPicker<EntityIDTargetResponses>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr__picker_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BDC RID: 7132
			// (get) Token: 0x0600675C RID: 26460 RVA: 0x001EF0CC File Offset: 0x001ED2CC
			// (set) Token: 0x0600675D RID: 26461 RVA: 0x00028522 File Offset: 0x00026722
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BDD RID: 7133
			// (get) Token: 0x0600675E RID: 26462 RVA: 0x001EF0FC File Offset: 0x001ED2FC
			// (set) Token: 0x0600675F RID: 26463 RVA: 0x00028541 File Offset: 0x00026741
			public List<WormPlayer>.Enumerator __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___7__wrap4);
					return new List<WormPlayer>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._DetermineTurn_d__11.NativeFieldInfoPtr___7__wrap4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040042CF RID: 17103
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040042D0 RID: 17104
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040042D1 RID: 17105
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040042D2 RID: 17106
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040042D3 RID: 17107
			private static readonly IntPtr NativeFieldInfoPtr__prePlayerTurnSelections_5__2;

			// Token: 0x040042D4 RID: 17108
			private static readonly IntPtr NativeFieldInfoPtr__picker_5__3;

			// Token: 0x040042D5 RID: 17109
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040042D6 RID: 17110
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040042D7 RID: 17111
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040042D8 RID: 17112
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042D9 RID: 17113
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040042DA RID: 17114
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040042DB RID: 17115
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040042DC RID: 17116
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040042DD RID: 17117
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042DE RID: 17118
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040042DF RID: 17119
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040042E0 RID: 17120
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000749 RID: 1865
		[ObfuscatedName("worm.canis.actions.phases.PlayerTurnPhase+<PrePlayerTurn>d__10")]
		public sealed class _PrePlayerTurn_d__10 : Object
		{
			// Token: 0x06006760 RID: 26464 RVA: 0x001EF12C File Offset: 0x001ED32C
			// Note: this type is marked as 'beforefieldinit'.
			static _PrePlayerTurn_d__10()
			{
				Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "<PrePlayerTurn>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr);
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, "<>1__state");
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, "<>2__current");
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, "<>l__initialThreadId");
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, "<>4__this");
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr__extraTurnsStacked_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, "<extraTurnsStacked>5__2");
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, "<>7__wrap2");
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, "<>7__wrap3");
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, 100669847);
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, 100669848);
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, 100669849);
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, 100669850);
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, 100669851);
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, 100669852);
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, 100669853);
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, 100669854);
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, 100669855);
				PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr, 100669856);
			}

			// Token: 0x06006761 RID: 26465 RVA: 0x001EF2AC File Offset: 0x001ED4AC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _PrePlayerTurn_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTurnPhase._PrePlayerTurn_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006762 RID: 26466 RVA: 0x001EF2F4 File Offset: 0x001ED4F4
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006763 RID: 26467 RVA: 0x001EF328 File Offset: 0x001ED528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162097, XrefRangeEnd = 162356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006764 RID: 26468 RVA: 0x001EF364 File Offset: 0x001ED564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162356, XrefRangeEnd = 162359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006765 RID: 26469 RVA: 0x001EF398 File Offset: 0x001ED598
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 162362, RefRangeEnd = 162363, XrefRangeStart = 162359, XrefRangeEnd = 162362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BE7 RID: 7143
			// (get) Token: 0x06006766 RID: 26470 RVA: 0x001EF3CC File Offset: 0x001ED5CC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006767 RID: 26471 RVA: 0x001EF40C File Offset: 0x001ED60C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162363, XrefRangeEnd = 162368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BE8 RID: 7144
			// (get) Token: 0x06006768 RID: 26472 RVA: 0x001EF440 File Offset: 0x001ED640
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006769 RID: 26473 RVA: 0x001EF480 File Offset: 0x001ED680
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162368, XrefRangeEnd = 162370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x0600676A RID: 26474 RVA: 0x001EF4C0 File Offset: 0x001ED6C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._PrePlayerTurn_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600676B RID: 26475 RVA: 0x0002856F File Offset: 0x0002676F
			public _PrePlayerTurn_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BE0 RID: 7136
			// (get) Token: 0x0600676C RID: 26476 RVA: 0x001EF500 File Offset: 0x001ED700
			// (set) Token: 0x0600676D RID: 26477 RVA: 0x00028578 File Offset: 0x00026778
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BE1 RID: 7137
			// (get) Token: 0x0600676E RID: 26478 RVA: 0x001EF528 File Offset: 0x001ED728
			// (set) Token: 0x0600676F RID: 26479 RVA: 0x00028593 File Offset: 0x00026793
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BE2 RID: 7138
			// (get) Token: 0x06006770 RID: 26480 RVA: 0x001EF558 File Offset: 0x001ED758
			// (set) Token: 0x06006771 RID: 26481 RVA: 0x000285B2 File Offset: 0x000267B2
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001BE3 RID: 7139
			// (get) Token: 0x06006772 RID: 26482 RVA: 0x001EF580 File Offset: 0x001ED780
			// (set) Token: 0x06006773 RID: 26483 RVA: 0x000285CD File Offset: 0x000267CD
			public unsafe PlayerTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BE4 RID: 7140
			// (get) Token: 0x06006774 RID: 26484 RVA: 0x001EF5B0 File Offset: 0x001ED7B0
			// (set) Token: 0x06006775 RID: 26485 RVA: 0x000285EC File Offset: 0x000267EC
			public unsafe int _extraTurnsStacked_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr__extraTurnsStacked_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr__extraTurnsStacked_5__2)) = value;
				}
			}

			// Token: 0x17001BE5 RID: 7141
			// (get) Token: 0x06006776 RID: 26486 RVA: 0x001EF5D8 File Offset: 0x001ED7D8
			// (set) Token: 0x06006777 RID: 26487 RVA: 0x00028607 File Offset: 0x00026807
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BE6 RID: 7142
			// (get) Token: 0x06006778 RID: 26488 RVA: 0x001EF608 File Offset: 0x001ED808
			// (set) Token: 0x06006779 RID: 26489 RVA: 0x00028626 File Offset: 0x00026826
			public List<Entity>.Enumerator __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___7__wrap3);
					return new List<Entity>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._PrePlayerTurn_d__10.NativeFieldInfoPtr___7__wrap3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Entity>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040042E1 RID: 17121
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040042E2 RID: 17122
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040042E3 RID: 17123
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040042E4 RID: 17124
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040042E5 RID: 17125
			private static readonly IntPtr NativeFieldInfoPtr__extraTurnsStacked_5__2;

			// Token: 0x040042E6 RID: 17126
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040042E7 RID: 17127
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040042E8 RID: 17128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040042E9 RID: 17129
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042EA RID: 17130
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040042EB RID: 17131
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040042EC RID: 17132
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040042ED RID: 17133
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040042EE RID: 17134
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042EF RID: 17135
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040042F0 RID: 17136
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040042F1 RID: 17137
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200074A RID: 1866
		[ObfuscatedName("worm.canis.actions.phases.PlayerTurnPhase+<ResolveDeferredAbilities>d__14")]
		public sealed class _ResolveDeferredAbilities_d__14 : Object
		{
			// Token: 0x0600677A RID: 26490 RVA: 0x001EF638 File Offset: 0x001ED838
			// Note: this type is marked as 'beforefieldinit'.
			static _ResolveDeferredAbilities_d__14()
			{
				Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "<ResolveDeferredAbilities>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr);
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, "<>1__state");
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, "<>2__current");
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, "<>l__initialThreadId");
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, "<>4__this");
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__playerTurnType_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, "<playerTurnType>5__2");
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__deferredAbilitySelections_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, "<deferredAbilitySelections>5__3");
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__forced_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, "<forced>5__4");
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__prompt_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, "<prompt>5__5");
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__picker_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, "<picker>5__6");
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, "<>7__wrap6");
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___7__wrap7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, "<>7__wrap7");
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, 100669857);
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, 100669858);
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, 100669859);
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, 100669860);
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, 100669861);
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, 100669862);
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, 100669863);
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, 100669864);
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, 100669865);
				PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr, 100669866);
			}

			// Token: 0x0600677B RID: 26491 RVA: 0x001EF808 File Offset: 0x001EDA08
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResolveDeferredAbilities_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDeferredAbilities_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600677C RID: 26492 RVA: 0x001EF850 File Offset: 0x001EDA50
			[CallerCount(0)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600677D RID: 26493 RVA: 0x001EF884 File Offset: 0x001EDA84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162370, XrefRangeEnd = 162801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600677E RID: 26494 RVA: 0x001EF8C0 File Offset: 0x001EDAC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162801, XrefRangeEnd = 162804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600677F RID: 26495 RVA: 0x001EF8F4 File Offset: 0x001EDAF4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 162807, RefRangeEnd = 162808, XrefRangeStart = 162804, XrefRangeEnd = 162807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BF4 RID: 7156
			// (get) Token: 0x06006780 RID: 26496 RVA: 0x001EF928 File Offset: 0x001EDB28
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006781 RID: 26497 RVA: 0x001EF968 File Offset: 0x001EDB68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162808, XrefRangeEnd = 162813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BF5 RID: 7157
			// (get) Token: 0x06006782 RID: 26498 RVA: 0x001EF99C File Offset: 0x001EDB9C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006783 RID: 26499 RVA: 0x001EF9DC File Offset: 0x001EDBDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162813, XrefRangeEnd = 162815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006784 RID: 26500 RVA: 0x001EFA1C File Offset: 0x001EDC1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006785 RID: 26501 RVA: 0x00028654 File Offset: 0x00026854
			public _ResolveDeferredAbilities_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BE9 RID: 7145
			// (get) Token: 0x06006786 RID: 26502 RVA: 0x001EFA5C File Offset: 0x001EDC5C
			// (set) Token: 0x06006787 RID: 26503 RVA: 0x0002865D File Offset: 0x0002685D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BEA RID: 7146
			// (get) Token: 0x06006788 RID: 26504 RVA: 0x001EFA84 File Offset: 0x001EDC84
			// (set) Token: 0x06006789 RID: 26505 RVA: 0x00028678 File Offset: 0x00026878
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BEB RID: 7147
			// (get) Token: 0x0600678A RID: 26506 RVA: 0x001EFAB4 File Offset: 0x001EDCB4
			// (set) Token: 0x0600678B RID: 26507 RVA: 0x00028697 File Offset: 0x00026897
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001BEC RID: 7148
			// (get) Token: 0x0600678C RID: 26508 RVA: 0x001EFADC File Offset: 0x001EDCDC
			// (set) Token: 0x0600678D RID: 26509 RVA: 0x000286B2 File Offset: 0x000268B2
			public unsafe PlayerTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BED RID: 7149
			// (get) Token: 0x0600678E RID: 26510 RVA: 0x001EFB0C File Offset: 0x001EDD0C
			// (set) Token: 0x0600678F RID: 26511 RVA: 0x000286D1 File Offset: 0x000268D1
			public unsafe PlayerTurnTypes _playerTurnType_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__playerTurnType_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__playerTurnType_5__2)) = value;
				}
			}

			// Token: 0x17001BEE RID: 7150
			// (get) Token: 0x06006790 RID: 26512 RVA: 0x001EFB34 File Offset: 0x001EDD34
			// (set) Token: 0x06006791 RID: 26513 RVA: 0x000286EC File Offset: 0x000268EC
			public unsafe List<AbilityDefinitionForGame<WormMatch>> _deferredAbilitySelections_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__deferredAbilitySelections_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AbilityDefinitionForGame<WormMatch>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__deferredAbilitySelections_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BEF RID: 7151
			// (get) Token: 0x06006792 RID: 26514 RVA: 0x001EFB64 File Offset: 0x001EDD64
			// (set) Token: 0x06006793 RID: 26515 RVA: 0x0002870B File Offset: 0x0002690B
			public unsafe bool _forced_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__forced_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__forced_5__4)) = value;
				}
			}

			// Token: 0x17001BF0 RID: 7152
			// (get) Token: 0x06006794 RID: 26516 RVA: 0x001EFB8C File Offset: 0x001EDD8C
			// (set) Token: 0x06006795 RID: 26517 RVA: 0x00028726 File Offset: 0x00026926
			public unsafe LocalizableTextVariables _prompt_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__prompt_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__prompt_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BF1 RID: 7153
			// (get) Token: 0x06006796 RID: 26518 RVA: 0x001EFBBC File Offset: 0x001EDDBC
			// (set) Token: 0x06006797 RID: 26519 RVA: 0x00028745 File Offset: 0x00026945
			public unsafe TargetPicker<EntityIDTargetResponses> _picker_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__picker_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetPicker<EntityIDTargetResponses>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr__picker_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BF2 RID: 7154
			// (get) Token: 0x06006798 RID: 26520 RVA: 0x001EFBEC File Offset: 0x001EDDEC
			// (set) Token: 0x06006799 RID: 26521 RVA: 0x00028764 File Offset: 0x00026964
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___7__wrap6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___7__wrap6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BF3 RID: 7155
			// (get) Token: 0x0600679A RID: 26522 RVA: 0x001EFC1C File Offset: 0x001EDE1C
			// (set) Token: 0x0600679B RID: 26523 RVA: 0x00028783 File Offset: 0x00026983
			public List<WormPlayer>.Enumerator __7__wrap7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___7__wrap7);
					return new List<WormPlayer>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDeferredAbilities_d__14.NativeFieldInfoPtr___7__wrap7), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040042F2 RID: 17138
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040042F3 RID: 17139
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040042F4 RID: 17140
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040042F5 RID: 17141
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040042F6 RID: 17142
			private static readonly IntPtr NativeFieldInfoPtr__playerTurnType_5__2;

			// Token: 0x040042F7 RID: 17143
			private static readonly IntPtr NativeFieldInfoPtr__deferredAbilitySelections_5__3;

			// Token: 0x040042F8 RID: 17144
			private static readonly IntPtr NativeFieldInfoPtr__forced_5__4;

			// Token: 0x040042F9 RID: 17145
			private static readonly IntPtr NativeFieldInfoPtr__prompt_5__5;

			// Token: 0x040042FA RID: 17146
			private static readonly IntPtr NativeFieldInfoPtr__picker_5__6;

			// Token: 0x040042FB RID: 17147
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap6;

			// Token: 0x040042FC RID: 17148
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap7;

			// Token: 0x040042FD RID: 17149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040042FE RID: 17150
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042FF RID: 17151
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004300 RID: 17152
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004301 RID: 17153
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04004302 RID: 17154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004303 RID: 17155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004304 RID: 17156
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004305 RID: 17157
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004306 RID: 17158
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200074B RID: 1867
		[ObfuscatedName("worm.canis.actions.phases.PlayerTurnPhase+<ResolveDelayedAbilities>d__15")]
		public sealed class _ResolveDelayedAbilities_d__15 : Object
		{
			// Token: 0x0600679C RID: 26524 RVA: 0x001EFC4C File Offset: 0x001EDE4C
			// Note: this type is marked as 'beforefieldinit'.
			static _ResolveDelayedAbilities_d__15()
			{
				Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "<ResolveDelayedAbilities>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr);
				PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr, "<>1__state");
				PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr, "<>2__current");
				PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr, "<>l__initialThreadId");
				PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr, "<>4__this");
				PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr, 100669867);
				PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr, 100669868);
				PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr, 100669869);
				PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr, 100669870);
				PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr, 100669871);
				PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr, 100669872);
				PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr, 100669873);
				PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr, 100669874);
			}

			// Token: 0x0600679D RID: 26525 RVA: 0x001EFD68 File Offset: 0x001EDF68
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResolveDelayedAbilities_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTurnPhase._ResolveDelayedAbilities_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600679E RID: 26526 RVA: 0x001EFDB0 File Offset: 0x001EDFB0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600679F RID: 26527 RVA: 0x001EFDE4 File Offset: 0x001EDFE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162815, XrefRangeEnd = 162849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001BFA RID: 7162
			// (get) Token: 0x060067A0 RID: 26528 RVA: 0x001EFE20 File Offset: 0x001EE020
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060067A1 RID: 26529 RVA: 0x001EFE60 File Offset: 0x001EE060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162849, XrefRangeEnd = 162854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001BFB RID: 7163
			// (get) Token: 0x060067A2 RID: 26530 RVA: 0x001EFE94 File Offset: 0x001EE094
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060067A3 RID: 26531 RVA: 0x001EFED4 File Offset: 0x001EE0D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162854, XrefRangeEnd = 162856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060067A4 RID: 26532 RVA: 0x001EFF14 File Offset: 0x001EE114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060067A5 RID: 26533 RVA: 0x000287B1 File Offset: 0x000269B1
			public _ResolveDelayedAbilities_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BF6 RID: 7158
			// (get) Token: 0x060067A6 RID: 26534 RVA: 0x001EFF54 File Offset: 0x001EE154
			// (set) Token: 0x060067A7 RID: 26535 RVA: 0x000287BA File Offset: 0x000269BA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BF7 RID: 7159
			// (get) Token: 0x060067A8 RID: 26536 RVA: 0x001EFF7C File Offset: 0x001EE17C
			// (set) Token: 0x060067A9 RID: 26537 RVA: 0x000287D5 File Offset: 0x000269D5
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BF8 RID: 7160
			// (get) Token: 0x060067AA RID: 26538 RVA: 0x001EFFAC File Offset: 0x001EE1AC
			// (set) Token: 0x060067AB RID: 26539 RVA: 0x000287F4 File Offset: 0x000269F4
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001BF9 RID: 7161
			// (get) Token: 0x060067AC RID: 26540 RVA: 0x001EFFD4 File Offset: 0x001EE1D4
			// (set) Token: 0x060067AD RID: 26541 RVA: 0x0002880F File Offset: 0x00026A0F
			public unsafe PlayerTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._ResolveDelayedAbilities_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004307 RID: 17159
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004308 RID: 17160
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004309 RID: 17161
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400430A RID: 17162
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400430B RID: 17163
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400430C RID: 17164
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400430D RID: 17165
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400430E RID: 17166
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400430F RID: 17167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004310 RID: 17168
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004311 RID: 17169
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004312 RID: 17170
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200074C RID: 1868
		[ObfuscatedName("worm.canis.actions.phases.PlayerTurnPhase+<TakeAgentTurn>d__12")]
		public sealed class _TakeAgentTurn_d__12 : Object
		{
			// Token: 0x060067AE RID: 26542 RVA: 0x001F0004 File Offset: 0x001EE204
			// Note: this type is marked as 'beforefieldinit'.
			static _TakeAgentTurn_d__12()
			{
				Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "<TakeAgentTurn>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr);
				PlayerTurnPhase._TakeAgentTurn_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr, "<>1__state");
				PlayerTurnPhase._TakeAgentTurn_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr, "<>2__current");
				PlayerTurnPhase._TakeAgentTurn_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr, "<>l__initialThreadId");
				PlayerTurnPhase._TakeAgentTurn_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr, "<>4__this");
				PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr, 100669875);
				PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr, 100669876);
				PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr, 100669877);
				PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr, 100669878);
				PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr, 100669879);
				PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr, 100669880);
				PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr, 100669881);
				PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr, 100669882);
			}

			// Token: 0x060067AF RID: 26543 RVA: 0x001F0120 File Offset: 0x001EE320
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TakeAgentTurn_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTurnPhase._TakeAgentTurn_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060067B0 RID: 26544 RVA: 0x001F0168 File Offset: 0x001EE368
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060067B1 RID: 26545 RVA: 0x001F019C File Offset: 0x001EE39C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162856, XrefRangeEnd = 162870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C00 RID: 7168
			// (get) Token: 0x060067B2 RID: 26546 RVA: 0x001F01D8 File Offset: 0x001EE3D8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060067B3 RID: 26547 RVA: 0x001F0218 File Offset: 0x001EE418
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162870, XrefRangeEnd = 162875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C01 RID: 7169
			// (get) Token: 0x060067B4 RID: 26548 RVA: 0x001F024C File Offset: 0x001EE44C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060067B5 RID: 26549 RVA: 0x001F028C File Offset: 0x001EE48C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162875, XrefRangeEnd = 162877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060067B6 RID: 26550 RVA: 0x001F02CC File Offset: 0x001EE4CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeAgentTurn_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060067B7 RID: 26551 RVA: 0x0002882E File Offset: 0x00026A2E
			public _TakeAgentTurn_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001BFC RID: 7164
			// (get) Token: 0x060067B8 RID: 26552 RVA: 0x001F030C File Offset: 0x001EE50C
			// (set) Token: 0x060067B9 RID: 26553 RVA: 0x00028837 File Offset: 0x00026A37
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeAgentTurn_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeAgentTurn_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001BFD RID: 7165
			// (get) Token: 0x060067BA RID: 26554 RVA: 0x001F0334 File Offset: 0x001EE534
			// (set) Token: 0x060067BB RID: 26555 RVA: 0x00028852 File Offset: 0x00026A52
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeAgentTurn_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeAgentTurn_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001BFE RID: 7166
			// (get) Token: 0x060067BC RID: 26556 RVA: 0x001F0364 File Offset: 0x001EE564
			// (set) Token: 0x060067BD RID: 26557 RVA: 0x00028871 File Offset: 0x00026A71
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeAgentTurn_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeAgentTurn_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001BFF RID: 7167
			// (get) Token: 0x060067BE RID: 26558 RVA: 0x001F038C File Offset: 0x001EE58C
			// (set) Token: 0x060067BF RID: 26559 RVA: 0x0002888C File Offset: 0x00026A8C
			public unsafe PlayerTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeAgentTurn_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeAgentTurn_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004313 RID: 17171
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004314 RID: 17172
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004315 RID: 17173
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004316 RID: 17174
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004317 RID: 17175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004318 RID: 17176
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004319 RID: 17177
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400431A RID: 17178
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400431B RID: 17179
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400431C RID: 17180
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400431D RID: 17181
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400431E RID: 17182
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200074D RID: 1869
		[ObfuscatedName("worm.canis.actions.phases.PlayerTurnPhase+<TakeRevealTurn>d__13")]
		public sealed class _TakeRevealTurn_d__13 : Object
		{
			// Token: 0x060067C0 RID: 26560 RVA: 0x001F03BC File Offset: 0x001EE5BC
			// Note: this type is marked as 'beforefieldinit'.
			static _TakeRevealTurn_d__13()
			{
				Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "<TakeRevealTurn>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr);
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, "<>1__state");
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, "<>2__current");
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, "<>l__initialThreadId");
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, "<>4__this");
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr__initialReveal_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, "<initialReveal>5__2");
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669883);
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669884);
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669885);
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669886);
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669887);
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669888);
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669889);
				PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr, 100669890);
			}

			// Token: 0x060067C1 RID: 26561 RVA: 0x001F04EC File Offset: 0x001EE6EC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TakeRevealTurn_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTurnPhase._TakeRevealTurn_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060067C2 RID: 26562 RVA: 0x001F0534 File Offset: 0x001EE734
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060067C3 RID: 26563 RVA: 0x001F0568 File Offset: 0x001EE768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162877, XrefRangeEnd = 162892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C07 RID: 7175
			// (get) Token: 0x060067C4 RID: 26564 RVA: 0x001F05A4 File Offset: 0x001EE7A4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060067C5 RID: 26565 RVA: 0x001F05E4 File Offset: 0x001EE7E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162892, XrefRangeEnd = 162897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C08 RID: 7176
			// (get) Token: 0x060067C6 RID: 26566 RVA: 0x001F0618 File Offset: 0x001EE818
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060067C7 RID: 26567 RVA: 0x001F0658 File Offset: 0x001EE858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162897, XrefRangeEnd = 162899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060067C8 RID: 26568 RVA: 0x001F0698 File Offset: 0x001EE898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._TakeRevealTurn_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060067C9 RID: 26569 RVA: 0x000288AB File Offset: 0x00026AAB
			public _TakeRevealTurn_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C02 RID: 7170
			// (get) Token: 0x060067CA RID: 26570 RVA: 0x001F06D8 File Offset: 0x001EE8D8
			// (set) Token: 0x060067CB RID: 26571 RVA: 0x000288B4 File Offset: 0x00026AB4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C03 RID: 7171
			// (get) Token: 0x060067CC RID: 26572 RVA: 0x001F0700 File Offset: 0x001EE900
			// (set) Token: 0x060067CD RID: 26573 RVA: 0x000288CF File Offset: 0x00026ACF
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C04 RID: 7172
			// (get) Token: 0x060067CE RID: 26574 RVA: 0x001F0730 File Offset: 0x001EE930
			// (set) Token: 0x060067CF RID: 26575 RVA: 0x000288EE File Offset: 0x00026AEE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C05 RID: 7173
			// (get) Token: 0x060067D0 RID: 26576 RVA: 0x001F0758 File Offset: 0x001EE958
			// (set) Token: 0x060067D1 RID: 26577 RVA: 0x00028909 File Offset: 0x00026B09
			public unsafe PlayerTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C06 RID: 7174
			// (get) Token: 0x060067D2 RID: 26578 RVA: 0x001F0788 File Offset: 0x001EE988
			// (set) Token: 0x060067D3 RID: 26579 RVA: 0x00028928 File Offset: 0x00026B28
			public unsafe bool _initialReveal_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr__initialReveal_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._TakeRevealTurn_d__13.NativeFieldInfoPtr__initialReveal_5__2)) = value;
				}
			}

			// Token: 0x0400431F RID: 17183
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004320 RID: 17184
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004321 RID: 17185
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004322 RID: 17186
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004323 RID: 17187
			private static readonly IntPtr NativeFieldInfoPtr__initialReveal_5__2;

			// Token: 0x04004324 RID: 17188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004325 RID: 17189
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004326 RID: 17190
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004327 RID: 17191
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004328 RID: 17192
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004329 RID: 17193
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400432A RID: 17194
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400432B RID: 17195
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200074E RID: 1870
		[ObfuscatedName("worm.canis.actions.phases.PlayerTurnPhase+<UndoDetermineTurn>d__18")]
		public sealed class _UndoDetermineTurn_d__18 : Object
		{
			// Token: 0x060067D4 RID: 26580 RVA: 0x001F07B0 File Offset: 0x001EE9B0
			// Note: this type is marked as 'beforefieldinit'.
			static _UndoDetermineTurn_d__18()
			{
				Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerTurnPhase>.NativeClassPtr, "<UndoDetermineTurn>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr);
				PlayerTurnPhase._UndoDetermineTurn_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr, "<>1__state");
				PlayerTurnPhase._UndoDetermineTurn_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr, "<>2__current");
				PlayerTurnPhase._UndoDetermineTurn_d__18.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr, "<>l__initialThreadId");
				PlayerTurnPhase._UndoDetermineTurn_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr, "<>4__this");
				PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr, 100669891);
				PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr, 100669892);
				PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr, 100669893);
				PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr, 100669894);
				PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr, 100669895);
				PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr, 100669896);
				PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr, 100669897);
				PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr, 100669898);
			}

			// Token: 0x060067D5 RID: 26581 RVA: 0x001F08CC File Offset: 0x001EEACC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UndoDetermineTurn_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTurnPhase._UndoDetermineTurn_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060067D6 RID: 26582 RVA: 0x001F0914 File Offset: 0x001EEB14
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060067D7 RID: 26583 RVA: 0x001F0948 File Offset: 0x001EEB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162899, XrefRangeEnd = 162929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001C0D RID: 7181
			// (get) Token: 0x060067D8 RID: 26584 RVA: 0x001F0984 File Offset: 0x001EEB84
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060067D9 RID: 26585 RVA: 0x001F09C4 File Offset: 0x001EEBC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162929, XrefRangeEnd = 162941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001C0E RID: 7182
			// (get) Token: 0x060067DA RID: 26586 RVA: 0x001F09F8 File Offset: 0x001EEBF8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060067DB RID: 26587 RVA: 0x001F0A38 File Offset: 0x001EEC38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162941, XrefRangeEnd = 162943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060067DC RID: 26588 RVA: 0x001F0A78 File Offset: 0x001EEC78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060067DD RID: 26589 RVA: 0x00028943 File Offset: 0x00026B43
			public _UndoDetermineTurn_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001C09 RID: 7177
			// (get) Token: 0x060067DE RID: 26590 RVA: 0x001F0AB8 File Offset: 0x001EECB8
			// (set) Token: 0x060067DF RID: 26591 RVA: 0x0002894C File Offset: 0x00026B4C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001C0A RID: 7178
			// (get) Token: 0x060067E0 RID: 26592 RVA: 0x001F0AE0 File Offset: 0x001EECE0
			// (set) Token: 0x060067E1 RID: 26593 RVA: 0x00028967 File Offset: 0x00026B67
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001C0B RID: 7179
			// (get) Token: 0x060067E2 RID: 26594 RVA: 0x001F0B10 File Offset: 0x001EED10
			// (set) Token: 0x060067E3 RID: 26595 RVA: 0x00028986 File Offset: 0x00026B86
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001C0C RID: 7180
			// (get) Token: 0x060067E4 RID: 26596 RVA: 0x001F0B38 File Offset: 0x001EED38
			// (set) Token: 0x060067E5 RID: 26597 RVA: 0x000289A1 File Offset: 0x00026BA1
			public unsafe PlayerTurnPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTurnPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTurnPhase._UndoDetermineTurn_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400432C RID: 17196
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400432D RID: 17197
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400432E RID: 17198
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400432F RID: 17199
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004330 RID: 17200
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004331 RID: 17201
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004332 RID: 17202
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004333 RID: 17203
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004334 RID: 17204
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004335 RID: 17205
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004336 RID: 17206
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004337 RID: 17207
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
