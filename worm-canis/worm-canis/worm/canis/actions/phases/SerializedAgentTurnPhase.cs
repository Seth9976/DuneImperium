using System;
using Canis;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Networking.selection.messages.outgoing;

namespace worm.canis.actions.phases
{
	// Token: 0x020002B1 RID: 689
	public class SerializedAgentTurnPhase : SerializedStateMachineAction
	{
		// Token: 0x06001C80 RID: 7296 RVA: 0x000C7BEC File Offset: 0x000C5DEC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedAgentTurnPhase()
		{
			Il2CppClassPointerStore<SerializedAgentTurnPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedAgentTurnPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedAgentTurnPhase>.NativeClassPtr);
			SerializedAgentTurnPhase.NativeFieldInfoPtr_AgentSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAgentTurnPhase>.NativeClassPtr, "AgentSelection");
			SerializedAgentTurnPhase.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAgentTurnPhase>.NativeClassPtr, "PlayerID");
			SerializedAgentTurnPhase.NativeFieldInfoPtr_ChosenSpaceAbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAgentTurnPhase>.NativeClassPtr, "ChosenSpaceAbilityID");
			SerializedAgentTurnPhase.NativeFieldInfoPtr_ChosenAgentAbilityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAgentTurnPhase>.NativeClassPtr, "ChosenAgentAbilityID");
			SerializedAgentTurnPhase.NativeFieldInfoPtr_ChosenAgentAbilityIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAgentTurnPhase>.NativeClassPtr, "ChosenAgentAbilityIDs");
			SerializedAgentTurnPhase.NativeFieldInfoPtr_UndoNodeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAgentTurnPhase>.NativeClassPtr, "UndoNodeID");
			SerializedAgentTurnPhase.NativeFieldInfoPtr_ChosenAgentID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedAgentTurnPhase>.NativeClassPtr, "ChosenAgentID");
			SerializedAgentTurnPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAgentTurnPhase>.NativeClassPtr, 100669268);
			SerializedAgentTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedAgentTurnPhase>.NativeClassPtr, 100669269);
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x000C7CD0 File Offset: 0x000C5ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152501, XrefRangeEnd = 152507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedAgentTurnPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x000C7D2C File Offset: 0x000C5F2C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedAgentTurnPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedAgentTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedAgentTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0000C111 File Offset: 0x0000A311
		public SerializedAgentTurnPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001C84 RID: 7300 RVA: 0x000C7D68 File Offset: 0x000C5F68
		// (set) Token: 0x06001C85 RID: 7301 RVA: 0x0000C11A File Offset: 0x0000A31A
		public unsafe EntityIDTargetResponses AgentSelection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_AgentSelection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityIDTargetResponses>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_AgentSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001C86 RID: 7302 RVA: 0x000C7D98 File Offset: 0x000C5F98
		// (set) Token: 0x06001C87 RID: 7303 RVA: 0x0000C139 File Offset: 0x0000A339
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001C88 RID: 7304 RVA: 0x000C7DC8 File Offset: 0x000C5FC8
		// (set) Token: 0x06001C89 RID: 7305 RVA: 0x0000C158 File Offset: 0x0000A358
		public unsafe EntityID ChosenSpaceAbilityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_ChosenSpaceAbilityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_ChosenSpaceAbilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001C8A RID: 7306 RVA: 0x000C7DF8 File Offset: 0x000C5FF8
		// (set) Token: 0x06001C8B RID: 7307 RVA: 0x0000C177 File Offset: 0x0000A377
		public unsafe EntityID ChosenAgentAbilityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_ChosenAgentAbilityID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_ChosenAgentAbilityID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001C8C RID: 7308 RVA: 0x000C7E28 File Offset: 0x000C6028
		// (set) Token: 0x06001C8D RID: 7309 RVA: 0x0000C196 File Offset: 0x0000A396
		public unsafe List<EntityID> ChosenAgentAbilityIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_ChosenAgentAbilityIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_ChosenAgentAbilityIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001C8E RID: 7310 RVA: 0x000C7E58 File Offset: 0x000C6058
		// (set) Token: 0x06001C8F RID: 7311 RVA: 0x0000C1B5 File Offset: 0x0000A3B5
		public unsafe EntityID UndoNodeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_UndoNodeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_UndoNodeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06001C90 RID: 7312 RVA: 0x000C7E88 File Offset: 0x000C6088
		// (set) Token: 0x06001C91 RID: 7313 RVA: 0x0000C1D4 File Offset: 0x0000A3D4
		public unsafe EntityID ChosenAgentID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_ChosenAgentID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedAgentTurnPhase.NativeFieldInfoPtr_ChosenAgentID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011A9 RID: 4521
		private static readonly IntPtr NativeFieldInfoPtr_AgentSelection;

		// Token: 0x040011AA RID: 4522
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeFieldInfoPtr_ChosenSpaceAbilityID;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeFieldInfoPtr_ChosenAgentAbilityID;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeFieldInfoPtr_ChosenAgentAbilityIDs;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeFieldInfoPtr_UndoNodeID;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeFieldInfoPtr_ChosenAgentID;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
