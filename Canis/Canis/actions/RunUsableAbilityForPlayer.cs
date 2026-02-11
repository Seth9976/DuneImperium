using System;
using Canis.actions.serialized;
using Canis.actions.staged;
using Canis.context;
using Canis.context.targetpickers;
using Canis.entities;
using Canis.hasExecutionStack;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace Canis.actions
{
	// Token: 0x020001D7 RID: 471
	public class RunUsableAbilityForPlayer : Action
	{
		// Token: 0x060013C2 RID: 5058 RVA: 0x00069484 File Offset: 0x00067684
		// Note: this type is marked as 'beforefieldinit'.
		static RunUsableAbilityForPlayer()
		{
			Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "RunUsableAbilityForPlayer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr);
			RunUsableAbilityForPlayer.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "match");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr_abilityToRun = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "abilityToRun");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "player");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr__ActiveAbility_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "<ActiveAbility>k__BackingField");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr__ExecutingStack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "<ExecutingStack>k__BackingField");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr_skipTargeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "skipTargeting");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr_skipCosts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "skipCosts");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr_skipSelectedCosts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "skipSelectedCosts");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr_mayCancelAbility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "mayCancelAbility");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr_resolutionSourceOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "resolutionSourceOverride");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr_resolutionSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "resolutionSource");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr_parentUndoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "parentUndoNode");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr_skipUndoIfNoParentDefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "skipUndoIfNoParentDefined");
			RunUsableAbilityForPlayer.NativeFieldInfoPtr_currentSubState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "currentSubState");
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_get_ActiveAbility_Public_get_ActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667611);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_set_ActiveAbility_Private_set_Void_ActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667612);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_get_AbilityToRun_Public_get_IAbilityStateMachineDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667613);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_get_Player_Public_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667614);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_get_ExecutingStack_Public_Virtual_Final_New_get_IHasExecutionStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667615);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_set_ExecutingStack_Public_Virtual_Final_New_set_Void_IHasExecutionStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667616);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr__ctor_Public_Void_IAbilityStateMachineDefinition_PlayerEntity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667617);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr__ctor_Public_Void_ActiveAbility_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667618);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667619);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_WithTargeting_Public_RunUsableAbilityForPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667620);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_WithoutCosts_Public_RunUsableAbilityForPlayer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667621);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_WithResolutionSource_Public_RunUsableAbilityForPlayer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667622);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_MayCancelAbility_Public_RunUsableAbilityForPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667623);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_WithParentUndo_Public_RunUsableAbilityForPlayer_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667624);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_WithSkipUndoIfNoParentIsSet_Public_RunUsableAbilityForPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667625);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_get_TargetingContext_Private_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667626);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_GetTargetResponses_Public_Static_IEnumerable_1_TargetResponse_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667627);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_DecorateResolution_Private_Action_Action_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667628);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_RunResolution_Private_IEnumerable_1_Action_TargetResponseQueue_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667629);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_RunWithResponses_Private_IEnumerable_1_Action_TargetResponseQueue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667630);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_RunCompletion_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667631);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_RollbackQueued_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667632);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667633);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667634);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667635);
			RunUsableAbilityForPlayer.NativeMethodInfoPtr_Deserialize_Public_Static_RunUsableAbilityForPlayer_Match_SerializedRunUsableAbilityForPlayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, 100667636);
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x000697D4 File Offset: 0x000679D4
		// (set) Token: 0x060013C4 RID: 5060 RVA: 0x00069814 File Offset: 0x00067A14
		public unsafe ActiveAbility ActiveAbility
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_get_ActiveAbility_Public_get_ActiveAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ActiveAbility>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_set_ActiveAbility_Private_set_Void_ActiveAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x00069858 File Offset: 0x00067A58
		public unsafe IAbilityStateMachineDefinition AbilityToRun
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_get_AbilityToRun_Public_get_IAbilityStateMachineDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAbilityStateMachineDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060013C6 RID: 5062 RVA: 0x00069898 File Offset: 0x00067A98
		public unsafe PlayerEntity Player
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_get_Player_Public_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060013C7 RID: 5063 RVA: 0x000698D8 File Offset: 0x00067AD8
		// (set) Token: 0x060013C8 RID: 5064 RVA: 0x00069918 File Offset: 0x00067B18
		public unsafe virtual IHasExecutionStack ExecutingStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_get_ExecutingStack_Public_Virtual_Final_New_get_IHasExecutionStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasExecutionStack>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_set_ExecutingStack_Public_Virtual_Final_New_set_Void_IHasExecutionStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060013C9 RID: 5065 RVA: 0x0006995C File Offset: 0x00067B5C
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 588302, RefRangeEnd = 588321, XrefRangeStart = 588294, XrefRangeEnd = 588302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunUsableAbilityForPlayer(IAbilityStateMachineDefinition abilityToRun, PlayerEntity player, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(abilityToRun);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr__ctor_Public_Void_IAbilityStateMachineDefinition_PlayerEntity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013CA RID: 5066 RVA: 0x000699CC File Offset: 0x00067BCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 588336, RefRangeEnd = 588338, XrefRangeStart = 588321, XrefRangeEnd = 588336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunUsableAbilityForPlayer(ActiveAbility activeAbility, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(activeAbility);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr__ctor_Public_Void_ActiveAbility_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013CB RID: 5067 RVA: 0x00069A2C File Offset: 0x00067C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588338, XrefRangeEnd = 588342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunUsableAbilityForPlayer.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060013CC RID: 5068 RVA: 0x00069A70 File Offset: 0x00067C70
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 588342, RefRangeEnd = 588355, XrefRangeStart = 588342, XrefRangeEnd = 588342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunUsableAbilityForPlayer WithTargeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_WithTargeting_Public_RunUsableAbilityForPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer>(intPtr3) : null;
		}

		// Token: 0x060013CD RID: 5069 RVA: 0x00069AB0 File Offset: 0x00067CB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 588355, RefRangeEnd = 588360, XrefRangeStart = 588355, XrefRangeEnd = 588355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunUsableAbilityForPlayer WithoutCosts(bool skipSelectedCosts = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipSelectedCosts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_WithoutCosts_Public_RunUsableAbilityForPlayer_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer>(intPtr3) : null;
			}
		}

		// Token: 0x060013CE RID: 5070 RVA: 0x00069AFC File Offset: 0x00067CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588360, XrefRangeEnd = 588361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunUsableAbilityForPlayer WithResolutionSource(Entity overrideSource)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(overrideSource);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_WithResolutionSource_Public_RunUsableAbilityForPlayer_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer>(intPtr3) : null;
			}
		}

		// Token: 0x060013CF RID: 5071 RVA: 0x00069B4C File Offset: 0x00067D4C
		[CallerCount(0)]
		public unsafe RunUsableAbilityForPlayer MayCancelAbility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_MayCancelAbility_Public_RunUsableAbilityForPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer>(intPtr3) : null;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x00069B8C File Offset: 0x00067D8C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 588365, RefRangeEnd = 588372, XrefRangeStart = 588361, XrefRangeEnd = 588365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunUsableAbilityForPlayer WithParentUndo(UndoNode parentUndo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentUndo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_WithParentUndo_Public_RunUsableAbilityForPlayer_UndoNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer>(intPtr3) : null;
			}
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x00069BDC File Offset: 0x00067DDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 588372, RefRangeEnd = 588374, XrefRangeStart = 588372, XrefRangeEnd = 588372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunUsableAbilityForPlayer WithSkipUndoIfNoParentIsSet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_WithSkipUndoIfNoParentIsSet_Public_RunUsableAbilityForPlayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer>(intPtr3) : null;
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060013D2 RID: 5074 RVA: 0x00069C1C File Offset: 0x00067E1C
		public unsafe Context TargetingContext
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588374, XrefRangeEnd = 588375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_get_TargetingContext_Private_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x00069C5C File Offset: 0x00067E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 588381, RefRangeEnd = 588383, XrefRangeStart = 588375, XrefRangeEnd = 588381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<TargetResponse> GetTargetResponses(Context targetingContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetingContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_GetTargetResponses_Public_Static_IEnumerable_1_TargetResponse_Context_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetResponse>>(intPtr3) : null;
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x00069CA0 File Offset: 0x00067EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588383, XrefRangeEnd = 588385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action DecorateResolution(Action resolution, Context resolutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resolution);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_DecorateResolution_Private_Action_Action_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x00069D04 File Offset: 0x00067F04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 588393, RefRangeEnd = 588395, XrefRangeStart = 588385, XrefRangeEnd = 588393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> RunResolution(TargetResponseQueue responses, Context paramContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responses);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paramContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_RunResolution_Private_IEnumerable_1_Action_TargetResponseQueue_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x00069D68 File Offset: 0x00067F68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 588402, RefRangeEnd = 588405, XrefRangeStart = 588395, XrefRangeEnd = 588402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> RunWithResponses(TargetResponseQueue responses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responses);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_RunWithResponses_Private_IEnumerable_1_Action_TargetResponseQueue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x00069DB8 File Offset: 0x00067FB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 588411, RefRangeEnd = 588414, XrefRangeStart = 588405, XrefRangeEnd = 588411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> RunCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_RunCompletion_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x00069DF8 File Offset: 0x00067FF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 588420, RefRangeEnd = 588422, XrefRangeStart = 588414, XrefRangeEnd = 588420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Action> RollbackQueued()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_RollbackQueued_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x00069E38 File Offset: 0x00068038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588422, XrefRangeEnd = 588428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<Action> execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunUsableAbilityForPlayer.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Action>>(intPtr3) : null;
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x00069E84 File Offset: 0x00068084
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588428, XrefRangeEnd = 588468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HandleReturningAction(Action returningAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returningAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunUsableAbilityForPlayer.NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00069ED4 File Offset: 0x000680D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588468, XrefRangeEnd = 588488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedAction MakeSerializedAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunUsableAbilityForPlayer.NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedAction>(intPtr3) : null;
			}
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x00069F30 File Offset: 0x00068130
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 588534, RefRangeEnd = 588535, XrefRangeStart = 588488, XrefRangeEnd = 588534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RunUsableAbilityForPlayer Deserialize(Match match, SerializedRunUsableAbilityForPlayer serialized)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.NativeMethodInfoPtr_Deserialize_Public_Static_RunUsableAbilityForPlayer_Match_SerializedRunUsableAbilityForPlayer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer>(intPtr3) : null;
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x000099D0 File Offset: 0x00007BD0
		public RunUsableAbilityForPlayer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x00069F88 File Offset: 0x00068188
		// (set) Token: 0x060013DF RID: 5087 RVA: 0x000099D9 File Offset: 0x00007BD9
		public unsafe Match match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060013E0 RID: 5088 RVA: 0x00069FB8 File Offset: 0x000681B8
		// (set) Token: 0x060013E1 RID: 5089 RVA: 0x000099F8 File Offset: 0x00007BF8
		public unsafe IAbilityStateMachineDefinition abilityToRun
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_abilityToRun);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAbilityStateMachineDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_abilityToRun), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x00069FE8 File Offset: 0x000681E8
		// (set) Token: 0x060013E3 RID: 5091 RVA: 0x00009A17 File Offset: 0x00007C17
		public unsafe PlayerEntity player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x0006A018 File Offset: 0x00068218
		// (set) Token: 0x060013E5 RID: 5093 RVA: 0x00009A36 File Offset: 0x00007C36
		public unsafe ActiveAbility _ActiveAbility_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr__ActiveAbility_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActiveAbility>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr__ActiveAbility_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0006A048 File Offset: 0x00068248
		// (set) Token: 0x060013E7 RID: 5095 RVA: 0x00009A55 File Offset: 0x00007C55
		public unsafe IHasExecutionStack _ExecutingStack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr__ExecutingStack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasExecutionStack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr__ExecutingStack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0006A078 File Offset: 0x00068278
		// (set) Token: 0x060013E9 RID: 5097 RVA: 0x00009A74 File Offset: 0x00007C74
		public unsafe bool skipTargeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_skipTargeting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_skipTargeting)) = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0006A0A0 File Offset: 0x000682A0
		// (set) Token: 0x060013EB RID: 5099 RVA: 0x00009A8F File Offset: 0x00007C8F
		public unsafe bool skipCosts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_skipCosts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_skipCosts)) = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x0006A0C8 File Offset: 0x000682C8
		// (set) Token: 0x060013ED RID: 5101 RVA: 0x00009AAA File Offset: 0x00007CAA
		public unsafe bool skipSelectedCosts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_skipSelectedCosts);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_skipSelectedCosts)) = value;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x0006A0F0 File Offset: 0x000682F0
		// (set) Token: 0x060013EF RID: 5103 RVA: 0x00009AC5 File Offset: 0x00007CC5
		public unsafe bool mayCancelAbility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_mayCancelAbility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_mayCancelAbility)) = value;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x0006A118 File Offset: 0x00068318
		// (set) Token: 0x060013F1 RID: 5105 RVA: 0x00009AE0 File Offset: 0x00007CE0
		public unsafe Entity resolutionSourceOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_resolutionSourceOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_resolutionSourceOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x0006A148 File Offset: 0x00068348
		// (set) Token: 0x060013F3 RID: 5107 RVA: 0x00009AFF File Offset: 0x00007CFF
		public unsafe Entity resolutionSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_resolutionSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_resolutionSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x0006A178 File Offset: 0x00068378
		// (set) Token: 0x060013F5 RID: 5109 RVA: 0x00009B1E File Offset: 0x00007D1E
		public unsafe UndoNode parentUndoNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_parentUndoNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_parentUndoNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0006A1A8 File Offset: 0x000683A8
		// (set) Token: 0x060013F7 RID: 5111 RVA: 0x00009B3D File Offset: 0x00007D3D
		public unsafe bool skipUndoIfNoParentDefined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_skipUndoIfNoParentDefined);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_skipUndoIfNoParentDefined)) = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x0006A1D0 File Offset: 0x000683D0
		// (set) Token: 0x060013F9 RID: 5113 RVA: 0x00009B58 File Offset: 0x00007D58
		public unsafe RunUsableAbilityForPlayer.SubState currentSubState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_currentSubState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer.NativeFieldInfoPtr_currentSubState)) = value;
			}
		}

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeFieldInfoPtr_match;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeFieldInfoPtr_abilityToRun;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeFieldInfoPtr_player;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeFieldInfoPtr__ActiveAbility_k__BackingField;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeFieldInfoPtr__ExecutingStack_k__BackingField;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeFieldInfoPtr_skipTargeting;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeFieldInfoPtr_skipCosts;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeFieldInfoPtr_skipSelectedCosts;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeFieldInfoPtr_mayCancelAbility;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeFieldInfoPtr_resolutionSourceOverride;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeFieldInfoPtr_resolutionSource;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeFieldInfoPtr_parentUndoNode;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeFieldInfoPtr_skipUndoIfNoParentDefined;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeFieldInfoPtr_currentSubState;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAbility_Public_get_ActiveAbility_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveAbility_Private_set_Void_ActiveAbility_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilityToRun_Public_get_IAbilityStateMachineDefinition_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr_get_Player_Public_get_PlayerEntity_0;

		// Token: 0x04000CDF RID: 3295
		private static readonly IntPtr NativeMethodInfoPtr_get_ExecutingStack_Public_Virtual_Final_New_get_IHasExecutionStack_0;

		// Token: 0x04000CE0 RID: 3296
		private static readonly IntPtr NativeMethodInfoPtr_set_ExecutingStack_Public_Virtual_Final_New_set_Void_IHasExecutionStack_0;

		// Token: 0x04000CE1 RID: 3297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAbilityStateMachineDefinition_PlayerEntity_Match_0;

		// Token: 0x04000CE2 RID: 3298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ActiveAbility_Match_0;

		// Token: 0x04000CE3 RID: 3299
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000CE4 RID: 3300
		private static readonly IntPtr NativeMethodInfoPtr_WithTargeting_Public_RunUsableAbilityForPlayer_0;

		// Token: 0x04000CE5 RID: 3301
		private static readonly IntPtr NativeMethodInfoPtr_WithoutCosts_Public_RunUsableAbilityForPlayer_Boolean_0;

		// Token: 0x04000CE6 RID: 3302
		private static readonly IntPtr NativeMethodInfoPtr_WithResolutionSource_Public_RunUsableAbilityForPlayer_Entity_0;

		// Token: 0x04000CE7 RID: 3303
		private static readonly IntPtr NativeMethodInfoPtr_MayCancelAbility_Public_RunUsableAbilityForPlayer_0;

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeMethodInfoPtr_WithParentUndo_Public_RunUsableAbilityForPlayer_UndoNode_0;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr_WithSkipUndoIfNoParentIsSet_Public_RunUsableAbilityForPlayer_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetingContext_Private_get_Context_0;

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetResponses_Public_Static_IEnumerable_1_TargetResponse_Context_0;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr_DecorateResolution_Private_Action_Action_Context_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr_RunResolution_Private_IEnumerable_1_Action_TargetResponseQueue_Context_0;

		// Token: 0x04000CEE RID: 3310
		private static readonly IntPtr NativeMethodInfoPtr_RunWithResponses_Private_IEnumerable_1_Action_TargetResponseQueue_0;

		// Token: 0x04000CEF RID: 3311
		private static readonly IntPtr NativeMethodInfoPtr_RunCompletion_Private_IEnumerable_1_Action_0;

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_RollbackQueued_Private_IEnumerable_1_Action_0;

		// Token: 0x04000CF1 RID: 3313
		private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

		// Token: 0x04000CF2 RID: 3314
		private static readonly IntPtr NativeMethodInfoPtr_HandleReturningAction_Public_Virtual_Void_Action_0;

		// Token: 0x04000CF3 RID: 3315
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedAction_Protected_Virtual_SerializedAction_Match_0;

		// Token: 0x04000CF4 RID: 3316
		private static readonly IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_RunUsableAbilityForPlayer_Match_SerializedRunUsableAbilityForPlayer_0;

		// Token: 0x0200040E RID: 1038
		public enum SubState
		{
			// Token: 0x04001C33 RID: 7219
			StartActiveAbilitySubState = 10,
			// Token: 0x04001C34 RID: 7220
			ExecutingActiveAbilitySubState = 20,
			// Token: 0x04001C35 RID: 7221
			CompletedActiveAbilitySubState = 30
		}

		// Token: 0x0200040F RID: 1039
		[ObfuscatedName("Canis.actions.RunUsableAbilityForPlayer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002D0E RID: 11534 RVA: 0x000BE868 File Offset: 0x000BCA68
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunUsableAbilityForPlayer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunUsableAbilityForPlayer.__c>.NativeClassPtr);
				RunUsableAbilityForPlayer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer.__c>.NativeClassPtr, "<>9");
				RunUsableAbilityForPlayer.__c.NativeFieldInfoPtr___9__42_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer.__c>.NativeClassPtr, "<>9__42_0");
				RunUsableAbilityForPlayer.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer.__c>.NativeClassPtr, "<>9__43_0");
				RunUsableAbilityForPlayer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer.__c>.NativeClassPtr, 100667638);
				RunUsableAbilityForPlayer.__c.NativeMethodInfoPtr__execute_b__42_0_Internal_Boolean_TargetInformation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer.__c>.NativeClassPtr, 100667639);
				RunUsableAbilityForPlayer.__c.NativeMethodInfoPtr__HandleReturningAction_b__43_0_Internal_Int32_ValueTuple_2_Int32_SerializedStagedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer.__c>.NativeClassPtr, 100667640);
			}

			// Token: 0x06002D0F RID: 11535 RVA: 0x000BE90C File Offset: 0x000BCB0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunUsableAbilityForPlayer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D10 RID: 11536 RVA: 0x000BE948 File Offset: 0x000BCB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__42_0(TargetInformation _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.__c.NativeMethodInfoPtr__execute_b__42_0_Internal_Boolean_TargetInformation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D11 RID: 11537 RVA: 0x000BE998 File Offset: 0x000BCB98
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 507920, RefRangeEnd = 507929, XrefRangeStart = 507920, XrefRangeEnd = 507929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _HandleReturningAction_b__43_0(ValueTuple<int, SerializedStagedAction> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer.__c.NativeMethodInfoPtr__HandleReturningAction_b__43_0_Internal_Int32_ValueTuple_2_Int32_SerializedStagedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002D12 RID: 11538 RVA: 0x0001583B File Offset: 0x00013A3B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BA2 RID: 2978
			// (get) Token: 0x06002D13 RID: 11539 RVA: 0x000BE9EC File Offset: 0x000BCBEC
			// (set) Token: 0x06002D14 RID: 11540 RVA: 0x00015844 File Offset: 0x00013A44
			public unsafe static RunUsableAbilityForPlayer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunUsableAbilityForPlayer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunUsableAbilityForPlayer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA3 RID: 2979
			// (get) Token: 0x06002D15 RID: 11541 RVA: 0x000BEA14 File Offset: 0x000BCC14
			// (set) Token: 0x06002D16 RID: 11542 RVA: 0x00015856 File Offset: 0x00013A56
			public unsafe static Func<TargetInformation, bool> __9__42_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunUsableAbilityForPlayer.__c.NativeFieldInfoPtr___9__42_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TargetInformation, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunUsableAbilityForPlayer.__c.NativeFieldInfoPtr___9__42_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA4 RID: 2980
			// (get) Token: 0x06002D17 RID: 11543 RVA: 0x000BEA3C File Offset: 0x000BCC3C
			// (set) Token: 0x06002D18 RID: 11544 RVA: 0x00015868 File Offset: 0x00013A68
			public unsafe static Func<ValueTuple<int, SerializedStagedAction>, int> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunUsableAbilityForPlayer.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, SerializedStagedAction>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunUsableAbilityForPlayer.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C36 RID: 7222
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001C37 RID: 7223
			private static readonly IntPtr NativeFieldInfoPtr___9__42_0;

			// Token: 0x04001C38 RID: 7224
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x04001C39 RID: 7225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C3A RID: 7226
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__42_0_Internal_Boolean_TargetInformation_0;

			// Token: 0x04001C3B RID: 7227
			private static readonly IntPtr NativeMethodInfoPtr__HandleReturningAction_b__43_0_Internal_Int32_ValueTuple_2_Int32_SerializedStagedAction_0;
		}

		// Token: 0x02000410 RID: 1040
		[ObfuscatedName("Canis.actions.RunUsableAbilityForPlayer+<GetTargetResponses>d__36")]
		public sealed class _GetTargetResponses_d__36 : Object
		{
			// Token: 0x06002D19 RID: 11545 RVA: 0x000BEA64 File Offset: 0x000BCC64
			// Note: this type is marked as 'beforefieldinit'.
			static _GetTargetResponses_d__36()
			{
				Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "<GetTargetResponses>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr);
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, "<>1__state");
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, "<>2__current");
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, "<>l__initialThreadId");
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr_targetingContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, "targetingContext");
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___3__targetingContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, "<>3__targetingContext");
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, "<>7__wrap1");
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, "<>7__wrap2");
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr__queue_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, "<queue>5__4");
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, 100667641);
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, 100667642);
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, 100667643);
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetresponse_TargetResponse__get_Current_Private_Virtual_Final_New_get_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, 100667644);
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, 100667645);
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, 100667646);
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetresponse_TargetResponse__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, 100667647);
				RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr, 100667648);
			}

			// Token: 0x06002D1A RID: 11546 RVA: 0x000BEBD0 File Offset: 0x000BCDD0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetTargetResponses_d__36(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunUsableAbilityForPlayer._GetTargetResponses_d__36>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D1B RID: 11547 RVA: 0x000BEC18 File Offset: 0x000BCE18
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D1C RID: 11548 RVA: 0x000BEC4C File Offset: 0x000BCE4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587435, XrefRangeEnd = 587443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000BAD RID: 2989
			// (get) Token: 0x06002D1D RID: 11549 RVA: 0x000BEC88 File Offset: 0x000BCE88
			public unsafe TargetResponse System.Collections.Generic.IEnumerator<Networking.selection.targetresponse.TargetResponse>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetresponse_TargetResponse__get_Current_Private_Virtual_Final_New_get_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr3) : null;
				}
			}

			// Token: 0x06002D1E RID: 11550 RVA: 0x000BECC8 File Offset: 0x000BCEC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587443, XrefRangeEnd = 587448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BAE RID: 2990
			// (get) Token: 0x06002D1F RID: 11551 RVA: 0x000BECFC File Offset: 0x000BCEFC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D20 RID: 11552 RVA: 0x000BED3C File Offset: 0x000BCF3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587448, XrefRangeEnd = 587456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetResponse> System_Collections_Generic_IEnumerable_Networking_selection_targetresponse_TargetResponse__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetresponse_TargetResponse__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetResponse>>(intPtr3) : null;
			}

			// Token: 0x06002D21 RID: 11553 RVA: 0x000BED7C File Offset: 0x000BCF7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002D22 RID: 11554 RVA: 0x0001587A File Offset: 0x00013A7A
			public _GetTargetResponses_d__36(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BA5 RID: 2981
			// (get) Token: 0x06002D23 RID: 11555 RVA: 0x000BEDBC File Offset: 0x000BCFBC
			// (set) Token: 0x06002D24 RID: 11556 RVA: 0x00015883 File Offset: 0x00013A83
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BA6 RID: 2982
			// (get) Token: 0x06002D25 RID: 11557 RVA: 0x000BEDE4 File Offset: 0x000BCFE4
			// (set) Token: 0x06002D26 RID: 11558 RVA: 0x0001589E File Offset: 0x00013A9E
			public unsafe TargetResponse __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA7 RID: 2983
			// (get) Token: 0x06002D27 RID: 11559 RVA: 0x000BEE14 File Offset: 0x000BD014
			// (set) Token: 0x06002D28 RID: 11560 RVA: 0x000158BD File Offset: 0x00013ABD
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000BA8 RID: 2984
			// (get) Token: 0x06002D29 RID: 11561 RVA: 0x000BEE3C File Offset: 0x000BD03C
			// (set) Token: 0x06002D2A RID: 11562 RVA: 0x000158D8 File Offset: 0x00013AD8
			public unsafe Context targetingContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr_targetingContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr_targetingContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BA9 RID: 2985
			// (get) Token: 0x06002D2B RID: 11563 RVA: 0x000BEE6C File Offset: 0x000BD06C
			// (set) Token: 0x06002D2C RID: 11564 RVA: 0x000158F7 File Offset: 0x00013AF7
			public unsafe Context __3__targetingContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___3__targetingContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___3__targetingContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BAA RID: 2986
			// (get) Token: 0x06002D2D RID: 11565 RVA: 0x000BEE9C File Offset: 0x000BD09C
			// (set) Token: 0x06002D2E RID: 11566 RVA: 0x00015916 File Offset: 0x00013B16
			public unsafe Il2CppReferenceArray<TargetResponse> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TargetResponse>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BAB RID: 2987
			// (get) Token: 0x06002D2F RID: 11567 RVA: 0x000BEECC File Offset: 0x000BD0CC
			// (set) Token: 0x06002D30 RID: 11568 RVA: 0x00015935 File Offset: 0x00013B35
			public unsafe int __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___7__wrap2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr___7__wrap2)) = value;
				}
			}

			// Token: 0x17000BAC RID: 2988
			// (get) Token: 0x06002D31 RID: 11569 RVA: 0x000BEEF4 File Offset: 0x000BD0F4
			// (set) Token: 0x06002D32 RID: 11570 RVA: 0x00015950 File Offset: 0x00013B50
			public unsafe TargetResponseQueue _queue_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr__queue_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponseQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._GetTargetResponses_d__36.NativeFieldInfoPtr__queue_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C3C RID: 7228
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C3D RID: 7229
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C3E RID: 7230
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001C3F RID: 7231
			private static readonly IntPtr NativeFieldInfoPtr_targetingContext;

			// Token: 0x04001C40 RID: 7232
			private static readonly IntPtr NativeFieldInfoPtr___3__targetingContext;

			// Token: 0x04001C41 RID: 7233
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001C42 RID: 7234
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001C43 RID: 7235
			private static readonly IntPtr NativeFieldInfoPtr__queue_5__4;

			// Token: 0x04001C44 RID: 7236
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C45 RID: 7237
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C46 RID: 7238
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C47 RID: 7239
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetresponse_TargetResponse__get_Current_Private_Virtual_Final_New_get_TargetResponse_0;

			// Token: 0x04001C48 RID: 7240
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C49 RID: 7241
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C4A RID: 7242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetresponse_TargetResponse__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetResponse_0;

			// Token: 0x04001C4B RID: 7243
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000411 RID: 1041
		[ObfuscatedName("Canis.actions.RunUsableAbilityForPlayer+<RollbackQueued>d__41")]
		public sealed class _RollbackQueued_d__41 : Object
		{
			// Token: 0x06002D33 RID: 11571 RVA: 0x000BEF24 File Offset: 0x000BD124
			// Note: this type is marked as 'beforefieldinit'.
			static _RollbackQueued_d__41()
			{
				Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "<RollbackQueued>d__41");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr);
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, "<>1__state");
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, "<>2__current");
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, "<>l__initialThreadId");
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, "<>4__this");
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr__toRollback_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, "<toRollback>5__2");
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, "<>7__wrap2");
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr__rolledbackState_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, "<rolledbackState>5__4");
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr__toRestore_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, "<toRestore>5__5");
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, "<i>5__6");
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___7__wrap6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, "<>7__wrap6");
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, 100667649);
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, 100667650);
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, 100667651);
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, 100667652);
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, 100667653);
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, 100667654);
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, 100667655);
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, 100667656);
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, 100667657);
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, 100667658);
				RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr, 100667659);
			}

			// Token: 0x06002D34 RID: 11572 RVA: 0x000BF0F4 File Offset: 0x000BD2F4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RollbackQueued_d__41(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RollbackQueued_d__41>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D35 RID: 11573 RVA: 0x000BF13C File Offset: 0x000BD33C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587456, XrefRangeEnd = 587474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D36 RID: 11574 RVA: 0x000BF170 File Offset: 0x000BD370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587474, XrefRangeEnd = 587574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002D37 RID: 11575 RVA: 0x000BF1AC File Offset: 0x000BD3AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587574, XrefRangeEnd = 587577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D38 RID: 11576 RVA: 0x000BF1E0 File Offset: 0x000BD3E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587577, XrefRangeEnd = 587580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D39 RID: 11577 RVA: 0x000BF214 File Offset: 0x000BD414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587580, XrefRangeEnd = 587583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BB9 RID: 3001
			// (get) Token: 0x06002D3A RID: 11578 RVA: 0x000BF248 File Offset: 0x000BD448
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002D3B RID: 11579 RVA: 0x000BF288 File Offset: 0x000BD488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587583, XrefRangeEnd = 587588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BBA RID: 3002
			// (get) Token: 0x06002D3C RID: 11580 RVA: 0x000BF2BC File Offset: 0x000BD4BC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D3D RID: 11581 RVA: 0x000BF2FC File Offset: 0x000BD4FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587588, XrefRangeEnd = 587590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002D3E RID: 11582 RVA: 0x000BF33C File Offset: 0x000BD53C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002D3F RID: 11583 RVA: 0x0001596F File Offset: 0x00013B6F
			public _RollbackQueued_d__41(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BAF RID: 2991
			// (get) Token: 0x06002D40 RID: 11584 RVA: 0x000BF37C File Offset: 0x000BD57C
			// (set) Token: 0x06002D41 RID: 11585 RVA: 0x00015978 File Offset: 0x00013B78
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BB0 RID: 2992
			// (get) Token: 0x06002D42 RID: 11586 RVA: 0x000BF3A4 File Offset: 0x000BD5A4
			// (set) Token: 0x06002D43 RID: 11587 RVA: 0x00015993 File Offset: 0x00013B93
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BB1 RID: 2993
			// (get) Token: 0x06002D44 RID: 11588 RVA: 0x000BF3D4 File Offset: 0x000BD5D4
			// (set) Token: 0x06002D45 RID: 11589 RVA: 0x000159B2 File Offset: 0x00013BB2
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000BB2 RID: 2994
			// (get) Token: 0x06002D46 RID: 11590 RVA: 0x000BF3FC File Offset: 0x000BD5FC
			// (set) Token: 0x06002D47 RID: 11591 RVA: 0x000159CD File Offset: 0x00013BCD
			public unsafe RunUsableAbilityForPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BB3 RID: 2995
			// (get) Token: 0x06002D48 RID: 11592 RVA: 0x000BF42C File Offset: 0x000BD62C
			// (set) Token: 0x06002D49 RID: 11593 RVA: 0x000159EC File Offset: 0x00013BEC
			public unsafe List<int> _toRollback_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr__toRollback_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr__toRollback_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BB4 RID: 2996
			// (get) Token: 0x06002D4A RID: 11594 RVA: 0x000BF45C File Offset: 0x000BD65C
			// (set) Token: 0x06002D4B RID: 11595 RVA: 0x00015A0B File Offset: 0x00013C0B
			public List<int>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___7__wrap2);
					return new List<int>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<int>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000BB5 RID: 2997
			// (get) Token: 0x06002D4C RID: 11596 RVA: 0x000BF48C File Offset: 0x000BD68C
			// (set) Token: 0x06002D4D RID: 11597 RVA: 0x00015A39 File Offset: 0x00013C39
			public unsafe int _rolledbackState_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr__rolledbackState_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr__rolledbackState_5__4)) = value;
				}
			}

			// Token: 0x17000BB6 RID: 2998
			// (get) Token: 0x06002D4E RID: 11598 RVA: 0x000BF4B4 File Offset: 0x000BD6B4
			// (set) Token: 0x06002D4F RID: 11599 RVA: 0x00015A54 File Offset: 0x00013C54
			public unsafe List<SerializedStagedAction> _toRestore_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr__toRestore_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SerializedStagedAction>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr__toRestore_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BB7 RID: 2999
			// (get) Token: 0x06002D50 RID: 11600 RVA: 0x000BF4E4 File Offset: 0x000BD6E4
			// (set) Token: 0x06002D51 RID: 11601 RVA: 0x00015A73 File Offset: 0x00013C73
			public unsafe int _i_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr__i_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr__i_5__6)) = value;
				}
			}

			// Token: 0x17000BB8 RID: 3000
			// (get) Token: 0x06002D52 RID: 11602 RVA: 0x000BF50C File Offset: 0x000BD70C
			// (set) Token: 0x06002D53 RID: 11603 RVA: 0x00015A8E File Offset: 0x00013C8E
			public unsafe IEnumerator<Action> __7__wrap6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___7__wrap6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RollbackQueued_d__41.NativeFieldInfoPtr___7__wrap6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C4C RID: 7244
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C4D RID: 7245
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C4E RID: 7246
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001C4F RID: 7247
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C50 RID: 7248
			private static readonly IntPtr NativeFieldInfoPtr__toRollback_5__2;

			// Token: 0x04001C51 RID: 7249
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04001C52 RID: 7250
			private static readonly IntPtr NativeFieldInfoPtr__rolledbackState_5__4;

			// Token: 0x04001C53 RID: 7251
			private static readonly IntPtr NativeFieldInfoPtr__toRestore_5__5;

			// Token: 0x04001C54 RID: 7252
			private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

			// Token: 0x04001C55 RID: 7253
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap6;

			// Token: 0x04001C56 RID: 7254
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C57 RID: 7255
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C58 RID: 7256
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C59 RID: 7257
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001C5A RID: 7258
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001C5B RID: 7259
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04001C5C RID: 7260
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001C5D RID: 7261
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C5E RID: 7262
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C5F RID: 7263
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001C60 RID: 7264
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000412 RID: 1042
		[ObfuscatedName("Canis.actions.RunUsableAbilityForPlayer+<RunCompletion>d__40")]
		public sealed class _RunCompletion_d__40 : Object
		{
			// Token: 0x06002D54 RID: 11604 RVA: 0x000BF53C File Offset: 0x000BD73C
			// Note: this type is marked as 'beforefieldinit'.
			static _RunCompletion_d__40()
			{
				Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "<RunCompletion>d__40");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr);
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, "<>1__state");
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, "<>2__current");
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, "<>l__initialThreadId");
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, "<>4__this");
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, "<>7__wrap1");
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, 100667660);
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, 100667661);
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, 100667662);
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, 100667663);
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, 100667664);
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, 100667665);
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, 100667666);
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, 100667667);
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, 100667668);
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, 100667669);
				RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr, 100667670);
			}

			// Token: 0x06002D55 RID: 11605 RVA: 0x000BF6A8 File Offset: 0x000BD8A8
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunCompletion_d__40(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunCompletion_d__40>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D56 RID: 11606 RVA: 0x000BF6F0 File Offset: 0x000BD8F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587590, XrefRangeEnd = 587605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D57 RID: 11607 RVA: 0x000BF724 File Offset: 0x000BD924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587605, XrefRangeEnd = 587683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002D58 RID: 11608 RVA: 0x000BF760 File Offset: 0x000BD960
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587683, XrefRangeEnd = 587686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D59 RID: 11609 RVA: 0x000BF794 File Offset: 0x000BD994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587686, XrefRangeEnd = 587689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D5A RID: 11610 RVA: 0x000BF7C8 File Offset: 0x000BD9C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587689, XrefRangeEnd = 587692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BC0 RID: 3008
			// (get) Token: 0x06002D5B RID: 11611 RVA: 0x000BF7FC File Offset: 0x000BD9FC
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002D5C RID: 11612 RVA: 0x000BF83C File Offset: 0x000BDA3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587692, XrefRangeEnd = 587697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BC1 RID: 3009
			// (get) Token: 0x06002D5D RID: 11613 RVA: 0x000BF870 File Offset: 0x000BDA70
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D5E RID: 11614 RVA: 0x000BF8B0 File Offset: 0x000BDAB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587697, XrefRangeEnd = 587699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002D5F RID: 11615 RVA: 0x000BF8F0 File Offset: 0x000BDAF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002D60 RID: 11616 RVA: 0x00015AAD File Offset: 0x00013CAD
			public _RunCompletion_d__40(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BBB RID: 3003
			// (get) Token: 0x06002D61 RID: 11617 RVA: 0x000BF930 File Offset: 0x000BDB30
			// (set) Token: 0x06002D62 RID: 11618 RVA: 0x00015AB6 File Offset: 0x00013CB6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BBC RID: 3004
			// (get) Token: 0x06002D63 RID: 11619 RVA: 0x000BF958 File Offset: 0x000BDB58
			// (set) Token: 0x06002D64 RID: 11620 RVA: 0x00015AD1 File Offset: 0x00013CD1
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBD RID: 3005
			// (get) Token: 0x06002D65 RID: 11621 RVA: 0x000BF988 File Offset: 0x000BDB88
			// (set) Token: 0x06002D66 RID: 11622 RVA: 0x00015AF0 File Offset: 0x00013CF0
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000BBE RID: 3006
			// (get) Token: 0x06002D67 RID: 11623 RVA: 0x000BF9B0 File Offset: 0x000BDBB0
			// (set) Token: 0x06002D68 RID: 11624 RVA: 0x00015B0B File Offset: 0x00013D0B
			public unsafe RunUsableAbilityForPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BBF RID: 3007
			// (get) Token: 0x06002D69 RID: 11625 RVA: 0x000BF9E0 File Offset: 0x000BDBE0
			// (set) Token: 0x06002D6A RID: 11626 RVA: 0x00015B2A File Offset: 0x00013D2A
			public unsafe IEnumerator<Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunCompletion_d__40.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C61 RID: 7265
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C62 RID: 7266
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C63 RID: 7267
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001C64 RID: 7268
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C65 RID: 7269
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001C66 RID: 7270
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C67 RID: 7271
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C68 RID: 7272
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C69 RID: 7273
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001C6A RID: 7274
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001C6B RID: 7275
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04001C6C RID: 7276
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001C6D RID: 7277
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C6E RID: 7278
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C6F RID: 7279
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001C70 RID: 7280
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000413 RID: 1043
		[ObfuscatedName("Canis.actions.RunUsableAbilityForPlayer+<RunResolution>d__38")]
		public sealed class _RunResolution_d__38 : Object
		{
			// Token: 0x06002D6B RID: 11627 RVA: 0x000BFA10 File Offset: 0x000BDC10
			// Note: this type is marked as 'beforefieldinit'.
			static _RunResolution_d__38()
			{
				Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "<RunResolution>d__38");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr);
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, "<>1__state");
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, "<>2__current");
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, "<>l__initialThreadId");
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, "<>4__this");
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr_paramContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, "paramContext");
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___3__paramContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, "<>3__paramContext");
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr_responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, "responses");
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___3__responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, "<>3__responses");
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr__resolutionContext_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, "<resolutionContext>5__2");
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr__executions_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, "<executions>5__3");
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, "<>7__wrap3");
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, 100667671);
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, 100667672);
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, 100667673);
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, 100667674);
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, 100667675);
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, 100667676);
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, 100667677);
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, 100667678);
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, 100667679);
				RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr, 100667680);
			}

			// Token: 0x06002D6C RID: 11628 RVA: 0x000BFBE0 File Offset: 0x000BDDE0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunResolution_d__38(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunResolution_d__38>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D6D RID: 11629 RVA: 0x000BFC28 File Offset: 0x000BDE28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587699, XrefRangeEnd = 587709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D6E RID: 11630 RVA: 0x000BFC5C File Offset: 0x000BDE5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587709, XrefRangeEnd = 587781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002D6F RID: 11631 RVA: 0x000BFC98 File Offset: 0x000BDE98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587781, XrefRangeEnd = 587784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D70 RID: 11632 RVA: 0x000BFCCC File Offset: 0x000BDECC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587784, XrefRangeEnd = 587787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BCD RID: 3021
			// (get) Token: 0x06002D71 RID: 11633 RVA: 0x000BFD00 File Offset: 0x000BDF00
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002D72 RID: 11634 RVA: 0x000BFD40 File Offset: 0x000BDF40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587787, XrefRangeEnd = 587792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BCE RID: 3022
			// (get) Token: 0x06002D73 RID: 11635 RVA: 0x000BFD74 File Offset: 0x000BDF74
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D74 RID: 11636 RVA: 0x000BFDB4 File Offset: 0x000BDFB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587792, XrefRangeEnd = 587802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002D75 RID: 11637 RVA: 0x000BFDF4 File Offset: 0x000BDFF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunResolution_d__38.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002D76 RID: 11638 RVA: 0x00015B49 File Offset: 0x00013D49
			public _RunResolution_d__38(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BC2 RID: 3010
			// (get) Token: 0x06002D77 RID: 11639 RVA: 0x000BFE34 File Offset: 0x000BE034
			// (set) Token: 0x06002D78 RID: 11640 RVA: 0x00015B52 File Offset: 0x00013D52
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BC3 RID: 3011
			// (get) Token: 0x06002D79 RID: 11641 RVA: 0x000BFE5C File Offset: 0x000BE05C
			// (set) Token: 0x06002D7A RID: 11642 RVA: 0x00015B6D File Offset: 0x00013D6D
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC4 RID: 3012
			// (get) Token: 0x06002D7B RID: 11643 RVA: 0x000BFE8C File Offset: 0x000BE08C
			// (set) Token: 0x06002D7C RID: 11644 RVA: 0x00015B8C File Offset: 0x00013D8C
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000BC5 RID: 3013
			// (get) Token: 0x06002D7D RID: 11645 RVA: 0x000BFEB4 File Offset: 0x000BE0B4
			// (set) Token: 0x06002D7E RID: 11646 RVA: 0x00015BA7 File Offset: 0x00013DA7
			public unsafe RunUsableAbilityForPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC6 RID: 3014
			// (get) Token: 0x06002D7F RID: 11647 RVA: 0x000BFEE4 File Offset: 0x000BE0E4
			// (set) Token: 0x06002D80 RID: 11648 RVA: 0x00015BC6 File Offset: 0x00013DC6
			public unsafe Context paramContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr_paramContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr_paramContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC7 RID: 3015
			// (get) Token: 0x06002D81 RID: 11649 RVA: 0x000BFF14 File Offset: 0x000BE114
			// (set) Token: 0x06002D82 RID: 11650 RVA: 0x00015BE5 File Offset: 0x00013DE5
			public unsafe Context __3__paramContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___3__paramContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___3__paramContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC8 RID: 3016
			// (get) Token: 0x06002D83 RID: 11651 RVA: 0x000BFF44 File Offset: 0x000BE144
			// (set) Token: 0x06002D84 RID: 11652 RVA: 0x00015C04 File Offset: 0x00013E04
			public unsafe TargetResponseQueue responses
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr_responses);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponseQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr_responses), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BC9 RID: 3017
			// (get) Token: 0x06002D85 RID: 11653 RVA: 0x000BFF74 File Offset: 0x000BE174
			// (set) Token: 0x06002D86 RID: 11654 RVA: 0x00015C23 File Offset: 0x00013E23
			public unsafe TargetResponseQueue __3__responses
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___3__responses);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponseQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___3__responses), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BCA RID: 3018
			// (get) Token: 0x06002D87 RID: 11655 RVA: 0x000BFFA4 File Offset: 0x000BE1A4
			// (set) Token: 0x06002D88 RID: 11656 RVA: 0x00015C42 File Offset: 0x00013E42
			public unsafe Context _resolutionContext_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr__resolutionContext_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr__resolutionContext_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BCB RID: 3019
			// (get) Token: 0x06002D89 RID: 11657 RVA: 0x000BFFD4 File Offset: 0x000BE1D4
			// (set) Token: 0x06002D8A RID: 11658 RVA: 0x00015C61 File Offset: 0x00013E61
			public unsafe int _executions_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr__executions_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr__executions_5__3)) = value;
				}
			}

			// Token: 0x17000BCC RID: 3020
			// (get) Token: 0x06002D8B RID: 11659 RVA: 0x000BFFFC File Offset: 0x000BE1FC
			// (set) Token: 0x06002D8C RID: 11660 RVA: 0x00015C7C File Offset: 0x00013E7C
			public unsafe IEnumerator<Action> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunResolution_d__38.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C71 RID: 7281
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C72 RID: 7282
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C73 RID: 7283
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001C74 RID: 7284
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C75 RID: 7285
			private static readonly IntPtr NativeFieldInfoPtr_paramContext;

			// Token: 0x04001C76 RID: 7286
			private static readonly IntPtr NativeFieldInfoPtr___3__paramContext;

			// Token: 0x04001C77 RID: 7287
			private static readonly IntPtr NativeFieldInfoPtr_responses;

			// Token: 0x04001C78 RID: 7288
			private static readonly IntPtr NativeFieldInfoPtr___3__responses;

			// Token: 0x04001C79 RID: 7289
			private static readonly IntPtr NativeFieldInfoPtr__resolutionContext_5__2;

			// Token: 0x04001C7A RID: 7290
			private static readonly IntPtr NativeFieldInfoPtr__executions_5__3;

			// Token: 0x04001C7B RID: 7291
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04001C7C RID: 7292
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C7D RID: 7293
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C7E RID: 7294
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C7F RID: 7295
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001C80 RID: 7296
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001C81 RID: 7297
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001C82 RID: 7298
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C83 RID: 7299
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C84 RID: 7300
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001C85 RID: 7301
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000414 RID: 1044
		[ObfuscatedName("Canis.actions.RunUsableAbilityForPlayer+<RunWithResponses>d__39")]
		public sealed class _RunWithResponses_d__39 : Object
		{
			// Token: 0x06002D8D RID: 11661 RVA: 0x000C002C File Offset: 0x000BE22C
			// Note: this type is marked as 'beforefieldinit'.
			static _RunWithResponses_d__39()
			{
				Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "<RunWithResponses>d__39");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr);
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, "<>1__state");
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, "<>2__current");
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, "<>l__initialThreadId");
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, "<>4__this");
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr_responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, "responses");
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___3__responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, "<>3__responses");
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, "<>7__wrap1");
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr__costContext_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, "<costContext>5__3");
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr__costAction_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, "<costAction>5__4");
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, 100667681);
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, 100667682);
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, 100667683);
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, 100667684);
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, 100667685);
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, 100667686);
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, 100667687);
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, 100667688);
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, 100667689);
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, 100667690);
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, 100667691);
				RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr, 100667692);
			}

			// Token: 0x06002D8E RID: 11662 RVA: 0x000C01FC File Offset: 0x000BE3FC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RunWithResponses_d__39(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunUsableAbilityForPlayer._RunWithResponses_d__39>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D8F RID: 11663 RVA: 0x000C0244 File Offset: 0x000BE444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587802, XrefRangeEnd = 587822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D90 RID: 11664 RVA: 0x000C0278 File Offset: 0x000BE478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587822, XrefRangeEnd = 587934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002D91 RID: 11665 RVA: 0x000C02B4 File Offset: 0x000BE4B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587934, XrefRangeEnd = 587937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D92 RID: 11666 RVA: 0x000C02E8 File Offset: 0x000BE4E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587937, XrefRangeEnd = 587940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D93 RID: 11667 RVA: 0x000C031C File Offset: 0x000BE51C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587940, XrefRangeEnd = 587943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D94 RID: 11668 RVA: 0x000C0350 File Offset: 0x000BE550
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587943, XrefRangeEnd = 587946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BD8 RID: 3032
			// (get) Token: 0x06002D95 RID: 11669 RVA: 0x000C0384 File Offset: 0x000BE584
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002D96 RID: 11670 RVA: 0x000C03C4 File Offset: 0x000BE5C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587946, XrefRangeEnd = 587951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BD9 RID: 3033
			// (get) Token: 0x06002D97 RID: 11671 RVA: 0x000C03F8 File Offset: 0x000BE5F8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D98 RID: 11672 RVA: 0x000C0438 File Offset: 0x000BE638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587951, XrefRangeEnd = 587960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002D99 RID: 11673 RVA: 0x000C0478 File Offset: 0x000BE678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002D9A RID: 11674 RVA: 0x00015C9B File Offset: 0x00013E9B
			public _RunWithResponses_d__39(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BCF RID: 3023
			// (get) Token: 0x06002D9B RID: 11675 RVA: 0x000C04B8 File Offset: 0x000BE6B8
			// (set) Token: 0x06002D9C RID: 11676 RVA: 0x00015CA4 File Offset: 0x00013EA4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BD0 RID: 3024
			// (get) Token: 0x06002D9D RID: 11677 RVA: 0x000C04E0 File Offset: 0x000BE6E0
			// (set) Token: 0x06002D9E RID: 11678 RVA: 0x00015CBF File Offset: 0x00013EBF
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD1 RID: 3025
			// (get) Token: 0x06002D9F RID: 11679 RVA: 0x000C0510 File Offset: 0x000BE710
			// (set) Token: 0x06002DA0 RID: 11680 RVA: 0x00015CDE File Offset: 0x00013EDE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000BD2 RID: 3026
			// (get) Token: 0x06002DA1 RID: 11681 RVA: 0x000C0538 File Offset: 0x000BE738
			// (set) Token: 0x06002DA2 RID: 11682 RVA: 0x00015CF9 File Offset: 0x00013EF9
			public unsafe RunUsableAbilityForPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD3 RID: 3027
			// (get) Token: 0x06002DA3 RID: 11683 RVA: 0x000C0568 File Offset: 0x000BE768
			// (set) Token: 0x06002DA4 RID: 11684 RVA: 0x00015D18 File Offset: 0x00013F18
			public unsafe TargetResponseQueue responses
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr_responses);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponseQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr_responses), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD4 RID: 3028
			// (get) Token: 0x06002DA5 RID: 11685 RVA: 0x000C0598 File Offset: 0x000BE798
			// (set) Token: 0x06002DA6 RID: 11686 RVA: 0x00015D37 File Offset: 0x00013F37
			public unsafe TargetResponseQueue __3__responses
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___3__responses);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponseQueue>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___3__responses), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD5 RID: 3029
			// (get) Token: 0x06002DA7 RID: 11687 RVA: 0x000C05C8 File Offset: 0x000BE7C8
			// (set) Token: 0x06002DA8 RID: 11688 RVA: 0x00015D56 File Offset: 0x00013F56
			public unsafe IEnumerator<Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD6 RID: 3030
			// (get) Token: 0x06002DA9 RID: 11689 RVA: 0x000C05F8 File Offset: 0x000BE7F8
			// (set) Token: 0x06002DAA RID: 11690 RVA: 0x00015D75 File Offset: 0x00013F75
			public unsafe Context _costContext_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr__costContext_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Context>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr__costContext_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD7 RID: 3031
			// (get) Token: 0x06002DAB RID: 11691 RVA: 0x000C0628 File Offset: 0x000BE828
			// (set) Token: 0x06002DAC RID: 11692 RVA: 0x00015D94 File Offset: 0x00013F94
			public unsafe CostAction _costAction_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr__costAction_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CostAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._RunWithResponses_d__39.NativeFieldInfoPtr__costAction_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C86 RID: 7302
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C87 RID: 7303
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C88 RID: 7304
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001C89 RID: 7305
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C8A RID: 7306
			private static readonly IntPtr NativeFieldInfoPtr_responses;

			// Token: 0x04001C8B RID: 7307
			private static readonly IntPtr NativeFieldInfoPtr___3__responses;

			// Token: 0x04001C8C RID: 7308
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04001C8D RID: 7309
			private static readonly IntPtr NativeFieldInfoPtr__costContext_5__3;

			// Token: 0x04001C8E RID: 7310
			private static readonly IntPtr NativeFieldInfoPtr__costAction_5__4;

			// Token: 0x04001C8F RID: 7311
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C90 RID: 7312
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C91 RID: 7313
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C92 RID: 7314
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001C93 RID: 7315
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001C94 RID: 7316
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04001C95 RID: 7317
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x04001C96 RID: 7318
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001C97 RID: 7319
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C98 RID: 7320
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C99 RID: 7321
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001C9A RID: 7322
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000415 RID: 1045
		[ObfuscatedName("Canis.actions.RunUsableAbilityForPlayer+<execute>d__42")]
		public sealed class _execute_d__42 : Object
		{
			// Token: 0x06002DAD RID: 11693 RVA: 0x000C0658 File Offset: 0x000BE858
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__42()
			{
				Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunUsableAbilityForPlayer>.NativeClassPtr, "<execute>d__42");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr);
				RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, "<>1__state");
				RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, "<>2__current");
				RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, "<>l__initialThreadId");
				RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, "<>4__this");
				RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr__ihass_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, "<ihass>5__2");
				RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr__storeTargets_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, "<storeTargets>5__3");
				RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___7__wrap3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, "<>7__wrap3");
				RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr__nextInStack_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, "<nextInStack>5__5");
				RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr__activeUndoNode_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, "<activeUndoNode>5__6");
				RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, 100667693);
				RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, 100667694);
				RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, 100667695);
				RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, 100667696);
				RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, 100667697);
				RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, 100667698);
				RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr___m__Finally4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, 100667699);
				RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, 100667700);
				RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, 100667701);
				RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, 100667702);
				RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, 100667703);
				RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr, 100667704);
			}

			// Token: 0x06002DAE RID: 11694 RVA: 0x000C0828 File Offset: 0x000BEA28
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__42(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunUsableAbilityForPlayer._execute_d__42>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002DAF RID: 11695 RVA: 0x000C0870 File Offset: 0x000BEA70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587960, XrefRangeEnd = 587966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002DB0 RID: 11696 RVA: 0x000C08A4 File Offset: 0x000BEAA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 587966, XrefRangeEnd = 588275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002DB1 RID: 11697 RVA: 0x000C08E0 File Offset: 0x000BEAE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588275, XrefRangeEnd = 588278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002DB2 RID: 11698 RVA: 0x000C0914 File Offset: 0x000BEB14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588278, XrefRangeEnd = 588281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002DB3 RID: 11699 RVA: 0x000C0948 File Offset: 0x000BEB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588281, XrefRangeEnd = 588284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002DB4 RID: 11700 RVA: 0x000C097C File Offset: 0x000BEB7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588284, XrefRangeEnd = 588287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr___m__Finally4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BE3 RID: 3043
			// (get) Token: 0x06002DB5 RID: 11701 RVA: 0x000C09B0 File Offset: 0x000BEBB0
			public unsafe Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002DB6 RID: 11702 RVA: 0x000C09F0 File Offset: 0x000BEBF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588287, XrefRangeEnd = 588292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000BE4 RID: 3044
			// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x000C0A24 File Offset: 0x000BEC24
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002DB8 RID: 11704 RVA: 0x000C0A64 File Offset: 0x000BEC64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 588292, XrefRangeEnd = 588294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr3) : null;
			}

			// Token: 0x06002DB9 RID: 11705 RVA: 0x000C0AA4 File Offset: 0x000BECA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUsableAbilityForPlayer._execute_d__42.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06002DBA RID: 11706 RVA: 0x00015DB3 File Offset: 0x00013FB3
			public _execute_d__42(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BDA RID: 3034
			// (get) Token: 0x06002DBB RID: 11707 RVA: 0x000C0AE4 File Offset: 0x000BECE4
			// (set) Token: 0x06002DBC RID: 11708 RVA: 0x00015DBC File Offset: 0x00013FBC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000BDB RID: 3035
			// (get) Token: 0x06002DBD RID: 11709 RVA: 0x000C0B0C File Offset: 0x000BED0C
			// (set) Token: 0x06002DBE RID: 11710 RVA: 0x00015DD7 File Offset: 0x00013FD7
			public unsafe Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BDC RID: 3036
			// (get) Token: 0x06002DBF RID: 11711 RVA: 0x000C0B3C File Offset: 0x000BED3C
			// (set) Token: 0x06002DC0 RID: 11712 RVA: 0x00015DF6 File Offset: 0x00013FF6
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000BDD RID: 3037
			// (get) Token: 0x06002DC1 RID: 11713 RVA: 0x000C0B64 File Offset: 0x000BED64
			// (set) Token: 0x06002DC2 RID: 11714 RVA: 0x00015E11 File Offset: 0x00014011
			public unsafe RunUsableAbilityForPlayer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunUsableAbilityForPlayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BDE RID: 3038
			// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x000C0B94 File Offset: 0x000BED94
			// (set) Token: 0x06002DC4 RID: 11716 RVA: 0x00015E30 File Offset: 0x00014030
			public unsafe IHasAbilityStateStack _ihass_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr__ihass_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasAbilityStateStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr__ihass_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BDF RID: 3039
			// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000C0BC4 File Offset: 0x000BEDC4
			// (set) Token: 0x06002DC6 RID: 11718 RVA: 0x00015E4F File Offset: 0x0001404F
			public unsafe bool _storeTargets_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr__storeTargets_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr__storeTargets_5__3)) = value;
				}
			}

			// Token: 0x17000BE0 RID: 3040
			// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x000C0BEC File Offset: 0x000BEDEC
			// (set) Token: 0x06002DC8 RID: 11720 RVA: 0x00015E6A File Offset: 0x0001406A
			public unsafe IEnumerator<Action> __7__wrap3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___7__wrap3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr___7__wrap3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE1 RID: 3041
			// (get) Token: 0x06002DC9 RID: 11721 RVA: 0x000C0C1C File Offset: 0x000BEE1C
			// (set) Token: 0x06002DCA RID: 11722 RVA: 0x00015E89 File Offset: 0x00014089
			public unsafe ActiveAbility _nextInStack_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr__nextInStack_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr__nextInStack_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BE2 RID: 3042
			// (get) Token: 0x06002DCB RID: 11723 RVA: 0x000C0C4C File Offset: 0x000BEE4C
			// (set) Token: 0x06002DCC RID: 11724 RVA: 0x00015EA8 File Offset: 0x000140A8
			public unsafe UndoNode _activeUndoNode_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr__activeUndoNode_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUsableAbilityForPlayer._execute_d__42.NativeFieldInfoPtr__activeUndoNode_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C9B RID: 7323
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C9C RID: 7324
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C9D RID: 7325
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001C9E RID: 7326
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C9F RID: 7327
			private static readonly IntPtr NativeFieldInfoPtr__ihass_5__2;

			// Token: 0x04001CA0 RID: 7328
			private static readonly IntPtr NativeFieldInfoPtr__storeTargets_5__3;

			// Token: 0x04001CA1 RID: 7329
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap3;

			// Token: 0x04001CA2 RID: 7330
			private static readonly IntPtr NativeFieldInfoPtr__nextInStack_5__5;

			// Token: 0x04001CA3 RID: 7331
			private static readonly IntPtr NativeFieldInfoPtr__activeUndoNode_5__6;

			// Token: 0x04001CA4 RID: 7332
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001CA5 RID: 7333
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CA6 RID: 7334
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CA7 RID: 7335
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04001CA8 RID: 7336
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04001CA9 RID: 7337
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04001CAA RID: 7338
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally4_Private_Void_0;

			// Token: 0x04001CAB RID: 7339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04001CAC RID: 7340
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CAD RID: 7341
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CAE RID: 7342
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001CAF RID: 7343
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
