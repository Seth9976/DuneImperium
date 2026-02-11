using System;
using Canis.actions;
using Canis.data;
using Canis.hasExecutionStack;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages;
using Networking.selection.messages.outgoing;
using Networking.selection.targetinformation;
using Networking.selection.targetresponse;

namespace Canis.entities
{
	// Token: 0x020000EE RID: 238
	public class PlayerEntity : Entity
	{
		// Token: 0x06000A81 RID: 2689 RVA: 0x00046270 File Offset: 0x00044470
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerEntity()
		{
			Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "PlayerEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr);
			PlayerEntity.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, "AccountID");
			PlayerEntity.NativeFieldInfoPtr_consecutiveSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, "consecutiveSelections");
			PlayerEntity.NativeFieldInfoPtr__ConsecutiveAITimeouts_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, "<ConsecutiveAITimeouts>k__BackingField");
			PlayerEntity.NativeMethodInfoPtr_get_ConsecutiveAITimeouts_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665550);
			PlayerEntity.NativeMethodInfoPtr_set_ConsecutiveAITimeouts_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665551);
			PlayerEntity.NativeMethodInfoPtr__ctor_Public_Void_Match_AccountID_PlayerMatchInitData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665552);
			PlayerEntity.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665553);
			PlayerEntity.NativeMethodInfoPtr_get_PlayerName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665554);
			PlayerEntity.NativeMethodInfoPtr_get_IsAI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665555);
			PlayerEntity.NativeMethodInfoPtr_get_StartsAsAI_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665556);
			PlayerEntity.NativeMethodInfoPtr_get_IsReplacedByAI_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665557);
			PlayerEntity.NativeMethodInfoPtr_get_StartedAsHuman_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665558);
			PlayerEntity.NativeMethodInfoPtr_OnCompletedSelection_Public_Virtual_New_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665559);
			PlayerEntity.NativeMethodInfoPtr_get_AILevel_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665560);
			PlayerEntity.NativeMethodInfoPtr_get_ClientVersion_Public_get_ClientVersionInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665561);
			PlayerEntity.NativeMethodInfoPtr_get_InfoSaveData_Public_Virtual_New_get_PlayerInfoSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665562);
			PlayerEntity.NativeMethodInfoPtr_GetPlayerPreAIDecisionAction_Public_Virtual_New_Action_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665563);
			PlayerEntity.NativeMethodInfoPtr_SelectFrom_Public_Virtual_New_IEnumerator_SelectionMessage_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665564);
			PlayerEntity.NativeMethodInfoPtr_IsInSelectionLoop_Public_Virtual_Final_New_Boolean_SelectionMessage_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665565);
			PlayerEntity.NativeMethodInfoPtr_get_ConsecutiveTimeoutThreshold_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665566);
			PlayerEntity.NativeMethodInfoPtr_IncrementConsecutiveTimeout_Public_Virtual_New_Boolean_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665567);
			PlayerEntity.NativeMethodInfoPtr_ResetConsecutiveTimeout_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665568);
			PlayerEntity.NativeMethodInfoPtr_DefaultRandomChoice_Public_Virtual_New_ISelectionCounter_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665569);
			PlayerEntity.NativeMethodInfoPtr_MakeEmptyResponse_Protected_Virtual_New_IEnumerable_1_TargetResponse_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665570);
			PlayerEntity.NativeMethodInfoPtr_DetermineDefaultRandomChoice_Public_Virtual_New_ISelectionCounter_SelectionMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665571);
			PlayerEntity.NativeMethodInfoPtr_SelectRandomlyForTargetInformation_Protected_Virtual_New_ValueTuple_2_List_1_ValueTuple_2_EntityID_Int32_Int32_Il2CppReferenceArray_1_TargetInformation_Int32_List_1_TargetResponse_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, 100665572);
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x000464A8 File Offset: 0x000446A8
		// (set) Token: 0x06000A83 RID: 2691 RVA: 0x000464E4 File Offset: 0x000446E4
		public unsafe int ConsecutiveAITimeouts
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.NativeMethodInfoPtr_get_ConsecutiveAITimeouts_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.NativeMethodInfoPtr_set_ConsecutiveAITimeouts_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x00046524 File Offset: 0x00044724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 566515, RefRangeEnd = 566516, XrefRangeStart = 566471, XrefRangeEnd = 566515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEntity(Match m, AccountID accountID, PlayerMatchInitData playerInitData, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerInitData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.NativeMethodInfoPtr__ctor_Public_Void_Match_AccountID_PlayerMatchInitData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000465A8 File Offset: 0x000447A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 566538, RefRangeEnd = 566540, XrefRangeStart = 566516, XrefRangeEnd = 566538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerEntity(SerializedEntity se, Match m, Entity parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(se);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x00046618 File Offset: 0x00044818
		public unsafe virtual string PlayerName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566540, XrefRangeEnd = 566554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_get_PlayerName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0004665C File Offset: 0x0004485C
		public unsafe bool IsAI
		{
			[CallerCount(226)]
			[CachedScanResults(RefRangeStart = 566561, RefRangeEnd = 566787, XrefRangeStart = 566554, XrefRangeEnd = 566561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.NativeMethodInfoPtr_get_IsAI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000A88 RID: 2696 RVA: 0x00046698 File Offset: 0x00044898
		public unsafe bool StartsAsAI
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 566794, RefRangeEnd = 566797, XrefRangeStart = 566787, XrefRangeEnd = 566794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.NativeMethodInfoPtr_get_StartsAsAI_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000A89 RID: 2697 RVA: 0x000466D4 File Offset: 0x000448D4
		public unsafe virtual bool IsReplacedByAI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566797, XrefRangeEnd = 566804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_get_IsReplacedByAI_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0004671C File Offset: 0x0004491C
		public unsafe virtual bool StartedAsHuman
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566804, XrefRangeEnd = 566811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_get_StartedAsHuman_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x00046764 File Offset: 0x00044964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566811, XrefRangeEnd = 566817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<Canis.actions.Action> OnCompletedSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_OnCompletedSelection_Public_Virtual_New_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x000467B0 File Offset: 0x000449B0
		public unsafe virtual int AILevel
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566817, XrefRangeEnd = 566824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_get_AILevel_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x000467F8 File Offset: 0x000449F8
		public unsafe ClientVersionInfo ClientVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566824, XrefRangeEnd = 566834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.NativeMethodInfoPtr_get_ClientVersion_Public_get_ClientVersionInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ClientVersionInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000A8E RID: 2702 RVA: 0x00046838 File Offset: 0x00044A38
		public unsafe virtual PlayerInfoSaveData InfoSaveData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566834, XrefRangeEnd = 566841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_get_InfoSaveData_Public_Virtual_New_get_PlayerInfoSaveData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlayerInfoSaveData>(intPtr3) : null;
			}
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00046884 File Offset: 0x00044A84
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Canis.actions.Action GetPlayerPreAIDecisionAction(SelectionMessage sm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_GetPlayerPreAIDecisionAction_Public_Virtual_New_Action_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x000468E0 File Offset: 0x00044AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566841, XrefRangeEnd = 566847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator SelectFrom(SelectionMessage selection, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_SelectFrom_Public_Virtual_New_IEnumerator_SelectionMessage_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00046950 File Offset: 0x00044B50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 566883, RefRangeEnd = 566885, XrefRangeStart = 566847, XrefRangeEnd = 566883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsInSelectionLoop(SelectionMessage selection, Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.NativeMethodInfoPtr_IsInSelectionLoop_Public_Virtual_Final_New_Boolean_SelectionMessage_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x000469B0 File Offset: 0x00044BB0
		public unsafe virtual int ConsecutiveTimeoutThreshold
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_get_ConsecutiveTimeoutThreshold_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x000469F8 File Offset: 0x00044BF8
		[CallerCount(0)]
		public unsafe virtual bool IncrementConsecutiveTimeout(SelectionMessage selectionMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selectionMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_IncrementConsecutiveTimeout_Public_Virtual_New_Boolean_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x00046A50 File Offset: 0x00044C50
		[CallerCount(0)]
		public unsafe virtual void ResetConsecutiveTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_ResetConsecutiveTimeout_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00046A8C File Offset: 0x00044C8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566885, XrefRangeEnd = 566923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionCounter DefaultRandomChoice(SelectionMessage selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_DefaultRandomChoice_Public_Virtual_New_ISelectionCounter_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionCounter>(intPtr3) : null;
			}
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00046AE8 File Offset: 0x00044CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566923, XrefRangeEnd = 566928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<TargetResponse> MakeEmptyResponse(EntityID selected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selected);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_MakeEmptyResponse_Protected_Virtual_New_IEnumerable_1_TargetResponse_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TargetResponse>>(intPtr3) : null;
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x00046B44 File Offset: 0x00044D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566928, XrefRangeEnd = 567056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ISelectionCounter DetermineDefaultRandomChoice(SelectionMessage selection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(selection);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_DetermineDefaultRandomChoice_Public_Virtual_New_ISelectionCounter_SelectionMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISelectionCounter>(intPtr3) : null;
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00046BA0 File Offset: 0x00044DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 567056, XrefRangeEnd = 567325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValueTuple<List<ValueTuple<EntityID, int>>, int> SelectRandomlyForTargetInformation(Il2CppReferenceArray<TargetInformation> targets, int i, List<TargetResponse> responses, EntityID sourceID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targets);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responses);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerEntity.NativeMethodInfoPtr_SelectRandomlyForTargetInformation_Protected_Virtual_New_ValueTuple_2_List_1_ValueTuple_2_EntityID_Int32_Int32_Il2CppReferenceArray_1_TargetInformation_Int32_List_1_TargetResponse_EntityID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new ValueTuple<List<ValueTuple<EntityID, int>>, int>(intPtr);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00005D77 File Offset: 0x00003F77
		public PlayerEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x00046C28 File Offset: 0x00044E28
		// (set) Token: 0x06000A9B RID: 2715 RVA: 0x00005D80 File Offset: 0x00003F80
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00046C58 File Offset: 0x00044E58
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x00005D9F File Offset: 0x00003F9F
		public unsafe int consecutiveSelections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity.NativeFieldInfoPtr_consecutiveSelections);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity.NativeFieldInfoPtr_consecutiveSelections)) = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x00046C80 File Offset: 0x00044E80
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x00005DBA File Offset: 0x00003FBA
		public unsafe int _ConsecutiveAITimeouts_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity.NativeFieldInfoPtr__ConsecutiveAITimeouts_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity.NativeFieldInfoPtr__ConsecutiveAITimeouts_k__BackingField)) = value;
			}
		}

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeFieldInfoPtr_consecutiveSelections;

		// Token: 0x0400072B RID: 1835
		private static readonly IntPtr NativeFieldInfoPtr__ConsecutiveAITimeouts_k__BackingField;

		// Token: 0x0400072C RID: 1836
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsecutiveAITimeouts_Public_get_Int32_0;

		// Token: 0x0400072D RID: 1837
		private static readonly IntPtr NativeMethodInfoPtr_set_ConsecutiveAITimeouts_Protected_set_Void_Int32_0;

		// Token: 0x0400072E RID: 1838
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Match_AccountID_PlayerMatchInitData_String_0;

		// Token: 0x0400072F RID: 1839
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializedEntity_Match_Entity_0;

		// Token: 0x04000730 RID: 1840
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerName_Public_Virtual_New_get_String_0;

		// Token: 0x04000731 RID: 1841
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAI_Public_get_Boolean_0;

		// Token: 0x04000732 RID: 1842
		private static readonly IntPtr NativeMethodInfoPtr_get_StartsAsAI_Public_get_Boolean_0;

		// Token: 0x04000733 RID: 1843
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReplacedByAI_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000734 RID: 1844
		private static readonly IntPtr NativeMethodInfoPtr_get_StartedAsHuman_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000735 RID: 1845
		private static readonly IntPtr NativeMethodInfoPtr_OnCompletedSelection_Public_Virtual_New_IEnumerable_1_Action_0;

		// Token: 0x04000736 RID: 1846
		private static readonly IntPtr NativeMethodInfoPtr_get_AILevel_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000737 RID: 1847
		private static readonly IntPtr NativeMethodInfoPtr_get_ClientVersion_Public_get_ClientVersionInfo_0;

		// Token: 0x04000738 RID: 1848
		private static readonly IntPtr NativeMethodInfoPtr_get_InfoSaveData_Public_Virtual_New_get_PlayerInfoSaveData_0;

		// Token: 0x04000739 RID: 1849
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerPreAIDecisionAction_Public_Virtual_New_Action_SelectionMessage_0;

		// Token: 0x0400073A RID: 1850
		private static readonly IntPtr NativeMethodInfoPtr_SelectFrom_Public_Virtual_New_IEnumerator_SelectionMessage_Match_0;

		// Token: 0x0400073B RID: 1851
		private static readonly IntPtr NativeMethodInfoPtr_IsInSelectionLoop_Public_Virtual_Final_New_Boolean_SelectionMessage_Match_0;

		// Token: 0x0400073C RID: 1852
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsecutiveTimeoutThreshold_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400073D RID: 1853
		private static readonly IntPtr NativeMethodInfoPtr_IncrementConsecutiveTimeout_Public_Virtual_New_Boolean_SelectionMessage_0;

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeMethodInfoPtr_ResetConsecutiveTimeout_Public_Virtual_New_Void_0;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeMethodInfoPtr_DefaultRandomChoice_Public_Virtual_New_ISelectionCounter_SelectionMessage_0;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeMethodInfoPtr_MakeEmptyResponse_Protected_Virtual_New_IEnumerable_1_TargetResponse_EntityID_0;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeMethodInfoPtr_DetermineDefaultRandomChoice_Public_Virtual_New_ISelectionCounter_SelectionMessage_0;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeMethodInfoPtr_SelectRandomlyForTargetInformation_Protected_Virtual_New_ValueTuple_2_List_1_ValueTuple_2_EntityID_Int32_Int32_Il2CppReferenceArray_1_TargetInformation_Int32_List_1_TargetResponse_EntityID_0;

		// Token: 0x02000331 RID: 817
		[ObfuscatedName("Canis.entities.PlayerEntity+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060021F8 RID: 8696 RVA: 0x00099940 File Offset: 0x00097B40
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayerEntity.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEntity.__c>.NativeClassPtr);
				PlayerEntity.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity.__c>.NativeClassPtr, "<>9");
				PlayerEntity.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity.__c>.NativeClassPtr, "<>9__35_0");
				PlayerEntity.__c.NativeFieldInfoPtr___9__35_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity.__c>.NativeClassPtr, "<>9__35_1");
				PlayerEntity.__c.NativeFieldInfoPtr___9__35_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity.__c>.NativeClassPtr, "<>9__35_2");
				PlayerEntity.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity.__c>.NativeClassPtr, 100665574);
				PlayerEntity.__c.NativeMethodInfoPtr__SelectRandomlyForTargetInformation_b__35_0_Internal_ValueTuple_2_EntityID_Int32_KeyValuePair_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity.__c>.NativeClassPtr, 100665575);
				PlayerEntity.__c.NativeMethodInfoPtr__SelectRandomlyForTargetInformation_b__35_1_Internal_Int32_ValueTuple_2_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity.__c>.NativeClassPtr, 100665576);
				PlayerEntity.__c.NativeMethodInfoPtr__SelectRandomlyForTargetInformation_b__35_2_Internal_ValueTuple_2_EntityID_Int32_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity.__c>.NativeClassPtr, 100665577);
			}

			// Token: 0x060021F9 RID: 8697 RVA: 0x00099A0C File Offset: 0x00097C0C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEntity.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060021FA RID: 8698 RVA: 0x00099A48 File Offset: 0x00097C48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566404, XrefRangeEnd = 566409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<EntityID, int> _SelectRandomlyForTargetInformation_b__35_0(KeyValuePair<EntityID, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.__c.NativeMethodInfoPtr__SelectRandomlyForTargetInformation_b__35_0_Internal_ValueTuple_2_EntityID_Int32_KeyValuePair_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<EntityID, int>(intPtr);
				}
			}

			// Token: 0x060021FB RID: 8699 RVA: 0x00099A98 File Offset: 0x00097C98
			[CallerCount(0)]
			public unsafe int _SelectRandomlyForTargetInformation_b__35_1(ValueTuple<EntityID, int> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.__c.NativeMethodInfoPtr__SelectRandomlyForTargetInformation_b__35_1_Internal_Int32_ValueTuple_2_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060021FC RID: 8700 RVA: 0x00099AEC File Offset: 0x00097CEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566409, XrefRangeEnd = 566412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<EntityID, int> _SelectRandomlyForTargetInformation_b__35_2(EntityID _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.__c.NativeMethodInfoPtr__SelectRandomlyForTargetInformation_b__35_2_Internal_ValueTuple_2_EntityID_Int32_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new ValueTuple<EntityID, int>(intPtr);
				}
			}

			// Token: 0x060021FD RID: 8701 RVA: 0x000104CB File Offset: 0x0000E6CB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000834 RID: 2100
			// (get) Token: 0x060021FE RID: 8702 RVA: 0x00099B34 File Offset: 0x00097D34
			// (set) Token: 0x060021FF RID: 8703 RVA: 0x000104D4 File Offset: 0x0000E6D4
			public unsafe static PlayerEntity.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerEntity.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerEntity.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000835 RID: 2101
			// (get) Token: 0x06002200 RID: 8704 RVA: 0x00099B5C File Offset: 0x00097D5C
			// (set) Token: 0x06002201 RID: 8705 RVA: 0x000104E6 File Offset: 0x0000E6E6
			public unsafe static Func<KeyValuePair<EntityID, int>, ValueTuple<EntityID, int>> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerEntity.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<EntityID, int>, ValueTuple<EntityID, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerEntity.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000836 RID: 2102
			// (get) Token: 0x06002202 RID: 8706 RVA: 0x00099B84 File Offset: 0x00097D84
			// (set) Token: 0x06002203 RID: 8707 RVA: 0x000104F8 File Offset: 0x0000E6F8
			public unsafe static Func<ValueTuple<EntityID, int>, int> __9__35_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerEntity.__c.NativeFieldInfoPtr___9__35_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<EntityID, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerEntity.__c.NativeFieldInfoPtr___9__35_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000837 RID: 2103
			// (get) Token: 0x06002204 RID: 8708 RVA: 0x00099BAC File Offset: 0x00097DAC
			// (set) Token: 0x06002205 RID: 8709 RVA: 0x0001050A File Offset: 0x0000E70A
			public unsafe static Func<EntityID, ValueTuple<EntityID, int>> __9__35_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerEntity.__c.NativeFieldInfoPtr___9__35_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityID, ValueTuple<EntityID, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerEntity.__c.NativeFieldInfoPtr___9__35_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400155C RID: 5468
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400155D RID: 5469
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x0400155E RID: 5470
			private static readonly IntPtr NativeFieldInfoPtr___9__35_1;

			// Token: 0x0400155F RID: 5471
			private static readonly IntPtr NativeFieldInfoPtr___9__35_2;

			// Token: 0x04001560 RID: 5472
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001561 RID: 5473
			private static readonly IntPtr NativeMethodInfoPtr__SelectRandomlyForTargetInformation_b__35_0_Internal_ValueTuple_2_EntityID_Int32_KeyValuePair_2_EntityID_Int32_0;

			// Token: 0x04001562 RID: 5474
			private static readonly IntPtr NativeMethodInfoPtr__SelectRandomlyForTargetInformation_b__35_1_Internal_Int32_ValueTuple_2_EntityID_Int32_0;

			// Token: 0x04001563 RID: 5475
			private static readonly IntPtr NativeMethodInfoPtr__SelectRandomlyForTargetInformation_b__35_2_Internal_ValueTuple_2_EntityID_Int32_EntityID_0;
		}

		// Token: 0x02000332 RID: 818
		[ObfuscatedName("Canis.entities.PlayerEntity+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Object
		{
			// Token: 0x06002206 RID: 8710 RVA: 0x00099BD4 File Offset: 0x00097DD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<PlayerEntity.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEntity.__c__DisplayClass27_0>.NativeClassPtr);
				PlayerEntity.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				PlayerEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity.__c__DisplayClass27_0>.NativeClassPtr, "selection");
				PlayerEntity.__c__DisplayClass27_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity.__c__DisplayClass27_0>.NativeClassPtr, "<>9__1");
				PlayerEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity.__c__DisplayClass27_0>.NativeClassPtr, 100665578);
				PlayerEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__IsInSelectionLoop_b__0_Internal_Boolean_PlayerEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity.__c__DisplayClass27_0>.NativeClassPtr, 100665579);
				PlayerEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__IsInSelectionLoop_b__1_Internal_Boolean_PendingSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity.__c__DisplayClass27_0>.NativeClassPtr, 100665580);
			}

			// Token: 0x06002207 RID: 8711 RVA: 0x00099C78 File Offset: 0x00097E78
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEntity.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002208 RID: 8712 RVA: 0x00099CB4 File Offset: 0x00097EB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566412, XrefRangeEnd = 566415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsInSelectionLoop_b__0(PlayerEntity player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__IsInSelectionLoop_b__0_Internal_Boolean_PlayerEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002209 RID: 8713 RVA: 0x00099D04 File Offset: 0x00097F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566415, XrefRangeEnd = 566416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _IsInSelectionLoop_b__1(PendingSelection ps)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ps);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity.__c__DisplayClass27_0.NativeMethodInfoPtr__IsInSelectionLoop_b__1_Internal_Boolean_PendingSelection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600220A RID: 8714 RVA: 0x0001051C File Offset: 0x0000E71C
			public __c__DisplayClass27_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000838 RID: 2104
			// (get) Token: 0x0600220B RID: 8715 RVA: 0x00099D54 File Offset: 0x00097F54
			// (set) Token: 0x0600220C RID: 8716 RVA: 0x00010525 File Offset: 0x0000E725
			public unsafe PlayerEntity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000839 RID: 2105
			// (get) Token: 0x0600220D RID: 8717 RVA: 0x00099D84 File Offset: 0x00097F84
			// (set) Token: 0x0600220E RID: 8718 RVA: 0x00010544 File Offset: 0x0000E744
			public unsafe SelectionMessage selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity.__c__DisplayClass27_0.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083A RID: 2106
			// (get) Token: 0x0600220F RID: 8719 RVA: 0x00099DB4 File Offset: 0x00097FB4
			// (set) Token: 0x06002210 RID: 8720 RVA: 0x00010563 File Offset: 0x0000E763
			public unsafe Func<PendingSelection, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity.__c__DisplayClass27_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PendingSelection, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity.__c__DisplayClass27_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001564 RID: 5476
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001565 RID: 5477
			private static readonly IntPtr NativeFieldInfoPtr_selection;

			// Token: 0x04001566 RID: 5478
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04001567 RID: 5479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001568 RID: 5480
			private static readonly IntPtr NativeMethodInfoPtr__IsInSelectionLoop_b__0_Internal_Boolean_PlayerEntity_0;

			// Token: 0x04001569 RID: 5481
			private static readonly IntPtr NativeMethodInfoPtr__IsInSelectionLoop_b__1_Internal_Boolean_PendingSelection_0;
		}

		// Token: 0x02000333 RID: 819
		[ObfuscatedName("Canis.entities.PlayerEntity+<MakeEmptyResponse>d__33")]
		public sealed class _MakeEmptyResponse_d__33 : Object
		{
			// Token: 0x06002211 RID: 8721 RVA: 0x00099DE4 File Offset: 0x00097FE4
			// Note: this type is marked as 'beforefieldinit'.
			static _MakeEmptyResponse_d__33()
			{
				Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, "<MakeEmptyResponse>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr);
				PlayerEntity._MakeEmptyResponse_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr, "<>1__state");
				PlayerEntity._MakeEmptyResponse_d__33.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr, "<>2__current");
				PlayerEntity._MakeEmptyResponse_d__33.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr, "<>l__initialThreadId");
				PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr, 100665581);
				PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr, 100665582);
				PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr, 100665583);
				PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetresponse_TargetResponse__get_Current_Private_Virtual_Final_New_get_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr, 100665584);
				PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr, 100665585);
				PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr, 100665586);
				PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetresponse_TargetResponse__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr, 100665587);
				PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr, 100665588);
			}

			// Token: 0x06002212 RID: 8722 RVA: 0x00099EEC File Offset: 0x000980EC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MakeEmptyResponse_d__33(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEntity._MakeEmptyResponse_d__33>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002213 RID: 8723 RVA: 0x00099F34 File Offset: 0x00098134
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002214 RID: 8724 RVA: 0x00099F68 File Offset: 0x00098168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566416, XrefRangeEnd = 566427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700083E RID: 2110
			// (get) Token: 0x06002215 RID: 8725 RVA: 0x00099FA4 File Offset: 0x000981A4
			public unsafe TargetResponse System.Collections.Generic.IEnumerator<Networking.selection.targetresponse.TargetResponse>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetresponse_TargetResponse__get_Current_Private_Virtual_Final_New_get_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr3) : null;
				}
			}

			// Token: 0x06002216 RID: 8726 RVA: 0x00099FE4 File Offset: 0x000981E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566427, XrefRangeEnd = 566432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700083F RID: 2111
			// (get) Token: 0x06002217 RID: 8727 RVA: 0x0009A018 File Offset: 0x00098218
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002218 RID: 8728 RVA: 0x0009A058 File Offset: 0x00098258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566432, XrefRangeEnd = 566434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<TargetResponse> System_Collections_Generic_IEnumerable_Networking_selection_targetresponse_TargetResponse__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetresponse_TargetResponse__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<TargetResponse>>(intPtr3) : null;
			}

			// Token: 0x06002219 RID: 8729 RVA: 0x0009A098 File Offset: 0x00098298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._MakeEmptyResponse_d__33.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600221A RID: 8730 RVA: 0x00010582 File Offset: 0x0000E782
			public _MakeEmptyResponse_d__33(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700083B RID: 2107
			// (get) Token: 0x0600221B RID: 8731 RVA: 0x0009A0D8 File Offset: 0x000982D8
			// (set) Token: 0x0600221C RID: 8732 RVA: 0x0001058B File Offset: 0x0000E78B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._MakeEmptyResponse_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._MakeEmptyResponse_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700083C RID: 2108
			// (get) Token: 0x0600221D RID: 8733 RVA: 0x0009A100 File Offset: 0x00098300
			// (set) Token: 0x0600221E RID: 8734 RVA: 0x000105A6 File Offset: 0x0000E7A6
			public unsafe TargetResponse __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._MakeEmptyResponse_d__33.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TargetResponse>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._MakeEmptyResponse_d__33.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700083D RID: 2109
			// (get) Token: 0x0600221F RID: 8735 RVA: 0x0009A130 File Offset: 0x00098330
			// (set) Token: 0x06002220 RID: 8736 RVA: 0x000105C5 File Offset: 0x0000E7C5
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._MakeEmptyResponse_d__33.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._MakeEmptyResponse_d__33.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x0400156A RID: 5482
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400156B RID: 5483
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400156C RID: 5484
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400156D RID: 5485
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400156E RID: 5486
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400156F RID: 5487
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001570 RID: 5488
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Networking_selection_targetresponse_TargetResponse__get_Current_Private_Virtual_Final_New_get_TargetResponse_0;

			// Token: 0x04001571 RID: 5489
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001572 RID: 5490
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001573 RID: 5491
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Networking_selection_targetresponse_TargetResponse__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_TargetResponse_0;

			// Token: 0x04001574 RID: 5492
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000334 RID: 820
		[ObfuscatedName("Canis.entities.PlayerEntity+<OnCompletedSelection>d__18")]
		public sealed class _OnCompletedSelection_d__18 : Object
		{
			// Token: 0x06002221 RID: 8737 RVA: 0x0009A158 File Offset: 0x00098358
			// Note: this type is marked as 'beforefieldinit'.
			static _OnCompletedSelection_d__18()
			{
				Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, "<OnCompletedSelection>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr);
				PlayerEntity._OnCompletedSelection_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr, "<>1__state");
				PlayerEntity._OnCompletedSelection_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr, "<>2__current");
				PlayerEntity._OnCompletedSelection_d__18.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr, "<>l__initialThreadId");
				PlayerEntity._OnCompletedSelection_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr, "<>4__this");
				PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr, 100665589);
				PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr, 100665590);
				PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr, 100665591);
				PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr, 100665592);
				PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr, 100665593);
				PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr, 100665594);
				PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr, 100665595);
				PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr, 100665596);
			}

			// Token: 0x06002222 RID: 8738 RVA: 0x0009A274 File Offset: 0x00098474
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnCompletedSelection_d__18(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEntity._OnCompletedSelection_d__18>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002223 RID: 8739 RVA: 0x0009A2BC File Offset: 0x000984BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002224 RID: 8740 RVA: 0x0009A2F0 File Offset: 0x000984F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566434, XrefRangeEnd = 566445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000844 RID: 2116
			// (get) Token: 0x06002225 RID: 8741 RVA: 0x0009A32C File Offset: 0x0009852C
			public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
				}
			}

			// Token: 0x06002226 RID: 8742 RVA: 0x0009A36C File Offset: 0x0009856C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566445, XrefRangeEnd = 566450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000845 RID: 2117
			// (get) Token: 0x06002227 RID: 8743 RVA: 0x0009A3A0 File Offset: 0x000985A0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002228 RID: 8744 RVA: 0x0009A3E0 File Offset: 0x000985E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566450, XrefRangeEnd = 566452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06002229 RID: 8745 RVA: 0x0009A420 File Offset: 0x00098620
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._OnCompletedSelection_d__18.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600222A RID: 8746 RVA: 0x000105E0 File Offset: 0x0000E7E0
			public _OnCompletedSelection_d__18(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000840 RID: 2112
			// (get) Token: 0x0600222B RID: 8747 RVA: 0x0009A460 File Offset: 0x00098660
			// (set) Token: 0x0600222C RID: 8748 RVA: 0x000105E9 File Offset: 0x0000E7E9
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._OnCompletedSelection_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._OnCompletedSelection_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000841 RID: 2113
			// (get) Token: 0x0600222D RID: 8749 RVA: 0x0009A488 File Offset: 0x00098688
			// (set) Token: 0x0600222E RID: 8750 RVA: 0x00010604 File Offset: 0x0000E804
			public unsafe Canis.actions.Action __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._OnCompletedSelection_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._OnCompletedSelection_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000842 RID: 2114
			// (get) Token: 0x0600222F RID: 8751 RVA: 0x0009A4B8 File Offset: 0x000986B8
			// (set) Token: 0x06002230 RID: 8752 RVA: 0x00010623 File Offset: 0x0000E823
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._OnCompletedSelection_d__18.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._OnCompletedSelection_d__18.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000843 RID: 2115
			// (get) Token: 0x06002231 RID: 8753 RVA: 0x0009A4E0 File Offset: 0x000986E0
			// (set) Token: 0x06002232 RID: 8754 RVA: 0x0001063E File Offset: 0x0000E83E
			public unsafe PlayerEntity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._OnCompletedSelection_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._OnCompletedSelection_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001575 RID: 5493
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001576 RID: 5494
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001577 RID: 5495
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001578 RID: 5496
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001579 RID: 5497
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400157A RID: 5498
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400157B RID: 5499
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400157C RID: 5500
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

			// Token: 0x0400157D RID: 5501
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400157E RID: 5502
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400157F RID: 5503
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

			// Token: 0x04001580 RID: 5504
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000335 RID: 821
		[ObfuscatedName("Canis.entities.PlayerEntity+<SelectFrom>d__26")]
		public sealed class _SelectFrom_d__26 : Object
		{
			// Token: 0x06002233 RID: 8755 RVA: 0x0009A510 File Offset: 0x00098710
			// Note: this type is marked as 'beforefieldinit'.
			static _SelectFrom_d__26()
			{
				Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerEntity>.NativeClassPtr, "<SelectFrom>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr);
				PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr, "<>1__state");
				PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr, "<>2__current");
				PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr_selection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr, "selection");
				PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr, "<>4__this");
				PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr__mainExecutionStack_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr, "<mainExecutionStack>5__2");
				PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr__message_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr, "<message>5__3");
				PlayerEntity._SelectFrom_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr, 100665597);
				PlayerEntity._SelectFrom_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr, 100665598);
				PlayerEntity._SelectFrom_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr, 100665599);
				PlayerEntity._SelectFrom_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr, 100665600);
				PlayerEntity._SelectFrom_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr, 100665601);
				PlayerEntity._SelectFrom_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr, 100665602);
			}

			// Token: 0x06002234 RID: 8756 RVA: 0x0009A62C File Offset: 0x0009882C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SelectFrom_d__26(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerEntity._SelectFrom_d__26>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._SelectFrom_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002235 RID: 8757 RVA: 0x0009A674 File Offset: 0x00098874
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._SelectFrom_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002236 RID: 8758 RVA: 0x0009A6A8 File Offset: 0x000988A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566452, XrefRangeEnd = 566466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._SelectFrom_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700084C RID: 2124
			// (get) Token: 0x06002237 RID: 8759 RVA: 0x0009A6E4 File Offset: 0x000988E4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._SelectFrom_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002238 RID: 8760 RVA: 0x0009A724 File Offset: 0x00098924
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 566466, XrefRangeEnd = 566471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._SelectFrom_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700084D RID: 2125
			// (get) Token: 0x06002239 RID: 8761 RVA: 0x0009A758 File Offset: 0x00098958
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerEntity._SelectFrom_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600223A RID: 8762 RVA: 0x0001065D File Offset: 0x0000E85D
			public _SelectFrom_d__26(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000846 RID: 2118
			// (get) Token: 0x0600223B RID: 8763 RVA: 0x0009A798 File Offset: 0x00098998
			// (set) Token: 0x0600223C RID: 8764 RVA: 0x00010666 File Offset: 0x0000E866
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000847 RID: 2119
			// (get) Token: 0x0600223D RID: 8765 RVA: 0x0009A7C0 File Offset: 0x000989C0
			// (set) Token: 0x0600223E RID: 8766 RVA: 0x00010681 File Offset: 0x0000E881
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000848 RID: 2120
			// (get) Token: 0x0600223F RID: 8767 RVA: 0x0009A7F0 File Offset: 0x000989F0
			// (set) Token: 0x06002240 RID: 8768 RVA: 0x000106A0 File Offset: 0x0000E8A0
			public unsafe SelectionMessage selection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr_selection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SelectionMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr_selection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000849 RID: 2121
			// (get) Token: 0x06002241 RID: 8769 RVA: 0x0009A820 File Offset: 0x00098A20
			// (set) Token: 0x06002242 RID: 8770 RVA: 0x000106BF File Offset: 0x0000E8BF
			public unsafe PlayerEntity __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerEntity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084A RID: 2122
			// (get) Token: 0x06002243 RID: 8771 RVA: 0x0009A850 File Offset: 0x00098A50
			// (set) Token: 0x06002244 RID: 8772 RVA: 0x000106DE File Offset: 0x0000E8DE
			public unsafe IHasExecutionStack _mainExecutionStack_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr__mainExecutionStack_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasExecutionStack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr__mainExecutionStack_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700084B RID: 2123
			// (get) Token: 0x06002245 RID: 8773 RVA: 0x0009A880 File Offset: 0x00098A80
			// (set) Token: 0x06002246 RID: 8774 RVA: 0x000106FD File Offset: 0x0000E8FD
			public unsafe ISelectionCounter _message_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr__message_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISelectionCounter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerEntity._SelectFrom_d__26.NativeFieldInfoPtr__message_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001581 RID: 5505
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001582 RID: 5506
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001583 RID: 5507
			private static readonly IntPtr NativeFieldInfoPtr_selection;

			// Token: 0x04001584 RID: 5508
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001585 RID: 5509
			private static readonly IntPtr NativeFieldInfoPtr__mainExecutionStack_5__2;

			// Token: 0x04001586 RID: 5510
			private static readonly IntPtr NativeFieldInfoPtr__message_5__3;

			// Token: 0x04001587 RID: 5511
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001588 RID: 5512
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001589 RID: 5513
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400158A RID: 5514
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400158B RID: 5515
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400158C RID: 5516
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
