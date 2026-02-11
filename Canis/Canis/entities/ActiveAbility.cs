using System;
using System.Runtime.InteropServices;
using Canis.actions;
using Canis.actions.staged;
using Canis.attributes;
using Canis.context;
using Canis.context.targetpickers;
using Canis.gameLogs;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Networking.selection.targetresponse;

namespace Canis.entities
{
	// Token: 0x020000CF RID: 207
	public class ActiveAbility : Entity
	{
		// Token: 0x0600095F RID: 2399 RVA: 0x00040D90 File Offset: 0x0003EF90
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveAbility()
		{
			Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "ActiveAbility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr);
			ActiveAbility.NativeFieldInfoPtr_BeginExecutionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, "BeginExecutionState");
			ActiveAbility.NativeFieldInfoPtr_CompletedExecutionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, "CompletedExecutionState");
			ActiveAbility.NativeFieldInfoPtr_CanceledExecutionState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, "CanceledExecutionState");
			ActiveAbility.NativeFieldInfoPtr__ReturningAction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, "<ReturningAction>k__BackingField");
			ActiveAbility.NativeMethodInfoPtr__ctor_Protected_Void_Match_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665260);
			ActiveAbility.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665261);
			ActiveAbility.NativeMethodInfoPtr_get_AbilityID_Public_get_AbilityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665262);
			ActiveAbility.NativeMethodInfoPtr_get_ReturningAction_Public_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665263);
			ActiveAbility.NativeMethodInfoPtr_set_ReturningAction_Public_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665264);
			ActiveAbility.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665265);
			ActiveAbility.NativeMethodInfoPtr_get_BaseRunningPlayer_Public_get_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665266);
			ActiveAbility.NativeMethodInfoPtr_get_AbilityDefinition_Public_get_AbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665267);
			ActiveAbility.NativeMethodInfoPtr_get_AbilityState_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665268);
			ActiveAbility.NativeMethodInfoPtr_AdvanceToTargeting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665269);
			ActiveAbility.NativeMethodInfoPtr_AdvanceToCosting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665270);
			ActiveAbility.NativeMethodInfoPtr_AdvanceToExecuting_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665271);
			ActiveAbility.NativeMethodInfoPtr_get_CurrentExecutionState_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665272);
			ActiveAbility.NativeMethodInfoPtr_AdvanceExecutionState_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665273);
			ActiveAbility.NativeMethodInfoPtr_get_Cancellable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665274);
			ActiveAbility.NativeMethodInfoPtr_set_Cancellable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665275);
			ActiveAbility.NativeMethodInfoPtr_get_StagedExecutionActions_Public_Virtual_New_get_Dictionary_2_Int32_List_1_SerializedStagedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665276);
			ActiveAbility.NativeMethodInfoPtr_FindDescendentStagedExecutionActions_Public_Virtual_New_Dictionary_2_Int32_List_1_SerializedStagedAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665277);
			ActiveAbility.NativeMethodInfoPtr_StagedExecutionActionsForState_Public_Virtual_New_List_1_SerializedStagedAction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665278);
			ActiveAbility.NativeMethodInfoPtr_AllOrderedStagedActions_Public_List_1_SerializedStagedAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665279);
			ActiveAbility.NativeMethodInfoPtr_AllOrderedStagedExecutionActions_Public_Virtual_New_List_1_ValueTuple_2_Int32_SerializedStagedAction_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665280);
			ActiveAbility.NativeMethodInfoPtr_UpsertStagedExecutionAction_Public_Virtual_New_Void_Int32_SerializedStagedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665281);
			ActiveAbility.NativeMethodInfoPtr_ClearStagedExecutionActionsForState_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665282);
			ActiveAbility.NativeMethodInfoPtr_get_StagedCostActions_Public_Virtual_New_get_List_1_SerializedStagedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665283);
			ActiveAbility.NativeMethodInfoPtr_UpsertStagedCostAction_Public_Virtual_New_Void_SerializedStagedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665284);
			ActiveAbility.NativeMethodInfoPtr_get_QueuedRollbacks_Public_Virtual_New_get_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665285);
			ActiveAbility.NativeMethodInfoPtr_RollbackExecutionState_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665286);
			ActiveAbility.NativeMethodInfoPtr_MakeResponseQueue_Public_TargetResponseQueue_AttributeDefinition_1_Il2CppReferenceArray_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665287);
			ActiveAbility.NativeMethodInfoPtr_MakeEntitiesQueue_Public_List_1_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665288);
			ActiveAbility.NativeMethodInfoPtr_get_FlattenedEntityTargets_Public_get_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665289);
			ActiveAbility.NativeMethodInfoPtr_StoreExecutionTargets_Public_Void_Il2CppReferenceArray_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665290);
			ActiveAbility.NativeMethodInfoPtr_get_Context_Public_get_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665291);
			ActiveAbility.NativeMethodInfoPtr_get_Completed_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665292);
			ActiveAbility.NativeMethodInfoPtr_get_Canceled_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665293);
			ActiveAbility.NativeMethodInfoPtr_get_Succeeded_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665294);
			ActiveAbility.NativeMethodInfoPtr_set_Succeeded_Public_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665295);
			ActiveAbility.NativeMethodInfoPtr_get_ActiveGameLogBuilder_Public_get_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665296);
			ActiveAbility.NativeMethodInfoPtr_set_ActiveGameLogBuilder_Public_set_Void_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665297);
			ActiveAbility.NativeMethodInfoPtr_UpdateActiveGameLogBuilder_Public_Void_Func_2_TGameLogBuilder_TGameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665298);
			ActiveAbility.NativeMethodInfoPtr_UpdateActiveGameLogBuilder_Public_Void_Func_2_GameLogBuilder_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665299);
			ActiveAbility.NativeMethodInfoPtr_get_ActiveUndoNode_Public_get_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665300);
			ActiveAbility.NativeMethodInfoPtr_set_ActiveUndoNode_Public_set_Void_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665301);
			ActiveAbility.NativeMethodInfoPtr_UpdateActiveUndoNode_Public_Void_Func_2_UndoNode_UndoNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665302);
			ActiveAbility.NativeMethodInfoPtr_CommitStack_Public_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665303);
			ActiveAbility.NativeMethodInfoPtr__get_AbilityDefinition_b__15_0_Private_Boolean_AbilityDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665304);
			ActiveAbility.NativeMethodInfoPtr__MakeEntitiesQueue_b__42_0_Private_Il2CppReferenceArray_1_Entity_EntityListTargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665305);
			ActiveAbility.NativeMethodInfoPtr__MakeEntitiesQueue_b__42_1_Private_Entity_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665306);
			ActiveAbility.NativeMethodInfoPtr__CommitStack_b__64_0_Private_IEnumerable_1_IStagedAction_ActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665307);
			ActiveAbility.NativeMethodInfoPtr__CommitStack_b__64_1_Private_Action_SerializedStagedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, 100665308);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x000411E4 File Offset: 0x0003F3E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 562520, RefRangeEnd = 562521, XrefRangeStart = 562504, XrefRangeEnd = 562520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveAbility(Match m, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr__ctor_Protected_Void_Match_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00041244 File Offset: 0x0003F444
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 553228, RefRangeEnd = 553234, XrefRangeStart = 553228, XrefRangeEnd = 553234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveAbility(SerializedEntity se, Match match, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x000412B4 File Offset: 0x0003F4B4
		public unsafe AbilityID AbilityID
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562521, XrefRangeEnd = 562528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_get_AbilityID_Public_get_AbilityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityID>(intPtr3) : null;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x000412F4 File Offset: 0x0003F4F4
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x00041334 File Offset: 0x0003F534
		public unsafe Canis.actions.Action ReturningAction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_get_ReturningAction_Public_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_set_ReturningAction_Public_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00041378 File Offset: 0x0003F578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562528, XrefRangeEnd = 562603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x000413BC File Offset: 0x0003F5BC
		public unsafe PlayerEntity BaseRunningPlayer
		{
			[CallerCount(306)]
			[CachedScanResults(RefRangeStart = 562620, RefRangeEnd = 562926, XrefRangeStart = 562603, XrefRangeEnd = 562620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_get_BaseRunningPlayer_Public_get_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr3) : null;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x000413FC File Offset: 0x0003F5FC
		public unsafe AbilityDefinition AbilityDefinition
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 562953, RefRangeEnd = 562972, XrefRangeStart = 562926, XrefRangeEnd = 562953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_get_AbilityDefinition_Public_get_AbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AbilityDefinition>(intPtr3) : null;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x0004143C File Offset: 0x0003F63C
		public unsafe int AbilityState
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 562979, RefRangeEnd = 562983, XrefRangeStart = 562972, XrefRangeEnd = 562979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_get_AbilityState_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00041478 File Offset: 0x0003F678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 562993, RefRangeEnd = 562994, XrefRangeStart = 562983, XrefRangeEnd = 562993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdvanceToTargeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_AdvanceToTargeting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x000414AC File Offset: 0x0003F6AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 563004, RefRangeEnd = 563008, XrefRangeStart = 562994, XrefRangeEnd = 563004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdvanceToCosting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_AdvanceToCosting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x000414E0 File Offset: 0x0003F6E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 563018, RefRangeEnd = 563020, XrefRangeStart = 563008, XrefRangeEnd = 563018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdvanceToExecuting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_AdvanceToExecuting_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x00041514 File Offset: 0x0003F714
		public unsafe int CurrentExecutionState
		{
			[CallerCount(187)]
			[CachedScanResults(RefRangeStart = 563027, RefRangeEnd = 563214, XrefRangeStart = 563020, XrefRangeEnd = 563027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_get_CurrentExecutionState_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x00041550 File Offset: 0x0003F750
		[CallerCount(271)]
		[CachedScanResults(RefRangeStart = 563224, RefRangeEnd = 563495, XrefRangeStart = 563214, XrefRangeEnd = 563224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdvanceExecutionState(int executionState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executionState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_AdvanceExecutionState_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00041590 File Offset: 0x0003F790
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x000415CC File Offset: 0x0003F7CC
		public unsafe bool Cancellable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 563502, RefRangeEnd = 563503, XrefRangeStart = 563495, XrefRangeEnd = 563502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_get_Cancellable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 563513, RefRangeEnd = 563514, XrefRangeStart = 563503, XrefRangeEnd = 563513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_set_Cancellable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x0004160C File Offset: 0x0003F80C
		public unsafe virtual Dictionary<int, List<SerializedStagedAction>> StagedExecutionActions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 563514, XrefRangeEnd = 563527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_get_StagedExecutionActions_Public_Virtual_New_get_Dictionary_2_Int32_List_1_SerializedStagedAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<SerializedStagedAction>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x00041658 File Offset: 0x0003F858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 563527, XrefRangeEnd = 563632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Dictionary<int, List<SerializedStagedAction>> FindDescendentStagedExecutionActions(bool reverse = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reverse;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_FindDescendentStagedExecutionActions_Public_Virtual_New_Dictionary_2_Int32_List_1_SerializedStagedAction_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<SerializedStagedAction>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000416B0 File Offset: 0x0003F8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 563632, XrefRangeEnd = 563637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<SerializedStagedAction> StagedExecutionActionsForState(int state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_StagedExecutionActionsForState_Public_Virtual_New_List_1_SerializedStagedAction_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SerializedStagedAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x00041708 File Offset: 0x0003F908
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 563669, RefRangeEnd = 563671, XrefRangeStart = 563637, XrefRangeEnd = 563669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<SerializedStagedAction> AllOrderedStagedActions(bool reverse = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reverse;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_AllOrderedStagedActions_Public_List_1_SerializedStagedAction_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SerializedStagedAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00041754 File Offset: 0x0003F954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 563671, XrefRangeEnd = 563734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<ValueTuple<int, SerializedStagedAction>> AllOrderedStagedExecutionActions(bool reverse = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reverse;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_AllOrderedStagedExecutionActions_Public_Virtual_New_List_1_ValueTuple_2_Int32_SerializedStagedAction_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<int, SerializedStagedAction>>>(intPtr3) : null;
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000417AC File Offset: 0x0003F9AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 563734, XrefRangeEnd = 563759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpsertStagedExecutionAction(int state, SerializedStagedAction serializedStagedAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serializedStagedAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_UpsertStagedExecutionAction_Public_Virtual_New_Void_Int32_SerializedStagedAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00041808 File Offset: 0x0003FA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 563759, XrefRangeEnd = 563826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ClearStagedExecutionActionsForState(int state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_ClearStagedExecutionActionsForState_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x00041854 File Offset: 0x0003FA54
		public unsafe virtual List<SerializedStagedAction> StagedCostActions
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 563826, XrefRangeEnd = 563839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_get_StagedCostActions_Public_Virtual_New_get_List_1_SerializedStagedAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<SerializedStagedAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000418A0 File Offset: 0x0003FAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 563839, XrefRangeEnd = 563853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpsertStagedCostAction(SerializedStagedAction serializedStagedAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedStagedAction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_UpsertStagedCostAction_Public_Virtual_New_Void_SerializedStagedAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x000418F0 File Offset: 0x0003FAF0
		public unsafe virtual List<int> QueuedRollbacks
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 563853, XrefRangeEnd = 563866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_get_QueuedRollbacks_Public_Virtual_New_get_List_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0004193C File Offset: 0x0003FB3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 563866, XrefRangeEnd = 563879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RollbackExecutionState(int executionState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref executionState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_RollbackExecutionState_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00041988 File Offset: 0x0003FB88
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 563893, RefRangeEnd = 563951, XrefRangeStart = 563879, XrefRangeEnd = 563893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TargetResponseQueue MakeResponseQueue(AttributeDefinition<Il2CppReferenceArray<TargetResponse>> targetAttrDef = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetAttrDef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_MakeResponseQueue_Public_TargetResponseQueue_AttributeDefinition_1_Il2CppReferenceArray_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponseQueue>(intPtr3) : null;
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000419D8 File Offset: 0x0003FBD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 563980, RefRangeEnd = 563981, XrefRangeStart = 563951, XrefRangeEnd = 563980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Il2CppReferenceArray<Entity>> MakeEntitiesQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_MakeEntitiesQueue_Public_List_1_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Il2CppReferenceArray<Entity>>>(intPtr3) : null;
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x00041A18 File Offset: 0x0003FC18
		public unsafe Il2CppReferenceArray<Entity> FlattenedEntityTargets
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 563981, XrefRangeEnd = 564003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_get_FlattenedEntityTargets_Public_get_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00041A58 File Offset: 0x0003FC58
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 564010, RefRangeEnd = 564013, XrefRangeStart = 564003, XrefRangeEnd = 564010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreExecutionTargets([Optional] Il2CppReferenceArray<TargetResponse> responses)
		{
			if (responses == null)
			{
				responses = new Il2CppReferenceArray<TargetResponse>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(responses);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_StoreExecutionTargets_Public_Void_Il2CppReferenceArray_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x00041AA8 File Offset: 0x0003FCA8
		public unsafe Context Context
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 564041, RefRangeEnd = 564043, XrefRangeStart = 564013, XrefRangeEnd = 564041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_get_Context_Public_get_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Context>(intPtr3) : null;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00041AE8 File Offset: 0x0003FCE8
		public unsafe virtual bool Completed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564043, XrefRangeEnd = 564044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_get_Completed_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x00041B30 File Offset: 0x0003FD30
		public unsafe virtual bool Canceled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564044, XrefRangeEnd = 564045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_get_Canceled_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00041B78 File Offset: 0x0003FD78
		// (set) Token: 0x06000983 RID: 2435 RVA: 0x00041BC0 File Offset: 0x0003FDC0
		public unsafe virtual bool Succeeded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564045, XrefRangeEnd = 564052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_get_Succeeded_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564052, XrefRangeEnd = 564062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ActiveAbility.NativeMethodInfoPtr_set_Succeeded_Public_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000984 RID: 2436 RVA: 0x00041C0C File Offset: 0x0003FE0C
		// (set) Token: 0x06000985 RID: 2437 RVA: 0x00041C4C File Offset: 0x0003FE4C
		public unsafe GameLogBuilder ActiveGameLogBuilder
		{
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 564072, RefRangeEnd = 564106, XrefRangeStart = 564062, XrefRangeEnd = 564072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_get_ActiveGameLogBuilder_Public_get_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr3) : null;
			}
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 564125, RefRangeEnd = 564169, XrefRangeStart = 564106, XrefRangeEnd = 564125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_set_ActiveGameLogBuilder_Public_set_Void_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00041C90 File Offset: 0x0003FE90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 564176, RefRangeEnd = 564177, XrefRangeStart = 564169, XrefRangeEnd = 564176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActiveGameLogBuilder<TGameLogBuilder>(Func<TGameLogBuilder, TGameLogBuilder> updater) where TGameLogBuilder : GameLogBuilder
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updater);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.MethodInfoStoreGeneric_UpdateActiveGameLogBuilder_Public_Void_Func_2_TGameLogBuilder_TGameLogBuilder_0<TGameLogBuilder>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00041CD4 File Offset: 0x0003FED4
		[CallerCount(169)]
		[CachedScanResults(RefRangeStart = 564180, RefRangeEnd = 564349, XrefRangeStart = 564177, XrefRangeEnd = 564180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActiveGameLogBuilder(Func<GameLogBuilder, GameLogBuilder> updater)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updater);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_UpdateActiveGameLogBuilder_Public_Void_Func_2_GameLogBuilder_GameLogBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000988 RID: 2440 RVA: 0x00041D18 File Offset: 0x0003FF18
		// (set) Token: 0x06000989 RID: 2441 RVA: 0x00041D58 File Offset: 0x0003FF58
		public unsafe UndoNode ActiveUndoNode
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 564362, RefRangeEnd = 564391, XrefRangeStart = 564349, XrefRangeEnd = 564362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_get_ActiveUndoNode_Public_get_UndoNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UndoNode>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 564403, RefRangeEnd = 564404, XrefRangeStart = 564391, XrefRangeEnd = 564403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_set_ActiveUndoNode_Public_set_Void_UndoNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00041D9C File Offset: 0x0003FF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564404, XrefRangeEnd = 564425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateActiveUndoNode(Func<UndoNode, UndoNode> updater)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(updater);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_UpdateActiveUndoNode_Public_Void_Func_2_UndoNode_UndoNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00041DE0 File Offset: 0x0003FFE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 564431, RefRangeEnd = 564433, XrefRangeStart = 564425, XrefRangeEnd = 564431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Canis.actions.Action> CommitStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr_CommitStack_Public_IEnumerable_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00041E20 File Offset: 0x00040020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564433, XrefRangeEnd = 564445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _get_AbilityDefinition_b__15_0(AbilityDefinition _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr__get_AbilityDefinition_b__15_0_Private_Boolean_AbilityDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00041E70 File Offset: 0x00040070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564445, XrefRangeEnd = 564458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Entity> _MakeEntitiesQueue_b__42_0(EntityListTargetResponse eltr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eltr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr__MakeEntitiesQueue_b__42_0_Private_Il2CppReferenceArray_1_Entity_EntityListTargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Entity>>(intPtr3) : null;
			}
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00041EC0 File Offset: 0x000400C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564458, XrefRangeEnd = 564462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Entity _MakeEntitiesQueue_b__42_1(EntityID t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr__MakeEntitiesQueue_b__42_1_Private_Entity_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entity>(intPtr3) : null;
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00041F10 File Offset: 0x00040110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564462, XrefRangeEnd = 564476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<IStagedAction> _CommitStack_b__64_0(ActiveAbility laa)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(laa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr__CommitStack_b__64_0_Private_IEnumerable_1_IStagedAction_ActiveAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IStagedAction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00041F60 File Offset: 0x00040160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 564476, XrefRangeEnd = 564478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Canis.actions.Action _CommitStack_b__64_1(SerializedStagedAction _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.NativeMethodInfoPtr__CommitStack_b__64_1_Private_Action_SerializedStagedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0000593B File Offset: 0x00003B3B
		public void StoreExecutionTargets(params TargetResponse[] responses)
		{
			this.StoreExecutionTargets(new Il2CppReferenceArray<TargetResponse>(responses));
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00005949 File Offset: 0x00003B49
		public ActiveAbility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00041FB0 File Offset: 0x000401B0
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x00005952 File Offset: 0x00003B52
		public unsafe static int BeginExecutionState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ActiveAbility.NativeFieldInfoPtr_BeginExecutionState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActiveAbility.NativeFieldInfoPtr_BeginExecutionState, (void*)(&value));
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000995 RID: 2453 RVA: 0x00041FCC File Offset: 0x000401CC
		// (set) Token: 0x06000996 RID: 2454 RVA: 0x00005960 File Offset: 0x00003B60
		public unsafe static int CompletedExecutionState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ActiveAbility.NativeFieldInfoPtr_CompletedExecutionState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActiveAbility.NativeFieldInfoPtr_CompletedExecutionState, (void*)(&value));
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x00041FE8 File Offset: 0x000401E8
		// (set) Token: 0x06000998 RID: 2456 RVA: 0x0000596E File Offset: 0x00003B6E
		public unsafe static int CanceledExecutionState
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ActiveAbility.NativeFieldInfoPtr_CanceledExecutionState, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ActiveAbility.NativeFieldInfoPtr_CanceledExecutionState, (void*)(&value));
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000999 RID: 2457 RVA: 0x00042004 File Offset: 0x00040204
		// (set) Token: 0x0600099A RID: 2458 RVA: 0x0000597C File Offset: 0x00003B7C
		public unsafe Canis.actions.Action _ReturningAction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility.NativeFieldInfoPtr__ReturningAction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility.NativeFieldInfoPtr__ReturningAction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeFieldInfoPtr_BeginExecutionState;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeFieldInfoPtr_CompletedExecutionState;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeFieldInfoPtr_CanceledExecutionState;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeFieldInfoPtr__ReturningAction_k__BackingField;

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_String_0;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilityID_Public_get_AbilityID_0;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_get_ReturningAction_Public_get_Action_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr_set_ReturningAction_Public_set_Void_Action_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseRunningPlayer_Public_get_PlayerEntity_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilityDefinition_Public_get_AbilityDefinition_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_get_AbilityState_Public_get_Int32_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_AdvanceToTargeting_Public_Void_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_AdvanceToCosting_Public_Void_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_AdvanceToExecuting_Public_Void_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentExecutionState_Public_get_Int32_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_AdvanceExecutionState_Public_Void_Int32_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_get_Cancellable_Public_get_Boolean_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_set_Cancellable_Public_set_Void_Boolean_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_get_StagedExecutionActions_Public_Virtual_New_get_Dictionary_2_Int32_List_1_SerializedStagedAction_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_FindDescendentStagedExecutionActions_Public_Virtual_New_Dictionary_2_Int32_List_1_SerializedStagedAction_Boolean_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_StagedExecutionActionsForState_Public_Virtual_New_List_1_SerializedStagedAction_Int32_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_AllOrderedStagedActions_Public_List_1_SerializedStagedAction_Boolean_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr_AllOrderedStagedExecutionActions_Public_Virtual_New_List_1_ValueTuple_2_Int32_SerializedStagedAction_Boolean_0;

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_UpsertStagedExecutionAction_Public_Virtual_New_Void_Int32_SerializedStagedAction_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_ClearStagedExecutionActionsForState_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_get_StagedCostActions_Public_Virtual_New_get_List_1_SerializedStagedAction_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_UpsertStagedCostAction_Public_Virtual_New_Void_SerializedStagedAction_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedRollbacks_Public_Virtual_New_get_List_1_Int32_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_RollbackExecutionState_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_MakeResponseQueue_Public_TargetResponseQueue_AttributeDefinition_1_Il2CppReferenceArray_1_TargetResponse_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_MakeEntitiesQueue_Public_List_1_Il2CppReferenceArray_1_Entity_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_get_FlattenedEntityTargets_Public_get_Il2CppReferenceArray_1_Entity_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_StoreExecutionTargets_Public_Void_Il2CppReferenceArray_1_TargetResponse_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_get_Context_Public_get_Context_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_get_Completed_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_get_Canceled_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_get_Succeeded_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_set_Succeeded_Public_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveGameLogBuilder_Public_get_GameLogBuilder_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveGameLogBuilder_Public_set_Void_GameLogBuilder_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActiveGameLogBuilder_Public_Void_Func_2_TGameLogBuilder_TGameLogBuilder_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActiveGameLogBuilder_Public_Void_Func_2_GameLogBuilder_GameLogBuilder_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveUndoNode_Public_get_UndoNode_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveUndoNode_Public_set_Void_UndoNode_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_UpdateActiveUndoNode_Public_Void_Func_2_UndoNode_UndoNode_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_CommitStack_Public_IEnumerable_1_Action_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr__get_AbilityDefinition_b__15_0_Private_Boolean_AbilityDefinition_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr__MakeEntitiesQueue_b__42_0_Private_Il2CppReferenceArray_1_Entity_EntityListTargetResponse_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr__MakeEntitiesQueue_b__42_1_Private_Entity_EntityID_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr__CommitStack_b__64_0_Private_IEnumerable_1_IStagedAction_ActiveAbility_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr__CommitStack_b__64_1_Private_Action_SerializedStagedAction_0;

		// Token: 0x02000311 RID: 785
		[ObfuscatedName("Canis.entities.ActiveAbility+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060020B7 RID: 8375 RVA: 0x00095600 File Offset: 0x00093800
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr);
				ActiveAbility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, "<>9");
				ActiveAbility.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, "<>9__29_0");
				ActiveAbility.__c.NativeFieldInfoPtr___9__31_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, "<>9__31_0");
				ActiveAbility.__c.NativeFieldInfoPtr___9__32_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, "<>9__32_0");
				ActiveAbility.__c.NativeFieldInfoPtr___9__32_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, "<>9__32_1");
				ActiveAbility.__c.NativeFieldInfoPtr___9__32_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, "<>9__32_2");
				ActiveAbility.__c.NativeFieldInfoPtr___9__44_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, "<>9__44_0");
				ActiveAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, 100665310);
				ActiveAbility.__c.NativeMethodInfoPtr__FindDescendentStagedExecutionActions_b__29_0_Internal_Boolean_ActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, 100665311);
				ActiveAbility.__c.NativeMethodInfoPtr__AllOrderedStagedActions_b__31_0_Internal_SerializedStagedAction_ValueTuple_2_Int32_SerializedStagedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, 100665312);
				ActiveAbility.__c.NativeMethodInfoPtr__AllOrderedStagedExecutionActions_b__32_0_Internal_Int32_KeyValuePair_2_Int32_List_1_SerializedStagedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, 100665313);
				ActiveAbility.__c.NativeMethodInfoPtr__AllOrderedStagedExecutionActions_b__32_1_Internal_Int32_KeyValuePair_2_Int32_List_1_SerializedStagedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, 100665314);
				ActiveAbility.__c.NativeMethodInfoPtr__AllOrderedStagedExecutionActions_b__32_2_Internal_IEnumerable_1_ValueTuple_2_Int32_SerializedStagedAction_KeyValuePair_2_Int32_List_1_SerializedStagedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, 100665315);
				ActiveAbility.__c.NativeMethodInfoPtr__get_FlattenedEntityTargets_b__44_0_Internal_IEnumerable_1_Entity_Il2CppReferenceArray_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr, 100665316);
			}

			// Token: 0x060020B8 RID: 8376 RVA: 0x00095744 File Offset: 0x00093944
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAbility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020B9 RID: 8377 RVA: 0x00095780 File Offset: 0x00093980
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562273, XrefRangeEnd = 562284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _FindDescendentStagedExecutionActions_b__29_0(ActiveAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.__c.NativeMethodInfoPtr__FindDescendentStagedExecutionActions_b__29_0_Internal_Boolean_ActiveAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020BA RID: 8378 RVA: 0x000957D0 File Offset: 0x000939D0
			[CallerCount(0)]
			public unsafe SerializedStagedAction _AllOrderedStagedActions_b__31_0(ValueTuple<int, SerializedStagedAction> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.__c.NativeMethodInfoPtr__AllOrderedStagedActions_b__31_0_Internal_SerializedStagedAction_ValueTuple_2_Int32_SerializedStagedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedStagedAction>(intPtr3) : null;
				}
			}

			// Token: 0x060020BB RID: 8379 RVA: 0x00095828 File Offset: 0x00093A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562284, XrefRangeEnd = 562285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AllOrderedStagedExecutionActions_b__32_0(KeyValuePair<int, List<SerializedStagedAction>> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.__c.NativeMethodInfoPtr__AllOrderedStagedExecutionActions_b__32_0_Internal_Int32_KeyValuePair_2_Int32_List_1_SerializedStagedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020BC RID: 8380 RVA: 0x0009587C File Offset: 0x00093A7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562285, XrefRangeEnd = 562286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AllOrderedStagedExecutionActions_b__32_1(KeyValuePair<int, List<SerializedStagedAction>> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.__c.NativeMethodInfoPtr__AllOrderedStagedExecutionActions_b__32_1_Internal_Int32_KeyValuePair_2_Int32_List_1_SerializedStagedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020BD RID: 8381 RVA: 0x000958D0 File Offset: 0x00093AD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562286, XrefRangeEnd = 562302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<ValueTuple<int, SerializedStagedAction>> _AllOrderedStagedExecutionActions_b__32_2(KeyValuePair<int, List<SerializedStagedAction>> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.__c.NativeMethodInfoPtr__AllOrderedStagedExecutionActions_b__32_2_Internal_IEnumerable_1_ValueTuple_2_Int32_SerializedStagedAction_KeyValuePair_2_Int32_List_1_SerializedStagedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<int, SerializedStagedAction>>>(intPtr3) : null;
				}
			}

			// Token: 0x060020BE RID: 8382 RVA: 0x00095928 File Offset: 0x00093B28
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Entity> _get_FlattenedEntityTargets_b__44_0(Il2CppReferenceArray<Entity> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.__c.NativeMethodInfoPtr__get_FlattenedEntityTargets_b__44_0_Internal_IEnumerable_1_Entity_Il2CppReferenceArray_1_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Entity>>(intPtr3) : null;
				}
			}

			// Token: 0x060020BF RID: 8383 RVA: 0x0000FB54 File Offset: 0x0000DD54
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007D4 RID: 2004
			// (get) Token: 0x060020C0 RID: 8384 RVA: 0x00095978 File Offset: 0x00093B78
			// (set) Token: 0x060020C1 RID: 8385 RVA: 0x0000FB5D File Offset: 0x0000DD5D
			public unsafe static ActiveAbility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ActiveAbility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActiveAbility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ActiveAbility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D5 RID: 2005
			// (get) Token: 0x060020C2 RID: 8386 RVA: 0x000959A0 File Offset: 0x00093BA0
			// (set) Token: 0x060020C3 RID: 8387 RVA: 0x0000FB6F File Offset: 0x0000DD6F
			public unsafe static Func<ActiveAbility, bool> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ActiveAbility.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ActiveAbility, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ActiveAbility.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D6 RID: 2006
			// (get) Token: 0x060020C4 RID: 8388 RVA: 0x000959C8 File Offset: 0x00093BC8
			// (set) Token: 0x060020C5 RID: 8389 RVA: 0x0000FB81 File Offset: 0x0000DD81
			public unsafe static Func<ValueTuple<int, SerializedStagedAction>, SerializedStagedAction> __9__31_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ActiveAbility.__c.NativeFieldInfoPtr___9__31_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, SerializedStagedAction>, SerializedStagedAction>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ActiveAbility.__c.NativeFieldInfoPtr___9__31_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D7 RID: 2007
			// (get) Token: 0x060020C6 RID: 8390 RVA: 0x000959F0 File Offset: 0x00093BF0
			// (set) Token: 0x060020C7 RID: 8391 RVA: 0x0000FB93 File Offset: 0x0000DD93
			public unsafe static Func<KeyValuePair<int, List<SerializedStagedAction>>, int> __9__32_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ActiveAbility.__c.NativeFieldInfoPtr___9__32_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, List<SerializedStagedAction>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ActiveAbility.__c.NativeFieldInfoPtr___9__32_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D8 RID: 2008
			// (get) Token: 0x060020C8 RID: 8392 RVA: 0x00095A18 File Offset: 0x00093C18
			// (set) Token: 0x060020C9 RID: 8393 RVA: 0x0000FBA5 File Offset: 0x0000DDA5
			public unsafe static Func<KeyValuePair<int, List<SerializedStagedAction>>, int> __9__32_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ActiveAbility.__c.NativeFieldInfoPtr___9__32_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, List<SerializedStagedAction>>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ActiveAbility.__c.NativeFieldInfoPtr___9__32_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007D9 RID: 2009
			// (get) Token: 0x060020CA RID: 8394 RVA: 0x00095A40 File Offset: 0x00093C40
			// (set) Token: 0x060020CB RID: 8395 RVA: 0x0000FBB7 File Offset: 0x0000DDB7
			public unsafe static Func<KeyValuePair<int, List<SerializedStagedAction>>, IEnumerable<ValueTuple<int, SerializedStagedAction>>> __9__32_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ActiveAbility.__c.NativeFieldInfoPtr___9__32_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, List<SerializedStagedAction>>, IEnumerable<ValueTuple<int, SerializedStagedAction>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ActiveAbility.__c.NativeFieldInfoPtr___9__32_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007DA RID: 2010
			// (get) Token: 0x060020CC RID: 8396 RVA: 0x00095A68 File Offset: 0x00093C68
			// (set) Token: 0x060020CD RID: 8397 RVA: 0x0000FBC9 File Offset: 0x0000DDC9
			public unsafe static Func<Il2CppReferenceArray<Entity>, IEnumerable<Entity>> __9__44_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ActiveAbility.__c.NativeFieldInfoPtr___9__44_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppReferenceArray<Entity>, IEnumerable<Entity>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ActiveAbility.__c.NativeFieldInfoPtr___9__44_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400149B RID: 5275
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400149C RID: 5276
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400149D RID: 5277
			private static readonly IntPtr NativeFieldInfoPtr___9__31_0;

			// Token: 0x0400149E RID: 5278
			private static readonly IntPtr NativeFieldInfoPtr___9__32_0;

			// Token: 0x0400149F RID: 5279
			private static readonly IntPtr NativeFieldInfoPtr___9__32_1;

			// Token: 0x040014A0 RID: 5280
			private static readonly IntPtr NativeFieldInfoPtr___9__32_2;

			// Token: 0x040014A1 RID: 5281
			private static readonly IntPtr NativeFieldInfoPtr___9__44_0;

			// Token: 0x040014A2 RID: 5282
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014A3 RID: 5283
			private static readonly IntPtr NativeMethodInfoPtr__FindDescendentStagedExecutionActions_b__29_0_Internal_Boolean_ActiveAbility_0;

			// Token: 0x040014A4 RID: 5284
			private static readonly IntPtr NativeMethodInfoPtr__AllOrderedStagedActions_b__31_0_Internal_SerializedStagedAction_ValueTuple_2_Int32_SerializedStagedAction_0;

			// Token: 0x040014A5 RID: 5285
			private static readonly IntPtr NativeMethodInfoPtr__AllOrderedStagedExecutionActions_b__32_0_Internal_Int32_KeyValuePair_2_Int32_List_1_SerializedStagedAction_0;

			// Token: 0x040014A6 RID: 5286
			private static readonly IntPtr NativeMethodInfoPtr__AllOrderedStagedExecutionActions_b__32_1_Internal_Int32_KeyValuePair_2_Int32_List_1_SerializedStagedAction_0;

			// Token: 0x040014A7 RID: 5287
			private static readonly IntPtr NativeMethodInfoPtr__AllOrderedStagedExecutionActions_b__32_2_Internal_IEnumerable_1_ValueTuple_2_Int32_SerializedStagedAction_KeyValuePair_2_Int32_List_1_SerializedStagedAction_0;

			// Token: 0x040014A8 RID: 5288
			private static readonly IntPtr NativeMethodInfoPtr__get_FlattenedEntityTargets_b__44_0_Internal_IEnumerable_1_Entity_Il2CppReferenceArray_1_Entity_0;
		}

		// Token: 0x02000312 RID: 786
		[ObfuscatedName("Canis.entities.ActiveAbility+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Object
		{
			// Token: 0x060020CE RID: 8398 RVA: 0x00095A90 File Offset: 0x00093C90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<ActiveAbility.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveAbility.__c__DisplayClass32_0>.NativeClassPtr);
				ActiveAbility.__c__DisplayClass32_0.NativeFieldInfoPtr_pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility.__c__DisplayClass32_0>.NativeClassPtr, "pair");
				ActiveAbility.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility.__c__DisplayClass32_0>.NativeClassPtr, 100665317);
				ActiveAbility.__c__DisplayClass32_0.NativeMethodInfoPtr__AllOrderedStagedExecutionActions_b__3_Internal_ValueTuple_2_Int32_SerializedStagedAction_SerializedStagedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility.__c__DisplayClass32_0>.NativeClassPtr, 100665318);
			}

			// Token: 0x060020CF RID: 8399 RVA: 0x00095AF8 File Offset: 0x00093CF8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAbility.__c__DisplayClass32_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020D0 RID: 8400 RVA: 0x00095B34 File Offset: 0x00093D34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562302, XrefRangeEnd = 562306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<int, SerializedStagedAction> _AllOrderedStagedExecutionActions_b__3(SerializedStagedAction act)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(act);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.__c__DisplayClass32_0.NativeMethodInfoPtr__AllOrderedStagedExecutionActions_b__3_Internal_ValueTuple_2_Int32_SerializedStagedAction_SerializedStagedAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<int, SerializedStagedAction>(intPtr);
				}
			}

			// Token: 0x060020D1 RID: 8401 RVA: 0x0000FBDB File Offset: 0x0000DDDB
			public __c__DisplayClass32_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007DB RID: 2011
			// (get) Token: 0x060020D2 RID: 8402 RVA: 0x00095B7C File Offset: 0x00093D7C
			// (set) Token: 0x060020D3 RID: 8403 RVA: 0x0000FBE4 File Offset: 0x0000DDE4
			public KeyValuePair<int, List<SerializedStagedAction>> pair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility.__c__DisplayClass32_0.NativeFieldInfoPtr_pair);
					return new KeyValuePair<int, List<SerializedStagedAction>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<int, List<SerializedStagedAction>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility.__c__DisplayClass32_0.NativeFieldInfoPtr_pair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<int, List<SerializedStagedAction>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040014A9 RID: 5289
			private static readonly IntPtr NativeFieldInfoPtr_pair;

			// Token: 0x040014AA RID: 5290
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014AB RID: 5291
			private static readonly IntPtr NativeMethodInfoPtr__AllOrderedStagedExecutionActions_b__3_Internal_ValueTuple_2_Int32_SerializedStagedAction_SerializedStagedAction_0;
		}

		// Token: 0x02000313 RID: 787
		[ObfuscatedName("Canis.entities.ActiveAbility+<>c__DisplayClass34_0")]
		public sealed class __c__DisplayClass34_0 : Object
		{
			// Token: 0x060020D4 RID: 8404 RVA: 0x00095BAC File Offset: 0x00093DAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass34_0()
			{
				Il2CppClassPointerStore<ActiveAbility.__c__DisplayClass34_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, "<>c__DisplayClass34_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveAbility.__c__DisplayClass34_0>.NativeClassPtr);
				ActiveAbility.__c__DisplayClass34_0.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility.__c__DisplayClass34_0>.NativeClassPtr, "state");
				ActiveAbility.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility.__c__DisplayClass34_0>.NativeClassPtr, 100665319);
				ActiveAbility.__c__DisplayClass34_0.NativeMethodInfoPtr__ClearStagedExecutionActionsForState_b__0_Internal_Boolean_ActiveAbility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility.__c__DisplayClass34_0>.NativeClassPtr, 100665320);
			}

			// Token: 0x060020D5 RID: 8405 RVA: 0x00095C14 File Offset: 0x00093E14
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass34_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAbility.__c__DisplayClass34_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.__c__DisplayClass34_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020D6 RID: 8406 RVA: 0x00095C50 File Offset: 0x00093E50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562306, XrefRangeEnd = 562318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ClearStagedExecutionActionsForState_b__0(ActiveAbility _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility.__c__DisplayClass34_0.NativeMethodInfoPtr__ClearStagedExecutionActionsForState_b__0_Internal_Boolean_ActiveAbility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060020D7 RID: 8407 RVA: 0x0000FC12 File Offset: 0x0000DE12
			public __c__DisplayClass34_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007DC RID: 2012
			// (get) Token: 0x060020D8 RID: 8408 RVA: 0x00095CA0 File Offset: 0x00093EA0
			// (set) Token: 0x060020D9 RID: 8409 RVA: 0x0000FC1B File Offset: 0x0000DE1B
			public unsafe int state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility.__c__DisplayClass34_0.NativeFieldInfoPtr_state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility.__c__DisplayClass34_0.NativeFieldInfoPtr_state)) = value;
				}
			}

			// Token: 0x040014AC RID: 5292
			private static readonly IntPtr NativeFieldInfoPtr_state;

			// Token: 0x040014AD RID: 5293
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040014AE RID: 5294
			private static readonly IntPtr NativeMethodInfoPtr__ClearStagedExecutionActionsForState_b__0_Internal_Boolean_ActiveAbility_0;
		}

		// Token: 0x02000314 RID: 788
		[ObfuscatedName("Canis.entities.ActiveAbility+<CommitStack>d__64")]
		public sealed class _CommitStack_d__64 : Object
		{
			// Token: 0x060020DA RID: 8410 RVA: 0x00095CC8 File Offset: 0x00093EC8
			// Note: this type is marked as 'beforefieldinit'.
			static _CommitStack_d__64()
			{
				Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr, "<CommitStack>d__64");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr);
				ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, "<>1__state");
				ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, "<>2__current");
				ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, "<>l__initialThreadId");
				ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, "<>4__this");
				ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, "<>7__wrap1");
				ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, "<>7__wrap2");
				ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, 100665321);
				ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, 100665322);
				ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, 100665323);
				ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, 100665324);
				ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, 100665325);
				ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, 100665326);
				ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, 100665327);
				ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, 100665328);
				ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, 100665329);
				ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr, 100665330);
			}

			// Token: 0x060020DB RID: 8411 RVA: 0x00095E34 File Offset: 0x00094034
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CommitStack_d__64(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveAbility._CommitStack_d__64>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020DC RID: 8412 RVA: 0x00095E7C File Offset: 0x0009407C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562318, XrefRangeEnd = 562331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020DD RID: 8413 RVA: 0x00095EB0 File Offset: 0x000940B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562331, XrefRangeEnd = 562491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060020DE RID: 8414 RVA: 0x00095EEC File Offset: 0x000940EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562491, XrefRangeEnd = 562494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020DF RID: 8415 RVA: 0x00095F20 File Offset: 0x00094120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562494, XrefRangeEnd = 562497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007E3 RID: 2019
			// (get) Token: 0x060020E0 RID: 8416 RVA: 0x00095F54 File Offset: 0x00094154
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x060020E1 RID: 8417 RVA: 0x00095F94 File Offset: 0x00094194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562497, XrefRangeEnd = 562502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007E4 RID: 2020
			// (get) Token: 0x060020E2 RID: 8418 RVA: 0x00095FC8 File Offset: 0x000941C8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020E3 RID: 8419 RVA: 0x00096008 File Offset: 0x00094208
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 562502, XrefRangeEnd = 562504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x060020E4 RID: 8420 RVA: 0x00096048 File Offset: 0x00094248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveAbility._CommitStack_d__64.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060020E5 RID: 8421 RVA: 0x0000FC36 File Offset: 0x0000DE36
			public _CommitStack_d__64(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007DD RID: 2013
			// (get) Token: 0x060020E6 RID: 8422 RVA: 0x00096088 File Offset: 0x00094288
			// (set) Token: 0x060020E7 RID: 8423 RVA: 0x0000FC3F File Offset: 0x0000DE3F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007DE RID: 2014
			// (get) Token: 0x060020E8 RID: 8424 RVA: 0x000960B0 File Offset: 0x000942B0
			// (set) Token: 0x060020E9 RID: 8425 RVA: 0x0000FC5A File Offset: 0x0000DE5A
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007DF RID: 2015
			// (get) Token: 0x060020EA RID: 8426 RVA: 0x000960E0 File Offset: 0x000942E0
			// (set) Token: 0x060020EB RID: 8427 RVA: 0x0000FC79 File Offset: 0x0000DE79
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170007E0 RID: 2016
			// (get) Token: 0x060020EC RID: 8428 RVA: 0x00096108 File Offset: 0x00094308
			// (set) Token: 0x060020ED RID: 8429 RVA: 0x0000FC94 File Offset: 0x0000DE94
			public unsafe ActiveAbility __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ActiveAbility>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E1 RID: 2017
			// (get) Token: 0x060020EE RID: 8430 RVA: 0x00096138 File Offset: 0x00094338
			// (set) Token: 0x060020EF RID: 8431 RVA: 0x0000FCB3 File Offset: 0x0000DEB3
			public List<IStagedAction>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___7__wrap1);
					return new List<IStagedAction>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<IStagedAction>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<IStagedAction>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170007E2 RID: 2018
			// (get) Token: 0x060020F0 RID: 8432 RVA: 0x00096168 File Offset: 0x00094368
			// (set) Token: 0x060020F1 RID: 8433 RVA: 0x0000FCE1 File Offset: 0x0000DEE1
			public unsafe IEnumerator<Canis.actions.Action> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveAbility._CommitStack_d__64.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040014AF RID: 5295
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040014B0 RID: 5296
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040014B1 RID: 5297
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x040014B2 RID: 5298
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040014B3 RID: 5299
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040014B4 RID: 5300
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x040014B5 RID: 5301
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040014B6 RID: 5302
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014B7 RID: 5303
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040014B8 RID: 5304
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x040014B9 RID: 5305
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x040014BA RID: 5306
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x040014BB RID: 5307
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040014BC RID: 5308
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040014BD RID: 5309
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x040014BE RID: 5310
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000315 RID: 789
		private sealed class MethodInfoStoreGeneric_UpdateActiveGameLogBuilder_Public_Void_Func_2_TGameLogBuilder_TGameLogBuilder_0<TGameLogBuilder>
		{
			// Token: 0x040014BF RID: 5311
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ActiveAbility.NativeMethodInfoPtr_UpdateActiveGameLogBuilder_Public_Void_Func_2_TGameLogBuilder_TGameLogBuilder_0, Il2CppClassPointerStore<ActiveAbility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TGameLogBuilder>.NativeClassPtr)) }))));
		}
	}
}
