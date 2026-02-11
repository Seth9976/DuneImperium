using System;
using Canis;
using Canis.actions;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.actions.phases
{
	// Token: 0x020002D2 RID: 722
	public class SerializedRevealTurnPhase : SerializedStateMachineAction
	{
		// Token: 0x06001DC1 RID: 7617 RVA: 0x000CCFC0 File Offset: 0x000CB1C0
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedRevealTurnPhase()
		{
			Il2CppClassPointerStore<SerializedRevealTurnPhase>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions.phases", "SerializedRevealTurnPhase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedRevealTurnPhase>.NativeClassPtr);
			SerializedRevealTurnPhase.NativeFieldInfoPtr_PlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRevealTurnPhase>.NativeClassPtr, "PlayerID");
			SerializedRevealTurnPhase.NativeFieldInfoPtr_InitialReveal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRevealTurnPhase>.NativeClassPtr, "InitialReveal");
			SerializedRevealTurnPhase.NativeFieldInfoPtr_RevealedCardIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRevealTurnPhase>.NativeClassPtr, "RevealedCardIDs");
			SerializedRevealTurnPhase.NativeFieldInfoPtr_RevealLogID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRevealTurnPhase>.NativeClassPtr, "RevealLogID");
			SerializedRevealTurnPhase.NativeFieldInfoPtr_UndoNodeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedRevealTurnPhase>.NativeClassPtr, "UndoNodeID");
			SerializedRevealTurnPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRevealTurnPhase>.NativeClassPtr, 100669987);
			SerializedRevealTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedRevealTurnPhase>.NativeClassPtr, 100669988);
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x000CD07C File Offset: 0x000CB27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164285, XrefRangeEnd = 164291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override StateMachineAction GenStateMachineAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedRevealTurnPhase.NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StateMachineAction>(intPtr3) : null;
			}
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x000CD0D8 File Offset: 0x000CB2D8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 146959, RefRangeEnd = 146969, XrefRangeStart = 146959, XrefRangeEnd = 146969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedRevealTurnPhase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedRevealTurnPhase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedRevealTurnPhase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x0000C7FF File Offset: 0x0000A9FF
		public SerializedRevealTurnPhase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x000CD114 File Offset: 0x000CB314
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x0000C808 File Offset: 0x0000AA08
		public unsafe EntityID PlayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRevealTurnPhase.NativeFieldInfoPtr_PlayerID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRevealTurnPhase.NativeFieldInfoPtr_PlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x000CD144 File Offset: 0x000CB344
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x0000C827 File Offset: 0x0000AA27
		public unsafe bool InitialReveal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRevealTurnPhase.NativeFieldInfoPtr_InitialReveal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRevealTurnPhase.NativeFieldInfoPtr_InitialReveal)) = value;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x000CD16C File Offset: 0x000CB36C
		// (set) Token: 0x06001DCA RID: 7626 RVA: 0x0000C842 File Offset: 0x0000AA42
		public unsafe List<EntityID> RevealedCardIDs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRevealTurnPhase.NativeFieldInfoPtr_RevealedCardIDs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRevealTurnPhase.NativeFieldInfoPtr_RevealedCardIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x000CD19C File Offset: 0x000CB39C
		// (set) Token: 0x06001DCC RID: 7628 RVA: 0x0000C861 File Offset: 0x0000AA61
		public Nullable<int> RevealLogID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRevealTurnPhase.NativeFieldInfoPtr_RevealLogID);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRevealTurnPhase.NativeFieldInfoPtr_RevealLogID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x000CD1CC File Offset: 0x000CB3CC
		// (set) Token: 0x06001DCE RID: 7630 RVA: 0x0000C88F File Offset: 0x0000AA8F
		public unsafe EntityID UndoNodeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRevealTurnPhase.NativeFieldInfoPtr_UndoNodeID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedRevealTurnPhase.NativeFieldInfoPtr_UndoNodeID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeFieldInfoPtr_PlayerID;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeFieldInfoPtr_InitialReveal;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeFieldInfoPtr_RevealedCardIDs;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeFieldInfoPtr_RevealLogID;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeFieldInfoPtr_UndoNodeID;

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeMethodInfoPtr_GenStateMachineAction_Protected_Virtual_StateMachineAction_Match_0;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
