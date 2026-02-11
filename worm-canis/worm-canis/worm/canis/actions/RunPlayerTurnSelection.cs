using System;
using Canis;
using Canis.actions;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages.outgoing;
using Networking.selection.targetresponse;
using worm.canis.abilities;
using worm.canis.data.enums;
using worm.canis.entities;

namespace worm.canis.actions
{
	// Token: 0x02000295 RID: 661
	public class RunPlayerTurnSelection : StateMachineAction<RunPlayerTurnState>
	{
		// Token: 0x06001B88 RID: 7048 RVA: 0x000C3D94 File Offset: 0x000C1F94
		// Note: this type is marked as 'beforefieldinit'.
		static RunPlayerTurnSelection()
		{
			Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "RunPlayerTurnSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr);
			RunPlayerTurnSelection.NativeFieldInfoPtr_wormMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, "wormMatch");
			RunPlayerTurnSelection.NativeFieldInfoPtr_selectingPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, "selectingPlayer");
			RunPlayerTurnSelection.NativeFieldInfoPtr_undoNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, "undoNode");
			RunPlayerTurnSelection.NativeFieldInfoPtr__SelectedAbility_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, "<SelectedAbility>k__BackingField");
			RunPlayerTurnSelection.NativeMethodInfoPtr_get_SelectedAbility_Public_get_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668763);
			RunPlayerTurnSelection.NativeMethodInfoPtr_set_SelectedAbility_Private_set_Void_AbilityDefinitionForGame_1_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668764);
			RunPlayerTurnSelection.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668765);
			RunPlayerTurnSelection.NativeMethodInfoPtr__ctor_Public_Void_SerializedRunPlayerTurnSelection_WormMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668766);
			RunPlayerTurnSelection.NativeMethodInfoPtr_WithParentUndo_Public_RunPlayerTurnSelection_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668767);
			RunPlayerTurnSelection.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_RunPlayerTurnState_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668768);
			RunPlayerTurnSelection.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_RunPlayerTurnState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668769);
			RunPlayerTurnSelection.NativeMethodInfoPtr_DetermineAbilityOutcome_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668770);
			RunPlayerTurnSelection.NativeMethodInfoPtr_ReevaluatePassiveAbilities_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668771);
			RunPlayerTurnSelection.NativeMethodInfoPtr_FireTriggers_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668772);
			RunPlayerTurnSelection.NativeMethodInfoPtr_Cleanup_Private_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668773);
			RunPlayerTurnSelection.NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668774);
			RunPlayerTurnSelection.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, 100668775);
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x000C3F18 File Offset: 0x000C2118
		// (set) Token: 0x06001B8A RID: 7050 RVA: 0x000C3F58 File Offset: 0x000C2158
		public unsafe AbilityDefinitionForGame<WormMatch> SelectedAbility
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.NativeMethodInfoPtr_get_SelectedAbility_Public_get_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityDefinitionForGame<WormMatch>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146859, XrefRangeEnd = 146860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.NativeMethodInfoPtr_set_SelectedAbility_Private_set_Void_AbilityDefinitionForGame_1_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x000C3F9C File Offset: 0x000C219C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 146869, RefRangeEnd = 146872, XrefRangeStart = 146860, XrefRangeEnd = 146869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunPlayerTurnSelection(WormPlayer selectingPlayer, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectingPlayer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x000C3FFC File Offset: 0x000C21FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 146891, RefRangeEnd = 146892, XrefRangeStart = 146872, XrefRangeEnd = 146891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunPlayerTurnSelection(SerializedRunPlayerTurnSelection serialized, WormMatch m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serialized);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.NativeMethodInfoPtr__ctor_Public_Void_SerializedRunPlayerTurnSelection_WormMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000C405C File Offset: 0x000C225C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146892, XrefRangeEnd = 146893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunPlayerTurnSelection WithParentUndo(UndoNode parentUndo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentUndo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.NativeMethodInfoPtr_WithParentUndo_Public_RunPlayerTurnSelection_UndoNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunPlayerTurnSelection>(intPtr3) : null;
			}
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x000C40AC File Offset: 0x000C22AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146893, XrefRangeEnd = 146906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<RunPlayerTurnState> DetermineNextTypedState(global::Canis.actions.Action lastAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunPlayerTurnSelection.NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_RunPlayerTurnState_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<RunPlayerTurnState>(intPtr);
			}
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x000C4100 File Offset: 0x000C2300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146906, XrefRangeEnd = 146915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction.StateBehavior TypedBehaviorFor(RunPlayerTurnState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunPlayerTurnSelection.NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_RunPlayerTurnState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction.StateBehavior>(intPtr3) : null;
			}
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x000C4158 File Offset: 0x000C2358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146915, XrefRangeEnd = 146921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> DetermineAbilityOutcome()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.NativeMethodInfoPtr_DetermineAbilityOutcome_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x000C4198 File Offset: 0x000C2398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146921, XrefRangeEnd = 146927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> ReevaluatePassiveAbilities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.NativeMethodInfoPtr_ReevaluatePassiveAbilities_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x000C41D8 File Offset: 0x000C23D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146927, XrefRangeEnd = 146933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> FireTriggers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.NativeMethodInfoPtr_FireTriggers_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x000C4218 File Offset: 0x000C2418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146933, XrefRangeEnd = 146939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<global::Canis.actions.Action> Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.NativeMethodInfoPtr_Cleanup_Private_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<global::Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x000C4258 File Offset: 0x000C2458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146939, XrefRangeEnd = 146943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual global::Canis.actions.Action OnSkip(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001B95 RID: 7061 RVA: 0x000C42A8 File Offset: 0x000C24A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146943, XrefRangeEnd = 146952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SerializedStateMachineAction MakeSerializedStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunPlayerTurnSelection.NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001B96 RID: 7062 RVA: 0x0000BC36 File Offset: 0x00009E36
		public RunPlayerTurnSelection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x000C4304 File Offset: 0x000C2504
		// (set) Token: 0x06001B98 RID: 7064 RVA: 0x0000BC3F File Offset: 0x00009E3F
		public unsafe WormMatch wormMatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.NativeFieldInfoPtr_wormMatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormMatch>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.NativeFieldInfoPtr_wormMatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x000C4334 File Offset: 0x000C2534
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x0000BC5E File Offset: 0x00009E5E
		public unsafe WormPlayer selectingPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.NativeFieldInfoPtr_selectingPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormPlayer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.NativeFieldInfoPtr_selectingPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x000C4364 File Offset: 0x000C2564
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x0000BC7D File Offset: 0x00009E7D
		public unsafe UndoNode undoNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.NativeFieldInfoPtr_undoNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.NativeFieldInfoPtr_undoNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x000C4394 File Offset: 0x000C2594
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x0000BC9C File Offset: 0x00009E9C
		public unsafe AbilityDefinitionForGame<WormMatch> _SelectedAbility_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.NativeFieldInfoPtr__SelectedAbility_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbilityDefinitionForGame<WormMatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.NativeFieldInfoPtr__SelectedAbility_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010FE RID: 4350
		private static readonly IntPtr NativeFieldInfoPtr_wormMatch;

		// Token: 0x040010FF RID: 4351
		private static readonly IntPtr NativeFieldInfoPtr_selectingPlayer;

		// Token: 0x04001100 RID: 4352
		private static readonly IntPtr NativeFieldInfoPtr_undoNode;

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeFieldInfoPtr__SelectedAbility_k__BackingField;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedAbility_Public_get_AbilityDefinitionForGame_1_WormMatch_0;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedAbility_Private_set_Void_AbilityDefinitionForGame_1_WormMatch_0;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_WormPlayer_WormMatch_0;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedRunPlayerTurnSelection_WormMatch_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_WithParentUndo_Public_RunPlayerTurnSelection_UndoNode_0;

		// Token: 0x04001107 RID: 4359
		private static readonly IntPtr NativeMethodInfoPtr_DetermineNextTypedState_Protected_Virtual_Nullable_1_RunPlayerTurnState_Action_0;

		// Token: 0x04001108 RID: 4360
		private static readonly IntPtr NativeMethodInfoPtr_TypedBehaviorFor_Protected_Virtual_StateBehavior_RunPlayerTurnState_0;

		// Token: 0x04001109 RID: 4361
		private static readonly IntPtr NativeMethodInfoPtr_DetermineAbilityOutcome_Private_IEnumerable_1_Action_0;

		// Token: 0x0400110A RID: 4362
		private static readonly IntPtr NativeMethodInfoPtr_ReevaluatePassiveAbilities_Private_IEnumerable_1_Action_0;

		// Token: 0x0400110B RID: 4363
		private static readonly IntPtr NativeMethodInfoPtr_FireTriggers_Private_IEnumerable_1_Action_0;

		// Token: 0x0400110C RID: 4364
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_IEnumerable_1_Action_0;

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeMethodInfoPtr_OnSkip_Public_Virtual_Final_New_Action_Match_0;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr_MakeSerializedStateMachineAction_Protected_Virtual_SerializedStateMachineAction_Match_0;

		// Token: 0x020006DE RID: 1758
		[ObfuscatedName("worm.canis.actions.RunPlayerTurnSelection+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Object
		{
			// Token: 0x06005E06 RID: 24070 RVA: 0x001D28B0 File Offset: 0x001D0AB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_0>.NativeClassPtr);
				RunPlayerTurnSelection.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				RunPlayerTurnSelection.__c__DisplayClass12_0.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_0>.NativeClassPtr, "selection");
				RunPlayerTurnSelection.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_0>.NativeClassPtr, 100668776);
				RunPlayerTurnSelection.__c__DisplayClass12_0.NativeMethodInfoPtr__DetermineAbilityOutcome_b__0_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_0>.NativeClassPtr, 100668777);
				RunPlayerTurnSelection.__c__DisplayClass12_0.NativeMethodInfoPtr__DetermineAbilityOutcome_b__2_Internal_String_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_0>.NativeClassPtr, 100668778);
			}

			// Token: 0x06005E07 RID: 24071 RVA: 0x001D2940 File Offset: 0x001D0B40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E08 RID: 24072 RVA: 0x001D297C File Offset: 0x001D0B7C
			[CallerCount(0)]
			public unsafe bool _DetermineAbilityOutcome_b__0(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.__c__DisplayClass12_0.NativeMethodInfoPtr__DetermineAbilityOutcome_b__0_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005E09 RID: 24073 RVA: 0x001D29CC File Offset: 0x001D0BCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _DetermineAbilityOutcome_b__2(TargetResponse tr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tr);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.__c__DisplayClass12_0.NativeMethodInfoPtr__DetermineAbilityOutcome_b__2_Internal_String_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06005E0A RID: 24074 RVA: 0x00023604 File Offset: 0x00021804
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018A0 RID: 6304
			// (get) Token: 0x06005E0B RID: 24075 RVA: 0x001D2A14 File Offset: 0x001D0C14
			// (set) Token: 0x06005E0C RID: 24076 RVA: 0x0002360D File Offset: 0x0002180D
			public unsafe RunPlayerTurnSelection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunPlayerTurnSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018A1 RID: 6305
			// (get) Token: 0x06005E0D RID: 24077 RVA: 0x001D2A44 File Offset: 0x001D0C44
			// (set) Token: 0x06005E0E RID: 24078 RVA: 0x0002362C File Offset: 0x0002182C
			public unsafe EntityIDTargetResponses selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.__c__DisplayClass12_0.NativeFieldInfoPtr_selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityIDTargetResponses>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.__c__DisplayClass12_0.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D0F RID: 15631
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D10 RID: 15632
			private static readonly IntPtr NativeFieldInfoPtr_selection;

			// Token: 0x04003D11 RID: 15633
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003D12 RID: 15634
			private static readonly IntPtr NativeMethodInfoPtr__DetermineAbilityOutcome_b__0_Internal_Boolean_WormAbilityDefinition_0;

			// Token: 0x04003D13 RID: 15635
			private static readonly IntPtr NativeMethodInfoPtr__DetermineAbilityOutcome_b__2_Internal_String_TargetResponse_0;
		}

		// Token: 0x020006DF RID: 1759
		[ObfuscatedName("worm.canis.actions.RunPlayerTurnSelection+<>c__DisplayClass12_1")]
		public sealed class __c__DisplayClass12_1 : Object
		{
			// Token: 0x06005E0F RID: 24079 RVA: 0x001D2A74 File Offset: 0x001D0C74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_1()
			{
				Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, "<>c__DisplayClass12_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_1>.NativeClassPtr);
				RunPlayerTurnSelection.__c__DisplayClass12_1.NativeFieldInfoPtr_turnType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_1>.NativeClassPtr, "turnType");
				RunPlayerTurnSelection.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_1>.NativeClassPtr, "CS$<>8__locals1");
				RunPlayerTurnSelection.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_1>.NativeClassPtr, 100668779);
				RunPlayerTurnSelection.__c__DisplayClass12_1.NativeMethodInfoPtr__DetermineAbilityOutcome_b__1_Internal_Boolean_WormAbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_1>.NativeClassPtr, 100668780);
			}

			// Token: 0x06005E10 RID: 24080 RVA: 0x001D2AF0 File Offset: 0x001D0CF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPlayerTurnSelection.__c__DisplayClass12_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.__c__DisplayClass12_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E11 RID: 24081 RVA: 0x001D2B2C File Offset: 0x001D0D2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146639, XrefRangeEnd = 146640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DetermineAbilityOutcome_b__1(WormAbilityDefinition _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection.__c__DisplayClass12_1.NativeMethodInfoPtr__DetermineAbilityOutcome_b__1_Internal_Boolean_WormAbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005E12 RID: 24082 RVA: 0x0002364B File Offset: 0x0002184B
			public __c__DisplayClass12_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018A2 RID: 6306
			// (get) Token: 0x06005E13 RID: 24083 RVA: 0x001D2B7C File Offset: 0x001D0D7C
			// (set) Token: 0x06005E14 RID: 24084 RVA: 0x00023654 File Offset: 0x00021854
			public unsafe PlayerTurnTypes turnType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.__c__DisplayClass12_1.NativeFieldInfoPtr_turnType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.__c__DisplayClass12_1.NativeFieldInfoPtr_turnType)) = value;
				}
			}

			// Token: 0x170018A3 RID: 6307
			// (get) Token: 0x06005E15 RID: 24085 RVA: 0x001D2BA4 File Offset: 0x001D0DA4
			// (set) Token: 0x06005E16 RID: 24086 RVA: 0x0002366F File Offset: 0x0002186F
			public unsafe RunPlayerTurnSelection.__c__DisplayClass12_0 field_Public___c__DisplayClass12_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunPlayerTurnSelection.__c__DisplayClass12_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection.__c__DisplayClass12_1.NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D14 RID: 15636
			private static readonly IntPtr NativeFieldInfoPtr_turnType;

			// Token: 0x04003D15 RID: 15637
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass12_0_0;

			// Token: 0x04003D16 RID: 15638
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003D17 RID: 15639
			private static readonly IntPtr NativeMethodInfoPtr__DetermineAbilityOutcome_b__1_Internal_Boolean_WormAbilityDefinition_0;
		}

		// Token: 0x020006E0 RID: 1760
		[ObfuscatedName("worm.canis.actions.RunPlayerTurnSelection+<Cleanup>d__15")]
		public sealed class _Cleanup_d__15 : Object
		{
			// Token: 0x06005E17 RID: 24087 RVA: 0x001D2BD4 File Offset: 0x001D0DD4
			// Note: this type is marked as 'beforefieldinit'.
			static _Cleanup_d__15()
			{
				Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, "<Cleanup>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr);
				RunPlayerTurnSelection._Cleanup_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr, "<>1__state");
				RunPlayerTurnSelection._Cleanup_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr, "<>2__current");
				RunPlayerTurnSelection._Cleanup_d__15.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr, "<>l__initialThreadId");
				RunPlayerTurnSelection._Cleanup_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr, "<>4__this");
				RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr, 100668781);
				RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr, 100668782);
				RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr, 100668783);
				RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr, 100668784);
				RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr, 100668785);
				RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr, 100668786);
				RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr, 100668787);
				RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr, 100668788);
			}

			// Token: 0x06005E18 RID: 24088 RVA: 0x001D2CF0 File Offset: 0x001D0EF0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Cleanup_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPlayerTurnSelection._Cleanup_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E19 RID: 24089 RVA: 0x001D2D38 File Offset: 0x001D0F38
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E1A RID: 24090 RVA: 0x001D2D6C File Offset: 0x001D0F6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146640, XrefRangeEnd = 146658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018A8 RID: 6312
			// (get) Token: 0x06005E1B RID: 24091 RVA: 0x001D2DA8 File Offset: 0x001D0FA8
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005E1C RID: 24092 RVA: 0x001D2DE8 File Offset: 0x001D0FE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146658, XrefRangeEnd = 146663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018A9 RID: 6313
			// (get) Token: 0x06005E1D RID: 24093 RVA: 0x001D2E1C File Offset: 0x001D101C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005E1E RID: 24094 RVA: 0x001D2E5C File Offset: 0x001D105C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146663, XrefRangeEnd = 146665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005E1F RID: 24095 RVA: 0x001D2E9C File Offset: 0x001D109C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._Cleanup_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005E20 RID: 24096 RVA: 0x0002368E File Offset: 0x0002188E
			public _Cleanup_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018A4 RID: 6308
			// (get) Token: 0x06005E21 RID: 24097 RVA: 0x001D2EDC File Offset: 0x001D10DC
			// (set) Token: 0x06005E22 RID: 24098 RVA: 0x00023697 File Offset: 0x00021897
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._Cleanup_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._Cleanup_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170018A5 RID: 6309
			// (get) Token: 0x06005E23 RID: 24099 RVA: 0x001D2F04 File Offset: 0x001D1104
			// (set) Token: 0x06005E24 RID: 24100 RVA: 0x000236B2 File Offset: 0x000218B2
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._Cleanup_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._Cleanup_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018A6 RID: 6310
			// (get) Token: 0x06005E25 RID: 24101 RVA: 0x001D2F34 File Offset: 0x001D1134
			// (set) Token: 0x06005E26 RID: 24102 RVA: 0x000236D1 File Offset: 0x000218D1
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._Cleanup_d__15.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._Cleanup_d__15.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170018A7 RID: 6311
			// (get) Token: 0x06005E27 RID: 24103 RVA: 0x001D2F5C File Offset: 0x001D115C
			// (set) Token: 0x06005E28 RID: 24104 RVA: 0x000236EC File Offset: 0x000218EC
			public unsafe RunPlayerTurnSelection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._Cleanup_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunPlayerTurnSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._Cleanup_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D18 RID: 15640
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D19 RID: 15641
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D1A RID: 15642
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003D1B RID: 15643
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D1C RID: 15644
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D1D RID: 15645
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D1E RID: 15646
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D1F RID: 15647
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003D20 RID: 15648
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D21 RID: 15649
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D22 RID: 15650
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003D23 RID: 15651
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006E1 RID: 1761
		[ObfuscatedName("worm.canis.actions.RunPlayerTurnSelection+<DetermineAbilityOutcome>d__12")]
		public sealed class _DetermineAbilityOutcome_d__12 : Object
		{
			// Token: 0x06005E29 RID: 24105 RVA: 0x001D2F8C File Offset: 0x001D118C
			// Note: this type is marked as 'beforefieldinit'.
			static _DetermineAbilityOutcome_d__12()
			{
				Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, "<DetermineAbilityOutcome>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr);
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, "<>1__state");
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, "<>2__current");
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, "<>l__initialThreadId");
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, "<>4__this");
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, "<>7__wrap1");
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, 100668789);
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, 100668790);
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, 100668791);
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, 100668792);
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, 100668793);
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, 100668794);
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, 100668795);
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, 100668796);
				RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr, 100668797);
			}

			// Token: 0x06005E2A RID: 24106 RVA: 0x001D30D0 File Offset: 0x001D12D0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DetermineAbilityOutcome_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPlayerTurnSelection._DetermineAbilityOutcome_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E2B RID: 24107 RVA: 0x001D3118 File Offset: 0x001D1318
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146665, XrefRangeEnd = 146670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E2C RID: 24108 RVA: 0x001D314C File Offset: 0x001D134C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146670, XrefRangeEnd = 146833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005E2D RID: 24109 RVA: 0x001D3188 File Offset: 0x001D1388
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146833, XrefRangeEnd = 146836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018AF RID: 6319
			// (get) Token: 0x06005E2E RID: 24110 RVA: 0x001D31BC File Offset: 0x001D13BC
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005E2F RID: 24111 RVA: 0x001D31FC File Offset: 0x001D13FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146836, XrefRangeEnd = 146841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018B0 RID: 6320
			// (get) Token: 0x06005E30 RID: 24112 RVA: 0x001D3230 File Offset: 0x001D1430
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005E31 RID: 24113 RVA: 0x001D3270 File Offset: 0x001D1470
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146841, XrefRangeEnd = 146843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005E32 RID: 24114 RVA: 0x001D32B0 File Offset: 0x001D14B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005E33 RID: 24115 RVA: 0x0002370B File Offset: 0x0002190B
			public _DetermineAbilityOutcome_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018AA RID: 6314
			// (get) Token: 0x06005E34 RID: 24116 RVA: 0x001D32F0 File Offset: 0x001D14F0
			// (set) Token: 0x06005E35 RID: 24117 RVA: 0x00023714 File Offset: 0x00021914
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170018AB RID: 6315
			// (get) Token: 0x06005E36 RID: 24118 RVA: 0x001D3318 File Offset: 0x001D1518
			// (set) Token: 0x06005E37 RID: 24119 RVA: 0x0002372F File Offset: 0x0002192F
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018AC RID: 6316
			// (get) Token: 0x06005E38 RID: 24120 RVA: 0x001D3348 File Offset: 0x001D1548
			// (set) Token: 0x06005E39 RID: 24121 RVA: 0x0002374E File Offset: 0x0002194E
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170018AD RID: 6317
			// (get) Token: 0x06005E3A RID: 24122 RVA: 0x001D3370 File Offset: 0x001D1570
			// (set) Token: 0x06005E3B RID: 24123 RVA: 0x00023769 File Offset: 0x00021969
			public unsafe RunPlayerTurnSelection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunPlayerTurnSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018AE RID: 6318
			// (get) Token: 0x06005E3C RID: 24124 RVA: 0x001D33A0 File Offset: 0x001D15A0
			// (set) Token: 0x06005E3D RID: 24125 RVA: 0x00023788 File Offset: 0x00021988
			public unsafe IEnumerator<global::Canis.actions.Action> __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._DetermineAbilityOutcome_d__12.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D24 RID: 15652
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D25 RID: 15653
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D26 RID: 15654
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003D27 RID: 15655
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D28 RID: 15656
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04003D29 RID: 15657
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D2A RID: 15658
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D2B RID: 15659
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D2C RID: 15660
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04003D2D RID: 15661
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003D2E RID: 15662
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D2F RID: 15663
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D30 RID: 15664
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003D31 RID: 15665
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006E2 RID: 1762
		[ObfuscatedName("worm.canis.actions.RunPlayerTurnSelection+<FireTriggers>d__14")]
		public sealed class _FireTriggers_d__14 : Object
		{
			// Token: 0x06005E3E RID: 24126 RVA: 0x001D33D0 File Offset: 0x001D15D0
			// Note: this type is marked as 'beforefieldinit'.
			static _FireTriggers_d__14()
			{
				Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, "<FireTriggers>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr);
				RunPlayerTurnSelection._FireTriggers_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr, "<>1__state");
				RunPlayerTurnSelection._FireTriggers_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr, "<>2__current");
				RunPlayerTurnSelection._FireTriggers_d__14.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr, "<>l__initialThreadId");
				RunPlayerTurnSelection._FireTriggers_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr, "<>4__this");
				RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr, 100668798);
				RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr, 100668799);
				RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr, 100668800);
				RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr, 100668801);
				RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr, 100668802);
				RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr, 100668803);
				RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr, 100668804);
				RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr, 100668805);
			}

			// Token: 0x06005E3F RID: 24127 RVA: 0x001D34EC File Offset: 0x001D16EC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _FireTriggers_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPlayerTurnSelection._FireTriggers_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E40 RID: 24128 RVA: 0x001D3534 File Offset: 0x001D1734
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E41 RID: 24129 RVA: 0x001D3568 File Offset: 0x001D1768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146843, XrefRangeEnd = 146845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018B5 RID: 6325
			// (get) Token: 0x06005E42 RID: 24130 RVA: 0x001D35A4 File Offset: 0x001D17A4
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005E43 RID: 24131 RVA: 0x001D35E4 File Offset: 0x001D17E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146845, XrefRangeEnd = 146850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018B6 RID: 6326
			// (get) Token: 0x06005E44 RID: 24132 RVA: 0x001D3618 File Offset: 0x001D1818
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005E45 RID: 24133 RVA: 0x001D3658 File Offset: 0x001D1858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146850, XrefRangeEnd = 146852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005E46 RID: 24134 RVA: 0x001D3698 File Offset: 0x001D1898
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._FireTriggers_d__14.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005E47 RID: 24135 RVA: 0x000237A7 File Offset: 0x000219A7
			public _FireTriggers_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018B1 RID: 6321
			// (get) Token: 0x06005E48 RID: 24136 RVA: 0x001D36D8 File Offset: 0x001D18D8
			// (set) Token: 0x06005E49 RID: 24137 RVA: 0x000237B0 File Offset: 0x000219B0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._FireTriggers_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._FireTriggers_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170018B2 RID: 6322
			// (get) Token: 0x06005E4A RID: 24138 RVA: 0x001D3700 File Offset: 0x001D1900
			// (set) Token: 0x06005E4B RID: 24139 RVA: 0x000237CB File Offset: 0x000219CB
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._FireTriggers_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._FireTriggers_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018B3 RID: 6323
			// (get) Token: 0x06005E4C RID: 24140 RVA: 0x001D3730 File Offset: 0x001D1930
			// (set) Token: 0x06005E4D RID: 24141 RVA: 0x000237EA File Offset: 0x000219EA
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._FireTriggers_d__14.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._FireTriggers_d__14.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170018B4 RID: 6324
			// (get) Token: 0x06005E4E RID: 24142 RVA: 0x001D3758 File Offset: 0x001D1958
			// (set) Token: 0x06005E4F RID: 24143 RVA: 0x00023805 File Offset: 0x00021A05
			public unsafe RunPlayerTurnSelection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._FireTriggers_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunPlayerTurnSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._FireTriggers_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D32 RID: 15666
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D33 RID: 15667
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D34 RID: 15668
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003D35 RID: 15669
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D36 RID: 15670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D37 RID: 15671
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D38 RID: 15672
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D39 RID: 15673
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003D3A RID: 15674
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D3B RID: 15675
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D3C RID: 15676
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003D3D RID: 15677
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020006E3 RID: 1763
		[ObfuscatedName("worm.canis.actions.RunPlayerTurnSelection+<ReevaluatePassiveAbilities>d__13")]
		public sealed class _ReevaluatePassiveAbilities_d__13 : Object
		{
			// Token: 0x06005E50 RID: 24144 RVA: 0x001D3788 File Offset: 0x001D1988
			// Note: this type is marked as 'beforefieldinit'.
			static _ReevaluatePassiveAbilities_d__13()
			{
				Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunPlayerTurnSelection>.NativeClassPtr, "<ReevaluatePassiveAbilities>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr);
				RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr, "<>1__state");
				RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr, "<>2__current");
				RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr, "<>l__initialThreadId");
				RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr, "<>4__this");
				RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr, 100668806);
				RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr, 100668807);
				RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr, 100668808);
				RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr, 100668809);
				RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr, 100668810);
				RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr, 100668811);
				RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr, 100668812);
				RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr, 100668813);
			}

			// Token: 0x06005E51 RID: 24145 RVA: 0x001D38A4 File Offset: 0x001D1AA4
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ReevaluatePassiveAbilities_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005E52 RID: 24146 RVA: 0x001D38EC File Offset: 0x001D1AEC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005E53 RID: 24147 RVA: 0x001D3920 File Offset: 0x001D1B20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170018BB RID: 6331
			// (get) Token: 0x06005E54 RID: 24148 RVA: 0x001D395C File Offset: 0x001D1B5C
			public unsafe global::Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06005E55 RID: 24149 RVA: 0x001D399C File Offset: 0x001D1B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146852, XrefRangeEnd = 146857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170018BC RID: 6332
			// (get) Token: 0x06005E56 RID: 24150 RVA: 0x001D39D0 File Offset: 0x001D1BD0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06005E57 RID: 24151 RVA: 0x001D3A10 File Offset: 0x001D1C10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 146857, XrefRangeEnd = 146859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<global::Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<global::Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06005E58 RID: 24152 RVA: 0x001D3A50 File Offset: 0x001D1C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06005E59 RID: 24153 RVA: 0x00023824 File Offset: 0x00021A24
			public _ReevaluatePassiveAbilities_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170018B7 RID: 6327
			// (get) Token: 0x06005E5A RID: 24154 RVA: 0x001D3A90 File Offset: 0x001D1C90
			// (set) Token: 0x06005E5B RID: 24155 RVA: 0x0002382D File Offset: 0x00021A2D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170018B8 RID: 6328
			// (get) Token: 0x06005E5C RID: 24156 RVA: 0x001D3AB8 File Offset: 0x001D1CB8
			// (set) Token: 0x06005E5D RID: 24157 RVA: 0x00023848 File Offset: 0x00021A48
			public unsafe global::Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170018B9 RID: 6329
			// (get) Token: 0x06005E5E RID: 24158 RVA: 0x001D3AE8 File Offset: 0x001D1CE8
			// (set) Token: 0x06005E5F RID: 24159 RVA: 0x00023867 File Offset: 0x00021A67
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170018BA RID: 6330
			// (get) Token: 0x06005E60 RID: 24160 RVA: 0x001D3B10 File Offset: 0x001D1D10
			// (set) Token: 0x06005E61 RID: 24161 RVA: 0x00023882 File Offset: 0x00021A82
			public unsafe RunPlayerTurnSelection __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunPlayerTurnSelection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunPlayerTurnSelection._ReevaluatePassiveAbilities_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003D3E RID: 15678
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04003D3F RID: 15679
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04003D40 RID: 15680
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04003D41 RID: 15681
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04003D42 RID: 15682
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003D43 RID: 15683
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D44 RID: 15684
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003D45 RID: 15685
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x04003D46 RID: 15686
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003D47 RID: 15687
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003D48 RID: 15688
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04003D49 RID: 15689
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
