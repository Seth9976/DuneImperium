using System;
using Canis;
using Canis.actions;
using canis.archetypes;
using Canis.entities;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.actions.phases
{
	// Token: 0x020002D9 RID: 729
	public class SetupPhase : StateMachineAction<SetupState>
	{
		// Token: 0x06001DF3 RID: 7667 RVA: 0x000CDC3C File Offset: 0x000CBE3C
		// Note: this type is marked as 'beforefieldinit'.
		static SetupPhase()
		{
			Il2CppClassPointerStore<SetupPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SetupPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr);
			SetupPhase.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "wormMatch");
			SetupPhase.NativeFieldInfoPtr_assignLeaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "assignLeaders");
			SetupPhase.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670112);
			SetupPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedSetupPhase_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670113);
			SetupPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_SetupState_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670114);
			SetupPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_SetupState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670115);
			SetupPhase.NativeMethodInfoPtr_BeginSetup_Protected_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670116);
			SetupPhase.NativeMethodInfoPtr_BeginSetupExtra_Protected_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670117);
			SetupPhase.NativeMethodInfoPtr_CreateDecks_Protected_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670118);
			SetupPhase.NativeMethodInfoPtr_CreateDecksExtra_Protected_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670119);
			SetupPhase.NativeMethodInfoPtr_EmitSerializedGameState_Protected_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670120);
			SetupPhase.NativeMethodInfoPtr_LeaderAssignment_Protected_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670121);
			SetupPhase.NativeMethodInfoPtr_DraftDeckSetup_Protected_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670122);
			SetupPhase.NativeMethodInfoPtr_CompleteSetup_Protected_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670123);
			SetupPhase.NativeMethodInfoPtr_CompleteSetupExtra_Protected_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670124);
			SetupPhase.NativeMethodInfoPtr_AdditionalLeaderSetup_Protected_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670125);
			SetupPhase.NativeMethodInfoPtr_AdditionalLeaderSetup2_Protected_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670126);
			SetupPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670127);
			SetupPhase.NativeMethodInfoPtr__BeginSetup_b__6_0_Private_Archetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670128);
			SetupPhase.NativeMethodInfoPtr__LeaderAssignment_b__11_1_Private_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, 100670129);
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x000CDDFC File Offset: 0x000CBFFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 169559, RefRangeEnd = 169560, XrefRangeStart = 169545, XrefRangeEnd = 169559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetupPhase(WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x000CDE48 File Offset: 0x000CC048
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 169592, RefRangeEnd = 169595, XrefRangeStart = 169560, XrefRangeEnd = 169592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetupPhase(SerializedSetupPhase serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.NativeMethodInfoPtr__ctor_Public_Void_SerializedSetupPhase_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF6 RID: 7670 RVA: 0x000CDEA8 File Offset: 0x000CC0A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169595, XrefRangeEnd = 169698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<SetupState> DetermineNextTypedState(global::Canis.actions.Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetupPhase.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_SetupState_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<SetupState>(intPtr);
			}
		}

		// Token: 0x06001DF7 RID: 7671 RVA: 0x000CDEFC File Offset: 0x000CC0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169698, XrefRangeEnd = 169711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior TypedBehaviorFor(SetupState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetupPhase.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_SetupState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06001DF8 RID: 7672 RVA: 0x000CDF54 File Offset: 0x000CC154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169711, XrefRangeEnd = 169717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> BeginSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.NativeMethodInfoPtr_BeginSetup_Protected_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DF9 RID: 7673 RVA: 0x000CDF94 File Offset: 0x000CC194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169717, XrefRangeEnd = 169722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> BeginSetupExtra()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetupPhase.NativeMethodInfoPtr_BeginSetupExtra_Protected_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x000CDFE0 File Offset: 0x000CC1E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169722, XrefRangeEnd = 169728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> CreateDecks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.NativeMethodInfoPtr_CreateDecks_Protected_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x000CE020 File Offset: 0x000CC220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169728, XrefRangeEnd = 169732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> CreateDecksExtra()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetupPhase.NativeMethodInfoPtr_CreateDecksExtra_Protected_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x000CE06C File Offset: 0x000CC26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169732, XrefRangeEnd = 169737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> EmitSerializedGameState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.NativeMethodInfoPtr_EmitSerializedGameState_Protected_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x000CE0AC File Offset: 0x000CC2AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169737, XrefRangeEnd = 169742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> LeaderAssignment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.NativeMethodInfoPtr_LeaderAssignment_Protected_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x000CE0EC File Offset: 0x000CC2EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169742, XrefRangeEnd = 169747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> DraftDeckSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.NativeMethodInfoPtr_DraftDeckSetup_Protected_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x000CE12C File Offset: 0x000CC32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169747, XrefRangeEnd = 169753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> CompleteSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.NativeMethodInfoPtr_CompleteSetup_Protected_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x000CE16C File Offset: 0x000CC36C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169753, XrefRangeEnd = 169758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<global::Canis.actions.Action> CompleteSetupExtra()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetupPhase.NativeMethodInfoPtr_CompleteSetupExtra_Protected_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x000CE1B8 File Offset: 0x000CC3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169758, XrefRangeEnd = 169764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> AdditionalLeaderSetup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.NativeMethodInfoPtr_AdditionalLeaderSetup_Protected_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x000CE1F8 File Offset: 0x000CC3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169764, XrefRangeEnd = 169770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> AdditionalLeaderSetup2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.NativeMethodInfoPtr_AdditionalLeaderSetup2_Protected_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x000CE238 File Offset: 0x000CC438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169770, XrefRangeEnd = 169798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SetupPhase.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x000CE294 File Offset: 0x000CC494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169798, XrefRangeEnd = 169800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Archetype _BeginSetup_b__6_0(ArchetypeID id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.NativeMethodInfoPtr__BeginSetup_b__6_0_Private_Archetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
			}
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x000CE2E4 File Offset: 0x000CC4E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169800, XrefRangeEnd = 169801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _LeaderAssignment_b__11_1(Archetype _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.NativeMethodInfoPtr__LeaderAssignment_b__11_1_Private_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x0000C910 File Offset: 0x0000AB10
		public SetupPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x000CE334 File Offset: 0x000CC534
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0000C919 File Offset: 0x0000AB19
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x000CE364 File Offset: 0x000CC564
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x0000C938 File Offset: 0x0000AB38
		public unsafe List<AssignLeader> assignLeaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.NativeFieldInfoPtr_assignLeaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AssignLeader>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.NativeFieldInfoPtr_assignLeaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeFieldInfoPtr_assignLeaders;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormMatch_0;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedSetupPhase_WormMatch_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_SetupState_Action_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_SetupState_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_BeginSetup_Protected_IEnumerable_1_Action_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_BeginSetupExtra_Protected_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecks_Protected_IEnumerable_1_Action_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecksExtra_Protected_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_EmitSerializedGameState_Protected_IEnumerable_1_Action_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_LeaderAssignment_Protected_IEnumerable_1_Action_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_DraftDeckSetup_Protected_IEnumerable_1_Action_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSetup_Protected_IEnumerable_1_Action_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_CompleteSetupExtra_Protected_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_AdditionalLeaderSetup_Protected_IEnumerable_1_Action_0;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr_AdditionalLeaderSetup2_Protected_IEnumerable_1_Action_0;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr__BeginSetup_b__6_0_Private_Archetype_ArchetypeID_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr__LeaderAssignment_b__11_1_Private_Boolean_Archetype_0;

		// Token: 0x02000766 RID: 1894
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060069BC RID: 27068 RVA: 0x001F65F8 File Offset: 0x001F47F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr);
				SetupPhase.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9");
				SetupPhase.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__4_0");
				SetupPhase.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__4_1");
				SetupPhase.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__4_2");
				SetupPhase.__c.NativeFieldInfoPtr___9__6_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__6_2");
				SetupPhase.__c.NativeFieldInfoPtr___9__6_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__6_3");
				SetupPhase.__c.NativeFieldInfoPtr___9__6_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__6_4");
				SetupPhase.__c.NativeFieldInfoPtr___9__6_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__6_5");
				SetupPhase.__c.NativeFieldInfoPtr___9__6_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__6_6");
				SetupPhase.__c.NativeFieldInfoPtr___9__6_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__6_7");
				SetupPhase.__c.NativeFieldInfoPtr___9__6_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__6_8");
				SetupPhase.__c.NativeFieldInfoPtr___9__8_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__8_3");
				SetupPhase.__c.NativeFieldInfoPtr___9__8_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__8_20");
				SetupPhase.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__10_0");
				SetupPhase.__c.NativeFieldInfoPtr___9__10_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__10_1");
				SetupPhase.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__11_0");
				SetupPhase.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__11_2");
				SetupPhase.__c.NativeFieldInfoPtr___9__11_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__11_3");
				SetupPhase.__c.NativeFieldInfoPtr___9__11_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__11_4");
				SetupPhase.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__12_0");
				SetupPhase.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__12_1");
				SetupPhase.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__13_1");
				SetupPhase.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__13_0");
				SetupPhase.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__13_2");
				SetupPhase.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, "<>9__13_3");
				SetupPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670131);
				SetupPhase.__c.NativeMethodInfoPtr__DetermineNextTypedState_b__4_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670132);
				SetupPhase.__c.NativeMethodInfoPtr__DetermineNextTypedState_b__4_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670133);
				SetupPhase.__c.NativeMethodInfoPtr__DetermineNextTypedState_b__4_2_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670134);
				SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_2_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670135);
				SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_3_Internal_Boolean_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670136);
				SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_4_Internal_Factions_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670137);
				SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_5_Internal_Int32_Factions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670138);
				SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_6_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670139);
				SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_7_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670140);
				SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_8_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670141);
				SetupPhase.__c.NativeMethodInfoPtr__CreateDecks_b__8_3_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670142);
				SetupPhase.__c.NativeMethodInfoPtr__CreateDecks_b__8_20_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670143);
				SetupPhase.__c.NativeMethodInfoPtr__EmitSerializedGameState_b__10_0_Internal_AccountID_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670144);
				SetupPhase.__c.NativeMethodInfoPtr__EmitSerializedGameState_b__10_1_Internal_PlayerInfoSaveData_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670145);
				SetupPhase.__c.NativeMethodInfoPtr__LeaderAssignment_b__11_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670146);
				SetupPhase.__c.NativeMethodInfoPtr__LeaderAssignment_b__11_2_Internal_ArchetypeID_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670147);
				SetupPhase.__c.NativeMethodInfoPtr__LeaderAssignment_b__11_3_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670148);
				SetupPhase.__c.NativeMethodInfoPtr__LeaderAssignment_b__11_4_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670149);
				SetupPhase.__c.NativeMethodInfoPtr__DraftDeckSetup_b__12_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670150);
				SetupPhase.__c.NativeMethodInfoPtr__DraftDeckSetup_b__12_1_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670151);
				SetupPhase.__c.NativeMethodInfoPtr__CompleteSetup_b__13_1_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670152);
				SetupPhase.__c.NativeMethodInfoPtr__CompleteSetup_b__13_0_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670153);
				SetupPhase.__c.NativeMethodInfoPtr__CompleteSetup_b__13_2_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670154);
				SetupPhase.__c.NativeMethodInfoPtr__CompleteSetup_b__13_3_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr, 100670155);
			}

			// Token: 0x060069BD RID: 27069 RVA: 0x001F6A0C File Offset: 0x001F4C0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060069BE RID: 27070 RVA: 0x001F6A48 File Offset: 0x001F4C48
			[CallerCount(0)]
			public unsafe bool _DetermineNextTypedState_b__4_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__DetermineNextTypedState_b__4_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069BF RID: 27071 RVA: 0x001F6A98 File Offset: 0x001F4C98
			[CallerCount(0)]
			public unsafe bool _DetermineNextTypedState_b__4_1(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__DetermineNextTypedState_b__4_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069C0 RID: 27072 RVA: 0x001F6AE8 File Offset: 0x001F4CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166683, XrefRangeEnd = 166684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineNextTypedState_b__4_2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__DetermineNextTypedState_b__4_2_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069C1 RID: 27073 RVA: 0x001F6B38 File Offset: 0x001F4D38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166684, XrefRangeEnd = 166693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetup_b__6_2(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_2_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069C2 RID: 27074 RVA: 0x001F6B88 File Offset: 0x001F4D88
			[CallerCount(0)]
			public unsafe bool _BeginSetup_b__6_3(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_3_Internal_Boolean_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069C3 RID: 27075 RVA: 0x001F6BD4 File Offset: 0x001F4DD4
			[CallerCount(0)]
			public unsafe Factions _BeginSetup_b__6_4(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_4_Internal_Factions_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069C4 RID: 27076 RVA: 0x001F6C20 File Offset: 0x001F4E20
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _BeginSetup_b__6_5(Factions _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref _;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_5_Internal_Int32_Factions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069C5 RID: 27077 RVA: 0x001F6C6C File Offset: 0x001F4E6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166693, XrefRangeEnd = 166702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetup_b__6_6(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_6_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069C6 RID: 27078 RVA: 0x001F6CBC File Offset: 0x001F4EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166702, XrefRangeEnd = 166711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetup_b__6_7(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_7_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069C7 RID: 27079 RVA: 0x001F6D0C File Offset: 0x001F4F0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166711, XrefRangeEnd = 166720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetup_b__6_8(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__BeginSetup_b__6_8_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069C8 RID: 27080 RVA: 0x001F6D5C File Offset: 0x001F4F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166720, XrefRangeEnd = 166741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__8_3(Archetype arch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__CreateDecks_b__8_3_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069C9 RID: 27081 RVA: 0x001F6DAC File Offset: 0x001F4FAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166741, XrefRangeEnd = 166750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__8_20(Archetype arch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__CreateDecks_b__8_20_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069CA RID: 27082 RVA: 0x001F6DFC File Offset: 0x001F4FFC
			[CallerCount(0)]
			public unsafe AccountID _EmitSerializedGameState_b__10_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__EmitSerializedGameState_b__10_0_Internal_AccountID_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
				}
			}

			// Token: 0x060069CB RID: 27083 RVA: 0x001F6E4C File Offset: 0x001F504C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166750, XrefRangeEnd = 166757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerInfoSaveData _EmitSerializedGameState_b__10_1(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__EmitSerializedGameState_b__10_1_Internal_PlayerInfoSaveData_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerInfoSaveData>(intPtr3) : null;
				}
			}

			// Token: 0x060069CC RID: 27084 RVA: 0x001F6E9C File Offset: 0x001F509C
			[CallerCount(0)]
			public unsafe bool _LeaderAssignment_b__11_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__LeaderAssignment_b__11_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069CD RID: 27085 RVA: 0x001F6EEC File Offset: 0x001F50EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ArchetypeID _LeaderAssignment_b__11_2(Archetype _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__LeaderAssignment_b__11_2_Internal_ArchetypeID_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArchetypeID>(intPtr3) : null;
				}
			}

			// Token: 0x060069CE RID: 27086 RVA: 0x001F6F3C File Offset: 0x001F513C
			[CallerCount(0)]
			public unsafe bool _LeaderAssignment_b__11_3(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__LeaderAssignment_b__11_3_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069CF RID: 27087 RVA: 0x001F6F8C File Offset: 0x001F518C
			[CallerCount(0)]
			public unsafe bool _LeaderAssignment_b__11_4(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__LeaderAssignment_b__11_4_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069D0 RID: 27088 RVA: 0x001F6FDC File Offset: 0x001F51DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166757, XrefRangeEnd = 166758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DraftDeckSetup_b__12_0(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__DraftDeckSetup_b__12_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069D1 RID: 27089 RVA: 0x001F702C File Offset: 0x001F522C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DraftDeckSetup_b__12_1(WormPlayer p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__DraftDeckSetup_b__12_1_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069D2 RID: 27090 RVA: 0x001F707C File Offset: 0x001F527C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166758, XrefRangeEnd = 166759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSetup_b__13_1(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__CompleteSetup_b__13_1_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069D3 RID: 27091 RVA: 0x001F70CC File Offset: 0x001F52CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSetup_b__13_0(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__CompleteSetup_b__13_0_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069D4 RID: 27092 RVA: 0x001F711C File Offset: 0x001F531C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSetup_b__13_2(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__CompleteSetup_b__13_2_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069D5 RID: 27093 RVA: 0x001F716C File Offset: 0x001F536C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompleteSetup_b__13_3(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c.NativeMethodInfoPtr__CompleteSetup_b__13_3_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060069D6 RID: 27094 RVA: 0x0002989B File Offset: 0x00027A9B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CAE RID: 7342
			// (get) Token: 0x060069D7 RID: 27095 RVA: 0x001F71BC File Offset: 0x001F53BC
			// (set) Token: 0x060069D8 RID: 27096 RVA: 0x000298A4 File Offset: 0x00027AA4
			public unsafe static SetupPhase.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupPhase.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CAF RID: 7343
			// (get) Token: 0x060069D9 RID: 27097 RVA: 0x001F71E4 File Offset: 0x001F53E4
			// (set) Token: 0x060069DA RID: 27098 RVA: 0x000298B6 File Offset: 0x00027AB6
			public unsafe static Func<WormPlayer, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CB0 RID: 7344
			// (get) Token: 0x060069DB RID: 27099 RVA: 0x001F720C File Offset: 0x001F540C
			// (set) Token: 0x060069DC RID: 27100 RVA: 0x000298C8 File Offset: 0x00027AC8
			public unsafe static Func<WormPlayer, bool> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CB1 RID: 7345
			// (get) Token: 0x060069DD RID: 27101 RVA: 0x001F7234 File Offset: 0x001F5434
			// (set) Token: 0x060069DE RID: 27102 RVA: 0x000298DA File Offset: 0x00027ADA
			public unsafe static Func<WormPlayer, bool> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CB2 RID: 7346
			// (get) Token: 0x060069DF RID: 27103 RVA: 0x001F725C File Offset: 0x001F545C
			// (set) Token: 0x060069E0 RID: 27104 RVA: 0x000298EC File Offset: 0x00027AEC
			public unsafe static Predicate<Archetype> __9__6_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<Archetype>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CB3 RID: 7347
			// (get) Token: 0x060069E1 RID: 27105 RVA: 0x001F7284 File Offset: 0x001F5484
			// (set) Token: 0x060069E2 RID: 27106 RVA: 0x000298FE File Offset: 0x00027AFE
			public unsafe static Func<Factions, bool> __9__6_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Factions, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CB4 RID: 7348
			// (get) Token: 0x060069E3 RID: 27107 RVA: 0x001F72AC File Offset: 0x001F54AC
			// (set) Token: 0x060069E4 RID: 27108 RVA: 0x00029910 File Offset: 0x00027B10
			public unsafe static Func<Factions, Factions> __9__6_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Factions, Factions>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CB5 RID: 7349
			// (get) Token: 0x060069E5 RID: 27109 RVA: 0x001F72D4 File Offset: 0x001F54D4
			// (set) Token: 0x060069E6 RID: 27110 RVA: 0x00029922 File Offset: 0x00027B22
			public unsafe static Func<Factions, int> __9__6_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Factions, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CB6 RID: 7350
			// (get) Token: 0x060069E7 RID: 27111 RVA: 0x001F72FC File Offset: 0x001F54FC
			// (set) Token: 0x060069E8 RID: 27112 RVA: 0x00029934 File Offset: 0x00027B34
			public unsafe static Func<Archetype, bool> __9__6_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CB7 RID: 7351
			// (get) Token: 0x060069E9 RID: 27113 RVA: 0x001F7324 File Offset: 0x001F5524
			// (set) Token: 0x060069EA RID: 27114 RVA: 0x00029946 File Offset: 0x00027B46
			public unsafe static Func<Archetype, bool> __9__6_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CB8 RID: 7352
			// (get) Token: 0x060069EB RID: 27115 RVA: 0x001F734C File Offset: 0x001F554C
			// (set) Token: 0x060069EC RID: 27116 RVA: 0x00029958 File Offset: 0x00027B58
			public unsafe static Func<Archetype, bool> __9__6_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__6_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CB9 RID: 7353
			// (get) Token: 0x060069ED RID: 27117 RVA: 0x001F7374 File Offset: 0x001F5574
			// (set) Token: 0x060069EE RID: 27118 RVA: 0x0002996A File Offset: 0x00027B6A
			public unsafe static Func<Archetype, bool> __9__8_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__8_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__8_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CBA RID: 7354
			// (get) Token: 0x060069EF RID: 27119 RVA: 0x001F739C File Offset: 0x001F559C
			// (set) Token: 0x060069F0 RID: 27120 RVA: 0x0002997C File Offset: 0x00027B7C
			public unsafe static Func<Archetype, bool> __9__8_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__8_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__8_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CBB RID: 7355
			// (get) Token: 0x060069F1 RID: 27121 RVA: 0x001F73C4 File Offset: 0x001F55C4
			// (set) Token: 0x060069F2 RID: 27122 RVA: 0x0002998E File Offset: 0x00027B8E
			public unsafe static Func<WormPlayer, AccountID> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, AccountID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CBC RID: 7356
			// (get) Token: 0x060069F3 RID: 27123 RVA: 0x001F73EC File Offset: 0x001F55EC
			// (set) Token: 0x060069F4 RID: 27124 RVA: 0x000299A0 File Offset: 0x00027BA0
			public unsafe static Func<WormPlayer, PlayerInfoSaveData> __9__10_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__10_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, PlayerInfoSaveData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__10_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CBD RID: 7357
			// (get) Token: 0x060069F5 RID: 27125 RVA: 0x001F7414 File Offset: 0x001F5614
			// (set) Token: 0x060069F6 RID: 27126 RVA: 0x000299B2 File Offset: 0x00027BB2
			public unsafe static Func<WormPlayer, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CBE RID: 7358
			// (get) Token: 0x060069F7 RID: 27127 RVA: 0x001F743C File Offset: 0x001F563C
			// (set) Token: 0x060069F8 RID: 27128 RVA: 0x000299C4 File Offset: 0x00027BC4
			public unsafe static Func<Archetype, ArchetypeID> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Archetype, ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CBF RID: 7359
			// (get) Token: 0x060069F9 RID: 27129 RVA: 0x001F7464 File Offset: 0x001F5664
			// (set) Token: 0x060069FA RID: 27130 RVA: 0x000299D6 File Offset: 0x00027BD6
			public unsafe static Func<WormPlayer, bool> __9__11_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__11_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__11_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CC0 RID: 7360
			// (get) Token: 0x060069FB RID: 27131 RVA: 0x001F748C File Offset: 0x001F568C
			// (set) Token: 0x060069FC RID: 27132 RVA: 0x000299E8 File Offset: 0x00027BE8
			public unsafe static Func<WormPlayer, bool> __9__11_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__11_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__11_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CC1 RID: 7361
			// (get) Token: 0x060069FD RID: 27133 RVA: 0x001F74B4 File Offset: 0x001F56B4
			// (set) Token: 0x060069FE RID: 27134 RVA: 0x000299FA File Offset: 0x00027BFA
			public unsafe static Func<WormPlayer, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CC2 RID: 7362
			// (get) Token: 0x060069FF RID: 27135 RVA: 0x001F74DC File Offset: 0x001F56DC
			// (set) Token: 0x06006A00 RID: 27136 RVA: 0x00029A0C File Offset: 0x00027C0C
			public unsafe static Func<WormPlayer, bool> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CC3 RID: 7363
			// (get) Token: 0x06006A01 RID: 27137 RVA: 0x001F7504 File Offset: 0x001F5704
			// (set) Token: 0x06006A02 RID: 27138 RVA: 0x00029A1E File Offset: 0x00027C1E
			public unsafe static Func<Entity, bool> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CC4 RID: 7364
			// (get) Token: 0x06006A03 RID: 27139 RVA: 0x001F752C File Offset: 0x001F572C
			// (set) Token: 0x06006A04 RID: 27140 RVA: 0x00029A30 File Offset: 0x00027C30
			public unsafe static Func<WormPlayer, bool> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CC5 RID: 7365
			// (get) Token: 0x06006A05 RID: 27141 RVA: 0x001F7554 File Offset: 0x001F5754
			// (set) Token: 0x06006A06 RID: 27142 RVA: 0x00029A42 File Offset: 0x00027C42
			public unsafe static Func<WormPlayer, bool> __9__13_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CC6 RID: 7366
			// (get) Token: 0x06006A07 RID: 27143 RVA: 0x001F757C File Offset: 0x001F577C
			// (set) Token: 0x06006A08 RID: 27144 RVA: 0x00029A54 File Offset: 0x00027C54
			public unsafe static Func<WormPlayer, bool> __9__13_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SetupPhase.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<WormPlayer, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SetupPhase.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400445F RID: 17503
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004460 RID: 17504
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04004461 RID: 17505
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x04004462 RID: 17506
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x04004463 RID: 17507
			private static readonly IntPtr NativeFieldInfoPtr___9__6_2;

			// Token: 0x04004464 RID: 17508
			private static readonly IntPtr NativeFieldInfoPtr___9__6_3;

			// Token: 0x04004465 RID: 17509
			private static readonly IntPtr NativeFieldInfoPtr___9__6_4;

			// Token: 0x04004466 RID: 17510
			private static readonly IntPtr NativeFieldInfoPtr___9__6_5;

			// Token: 0x04004467 RID: 17511
			private static readonly IntPtr NativeFieldInfoPtr___9__6_6;

			// Token: 0x04004468 RID: 17512
			private static readonly IntPtr NativeFieldInfoPtr___9__6_7;

			// Token: 0x04004469 RID: 17513
			private static readonly IntPtr NativeFieldInfoPtr___9__6_8;

			// Token: 0x0400446A RID: 17514
			private static readonly IntPtr NativeFieldInfoPtr___9__8_3;

			// Token: 0x0400446B RID: 17515
			private static readonly IntPtr NativeFieldInfoPtr___9__8_20;

			// Token: 0x0400446C RID: 17516
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x0400446D RID: 17517
			private static readonly IntPtr NativeFieldInfoPtr___9__10_1;

			// Token: 0x0400446E RID: 17518
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400446F RID: 17519
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x04004470 RID: 17520
			private static readonly IntPtr NativeFieldInfoPtr___9__11_3;

			// Token: 0x04004471 RID: 17521
			private static readonly IntPtr NativeFieldInfoPtr___9__11_4;

			// Token: 0x04004472 RID: 17522
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04004473 RID: 17523
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04004474 RID: 17524
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04004475 RID: 17525
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04004476 RID: 17526
			private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

			// Token: 0x04004477 RID: 17527
			private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

			// Token: 0x04004478 RID: 17528
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004479 RID: 17529
			private static readonly IntPtr NativeMethodInfoPtr__DetermineNextTypedState_b__4_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400447A RID: 17530
			private static readonly IntPtr NativeMethodInfoPtr__DetermineNextTypedState_b__4_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400447B RID: 17531
			private static readonly IntPtr NativeMethodInfoPtr__DetermineNextTypedState_b__4_2_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400447C RID: 17532
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetup_b__6_2_Internal_Boolean_Archetype_0;

			// Token: 0x0400447D RID: 17533
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetup_b__6_3_Internal_Boolean_Factions_0;

			// Token: 0x0400447E RID: 17534
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetup_b__6_4_Internal_Factions_Factions_0;

			// Token: 0x0400447F RID: 17535
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetup_b__6_5_Internal_Int32_Factions_0;

			// Token: 0x04004480 RID: 17536
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetup_b__6_6_Internal_Boolean_Archetype_0;

			// Token: 0x04004481 RID: 17537
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetup_b__6_7_Internal_Boolean_Archetype_0;

			// Token: 0x04004482 RID: 17538
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetup_b__6_8_Internal_Boolean_Archetype_0;

			// Token: 0x04004483 RID: 17539
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__8_3_Internal_Boolean_Archetype_0;

			// Token: 0x04004484 RID: 17540
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__8_20_Internal_Boolean_Archetype_0;

			// Token: 0x04004485 RID: 17541
			private static readonly IntPtr NativeMethodInfoPtr__EmitSerializedGameState_b__10_0_Internal_AccountID_WormPlayer_0;

			// Token: 0x04004486 RID: 17542
			private static readonly IntPtr NativeMethodInfoPtr__EmitSerializedGameState_b__10_1_Internal_PlayerInfoSaveData_WormPlayer_0;

			// Token: 0x04004487 RID: 17543
			private static readonly IntPtr NativeMethodInfoPtr__LeaderAssignment_b__11_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004488 RID: 17544
			private static readonly IntPtr NativeMethodInfoPtr__LeaderAssignment_b__11_2_Internal_ArchetypeID_Archetype_0;

			// Token: 0x04004489 RID: 17545
			private static readonly IntPtr NativeMethodInfoPtr__LeaderAssignment_b__11_3_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400448A RID: 17546
			private static readonly IntPtr NativeMethodInfoPtr__LeaderAssignment_b__11_4_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400448B RID: 17547
			private static readonly IntPtr NativeMethodInfoPtr__DraftDeckSetup_b__12_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400448C RID: 17548
			private static readonly IntPtr NativeMethodInfoPtr__DraftDeckSetup_b__12_1_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400448D RID: 17549
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSetup_b__13_1_Internal_Boolean_Entity_0;

			// Token: 0x0400448E RID: 17550
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSetup_b__13_0_Internal_Boolean_WormPlayer_0;

			// Token: 0x0400448F RID: 17551
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSetup_b__13_2_Internal_Boolean_WormPlayer_0;

			// Token: 0x04004490 RID: 17552
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSetup_b__13_3_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000767 RID: 1895
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x06006A09 RID: 27145 RVA: 0x001F75A4 File Offset: 0x001F57A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<SetupPhase.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass13_0>.NativeClassPtr);
				SetupPhase.__c__DisplayClass13_0.NativeFieldInfoPtr_soloPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass13_0>.NativeClassPtr, "soloPlayer");
				SetupPhase.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass13_0>.NativeClassPtr, 100670156);
				SetupPhase.__c__DisplayClass13_0.NativeMethodInfoPtr__CompleteSetup_b__4_Internal_Boolean_WormPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass13_0>.NativeClassPtr, 100670157);
			}

			// Token: 0x06006A0A RID: 27146 RVA: 0x001F760C File Offset: 0x001F580C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A0B RID: 27147 RVA: 0x001F7648 File Offset: 0x001F5848
			[CallerCount(0)]
			public unsafe bool _CompleteSetup_b__4(WormPlayer _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass13_0.NativeMethodInfoPtr__CompleteSetup_b__4_Internal_Boolean_WormPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A0C RID: 27148 RVA: 0x00029A66 File Offset: 0x00027C66
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CC7 RID: 7367
			// (get) Token: 0x06006A0D RID: 27149 RVA: 0x001F7698 File Offset: 0x001F5898
			// (set) Token: 0x06006A0E RID: 27150 RVA: 0x00029A6F File Offset: 0x00027C6F
			public unsafe WormPlayer soloPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass13_0.NativeFieldInfoPtr_soloPlayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass13_0.NativeFieldInfoPtr_soloPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004491 RID: 17553
			private static readonly IntPtr NativeFieldInfoPtr_soloPlayer;

			// Token: 0x04004492 RID: 17554
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004493 RID: 17555
			private static readonly IntPtr NativeMethodInfoPtr__CompleteSetup_b__4_Internal_Boolean_WormPlayer_0;
		}

		// Token: 0x02000768 RID: 1896
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x06006A0F RID: 27151 RVA: 0x001F76C8 File Offset: 0x001F58C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<SetupPhase.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass17_0>.NativeClassPtr);
				SetupPhase.__c__DisplayClass17_0.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass17_0>.NativeClassPtr, "match");
				SetupPhase.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass17_0>.NativeClassPtr, 100670158);
				SetupPhase.__c__DisplayClass17_0.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__0_Internal_IEnumerable_1_SerializedAssignLeader_AssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass17_0>.NativeClassPtr, 100670159);
			}

			// Token: 0x06006A10 RID: 27152 RVA: 0x001F7730 File Offset: 0x001F5930
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A11 RID: 27153 RVA: 0x001F776C File Offset: 0x001F596C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166759, XrefRangeEnd = 166773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<SerializedAssignLeader> _MakeSerializedStateMachineAction_b__0(AssignLeader _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass17_0.NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__0_Internal_IEnumerable_1_SerializedAssignLeader_AssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SerializedAssignLeader>>(intPtr3) : null;
				}
			}

			// Token: 0x06006A12 RID: 27154 RVA: 0x00029A8E File Offset: 0x00027C8E
			public __c__DisplayClass17_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CC8 RID: 7368
			// (get) Token: 0x06006A13 RID: 27155 RVA: 0x001F77BC File Offset: 0x001F59BC
			// (set) Token: 0x06006A14 RID: 27156 RVA: 0x00029A97 File Offset: 0x00027C97
			public unsafe Match match
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass17_0.NativeFieldInfoPtr_match);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass17_0.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004494 RID: 17556
			private static readonly IntPtr NativeFieldInfoPtr_match;

			// Token: 0x04004495 RID: 17557
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004496 RID: 17558
			private static readonly IntPtr NativeMethodInfoPtr__MakeSerializedStateMachineAction_b__0_Internal_IEnumerable_1_SerializedAssignLeader_AssignLeader_0;
		}

		// Token: 0x02000769 RID: 1897
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06006A15 RID: 27157 RVA: 0x001F77EC File Offset: 0x001F59EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<SetupPhase.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass3_0>.NativeClassPtr);
				SetupPhase.__c__DisplayClass3_0.NativeFieldInfoPtr_m = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass3_0>.NativeClassPtr, "m");
				SetupPhase.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass3_0>.NativeClassPtr, 100670160);
				SetupPhase.__c__DisplayClass3_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_AssignLeader_SerializedAssignLeader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass3_0>.NativeClassPtr, 100670161);
			}

			// Token: 0x06006A16 RID: 27158 RVA: 0x001F7854 File Offset: 0x001F5A54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A17 RID: 27159 RVA: 0x001F7890 File Offset: 0x001F5A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166773, XrefRangeEnd = 166795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<AssignLeader> __ctor_b__0(SerializedAssignLeader sal)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sal);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass3_0.NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_AssignLeader_SerializedAssignLeader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AssignLeader>>(intPtr3) : null;
				}
			}

			// Token: 0x06006A18 RID: 27160 RVA: 0x00029AB6 File Offset: 0x00027CB6
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CC9 RID: 7369
			// (get) Token: 0x06006A19 RID: 27161 RVA: 0x001F78E0 File Offset: 0x001F5AE0
			// (set) Token: 0x06006A1A RID: 27162 RVA: 0x00029ABF File Offset: 0x00027CBF
			public unsafe WormMatch m
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass3_0.NativeFieldInfoPtr_m);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass3_0.NativeFieldInfoPtr_m), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004497 RID: 17559
			private static readonly IntPtr NativeFieldInfoPtr_m;

			// Token: 0x04004498 RID: 17560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004499 RID: 17561
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_Internal_IEnumerable_1_AssignLeader_SerializedAssignLeader_0;
		}

		// Token: 0x0200076A RID: 1898
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06006A1B RID: 27163 RVA: 0x001F7910 File Offset: 0x001F5B10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<SetupPhase.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass6_0>.NativeClassPtr);
				SetupPhase.__c__DisplayClass6_0.NativeFieldInfoPtr_spaceSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass6_0>.NativeClassPtr, "spaceSet");
				SetupPhase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass6_0>.NativeClassPtr, 100670162);
				SetupPhase.__c__DisplayClass6_0.NativeMethodInfoPtr__BeginSetup_b__1_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass6_0>.NativeClassPtr, 100670163);
			}

			// Token: 0x06006A1C RID: 27164 RVA: 0x001F7978 File Offset: 0x001F5B78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A1D RID: 27165 RVA: 0x001F79B4 File Offset: 0x001F5BB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166795, XrefRangeEnd = 166796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _BeginSetup_b__1(Archetype arch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass6_0.NativeMethodInfoPtr__BeginSetup_b__1_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A1E RID: 27166 RVA: 0x00029ADE File Offset: 0x00027CDE
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CCA RID: 7370
			// (get) Token: 0x06006A1F RID: 27167 RVA: 0x001F7A04 File Offset: 0x001F5C04
			// (set) Token: 0x06006A20 RID: 27168 RVA: 0x00029AE7 File Offset: 0x00027CE7
			public unsafe Set spaceSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass6_0.NativeFieldInfoPtr_spaceSet);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass6_0.NativeFieldInfoPtr_spaceSet)) = value;
				}
			}

			// Token: 0x0400449A RID: 17562
			private static readonly IntPtr NativeFieldInfoPtr_spaceSet;

			// Token: 0x0400449B RID: 17563
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400449C RID: 17564
			private static readonly IntPtr NativeMethodInfoPtr__BeginSetup_b__1_Internal_Boolean_Archetype_0;
		}

		// Token: 0x0200076B RID: 1899
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06006A21 RID: 27169 RVA: 0x001F7A2C File Offset: 0x001F5C2C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr);
				SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr_doubleImperiumSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, "doubleImperiumSets");
				SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr_doubleIntrigueSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, "doubleIntrigueSets");
				SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr_distributedTechTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, "distributedTechTiles");
				SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, "<>9__9");
				SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, "<>9__10");
				SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, "<>9__11");
				SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, "<>9__12");
				SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, "<>9__13");
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670164);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__0_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670165);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__1_Internal_Archetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670166);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__2_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670167);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__4_Internal_Archetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670168);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__9_Internal_Archetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670169);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__10_Internal_Archetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670170);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__11_Internal_Archetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670171);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__12_Internal_Archetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670172);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__13_Internal_Archetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670173);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__16_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670174);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__14_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670175);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__15_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670176);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__5_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670177);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__6_Internal_Archetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670178);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__7_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670179);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__19_Internal_Boolean_Archetype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670180);
				SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__21_Internal_Archetype_ArchetypeID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr, 100670181);
			}

			// Token: 0x06006A22 RID: 27170 RVA: 0x001F7C74 File Offset: 0x001F5E74
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A23 RID: 27171 RVA: 0x001F7CB0 File Offset: 0x001F5EB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166796, XrefRangeEnd = 166800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__0(Archetype arch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__0_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A24 RID: 27172 RVA: 0x001F7D00 File Offset: 0x001F5F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166800, XrefRangeEnd = 166802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Archetype _CreateDecks_b__1(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__1_Internal_Archetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06006A25 RID: 27173 RVA: 0x001F7D50 File Offset: 0x001F5F50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166802, XrefRangeEnd = 166806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__2(Archetype arch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__2_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A26 RID: 27174 RVA: 0x001F7DA0 File Offset: 0x001F5FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Archetype _CreateDecks_b__4(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__4_Internal_Archetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06006A27 RID: 27175 RVA: 0x001F7DF0 File Offset: 0x001F5FF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Archetype _CreateDecks_b__9(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__9_Internal_Archetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06006A28 RID: 27176 RVA: 0x001F7E40 File Offset: 0x001F6040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Archetype _CreateDecks_b__10(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__10_Internal_Archetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06006A29 RID: 27177 RVA: 0x001F7E90 File Offset: 0x001F6090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Archetype _CreateDecks_b__11(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__11_Internal_Archetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06006A2A RID: 27178 RVA: 0x001F7EE0 File Offset: 0x001F60E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Archetype _CreateDecks_b__12(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__12_Internal_Archetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06006A2B RID: 27179 RVA: 0x001F7F30 File Offset: 0x001F6130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Archetype _CreateDecks_b__13(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__13_Internal_Archetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06006A2C RID: 27180 RVA: 0x001F7F80 File Offset: 0x001F6180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166806, XrefRangeEnd = 166810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__16(Archetype arch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__16_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A2D RID: 27181 RVA: 0x001F7FD0 File Offset: 0x001F61D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166810, XrefRangeEnd = 166814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__14(Archetype arch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__14_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A2E RID: 27182 RVA: 0x001F8020 File Offset: 0x001F6220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166814, XrefRangeEnd = 166818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__15(Archetype arch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__15_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A2F RID: 27183 RVA: 0x001F8070 File Offset: 0x001F6270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166818, XrefRangeEnd = 166819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__5(Archetype arch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__5_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A30 RID: 27184 RVA: 0x001F80C0 File Offset: 0x001F62C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Archetype _CreateDecks_b__6(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__6_Internal_Archetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06006A31 RID: 27185 RVA: 0x001F8110 File Offset: 0x001F6310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166819, XrefRangeEnd = 166820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__7(Archetype arch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__7_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A32 RID: 27186 RVA: 0x001F8160 File Offset: 0x001F6360
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166820, XrefRangeEnd = 166825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__19(Archetype arch)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(arch);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__19_Internal_Boolean_Archetype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A33 RID: 27187 RVA: 0x001F81B0 File Offset: 0x001F63B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Archetype _CreateDecks_b__21(ArchetypeID id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_0.NativeMethodInfoPtr__CreateDecks_b__21_Internal_Archetype_ArchetypeID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Archetype>(intPtr3) : null;
				}
			}

			// Token: 0x06006A34 RID: 27188 RVA: 0x00029B02 File Offset: 0x00027D02
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CCB RID: 7371
			// (get) Token: 0x06006A35 RID: 27189 RVA: 0x001F8200 File Offset: 0x001F6400
			// (set) Token: 0x06006A36 RID: 27190 RVA: 0x00029B0B File Offset: 0x00027D0B
			public unsafe SetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CCC RID: 7372
			// (get) Token: 0x06006A37 RID: 27191 RVA: 0x001F8230 File Offset: 0x001F6430
			// (set) Token: 0x06006A38 RID: 27192 RVA: 0x00029B2A File Offset: 0x00027D2A
			public unsafe List<Set> doubleImperiumSets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr_doubleImperiumSets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Set>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr_doubleImperiumSets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CCD RID: 7373
			// (get) Token: 0x06006A39 RID: 27193 RVA: 0x001F8260 File Offset: 0x001F6460
			// (set) Token: 0x06006A3A RID: 27194 RVA: 0x00029B49 File Offset: 0x00027D49
			public unsafe List<Set> doubleIntrigueSets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr_doubleIntrigueSets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Set>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr_doubleIntrigueSets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CCE RID: 7374
			// (get) Token: 0x06006A3B RID: 27195 RVA: 0x001F8290 File Offset: 0x001F6490
			// (set) Token: 0x06006A3C RID: 27196 RVA: 0x00029B68 File Offset: 0x00027D68
			public unsafe HashSet<ArchetypeID> distributedTechTiles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr_distributedTechTiles);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr_distributedTechTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CCF RID: 7375
			// (get) Token: 0x06006A3D RID: 27197 RVA: 0x001F82C0 File Offset: 0x001F64C0
			// (set) Token: 0x06006A3E RID: 27198 RVA: 0x00029B87 File Offset: 0x00027D87
			public unsafe Func<ArchetypeID, Archetype> __9__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ArchetypeID, Archetype>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CD0 RID: 7376
			// (get) Token: 0x06006A3F RID: 27199 RVA: 0x001F82F0 File Offset: 0x001F64F0
			// (set) Token: 0x06006A40 RID: 27200 RVA: 0x00029BA6 File Offset: 0x00027DA6
			public unsafe Func<ArchetypeID, Archetype> __9__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ArchetypeID, Archetype>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CD1 RID: 7377
			// (get) Token: 0x06006A41 RID: 27201 RVA: 0x001F8320 File Offset: 0x001F6520
			// (set) Token: 0x06006A42 RID: 27202 RVA: 0x00029BC5 File Offset: 0x00027DC5
			public unsafe Func<ArchetypeID, Archetype> __9__11
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__11);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ArchetypeID, Archetype>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__11), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CD2 RID: 7378
			// (get) Token: 0x06006A43 RID: 27203 RVA: 0x001F8350 File Offset: 0x001F6550
			// (set) Token: 0x06006A44 RID: 27204 RVA: 0x00029BE4 File Offset: 0x00027DE4
			public unsafe Func<ArchetypeID, Archetype> __9__12
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__12);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ArchetypeID, Archetype>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__12), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CD3 RID: 7379
			// (get) Token: 0x06006A45 RID: 27205 RVA: 0x001F8380 File Offset: 0x001F6580
			// (set) Token: 0x06006A46 RID: 27206 RVA: 0x00029C03 File Offset: 0x00027E03
			public unsafe Func<ArchetypeID, Archetype> __9__13
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__13);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ArchetypeID, Archetype>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_0.NativeFieldInfoPtr___9__13), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400449D RID: 17565
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400449E RID: 17566
			private static readonly IntPtr NativeFieldInfoPtr_doubleImperiumSets;

			// Token: 0x0400449F RID: 17567
			private static readonly IntPtr NativeFieldInfoPtr_doubleIntrigueSets;

			// Token: 0x040044A0 RID: 17568
			private static readonly IntPtr NativeFieldInfoPtr_distributedTechTiles;

			// Token: 0x040044A1 RID: 17569
			private static readonly IntPtr NativeFieldInfoPtr___9__9;

			// Token: 0x040044A2 RID: 17570
			private static readonly IntPtr NativeFieldInfoPtr___9__10;

			// Token: 0x040044A3 RID: 17571
			private static readonly IntPtr NativeFieldInfoPtr___9__11;

			// Token: 0x040044A4 RID: 17572
			private static readonly IntPtr NativeFieldInfoPtr___9__12;

			// Token: 0x040044A5 RID: 17573
			private static readonly IntPtr NativeFieldInfoPtr___9__13;

			// Token: 0x040044A6 RID: 17574
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044A7 RID: 17575
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__0_Internal_Boolean_Archetype_0;

			// Token: 0x040044A8 RID: 17576
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__1_Internal_Archetype_ArchetypeID_0;

			// Token: 0x040044A9 RID: 17577
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__2_Internal_Boolean_Archetype_0;

			// Token: 0x040044AA RID: 17578
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__4_Internal_Archetype_ArchetypeID_0;

			// Token: 0x040044AB RID: 17579
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__9_Internal_Archetype_ArchetypeID_0;

			// Token: 0x040044AC RID: 17580
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__10_Internal_Archetype_ArchetypeID_0;

			// Token: 0x040044AD RID: 17581
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__11_Internal_Archetype_ArchetypeID_0;

			// Token: 0x040044AE RID: 17582
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__12_Internal_Archetype_ArchetypeID_0;

			// Token: 0x040044AF RID: 17583
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__13_Internal_Archetype_ArchetypeID_0;

			// Token: 0x040044B0 RID: 17584
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__16_Internal_Boolean_Archetype_0;

			// Token: 0x040044B1 RID: 17585
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__14_Internal_Boolean_Archetype_0;

			// Token: 0x040044B2 RID: 17586
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__15_Internal_Boolean_Archetype_0;

			// Token: 0x040044B3 RID: 17587
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__5_Internal_Boolean_Archetype_0;

			// Token: 0x040044B4 RID: 17588
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__6_Internal_Archetype_ArchetypeID_0;

			// Token: 0x040044B5 RID: 17589
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__7_Internal_Boolean_Archetype_0;

			// Token: 0x040044B6 RID: 17590
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__19_Internal_Boolean_Archetype_0;

			// Token: 0x040044B7 RID: 17591
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__21_Internal_Archetype_ArchetypeID_0;
		}

		// Token: 0x0200076C RID: 1900
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<>c__DisplayClass8_1")]
		public sealed class __c__DisplayClass8_1 : Object
		{
			// Token: 0x06006A47 RID: 27207 RVA: 0x001F83B0 File Offset: 0x001F65B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_1()
			{
				Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<>c__DisplayClass8_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_1>.NativeClassPtr);
				SetupPhase.__c__DisplayClass8_1.NativeFieldInfoPtr_imperiumDeckExclusions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_1>.NativeClassPtr, "imperiumDeckExclusions");
				SetupPhase.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_1>.NativeClassPtr, 100670182);
				SetupPhase.__c__DisplayClass8_1.NativeMethodInfoPtr__CreateDecks_b__8_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_1>.NativeClassPtr, 100670183);
			}

			// Token: 0x06006A48 RID: 27208 RVA: 0x001F8418 File Offset: 0x001F6618
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A49 RID: 27209 RVA: 0x001F8454 File Offset: 0x001F6654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166825, XrefRangeEnd = 166830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__8(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_1.NativeMethodInfoPtr__CreateDecks_b__8_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A4A RID: 27210 RVA: 0x00029C22 File Offset: 0x00027E22
			public __c__DisplayClass8_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CD4 RID: 7380
			// (get) Token: 0x06006A4B RID: 27211 RVA: 0x001F84A4 File Offset: 0x001F66A4
			// (set) Token: 0x06006A4C RID: 27212 RVA: 0x00029C2B File Offset: 0x00027E2B
			public unsafe List<ArchetypeID> imperiumDeckExclusions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_1.NativeFieldInfoPtr_imperiumDeckExclusions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_1.NativeFieldInfoPtr_imperiumDeckExclusions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044B8 RID: 17592
			private static readonly IntPtr NativeFieldInfoPtr_imperiumDeckExclusions;

			// Token: 0x040044B9 RID: 17593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044BA RID: 17594
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__8_Internal_Boolean_Entity_0;
		}

		// Token: 0x0200076D RID: 1901
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<>c__DisplayClass8_2")]
		public sealed class __c__DisplayClass8_2 : Object
		{
			// Token: 0x06006A4D RID: 27213 RVA: 0x001F84D4 File Offset: 0x001F66D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_2()
			{
				Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<>c__DisplayClass8_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_2>.NativeClassPtr);
				SetupPhase.__c__DisplayClass8_2.NativeFieldInfoPtr_intrigueDeckExclusions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_2>.NativeClassPtr, "intrigueDeckExclusions");
				SetupPhase.__c__DisplayClass8_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_2>.NativeClassPtr, 100670184);
				SetupPhase.__c__DisplayClass8_2.NativeMethodInfoPtr__CreateDecks_b__17_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_2>.NativeClassPtr, 100670185);
			}

			// Token: 0x06006A4E RID: 27214 RVA: 0x001F853C File Offset: 0x001F673C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A4F RID: 27215 RVA: 0x001F8578 File Offset: 0x001F6778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166830, XrefRangeEnd = 166835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__17(Entity _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_2.NativeMethodInfoPtr__CreateDecks_b__17_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A50 RID: 27216 RVA: 0x00029C4A File Offset: 0x00027E4A
			public __c__DisplayClass8_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CD5 RID: 7381
			// (get) Token: 0x06006A51 RID: 27217 RVA: 0x001F85C8 File Offset: 0x001F67C8
			// (set) Token: 0x06006A52 RID: 27218 RVA: 0x00029C53 File Offset: 0x00027E53
			public unsafe List<ArchetypeID> intrigueDeckExclusions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_2.NativeFieldInfoPtr_intrigueDeckExclusions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_2.NativeFieldInfoPtr_intrigueDeckExclusions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044BB RID: 17595
			private static readonly IntPtr NativeFieldInfoPtr_intrigueDeckExclusions;

			// Token: 0x040044BC RID: 17596
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044BD RID: 17597
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__17_Internal_Boolean_Entity_0;
		}

		// Token: 0x0200076E RID: 1902
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<>c__DisplayClass8_3")]
		public sealed class __c__DisplayClass8_3 : Object
		{
			// Token: 0x06006A53 RID: 27219 RVA: 0x001F85F8 File Offset: 0x001F67F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_3()
			{
				Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<>c__DisplayClass8_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_3>.NativeClassPtr);
				SetupPhase.__c__DisplayClass8_3.NativeFieldInfoPtr_imperiumRowCosts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_3>.NativeClassPtr, "imperiumRowCosts");
				SetupPhase.__c__DisplayClass8_3.NativeFieldInfoPtr___9__18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_3>.NativeClassPtr, "<>9__18");
				SetupPhase.__c__DisplayClass8_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_3>.NativeClassPtr, 100670186);
				SetupPhase.__c__DisplayClass8_3.NativeMethodInfoPtr__CreateDecks_b__18_Internal_Boolean_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_3>.NativeClassPtr, 100670187);
			}

			// Token: 0x06006A54 RID: 27220 RVA: 0x001F8674 File Offset: 0x001F6874
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase.__c__DisplayClass8_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A55 RID: 27221 RVA: 0x001F86B0 File Offset: 0x001F68B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166835, XrefRangeEnd = 166845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CreateDecks_b__18(Entity card)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(card);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase.__c__DisplayClass8_3.NativeMethodInfoPtr__CreateDecks_b__18_Internal_Boolean_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06006A56 RID: 27222 RVA: 0x00029C72 File Offset: 0x00027E72
			public __c__DisplayClass8_3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CD6 RID: 7382
			// (get) Token: 0x06006A57 RID: 27223 RVA: 0x001F8700 File Offset: 0x001F6900
			// (set) Token: 0x06006A58 RID: 27224 RVA: 0x00029C7B File Offset: 0x00027E7B
			public unsafe List<int> imperiumRowCosts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_3.NativeFieldInfoPtr_imperiumRowCosts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_3.NativeFieldInfoPtr_imperiumRowCosts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CD7 RID: 7383
			// (get) Token: 0x06006A59 RID: 27225 RVA: 0x001F8730 File Offset: 0x001F6930
			// (set) Token: 0x06006A5A RID: 27226 RVA: 0x00029C9A File Offset: 0x00027E9A
			public unsafe Func<Entity, bool> __9__18
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_3.NativeFieldInfoPtr___9__18);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Entity, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase.__c__DisplayClass8_3.NativeFieldInfoPtr___9__18), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044BE RID: 17598
			private static readonly IntPtr NativeFieldInfoPtr_imperiumRowCosts;

			// Token: 0x040044BF RID: 17599
			private static readonly IntPtr NativeFieldInfoPtr___9__18;

			// Token: 0x040044C0 RID: 17600
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040044C1 RID: 17601
			private static readonly IntPtr NativeMethodInfoPtr__CreateDecks_b__18_Internal_Boolean_Entity_0;
		}

		// Token: 0x0200076F RID: 1903
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<AdditionalLeaderSetup2>d__16")]
		public sealed class _AdditionalLeaderSetup2_d__16 : Object
		{
			// Token: 0x06006A5B RID: 27227 RVA: 0x001F8760 File Offset: 0x001F6960
			// Note: this type is marked as 'beforefieldinit'.
			static _AdditionalLeaderSetup2_d__16()
			{
				Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<AdditionalLeaderSetup2>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr);
				SetupPhase._AdditionalLeaderSetup2_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr, "<>1__state");
				SetupPhase._AdditionalLeaderSetup2_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr, "<>2__current");
				SetupPhase._AdditionalLeaderSetup2_d__16.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr, "<>l__initialThreadId");
				SetupPhase._AdditionalLeaderSetup2_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr, "<>4__this");
				SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr, 100670188);
				SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr, 100670189);
				SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr, 100670190);
				SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr, 100670191);
				SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr, 100670192);
				SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr, 100670193);
				SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr, 100670194);
				SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr, 100670195);
			}

			// Token: 0x06006A5C RID: 27228 RVA: 0x001F887C File Offset: 0x001F6A7C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AdditionalLeaderSetup2_d__16(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup2_d__16>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006A5D RID: 27229 RVA: 0x001F88C4 File Offset: 0x001F6AC4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A5E RID: 27230 RVA: 0x001F88F8 File Offset: 0x001F6AF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166845, XrefRangeEnd = 166847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CDC RID: 7388
			// (get) Token: 0x06006A5F RID: 27231 RVA: 0x001F8934 File Offset: 0x001F6B34
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006A60 RID: 27232 RVA: 0x001F8974 File Offset: 0x001F6B74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166847, XrefRangeEnd = 166852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CDD RID: 7389
			// (get) Token: 0x06006A61 RID: 27233 RVA: 0x001F89A8 File Offset: 0x001F6BA8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006A62 RID: 27234 RVA: 0x001F89E8 File Offset: 0x001F6BE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166852, XrefRangeEnd = 166854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006A63 RID: 27235 RVA: 0x001F8A28 File Offset: 0x001F6C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup2_d__16.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006A64 RID: 27236 RVA: 0x00029CB9 File Offset: 0x00027EB9
			public _AdditionalLeaderSetup2_d__16(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CD8 RID: 7384
			// (get) Token: 0x06006A65 RID: 27237 RVA: 0x001F8A68 File Offset: 0x001F6C68
			// (set) Token: 0x06006A66 RID: 27238 RVA: 0x00029CC2 File Offset: 0x00027EC2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup2_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup2_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CD9 RID: 7385
			// (get) Token: 0x06006A67 RID: 27239 RVA: 0x001F8A90 File Offset: 0x001F6C90
			// (set) Token: 0x06006A68 RID: 27240 RVA: 0x00029CDD File Offset: 0x00027EDD
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup2_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup2_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CDA RID: 7386
			// (get) Token: 0x06006A69 RID: 27241 RVA: 0x001F8AC0 File Offset: 0x001F6CC0
			// (set) Token: 0x06006A6A RID: 27242 RVA: 0x00029CFC File Offset: 0x00027EFC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup2_d__16.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup2_d__16.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001CDB RID: 7387
			// (get) Token: 0x06006A6B RID: 27243 RVA: 0x001F8AE8 File Offset: 0x001F6CE8
			// (set) Token: 0x06006A6C RID: 27244 RVA: 0x00029D17 File Offset: 0x00027F17
			public unsafe SetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup2_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup2_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044C2 RID: 17602
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040044C3 RID: 17603
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040044C4 RID: 17604
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040044C5 RID: 17605
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040044C6 RID: 17606
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040044C7 RID: 17607
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040044C8 RID: 17608
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040044C9 RID: 17609
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040044CA RID: 17610
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040044CB RID: 17611
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040044CC RID: 17612
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040044CD RID: 17613
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000770 RID: 1904
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<AdditionalLeaderSetup>d__15")]
		public sealed class _AdditionalLeaderSetup_d__15 : Object
		{
			// Token: 0x06006A6D RID: 27245 RVA: 0x001F8B18 File Offset: 0x001F6D18
			// Note: this type is marked as 'beforefieldinit'.
			static _AdditionalLeaderSetup_d__15()
			{
				Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<AdditionalLeaderSetup>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr);
				SetupPhase._AdditionalLeaderSetup_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr, "<>1__state");
				SetupPhase._AdditionalLeaderSetup_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr, "<>2__current");
				SetupPhase._AdditionalLeaderSetup_d__15.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr, "<>l__initialThreadId");
				SetupPhase._AdditionalLeaderSetup_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr, "<>4__this");
				SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr, 100670196);
				SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr, 100670197);
				SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr, 100670198);
				SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr, 100670199);
				SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr, 100670200);
				SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr, 100670201);
				SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr, 100670202);
				SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr, 100670203);
			}

			// Token: 0x06006A6E RID: 27246 RVA: 0x001F8C34 File Offset: 0x001F6E34
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _AdditionalLeaderSetup_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase._AdditionalLeaderSetup_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006A6F RID: 27247 RVA: 0x001F8C7C File Offset: 0x001F6E7C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A70 RID: 27248 RVA: 0x001F8CB0 File Offset: 0x001F6EB0
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CE2 RID: 7394
			// (get) Token: 0x06006A71 RID: 27249 RVA: 0x001F8CEC File Offset: 0x001F6EEC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006A72 RID: 27250 RVA: 0x001F8D2C File Offset: 0x001F6F2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166854, XrefRangeEnd = 166859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CE3 RID: 7395
			// (get) Token: 0x06006A73 RID: 27251 RVA: 0x001F8D60 File Offset: 0x001F6F60
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006A74 RID: 27252 RVA: 0x001F8DA0 File Offset: 0x001F6FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166859, XrefRangeEnd = 166861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006A75 RID: 27253 RVA: 0x001F8DE0 File Offset: 0x001F6FE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._AdditionalLeaderSetup_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006A76 RID: 27254 RVA: 0x00029D36 File Offset: 0x00027F36
			public _AdditionalLeaderSetup_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CDE RID: 7390
			// (get) Token: 0x06006A77 RID: 27255 RVA: 0x001F8E20 File Offset: 0x001F7020
			// (set) Token: 0x06006A78 RID: 27256 RVA: 0x00029D3F File Offset: 0x00027F3F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CDF RID: 7391
			// (get) Token: 0x06006A79 RID: 27257 RVA: 0x001F8E48 File Offset: 0x001F7048
			// (set) Token: 0x06006A7A RID: 27258 RVA: 0x00029D5A File Offset: 0x00027F5A
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CE0 RID: 7392
			// (get) Token: 0x06006A7B RID: 27259 RVA: 0x001F8E78 File Offset: 0x001F7078
			// (set) Token: 0x06006A7C RID: 27260 RVA: 0x00029D79 File Offset: 0x00027F79
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup_d__15.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup_d__15.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001CE1 RID: 7393
			// (get) Token: 0x06006A7D RID: 27261 RVA: 0x001F8EA0 File Offset: 0x001F70A0
			// (set) Token: 0x06006A7E RID: 27262 RVA: 0x00029D94 File Offset: 0x00027F94
			public unsafe SetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._AdditionalLeaderSetup_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044CE RID: 17614
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040044CF RID: 17615
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040044D0 RID: 17616
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040044D1 RID: 17617
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040044D2 RID: 17618
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040044D3 RID: 17619
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040044D4 RID: 17620
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040044D5 RID: 17621
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040044D6 RID: 17622
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040044D7 RID: 17623
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040044D8 RID: 17624
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040044D9 RID: 17625
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000771 RID: 1905
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<BeginSetup>d__6")]
		public sealed class _BeginSetup_d__6 : Object
		{
			// Token: 0x06006A7F RID: 27263 RVA: 0x001F8ED0 File Offset: 0x001F70D0
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginSetup_d__6()
			{
				Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<BeginSetup>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr);
				SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, "<>1__state");
				SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, "<>2__current");
				SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, "<>l__initialThreadId");
				SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, "<>4__this");
				SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, "<>7__wrap1");
				SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr__player_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, "<player>5__3");
				SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, "<>7__wrap3");
				SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, 100670204);
				SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, 100670205);
				SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, 100670206);
				SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, 100670207);
				SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, 100670208);
				SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, 100670209);
				SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, 100670210);
				SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, 100670211);
				SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, 100670212);
				SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr, 100670213);
			}

			// Token: 0x06006A80 RID: 27264 RVA: 0x001F9050 File Offset: 0x001F7250
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginSetup_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase._BeginSetup_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006A81 RID: 27265 RVA: 0x001F9098 File Offset: 0x001F7298
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166871, RefRangeEnd = 166872, XrefRangeStart = 166861, XrefRangeEnd = 166871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A82 RID: 27266 RVA: 0x001F90CC File Offset: 0x001F72CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166872, XrefRangeEnd = 167625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006A83 RID: 27267 RVA: 0x001F9108 File Offset: 0x001F7308
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167625, XrefRangeEnd = 167628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A84 RID: 27268 RVA: 0x001F913C File Offset: 0x001F733C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167628, XrefRangeEnd = 167631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CEB RID: 7403
			// (get) Token: 0x06006A85 RID: 27269 RVA: 0x001F9170 File Offset: 0x001F7370
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006A86 RID: 27270 RVA: 0x001F91B0 File Offset: 0x001F73B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167631, XrefRangeEnd = 167636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CEC RID: 7404
			// (get) Token: 0x06006A87 RID: 27271 RVA: 0x001F91E4 File Offset: 0x001F73E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006A88 RID: 27272 RVA: 0x001F9224 File Offset: 0x001F7424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167636, XrefRangeEnd = 167638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006A89 RID: 27273 RVA: 0x001F9264 File Offset: 0x001F7464
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetup_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006A8A RID: 27274 RVA: 0x00029DB3 File Offset: 0x00027FB3
			public _BeginSetup_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CE4 RID: 7396
			// (get) Token: 0x06006A8B RID: 27275 RVA: 0x001F92A4 File Offset: 0x001F74A4
			// (set) Token: 0x06006A8C RID: 27276 RVA: 0x00029DBC File Offset: 0x00027FBC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CE5 RID: 7397
			// (get) Token: 0x06006A8D RID: 27277 RVA: 0x001F92CC File Offset: 0x001F74CC
			// (set) Token: 0x06006A8E RID: 27278 RVA: 0x00029DD7 File Offset: 0x00027FD7
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CE6 RID: 7398
			// (get) Token: 0x06006A8F RID: 27279 RVA: 0x001F92FC File Offset: 0x001F74FC
			// (set) Token: 0x06006A90 RID: 27280 RVA: 0x00029DF6 File Offset: 0x00027FF6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001CE7 RID: 7399
			// (get) Token: 0x06006A91 RID: 27281 RVA: 0x001F9324 File Offset: 0x001F7524
			// (set) Token: 0x06006A92 RID: 27282 RVA: 0x00029E11 File Offset: 0x00028011
			public unsafe SetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CE8 RID: 7400
			// (get) Token: 0x06006A93 RID: 27283 RVA: 0x001F9354 File Offset: 0x001F7554
			// (set) Token: 0x06006A94 RID: 27284 RVA: 0x00029E30 File Offset: 0x00028030
			public List<WormPlayer>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___7__wrap1);
					return new List<WormPlayer>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001CE9 RID: 7401
			// (get) Token: 0x06006A95 RID: 27285 RVA: 0x001F9384 File Offset: 0x001F7584
			// (set) Token: 0x06006A96 RID: 27286 RVA: 0x00029E5E File Offset: 0x0002805E
			public unsafe WormPlayer _player_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr__player_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr__player_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CEA RID: 7402
			// (get) Token: 0x06006A97 RID: 27287 RVA: 0x001F93B4 File Offset: 0x001F75B4
			// (set) Token: 0x06006A98 RID: 27288 RVA: 0x00029E7D File Offset: 0x0002807D
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetup_d__6.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044DA RID: 17626
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040044DB RID: 17627
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040044DC RID: 17628
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040044DD RID: 17629
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040044DE RID: 17630
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040044DF RID: 17631
			private static readonly IntPtr NativeFieldInfoPtr__player_5__3;

			// Token: 0x040044E0 RID: 17632
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x040044E1 RID: 17633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040044E2 RID: 17634
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040044E3 RID: 17635
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040044E4 RID: 17636
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040044E5 RID: 17637
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040044E6 RID: 17638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040044E7 RID: 17639
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040044E8 RID: 17640
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040044E9 RID: 17641
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040044EA RID: 17642
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000772 RID: 1906
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<BeginSetupExtra>d__7")]
		public sealed class _BeginSetupExtra_d__7 : Object
		{
			// Token: 0x06006A99 RID: 27289 RVA: 0x001F93E4 File Offset: 0x001F75E4
			// Note: this type is marked as 'beforefieldinit'.
			static _BeginSetupExtra_d__7()
			{
				Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<BeginSetupExtra>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr);
				SetupPhase._BeginSetupExtra_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr, "<>1__state");
				SetupPhase._BeginSetupExtra_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr, "<>2__current");
				SetupPhase._BeginSetupExtra_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr, "<>l__initialThreadId");
				SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr, 100670214);
				SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr, 100670215);
				SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr, 100670216);
				SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr, 100670217);
				SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr, 100670218);
				SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr, 100670219);
				SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr, 100670220);
				SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr, 100670221);
			}

			// Token: 0x06006A9A RID: 27290 RVA: 0x001F94EC File Offset: 0x001F76EC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _BeginSetupExtra_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase._BeginSetupExtra_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006A9B RID: 27291 RVA: 0x001F9534 File Offset: 0x001F7734
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006A9C RID: 27292 RVA: 0x001F9568 File Offset: 0x001F7768
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001CF0 RID: 7408
			// (get) Token: 0x06006A9D RID: 27293 RVA: 0x001F95A4 File Offset: 0x001F77A4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006A9E RID: 27294 RVA: 0x001F95E4 File Offset: 0x001F77E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167638, XrefRangeEnd = 167643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001CF1 RID: 7409
			// (get) Token: 0x06006A9F RID: 27295 RVA: 0x001F9618 File Offset: 0x001F7818
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006AA0 RID: 27296 RVA: 0x001F9658 File Offset: 0x001F7858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167643, XrefRangeEnd = 167645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006AA1 RID: 27297 RVA: 0x001F9698 File Offset: 0x001F7898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._BeginSetupExtra_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006AA2 RID: 27298 RVA: 0x00029E9C File Offset: 0x0002809C
			public _BeginSetupExtra_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CED RID: 7405
			// (get) Token: 0x06006AA3 RID: 27299 RVA: 0x001F96D8 File Offset: 0x001F78D8
			// (set) Token: 0x06006AA4 RID: 27300 RVA: 0x00029EA5 File Offset: 0x000280A5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetupExtra_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetupExtra_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CEE RID: 7406
			// (get) Token: 0x06006AA5 RID: 27301 RVA: 0x001F9700 File Offset: 0x001F7900
			// (set) Token: 0x06006AA6 RID: 27302 RVA: 0x00029EC0 File Offset: 0x000280C0
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetupExtra_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetupExtra_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CEF RID: 7407
			// (get) Token: 0x06006AA7 RID: 27303 RVA: 0x001F9730 File Offset: 0x001F7930
			// (set) Token: 0x06006AA8 RID: 27304 RVA: 0x00029EDF File Offset: 0x000280DF
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetupExtra_d__7.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._BeginSetupExtra_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x040044EB RID: 17643
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040044EC RID: 17644
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040044ED RID: 17645
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040044EE RID: 17646
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040044EF RID: 17647
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040044F0 RID: 17648
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040044F1 RID: 17649
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040044F2 RID: 17650
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040044F3 RID: 17651
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040044F4 RID: 17652
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040044F5 RID: 17653
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000773 RID: 1907
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<CompleteSetup>d__13")]
		public sealed class _CompleteSetup_d__13 : Object
		{
			// Token: 0x06006AA9 RID: 27305 RVA: 0x001F9758 File Offset: 0x001F7958
			// Note: this type is marked as 'beforefieldinit'.
			static _CompleteSetup_d__13()
			{
				Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<CompleteSetup>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr);
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<>1__state");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<>2__current");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<>l__initialThreadId");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<>4__this");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__hagalMode_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<hagalMode>5__2");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__hagalDifficulty_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<hagalDifficulty>5__3");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__humanPlayer_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<humanPlayer>5__4");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<>7__wrap4");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___7__wrap5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<>7__wrap5");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__player_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<player>5__7");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__bonusTroops_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<bonusTroops>5__8");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__firstHagalPlayer_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<firstHagalPlayer>5__9");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___7__wrap9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<>7__wrap9");
				SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___7__wrap10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, "<>7__wrap10");
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670222);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670223);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670224);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670225);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670226);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670227);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670228);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally5_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670229);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally6_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670230);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally7_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670231);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670232);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670233);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670234);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670235);
				SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr, 100670236);
			}

			// Token: 0x06006AAA RID: 27306 RVA: 0x001F99C8 File Offset: 0x001F7BC8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CompleteSetup_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase._CompleteSetup_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006AAB RID: 27307 RVA: 0x001F9A10 File Offset: 0x001F7C10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167645, XrefRangeEnd = 167682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006AAC RID: 27308 RVA: 0x001F9A44 File Offset: 0x001F7C44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167682, XrefRangeEnd = 168149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006AAD RID: 27309 RVA: 0x001F9A80 File Offset: 0x001F7C80
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 168152, RefRangeEnd = 168153, XrefRangeStart = 168149, XrefRangeEnd = 168152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006AAE RID: 27310 RVA: 0x001F9AB4 File Offset: 0x001F7CB4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 168156, RefRangeEnd = 168157, XrefRangeStart = 168153, XrefRangeEnd = 168156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006AAF RID: 27311 RVA: 0x001F9AE8 File Offset: 0x001F7CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168157, XrefRangeEnd = 168160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006AB0 RID: 27312 RVA: 0x001F9B1C File Offset: 0x001F7D1C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 168163, RefRangeEnd = 168164, XrefRangeStart = 168160, XrefRangeEnd = 168163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006AB1 RID: 27313 RVA: 0x001F9B50 File Offset: 0x001F7D50
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 168167, RefRangeEnd = 168168, XrefRangeStart = 168164, XrefRangeEnd = 168167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally5_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006AB2 RID: 27314 RVA: 0x001F9B84 File Offset: 0x001F7D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168168, XrefRangeEnd = 168171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally6_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006AB3 RID: 27315 RVA: 0x001F9BB8 File Offset: 0x001F7DB8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 168174, RefRangeEnd = 168175, XrefRangeStart = 168171, XrefRangeEnd = 168174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr___m__Finally7_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D00 RID: 7424
			// (get) Token: 0x06006AB4 RID: 27316 RVA: 0x001F9BEC File Offset: 0x001F7DEC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006AB5 RID: 27317 RVA: 0x001F9C2C File Offset: 0x001F7E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168175, XrefRangeEnd = 168180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D01 RID: 7425
			// (get) Token: 0x06006AB6 RID: 27318 RVA: 0x001F9C60 File Offset: 0x001F7E60
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006AB7 RID: 27319 RVA: 0x001F9CA0 File Offset: 0x001F7EA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168180, XrefRangeEnd = 168182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006AB8 RID: 27320 RVA: 0x001F9CE0 File Offset: 0x001F7EE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetup_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006AB9 RID: 27321 RVA: 0x00029EFA File Offset: 0x000280FA
			public _CompleteSetup_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001CF2 RID: 7410
			// (get) Token: 0x06006ABA RID: 27322 RVA: 0x001F9D20 File Offset: 0x001F7F20
			// (set) Token: 0x06006ABB RID: 27323 RVA: 0x00029F03 File Offset: 0x00028103
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001CF3 RID: 7411
			// (get) Token: 0x06006ABC RID: 27324 RVA: 0x001F9D48 File Offset: 0x001F7F48
			// (set) Token: 0x06006ABD RID: 27325 RVA: 0x00029F1E File Offset: 0x0002811E
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CF4 RID: 7412
			// (get) Token: 0x06006ABE RID: 27326 RVA: 0x001F9D78 File Offset: 0x001F7F78
			// (set) Token: 0x06006ABF RID: 27327 RVA: 0x00029F3D File Offset: 0x0002813D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001CF5 RID: 7413
			// (get) Token: 0x06006AC0 RID: 27328 RVA: 0x001F9DA0 File Offset: 0x001F7FA0
			// (set) Token: 0x06006AC1 RID: 27329 RVA: 0x00029F58 File Offset: 0x00028158
			public unsafe SetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CF6 RID: 7414
			// (get) Token: 0x06006AC2 RID: 27330 RVA: 0x001F9DD0 File Offset: 0x001F7FD0
			// (set) Token: 0x06006AC3 RID: 27331 RVA: 0x00029F77 File Offset: 0x00028177
			public unsafe HagalModes _hagalMode_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__hagalMode_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__hagalMode_5__2)) = value;
				}
			}

			// Token: 0x17001CF7 RID: 7415
			// (get) Token: 0x06006AC4 RID: 27332 RVA: 0x001F9DF8 File Offset: 0x001F7FF8
			// (set) Token: 0x06006AC5 RID: 27333 RVA: 0x00029F92 File Offset: 0x00028192
			public unsafe HagalDifficultyLevels _hagalDifficulty_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__hagalDifficulty_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__hagalDifficulty_5__3)) = value;
				}
			}

			// Token: 0x17001CF8 RID: 7416
			// (get) Token: 0x06006AC6 RID: 27334 RVA: 0x001F9E20 File Offset: 0x001F8020
			// (set) Token: 0x06006AC7 RID: 27335 RVA: 0x00029FAD File Offset: 0x000281AD
			public unsafe WormPlayer _humanPlayer_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__humanPlayer_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__humanPlayer_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CF9 RID: 7417
			// (get) Token: 0x06006AC8 RID: 27336 RVA: 0x001F9E50 File Offset: 0x001F8050
			// (set) Token: 0x06006AC9 RID: 27337 RVA: 0x00029FCC File Offset: 0x000281CC
			public List<WormPlayer>.Enumerator __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___7__wrap4);
					return new List<WormPlayer>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___7__wrap4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001CFA RID: 7418
			// (get) Token: 0x06006ACA RID: 27338 RVA: 0x001F9E80 File Offset: 0x001F8080
			// (set) Token: 0x06006ACB RID: 27339 RVA: 0x00029FFA File Offset: 0x000281FA
			public List<WormAgent>.Enumerator __7__wrap5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___7__wrap5);
					return new List<WormAgent>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormAgent>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___7__wrap5), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormAgent>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001CFB RID: 7419
			// (get) Token: 0x06006ACC RID: 27340 RVA: 0x001F9EB0 File Offset: 0x001F80B0
			// (set) Token: 0x06006ACD RID: 27341 RVA: 0x0002A028 File Offset: 0x00028228
			public unsafe WormPlayer _player_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__player_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__player_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CFC RID: 7420
			// (get) Token: 0x06006ACE RID: 27342 RVA: 0x001F9EE0 File Offset: 0x001F80E0
			// (set) Token: 0x06006ACF RID: 27343 RVA: 0x0002A047 File Offset: 0x00028247
			public unsafe int _bonusTroops_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__bonusTroops_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__bonusTroops_5__8)) = value;
				}
			}

			// Token: 0x17001CFD RID: 7421
			// (get) Token: 0x06006AD0 RID: 27344 RVA: 0x001F9F08 File Offset: 0x001F8108
			// (set) Token: 0x06006AD1 RID: 27345 RVA: 0x0002A062 File Offset: 0x00028262
			public unsafe WormPlayer _firstHagalPlayer_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__firstHagalPlayer_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr__firstHagalPlayer_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CFE RID: 7422
			// (get) Token: 0x06006AD2 RID: 27346 RVA: 0x001F9F38 File Offset: 0x001F8138
			// (set) Token: 0x06006AD3 RID: 27347 RVA: 0x0002A081 File Offset: 0x00028281
			public unsafe IEnumerator<ArchetypeID> __7__wrap9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___7__wrap9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___7__wrap9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001CFF RID: 7423
			// (get) Token: 0x06006AD4 RID: 27348 RVA: 0x001F9F68 File Offset: 0x001F8168
			// (set) Token: 0x06006AD5 RID: 27349 RVA: 0x0002A0A0 File Offset: 0x000282A0
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___7__wrap10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetup_d__13.NativeFieldInfoPtr___7__wrap10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040044F6 RID: 17654
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040044F7 RID: 17655
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040044F8 RID: 17656
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040044F9 RID: 17657
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040044FA RID: 17658
			private static readonly IntPtr NativeFieldInfoPtr__hagalMode_5__2;

			// Token: 0x040044FB RID: 17659
			private static readonly IntPtr NativeFieldInfoPtr__hagalDifficulty_5__3;

			// Token: 0x040044FC RID: 17660
			private static readonly IntPtr NativeFieldInfoPtr__humanPlayer_5__4;

			// Token: 0x040044FD RID: 17661
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x040044FE RID: 17662
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap5;

			// Token: 0x040044FF RID: 17663
			private static readonly IntPtr NativeFieldInfoPtr__player_5__7;

			// Token: 0x04004500 RID: 17664
			private static readonly IntPtr NativeFieldInfoPtr__bonusTroops_5__8;

			// Token: 0x04004501 RID: 17665
			private static readonly IntPtr NativeFieldInfoPtr__firstHagalPlayer_5__9;

			// Token: 0x04004502 RID: 17666
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap9;

			// Token: 0x04004503 RID: 17667
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap10;

			// Token: 0x04004504 RID: 17668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004505 RID: 17669
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004506 RID: 17670
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004507 RID: 17671
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004508 RID: 17672
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04004509 RID: 17673
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x0400450A RID: 17674
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x0400450B RID: 17675
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally5_Private_Void_0;

			// Token: 0x0400450C RID: 17676
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally6_Private_Void_0;

			// Token: 0x0400450D RID: 17677
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally7_Private_Void_0;

			// Token: 0x0400450E RID: 17678
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400450F RID: 17679
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004510 RID: 17680
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004511 RID: 17681
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004512 RID: 17682
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000774 RID: 1908
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<CompleteSetupExtra>d__14")]
		public sealed class _CompleteSetupExtra_d__14 : Object
		{
			// Token: 0x06006AD6 RID: 27350 RVA: 0x001F9F98 File Offset: 0x001F8198
			// Note: this type is marked as 'beforefieldinit'.
			static _CompleteSetupExtra_d__14()
			{
				Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<CompleteSetupExtra>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr);
				SetupPhase._CompleteSetupExtra_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr, "<>1__state");
				SetupPhase._CompleteSetupExtra_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr, "<>2__current");
				SetupPhase._CompleteSetupExtra_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr, "<>l__initialThreadId");
				SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr, 100670237);
				SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr, 100670238);
				SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr, 100670239);
				SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr, 100670240);
				SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr, 100670241);
				SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr, 100670242);
				SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr, 100670243);
				SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr, 100670244);
			}

			// Token: 0x06006AD7 RID: 27351 RVA: 0x001FA0A0 File Offset: 0x001F82A0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CompleteSetupExtra_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase._CompleteSetupExtra_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006AD8 RID: 27352 RVA: 0x001FA0E8 File Offset: 0x001F82E8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006AD9 RID: 27353 RVA: 0x001FA11C File Offset: 0x001F831C
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D05 RID: 7429
			// (get) Token: 0x06006ADA RID: 27354 RVA: 0x001FA158 File Offset: 0x001F8358
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006ADB RID: 27355 RVA: 0x001FA198 File Offset: 0x001F8398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168182, XrefRangeEnd = 168187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D06 RID: 7430
			// (get) Token: 0x06006ADC RID: 27356 RVA: 0x001FA1CC File Offset: 0x001F83CC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006ADD RID: 27357 RVA: 0x001FA20C File Offset: 0x001F840C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168187, XrefRangeEnd = 168189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006ADE RID: 27358 RVA: 0x001FA24C File Offset: 0x001F844C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CompleteSetupExtra_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006ADF RID: 27359 RVA: 0x0002A0BF File Offset: 0x000282BF
			public _CompleteSetupExtra_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D02 RID: 7426
			// (get) Token: 0x06006AE0 RID: 27360 RVA: 0x001FA28C File Offset: 0x001F848C
			// (set) Token: 0x06006AE1 RID: 27361 RVA: 0x0002A0C8 File Offset: 0x000282C8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetupExtra_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetupExtra_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D03 RID: 7427
			// (get) Token: 0x06006AE2 RID: 27362 RVA: 0x001FA2B4 File Offset: 0x001F84B4
			// (set) Token: 0x06006AE3 RID: 27363 RVA: 0x0002A0E3 File Offset: 0x000282E3
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetupExtra_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetupExtra_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D04 RID: 7428
			// (get) Token: 0x06006AE4 RID: 27364 RVA: 0x001FA2E4 File Offset: 0x001F84E4
			// (set) Token: 0x06006AE5 RID: 27365 RVA: 0x0002A102 File Offset: 0x00028302
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetupExtra_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CompleteSetupExtra_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x04004513 RID: 17683
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004514 RID: 17684
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004515 RID: 17685
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004516 RID: 17686
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004517 RID: 17687
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004518 RID: 17688
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004519 RID: 17689
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400451A RID: 17690
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400451B RID: 17691
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400451C RID: 17692
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400451D RID: 17693
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000775 RID: 1909
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<CreateDecks>d__8")]
		public sealed class _CreateDecks_d__8 : Object
		{
			// Token: 0x06006AE6 RID: 27366 RVA: 0x001FA30C File Offset: 0x001F850C
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateDecks_d__8()
			{
				Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<CreateDecks>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr);
				SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, "<>1__state");
				SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, "<>2__current");
				SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, "<>l__initialThreadId");
				SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, "<>4__this");
				SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, "<>7__wrap1");
				SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, 100670245);
				SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, 100670246);
				SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, 100670247);
				SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, 100670248);
				SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, 100670249);
				SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, 100670250);
				SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, 100670251);
				SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, 100670252);
				SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr, 100670253);
			}

			// Token: 0x06006AE7 RID: 27367 RVA: 0x001FA450 File Offset: 0x001F8650
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CreateDecks_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase._CreateDecks_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006AE8 RID: 27368 RVA: 0x001FA498 File Offset: 0x001F8698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168189, XrefRangeEnd = 168194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006AE9 RID: 27369 RVA: 0x001FA4CC File Offset: 0x001F86CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168194, XrefRangeEnd = 169069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006AEA RID: 27370 RVA: 0x001FA508 File Offset: 0x001F8708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169069, XrefRangeEnd = 169072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D0C RID: 7436
			// (get) Token: 0x06006AEB RID: 27371 RVA: 0x001FA53C File Offset: 0x001F873C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006AEC RID: 27372 RVA: 0x001FA57C File Offset: 0x001F877C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169072, XrefRangeEnd = 169077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D0D RID: 7437
			// (get) Token: 0x06006AED RID: 27373 RVA: 0x001FA5B0 File Offset: 0x001F87B0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006AEE RID: 27374 RVA: 0x001FA5F0 File Offset: 0x001F87F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169077, XrefRangeEnd = 169079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006AEF RID: 27375 RVA: 0x001FA630 File Offset: 0x001F8830
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecks_d__8.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006AF0 RID: 27376 RVA: 0x0002A11D File Offset: 0x0002831D
			public _CreateDecks_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D07 RID: 7431
			// (get) Token: 0x06006AF1 RID: 27377 RVA: 0x001FA670 File Offset: 0x001F8870
			// (set) Token: 0x06006AF2 RID: 27378 RVA: 0x0002A126 File Offset: 0x00028326
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D08 RID: 7432
			// (get) Token: 0x06006AF3 RID: 27379 RVA: 0x001FA698 File Offset: 0x001F8898
			// (set) Token: 0x06006AF4 RID: 27380 RVA: 0x0002A141 File Offset: 0x00028341
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D09 RID: 7433
			// (get) Token: 0x06006AF5 RID: 27381 RVA: 0x001FA6C8 File Offset: 0x001F88C8
			// (set) Token: 0x06006AF6 RID: 27382 RVA: 0x0002A160 File Offset: 0x00028360
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001D0A RID: 7434
			// (get) Token: 0x06006AF7 RID: 27383 RVA: 0x001FA6F0 File Offset: 0x001F88F0
			// (set) Token: 0x06006AF8 RID: 27384 RVA: 0x0002A17B File Offset: 0x0002837B
			public unsafe SetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D0B RID: 7435
			// (get) Token: 0x06006AF9 RID: 27385 RVA: 0x001FA720 File Offset: 0x001F8920
			// (set) Token: 0x06006AFA RID: 27386 RVA: 0x0002A19A File Offset: 0x0002839A
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecks_d__8.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400451E RID: 17694
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400451F RID: 17695
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004520 RID: 17696
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004521 RID: 17697
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004522 RID: 17698
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04004523 RID: 17699
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004524 RID: 17700
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004525 RID: 17701
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004526 RID: 17702
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004527 RID: 17703
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004528 RID: 17704
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004529 RID: 17705
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400452A RID: 17706
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x0400452B RID: 17707
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000776 RID: 1910
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<CreateDecksExtra>d__9")]
		public sealed class _CreateDecksExtra_d__9 : Object
		{
			// Token: 0x06006AFB RID: 27387 RVA: 0x001FA750 File Offset: 0x001F8950
			// Note: this type is marked as 'beforefieldinit'.
			static _CreateDecksExtra_d__9()
			{
				Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<CreateDecksExtra>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr);
				SetupPhase._CreateDecksExtra_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr, "<>1__state");
				SetupPhase._CreateDecksExtra_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr, "<>2__current");
				SetupPhase._CreateDecksExtra_d__9.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr, "<>l__initialThreadId");
				SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr, 100670254);
				SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr, 100670255);
				SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr, 100670256);
				SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr, 100670257);
				SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr, 100670258);
				SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr, 100670259);
				SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr, 100670260);
				SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr, 100670261);
			}

			// Token: 0x06006AFC RID: 27388 RVA: 0x001FA858 File Offset: 0x001F8A58
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CreateDecksExtra_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase._CreateDecksExtra_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006AFD RID: 27389 RVA: 0x001FA8A0 File Offset: 0x001F8AA0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006AFE RID: 27390 RVA: 0x001FA8D4 File Offset: 0x001F8AD4
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D11 RID: 7441
			// (get) Token: 0x06006AFF RID: 27391 RVA: 0x001FA910 File Offset: 0x001F8B10
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006B00 RID: 27392 RVA: 0x001FA950 File Offset: 0x001F8B50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169079, XrefRangeEnd = 169084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D12 RID: 7442
			// (get) Token: 0x06006B01 RID: 27393 RVA: 0x001FA984 File Offset: 0x001F8B84
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006B02 RID: 27394 RVA: 0x001FA9C4 File Offset: 0x001F8BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169084, XrefRangeEnd = 169086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006B03 RID: 27395 RVA: 0x001FAA04 File Offset: 0x001F8C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._CreateDecksExtra_d__9.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006B04 RID: 27396 RVA: 0x0002A1B9 File Offset: 0x000283B9
			public _CreateDecksExtra_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D0E RID: 7438
			// (get) Token: 0x06006B05 RID: 27397 RVA: 0x001FAA44 File Offset: 0x001F8C44
			// (set) Token: 0x06006B06 RID: 27398 RVA: 0x0002A1C2 File Offset: 0x000283C2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecksExtra_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecksExtra_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D0F RID: 7439
			// (get) Token: 0x06006B07 RID: 27399 RVA: 0x001FAA6C File Offset: 0x001F8C6C
			// (set) Token: 0x06006B08 RID: 27400 RVA: 0x0002A1DD File Offset: 0x000283DD
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecksExtra_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecksExtra_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D10 RID: 7440
			// (get) Token: 0x06006B09 RID: 27401 RVA: 0x001FAA9C File Offset: 0x001F8C9C
			// (set) Token: 0x06006B0A RID: 27402 RVA: 0x0002A1FC File Offset: 0x000283FC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecksExtra_d__9.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._CreateDecksExtra_d__9.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x0400452C RID: 17708
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400452D RID: 17709
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400452E RID: 17710
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400452F RID: 17711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04004530 RID: 17712
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004531 RID: 17713
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004532 RID: 17714
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004533 RID: 17715
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004534 RID: 17716
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004535 RID: 17717
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004536 RID: 17718
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000777 RID: 1911
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<DraftDeckSetup>d__12")]
		public sealed class _DraftDeckSetup_d__12 : Object
		{
			// Token: 0x06006B0B RID: 27403 RVA: 0x001FAAC4 File Offset: 0x001F8CC4
			// Note: this type is marked as 'beforefieldinit'.
			static _DraftDeckSetup_d__12()
			{
				Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<DraftDeckSetup>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr);
				SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, "<>1__state");
				SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, "<>2__current");
				SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, "<>l__initialThreadId");
				SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, "<>4__this");
				SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, "<>7__wrap1");
				SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr__x_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, "<x>5__3");
				SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, 100670262);
				SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, 100670263);
				SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, 100670264);
				SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, 100670265);
				SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, 100670266);
				SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, 100670267);
				SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, 100670268);
				SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, 100670269);
				SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr, 100670270);
			}

			// Token: 0x06006B0C RID: 27404 RVA: 0x001FAC1C File Offset: 0x001F8E1C
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DraftDeckSetup_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase._DraftDeckSetup_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006B0D RID: 27405 RVA: 0x001FAC64 File Offset: 0x001F8E64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169086, XrefRangeEnd = 169091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006B0E RID: 27406 RVA: 0x001FAC98 File Offset: 0x001F8E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169091, XrefRangeEnd = 169183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006B0F RID: 27407 RVA: 0x001FACD4 File Offset: 0x001F8ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169183, XrefRangeEnd = 169186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D19 RID: 7449
			// (get) Token: 0x06006B10 RID: 27408 RVA: 0x001FAD08 File Offset: 0x001F8F08
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006B11 RID: 27409 RVA: 0x001FAD48 File Offset: 0x001F8F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169186, XrefRangeEnd = 169191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D1A RID: 7450
			// (get) Token: 0x06006B12 RID: 27410 RVA: 0x001FAD7C File Offset: 0x001F8F7C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006B13 RID: 27411 RVA: 0x001FADBC File Offset: 0x001F8FBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169191, XrefRangeEnd = 169193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006B14 RID: 27412 RVA: 0x001FADFC File Offset: 0x001F8FFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._DraftDeckSetup_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006B15 RID: 27413 RVA: 0x0002A217 File Offset: 0x00028417
			public _DraftDeckSetup_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D13 RID: 7443
			// (get) Token: 0x06006B16 RID: 27414 RVA: 0x001FAE3C File Offset: 0x001F903C
			// (set) Token: 0x06006B17 RID: 27415 RVA: 0x0002A220 File Offset: 0x00028420
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D14 RID: 7444
			// (get) Token: 0x06006B18 RID: 27416 RVA: 0x001FAE64 File Offset: 0x001F9064
			// (set) Token: 0x06006B19 RID: 27417 RVA: 0x0002A23B File Offset: 0x0002843B
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D15 RID: 7445
			// (get) Token: 0x06006B1A RID: 27418 RVA: 0x001FAE94 File Offset: 0x001F9094
			// (set) Token: 0x06006B1B RID: 27419 RVA: 0x0002A25A File Offset: 0x0002845A
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001D16 RID: 7446
			// (get) Token: 0x06006B1C RID: 27420 RVA: 0x001FAEBC File Offset: 0x001F90BC
			// (set) Token: 0x06006B1D RID: 27421 RVA: 0x0002A275 File Offset: 0x00028475
			public unsafe SetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D17 RID: 7447
			// (get) Token: 0x06006B1E RID: 27422 RVA: 0x001FAEEC File Offset: 0x001F90EC
			// (set) Token: 0x06006B1F RID: 27423 RVA: 0x0002A294 File Offset: 0x00028494
			public List<WormPlayer>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___7__wrap1);
					return new List<WormPlayer>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<WormPlayer>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001D18 RID: 7448
			// (get) Token: 0x06006B20 RID: 27424 RVA: 0x001FAF1C File Offset: 0x001F911C
			// (set) Token: 0x06006B21 RID: 27425 RVA: 0x0002A2C2 File Offset: 0x000284C2
			public unsafe int _x_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr__x_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._DraftDeckSetup_d__12.NativeFieldInfoPtr__x_5__3)) = value;
				}
			}

			// Token: 0x04004537 RID: 17719
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004538 RID: 17720
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004539 RID: 17721
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400453A RID: 17722
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400453B RID: 17723
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x0400453C RID: 17724
			private static readonly IntPtr NativeFieldInfoPtr__x_5__3;

			// Token: 0x0400453D RID: 17725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400453E RID: 17726
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400453F RID: 17727
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04004540 RID: 17728
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004541 RID: 17729
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004542 RID: 17730
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004543 RID: 17731
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004544 RID: 17732
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004545 RID: 17733
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000778 RID: 1912
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<EmitSerializedGameState>d__10")]
		public sealed class _EmitSerializedGameState_d__10 : Object
		{
			// Token: 0x06006B22 RID: 27426 RVA: 0x001FAF44 File Offset: 0x001F9144
			// Note: this type is marked as 'beforefieldinit'.
			static _EmitSerializedGameState_d__10()
			{
				Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<EmitSerializedGameState>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr);
				SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, "<>1__state");
				SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, "<>2__current");
				SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, "<>l__initialThreadId");
				SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, "<>4__this");
				SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr__serializedGameStateMsg_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, "<serializedGameStateMsg>5__2");
				SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, 100670271);
				SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, 100670272);
				SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, 100670273);
				SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, 100670274);
				SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, 100670275);
				SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, 100670276);
				SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, 100670277);
				SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr, 100670278);
			}

			// Token: 0x06006B23 RID: 27427 RVA: 0x001FB074 File Offset: 0x001F9274
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _EmitSerializedGameState_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase._EmitSerializedGameState_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006B24 RID: 27428 RVA: 0x001FB0BC File Offset: 0x001F92BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006B25 RID: 27429 RVA: 0x001FB0F0 File Offset: 0x001F92F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169193, XrefRangeEnd = 169233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001D20 RID: 7456
			// (get) Token: 0x06006B26 RID: 27430 RVA: 0x001FB12C File Offset: 0x001F932C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006B27 RID: 27431 RVA: 0x001FB16C File Offset: 0x001F936C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169233, XrefRangeEnd = 169238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D21 RID: 7457
			// (get) Token: 0x06006B28 RID: 27432 RVA: 0x001FB1A0 File Offset: 0x001F93A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006B29 RID: 27433 RVA: 0x001FB1E0 File Offset: 0x001F93E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169238, XrefRangeEnd = 169240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006B2A RID: 27434 RVA: 0x001FB220 File Offset: 0x001F9420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._EmitSerializedGameState_d__10.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006B2B RID: 27435 RVA: 0x0002A2DD File Offset: 0x000284DD
			public _EmitSerializedGameState_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D1B RID: 7451
			// (get) Token: 0x06006B2C RID: 27436 RVA: 0x001FB260 File Offset: 0x001F9460
			// (set) Token: 0x06006B2D RID: 27437 RVA: 0x0002A2E6 File Offset: 0x000284E6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D1C RID: 7452
			// (get) Token: 0x06006B2E RID: 27438 RVA: 0x001FB288 File Offset: 0x001F9488
			// (set) Token: 0x06006B2F RID: 27439 RVA: 0x0002A301 File Offset: 0x00028501
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D1D RID: 7453
			// (get) Token: 0x06006B30 RID: 27440 RVA: 0x001FB2B8 File Offset: 0x001F94B8
			// (set) Token: 0x06006B31 RID: 27441 RVA: 0x0002A320 File Offset: 0x00028520
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001D1E RID: 7454
			// (get) Token: 0x06006B32 RID: 27442 RVA: 0x001FB2E0 File Offset: 0x001F94E0
			// (set) Token: 0x06006B33 RID: 27443 RVA: 0x0002A33B File Offset: 0x0002853B
			public unsafe SetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D1F RID: 7455
			// (get) Token: 0x06006B34 RID: 27444 RVA: 0x001FB310 File Offset: 0x001F9510
			// (set) Token: 0x06006B35 RID: 27445 RVA: 0x0002A35A File Offset: 0x0002855A
			public unsafe SerializedGameState _serializedGameStateMsg_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr__serializedGameStateMsg_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._EmitSerializedGameState_d__10.NativeFieldInfoPtr__serializedGameStateMsg_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004546 RID: 17734
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004547 RID: 17735
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004548 RID: 17736
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004549 RID: 17737
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400454A RID: 17738
			private static readonly IntPtr NativeFieldInfoPtr__serializedGameStateMsg_5__2;

			// Token: 0x0400454B RID: 17739
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400454C RID: 17740
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400454D RID: 17741
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400454E RID: 17742
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400454F RID: 17743
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004550 RID: 17744
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004551 RID: 17745
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004552 RID: 17746
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000779 RID: 1913
		[ObfuscatedName("worm.canis.actions.phases.SetupPhase+<LeaderAssignment>d__11")]
		public sealed class _LeaderAssignment_d__11 : Object
		{
			// Token: 0x06006B36 RID: 27446 RVA: 0x001FB340 File Offset: 0x001F9540
			// Note: this type is marked as 'beforefieldinit'.
			static _LeaderAssignment_d__11()
			{
				Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetupPhase>.NativeClassPtr, "<LeaderAssignment>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr);
				SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, "<>1__state");
				SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, "<>2__current");
				SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, "<>l__initialThreadId");
				SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, "<>4__this");
				SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr__leaderArchetypes_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, "<leaderArchetypes>5__2");
				SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr__toTake_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, "<toTake>5__3");
				SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, "<>7__wrap3");
				SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr__options_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, "<options>5__5");
				SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr__assignLeader_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, "<assignLeader>5__6");
				SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, 100670279);
				SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, 100670280);
				SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, 100670281);
				SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, 100670282);
				SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, 100670283);
				SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, 100670284);
				SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, 100670285);
				SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, 100670286);
				SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, 100670287);
				SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr, 100670288);
			}

			// Token: 0x06006B37 RID: 27447 RVA: 0x001FB4E8 File Offset: 0x001F96E8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LeaderAssignment_d__11(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupPhase._LeaderAssignment_d__11>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06006B38 RID: 27448 RVA: 0x001FB530 File Offset: 0x001F9730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169240, XrefRangeEnd = 169250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006B39 RID: 27449 RVA: 0x001FB564 File Offset: 0x001F9764
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169250, XrefRangeEnd = 169532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06006B3A RID: 27450 RVA: 0x001FB5A0 File Offset: 0x001F97A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169532, XrefRangeEnd = 169535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06006B3B RID: 27451 RVA: 0x001FB5D4 File Offset: 0x001F97D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169535, XrefRangeEnd = 169538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D2B RID: 7467
			// (get) Token: 0x06006B3C RID: 27452 RVA: 0x001FB608 File Offset: 0x001F9808
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06006B3D RID: 27453 RVA: 0x001FB648 File Offset: 0x001F9848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169538, XrefRangeEnd = 169543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001D2C RID: 7468
			// (get) Token: 0x06006B3E RID: 27454 RVA: 0x001FB67C File Offset: 0x001F987C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06006B3F RID: 27455 RVA: 0x001FB6BC File Offset: 0x001F98BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 169543, XrefRangeEnd = 169545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06006B40 RID: 27456 RVA: 0x001FB6FC File Offset: 0x001F98FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetupPhase._LeaderAssignment_d__11.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06006B41 RID: 27457 RVA: 0x0002A379 File Offset: 0x00028579
			public _LeaderAssignment_d__11(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001D22 RID: 7458
			// (get) Token: 0x06006B42 RID: 27458 RVA: 0x001FB73C File Offset: 0x001F993C
			// (set) Token: 0x06006B43 RID: 27459 RVA: 0x0002A382 File Offset: 0x00028582
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001D23 RID: 7459
			// (get) Token: 0x06006B44 RID: 27460 RVA: 0x001FB764 File Offset: 0x001F9964
			// (set) Token: 0x06006B45 RID: 27461 RVA: 0x0002A39D File Offset: 0x0002859D
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D24 RID: 7460
			// (get) Token: 0x06006B46 RID: 27462 RVA: 0x001FB794 File Offset: 0x001F9994
			// (set) Token: 0x06006B47 RID: 27463 RVA: 0x0002A3BC File Offset: 0x000285BC
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17001D25 RID: 7461
			// (get) Token: 0x06006B48 RID: 27464 RVA: 0x001FB7BC File Offset: 0x001F99BC
			// (set) Token: 0x06006B49 RID: 27465 RVA: 0x0002A3D7 File Offset: 0x000285D7
			public unsafe SetupPhase __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetupPhase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D26 RID: 7462
			// (get) Token: 0x06006B4A RID: 27466 RVA: 0x001FB7EC File Offset: 0x001F99EC
			// (set) Token: 0x06006B4B RID: 27467 RVA: 0x0002A3F6 File Offset: 0x000285F6
			public unsafe List<ArchetypeID> _leaderArchetypes_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr__leaderArchetypes_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr__leaderArchetypes_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D27 RID: 7463
			// (get) Token: 0x06006B4C RID: 27468 RVA: 0x001FB81C File Offset: 0x001F9A1C
			// (set) Token: 0x06006B4D RID: 27469 RVA: 0x0002A415 File Offset: 0x00028615
			public unsafe int _toTake_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr__toTake_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr__toTake_5__3)) = value;
				}
			}

			// Token: 0x17001D28 RID: 7464
			// (get) Token: 0x06006B4E RID: 27470 RVA: 0x001FB844 File Offset: 0x001F9A44
			// (set) Token: 0x06006B4F RID: 27471 RVA: 0x0002A430 File Offset: 0x00028630
			public unsafe IEnumerator<WormPlayer> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<WormPlayer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D29 RID: 7465
			// (get) Token: 0x06006B50 RID: 27472 RVA: 0x001FB874 File Offset: 0x001F9A74
			// (set) Token: 0x06006B51 RID: 27473 RVA: 0x0002A44F File Offset: 0x0002864F
			public unsafe List<ArchetypeID> _options_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr__options_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ArchetypeID>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr__options_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001D2A RID: 7466
			// (get) Token: 0x06006B52 RID: 27474 RVA: 0x001FB8A4 File Offset: 0x001F9AA4
			// (set) Token: 0x06006B53 RID: 27475 RVA: 0x0002A46E File Offset: 0x0002866E
			public unsafe AssignLeader _assignLeader_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr__assignLeader_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssignLeader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SetupPhase._LeaderAssignment_d__11.NativeFieldInfoPtr__assignLeader_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004553 RID: 17747
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04004554 RID: 17748
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04004555 RID: 17749
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04004556 RID: 17750
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04004557 RID: 17751
			private static readonly IntPtr NativeFieldInfoPtr__leaderArchetypes_5__2;

			// Token: 0x04004558 RID: 17752
			private static readonly IntPtr NativeFieldInfoPtr__toTake_5__3;

			// Token: 0x04004559 RID: 17753
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x0400455A RID: 17754
			private static readonly IntPtr NativeFieldInfoPtr__options_5__5;

			// Token: 0x0400455B RID: 17755
			private static readonly IntPtr NativeFieldInfoPtr__assignLeader_5__6;

			// Token: 0x0400455C RID: 17756
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400455D RID: 17757
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400455E RID: 17758
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400455F RID: 17759
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04004560 RID: 17760
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04004561 RID: 17761
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04004562 RID: 17762
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04004563 RID: 17763
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04004564 RID: 17764
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04004565 RID: 17765
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
